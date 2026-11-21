using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using CSharpScript.Launcher.Platform.PlatformSdk;
using UnrealEngine;

// Token: 0x02001EEA RID: 7914
public class SdkPayProductInformationView : UiViewBase
{
	// Token: 0x060138B0 RID: 80048 RVA: 0x005B27C3 File Offset: 0x005B09C3
	[NullableContext(1)]
	public SdkPayProductInformationView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x060138B1 RID: 80049 RVA: 0x005B27CC File Offset: 0x005B09CC
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

	// Token: 0x060138B2 RID: 80050 RVA: 0x005B2877 File Offset: 0x005B0A77
	protected override void OnStart()
	{
		this.ViewData = (this.OpenParam as SdkPayProductInformationViewData);
	}

	// Token: 0x060138B3 RID: 80051 RVA: 0x005B288A File Offset: 0x005B0A8A
	private void OnClickBackBtn()
	{
		base.CloseMe(null);
		EventSystem.Instance.Emit<ESdkDialogResult>(EEventName.SdkPayEnd, ESdkDialogResult.No);
	}

	// Token: 0x060138B4 RID: 80052 RVA: 0x005B28A4 File Offset: 0x005B0AA4
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

	// Token: 0x060138B5 RID: 80053 RVA: 0x005B28F0 File Offset: 0x005B0AF0
	protected override void OnBeforeShow()
	{
		this.RefreshTitle();
		this.RefreshContent();
	}

	// Token: 0x060138B6 RID: 80054 RVA: 0x005B28FE File Offset: 0x005B0AFE
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

	// Token: 0x060138B7 RID: 80055 RVA: 0x005B2925 File Offset: 0x005B0B25
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

	// Token: 0x0400A70B RID: 42763
	[Nullable(2)]
	private SdkPayProductInformationViewData ViewData;

	// Token: 0x0200817C RID: 33148
	private enum EComponents
	{
		// Token: 0x04029DAD RID: 171437
		ProductName,
		// Token: 0x04029DAE RID: 171438
		Content,
		// Token: 0x04029DAF RID: 171439
		BackBtn,
		// Token: 0x04029DB0 RID: 171440
		ConfirmBtn
	}
}
