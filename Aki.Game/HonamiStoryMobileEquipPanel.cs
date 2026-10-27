using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.HonamiStory;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E97 RID: 7831
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryMobileEquipPanel : HonamiStoryBackpackPanelBase
{
	// Token: 0x0600F04C RID: 61516 RVA: 0x003998CC File Offset: 0x00397ACC
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

	// Token: 0x0600F04D RID: 61517 RVA: 0x00399A7C File Offset: 0x00397C7C
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

	// Token: 0x0600F04E RID: 61518 RVA: 0x00399B02 File Offset: 0x00397D02
	protected override void OnBeforeShow()
	{
		this.RefreshNeedQuickAll();
		this.AddEventListener();
	}

	// Token: 0x0600F04F RID: 61519 RVA: 0x00399B10 File Offset: 0x00397D10
	protected override void OnAfterShow()
	{
		if (this.RoleEquipItemList.Count > 0)
		{
			this.ScrollAfterInit();
		}
	}

	// Token: 0x0600F050 RID: 61520 RVA: 0x00399B28 File Offset: 0x00397D28
	private void AddEventListener()
	{
		this.ScrollView.OnScrollValueChange.Bind(new Action<FVector2D>(this.OnScrollValueChange));
		EventSystem.Instance.Add<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Add<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Add(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600F051 RID: 61521 RVA: 0x00399BA5 File Offset: 0x00397DA5
	protected override void OnBeforeHide()
	{
		this.RemoveEventListener();
	}

	// Token: 0x0600F052 RID: 61522 RVA: 0x00399BB0 File Offset: 0x00397DB0
	private void RemoveEventListener()
	{
		this.ScrollView.OnScrollValueChange.Unbind();
		EventSystem.Instance.Remove<HonamiStoryBagUpdateContext>(EEventName.OnHonamiStoryBackpackUpdate, new Action<HonamiStoryBagUpdateContext>(this.OnHonamiStoryBackpackUpdate));
		EventSystem.Instance.Remove<int, int>(EEventName.OnHonamiStoryPowerLevelUpdate, new Action<int, int>(this.OnPowerLevelChange));
		EventSystem.Instance.Remove(EEventName.OnHonamiStorySortSuccess, new Action(this.OnSortSuccess));
	}

	// Token: 0x0600F053 RID: 61523 RVA: 0x00399C24 File Offset: 0x00397E24
	public UniTask Init()
	{
		HonamiStoryMobileEquipPanel.<Init>d__34 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<Init>d__34>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600F054 RID: 61524 RVA: 0x00399C68 File Offset: 0x00397E68
	private UniTask InitRoleEquipItemList()
	{
		HonamiStoryMobileEquipPanel.<InitRoleEquipItemList>d__35 <InitRoleEquipItemList>d__;
		<InitRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitRoleEquipItemList>d__.<>4__this = this;
		<InitRoleEquipItemList>d__.<>1__state = -1;
		<InitRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<InitRoleEquipItemList>d__35>(ref <InitRoleEquipItemList>d__);
		return <InitRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600F055 RID: 61525 RVA: 0x00399CAC File Offset: 0x00397EAC
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

	// Token: 0x0600F056 RID: 61526 RVA: 0x00399CF8 File Offset: 0x00397EF8
	private UniTask InitBackpackPanel()
	{
		HonamiStoryMobileEquipPanel.<InitBackpackPanel>d__37 <InitBackpackPanel>d__;
		<InitBackpackPanel>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<InitBackpackPanel>d__.<>4__this = this;
		<InitBackpackPanel>d__.<>1__state = -1;
		<InitBackpackPanel>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<InitBackpackPanel>d__37>(ref <InitBackpackPanel>d__);
		return <InitBackpackPanel>d__.<>t__builder.Task;
	}

	// Token: 0x0600F057 RID: 61527 RVA: 0x00399D3B File Offset: 0x00397F3B
	public override bool OnDragBegin([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		this.RefreshScrollMoveState(null);
		return base.OnDragBegin(eventData, item);
	}

	// Token: 0x0600F058 RID: 61528 RVA: 0x00399D53 File Offset: 0x00397F53
	public override bool OnDrag([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(item);
		return base.OnDrag(eventData, item);
	}

	// Token: 0x0600F059 RID: 61529 RVA: 0x00399D64 File Offset: 0x00397F64
	public override void OnDragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.RefreshMask(null);
		this.RefreshScrollMoveState(null);
		base.OnDragEnd(eventData, item);
	}

	// Token: 0x0600F05A RID: 61530 RVA: 0x00399D7C File Offset: 0x00397F7C
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

	// Token: 0x0600F05B RID: 61531 RVA: 0x00399DC0 File Offset: 0x00397FC0
	public override void OnHoverEnd()
	{
		this.HoverItem = null;
		this.HoverAgent = null;
		this.RefreshScrollMoveState(null);
		this.RefreshHoverInfo(null, null);
		base.OnCheckAttrItem(null, null);
	}

	// Token: 0x0600F05C RID: 61532 RVA: 0x00399DE7 File Offset: 0x00397FE7
	public override int GetBackpackType()
	{
		return (int)this.BackpackData.GetBackpackType();
	}

	// Token: 0x0600F05D RID: 61533 RVA: 0x00399DF4 File Offset: 0x00397FF4
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

	// Token: 0x0600F05E RID: 61534 RVA: 0x00399E90 File Offset: 0x00398090
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

	// Token: 0x0600F05F RID: 61535 RVA: 0x00399F18 File Offset: 0x00398118
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

	// Token: 0x0600F060 RID: 61536 RVA: 0x00399FC0 File Offset: 0x003981C0
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

	// Token: 0x0600F061 RID: 61537 RVA: 0x0039A068 File Offset: 0x00398268
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

	// Token: 0x0600F062 RID: 61538 RVA: 0x0039A0AC File Offset: 0x003982AC
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

	// Token: 0x0600F063 RID: 61539 RVA: 0x0039A204 File Offset: 0x00398404
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

	// Token: 0x0600F064 RID: 61540 RVA: 0x0039A294 File Offset: 0x00398494
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

	// Token: 0x0600F065 RID: 61541 RVA: 0x0039A32C File Offset: 0x0039852C
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

	// Token: 0x0600F066 RID: 61542 RVA: 0x0039A3F4 File Offset: 0x003985F4
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

	// Token: 0x0600F067 RID: 61543 RVA: 0x0039A410 File Offset: 0x00398610
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

	// Token: 0x0600F068 RID: 61544 RVA: 0x0039A474 File Offset: 0x00398674
	public UniTask RefreshEquipItem()
	{
		HonamiStoryMobileEquipPanel.<RefreshEquipItem>d__55 <RefreshEquipItem>d__;
		<RefreshEquipItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshEquipItem>d__.<>4__this = this;
		<RefreshEquipItem>d__.<>1__state = -1;
		<RefreshEquipItem>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<RefreshEquipItem>d__55>(ref <RefreshEquipItem>d__);
		return <RefreshEquipItem>d__.<>t__builder.Task;
	}

	// Token: 0x0600F069 RID: 61545 RVA: 0x0039A4B8 File Offset: 0x003986B8
	private UniTask RefreshRoleEquipItemList()
	{
		HonamiStoryMobileEquipPanel.<RefreshRoleEquipItemList>d__56 <RefreshRoleEquipItemList>d__;
		<RefreshRoleEquipItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RefreshRoleEquipItemList>d__.<>4__this = this;
		<RefreshRoleEquipItemList>d__.<>1__state = -1;
		<RefreshRoleEquipItemList>d__.<>t__builder.Start<HonamiStoryMobileEquipPanel.<RefreshRoleEquipItemList>d__56>(ref <RefreshRoleEquipItemList>d__);
		return <RefreshRoleEquipItemList>d__.<>t__builder.Task;
	}

	// Token: 0x0600F06A RID: 61546 RVA: 0x0039A4FC File Offset: 0x003986FC
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

	// Token: 0x0600F06B RID: 61547 RVA: 0x0039A564 File Offset: 0x00398764
	private bool CheckCanEquipItem(HonamiStoryEquipGridItem equipItem, HonamiStoryItemDataBase itemData)
	{
		return itemData.GetItemType() == EHonamiStoryItemType.Plugin && equipItem.GetIsUnlock();
	}

	// Token: 0x0600F06C RID: 61548 RVA: 0x0039A57C File Offset: 0x0039877C
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

	// Token: 0x0600F06D RID: 61549 RVA: 0x0039A614 File Offset: 0x00398814
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

	// Token: 0x0600F06E RID: 61550 RVA: 0x0039A6FC File Offset: 0x003988FC
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

	// Token: 0x0600F06F RID: 61551 RVA: 0x0039A82C File Offset: 0x00398A2C
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

	// Token: 0x0600F070 RID: 61552 RVA: 0x0039A8DC File Offset: 0x00398ADC
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

	// Token: 0x0600F071 RID: 61553 RVA: 0x0039A994 File Offset: 0x00398B94
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

	// Token: 0x0600F072 RID: 61554 RVA: 0x0039A9F0 File Offset: 0x00398BF0
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

	// Token: 0x0600F073 RID: 61555 RVA: 0x0039AAB0 File Offset: 0x00398CB0
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

	// Token: 0x0600F074 RID: 61556 RVA: 0x0039AB4C File Offset: 0x00398D4C
	public void OnClickedEquipToggle()
	{
		EToggleState state = (this.CurrentScrollValue <= this.ScrollThreshold) ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		this.ToggleA.SetToggleState(state, false, false, false);
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, base.GetItem(11), true);
	}

	// Token: 0x0600F075 RID: 61557 RVA: 0x0039AB9C File Offset: 0x00398D9C
	public void OnClickedBackpackToggle()
	{
		EToggleState state = (this.CurrentScrollValue <= this.ScrollThreshold) ? EToggleState.ETT_UnChecked : EToggleState.ETT_Checked;
		this.ToggleB.SetToggleState(state, false, false, false);
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, this.BackpackPanel.GetRootItem(), true);
	}

	// Token: 0x0600F076 RID: 61558 RVA: 0x0039ABEC File Offset: 0x00398DEC
	private void OnPowerLevelChange(int oldValue, int newValue)
	{
		this.RefreshNeedQuickAll();
		this.TeamDataItem.RefreshPowerLevel(oldValue != newValue, oldValue < newValue, oldValue, newValue);
	}

	// Token: 0x0600F077 RID: 61559 RVA: 0x0039AC0C File Offset: 0x00398E0C
	private void OnSortSuccess()
	{
		this.ScrollView.StopMovement();
		FVector2D fvector2D = new FVector2D();
		this.ScrollView.ScrollToTop(ref fvector2D, this.BackpackPanel.GetRootItem(), true);
	}

	// Token: 0x0600F078 RID: 61560 RVA: 0x0039AC44 File Offset: 0x00398E44
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

	// Token: 0x0600F079 RID: 61561 RVA: 0x0039AC98 File Offset: 0x00398E98
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

	// Token: 0x0600F07A RID: 61562 RVA: 0x0039ACE8 File Offset: 0x00398EE8
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

	// Token: 0x0600F07B RID: 61563 RVA: 0x0039AD4C File Offset: 0x00398F4C
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

	// Token: 0x04006F2A RID: 28458
	[Nullable(2)]
	private LevelSequencePlayer LevelSequencePlayer;

	// Token: 0x04006F2B RID: 28459
	private bool ActivityOpen;

	// Token: 0x04006F2C RID: 28460
	private double LastClickTime;

	// Token: 0x04006F2D RID: 28461
	private UUIScrollViewWithScrollbarComponent ScrollView;

	// Token: 0x04006F2E RID: 28462
	protected UUIItem ViewportItem;

	// Token: 0x04006F2F RID: 28463
	protected float ViewportHeight;

	// Token: 0x04006F30 RID: 28464
	public UUIItem ContentItem;

	// Token: 0x04006F31 RID: 28465
	[Nullable(2)]
	protected HonamiStoryBackpackLevelItem TeamDataItem;

	// Token: 0x04006F32 RID: 28466
	private HonamiStoryPlayerBackpackData BackpackData;

	// Token: 0x04006F33 RID: 28467
	private readonly List<HonamiStoryRoleEquipItem> RoleEquipItemList = new List<HonamiStoryRoleEquipItem>();

	// Token: 0x04006F34 RID: 28468
	[Nullable(2)]
	private HonamiStoryEquipGridItem HoverItem;

	// Token: 0x04006F35 RID: 28469
	[Nullable(2)]
	private HonamiStoryInteractOperateAgent HoverAgent;

	// Token: 0x04006F36 RID: 28470
	[Nullable(2)]
	protected HonamiStoryBackpackInsteadItem InsteadValueItem;

	// Token: 0x04006F37 RID: 28471
	[Nullable(2)]
	protected HonamiStoryBackpackValueCountItem CurrentValueItem;

	// Token: 0x04006F38 RID: 28472
	[Nullable(2)]
	private ButtonItem ButtonLeft;

	// Token: 0x04006F39 RID: 28473
	[Nullable(2)]
	private ButtonItem ButtonRight;

	// Token: 0x04006F3A RID: 28474
	private bool CurIsEquipPanel = true;

	// Token: 0x04006F3B RID: 28475
	[Nullable(2)]
	private HonamiStoryMobileBagInfoPanel BackpackPanel;

	// Token: 0x04006F3C RID: 28476
	public UUIExtendToggle ToggleA;

	// Token: 0x04006F3D RID: 28477
	public UUIExtendToggle ToggleB;

	// Token: 0x04006F3E RID: 28478
	public UUIItem MoveUpItem;

	// Token: 0x04006F3F RID: 28479
	public UUIItem MoveDownItem;

	// Token: 0x04006F40 RID: 28480
	private bool IsScrollUp;

	// Token: 0x04006F41 RID: 28481
	private int ScrollSpeed = 10;

	// Token: 0x04006F42 RID: 28482
	private float CurrentScrollValue;

	// Token: 0x04006F43 RID: 28483
	private float ScrollThreshold;

	// Token: 0x02008457 RID: 33879
	[NullableContext(0)]
	private enum EDefine
	{
		// Token: 0x0402B12C RID: 176428
		LevelItem,
		// Token: 0x0402B12D RID: 176429
		PanelEquipList,
		// Token: 0x0402B12E RID: 176430
		HonamiStoryRoleItem,
		// Token: 0x0402B12F RID: 176431
		SpriteMask,
		// Token: 0x0402B130 RID: 176432
		SpriteState,
		// Token: 0x0402B131 RID: 176433
		BtnMask,
		// Token: 0x0402B132 RID: 176434
		ReplaceItem,
		// Token: 0x0402B133 RID: 176435
		BtnSell,
		// Token: 0x0402B134 RID: 176436
		BtnSort,
		// Token: 0x0402B135 RID: 176437
		PanelBottom,
		// Token: 0x0402B136 RID: 176438
		PanelBg,
		// Token: 0x0402B137 RID: 176439
		PanelTipsLayout,
		// Token: 0x0402B138 RID: 176440
		Niagara,
		// Token: 0x0402B139 RID: 176441
		Content,
		// Token: 0x0402B13A RID: 176442
		SvList,
		// Token: 0x0402B13B RID: 176443
		Viewport,
		// Token: 0x0402B13C RID: 176444
		ValueItem,
		// Token: 0x0402B13D RID: 176445
		EquipBg
	}
}
