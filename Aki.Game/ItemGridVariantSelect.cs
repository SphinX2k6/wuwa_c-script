using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Inventory;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020018C3 RID: 6339
[NullableContext(2)]
[Nullable(0)]
public class ItemGridVariantSelect : ItemGridAbstract, IItemGrid, IItemGridVariantOne, IItemGridVariantSelect
{
	// Token: 0x0600B9DE RID: 47582 RVA: 0x002A2076 File Offset: 0x002A0276
	public ItemGridVariantSelect(AActor commonItemActor = null, ItemGridAbstract source = null, EUiViewName? belongView = null) : base(commonItemActor, source, belongView)
	{
	}

	// Token: 0x17000F61 RID: 3937
	// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x002A2096 File Offset: 0x002A0296
	public bool IsItemGridVariantOne { get; } = 1;

	// Token: 0x17000F62 RID: 3938
	// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x002A209E File Offset: 0x002A029E
	public bool IsItemGrid { get; } = 1;

	// Token: 0x17000F63 RID: 3939
	// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002A20A6 File Offset: 0x002A02A6
	public bool IsItemGridVariantSelect { get; } = 1;

	// Token: 0x0600B9E2 RID: 47586 RVA: 0x002A20AE File Offset: 0x002A02AE
	public void RefreshItemShowState(bool showState)
	{
		base.GetItem(0).SetUIActive(showState);
	}

	// Token: 0x0600B9E3 RID: 47587 RVA: 0x002A20C0 File Offset: 0x002A02C0
	public void RefreshReduceButtonShowState(bool showState)
	{
		base.GetButton(4).RootUIComp.Get().SetUIActive(showState);
	}

	// Token: 0x0600B9E4 RID: 47588 RVA: 0x002A20E7 File Offset: 0x002A02E7
	public UUIItem GetFinishSelectItem()
	{
		return base.GetItem(1);
	}

	// Token: 0x0600B9E5 RID: 47589 RVA: 0x002A20F0 File Offset: 0x002A02F0
	public UUIItem GetFinishMiddleItem()
	{
		return base.GetItem(2);
	}

	// Token: 0x0600B9E6 RID: 47590 RVA: 0x002A20F9 File Offset: 0x002A02F9
	public UUIItem GetControlItem()
	{
		return base.GetItem(3);
	}

	// Token: 0x0600B9E7 RID: 47591 RVA: 0x002A2102 File Offset: 0x002A0302
	public UUIButtonComponent GetReduceButton()
	{
		return base.GetButton(4);
	}

	// Token: 0x0600B9E8 RID: 47592 RVA: 0x002A210B File Offset: 0x002A030B
	public UUIButtonComponent GetAddButton()
	{
		return base.GetButton(5);
	}

	// Token: 0x0600B9E9 RID: 47593 RVA: 0x002A2114 File Offset: 0x002A0314
	[NullableContext(1)]
	public void SetAddButtonCallBack(Action call)
	{
		this.OnClickAddButtonCall = call;
	}

	// Token: 0x0600B9EA RID: 47594 RVA: 0x002A2120 File Offset: 0x002A0320
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

	// Token: 0x0600B9EB RID: 47595 RVA: 0x002A21F7 File Offset: 0x002A03F7
	protected override void OnStart()
	{
		this.ItemGridVariantOne = new ItemGridVariantOne(base.GetItem(0).GetOwner(), this, new EUiViewName?(base.GetBelongView()));
		this.RefreshReduceButtonShowState(false);
	}

	// Token: 0x0600B9EC RID: 47596 RVA: 0x002A2223 File Offset: 0x002A0423
	private void OnClickAddButton()
	{
		Action onClickAddButtonCall = this.OnClickAddButtonCall;
		if (onClickAddButtonCall == null)
		{
			return;
		}
		onClickAddButtonCall();
	}

	// Token: 0x0600B9ED RID: 47597 RVA: 0x002A2235 File Offset: 0x002A0435
	public void RefreshQualitySprite()
	{
		this.ItemGridVariantOne.RefreshQualitySprite();
	}

	// Token: 0x0600B9EE RID: 47598 RVA: 0x002A2242 File Offset: 0x002A0442
	public void RefreshTextureIcon()
	{
		this.ItemGridVariantOne.RefreshTextureIcon();
	}

	// Token: 0x0600B9EF RID: 47599 RVA: 0x002A224F File Offset: 0x002A044F
	[NullableContext(1)]
	public void RefreshTextDown(bool showState, string text)
	{
		this.ItemGridVariantOne.RefreshTextDown(showState, text);
	}

	// Token: 0x0600B9F0 RID: 47600 RVA: 0x002A225E File Offset: 0x002A045E
	[NullableContext(1)]
	public void RefreshTextDownByTextId(bool showState, string text, params object[] args)
	{
		this.ItemGridVariantOne.RefreshTextDownByTextId(showState, text, args);
	}

