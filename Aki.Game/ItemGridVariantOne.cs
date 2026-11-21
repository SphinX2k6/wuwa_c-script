using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D77 RID: 3447
[NullableContext(2)]
[Nullable(0)]
public class ItemGridVariantOne : ItemGridAbstract, IItemGrid, IItemGridVariantOne
{
	// Token: 0x06008D9D RID: 36253 RVA: 0x002AC44C File Offset: 0x002AA64C
	public ItemGridVariantOne(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null) : base(commonItemActor, source, belongView)
	{
	}

	// Token: 0x17000F81 RID: 3969
	// (get) Token: 0x06008D9E RID: 36254 RVA: 0x002AC465 File Offset: 0x002AA665
	public bool IsItemGridVariantOne { get; } = 1;

	// Token: 0x17000F82 RID: 3970
	// (get) Token: 0x06008D9F RID: 36255 RVA: 0x002AC46D File Offset: 0x002AA66D
	public bool IsItemGrid { get; } = 1;

	// Token: 0x06008DA0 RID: 36256 RVA: 0x002AC478 File Offset: 0x002AA678
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

	// Token: 0x06008DA1 RID: 36257 RVA: 0x002AC52C File Offset: 0x002AA72C
	protected override void OnStart()
	{
		this.StarLayoutItem = new StarLayoutItem(base.GetItem(1));
		this.ItemGrid = new ItemGrid(base.GetItem(0).GetOwner(), this, null);
		this.RefreshStar(null);
		this.RefreshRecoverSprite(false);
		this.RefreshRightDownLockSprite(false);
		this.RefreshUpgradePanel(false, null);
	}

	// Token: 0x06008DA2 RID: 36258 RVA: 0x002AC589 File Offset: 0x002AA789
	public void RefreshQualitySprite()
	{
		this.ItemGrid.RefreshQualitySprite();
	}

	// Token: 0x06008DA3 RID: 36259 RVA: 0x002AC596 File Offset: 0x002AA796
	[NullableContext(1)]
	public void RefreshTextureByPath(string path)
	{
		this.ItemGrid.RefreshTextureByPath(path);
	}

	// Token: 0x06008DA4 RID: 36260 RVA: 0x002AC5A4 File Offset: 0x002AA7A4
	public void RefreshTextureIcon()
	{
		this.ItemGrid.RefreshTextureIcon();
	}

	// Token: 0x06008DA5 RID: 36261 RVA: 0x002AC5B1 File Offset: 0x002AA7B1
	[NullableContext(1)]
	public void RefreshTextDown(bool showState, string text)
	{
		this.ItemGrid.RefreshTextDown(showState, text);
	}

	// Token: 0x06008DA6 RID: 36262 RVA: 0x002AC5C0 File Offset: 0x002AA7C0
	[NullableContext(1)]
	public void RefreshTextDownByTextId(bool showState, string textId, params object[] args)
	{
		this.ItemGrid.RefreshTextDownByTextId(showState, textId, args);
	}

	// Token: 0x06008DA7 RID: 36263 RVA: 0x002AC5D0 File Offset: 0x002AA7D0
	[NullableContext(1)]
	public void SetToggleClickEvent(Action<int, ItemConfig> call)
	{
		this.ItemGrid.SetToggleClickEvent(call);
	}

	// Token: 0x06008DA8 RID: 36264 RVA: 0x002AC5DE File Offset: 0x002AA7DE
	[NullableContext(1)]
	public void SetToggleClickStateEvent(Action<EToggleState> call)
	{
		this.ItemGrid.SetToggleClickStateEvent(call);
	}

	// Token: 0x06008DA9 RID: 36265 RVA: 0x002AC5EC File Offset: 0x002AA7EC
	public void BindRedPointWithKeyAndId(ERedDotName name, int uid)
	{
		this.ItemGrid.BindRedPointWithKeyAndId(name, uid);
	}

