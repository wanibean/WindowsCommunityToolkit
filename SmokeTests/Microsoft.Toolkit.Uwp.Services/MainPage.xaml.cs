// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.Toolkit.Uwp.Services.Facebook;

namespace SmokeTest
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ConnectButton_OnClick(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            try
            {
                FacebookService.Instance.Initialize(string.Empty);
            }
            catch (Exception ex)
            {
                textBlock.Text = ex.ToString();
            }
        }
    }
}
