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

// Token: 0x02001354 RID: 4948
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryEquipBackpackPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600C3CE RID: 50126 RVA: 0x003A0FC8 File Offset: 0x0039F1C8
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

	// Token: 0x0600C3CF RID: 50127 RVA: 0x003A1147 File Offset: 0x0039F347
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
	}

	// Token: 0x0600C3D0 RID: 50128 RVA: 0x003A115C File Offset: 0x0039F35C
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

	// Token: 0x0600C3D1 RID: 50129 RVA: 0x003A11AF File Offset: 0x0039F3AF
	protected override void OnAfterShow()
	{
		base.GetSprite(3).SetUIActive(false);
		base.GetSprite(4).SetUIActive(false);
	}

	// Token: 0x0600C3D2 RID: 50130 RVA: 0x003A11CB File Offset: 0x0039F3CB
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600C3D3 RID: 50131 RVA: 0x003A11D3 File Offset: 0x0039F3D3
	protected override void OnBeforeDestroy()
	{
		this.CurSelectRoleEquipItem = null;
		this.TeamDataItem = null;
	}

	// Token: 0x0600C3D4 RID: 50132 RVA: 0x003A11E4 File Offset: 0x0039F3E4
	private void AddEventListener()
	{
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Add(EEventName.OnHonamiStoryRoleEquipChanged, new Action(this.OnHonamiStoryRoleEquipChanged));
		EventSystem.Instance.Add<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnCurrencyRefresh));
		EventSystem.Instance.Add<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnCurrencyRefresh));
	}

	// Token: 0x0600C3D5 RID: 50133 RVA: 0x003A1280 File Offset: 0x0039F480
	private void RemoveEventListener()
	{
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Remove(EEventName.OnHonamiStoryRoleEquipChanged, new Action(this.OnHonamiStoryRoleEquipChanged));
		EventSystem.Instance.Remove<IReadOnlyList<IProto_NormalItem>>(EEventName.OnAddCommonItemList, new Action<IReadOnlyList<IProto_NormalItem>>(this.OnCurrencyRefresh));
		EventSystem.Instance.Remove<IReadOnlyList<int>>(EEventName.OnRemoveCommonItem, new Action<IReadOnlyList<int>>(this.OnCurrencyRefresh));
	}

	// Token: 0x0600C3D6 RID: 50134 RVA: 0x003A131C File Offset: 0x0039F51C
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

	// Token: 0x0600C3D7 RID: 50135 RVA: 0x003A1368 File Offset: 0x0039F568
	private UniTask InitRoleEquipItemList()
	{
		HonamiStoryEquipBackpackPanel.<InitRoleEquipItemList>d__25 <InitRoleEquipItemList>d__;
		<InitRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleEquipItemList>d__.<>4__this = this;
		<InitRoleEquipItemList>d__.<>1__state = -1;
		<InitRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<InitRoleEquipItemList>d__25>(ref <InitRoleEquipItemList>d__);
		return <InitRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C3D8 RID: 50136 RVA: 0x003A13AC File Offset: 0x0039F5AC
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

	// Token: 0x0600C3D9 RID: 50137 RVA: 0x003A13F8 File Offset: 0x0039F5F8
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

	// Token: 0x0600C3DA RID: 50138 RVA: 0x003A145C File Offset: 0x0039F65C
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

	// Token: 0x0600C3DB RID: 50139 RVA: 0x003A14F4 File Offset: 0x0039F6F4
	public UniTask RefreshEquipItem()
	{
		HonamiStoryEquipBackpackPanel.<RefreshEquipItem>d__29 <RefreshEquipItem>d__;
		<RefreshEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEquipItem>d__.<>4__this = this;
		<RefreshEquipItem>d__.<>1__state = -1;
		<RefreshEquipItem>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<RefreshEquipItem>d__29>(ref <RefreshEquipItem>d__);
		return <RefreshEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C3DC RID: 50140 RVA: 0x003A1538 File Offset: 0x0039F738
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

	// Token: 0x0600C3DD RID: 50141 RVA: 0x003A1618 File Offset: 0x0039F818
	private UniTask RefreshRoleEquipItemList()
	{
		HonamiStoryEquipBackpackPanel.<RefreshRoleEquipItemList>d__31 <RefreshRoleEquipItemList>d__;
		<RefreshRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleEquipItemList>d__.<>4__this = this;
		<RefreshRoleEquipItemList>d__.<>1__state = -1;
		<RefreshRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryEquipBackpackPanel.<RefreshRoleEquipItemList>d__31>(ref <RefreshRoleEquipItemList>d__);
		return <RefreshRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C3DE RID: 50142 RVA: 0x003A165B File Offset: 0x0039F85B
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.GetBackpackType();
	}

	// Token: 0x0600C3DF RID: 50143 RVA: 0x003A1668 File Offset: 0x0039F868
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600C3E0 RID: 50144 RVA: 0x003A1679 File Offset: 0x0039F879
	public override bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		return base.OnDrag(eventData, item);
	}

	// Token: 0x0600C3E1 RID: 50145 RVA: 0x003A168A File Offset: 0x0039F88A
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(null);
		base.OnDragEnd(eventData, item);
	}

	// Token: 0x0600C3E2 RID: 50146 RVA: 0x003A169C File Offset: 0x0039F89C
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

	// Token: 0x0600C3E3 RID: 50147 RVA: 0x003A16D2 File Offset: 0x0039F8D2
	public override void OnHoverEnd()
	{
		this.HoverItem = null;
		this.RefreshHoverInfo(null, null);
		base.OnCheckAttrItem(null, null);
	}

	// Token: 0x0600C3E4 RID: 50148 RVA: 0x003A16EC File Offset: 0x0039F8EC
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

	// Token: 0x0600C3E5 RID: 50149 RVA: 0x003A1764 File Offset: 0x0039F964
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

	// Token: 0x0600C3E6 RID: 50150 RVA: 0x003A1800 File Offset: 0x0039FA00
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

	// Token: 0x0600C3E7 RID: 50151 RVA: 0x003A1888 File Offset: 0x0039FA88
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

	// Token: 0x0600C3E8 RID: 50152 RVA: 0x003A1930 File Offset: 0x0039FB30
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

	// Token: 0x0600C3E9 RID: 50153 RVA: 0x003A19D8 File Offset: 0x0039FBD8
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

	// Token: 0x0600C3EA RID: 50154 RVA: 0x003A1A1C File Offset: 0x0039FC1C
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

	// Token: 0x0600C3EB RID: 50155 RVA: 0x003A1B9C File Offset: 0x0039FD9C
	public void RefreshUnlockSlot()
	{
		this.RefreshEquipItem();
	}

	// Token: 0x0600C3EC RID: 50156 RVA: 0x003A1BA5 File Offset: 0x0039FDA5
	private bool CheckCanEquipItem(HonamiStoryEquipGridItem equipItem, HonamiStoryItemDataBase itemData)
	{
		return itemData.GetItemType() == EHonamiStoryItemType.Plugin && equipItem.GetIsUnlock();
	}

	// Token: 0x0600C3ED RID: 50157 RVA: 0x003A1BBC File Offset: 0x0039FDBC
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

	// Token: 0x0600C3EE RID: 50158 RVA: 0x003A1C4C File Offset: 0x0039FE4C
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

	// Token: 0x0600C3EF RID: 50159 RVA: 0x003A1CA4 File Offset: 0x0039FEA4
	private void OnHonamiStoryRoleEquipChanged()
	{
		this.RefreshEquipItem();
		this.RefreshRoleTipItem();
	}

	// Token: 0x0600C3F0 RID: 50160 RVA: 0x003A1CB4 File Offset: 0x0039FEB4
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

	// Token: 0x0600C3F1 RID: 50161 RVA: 0x003A1D44 File Offset: 0x0039FF44
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

	// Token: 0x0600C3F2 RID: 50162 RVA: 0x003A1DDC File Offset: 0x0039FFDC
	private void OnPowerLevelChange(int oldValue, int newValue)
	{
		this.RefreshNeedQuickAll();
		this.TeamDataItem.RefreshPowerLevel(oldValue != newValue, oldValue < newValue, oldValue, newValue);
	}

	// Token: 0x0600C3F3 RID: 50163 RVA: 0x003A1DFC File Offset: 0x0039FFFC
	public override void RefreshSingleItem(HonamiStoryItemDataBase itemData)
	{
		int position = itemData.GetPosition();
		HonamiStoryRoleEquipData roleItemDataByPosition = HonamiStoryModel.Instance.GetRoleItemDataByPosition(position);
		int honamiStoryPluginIndex = roleItemDataByPosition.GetHonamiStoryPluginIndex(position);
		HonamiStoryEquipGridItem honamiStoryEquipGridItem = this.RoleEquipItemList[roleItemDataByPosition.GetPosition()].GetPluginItemList()[honamiStoryPluginIndex];
		honamiStoryEquipGridItem.Refresh(honamiStoryEquipGridItem.GetData(), -1);
	}

	// Token: 0x0600C3F4 RID: 50164 RVA: 0x003A1E4C File Offset: 0x003A004C
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

	// Token: 0x0600C3F5 RID: 50165 RVA: 0x003A1F34 File Offset: 0x003A0134
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

	// Token: 0x0600C3F6 RID: 50166 RVA: 0x003A1F9C File Offset: 0x003A019C
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

	// Token: 0x0600C3F7 RID: 50167 RVA: 0x003A1FDC File Offset: 0x003A01DC
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

	// Token: 0x0600C3F8 RID: 50168 RVA: 0x003A2028 File Offset: 0x003A0228
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

	// Token: 0x0600C3F9 RID: 50169 RVA: 0x003A2124 File Offset: 0x003A0324
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

	// Token: 0x0600C3FA RID: 50170 RVA: 0x003A21E4 File Offset: 0x003A03E4
	private void RecoverCallback()
	{
		this.CloseRoleTipItem();
	}

	// Token: 0x0600C3FB RID: 50171 RVA: 0x003A21EC File Offset: 0x003A03EC
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

	// Token: 0x0600C3FC RID: 50172 RVA: 0x003A2274 File Offset: 0x003A0474
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

	// Token: 0x0600C3FD RID: 50173 RVA: 0x003A2308 File Offset: 0x003A0508
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

	// Token: 0x0600C3FE RID: 50174 RVA: 0x003A237C File Offset: 0x003A057C
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

	// Token: 0x0600C3FF RID: 50175 RVA: 0x003A2400 File Offset: 0x003A0600
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

	// Token: 0x0600C400 RID: 50176 RVA: 0x003A24A4 File Offset: 0x003A06A4
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

	// Token: 0x0600C401 RID: 50177 RVA: 0x003A2548 File Offset: 0x003A0748
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

	// Token: 0x0600C402 RID: 50178 RVA: 0x003A2588 File Offset: 0x003A0788
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

	// Token: 0x0600C403 RID: 50179 RVA: 0x003A2768 File Offset: 0x003A0968
	private void OnCurrencyRefresh(IReadOnlyList<int> _)
	{
		this.OnCurrencyRefresh(new List<IProto_NormalItem>());
	}

	// Token: 0x0600C404 RID: 50180 RVA: 0x003A2778 File Offset: 0x003A0978
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

	// Token: 0x04006FD1 RID: 28625
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006FD2 RID: 28626
	[Nullable(2)]
	protected HonamiStoryBackpackLevelItem TeamDataItem;

	// Token: 0x04006FD3 RID: 28627
	private HonamiStoryPlayerBackpackData BackpackData;

	// Token: 0x04006FD4 RID: 28628
	private readonly List<HonamiStoryRoleEquipItem> RoleEquipItemList = new List<HonamiStoryRoleEquipItem>();

	// Token: 0x04006FD5 RID: 28629
	[Nullable(2)]
	private HonamiStoryRoleEquipItem CurSelectRoleEquipItem;

	// Token: 0x04006FD6 RID: 28630
	[Nullable(2)]
	private HonamiStoryGridItemBase HoverItem;

	// Token: 0x04006FD7 RID: 28631
	[Nullable(2)]
	protected HonamiStoryBackpackInsteadItem InsteadValueItem;

	// Token: 0x04006FD8 RID: 28632
	[Nullable(2)]
	private HonamiStoryRoleTipItem RoleTipItem;

	// Token: 0x04006FD9 RID: 28633
	[Nullable(2)]
	private ButtonItem ButtonQuickAll;

	// Token: 0x04006FDA RID: 28634
	[Nullable(2)]
	private ButtonItem ButtonUnload;

	// Token: 0x04006FDB RID: 28635
	private double LastClickTime;

	// Token: 0x04006FDC RID: 28636
	public float ViewPanelHeight;

	// Token: 0x04006FDD RID: 28637
	protected float SelfHeight;

	// Token: 0x04006FDE RID: 28638
	protected float SelfOldHeight;

	// Token: 0x04006FDF RID: 28639
	protected float ContentHeight;

	// Token: 0x020075C6 RID: 30150
	[NullableContext(0)]
	private enum EComponent
	{
		// Token: 0x040263C8 RID: 156616
		TeamDataItem,
		// Token: 0x040263C9 RID: 156617
		RoleEquipRoot,
		// Token: 0x040263CA RID: 156618
		RoleEquipItem,
		// Token: 0x040263CB RID: 156619
		SpriteGridMask,
		// Token: 0x040263CC RID: 156620
		SpriteGridState,
		// Token: 0x040263CD RID: 156621
		BtnMask,
		// Token: 0x040263CE RID: 156622
		InsteadModeItem,
		// Token: 0x040263CF RID: 156623
		BtnQuickAll,
		// Token: 0x040263D0 RID: 156624
		BtnUnload,
		// Token: 0x040263D1 RID: 156625
		PanelButton,
		// Token: 0x040263D2 RID: 156626
		PanelBg,
		// Token: 0x040263D3 RID: 156627
		TipLayout,
		// Token: 0x040263D4 RID: 156628
		QuickAllNiagara,
		// Token: 0x040263D5 RID: 156629
		Content,
		// Token: 0x040263D6 RID: 156630
		SvDefault,
		// Token: 0x040263D7 RID: 156631
		Viewport,
		// Token: 0x040263D8 RID: 156632
		PanelSaleCancel,
		// Token: 0x040263D9 RID: 156633
		SpriteEquipBgB,
		// Token: 0x040263DA RID: 156634
		PanelSelf
	}
}
