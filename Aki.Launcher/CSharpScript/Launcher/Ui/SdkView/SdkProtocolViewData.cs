using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Launcher.BaseConfig;
using CSharpScript.Launcher.Platform.PlatformSdk;

namespace CSharpScript.Launcher.Ui.SdkView
{
	// Token: 0x020000CC RID: 204
	[NullableContext(1)]
	[Nullable(0)]
	public class SdkProtocolViewData
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x00039CD4 File Offset: 0x00037ED4
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

		// Token: 0x060006BE RID: 1726 RVA: 0x00039E61 File Offset: 0x00038061
		private static void OpenWebView(SdkProtocolView owner, string url)
		{
			PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
			if (platformSdk == null)
			{
				return;
			}
			platformSdk.OpenWebView(url, null);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00039E79 File Offset: 0x00038079
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

		// Token: 0x04000431 RID: 1073
		public string TitleId = "";

		// Token: 0x04000432 RID: 1074
		public string DescTextId = "";

		// Token: 0x04000433 RID: 1075
		[Nullable(2)]
		public Action EnterCallback;

		// Token: 0x04000434 RID: 1076
		[Nullable(2)]
		public Action CancelCallback;

		// Token: 0x04000435 RID: 1077
		public List<SdkProtocolViewLayoutData> LayoutData = new List<SdkProtocolViewLayoutData>();
	}
}