	// Token: 0x06008DAA RID: 36266 RVA: 0x002AC5FB File Offset: 0x002AA7FB
	[NullableContext(1)]
	public void RefreshCdPanel(bool showState, float cdFillAmount, string cdText)
	{
		this.ItemGrid.RefreshCdPanel(showState, cdFillAmount, cdText);
	}

	// Token: 0x06008DAB RID: 36267 RVA: 0x002AC60B File Offset: 0x002AA80B
	public void RefreshDarkSprite(bool showState)
	{
		this.ItemGrid.RefreshDarkSprite(showState);
	}

	// Token: 0x06008DAC RID: 36268 RVA: 0x002AC619 File Offset: 0x002AA819
	public void RefreshLockSprite(bool showState)
	{
		this.ItemGrid.RefreshLockSprite(showState);
	}

	// Token: 0x06008DAD RID: 36269 RVA: 0x002AC627 File Offset: 0x002AA827
	public UUIExtendToggle GetClickToggle()
	{
		return this.ItemGrid.GetClickToggle();
	}

	// Token: 0x06008DAE RID: 36270 RVA: 0x002AC634 File Offset: 0x002AA834
	public UUIText GetDownText()
	{
		return this.ItemGrid.GetDownText();
	}

	// Token: 0x06008DAF RID: 36271 RVA: 0x002AC641 File Offset: 0x002AA841
	public void RefreshNewItem(bool state)
	{
		this.ItemGrid.RefreshNewItem(state);
	}

	// Token: 0x06008DB0 RID: 36272 RVA: 0x002AC64F File Offset: 0x002AA84F
	public void RefreshStar(int[] starNum)
	{
		this.StarLayoutItem.RefreshStar(starNum);
	}

	// Token: 0x06008DB1 RID: 36273 RVA: 0x002AC65D File Offset: 0x002AA85D
	public void RefreshRecoverSprite(bool showState)
	{
		base.GetSprite(3).SetUIActive(showState);
	}

	// Token: 0x06008DB2 RID: 36274 RVA: 0x002AC66C File Offset: 0x002AA86C
	public void RefreshRightDownLockSprite(bool showState)
	{
		base.GetSprite(4).SetUIActive(showState);
	}

	// Token: 0x06008DB3 RID: 36275 RVA: 0x002AC67B File Offset: 0x002AA87B
	public void RefreshUpgradePanel(bool showState, string showText)
	{
		base.GetItem(5).SetUIActive(showState);
		if (showState)
		{
			base.GetText(6).SetText(showText, true);
		}
	}

	// Token: 0x06008DB4 RID: 36276 RVA: 0x002AC69B File Offset: 0x002AA89B
	public override void Refresh(TItem data, bool isSelected, int gridIndex)
	{
	}

	// Token: 0x06008DB5 RID: 36277 RVA: 0x002AC69D File Offset: 0x002AA89D
	protected override void OnBeforeDestroy()
	{
		StarLayoutItem starLayoutItem = this.StarLayoutItem;
		if (starLayoutItem != null)
		{
			starLayoutItem.Destroy(null);
		}
		this.ItemGrid.Destroy(null);
	}

	// Token: 0x040054E1 RID: 21729
	protected ItemGrid ItemGrid;

	// Token: 0x040054E2 RID: 21730
	private StarLayoutItem StarLayoutItem;

	// Token: 0x02006FD2 RID: 28626
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024875 RID: 149621
		ItemGrid,
		// Token: 0x04024876 RID: 149622
		StarItem,
		// Token: 0x04024877 RID: 149623
		RightDownVertical,
		// Token: 0x04024878 RID: 149624
		RecoverSprite,
		// Token: 0x04024879 RID: 149625
		LockSprite,
		// Token: 0x0402487A RID: 149626
		UpgradePanel,
		// Token: 0x0402487B RID: 149627
		UpgradeText
	}
}
