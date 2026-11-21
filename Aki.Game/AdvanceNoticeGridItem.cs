using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000582 RID: 1410
public class AdvanceNoticeGridItem : UiPanelBase
{
	// Token: 0x060043A4 RID: 17316 RVA: 0x001758A6 File Offset: 0x00173AA6
	public AdvanceNoticeGridItem(int advertisingPageInfoId)
	{
		this.AdvertisingPageInfoId = advertisingPageInfoId;
	}

	// Token: 0x060043A5 RID: 17317 RVA: 0x001758B8 File Offset: 0x00173AB8
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUISprite)),
			new ValueTuple<int, Type>(3, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action(this.OnItemButtonClick))
		};
	}

	// Token: 0x060043A6 RID: 17318 RVA: 0x0017594B File Offset: 0x00173B4B
	protected override void OnStart()
	{
		this.TextureTransitionComp = (base.GetTexture(1).GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent);
	}

	// Token: 0x060043A7 RID: 17319 RVA: 0x00175973 File Offset: 0x00173B73
	public void RefreshByTabId(int tabId)
	{
		this.TabId = tabId;
		this.Refresh();
	}

	// Token: 0x060043A8 RID: 17320 RVA: 0x00175984 File Offset: 0x00173B84
	public void Refresh()
	{
		AdvertisingTabInfo advertisingTabInfoById = AdvanceNoticeConfig.Instance.GetAdvertisingTabInfoById(this.TabId);
		base.SetTextureByPath(advertisingTabInfoById.EntryButtonImage, base.GetTexture(1), null, delegate(bool _)
		{
			this.TextureTransitionComp.SetAllStateTexture(base.GetTexture(1).GetTexture());
		});
		this.SetSpriteByPath(advertisingTabInfoById.TabIcon, base.GetSprite(2), false, null, null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(3), advertisingTabInfoById.EntryButtonText, Array.Empty<object>());
	}

	// Token: 0x060043A9 RID: 17321 RVA: 0x00175A07 File Offset: 0x00173C07
	private void OnItemButtonClick()
	{
		AdvanceNoticeController instance = AdvanceNoticeController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenAdvanceNoticeView(this.AdvertisingPageInfoId, this.TabId);
	}

	// Token: 0x040034A2 RID: 13474
	private int TabId;

	// Token: 0x040034A3 RID: 13475
	[Nullable(2)]
	private UUITextureTransitionComponent TextureTransitionComp;

	// Token: 0x040034A4 RID: 13476
	public readonly int AdvertisingPageInfoId;

	// Token: 0x02006828 RID: 26664
	private class EComponentDefine
	{
		// Token: 0x04022559 RID: 140633
		public const int ItemButton = 0;

		// Token: 0x0402255A RID: 140634
		public const int BgTexture = 1;

		// Token: 0x0402255B RID: 140635
		public const int TypeIconSprite = 2;

		// Token: 0x0402255C RID: 140636
		public const int TitleDescText = 3;
	}
}
