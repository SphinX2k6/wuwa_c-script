using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020020A6 RID: 8358
public class LoginAgeTipView : UiViewBase
{
	// Token: 0x060107DF RID: 67551 RVA: 0x00407237 File Offset: 0x00405437
	[NullableContext(1)]
	public LoginAgeTipView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060107E0 RID: 67552 RVA: 0x00407268 File Offset: 0x00405468
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

	// Token: 0x060107E1 RID: 67553 RVA: 0x0040736C File Offset: 0x0040556C
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

	// Token: 0x060107E2 RID: 67554 RVA: 0x004073BC File Offset: 0x004055BC
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

	// Token: 0x060107E3 RID: 67555 RVA: 0x00407458 File Offset: 0x00405658
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

	// Token: 0x060107E4 RID: 67556 RVA: 0x004074FC File Offset: 0x004056FC
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

	// Token: 0x040079FC RID: 31228
	[Nullable(1)]
	private readonly Action CloseAgeTipBtnClickCallBack = delegate()
	{
		UiLayer.Instance.SetShowNormalMaskLayer(false, "");
		UiManager.Instance.CloseView(EUiViewName.LoginAgeTipView, null);
	};

	// Token: 0x0200869E RID: 34462
	public enum ELoginShowType
	{
		// Token: 0x0402BCB4 RID: 179380
		AgeTip,
		// Token: 0x0402BCB5 RID: 179381
		UserAgreement,
		// Token: 0x0402BCB6 RID: 179382
		PrivacyAgreement,
		// Token: 0x0402BCB7 RID: 179383
		ChildPrivacyAgreement,
		// Token: 0x0402BCB8 RID: 179384
		LoginNotice
	}

	// Token: 0x0200869F RID: 34463
	private enum ELoginAgeTipChildCom
	{
		// Token: 0x0402BCBA RID: 179386
		Text1,
		// Token: 0x0402BCBB RID: 179387
		Text2,
		// Token: 0x0402BCBC RID: 179388
		Text3,
		// Token: 0x0402BCBD RID: 179389
		CloseBtn,
		// Token: 0x0402BCBE RID: 179390
		Title
	}
}
