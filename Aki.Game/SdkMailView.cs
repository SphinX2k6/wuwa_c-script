using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001EE9 RID: 7913
[NullableContext(1)]
[Nullable(0)]
public class SdkMailView : UiTickViewBase
{
	// Token: 0x0601389E RID: 80030 RVA: 0x005B1F3F File Offset: 0x005B013F
	public SdkMailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0601389F RID: 80031 RVA: 0x005B1F60 File Offset: 0x005B0160
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITextInputComponent)),
			new ValueTuple<int, Type>(2, typeof(UUITextInputComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(8, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(9, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(10, typeof(UUIText)),
			new ValueTuple<int, Type>(11, typeof(UUIText)),
			new ValueTuple<int, Type>(12, typeof(UUIText)),
			new ValueTuple<int, Type>(13, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnClickCancelButton)),
			new ValueTuple<int, Delegate>(9, new Action(this.OnClickConfirmButton)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickProtocolButton1)),
			new ValueTuple<int, Delegate>(4, new Action(this.OnClickProtocolButton2)),
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickProtocolButton3)),
			new ValueTuple<int, Delegate>(8, new Action(this.OnClickSendCodeButton)),
			new ValueTuple<int, Delegate>(7, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x060138A0 RID: 80032 RVA: 0x005B2168 File Offset: 0x005B0368
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as SdkMailViewData);
		this.ProtocolButtonArray = new List<UUIButtonComponent>
		{
			base.GetButton(3),
			base.GetButton(4),
			base.GetButton(5)
		};
		this.ProtocolTextArray = new List<UUIText>
		{
			base.GetText(10),
			base.GetText(11),
			base.GetText(12)
		};
		this.RefreshSendCodeButton();
		this.RefreshProtocolItems();
		PlatformReportLoginWindow eventData = new PlatformReportLoginWindow();
		PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
		this.RefreshConfirmButtonState();
		UUITextInputComponent inputText = base.GetInputText(1);
		if (inputText != null)
		{
			inputText.OnTextChange.Bind(new Action<string>(this.OnInputTextChange));
		}
		UUITextInputComponent inputText2 = base.GetInputText(2);
		if (inputText2 != null)
		{
			inputText2.OnTextChange.Bind(new Action<string>(this.OnInputTextChange));
		}
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (extendToggle != null)
		{
			extendToggle.OnStateChange.Add(new Action<EToggleState>(this.OnToggleStateChange));
		}
	}

	// Token: 0x060138A1 RID: 80033 RVA: 0x005B227B File Offset: 0x005B047B
	private void OnToggleStateChange(EToggleState state)
	{
		this.RefreshConfirmButtonState();
	}

	// Token: 0x060138A2 RID: 80034 RVA: 0x005B2283 File Offset: 0x005B0483
	private void OnInputTextChange(string _)
	{
		this.RefreshConfirmButtonState();
	}

	// Token: 0x060138A3 RID: 80035 RVA: 0x005B228C File Offset: 0x005B048C
	private void OnToggleClick(EToggleState _)
	{
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (extendToggle == null)
		{
			return;
		}
		if (extendToggle.GetToggleState() == EToggleState.ETT_Checked)
		{
			PlatformReportClickProtocol eventData = new PlatformReportClickProtocol();
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
		}
	}

	// Token: 0x060138A4 RID: 80036 RVA: 0x005B22C4 File Offset: 0x005B04C4
	private void OnClickSendCodeButton()
	{
		if (TimeUtil.Instance.GetServerTime() - this.SendCodeTime < 60.0)
		{
			return;
		}
		UUITextInputComponent inputText = base.GetInputText(1);
		if (inputText == null)
		{
			return;
		}
		string text = inputText.GetText();
		if (!new Regex("^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$").IsMatch(text))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PSN_Tip_MailNotValid", Array.Empty<object>());
			return;
		}
		this.SendCodeToSdkServer(text);
	}

	// Token: 0x060138A5 RID: 80037 RVA: 0x005B2330 File Offset: 0x005B0530
	private void RefreshConfirmButtonState()
	{
		UUITextInputComponent inputText = base.GetInputText(1);
		UUITextInputComponent inputText2 = base.GetInputText(2);
		UUIExtendToggle extendToggle = base.GetExtendToggle(7);
		if (inputText == null || inputText2 == null || extendToggle == null)
		{
			return;
		}
		string text = inputText.GetText();
		string text2 = inputText2.GetText();
		EToggleState toggleState = extendToggle.GetToggleState();
		if (text.Length > 0 && text2.Length > 0 && toggleState == EToggleState.ETT_Checked)
		{
			UUIButtonComponent button = base.GetButton(9);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(true);
			return;
		}
		else
		{
			UUIButtonComponent button2 = base.GetButton(9);
			if (button2 == null)
			{
				return;
			}
			button2.SetSelfInteractive(false);
			return;
		}
	}

	// Token: 0x060138A6 RID: 80038 RVA: 0x005B23B4 File Offset: 0x005B05B4
	private UniTask SendCodeToSdkServer(string mailAddress)
	{
		SdkMailView.<SendCodeToSdkServer>d__13 <SendCodeToSdkServer>d__;
		<SendCodeToSdkServer>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<SendCodeToSdkServer>d__.<>4__this = this;
		<SendCodeToSdkServer>d__.mailAddress = mailAddress;
		<SendCodeToSdkServer>d__.<>1__state = -1;
		<SendCodeToSdkServer>d__.<>t__builder.Start<SdkMailView.<SendCodeToSdkServer>d__13>(ref <SendCodeToSdkServer>d__);
		return <SendCodeToSdkServer>d__.<>t__builder.Task;
	}

	// Token: 0x060138A7 RID: 80039 RVA: 0x005B2400 File Offset: 0x005B0600
	private void RefreshProtocolItems()
	{
		for (int i = 0; i < this.ProtocolButtonArray.Count; i++)
		{
			UUIItem uuiitem = this.ProtocolButtonArray[i].RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(false);
			}
			this.ProtocolTextArray[i].SetUIActive(false);
		}
		if (this.ViewData != null)
		{
			for (int j = 0; j < this.ProtocolButtonArray.Count; j++)
			{
				if (j < this.ViewData.ProtocolData.Count)
				{
					UUIItem uuiitem2 = this.ProtocolButtonArray[j].RootUIComp.Get();
					if (uuiitem2 != null)
					{
						uuiitem2.SetUIActive(true);
					}
					this.ProtocolTextArray[j].SetUIActive(true);
					this.ProtocolTextArray[j].SetText(this.ViewData.ProtocolData[j].Title, true);
				}
				else
				{
					UUIItem uuiitem3 = this.ProtocolButtonArray[j].RootUIComp.Get();
					if (uuiitem3 != null)
					{
						uuiitem3.SetUIActive(false);
					}
					this.ProtocolTextArray[j].SetUIActive(false);
				}
			}
		}
	}

	// Token: 0x060138A8 RID: 80040 RVA: 0x005B252C File Offset: 0x005B072C
	private void OnClickCancelButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x060138A9 RID: 80041 RVA: 0x005B2538 File Offset: 0x005B0738
	private void OnClickConfirmButton()
	{
		UUITextInputComponent inputText = base.GetInputText(1);
		if (inputText == null)
		{
			return;
		}
		string mailAddress = inputText.GetText();
		if (!new Regex("^[^\\s@]+@[^\\s@]+\\.[^\\s@]+$").IsMatch(mailAddress))
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PSN_Tip_MailNotValid", Array.Empty<object>());
			return;
		}
		UUITextInputComponent inputText2 = base.GetInputText(2);
		if (inputText2 == null)
		{
			return;
		}
		string code = inputText2.GetText();
		if (code.Length != 6)
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("PSN_Tip_MailCodeError", Array.Empty<object>());
			return;
		}
		SdkLoadPopUpViewData param = SdkLoadPopUpViewData.Create(5, "Sdk_Bind_Mail_Loading");
		UiManager.Instance.OpenView(EUiViewName.SdkLoadPopUpView, param, delegate(bool isSuccess, int _)
		{
			PlatformReportClickLogin eventData = new PlatformReportClickLogin();
			PlatformSdkManagerNew.Instance.GetPlatformSdk().ReportToThirdParty(eventData);
			PlatformSdkManagerNew.Instance.GetPlatformSdk().BindAccountThenLogin(delegate(string msg, bool needReLogin, bool needSelectLoginFunction, [Nullable(2)] ILoginResponseData data)
			{
				if (data != null)
				{
					UiManager.Instance.CloseView(EUiViewName.SdkMailView, null);
					UiManager.Instance.CloseView(EUiViewName.SdkLoginView, null);
					LoginController.Instance.OnSdkLoginResult(data.code, data.cuid, data.username);
				}
				else if (data == null && msg != "" && msg != PlatformSdkServerMsg.BadHttp.ToEnumString())
				{
					ScrollingTipsController.Instance.ShowTipsByText(msg);
				}
				else if (data == null)
				{
					ConfirmBoxDataNew confirmBoxDataNew = new ConfirmBoxDataNew(EConfirmBoxConfigId.SdkServerNetworkError);
					ConfirmBoxController.Instance.ShowNetWorkConfirmBoxView(confirmBoxDataNew, null);
				}
				UiManager.Instance.CloseView(EUiViewName.SdkLoadPopUpView, null);
			}, mailAddress, code);
		});
	}

	// Token: 0x060138AA RID: 80042 RVA: 0x005B25F4 File Offset: 0x005B07F4
	private void OnClickProtocolButton1()
	{
		if (this.ViewData != null && this.ViewData.ProtocolData.Count > 0)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", this.ViewData.ProtocolData[0].Url, true, true, true);
		}
	}

	// Token: 0x060138AB RID: 80043 RVA: 0x005B2644 File Offset: 0x005B0844
	private void OnClickProtocolButton2()
	{
		if (this.ViewData != null && this.ViewData.ProtocolData.Count > 1)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", this.ViewData.ProtocolData[1].Url, true, true, true);
		}
	}

	// Token: 0x060138AC RID: 80044 RVA: 0x005B2694 File Offset: 0x005B0894
	private void OnClickProtocolButton3()
	{
		if (this.ViewData != null && this.ViewData.ProtocolData.Count > 2)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", this.ViewData.ProtocolData[2].Url, true, true, true);
		}
	}

	// Token: 0x060138AD RID: 80045 RVA: 0x005B26E4 File Offset: 0x005B08E4
	private void RefreshSendCodeButton()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		UUITextInputComponent inputText = base.GetInputText(1);
		if (inputText == null)
		{
			return;
		}
		string text = inputText.GetText();
		if (serverTime - this.SendCodeTime < 60.0 || text.Length == 0)
		{
			UUIButtonComponent button = base.GetButton(8);
			if (button == null)
			{
				return;
			}
			button.SetSelfInteractive(false);
			return;
		}
		else
		{
			UUIButtonComponent button2 = base.GetButton(8);
			if (button2 == null)
			{
				return;
			}
			button2.SetSelfInteractive(true);
			return;
		}
	}

	// Token: 0x060138AE RID: 80046 RVA: 0x005B2750 File Offset: 0x005B0950
	private void RefreshCountDownText()
	{
		double serverTime = TimeUtil.Instance.GetServerTime();
		int num = (int)(60.0 - (serverTime - this.SendCodeTime));
		UUIText text = base.GetText(13);
		if (text == null)
		{
			return;
		}
		if (num <= 0)
		{
			text.ShowTextNew("Send_MailCode");
			return;
		}
		LguiUtil.Instance.SetLocalTextNew(text, "Send_MailCode_Cd", new <>z__ReadOnlySingleElementList<object>(num.ToString()));
	}

	// Token: 0x060138AF RID: 80047 RVA: 0x005B27B5 File Offset: 0x005B09B5
	protected override void OnTick(float delta)
	{
		this.RefreshSendCodeButton();
		this.RefreshCountDownText();
	}

	// Token: 0x0400A707 RID: 42759
	private double SendCodeTime;

	// Token: 0x0400A708 RID: 42760
	private List<UUIButtonComponent> ProtocolButtonArray = new List<UUIButtonComponent>();

	// Token: 0x0400A709 RID: 42761
	private List<UUIText> ProtocolTextArray = new List<UUIText>();

	// Token: 0x0400A70A RID: 42762
	[Nullable(2)]
	private SdkMailViewData ViewData;

	// Token: 0x02008177 RID: 33143
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029D93 RID: 171411
		BackButton,
		// Token: 0x04029D94 RID: 171412
		AccountInput,
		// Token: 0x04029D95 RID: 171413
		CodeInput,
		// Token: 0x04029D96 RID: 171414
		ProtocolButton1,
		// Token: 0x04029D97 RID: 171415
		ProtocolButton2,
		// Token: 0x04029D98 RID: 171416
		ProtocolButton3,
		// Token: 0x04029D99 RID: 171417
		ExtendToggleParent,
		// Token: 0x04029D9A RID: 171418
		AgreeToggle,
		// Token: 0x04029D9B RID: 171419
		SendCodeButton,
		// Token: 0x04029D9C RID: 171420
		ConfirmButton,
		// Token: 0x04029D9D RID: 171421
		ProtocolText1,
		// Token: 0x04029D9E RID: 171422
		ProtocolText2,
		// Token: 0x04029D9F RID: 171423
		ProtocolText3,
		// Token: 0x04029DA0 RID: 171424
		ConfirmBoxText
	}
}
