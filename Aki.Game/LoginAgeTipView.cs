using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200157D RID: 5501
public class LoginAgeTipView : UiViewBase
{
	// Token: 0x0600DC4E RID: 56398 RVA: 0x004138D7 File Offset: 0x00411AD7
	[NullableContext(1)]
	public LoginAgeTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600DC4F RID: 56399 RVA: 0x00413908 File Offset: 0x00411B08
	protected unsafe override void OnRegisterComponent()
	{
		int num = 5;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIText));
		this.ComponentRegisterInfos = list;
		num2 = 1;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, this.CloseAgeTipBtnClickCallBack);
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600DC50 RID: 56400 RVA: 0x00413A0C File Offset: 0x00411C0C
	protected override void OnStart()
	{
		IUiPopFrameInterface childPopView = this.ChildPopView;
		if (childPopView != null)
		{
			CommonPopViewBase popItem = childPopView.PopItem;
			if (popItem != null)
			{
				popItem.OverrideBackBtnCallBack(delegate
				{
					this.CloseAgeTipBtnClickCallBack();
				});
			}
		}
		LoginAgeTipView.ELoginShowType type = (LoginAgeTipView.ELoginShowType)this.OpenParam;
		this.UpdateShowData(type);
		this.UpdateTitle(type);
	}

	// Token: 0x0600DC51 RID: 56401 RVA: 0x00413A5C File Offset: 0x00411C5C
	private void UpdateShowData(LoginAgeTipView.ELoginShowType type)
	{
		switch (type)
		{
		case LoginAgeTipView.ELoginShowType.AgeTip:
		{
			UUIText text = base.GetText(0);
			if (text != null)
			{
				text.SetUIActive(true);
			}
			UUIText text2 = base.GetText(0);
			if (text2 == null)
			{
				return;
			}
			text2.SetText(TextConfig.Instance.GetTextById("AgeTip"), true);
			return;
		}
		case LoginAgeTipView.ELoginShowType.UserAgreement:
		case LoginAgeTipView.ELoginShowType.PrivacyAgreement:
		case LoginAgeTipView.ELoginShowType.ChildPrivacyAgreement:
			this.ShowAgreement(TextConfig.Instance.GetTextById(type.ToString()));
			return;
		case LoginAgeTipView.ELoginShowType.LoginNotice:
			if (LoginModel.Instance.LoginNotice != null)
			{
				this.ShowAgreement(LoginModel.Instance.LoginNotice.content);
			}
			return;
		default:
			return;
		}
	}

	// Token: 0x0600DC52 RID: 56402 RVA: 0x00413AF8 File Offset: 0x00411CF8
	[NullableContext(1)]
	private void ShowAgreement(string content)
	{
		string text = content;
		int i = 0;
		while (i < 3)
		{
			int num = text.IndexOf('\n', 6000);
			if (num == -1)
			{
				if (text.Length >= 6000)
				{
					break;
				}
				UUIText text2 = base.GetText(i);
				if (text2 != null)
				{
					text2.SetUIActive(true);
				}
				UUIText text3 = base.GetText(i);
				if (text3 == null)
				{
					return;
				}
				text3.SetText(text, true);
				return;
			}
			else
			{
				string newText = text.Substring(0, num);
				UUIText text4 = base.GetText(i);
				if (text4 != null)
				{
					text4.SetUIActive(true);
				}
				UUIText text5 = base.GetText(i);
				if (text5 != null)
				{
					text5.SetText(newText, true);
				}
				text = text.Substring(num + 1);
				i++;
			}
		}
	}

	// Token: 0x0600DC53 RID: 56403 RVA: 0x00413B9C File Offset: 0x00411D9C
	private void UpdateTitle(LoginAgeTipView.ELoginShowType type)
	{
		string id = null;
		switch (type)
		{
		case LoginAgeTipView.ELoginShowType.AgeTip:
			id = "AgeTipTitle";
			break;
		case LoginAgeTipView.ELoginShowType.UserAgreement:
			id = "UserTitle";
			break;
		case LoginAgeTipView.ELoginShowType.PrivacyAgreement:
			id = "PrivacyTitle";
			break;
		case LoginAgeTipView.ELoginShowType.ChildPrivacyAgreement:
			id = "ChildPrivacyTitle";
			break;
		case LoginAgeTipView.ELoginShowType.LoginNotice:
			if (LoginModel.Instance.LoginNotice != null)
			{
				UUIText text = base.GetText(4);
				if (text == null)
				{
					return;
				}
				text.SetText(LoginModel.Instance.LoginNotice.Title, true);
			}
			return;
		}
		string textById = TextConfig.Instance.GetTextById(id);
		UUIText text2 = base.GetText(4);
		if (text2 == null)
		{
			return;
		}
		text2.SetText(textById, true);
	}

	// Token: 0x04007AFB RID: 31483
	[Nullable(1)]
	private readonly Action CloseAgeTipBtnClickCallBack = delegate()
	{
		UiLayer.Instance.SetShowNormalMaskLayer(false, "");
		UiManager.Instance.CloseView(EUiViewName.LoginAgeTipView, null);
	};

	// Token: 0x02007829 RID: 30761
	public enum ELoginShowType
	{
		// Token: 0x04026FD5 RID: 159701
		AgeTip,
		// Token: 0x04026FD6 RID: 159702
		UserAgreement,
		// Token: 0x04026FD7 RID: 159703
		PrivacyAgreement,
		// Token: 0x04026FD8 RID: 159704
		ChildPrivacyAgreement,
		// Token: 0x04026FD9 RID: 159705
		LoginNotice
	}

	// Token: 0x0200782A RID: 30762
	private enum ELoginAgeTipChildCom
	{
		// Token: 0x04026FDB RID: 159707
		Text1,
		// Token: 0x04026FDC RID: 159708
		Text2,
		// Token: 0x04026FDD RID: 159709
		Text3,
		// Token: 0x04026FDE RID: 159710
		CloseBtn,
		// Token: 0x04026FDF RID: 159711
		Title
	}
}
