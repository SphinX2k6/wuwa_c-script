using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200296E RID: 10606
[NullableContext(1)]
[Nullable(0)]
public class SdkMailView : UiTickViewBase
{
	// Token: 0x06015E9A RID: 89754 RVA: 0x00586F3B File Offset: 0x0058513B
	public SdkMailView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015E9B RID: 89755 RVA: 0x00586F5C File Offset: 0x0058515C
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

	// Token: 0x06015E9C RID: 89756 RVA: 0x00587164 File Offset: 0x00585364
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

	// Token: 0x06015E9D RID: 89757 RVA: 0x00587277 File Offset: 0x00585477
	private void OnToggleStateChange(EToggleState state)
	{
		this.RefreshConfirmButtonState();
	}

	// Token: 0x06015E9E RID: 89758 RVA: 0x0058727F File Offset: 0x0058547F
	private void OnInputTextChange(string _)
	{
		this.RefreshConfirmButtonState();
	}

	// Token: 0x06015E9F RID: 89759 RVA: 0x00587288 File Offset: 0x00585488
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

	// Token: 0x06015EA0 RID: 89760 RVA: 0x005872C0 File Offset: 0x005854C0
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

	// Token: 0x06015EA1 RID: 89761 RVA: 0x0058732C File Offset: 0x0058552C
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

	// Token: 0x06015EA2 RID: 89762 RVA: 0x005873B0 File Offset: 0x005855B0
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

	// Token: 0x06015EA3 RID: 89763 RVA: 0x005873FC File Offset: 0x005855FC
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

	// Token: 0x06015EA4 RID: 89764 RVA: 0x00587528 File Offset: 0x00585728
	private void OnClickCancelButton()
	{
		base.CloseMe(null);
	}

	// Token: 0x06015EA5 RID: 89765 RVA: 0x00587534 File Offset: 0x00585734
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

	// Token: 0x06015EA6 RID: 89766 RVA: 0x005875F0 File Offset: 0x005857F0
	private void OnClickProtocolButton1()
	{
		if (this.ViewData != null && this.ViewData.ProtocolData.Count > 0)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", this.ViewData.ProtocolData[0].Url, true, true, true);
		}
	}

	// Token: 0x06015EA7 RID: 89767 RVA: 0x00587640 File Offset: 0x00585840
	private void OnClickProtocolButton2()
	{
		if (this.ViewData != null && this.ViewData.ProtocolData.Count > 1)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", this.ViewData.ProtocolData[1].Url, true, true, true);
		}
	}

	// Token: 0x06015EA8 RID: 89768 RVA: 0x00587690 File Offset: 0x00585890
	private void OnClickProtocolButton3()
	{
		if (this.ViewData != null && this.ViewData.ProtocolData.Count > 2)
		{
			KuroSdkController.Instance.SdkOpenUrlWnd("", this.ViewData.ProtocolData[2].Url, true, true, true);
		}
	}

	// Token: 0x06015EA9 RID: 89769 RVA: 0x005876E0 File Offset: 0x005858E0
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

	// Token: 0x06015EAA RID: 89770 RVA: 0x0058774C File Offset: 0x0058594C
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

	// Token: 0x06015EAB RID: 89771 RVA: 0x005877B1 File Offset: 0x005859B1
	protected override void OnTick(float delta)
	{
		this.RefreshSendCodeButton();
		this.RefreshCountDownText();
	}

	// Token: 0x0400A31D RID: 41757
	private double SendCodeTime;

	// Token: 0x0400A31E RID: 41758
	private List<UUIButtonComponent> ProtocolButtonArray = new List<UUIButtonComponent>();

	// Token: 0x0400A31F RID: 41759
	private List<UUIText> ProtocolTextArray = new List<UUIText>();

	// Token: 0x0400A320 RID: 41760
	[Nullable(2)]
	private SdkMailViewData ViewData;

	// Token: 0x02008F2F RID: 36655
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402E696 RID: 190102
		BackButton,
		// Token: 0x0402E697 RID: 190103
		AccountInput,
		// Token: 0x0402E698 RID: 190104
		CodeInput,
		// Token: 0x0402E699 RID: 190105
		ProtocolButton1,
		// Token: 0x0402E69A RID: 190106
		ProtocolButton2,
		// Token: 0x0402E69B RID: 190107
		ProtocolButton3,
		// Token: 0x0402E69C RID: 190108
		ExtendToggleParent,
		// Token: 0x0402E69D RID: 190109
		AgreeToggle,
		// Token: 0x0402E69E RID: 190110
		SendCodeButton,
		// Token: 0x0402E69F RID: 190111
		ConfirmButton,
		// Token: 0x0402E6A0 RID: 190112
		ProtocolText1,
		// Token: 0x0402E6A1 RID: 190113
		ProtocolText2,
		// Token: 0x0402E6A2 RID: 190114
		ProtocolText3,
		// Token: 0x0402E6A3 RID: 190115
		ConfirmBoxText
	}
}
