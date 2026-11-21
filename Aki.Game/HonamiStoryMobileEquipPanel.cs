using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001359 RID: 4953
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMobileEquipPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600C46B RID: 50283 RVA: 0x003A5488 File Offset: 0x003A3688
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
			new ValueTuple<int, Type>(15, typeof(UUIItem)),
			new ValueTuple<int, Type>(16, typeof(UUIItem)),
			new ValueTuple<int, Type>(17, typeof(UUISprite))
		};
	}

	// Token: 0x0600C46C RID: 50284 RVA: 0x003A5638 File Offset: 0x003A3838
	protected override void OnStart()
	{
		this.LevelSequencePlayer = new LevelSequencePlayer(this.RootItem);
		this.ScrollSpeed = HonamiStoryConfig.Instance.GetScrollingSpeed();
		this.ScrollView = base.GetScrollViewWithScrollbar(14);
		this.ViewportItem = base.GetItem(15);
		this.ContentItem = base.GetItem(13);
		this.ViewportHeight = this.ViewportItem.GetHeight();
		HonamiStoryActivityData activityData = HonamiStoryModel.Instance.GetActivityData(false);
		this.ActivityOpen = (activityData != null && activityData.GetPreGuideQuestFinishState());
	}

	// Token: 0x0600C46D RID: 50285 RVA: 0x003A56BE File Offset: 0x003A38BE
	protected override void OnBeforeShow()
	{
		this.RefreshNeedQuickAll();
		this.AddEventListener();
	}

	// Token: 0x0600C46E RID: 50286 RVA: 0x003A56CC File Offset: 0x003A38CC
	protected override void OnAfterShow()
	{
		if (this.RoleEquipItemList.Count > 0)
		{
			this.ScrollAfterInit();
		}
	}

	// Token: 0x0600C46F RID: 50287 RVA: 0x003A56E4 File Offset: 0x003A38E4
	private void AddEventListener()
	{
		this.ScrollView.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Add(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600C470 RID: 50288 RVA: 0x003A5761 File Offset: 0x003A3961
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600C471 RID: 50289 RVA: 0x003A576C File Offset: 0x003A396C
	private void RemoveEventListener()
	{
		this.ScrollView.OnScrollValueChange.Unbind();
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600C472 RID: 50290 RVA: 0x003A57E0 File Offset: 0x003A39E0
	public UniTask Init()
	{
		HonamiStoryMobileEquipPanel.<Init>d__34 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<Init>d__34>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600C473 RID: 50291 RVA: 0x003A5824 File Offset: 0x003A3A24
	private UniTask InitRoleEquipItemList()
	{
		HonamiStoryMobileEquipPanel.<InitRoleEquipItemList>d__35 <InitRoleEquipItemList>d__;
		<InitRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleEquipItemList>d__.<>4__this = this;
		<InitRoleEquipItemList>d__.<>1__state = -1;
		<InitRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<InitRoleEquipItemList>d__35>(ref <InitRoleEquipItemList>d__);
		return <InitRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C474 RID: 50292 RVA: 0x003A5868 File Offset: 0x003A3A68
	private UniTask InitRoleEquipItem(HonamiStoryRoleEquipData equipData)
	{
		HonamiStoryMobileEquipPanel.<InitRoleEquipItem>d__36 <InitRoleEquipItem>d__;
		<InitRoleEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleEquipItem>d__.<>4__this = this;
		<InitRoleEquipItem>d__.equipData = equipData;
		<InitRoleEquipItem>d__.<>1__state = -1;
		<InitRoleEquipItem>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<InitRoleEquipItem>d__36>(ref <InitRoleEquipItem>d__);
		return <InitRoleEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C475 RID: 50293 RVA: 0x003A58B4 File Offset: 0x003A3AB4
	private UniTask InitBackpackPanel()
	{
		HonamiStoryMobileEquipPanel.<InitBackpackPanel>d__37 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<InitBackpackPanel>d__37>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600C476 RID: 50294 RVA: 0x003A58F7 File Offset: 0x003A3AF7
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		this.RefreshScrollMoveState(null);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600C477 RID: 50295 RVA: 0x003A590F File Offset: 0x003A3B0F
	public override bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		return base.OnDrag(eventData, item);
	}

	// Token: 0x0600C478 RID: 50296 RVA: 0x003A5920 File Offset: 0x003A3B20
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(null);
		this.RefreshScrollMoveState(null);
		base.OnDragEnd(eventData, item);
	}

	// Token: 0x0600C479 RID: 50297 RVA: 0x003A5938 File Offset: 0x003A3B38
	public override void OnHover(ULGUIPointerEventData eventData, HonamiStoryInteractOperateAgent operateAgent)
	{
		HonamiStoryEquipGridItem equipItemByEventData = this.GetEquipItemByEventData(eventData);
		this.RefreshScrollMoveState(eventData);
		if (this.HoverItem == equipItemByEventData)
		{
			return;
		}
		this.HoverItem = equipItemByEventData;
		this.HoverAgent = operateAgent;
		this.RefreshHoverInfo(equipItemByEventData, operateAgent);
		base.OnCheckAttrItem(equipItemByEventData, operateAgent);
	}

	// Token: 0x0600C47A RID: 50298 RVA: 0x003A597C File Offset: 0x003A3B7C
	public override void OnHoverEnd()
	{
		this.HoverItem = null;
		this.HoverAgent = null;
		this.RefreshScrollMoveState(null);
		this.RefreshHoverInfo(null, null);
		base.OnCheckAttrItem(null, null);
	}

	// Token: 0x0600C47B RID: 50299 RVA: 0x003A59A3 File Offset: 0x003A3BA3
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.GetBackpackType();
	}

	// Token: 0x0600C47C RID: 50300 RVA: 0x003A59B0 File Offset: 0x003A3BB0
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

	// Token: 0x0600C47D RID: 50301 RVA: 0x003A5A4C File Offset: 0x003A3C4C
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

	// Token: 0x0600C47E RID: 50302 RVA: 0x003A5AD4 File Offset: 0x003A3CD4
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

	// Token: 0x0600C47F RID: 50303 RVA: 0x003A5B7C File Offset: 0x003A3D7C
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

	// Token: 0x0600C480 RID: 50304 RVA: 0x003A5C24 File Offset: 0x003A3E24
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

	// Token: 0x0600C481 RID: 50305 RVA: 0x003A5C68 File Offset: 0x003A3E68
	public override void OnBackpackLogicStateChange(EHonamiStoryBackpackLogicState state)
	{
		if (state == EHonamiStoryBackpackLogicState.Normal)
		{
			this.SetPanelAlpha(state);
			this.RefreshBottomPanel();
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
		if (state == EHonamiStoryBackpackLogicState.TipsWithPlugins || state == EHonamiStoryBackpackLogicState.Tips)
		{
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
		if (state == EHonamiStoryBackpackLogicState.Dragging || state == EHonamiStoryBackpackLogicState.DraggingPlugins)
		{
			this.SetPanelAlpha(state);
			this.RefreshBottomPanel();
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
			this.RefreshBottomPanel();
			foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem4 in this.RoleEquipItemList)
			{
				honamiStoryRoleEquipItem4.RefreshState(state);
			}
		}
	}

	// Token: 0x0600C482 RID: 50306 RVA: 0x003A5DC0 File Offset: 0x003A3FC0
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

	// Token: 0x0600C483 RID: 50307 RVA: 0x003A5E50 File Offset: 0x003A4050
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

	// Token: 0x0600C484 RID: 50308 RVA: 0x003A5EE8 File Offset: 0x003A40E8
	protected void RefreshSelfPanel()
	{
		float height = base.GetItem(2).GetHeight();
		float spacing = (base.GetItem(1).GetOwner().GetComponentByClass(UUIVerticalLayout.StaticClass()) as UUIVerticalLayout).GetSpacing();
		int count = this.RoleEquipItemList.Count;
		float num = (float)count * height + Math.Max(0f, spacing * (float)(count - 1));
		float num2 = Math.Abs(base.GetItem(11).GetAnchorOffsetY());
		float num3 = num + num2 * 2f;
		HonamiStoryBackpackData backPackData = HonamiStoryModel.Instance.GetBackPackData(2, false);
		int num4 = backPackData.GetCellHeight() * backPackData.GetHeightCount(false);
		float height2 = Math.Min(this.RootItem.GetHeight(), num3 + (float)num4);
		UUIItem rootItem = this.RootItem;
		if (rootItem == null)
		{
			return;
		}
		rootItem.SetHeight(height2);
	}

	// Token: 0x0600C485 RID: 50309 RVA: 0x003A5FB0 File Offset: 0x003A41B0
	protected void ScrollAfterInit()
	{
		TimerSystem.Instance.Next(delegate(float _)
		{
			float height = base.GetItem(11).GetHeight();
			float height2 = this.ContentItem.GetHeight();
			float height3 = this.ViewportItem.GetHeight();
			this.ScrollThreshold = height / (height2 - height3);
			HonamiStoryRoleEquipItem honamiStoryRoleEquipItem = this.RoleEquipItemList[this.RoleEquipItemList.Count - 1];
			FVector2D fvector2D = new FVector2D();
			this.ScrollView.ScrollToTop(ref fvector2D, honamiStoryRoleEquipItem.GetRootItem(), true);
		}, null, null);
	}

	// Token: 0x0600C486 RID: 50310 RVA: 0x003A5FCC File Offset: 0x003A41CC
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

	// Token: 0x0600C487 RID: 50311 RVA: 0x003A6030 File Offset: 0x003A4230
	public UniTask RefreshEquipItem()
	{
		HonamiStoryMobileEquipPanel.<RefreshEquipItem>d__55 <RefreshEquipItem>d__;
		<RefreshEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEquipItem>d__.<>4__this = this;
		<RefreshEquipItem>d__.<>1__state = -1;
		<RefreshEquipItem>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<RefreshEquipItem>d__55>(ref <RefreshEquipItem>d__);
		return <RefreshEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600C488 RID: 50312 RVA: 0x003A6074 File Offset: 0x003A4274
	private UniTask RefreshRoleEquipItemList()
	{
		HonamiStoryMobileEquipPanel.<RefreshRoleEquipItemList>d__56 <RefreshRoleEquipItemList>d__;
		<RefreshRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleEquipItemList>d__.<>4__this = this;
		<RefreshRoleEquipItemList>d__.<>1__state = -1;
		<RefreshRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<RefreshRoleEquipItemList>d__56>(ref <RefreshRoleEquipItemList>d__);
		return <RefreshRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600C489 RID: 50313 RVA: 0x003A60B8 File Offset: 0x003A42B8
	[return: Nullable(2)]
	private HonamiStoryEquipGridItem GetEquipItemByEventData(ULGUIPointerEventData eventData)
	{
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			if (HonamiStoryUtil.CheckEventDataInItemViewport(eventData, honamiStoryRoleEquipItem.GetRootItem(), true))
			{
				return honamiStoryRoleEquipItem.GetEquipItemByEventData(eventData);
			}
		}
		return null;
	}

	// Token: 0x0600C48A RID: 50314 RVA: 0x003A6120 File Offset: 0x003A4320
	private bool CheckCanEquipItem(HonamiStoryEquipGridItem equipItem, HonamiStoryItemDataBase itemData)
	{
		return itemData.GetItemType() == EHonamiStoryItemType.Plugin && equipItem.GetIsUnlock();
	}

	// Token: 0x0600C48B RID: 50315 RVA: 0x003A6138 File Offset: 0x003A4338
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

	// Token: 0x0600C48C RID: 50316 RVA: 0x003A61D0 File Offset: 0x003A43D0
	protected void SetPanelAlpha(EHonamiStoryBackpackLogicState state)
	{
		bool flag = state == EHonamiStoryBackpackLogicState.Normal;
		bool flag2 = state == EHonamiStoryBackpackLogicState.Dragging || state == EHonamiStoryBackpackLogicState.DraggingPlugins;
		HonamiStoryBackpackLevelItem teamDataItem = this.TeamDataItem;
		if (teamDataItem != null)
		{
			teamDataItem.SetIsEnable(flag || flag2);
		}
		foreach (HonamiStoryRoleEquipItem honamiStoryRoleEquipItem in this.RoleEquipItemList)
		{
			honamiStoryRoleEquipItem.SetEnableState(state);
		}
		this.ToggleA.RootUIComp.Get().SetAlpha((!flag2) ? 1f : 0.4f);
		this.ToggleB.RootUIComp.Get().SetAlpha((!flag2) ? 1f : 0.4f);
		UUISprite sprite = base.GetSprite(17);
		if (sprite == null)
		{
			return;
		}
		sprite.SetAlpha((flag || flag2) ? 1f : 0.4f);
	}

	// Token: 0x0600C48D RID: 50317 RVA: 0x003A62B8 File Offset: 0x003A44B8
	protected void RefreshBottomPanel()
	{
		EHonamiStoryBackpackLogicState backpackLogicState = HonamiStoryModel.Instance.GetBackpackLogicState();
		bool flag = backpackLogicState == EHonamiStoryBackpackLogicState.Instead;
		bool flag2 = backpackLogicState == EHonamiStoryBackpackLogicState.Dragging || backpackLogicState == EHonamiStoryBackpackLogicState.DraggingPlugins;
		HonamiStoryBackpackInsteadItem insteadValueItem = this.InsteadValueItem;
		if (insteadValueItem != null)
		{
			insteadValueItem.SetVisible(flag);
		}
		HonamiStoryBackpackValueCountItem currentValueItem = this.CurrentValueItem;
		if (currentValueItem != null)
		{
			currentValueItem.SetVisible(!flag && this.ActivityOpen && !this.CurIsEquipPanel);
		}
		if (!flag)
		{
			string textId = this.CurIsEquipPanel ? "HonamiStory_QuickUnloadAll" : "HonamiStory_BackpackSort";
			ButtonItem buttonRight = this.ButtonRight;
			if (buttonRight != null)
			{
				buttonRight.SetLocalTextNew(textId, Array.Empty<object>());
			}
		}
		ButtonItem buttonRight2 = this.ButtonRight;
		if (buttonRight2 != null)
		{
			buttonRight2.SetUiActive(!flag);
		}
		ButtonItem buttonLeft = this.ButtonLeft;
		if (buttonLeft != null)
		{
			buttonLeft.SetUiActive(this.CurIsEquipPanel && !flag);
		}
		ButtonItem buttonRight3 = this.ButtonRight;
		if (buttonRight3 != null)
		{
			buttonRight3.SetEnableClick(!flag2);
		}
		ButtonItem buttonLeft2 = this.ButtonLeft;
		if (buttonLeft2 != null)
		{
			buttonLeft2.SetEnableClick(!flag2);
		}
		float alpha = (!flag2) ? 1f : 0.4f;
		ButtonItem buttonRight4 = this.ButtonRight;
		if (buttonRight4 != null)
		{
			buttonRight4.GetRootItem().SetAlpha(alpha);
		}
		ButtonItem buttonLeft3 = this.ButtonLeft;
		if (buttonLeft3 == null)
		{
			return;
		}
		buttonLeft3.GetRootItem().SetAlpha(alpha);
	}

	// Token: 0x0600C48E RID: 50318 RVA: 0x003A63E8 File Offset: 0x003A45E8
	[NullableContext(2)]
	protected void RefreshScrollMoveState(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			this.MoveUpItem.SetUIActive(false);
			this.MoveDownItem.SetUIActive(false);
			return;
		}
		float stretchTop = this.ContentItem.GetStretchTop();
		bool flag = HonamiStoryUtil.CheckEventDataInItemViewport(eventData, this.MoveUpItem, true) && stretchTop < 0f;
		float stretchBottom = this.ContentItem.GetStretchBottom();
		bool flag2 = HonamiStoryUtil.CheckEventDataInItemViewport(eventData, this.MoveDownItem, true) && stretchBottom < 0f;
		this.MoveUpItem.SetUIActive(flag);
		this.MoveDownItem.SetUIActive(flag2);
		if (flag || flag2)
		{
			float scrollSpeedMulti = this.GetScrollSpeedMulti(flag, eventData);
			this.IsScrollUp = flag;
			this.OnHoveringUpDownPanel(scrollSpeedMulti);
		}
	}

	// Token: 0x0600C48F RID: 50319 RVA: 0x003A6498 File Offset: 0x003A4698
	private void OnHoveringUpDownPanel(float multi)
	{
		FVector location = this.ContentItem.GetRelativeTransform().GetLocation();
		float num = (float)(this.IsScrollUp ? (-(float)this.ScrollSpeed) : this.ScrollSpeed) * multi;
		this.ScrollView.SetScrollValue(new FVector2D(0f, Math.Max(0f, location.Y + num)));
		float stretchTop = this.ContentItem.GetStretchTop();
		float stretchBottom = this.ContentItem.GetStretchBottom();
		if (this.IsScrollUp && stretchTop >= 0f)
		{
			this.MoveUpItem.SetUIActive(false);
			return;
		}
		if (!this.IsScrollUp && stretchBottom >= 0f)
		{
			this.MoveDownItem.SetUIActive(false);
		}
	}

	// Token: 0x0600C490 RID: 50320 RVA: 0x003A6550 File Offset: 0x003A4750
	private float GetScrollSpeedMulti(bool isUp, ULGUIPointerEventData eventData)
	{
		UUIItem uuiitem = isUp ? this.MoveUpItem : this.MoveDownItem;
		FVector offsetVector = HonamiStoryUtil.GetOffsetVector(eventData.GetWorldPointInPlane());
		FVector uiworldPosition = uuiitem.GetUIWorldPosition();
		if (isUp)
		{
			return (float)((offsetVector.Z > uiworldPosition.Z) ? 2 : 1);
		}
		return (float)((offsetVector.Z > uiworldPosition.Z) ? 1 : 2);
	}

	// Token: 0x0600C491 RID: 50321 RVA: 0x003A65AC File Offset: 0x003A47AC
	private void ToggleUpdateWhenScrollValueChange(FVector2D? inVector)
	{
		if (inVector == null)
		{
			return;
		}
		float height = base.GetItem(11).GetHeight();
		float height2 = this.ContentItem.GetHeight();
		float height3 = this.ViewportItem.GetHeight();
		this.ScrollThreshold = height / (height2 - height3);
		this.CurrentScrollValue = inVector.Value.Y;
		EToggleState state = (this.CurrentScrollValue <= this.ScrollThreshold) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		EToggleState state2 = (this.CurrentScrollValue <= this.ScrollThreshold) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		this.CurIsEquipPanel = (this.CurrentScrollValue <= this.ScrollThreshold);
		this.RefreshBottomPanel();
		this.ToggleA.SetToggleState(state, false, false, false);
		this.ToggleB.SetToggleState(state2, false, false, false);
	}

	// Token: 0x0600C492 RID: 50322 RVA: 0x003A666C File Offset: 0x003A486C
	public void RefreshNeedQuickAll()
	{
		if (base.GetUiNiagara(12) == null)
		{
			return;
		}
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

	// Token: 0x0600C493 RID: 50323 RVA: 0x003A6708 File Offset: 0x003A4908
	public void OnClickedEquipToggle()
	{
		EToggleState state = (this.CurrentScrollValue <= this.ScrollThreshold) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.ToggleA.SetToggleState(state, false, false, false);
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, base.GetItem(11), true);
	}

	// Token: 0x0600C494 RID: 50324 RVA: 0x003A6758 File Offset: 0x003A4958
	public void OnClickedBackpackToggle()
	{
		EToggleState state = (this.CurrentScrollValue <= this.ScrollThreshold) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		this.ToggleB.SetToggleState(state, false, false, false);
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, this.BackpackPanel.GetRootItem(), true);
	}

	// Token: 0x0600C495 RID: 50325 RVA: 0x003A67A8 File Offset: 0x003A49A8
	private void OnPowerLevelChange(int oldValue, int newValue)
	{
		this.RefreshNeedQuickAll();
		this.TeamDataItem.RefreshPowerLevel(oldValue != newValue, oldValue < newValue, oldValue, newValue);
	}

	// Token: 0x0600C496 RID: 50326 RVA: 0x003A67C8 File Offset: 0x003A49C8
	private void OnSortSuccess()
	{
		this.ScrollView.StopMovement();
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, this.BackpackPanel.GetRootItem(), true);
	}

	// Token: 0x0600C497 RID: 50327 RVA: 0x003A6800 File Offset: 0x003A4A00
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
		});
	}

	// Token: 0x0600C498 RID: 50328 RVA: 0x003A6854 File Offset: 0x003A4A54
	private void OnScrollValueChange(FVector2D inVector)
	{
		this.ToggleUpdateWhenScrollValueChange(new FVector2D?(inVector));
		HonamiStoryModel.Instance.GetInteractController().RefreshSelectedUiItem();
		this.BackpackPanel.UpdateViewportItems();
		if (this.HoverItem != null)
		{
			this.RefreshHoverInfo(this.HoverItem, this.HoverAgent);
		}
	}

	// Token: 0x0600C499 RID: 50329 RVA: 0x003A68A4 File Offset: 0x003A4AA4
	private void OnClickLeft(int _)
	{
		double now = Time.Instance.Now;
		if (now - this.LastClickTime < 300.0)
		{
			return;
		}
		this.LastClickTime = now;
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		EHonamiStoryBackpackLogicState logicState = backpackLogic.GetLogicState();
		if (logicState == EHonamiStoryBackpackLogicState.Normal)
		{
			HonamiStoryModel.Instance.ApplyQuickAll();
			return;
		}
		if ((logicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || logicState == EHonamiStoryBackpackLogicState.Tips) && backpackLogic != null)
		{
			backpackLogic.CloseTips();
		}
	}

	// Token: 0x0600C49A RID: 50330 RVA: 0x003A6908 File Offset: 0x003A4B08
	private void OnClickRight(int _)
	{
		double now = Time.Instance.Now;
		if (now - this.LastClickTime < 300.0)
		{
			return;
		}
		this.LastClickTime = now;
		HonamiStoryBackpackLogicController backpackLogic = HonamiStoryModel.Instance.GetBackpackLogic();
		EHonamiStoryBackpackLogicState logicState = backpackLogic.GetLogicState();
		if (logicState != EHonamiStoryBackpackLogicState.Normal)
		{
			if ((logicState == EHonamiStoryBackpackLogicState.TipsWithPlugins || logicState == EHonamiStoryBackpackLogicState.Tips) && backpackLogic != null)
			{
				backpackLogic.CloseTips();
			}
			return;
		}
		if (this.CurIsEquipPanel)
		{
			HonamiStoryModel.Instance.QuickUnloadAllSlot();
			return;
		}
		HonamiStoryModel.Instance.SortBackpack();
	}

	// Token: 0x0400700B RID: 28683
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x0400700C RID: 28684
	private bool ActivityOpen;

	// Token: 0x0400700D RID: 28685
	private double LastClickTime;

	// Token: 0x0400700E RID: 28686
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x0400700F RID: 28687
	protected UUIItem ViewportItem;

	// Token: 0x04007010 RID: 28688
	protected float ViewportHeight;

	// Token: 0x04007011 RID: 28689
	public UUIItem ContentItem;

	// Token: 0x04007012 RID: 28690
	[Nullable(2)]
	protected HonamiStoryBackpackLevelItem TeamDataItem;

	// Token: 0x04007013 RID: 28691
	private HonamiStoryPlayerBackpackData BackpackData;

	// Token: 0x04007014 RID: 28692
	private readonly List<HonamiStoryRoleEquipItem> RoleEquipItemList = new List<HonamiStoryRoleEquipItem>();

	// Token: 0x04007015 RID: 28693
	[Nullable(2)]
	private HonamiStoryEquipGridItem HoverItem;

	// Token: 0x04007016 RID: 28694
	[Nullable(2)]
	private HonamiStoryInteractOperateAgent HoverAgent;

	// Token: 0x04007017 RID: 28695
	[Nullable(2)]
	protected HonamiStoryBackpackInsteadItem InsteadValueItem;

	// Token: 0x04007018 RID: 28696
	[Nullable(2)]
	protected HonamiStoryBackpackValueCountItem CurrentValueItem;

	// Token: 0x04007019 RID: 28697
	[Nullable(2)]
	private ButtonItem ButtonLeft;

	// Token: 0x0400701A RID: 28698
	[Nullable(2)]
	private ButtonItem ButtonRight;

	// Token: 0x0400701B RID: 28699
	private bool CurIsEquipPanel = true;

	// Token: 0x0400701C RID: 28700
	[Nullable(2)]
	private HonamiStoryMobileBagInfoPanel BackpackPanel;

	// Token: 0x0400701D RID: 28701
	public UUIExtendToggle ToggleA;

	// Token: 0x0400701E RID: 28702
	public UUIExtendToggle ToggleB;

	// Token: 0x0400701F RID: 28703
	public UUIItem MoveUpItem;

	// Token: 0x04007020 RID: 28704
	public UUIItem MoveDownItem;

	// Token: 0x04007021 RID: 28705
	private bool IsScrollUp;

	// Token: 0x04007022 RID: 28706
	private int ScrollSpeed = 10;

	// Token: 0x04007023 RID: 28707
	private float CurrentScrollValue;

	// Token: 0x04007024 RID: 28708
	private float ScrollThreshold;

	// Token: 0x020075DC RID: 30172
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x04026450 RID: 156752
		LevelItem,
		// Token: 0x04026451 RID: 156753
		PanelEquipList,
		// Token: 0x04026452 RID: 156754
		HonamiStoryRoleItem,
		// Token: 0x04026453 RID: 156755
		SpriteMask,
		// Token: 0x04026454 RID: 156756
		SpriteState,
		// Token: 0x04026455 RID: 156757
		BtnMask,
		// Token: 0x04026456 RID: 156758
		ReplaceItem,
		// Token: 0x04026457 RID: 156759
		BtnSell,
		// Token: 0x04026458 RID: 156760
		BtnSort,
		// Token: 0x04026459 RID: 156761
		PanelBottom,
		// Token: 0x0402645A RID: 156762
		PanelBg,
		// Token: 0x0402645B RID: 156763
		PanelTipsLayout,
		// Token: 0x0402645C RID: 156764
		Niagara,
		// Token: 0x0402645D RID: 156765
		Content,
		// Token: 0x0402645E RID: 156766
		SvList,
		// Token: 0x0402645F RID: 156767
		Viewport,
		// Token: 0x04026460 RID: 156768
		ValueItem,
		// Token: 0x04026461 RID: 156769
		EquipBg
	}
}
