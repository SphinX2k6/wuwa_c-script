using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020010CE RID: 4302
public class AdvanceNoticeGridItem : UiPanelBase
{
	// Token: 0x0600700E RID: 28686 RVA: 0x0016CEEA File Offset: 0x0016B0EA
	public AdvanceNoticeGridItem(int advertisingPageInfoId)
	{
		this.AdvertisingPageInfoId = advertisingPageInfoId;
	}

	// Token: 0x0600700F RID: 28687 RVA: 0x0016CEFC File Offset: 0x0016B0FC
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

	// Token: 0x06007010 RID: 28688 RVA: 0x0016CF8F File Offset: 0x0016B18F
	protected override void OnStart()
	{
		this.TextureTransitionComp = (base.GetTexture(1).GetOwner().GetComponentByClass(UUITextureTransitionComponent.StaticClass()) as UUITextureTransitionComponent);
	}

	// Token: 0x06007011 RID: 28689 RVA: 0x0016CFB7 File Offset: 0x0016B1B7
	public void RefreshByTabId(int tabId)
	{
		this.TabId = tabId;
		this.Refresh();
	}

	// Token: 0x06007012 RID: 28690 RVA: 0x0016CFC8 File Offset: 0x0016B1C8
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

	// Token: 0x06007013 RID: 28691 RVA: 0x0016D04B File Offset: 0x0016B24B
	private void OnItemButtonClick()
	{
		AdvanceNoticeController instance = AdvanceNoticeController.Instance;
		if (instance == null)
		{
			return;
		}
		instance.OpenAdvanceNoticeView(this.AdvertisingPageInfoId, this.TabId);
	}

	// Token: 0x04003409 RID: 13321
	private int TabId;

	// Token: 0x0400340A RID: 13322
	[Nullable(2)]
	private UUITextureTransitionComponent TextureTransitionComp;

	// Token: 0x0400340B RID: 13323
	public readonly int AdvertisingPageInfoId;

	// Token: 0x02007694 RID: 30356
	private class EComponentDefine
	{
		// Token: 0x04027210 RID: 160272
		public const int ItemButton = 0;

		// Token: 0x04027211 RID: 160273
		public const int BgTexture = 1;

		// Token: 0x04027212 RID: 160274
		public const int TypeIconSprite = 2;

		// Token: 0x04027213 RID: 160275
		public const int TitleDescText = 3;
	}
}
