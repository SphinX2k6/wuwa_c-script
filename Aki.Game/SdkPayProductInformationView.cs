using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x0200296F RID: 10607
public class SdkPayProductInformationView : UiViewBase
{
	// Token: 0x06015EAC RID: 89772 RVA: 0x005877BF File Offset: 0x005859BF
	[NullableContext(1)]
	public SdkPayProductInformationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x06015EAD RID: 89773 RVA: 0x005877C8 File Offset: 0x005859C8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIText)),
			new ValueTuple<int, Type>(2, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(3, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(2, new Action(this.OnClickBackBtn)),
			new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmBtn))
		};
	}

	// Token: 0x06015EAE RID: 89774 RVA: 0x00587873 File Offset: 0x00585A73
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as SdkPayProductInformationViewData);
	}

	// Token: 0x06015EAF RID: 89775 RVA: 0x00587886 File Offset: 0x00585A86
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
		EventSystem.Instance.Emit<ESdkDialogResult>(EEventName.SdkPayEnd, ESdkDialogResult.No);
	}

	// Token: 0x06015EB0 RID: 89776 RVA: 0x005878A0 File Offset: 0x00585AA0
	private void OnClickConfirmBtn()
	{
		PlatformSdkNew platformSdk = PlatformSdkManagerNew.Instance.GetPlatformSdk();
		if (platformSdk != null)
		{
			platformSdk.HidePlayStationStoreIcon();
		}
		if (this.ViewData != null)
		{
			this.ViewData.OnClickConfirmBtn(this.ViewData.ProductId);
		}
		base.CloseMe(null);
	}

	// Token: 0x06015EB1 RID: 89777 RVA: 0x005878EC File Offset: 0x00585AEC
	protected override void OnBeforeShow()
	{
		this.RefreshTitle();
		this.RefreshContent();
	}

	// Token: 0x06015EB2 RID: 89778 RVA: 0x005878FA File Offset: 0x00585AFA
	private void RefreshTitle()
	{
		if (this.ViewData != null)
		{
			UUIText text = base.GetText(0);
			if (text == null)
			{
				return;
			}
			text.SetText(this.ViewData.ProductName, true);
		}
	}

	// Token: 0x06015EB3 RID: 89779 RVA: 0x00587921 File Offset: 0x00585B21
	private void RefreshContent()
	{
		if (this.ViewData != null)
		{
			UUIText text = base.GetText(1);
			if (text == null)
			{
				return;
			}
			text.SetText(this.ViewData.ContentName, true);
		}
	}

	// Token: 0x0400A321 RID: 41761
	[Nullable(2)]
	private SdkPayProductInformationViewData ViewData;

	// Token: 0x02008F34 RID: 36660
	private enum EComponents
	{
		// Token: 0x0402E6B0 RID: 190128
		ProductName,
		// Token: 0x0402E6B1 RID: 190129
		Content,
		// Token: 0x0402E6B2 RID: 190130
		BackBtn,
		// Token: 0x0402E6B3 RID: 190131
		ConfirmBtn
	}
}
