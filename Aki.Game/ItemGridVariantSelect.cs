using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000D7C RID: 3452
[NullableContext(2)]
[Nullable(0)]
public class ItemGridVariantSelect : ItemGridAbstract, IItemGrid, IItemGridVariantOne, IItemGridVariantSelect
{
	// Token: 0x06008DC7 RID: 36295 RVA: 0x002AC7CE File Offset: 0x002AA9CE
	public ItemGridVariantSelect(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null) : base(commonItemActor, source, belongView)
	{
	}

	// Token: 0x17000F84 RID: 3972
	// (get) Token: 0x06008DC8 RID: 36296 RVA: 0x002AC7EE File Offset: 0x002AA9EE
	public bool IsItemGridVariantOne { get; } = 1;

	// Token: 0x17000F85 RID: 3973
	// (get) Token: 0x06008DC9 RID: 36297 RVA: 0x002AC7F6 File Offset: 0x002AA9F6
	public bool IsItemGrid { get; } = 1;

	// Token: 0x17000F86 RID: 3974
	// (get) Token: 0x06008DCA RID: 36298 RVA: 0x002AC7FE File Offset: 0x002AA9FE
	public bool IsItemGridVariantSelect { get; } = 1;

	// Token: 0x06008DCB RID: 36299 RVA: 0x002AC806 File Offset: 0x002AAA06
	public void RefreshItemShowState(bool showState)
	{
		base.GetItem(0).SetUIActive(showState);
	}

	// Token: 0x06008DCC RID: 36300 RVA: 0x002AC818 File Offset: 0x002AAA18
	public void RefreshReduceButtonShowState(bool showState)
	{
		base.GetButton(4).RootUIComp.Get().SetUIActive(showState);
	}

	// Token: 0x06008DCD RID: 36301 RVA: 0x002AC83F File Offset: 0x002AAA3F
	public UUIItem GetFinishSelectItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x06008DCE RID: 36302 RVA: 0x002AC848 File Offset: 0x002AAA48
	public UUIItem GetFinishMiddleItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x06008DCF RID: 36303 RVA: 0x002AC851 File Offset: 0x002AAA51
	public UUIItem GetControlItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x06008DD0 RID: 36304 RVA: 0x002AC85A File Offset: 0x002AAA5A
	public UUIButtonComponent GetReduceButton()
	{
		return base.GetButton(4);
	}

	// Token: 0x06008DD1 RID: 36305 RVA: 0x002AC863 File Offset: 0x002AAA63
	public UUIButtonComponent GetAddButton()
	{
		return base.GetButton(5);
	}

	// Token: 0x06008DD2 RID: 36306 RVA: 0x002AC86C File Offset: 0x002AAA6C
	[NullableContext(1)]
	public void SetAddButtonCallBack(Action call)
	{
		this.OnClickAddButtonCall = call;
	}

