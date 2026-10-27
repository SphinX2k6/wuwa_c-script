using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000C9 RID: 201
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkProtocolViewData
	{
		// Token: 0x060006A1 RID: 1697 RVA: 0x000381A4 File Offset: 0x000363A4
		public static SdkProtocolViewData CreateViewData(Action enterCallback, Action cancelCallback)
		{
			bool flag = BaseConfigController.Instance.GetPublicValue("SdkArea") != "CN";
			List<SdkProtocolViewLayoutData> list = new List<SdkProtocolViewLayoutData>();
			if (flag)
			{
				string teamOfService = PlatformSdkConfig.Instance.GetTermsOfService();
				string privacyPolicy = PlatformSdkConfig.Instance.GetPrivacyPolicy();
				if (!string.IsNullOrEmpty(teamOfService))
				{
					list.Add(SdkProtocolViewLayoutData.CreateLayoutData("UserProtocol", "手柄LT", delegate(SdkProtocolView owner)
					{
						SdkProtocolViewData.OpenWebView(owner, teamOfService);
					}));
				}
				if (!string.IsNullOrEmpty(privacyPolicy))
				{
					list.Add(SdkProtocolViewLayoutData.CreateLayoutData("PrivacyPolicy", "手柄RT", delegate(SdkProtocolView owner)
					{
						SdkProtocolViewData.OpenWebView(owner, privacyPolicy);
					}));
				}
			}
			else
			{
				string teamOfService = PlatformSdkConfig.Instance.GetTermsOfService();
				string privacyPolicy = PlatformSdkConfig.Instance.GetPrivacyPolicy();
				string childPolicy = PlatformSdkConfig.Instance.GetChildPolicy();
				if (!string.IsNullOrEmpty(teamOfService))
				{
					list.Add(SdkProtocolViewLayoutData.CreateLayoutData("UserProtocol", "手柄LT", delegate(SdkProtocolView owner)
					{
						SdkProtocolViewData.OpenWebView(owner, teamOfService);
					}));
				}
				if (!string.IsNullOrEmpty(privacyPolicy))
				{
					list.Add(SdkProtocolViewLayoutData.CreateLayoutData("PrivacyPolicy", "手柄RT", delegate(SdkProtocolView owner)
					{
						SdkProtocolViewData.OpenWebView(owner, privacyPolicy);
					}));
				}
				if (!string.IsNullOrEmpty(childPolicy))
				{
					list.Add(SdkProtocolViewLayoutData.CreateLayoutData("ChildProtocol", "手柄右边上键", delegate(SdkProtocolView owner)
					{
						SdkProtocolViewData.OpenWebView(owner, childPolicy);
					}));
				}
			}
			return SdkProtocolViewData.Create("SdkProtocolTitle", "SdkProtocolDesc", enterCallback, cancelCallback, list);
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x00038331 File Offset: 0x00036531
		private static void OpenWebView(SdkProtocolView owner, string url)
		{
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.OpenWebView(url, null);
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x00038349 File Offset: 0x00036549
		public static SdkProtocolViewData Create(string titleId, string descTextId, Action enterCallback, Action cancelCallback, List<SdkProtocolViewLayoutData> layoutData)
		{
			return new SdkProtocolViewData
			{
				TitleId = titleId,
				DescTextId = descTextId,
				EnterCallback = enterCallback,
				CancelCallback = cancelCallback,
				LayoutData = layoutData
			};
		}

		// Token: 0x04000402 RID: 1026
		public string TitleId = "";

		// Token: 0x04000403 RID: 1027
		public string DescTextId = "";

		// Token: 0x04000404 RID: 1028
		[Nullable(2)]
		public Action EnterCallback;

		// Token: 0x04000405 RID: 1029
		[Nullable(2)]
		public Action CancelCallback;

		// Token: 0x04000406 RID: 1030
		public List<SdkProtocolViewLayoutData> LayoutData = new List<SdkProtocolViewLayoutData>();
	}
}
