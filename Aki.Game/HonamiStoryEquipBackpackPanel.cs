using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E92 RID: 7826
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryEquipBackpackPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600EFAF RID: 61359 RVA: 0x0039540C File Offset: 0x0039360C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUISprite)),
			new ValueTuple<int, Type>(4, typeof(UUISprite)),
			new ValueTuple<int, Type>(5, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem)),
			new ValueTuple<int, Type>(9, typeof(UUIItem)),
			new ValueTuple<int, Type>(10, typeof(UUIItem)),
			new ValueTuple<int, Type>(11, typeof(UUIItem)),
			new ValueTuple<int, Type>(12, typeof(UUINiagara)),
			new ValueTuple<int, Type>(13, typeof(UUIItem)),
			new ValueTuple<int, Type>(14, typeof(UUIScrollViewWithScrollbarComponent)),
			new ValueTuple<int, Type>(18, typeof(UUIItem))
		};
	}

	// Token: 0x0600EFB0 RID: 61360 RVA: 0x0039558B File Offset: 0x0039378B
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600EFB1 RID: 61361 RVA: 0x003955A0 File Offset: 0x003937A0
	protected override void OnBeforeShow()
	{
		base.GetSprite(3).SetUIActive(true);
		base.GetSprite(4).SetUIActive(true);
		UUIButtonComponent button = base.GetButton(5);
		if (button != null)
		{
			button.RootUIComp.Get().SetUIActive(false);
		}
		this.RefreshNeedQuickAll();
		this.AddEventListener();
	}

	// Token: 0x0600EFB2 RID: 61362 RVA: 0x003955F3 File Offset: 0x003937F3
	protected override void OnAfterShow()
	{
		base.GetSprite(3).SetUIActive(false);
		base.GetSprite(4).SetUIActive(false);
	}

	// Token: 0x0600EFB3 RID: 61363 RVA: 0x0039560F File Offset: 0x0039380F
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600EFB4 RID: 61364 RVA: 0x00395617 File Offset: 0x00393817
	protected override void OnBeforeDestroy()
	{
		this.CurSelectRoleEquipItem = null;
		this.TeamDataItem = null;
	}

	// Token: 0x0600EFB5 RID: 61365 RVA: 0x00395628 File Offset: 0x00393828
	private void AddEventListener()
	{
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Add(EEventName.OnHonamiStoryRoleEquipChanged, new Action(this.OnHonamiStoryRoleEquipChanged));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnCurrencyRefresh));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnCurrencyRefresh));
	}

	// Token: 0x0600EFB6 RID: 61366 RVA: 0x003956C4 File Offset: 0x003938C4
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryRoleEquipChanged, new Action(this.OnHonamiStoryRoleEquipChanged));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnCurrencyRefresh));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnCurrencyRefresh));
	}

	// Token: 0x0600EFB7 RID: 61367 RVA: 0x00395760 File Offset: 0x00393960
	public UniTask Init(HonamiStoryPlayerBackpackData backpackData)
	{
		HonamiStoryEquipBackpackPanel.<Init>d__24 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.backpackData = backpackData;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<Init>d__24>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFB8 RID: 61368 RVA: 0x003957AC File Offset: 0x003939AC
	private UniTask InitRoleEquipItemList()
	{
		HonamiStoryEquipBackpackPanel.<InitRoleEquipItemList>d__25 <InitRoleEquipItemList>d__;
		<InitRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleEquipItemList>d__.<>4__this = this;
		<InitRoleEquipItemList>d__.<>1__state = -1;
		<InitRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<InitRoleEquipItemList>d__25>(ref <InitRoleEquipItemList>d__);
		return <InitRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFB9 RID: 61369 RVA: 0x003957F0 File Offset: 0x003939F0
	private UniTask InitRoleEquipItem(HonamiStoryRoleEquipData equipData)
	{
		HonamiStoryEquipBackpackPanel.<InitRoleEquipItem>d__26 <InitRoleEquipItem>d__;
		<InitRoleEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleEquipItem>d__.<>4__this = this;
		<InitRoleEquipItem>d__.equipData = equipData;
		<InitRoleEquipItem>d__.<>1__state = -1;
		<InitRoleEquipItem>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<InitRoleEquipItem>d__26>(ref <InitRoleEquipItem>d__);
		return <InitRoleEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFBA RID: 61370 RVA: 0x0039583C File Offset: 0x00393A3C
	[NullableContext(2)]
	private void RefreshMask(HonamiStoryGridItemBase item)
	{
		if (item == null)
		{
			base.GetSprite(3).SetUIActive(false);
			return;
		}
		UUISprite sprite = base.GetSprite(3);
		sprite.SetUIActive(true);
		sprite.SetWidth(item.GetRootItem().GetWidth());
		sprite.SetHeight(item.GetRootItem().GetHeight());
		FVector fvector = item.GetRootItem().K2_GetComponentLocation();
		sprite.SetUIWorldLocation(fvector);
	}

	// Token: 0x0600EFBB RID: 61371 RVA: 0x003958A0 File Offset: 0x00393AA0
	private void RefreshHoverInfo([Nullable(2)] HonamiStoryEquipGridItem item, HonamiStoryInteractOperateAgent operateAgent)
	{
		UUISprite sprite = base.GetSprite(4);
		if (item == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		HonamiStoryItemDataBase operateData = operateAgent.OperateData;
		if (operateData == item.GetData() || operateData == null)
		{
			sprite.SetUIActive(false);
			return;
		}
		bool flag = this.CheckCanEquipItem(item, operateData);
		sprite.SetUIActive(true);
		sprite.SetWidth(item.GetRootItem().GetWidth());
		sprite.SetHeight(item.GetRootItem().GetHeight());
		FVector fvector = item.GetRootItem().K2_GetComponentLocation();
		sprite.SetUIWorldLocation(fvector);
		UUIItem uuiitem = sprite;
		bool bUseChangeColor = flag;
		FColor? fcolor = new FColor?(sprite.changeColor);
		uuiitem.SetChangeColor(bUseChangeColor, fcolor);
	}

	// Token: 0x0600EFBC RID: 61372 RVA: 0x00395938 File Offset: 0x00393B38
	public UniTask RefreshEquipItem()
	{
		HonamiStoryEquipBackpackPanel.<RefreshEquipItem>d__29 <RefreshEquipItem>d__;
		<RefreshEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEquipItem>d__.<>4__this = this;
		<RefreshEquipItem>d__.<>1__state = -1;
		<RefreshEquipItem>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<RefreshEquipItem>d__29>(ref <RefreshEquipItem>d__);
		return <RefreshEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFBD RID: 61373 RVA: 0x0039597C File Offset: 0x00393B7C
	public void RefreshRoleTipItem()
	{
		if (this.RoleTipItem == null || this.CurSelectRoleEquipItem == null)
		{
			return;
		}
		this.RoleTipItem.Refresh(this.CurSelectRoleEquipItem.GetRoleEquipData());
		float stretchBottom = this.RootItem.GetStretchBottom();
		float height = this.RootItem.GetHeight();
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetHeight(height + stretchBottom);
		}
		float num = height + stretchBottom - base.GetScrollViewWithScrollbar(14).RootUIComp.Get().GetStretchTop();
		float height2 = base.GetItem(2).GetHeight();
		float anchorOffsetY = base.GetItem(11).GetAnchorOffsetY();
		float stretchBottom2 = base.GetScrollViewWithScrollbar(14).RootUIComp.Get().GetStretchBottom();
		this.RoleTipItem.GetRootItem().SetHeight(num - height2 - Math.Abs(anchorOffsetY) * 2f - stretchBottom2);
	}

	// Token: 0x0600EFBE RID: 61374 RVA: 0x00395A5C File Offset: 0x00393C5C
	private UniTask RefreshRoleEquipItemList()
	{
		HonamiStoryEquipBackpackPanel.<RefreshRoleEquipItemList>d__31 <RefreshRoleEquipItemList>d__;
		<RefreshRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleEquipItemList>d__.<>4__this = this;
		<RefreshRoleEquipItemList>d__.<>1__state = -1;
		<RefreshRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<RefreshRoleEquipItemList>d__31>(ref <RefreshRoleEquipItemList>d__);
		return <RefreshRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600EFBF RID: 61375 RVA: 0x00395A9F File Offset: 0x00393C9F
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.GetBackpackType();
	}

	// Token: 0x0600EFC0 RID: 61376 RVA: 0x00395AAC File Offset: 0x00393CAC
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600EFC1 RID: 61377 RVA: 0x00395ABD File Offset: 0x00393CBD
	public override bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		return base.OnDrag(eventData, item);
	}

	// Token: 0x0600EFC2 RID: 61378 RVA: 0x00395ACE File Offset: 0x00393CCE
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(null);
		base.OnDragEnd(eventData, item);
	}

	// Token: 0x0600EFC3 RID: 61379 RVA: 0x00395AE0 File Offset: 0x00393CE0
	public override void OnHover(ULGUIPointerEventData eventData, HonamiStoryInteractOperateAgent operateAgent)
	{
		HonamiStoryEquipGridItem equipItemByEventData = this.GetEquipItemByEventData(eventData);
		if (this.HoverItem == equipItemByEventData)
		{
			return;
		}
		this.HoverItem = equipItemByEventData;
		this.RefreshHoverInfo(equipItemByEventData, operateAgent);
		base.OnCheckAttrItem(equipItemByEventData, operateAgent);
	}

	// Token: 0x0600EFC4 RID: 61380 RVA: 0x00395B16 File Offset: 0x00393D16
	public override void OnHoverEnd()
	{
		this.HoverItem = null;
		this.RefreshHoverInfo(null, null);
		base.OnCheckAttrItem(null, null);
	}

	// Token: 0x0600EFC5 RID: 61381 RVA: 0x00395B30 File Offset: 0x00393D30
	[return: Nullable(2)]
	private HonamiStoryEquipGridItem GetEquipItemByEventData(ULGUIPointerEventData eventData)
	{
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			if (honamiStoryRoleEquipItem.GetRootItem().IsUIActiveSelf() && HonamiStoryUtil.CheckEventDataInItemViewport(eventData, honamiStoryRoleEquipItem.GetRootItem(), true))
			{
				return honamiStoryRoleEquipItem.GetEquipItemByEventData(eventData);
			}
		}
		return null;
	}

	// Token: 0x0600EFC6 RID: 61382 RVA: 0x00395BA8 File Offset: 0x00393DA8
	public override bool CheckDragItemInViewport(ULGUIPointerEventData eventData)
	{
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = base.GetRootItem().GetUIWorldPosition();
		float num = uiworldPosition.X - base.GetRootItem().GetWidth() / 2f;
		float num2 = num + base.GetRootItem().GetWidth();
		float num3 = uiworldPosition.Z - base.GetRootItem().GetHeight() / 2f;
		float num4 = num3 + base.GetRootItem().GetHeight();
		return offsetVector.X >= num && offsetVector.X <= num2 && offsetVector.Z >= num3 && offsetVector.Z <= num4;
	}

	// Token: 0x0600EFC7 RID: 61383 RVA: 0x00395C44 File Offset: 0x00393E44
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase itemData)
	{
		HonamiStoryEquipGridItem equipItemByEventData = this.GetEquipItemByEventData(eventData);
		if (equipItemByEventData == null || equipItemByEventData.GetData() == itemData)
		{
			return null;
		}
		if (!this.CheckCanEquipItem(equipItemByEventData, itemData))
		{
			return null;
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(itemData, equipItemByEventData.GetPosition());
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo);
		HonamiStoryItemDataBase data = equipItemByEventData.GetData();
		if (data != null)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo2 = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(data, itemData.GetPosition());
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo2);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600EFC8 RID: 61384 RVA: 0x00395CCC File Offset: 0x00393ECC
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateData, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		if (operateData == null)
		{
			return null;
		}
		if (exchangeItemSet.Count > 1)
		{
			return null;
		}
		HonamiStoryItemDataBase honamiStoryItemDataBase = null;
		using (HashSet<HonamiStoryItemDataBase>.Enumerator enumerator = exchangeItemSet.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				honamiStoryItemDataBase = enumerator.Current;
			}
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(operateData);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
		if (honamiStoryItemDataBase != null)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(honamiStoryItemDataBase, operateData.GetPosition());
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600EFC9 RID: 61385 RVA: 0x00395D74 File Offset: 0x00393F74
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpack(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateData, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		if (operateData == null)
		{
			return null;
		}
		HonamiStoryEquipGridItem equipItemByEventData = this.GetEquipItemByEventData(eventData);
		if (equipItemByEventData == null)
		{
			return null;
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(operateData, equipItemByEventData.GetPosition());
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in exchangeItemSet)
		{
			if (honamiStoryItemDataBase != null)
			{
				HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(honamiStoryItemDataBase);
				honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
			}
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600EFCA RID: 61386 RVA: 0x00395E1C File Offset: 0x0039401C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override HashSet<HonamiStoryItemDataBase> GetExchangeItemSet(ULGUIPointerEventData eventData, HonamiStoryItemDataBase operateItemData)
	{
		HonamiStoryEquipGridItem equipItemByEventData = this.GetEquipItemByEventData(eventData);
		if (equipItemByEventData == null)
		{
			return null;
		}
		if (!this.CheckCanEquipItem(equipItemByEventData, operateItemData))
		{
			return null;
		}
		HashSet<HonamiStoryItemDataBase> hashSet = new HashSet<HonamiStoryItemDataBase>();
		HonamiStoryItemDataBase data = equipItemByEventData.GetData();
		if (data == null)
		{
			return hashSet;
		}
		hashSet.Add(data);
		return hashSet;
	}

	// Token: 0x0600EFCB RID: 61387 RVA: 0x00395E60 File Offset: 0x00394060
	public override void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state)
	{
		if (state == EHonamiStoryBackpackLogicState.Normal)
		{
			this.SetPanelAlpha(state);
			this.RefreshBottomPanel(state);
			HonamiStoryRoleTipItem roleTipItem = this.RoleTipItem;
			if (roleTipItem != null)
			{
				roleTipItem.RefreshItemTipsOpen();
			}
			using (List<HonamiStoryRoleEquipItem>.Enumerator enumerator = this.RoleEquipItemList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					HonamiStoryRoleEquipItem honamiStoryRoleEquipItem = enumerator.Current;
					honamiStoryRoleEquipItem.RefreshState(state);
				}
				return;
			}
		}
		if (state == EHonamiStoryBackpackLogicState.Sell)
		{
			this.SetPanelAlpha(state);
			return;
		}
		if (state == EHonamiStoryBackpackLogicState.Tips || state == EHonamiStoryBackpackLogicState.TipsWithPlugins)
		{
			HonamiStoryRoleTipItem roleTipItem2 = this.RoleTipItem;
			if (roleTipItem2 != null)
			{
				roleTipItem2.RefreshItemTipsOpen();
			}
			using (List<HonamiStoryRoleEquipItem>.Enumerator enumerator = this.RoleEquipItemList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					HonamiStoryRoleEquipItem honamiStoryRoleEquipItem2 = enumerator.Current;
					honamiStoryRoleEquipItem2.RefreshState(state);
				}
				return;
			}
		}
		if (state == EHonamiStoryBackpackLogicState.DraggingPlugins || state == EHonamiStoryBackpackLogicState.Dragging)
		{
			this.SetPanelAlpha(state);
			using (List<HonamiStoryRoleEquipItem>.Enumerator enumerator = this.RoleEquipItemList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					HonamiStoryRoleEquipItem honamiStoryRoleEquipItem3 = enumerator.Current;
					honamiStoryRoleEquipItem3.RefreshState(state);
				}
				return;
			}
		}
		if (state == EHonamiStoryBackpackLogicState.Instead)
		{
			this.SetPanelAlpha(state);
			this.RefreshBottomPanel(state);
			foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem4 in this.RoleEquipItemList)
			{
				honamiStoryRoleEquipItem4.RefreshState(state);
			}
		}
	}

	// Token: 0x0600EFCC RID: 61388 RVA: 0x00395FE0 File Offset: 0x003941E0
	public void RefreshUnlockSlot()
	{
		this.RefreshEquipItem();
	}

	// Token: 0x0600EFCD RID: 61389 RVA: 0x00395FE9 File Offset: 0x003941E9
	private bool CheckCanEquipItem(HonamiStoryEquipGridItem equipItem, HonamiStoryItemDataBase itemData)
	{
		return itemData.GetItemType() == EHonamiStoryItemType.Plugin && equipItem.GetIsUnlock();
	}

	// Token: 0x0600EFCE RID: 61390 RVA: 0x00396000 File Offset: 0x00394200
	public void RefreshNeedQuickAll()
	{
		bool flag = base.GetUiNiagara(12).IsUIActiveSelf();
		bool flag2 = HonamiStoryModel.Instance.QuickAllCheck(true);
		if (flag2 == flag)
		{
			if (!flag2)
			{
				this.LevelSequencePlayer.StopSequenceByKey("Tips_Rect", false, false);
				base.GetUiNiagara(12).SetUIActive(false);
			}
			return;
		}
		if (flag2)
		{
			this.LevelSequencePlayer.PlayLevelSequenceByName("Tips_Rect", false, null, false);
			return;
		}
		this.LevelSequencePlayer.StopSequenceByKey("Tips_Rect", false, false);
		base.GetUiNiagara(12).SetUIActive(false);
	}

	// Token: 0x0600EFCF RID: 61391 RVA: 0x00396090 File Offset: 0x00394290
	private void OnHonamiStoryBackpackUpdate(HonamiStoryBagUpdateContext updateContext)
	{
		if (updateContext.BackPackConfigId != this.BackpackData.BackpackId)
		{
			return;
		}
		this.RefreshEquipItem().ContinueWith(delegate()
		{
			foreach (HonamiStoryGridItemBase honamiStoryGridItemBase in this.GetUpdateContextEffectGridItems(updateContext))
			{
				honamiStoryGridItemBase.PlayPosChangeSweepAnimation();
			}
			if (Info.Instance.IsInGamepad())
			{
				HonamiStoryModel.Instance.GetGamepadLogic().Reset();
			}
		});
		this.RefreshRoleTipItem();
	}

	// Token: 0x0600EFD0 RID: 61392 RVA: 0x003960E8 File Offset: 0x003942E8
	private void OnHonamiStoryRoleEquipChanged()
	{
		this.RefreshEquipItem();
		this.RefreshRoleTipItem();
	}

	// Token: 0x0600EFD1 RID: 61393 RVA: 0x003960F8 File Offset: 0x003942F8
	public override List<HonamiStoryGridItemBase> GetUpdateContextEffectGridItems(HonamiStoryBagUpdateContext updateContext)
	{
		List<HonamiStoryGridItemBase> list = new List<HonamiStoryGridItemBase>();
		foreach (HonamiStoryBagUpdateInfo honamiStoryBagUpdateInfo in updateContext.HonamiStoryBagUpdateInfo)
		{
			HonamiStoryItemDataBase itemData = HonamiStoryModel.Instance.GetItemData(honamiStoryBagUpdateInfo.ItemIncrId);
			if (itemData != null && (honamiStoryBagUpdateInfo.Type == 0 || honamiStoryBagUpdateInfo.Type == 1))
			{
				int position = itemData.GetPosition();
				HonamiStoryEquipGridItem equipGridItemByPosition = this.GetEquipGridItemByPosition(position);
				if (equipGridItemByPosition != null)
				{
					list.Add(equipGridItemByPosition);
				}
			}
		}
		return list;
	}

	// Token: 0x0600EFD2 RID: 61394 RVA: 0x00396188 File Offset: 0x00394388
	[NullableContext(2)]
	private HonamiStoryEquipGridItem GetEquipGridItemByPosition(int position)
	{
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in honamiStoryRoleEquipItem.GetPluginItemList())
			{
				if (honamiStoryEquipGridItem.GetPosition() == position)
				{
					return honamiStoryEquipGridItem;
				}
			}
		}
		return null;
	}

	// Token: 0x0600EFD3 RID: 61395 RVA: 0x00396220 File Offset: 0x00394420
	private void OnPowerLevelChange(int oldValue, int newValue)
	{
		this.RefreshNeedQuickAll();
		this.TeamDataItem.RefreshPowerLevel(oldValue != newValue, oldValue < newValue, oldValue, newValue);
	}

	// Token: 0x0600EFD4 RID: 61396 RVA: 0x00396240 File Offset: 0x00394440
	public override void RefreshSingleItem(HonamiStoryItemDataBase itemData)
	{
		int position = itemData.GetPosition();
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(position);
		int honamiStoryPluginIndex = roleItemDataByPosition.GetHonamiStoryPluginIndex(position);
		HonamiStoryEquipGridItem honamiStoryEquipGridItem = this.RoleEquipItemList[roleItemDataByPosition.GetPosition()].GetPluginItemList()[honamiStoryPluginIndex];
		honamiStoryEquipGridItem.Refresh(honamiStoryEquipGridItem.GetData(), -1);
	}

	// Token: 0x0600EFD5 RID: 61397 RVA: 0x00396290 File Offset: 0x00394490
	protected void SetPanelAlpha(EHonamiStoryBackpackLogicState state)
	{
		bool flag = state == EHonamiStoryBackpackLogicState.Normal;
		bool flag2 = state == EHonamiStoryBackpackLogicState.Dragging || state == EHonamiStoryBackpackLogicState.DraggingPlugins;
		ButtonItem buttonQuickAll = this.ButtonQuickAll;
		if (buttonQuickAll != null)
		{
			buttonQuickAll.SetEnableClick(flag);
		}
		ButtonItem buttonUnload = this.ButtonUnload;
		if (buttonUnload != null)
		{
			buttonUnload.SetEnableClick(flag);
		}
		HonamiStoryBackpackLevelItem teamDataItem = this.TeamDataItem;
		if (teamDataItem != null)
		{
			teamDataItem.SetIsEnable(flag || flag2);
		}
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			honamiStoryRoleEquipItem.SetEnableState(state);
		}
		float alpha = (state == EHonamiStoryBackpackLogicState.Normal || state == EHonamiStoryBackpackLogicState.Instead) ? 1f : 0.4f;
		UUIItem item = base.GetItem(9);
		if (item != null)
		{
			item.SetAlpha(alpha);
		}
		UUIItem item2 = base.GetItem(10);
		if (item2 == null)
		{
			return;
		}
		item2.SetAlpha((flag || flag2) ? 1f : 0.4f);
	}

	// Token: 0x0600EFD6 RID: 61398 RVA: 0x00396378 File Offset: 0x00394578
	protected void RefreshBottomPanel(EHonamiStoryBackpackLogicState state)
	{
		bool flag = this.CurSelectRoleEquipItem != null;
		bool flag2 = state == EHonamiStoryBackpackLogicState.Normal;
		HonamiStoryBackpackInsteadItem insteadValueItem = this.InsteadValueItem;
		if (insteadValueItem != null)
		{
			insteadValueItem.SetVisible(state == EHonamiStoryBackpackLogicState.Instead);
		}
		ButtonItem buttonQuickAll = this.ButtonQuickAll;
		if (buttonQuickAll != null)
		{
			buttonQuickAll.SetUiActive(flag2 && !flag);
		}
		ButtonItem buttonUnload = this.ButtonUnload;
		if (buttonUnload == null)
		{
			return;
		}
		buttonUnload.SetUiActive(flag2 && !flag);
	}

	// Token: 0x0600EFD7 RID: 61399 RVA: 0x003963E0 File Offset: 0x003945E0
	private void OnClickQuickAll(int _)
	{
		double now = Time.Instance.Now;
		if (now - this.LastClickTime < 300.0)
		{
			return;
		}
		this.LastClickTime = now;
		HonamiStoryModel.Instance.ApplyQuickAll();
	}

	// Token: 0x0600EFD8 RID: 61400 RVA: 0x00396420 File Offset: 0x00394620
	private void OnClickUnload(int _)
	{
		double now = Time.Instance.Now;
		if (now - this.LastClickTime < 300.0)
		{
			return;
		}
		this.LastClickTime = now;
		if (HonamiStoryModel.Instance.GetBackpackLogicState() == EHonamiStoryBackpackLogicState.Normal)
		{
			HonamiStoryModel.Instance.QuickUnloadAllSlot();
		}
	}

	// Token: 0x0600EFD9 RID: 61401 RVA: 0x0039646C File Offset: 0x0039466C
	protected void RefreshSelfPanel()
	{
		float height = base.GetItem(2).GetHeight();
		float spacing = (base.GetItem(1).GetOwner().GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUIVerticalLayout).GetSpacing();
		int count = this.RoleEquipItemList.Count;
		float num = (float)count * height + Math.Max(0f, spacing * (float)(count - 1));
		float num2 = Math.Abs(base.GetItem(11).GetAnchorOffsetY());
		this.ContentHeight = num + num2 * 2f;
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetHeight(this.ContentHeight);
		}
		float num3 = base.GetScrollViewWithScrollbar(14).RootUIComp.Get().GetHeight() - this.ContentHeight;
		this.SelfOldHeight = this.RootItem.GetHeight();
		this.SelfHeight = this.SelfOldHeight - num3;
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetHeight(this.SelfHeight);
	}

	// Token: 0x0600EFDA RID: 61402 RVA: 0x00396568 File Offset: 0x00394768
	private void CloseRoleTipItem()
	{
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			honamiStoryRoleEquipItem.SetActive(true);
		}
		HonamiStoryRoleTipItem roleTipItem = this.RoleTipItem;
		if (roleTipItem != null)
		{
			roleTipItem.ShowTips(false);
		}
		UUIItem rootItem = this.RootItem;
		if (rootItem != null)
		{
			rootItem.SetHeight(this.SelfHeight);
		}
		UUIItem item = base.GetItem(13);
		if (item != null)
		{
			item.SetHeight(this.ContentHeight);
		}
		HonamiStoryRoleEquipItem curSelectRoleEquipItem = this.CurSelectRoleEquipItem;
		if (curSelectRoleEquipItem != null)
		{
			curSelectRoleEquipItem.SetRoleTipOpenState(false);
		}
		this.CurSelectRoleEquipItem = null;
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		this.RefreshBottomPanel(backpackLogicState);
	}

	// Token: 0x0600EFDB RID: 61403 RVA: 0x00396628 File Offset: 0x00394828
	private void RecoverCallback()
	{
		this.CloseRoleTipItem();
	}

	// Token: 0x0600EFDC RID: 61404 RVA: 0x00396630 File Offset: 0x00394830
	private void OnItemMoreClicked(HonamiStoryRoleEquipItem item)
	{
		if (this.CurSelectRoleEquipItem == item)
		{
			this.CloseRoleTipItem();
			return;
		}
		this.CurSelectRoleEquipItem = item;
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			honamiStoryRoleEquipItem.SetActive(honamiStoryRoleEquipItem == item);
		}
		EHonamiStoryBackpackLogicState logicState = HonamiStoryModel.Instance.GetBackpackLogic().GetLogicState();
		this.RefreshBottomPanel(logicState);
		this.RefreshRoleTipItem();
	}

	// Token: 0x0600EFDD RID: 61405 RVA: 0x003966B8 File Offset: 0x003948B8
	public override List<HonamiStoryGridItemBase> GetCurrentGridListGamepad()
	{
		List<HonamiStoryGridItemBase> list = new List<HonamiStoryGridItemBase>();
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			foreach (HonamiStoryEquipGridItem item in honamiStoryRoleEquipItem.GetPluginItemList())
			{
				list.Add(item);
			}
		}
		return list;
	}

	// Token: 0x0600EFDE RID: 61406 RVA: 0x0039674C File Offset: 0x0039494C
	public override void OnHoverGamepad(HonamiStoryGridItemBase targetItem, int position, HonamiStoryInteractOperateAgent operateAgent)
	{
		HonamiStoryEquipGridItem honamiStoryEquipGridItem = targetItem as HonamiStoryEquipGridItem;
		if (this.HoverItem == honamiStoryEquipGridItem)
		{
			return;
		}
		this.HoverItem = honamiStoryEquipGridItem;
		this.RefreshHoverInfo(honamiStoryEquipGridItem, operateAgent);
		base.OnCheckAttrItem(honamiStoryEquipGridItem, operateAgent);
		HonamiStoryBackpackView honamiStoryBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryBackpackView) as HonamiStoryBackpackView;
		if (honamiStoryBackpackView != null)
		{
			honamiStoryBackpackView.ShowTipsHotKeyOnly(targetItem);
		}
		HonamiStoryPickUpBackpackView honamiStoryPickUpBackpackView = UiManager.Instance.GetViewByName(EUiViewName.HonamiStoryPickUpBackpackView) as HonamiStoryPickUpBackpackView;
		if (honamiStoryPickUpBackpackView != null)
		{
			honamiStoryPickUpBackpackView.ShowTipsHotKeyOnly(targetItem);
		}
	}

	// Token: 0x0600EFDF RID: 61407 RVA: 0x003967C0 File Offset: 0x003949C0
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSameBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase itemData)
	{
		HonamiStoryEquipGridItem honamiStoryEquipGridItem = gridItem as HonamiStoryEquipGridItem;
		if (honamiStoryEquipGridItem == null || honamiStoryEquipGridItem.GetData() == itemData)
		{
			return null;
		}
		if (!this.CheckCanEquipItem(honamiStoryEquipGridItem, itemData))
		{
			return null;
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(itemData, honamiStoryEquipGridItem.GetPosition());
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo);
		HonamiStoryItemDataBase data = honamiStoryEquipGridItem.GetData();
		if (data != null)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemSwapInfo2 = HonamiStoryUtil.GetHonamiStoryItemSwapInfo(data, itemData.GetPosition());
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemSwapInfo2);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600EFE0 RID: 61408 RVA: 0x00396844 File Offset: 0x00394A44
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInSendBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		if (operateItem == null)
		{
			return null;
		}
		if (exchangeItemSet.Count > 1)
		{
			return null;
		}
		HonamiStoryItemDataBase honamiStoryItemDataBase = null;
		using (HashSet<HonamiStoryItemDataBase>.Enumerator enumerator = exchangeItemSet.GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				honamiStoryItemDataBase = enumerator.Current;
			}
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(operateItem);
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
		if (honamiStoryItemDataBase != null)
		{
			HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(honamiStoryItemDataBase, operateItem.GetPosition());
			honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600EFE1 RID: 61409 RVA: 0x003968E8 File Offset: 0x00394AE8
	[return: Nullable(2)]
	public override HonamiStoryBagUpdateContext GetUpdateInfoInReceiveBackpackGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem, HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		if (operateItem == null)
		{
			return null;
		}
		HonamiStoryEquipGridItem honamiStoryEquipGridItem = gridItem as HonamiStoryEquipGridItem;
		if (honamiStoryEquipGridItem == null)
		{
			return null;
		}
		HonamiStoryBagUpdateContext honamiStoryBagUpdateContext = HonamiStoryBagUpdateContext.Create();
		honamiStoryBagUpdateContext.BackPackConfigId = this.BackpackData.BackpackId;
		HonamiStoryBagUpdateInfo honamiStoryItemAddInfo = HonamiStoryUtil.GetHonamiStoryItemAddInfo(operateItem, honamiStoryEquipGridItem.GetPosition());
		honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemAddInfo);
		foreach (HonamiStoryItemDataBase honamiStoryItemDataBase in exchangeItemSet)
		{
			if (honamiStoryItemDataBase != null)
			{
				HonamiStoryBagUpdateInfo honamiStoryItemRemoveInfo = HonamiStoryUtil.GetHonamiStoryItemRemoveInfo(honamiStoryItemDataBase);
				honamiStoryBagUpdateContext.HonamiStoryBagUpdateInfo.Add(honamiStoryItemRemoveInfo);
			}
		}
		return honamiStoryBagUpdateContext;
	}

	// Token: 0x0600EFE2 RID: 61410 RVA: 0x0039698C File Offset: 0x00394B8C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override HashSet<HonamiStoryItemDataBase> GetExchangeItemSetGamepad(HonamiStoryGridItemBase gridItem, HonamiStoryItemDataBase operateItem)
	{
		HonamiStoryEquipGridItem honamiStoryEquipGridItem = gridItem as HonamiStoryEquipGridItem;
		if (honamiStoryEquipGridItem == null)
		{
			return null;
		}
		if (!this.CheckCanEquipItem(honamiStoryEquipGridItem, operateItem))
		{
			return null;
		}
		HashSet<HonamiStoryItemDataBase> hashSet = new HashSet<HonamiStoryItemDataBase>();
		HonamiStoryItemDataBase data = honamiStoryEquipGridItem.GetData();
		if (data == null)
		{
			return hashSet;
		}
		hashSet.Add(data);
		return hashSet;
	}

	// Token: 0x0600EFE3 RID: 61411 RVA: 0x003969CC File Offset: 0x00394BCC
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		string a = configParams[0];
		if (a == "RolePanel")
		{
			UUIItem guideUiItem = base.GetGuideUiItem("3");
			if (guideUiItem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				guideUiItem,
				guideUiItem
			};
		}
		else if (a == "Equips")
		{
			HonamiStoryRoleEquipItem honamiStoryRoleEquipItem = this.RoleEquipItemList[0];
			UUIItem uuiitem = (honamiStoryRoleEquipItem != null) ? honamiStoryRoleEquipItem.GetGuideUiItem("0") : null;
			if (uuiitem == null)
			{
				return null;
			}
			return new UUIItem[]
			{
				uuiitem,
				uuiitem
			};
		}
		else if (a == "AddBtn")
		{
			HonamiStoryRoleEquipItem honamiStoryRoleEquipItem2 = this.RoleEquipItemList[0];
			if (honamiStoryRoleEquipItem2 == null)
			{
				return null;
			}
			return honamiStoryRoleEquipItem2.GetGuideUiItemAndUiItemForShowEx(configParams);
		}
		else
		{
			if (a == "Plugin")
			{
				foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem3 in this.RoleEquipItemList)
				{
					int id = int.Parse(configParams[1]);
					ValueTuple<UUIItem, UUIItem>? valueTuple = honamiStoryRoleEquipItem3.GuideFindPluginItemWithId(id);
					if (valueTuple != null)
					{
						return new UUIItem[]
						{
							valueTuple.Value.Item1,
							valueTuple.Value.Item2
						};
					}
				}
			}
			if (a == "UpdateBtn")
			{
				UUIItem guideUiItem2 = base.GetGuideUiItem("5");
				if (guideUiItem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					guideUiItem2,
					guideUiItem2
				};
			}
			else if (a == "Capybara")
			{
				int index = int.Parse(configParams[1]);
				HonamiStoryRoleEquipItem honamiStoryRoleEquipItem4 = this.RoleEquipItemList[index];
				UUIItem uuiitem2 = (honamiStoryRoleEquipItem4 != null) ? honamiStoryRoleEquipItem4.GetGuideUiItem("1") : null;
				if (uuiitem2 == null)
				{
					return null;
				}
				return new UUIItem[]
				{
					uuiitem2,
					uuiitem2
				};
			}
			else
			{
				if (!(a == "SuitDesc"))
				{
					return null;
				}
				HonamiStoryRoleTipItem roleTipItem = this.RoleTipItem;
				if (roleTipItem == null)
				{
					return null;
				}
				return roleTipItem.GetGuideUiItemAndUiItemForShowEx(configParams);
			}
		}
	}

	// Token: 0x0600EFE4 RID: 61412 RVA: 0x00396BAC File Offset: 0x00394DAC
	private void OnCurrencyRefresh(IReadOnlyList<int> _)
	{
		this.OnCurrencyRefresh(new List<IProto_NormalItem>());
	}

	// Token: 0x0600EFE5 RID: 61413 RVA: 0x00396BBC File Offset: 0x00394DBC
	private void OnCurrencyRefresh(IReadOnlyList<IProto_NormalItem> _)
	{
		HonamiStoryBackpackLevelItem teamDataItem = this.TeamDataItem;
		if (teamDataItem != null)
		{
			teamDataItem.CheckCanUpgrade();
		}
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			foreach (HonamiStoryEquipGridItem honamiStoryEquipGridItem in honamiStoryRoleEquipItem.GetPluginItemList())
			{
				honamiStoryEquipGridItem.RefreshLockState();
			}
		}
	}

	// Token: 0x04006EF0 RID: 28400
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006EF1 RID: 28401
	[Nullable(2)]
	protected HonamiStoryBackpackLevelItem TeamDataItem;

	// Token: 0x04006EF2 RID: 28402
	private HonamiStoryPlayerBackpackData BackpackData;

	// Token: 0x04006EF3 RID: 28403
	private readonly List<HonamiStoryRoleEquipItem> RoleEquipItemList = new List<HonamiStoryRoleEquipItem>();

	// Token: 0x04006EF4 RID: 28404
	[Nullable(2)]
	private HonamiStoryRoleEquipItem CurSelectRoleEquipItem;

	// Token: 0x04006EF5 RID: 28405
	[Nullable(2)]
	private HonamiStoryGridItemBase HoverItem;

	// Token: 0x04006EF6 RID: 28406
	[Nullable(2)]
	protected HonamiStoryBackpackInsteadItem InsteadValueItem;

	// Token: 0x04006EF7 RID: 28407
	[Nullable(2)]
	private HonamiStoryRoleTipItem RoleTipItem;

	// Token: 0x04006EF8 RID: 28408
	[Nullable(2)]
	private ButtonItem ButtonQuickAll;

	// Token: 0x04006EF9 RID: 28409
	[Nullable(2)]
	private ButtonItem ButtonUnload;

	// Token: 0x04006EFA RID: 28410
	private double LastClickTime;

	// Token: 0x04006EFB RID: 28411
	public float ViewPanelHeight;

	// Token: 0x04006EFC RID: 28412
	protected float SelfHeight;

	// Token: 0x04006EFD RID: 28413
	protected float SelfOldHeight;

	// Token: 0x04006EFE RID: 28414
	protected float ContentHeight;

	// Token: 0x02008441 RID: 33857
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x0402B0A4 RID: 176292
		TeamDataItem,
		// Token: 0x0402B0A5 RID: 176293
		RoleEquipRoot,
		// Token: 0x0402B0A6 RID: 176294
		RoleEquipItem,
		// Token: 0x0402B0A7 RID: 176295
		SpriteGridMask,
		// Token: 0x0402B0A8 RID: 176296
		SpriteGridState,
		// Token: 0x0402B0A9 RID: 176297
		BtnMask,
		// Token: 0x0402B0AA RID: 176298
		InsteadModeItem,
		// Token: 0x0402B0AB RID: 176299
		BtnQuickAll,
		// Token: 0x0402B0AC RID: 176300
		BtnUnload,
		// Token: 0x0402B0AD RID: 176301
		PanelButton,
		// Token: 0x0402B0AE RID: 176302
		PanelBg,
		// Token: 0x0402B0AF RID: 176303
		TipLayout,
		// Token: 0x0402B0B0 RID: 176304
		QuickAllNiagara,
		// Token: 0x0402B0B1 RID: 176305
		Content,
		// Token: 0x0402B0B2 RID: 176306
		SvDefault,
		// Token: 0x0402B0B3 RID: 176307
		Viewport,
		// Token: 0x0402B0B4 RID: 176308
		PanelSaleCancel,
		// Token: 0x0402B0B5 RID: 176309
		SpriteEquipBgB,
		// Token: 0x0402B0B6 RID: 176310
		PanelSelf
	}
}
