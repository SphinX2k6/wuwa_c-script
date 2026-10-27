using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018BE RID: 6334
[NullableContext(2)]
[Nullable(0)]
public class ItemGridVariantOne : ItemGridAbstract, IItemGrid, IItemGridVariantOne
{
	// Token: 0x0600B9B4 RID: 47540 RVA: 0x002A1CF4 File Offset: 0x0029FEF4
	public ItemGridVariantOne(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null) : base(commonItemActor, source, belongView)
	{
	}

	// Token: 0x17000F5E RID: 3934
	// (get) Token: 0x0600B9B5 RID: 47541 RVA: 0x002A1D0D File Offset: 0x0029FF0D
	public bool IsItemGridVariantOne { get; } = 1;

	// Token: 0x17000F5F RID: 3935
	// (get) Token: 0x0600B9B6 RID: 47542 RVA: 0x002A1D15 File Offset: 0x0029FF15
	public bool IsItemGrid { get; } = 1;

	// Token: 0x0600B9B7 RID: 47543 RVA: 0x002A1D20 File Offset: 0x0029FF20
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIVerticalLayout)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIText))
		};
	}

	// Token: 0x0600B9B8 RID: 47544 RVA: 0x002A1DD4 File Offset: 0x0029FFD4
	protected override void OnStart()
	{
		this.StarLayoutItem = new StarLayoutItem(base.GetItem(1));
		this.ItemGrid = new ItemGrid(base.GetItem(0).GetOwner(), this, null);
		this.RefreshStar(null);
		this.RefreshRecoverSprite(false);
		this.RefreshRightDownLockSprite(false);
		this.RefreshUpgradePanel(false, null);
	}

	// Token: 0x0600B9B9 RID: 47545 RVA: 0x002A1E31 File Offset: 0x002A0031
	public void RefreshQualitySprite()
	{
		this.ItemGrid.RefreshQualitySprite();
	}

	// Token: 0x0600B9BA RID: 47546 RVA: 0x002A1E3E File Offset: 0x002A003E
	[NullableContext(1)]
	public void RefreshTextureByPath(string path)
	{
		this.ItemGrid.RefreshTextureByPath(path);
	}

	// Token: 0x0600B9BB RID: 47547 RVA: 0x002A1E4C File Offset: 0x002A004C
	public void RefreshTextureIcon()
	{
		this.ItemGrid.RefreshTextureIcon();
	}

	// Token: 0x0600B9BC RID: 47548 RVA: 0x002A1E59 File Offset: 0x002A0059
	[NullableContext(1)]
	public void RefreshTextDown(bool showState, string text)
	{
		this.ItemGrid.RefreshTextDown(showState, text);
	}

	// Token: 0x0600B9BD RID: 47549 RVA: 0x002A1E68 File Offset: 0x002A0068
	[NullableContext(1)]
	public void RefreshTextDownByTextId(bool showState, string textId, params object[] args)
	{
		this.ItemGrid.RefreshTextDownByTextId(showState, textId, args);
	}

	// Token: 0x0600B9BE RID: 47550 RVA: 0x002A1E78 File Offset: 0x002A0078
	[NullableContext(1)]
	public void SetToggleClickEvent(Action<int, ItemConfig> call)
	{
		this.ItemGrid.SetToggleClickEvent(call);
	}

	// Token: 0x0600B9BF RID: 47551 RVA: 0x002A1E86 File Offset: 0x002A0086
	[NullableContext(1)]
	public void SetToggleClickStateEvent(Action<EToggleState> call)
	{
		this.ItemGrid.SetToggleClickStateEvent(call);
	}

	// Token: 0x0600B9C0 RID: 47552 RVA: 0x002A1E94 File Offset: 0x002A0094
	public void BindRedPointWithKeyAndId(ERedDotName name, int uid)
	{
		this.ItemGrid.BindRedPointWithKeyAndId(name, uid);
	}

	// Token: 0x0600B9C1 RID: 47553 RVA: 0x002A1EA3 File Offset: 0x002A00A3
	[NullableContext(1)]
	public void RefreshCdPanel(bool showState, float cdFillAmount, string cdText)
	{
		this.ItemGrid.RefreshCdPanel(showState, cdFillAmount, cdText);
	}

	// Token: 0x0600B9C2 RID: 47554 RVA: 0x002A1EB3 File Offset: 0x002A00B3
	public void RefreshDarkSprite(bool showState)
	{
		this.ItemGrid.RefreshDarkSprite(showState);
	}

	// Token: 0x0600B9C3 RID: 47555 RVA: 0x002A1EC1 File Offset: 0x002A00C1
	public void RefreshLockSprite(bool showState)
	{
		this.ItemGrid.RefreshLockSprite(showState);
	}

	// Token: 0x0600B9C4 RID: 47556 RVA: 0x002A1ECF File Offset: 0x002A00CF
	public UUIExtendToggle GetClickToggle()
	{
		return this.ItemGrid.GetClickToggle();
	}

	// Token: 0x0600B9C5 RID: 47557 RVA: 0x002A1EDC File Offset: 0x002A00DC
	public UUIText GetDownText()
	{
		return this.ItemGrid.GetDownText();
	}

	// Token: 0x0600B9C6 RID: 47558 RVA: 0x002A1EE9 File Offset: 0x002A00E9
	public void RefreshNewItem(bool state)
	{
		this.ItemGrid.RefreshNewItem(state);
	}

	// Token: 0x0600B9C7 RID: 47559 RVA: 0x002A1EF7 File Offset: 0x002A00F7
	public void RefreshStar(int[] starNum)
	{
		this.StarLayoutItem.RefreshStar(starNum);
	}

	// Token: 0x0600B9C8 RID: 47560 RVA: 0x002A1F05 File Offset: 0x002A0105
	public void RefreshRecoverSprite(bool showState)
	{
		base.GetSprite(3).SetUIActive(showState);
	}

	// Token: 0x0600B9C9 RID: 47561 RVA: 0x002A1F14 File Offset: 0x002A0114
	public void RefreshRightDownLockSprite(bool showState)
	{
		base.GetSprite(4).SetUIActive(showState);
	}

	// Token: 0x0600B9CA RID: 47562 RVA: 0x002A1F23 File Offset: 0x002A0123
	public void RefreshUpgradePanel(bool showState, string showText)
	{
		base.GetItem(5).SetUIActive(showState);
		if (showState)
		{
			base.GetText(6).SetText(showText, true);
		}
	}

	// Token: 0x0600B9CB RID: 47563 RVA: 0x002A1F43 File Offset: 0x002A0143
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x0600B9CC RID: 47564 RVA: 0x002A1F45 File Offset: 0x002A0145
	protected override void OnBeforeDestroy()
	{
		StarLayoutItem starLayoutItem = this.StarLayoutItem;
		if (starLayoutItem != null)
		{
			starLayoutItem.Destroy(null);
		}
		this.ItemGrid.Destroy(null);
	}

	// Token: 0x04005436 RID: 21558
	protected ItemGrid ItemGrid;

	// Token: 0x04005437 RID: 21559
	private StarLayoutItem StarLayoutItem;

	// Token: 0x02007E4B RID: 32331
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029548 RID: 169288
		ItemGrid,
		// Token: 0x04029549 RID: 169289
		StarItem,
		// Token: 0x0402954A RID: 169290
		RightDownVertical,
		// Token: 0x0402954B RID: 169291
		RecoverSprite,
		// Token: 0x0402954C RID: 169292
		LockSprite,
		// Token: 0x0402954D RID: 169293
		UpgradePanel,
		// Token: 0x0402954E RID: 169294
		UpgradeText
	}
}