	// Token: 0x06008DD3 RID: 36307 RVA: 0x002AC878 File Offset: 0x002AAA78
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(5, new Action(this.OnClickAddButton)),
			new ValueTuple<int, Delegate>(4, new Action(delegate()
			{
				Action onClickReduceButtonCall = this.OnClickReduceButtonCall;
				if (onClickReduceButtonCall == null)
				{
					return;
				}
				onClickReduceButtonCall();
			}))
		};
	}

	// Token: 0x06008DD4 RID: 36308 RVA: 0x002AC94F File Offset: 0x002AAB4F
	protected override void OnStart()
	{
		this.ItemGridVariantOne = new ItemGridVariantOne(base.GetItem(0).GetOwner(), this, new EUiViewName?(base.GetBelongView()));
		this.RefreshReduceButtonShowState(false);
	}

	// Token: 0x06008DD5 RID: 36309 RVA: 0x002AC97B File Offset: 0x002AAB7B
	private void OnClickAddButton()
	{
		Action onClickAddButtonCall = this.OnClickAddButtonCall;
		if (onClickAddButtonCall == null)
		{
			return;
		}
		onClickAddButtonCall();
	}

	// Token: 0x06008DD6 RID: 36310 RVA: 0x002AC98D File Offset: 0x002AAB8D
	public void RefreshQualitySprite()
	{
		this.ItemGridVariantOne.RefreshQualitySprite();
	}

	// Token: 0x06008DD7 RID: 36311 RVA: 0x002AC99A File Offset: 0x002AAB9A
	public void RefreshTextureIcon()
	{
		this.ItemGridVariantOne.RefreshTextureIcon();
	}

	// Token: 0x06008DD8 RID: 36312 RVA: 0x002AC9A7 File Offset: 0x002AABA7
	[NullableContext(1)]
	public void RefreshTextDown(bool showState, string text)
	{
		this.ItemGridVariantOne.RefreshTextDown(showState, text);
	}

	// Token: 0x06008DD9 RID: 36313 RVA: 0x002AC9B6 File Offset: 0x002AABB6
	[NullableContext(1)]
	public void RefreshTextDownByTextId(bool showState, string text, params object[] args)
	{
		this.ItemGridVariantOne.RefreshTextDownByTextId(showState, text, args);
	}

	// Token: 0x06008DDA RID: 36314 RVA: 0x002AC9C6 File Offset: 0x002AABC6
	[NullableContext(1)]
	public void SetReduceClickEvent(Action call)
	{
		this.OnClickReduceButtonCall = call;
	}

	// Token: 0x06008DDB RID: 36315 RVA: 0x002AC9CF File Offset: 0x002AABCF
	[NullableContext(1)]
	public void SetToggleClickEvent(Action<int, ItemConfig> call)
	{
		this.ItemGridVariantOne.SetToggleClickEvent(call);
	}

	// Token: 0x06008DDC RID: 36316 RVA: 0x002AC9DD File Offset: 0x002AABDD
	[NullableContext(1)]
	public void SetToggleClickStateEvent(Action<EToggleState> call)
	{
		this.ItemGridVariantOne.SetToggleClickStateEvent(call);
	}

	// Token: 0x06008DDD RID: 36317 RVA: 0x002AC9EB File Offset: 0x002AABEB
	public void BindRedPointWithKeyAndId(ERedDotName name, int uid)
	{
		this.ItemGridVariantOne.BindRedPointWithKeyAndId(name, uid);
	}

	// Token: 0x06008DDE RID: 36318 RVA: 0x002AC9FA File Offset: 0x002AABFA
	[NullableContext(1)]
	public void RefreshCdPanel(bool showState, float cdFillAmount, string cdText)
	{
		this.ItemGridVariantOne.RefreshCdPanel(showState, cdFillAmount, cdText);
	}

	// Token: 0x06008DDF RID: 36319 RVA: 0x002ACA0A File Offset: 0x002AAC0A
	public void RefreshDarkSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshDarkSprite(showState);
	}

	// Token: 0x06008DE0 RID: 36320 RVA: 0x002ACA18 File Offset: 0x002AAC18
	public void RefreshLockSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshLockSprite(showState);
	}

	// Token: 0x06008DE1 RID: 36321 RVA: 0x002ACA26 File Offset: 0x002AAC26
	[NullableContext(1)]
	public void RefreshStar(int[] starNum)
	{
		this.ItemGridVariantOne.RefreshStar(starNum);
	}

	// Token: 0x06008DE2 RID: 36322 RVA: 0x002ACA34 File Offset: 0x002AAC34
	public void RefreshRecoverSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshRecoverSprite(showState);
	}

	// Token: 0x06008DE3 RID: 36323 RVA: 0x002ACA42 File Offset: 0x002AAC42
	public void RefreshRightDownLockSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshRightDownLockSprite(showState);
	}

	// Token: 0x06008DE4 RID: 36324 RVA: 0x002ACA50 File Offset: 0x002AAC50
	[NullableContext(1)]
	public void RefreshUpgradePanel(bool showState, string showText)
	{
		this.ItemGridVariantOne.RefreshUpgradePanel(showState, showText);
	}

	// Token: 0x06008DE5 RID: 36325 RVA: 0x002ACA5F File Offset: 0x002AAC5F
	public UUIExtendToggle GetClickToggle()
	{
		return this.ItemGridVariantOne.GetClickToggle();
	}

	// Token: 0x06008DE6 RID: 36326 RVA: 0x002ACA6C File Offset: 0x002AAC6C
	public UUIText GetDownText()
	{
		return this.ItemGridVariantOne.GetDownText();
	}

	// Token: 0x06008DE7 RID: 36327 RVA: 0x002ACA79 File Offset: 0x002AAC79
	public int GetConfigId()
	{
		return base.GetItemId();
	}

	// Token: 0x06008DE8 RID: 36328 RVA: 0x002ACA81 File Offset: 0x002AAC81
	protected override void OnBeforeDestroy()
	{
		this.ItemGridVariantOne.Destroy(null);
	}

	// Token: 0x040054EC RID: 21740
	private Action OnClickAddButtonCall;

	// Token: 0x040054ED RID: 21741
	private Action OnClickReduceButtonCall;

	// Token: 0x040054EE RID: 21742
	private ItemGridVariantOne ItemGridVariantOne;

	// Token: 0x02006FD4 RID: 28628
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04024880 RID: 149632
		ItemGridVariantOne,
		// Token: 0x04024881 RID: 149633
		FinishSelectItem,
		// Token: 0x04024882 RID: 149634
		FinishMiddleItem,
		// Token: 0x04024883 RID: 149635
		ControlItem,
		// Token: 0x04024884 RID: 149636
		ReduceButton,
		// Token: 0x04024885 RID: 149637
		AddButton
	}
}