	// Token: 0x0600B9F1 RID: 47601 RVA: 0x002A226E File Offset: 0x002A046E
	[NullableContext(1)]
	public void SetReduceClickEvent(Action call)
	{
		this.OnClickReduceButtonCall = call;
	}

	// Token: 0x0600B9F2 RID: 47602 RVA: 0x002A2277 File Offset: 0x002A0477
	[NullableContext(1)]
	public void SetToggleClickEvent(Action<int, ItemConfig> call)
	{
		this.ItemGridVariantOne.SetToggleClickEvent(call);
	}

	// Token: 0x0600B9F3 RID: 47603 RVA: 0x002A2285 File Offset: 0x002A0485
	[NullableContext(1)]
	public void SetToggleClickStateEvent(Action<EToggleState> call)
	{
		this.ItemGridVariantOne.SetToggleClickStateEvent(call);
	}

	// Token: 0x0600B9F4 RID: 47604 RVA: 0x002A2293 File Offset: 0x002A0493
	public void BindRedPointWithKeyAndId(ERedDotName name, int uid)
	{
		this.ItemGridVariantOne.BindRedPointWithKeyAndId(name, uid);
	}

	// Token: 0x0600B9F5 RID: 47605 RVA: 0x002A22A2 File Offset: 0x002A04A2
	[NullableContext(1)]
	public void RefreshCdPanel(bool showState, float cdFillAmount, string cdText)
	{
		this.ItemGridVariantOne.RefreshCdPanel(showState, cdFillAmount, cdText);
	}

	// Token: 0x0600B9F6 RID: 47606 RVA: 0x002A22B2 File Offset: 0x002A04B2
	public void RefreshDarkSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshDarkSprite(showState);
	}

	// Token: 0x0600B9F7 RID: 47607 RVA: 0x002A22C0 File Offset: 0x002A04C0
	public void RefreshLockSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshLockSprite(showState);
	}

	// Token: 0x0600B9F8 RID: 47608 RVA: 0x002A22CE File Offset: 0x002A04CE
	[NullableContext(1)]
	public void RefreshStar(int[] starNum)
	{
		this.ItemGridVariantOne.RefreshStar(starNum);
	}

	// Token: 0x0600B9F9 RID: 47609 RVA: 0x002A22DC File Offset: 0x002A04DC
	public void RefreshRecoverSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshRecoverSprite(showState);
	}

	// Token: 0x0600B9FA RID: 47610 RVA: 0x002A22EA File Offset: 0x002A04EA
	public void RefreshRightDownLockSprite(bool showState)
	{
		this.ItemGridVariantOne.RefreshRightDownLockSprite(showState);
	}

	// Token: 0x0600B9FB RID: 47611 RVA: 0x002A22F8 File Offset: 0x002A04F8
	[NullableContext(1)]
	public void RefreshUpgradePanel(bool showState, string showText)
	{
		this.ItemGridVariantOne.RefreshUpgradePanel(showState, showText);
	}

	// Token: 0x0600B9FC RID: 47612 RVA: 0x002A2307 File Offset: 0x002A0507
	public UUIExtendToggle GetClickToggle()
	{
		return this.ItemGridVariantOne.GetClickToggle();
	}

	// Token: 0x0600B9FD RID: 47613 RVA: 0x002A2314 File Offset: 0x002A0514
	public UUIText GetDownText()
	{
		return this.ItemGridVariantOne.GetDownText();
	}

	// Token: 0x0600B9FE RID: 47614 RVA: 0x002A2321 File Offset: 0x002A0521
	public int GetConfigId()
	{
		return base.GetItemId();
	}

	// Token: 0x0600B9FF RID: 47615 RVA: 0x002A2329 File Offset: 0x002A0529
	protected override void OnBeforeDestroy()
	{
		this.ItemGridVariantOne.Destroy(null);
	}

	// Token: 0x04005441 RID: 21569
	private Action OnClickAddButtonCall;

	// Token: 0x04005442 RID: 21570
	private Action OnClickReduceButtonCall;

	// Token: 0x04005443 RID: 21571
	private ItemGridVariantOne ItemGridVariantOne;

	// Token: 0x02007E4D RID: 32333
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x04029553 RID: 169299
		ItemGridVariantOne,
		// Token: 0x04029554 RID: 169300
		FinishSelectItem,
		// Token: 0x04029555 RID: 169301
		FinishMiddleItem,
		// Token: 0x04029556 RID: 169302
		ControlItem,
		// Token: 0x04029557 RID: 169303
		ReduceButton,
		// Token: 0x04029558 RID: 169304
		AddButton
	}
}
