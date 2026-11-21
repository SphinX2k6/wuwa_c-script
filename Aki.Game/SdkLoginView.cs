using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x02001EE8 RID: 7912
public class SdkLoginView : UiViewBase
{
	// Token: 0x06013898 RID: 80024 RVA: 0x005B1CBC File Offset: 0x005AFEBC
	[NullableContext(1)]
	public SdkLoginView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06013899 RID: 80025 RVA: 0x005B1CC8 File Offset: 0x005AFEC8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(2, typeof(UUIText)),
			new ValueTuple<int, Type>(3, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCancelButton)),
			new ValueTuple<int, Delegate>(1, new Action(this.OnClickCreateButton)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickLoginButton))
		};
	}

	// Token: 0x0601389A RID: 80026 RVA: 0x005B1DA4 File Offset: 0x005AFFA4
	protected override void OnAfterShow()
	{
		PlatformReportSelectLogin eventData = new PlatformReportSelectLogin();
		PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
	}

	// Token: 0x0601389B RID: 80027 RVA: 0x005B1DC7 File Offset: 0x005AFFC7
	private void OnClickCancelButton()
	{
		LoginModel.Instance.SetSdkLoginState(LoginDefine.ESdkLoginState.Logout);
		base.CloseMe(null);
	}

	// Token: 0x0601389C RID: 80028 RVA: 0x005B1DDC File Offset: 0x005AFFDC
	private void OnClickCreateButton()
	{
		SdkPopUpViewData sdkPopUpViewData = new SdkPopUpViewData();
		sdkPopUpViewData.ViewType = ESdkPopUpViewType.Creating;
		sdkPopUpViewData.NeedMask = true;
		sdkPopUpViewData.Text = ConfigMultiTextLang.GetLocalTextNew("CreatingAccount", null);
		UiManager.Instance.OpenView(EUiViewName.SdkTipsMiddlePopUpView, sdkPopUpViewData, delegate(bool isSuccess, int _)
		{
			PlatformReportCreateNewAccount eventData = new PlatformReportCreateNewAccount();
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
			PlatformSdkManagerNew.Instance.GetPlatformSdk().BindAccountThenLogin(delegate(string msg, bool needReLogin, bool needSelectLoginFunction, [Nullable(2)] ILoginResponseData data)
			{
				UiManager.Instance.CloseView(EUiViewName.SdkTipsMiddlePopUpView, null);
				if (data != null)
				{
					UiManager.Instance.CloseView(EUiViewName.SdkLoginView, null);
					LoginController.Instance.OnSdkLoginResult(data.code, data.cuid, data.username);
					return;
				}
				if (data == null && msg != "" && msg != PlatformSdkServerMsg.BadHttp.ToEnumString())
				{
					ScrollingTipsController.Instance.ShowTipsByText(msg);
					return;
				}
				if (data == null)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SdkServerNetworkError);
					ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
				}
			}, "", "");
		});
	}

	// Token: 0x0601389D RID: 80029 RVA: 0x005B1E44 File Offset: 0x005B0044
	private void OnClickLoginButton()
	{
		PlatformReportClickOldAccount eventData = new PlatformReportClickOldAccount();
		PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
		SdkMailViewData sdkMailViewData = new SdkMailViewData();
		string privacyPolicy = PlatformSdkConfig.Instance.GetPrivacyPolicy();
		string termsOfService = PlatformSdkConfig.Instance.GetTermsOfService();
		string childPolicy = PlatformSdkConfig.Instance.GetChildPolicy();
		if (termsOfService != null && termsOfService != "")
		{
			string localTextNew = ConfigMultiTextLang.GetLocalTextNew("MenuConfig_114_Name", null);
			SdkProtocolData item = SdkProtocolData.Create(termsOfService, localTextNew);
			sdkMailViewData.ProtocolData.Add(item);
		}
		if (privacyPolicy != null && privacyPolicy != "")
		{
			string localTextNew2 = ConfigMultiTextLang.GetLocalTextNew("MenuConfig_115_Name", null);
			SdkProtocolData item2 = SdkProtocolData.Create(privacyPolicy, localTextNew2);
			sdkMailViewData.ProtocolData.Add(item2);
		}
		if (childPolicy != null && childPolicy != "")
		{
			string localTextNew3 = ConfigMultiTextLang.GetLocalTextNew("MenuConfig_116_Name", null);
			SdkProtocolData item3 = SdkProtocolData.Create(childPolicy, localTextNew3);
			sdkMailViewData.ProtocolData.Add(item3);
		}
		UiManager.Instance.OpenView(EUiViewName.SdkMailView, sdkMailViewData, null);
	}

	// Token: 0x02008175 RID: 33141
	private enum EComponent
	{
		// Token: 0x04029D8A RID: 171402
		CancelButton,
		// Token: 0x04029D8B RID: 171403
		CreateButton,
		// Token: 0x04029D8C RID: 171404
		DescText,
		// Token: 0x04029D8D RID: 171405
		VerticalLayout,
		// Token: 0x04029D8E RID: 171406
		LoginButton
	}
}
