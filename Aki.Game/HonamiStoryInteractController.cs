using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001E94 RID: 7828
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryInteractController
{
	// Token: 0x0600EFFF RID: 61439 RVA: 0x00397444 File Offset: 0x00395644
	public UniTask Init(UUIItem attachPanel)
	{
		HonamiStoryInteractController.<Init>d__12 <Init>d__;
		<Init>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<Init>d__.<>4__this = this;
		<Init>d__.attachPanel = attachPanel;
		<Init>d__.<>1__state = -1;
		<Init>d__.<>t__builder.Start<HonamiStoryInteractController.<Init>d__12>(ref <Init>d__);
		return <Init>d__.<>t__builder.Task;
	}

	// Token: 0x0600F000 RID: 61440 RVA: 0x0039748F File Offset: 0x0039568F
	public void OnBeforeShow()
	{
		this.DragItem.GetRootItem().SetPivot(new FVector2D(0.5f, 0.5f));
		this.DragItem.GetOriginalItem().SetUIParent(this.AttachPanel, false);
	}

	// Token: 0x0600F001 RID: 61441 RVA: 0x003974C7 File Offset: 0x003956C7
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.PanelBaseList.Add(panel);
	}

	// Token: 0x0600F002 RID: 61442 RVA: 0x003974D5 File Offset: 0x003956D5
	public void RegisterBackpackView(HonamiStoryBackpackView view)
	{
		this.BackpackView = view;
	}

	// Token: 0x0600F003 RID: 61443 RVA: 0x003974DE File Offset: 0x003956DE
	public void RegisterPickUpView(HonamiStoryPickUpBackpackView view)
	{
		this.PickUpBackpackView = view;
	}

	// Token: 0x0600F004 RID: 61444 RVA: 0x003974E7 File Offset: 0x003956E7
	public void ClearPanel()
	{
		this.PanelBaseList = new List<HonamiStoryBackpackPanelBase>();
	}

	// Token: 0x0600F005 RID: 61445 RVA: 0x003974F4 File Offset: 0x003956F4
	public void RefreshDragItem(HonamiStoryInteractOperateAgent agent, bool isDragCross)
	{
		HonamiStoryItemDataBase operateData = agent.OperateData;
		HonamiStoryItemDataBase data = this.DragItem.GetData();
		bool? flag = (data != null) ? new bool?(data.GetIsDragCross()) : null;
		if (operateData == data)
		{
			bool? flag2 = flag;
			if (isDragCross == flag2.GetValueOrDefault() & flag2 != null)
			{
				return;
			}
		}
		operateData.SetIsDragCross(isDragCross);
		this.DragItem.Refresh(operateData, -1);
		float width = isDragCross ? agent.BaseHeight : agent.BaseWidth;
		float height = isDragCross ? agent.BaseWidth : agent.BaseHeight;
		UUIItem rootItem = this.DragItem.GetRootItem();
		rootItem.SetWidth(width);
		rootItem.SetHeight(height);
	}

	// Token: 0x0600F006 RID: 61446 RVA: 0x003975A0 File Offset: 0x003957A0
	public void SetDragItemPositionByItem(HonamiStoryGridItemBase item)
	{
		FVector dragItemLocation = item.GetRootItem().K2_GetComponentLocation();
		this.SetDragItemLocation(dragItemLocation);
	}

	// Token: 0x0600F007 RID: 61447 RVA: 0x003975C0 File Offset: 0x003957C0
	public void SetDragItemLocation(FVector location)
	{
		HonamiStoryItemDataBase data = this.DragItem.GetData();
		bool isDragCross = data.GetIsDragCross();
		bool flag = HonamiStoryUtil.IsMobileView();
		int num = flag ? 134 : 86;
		int num2 = flag ? 134 : 86;
		int num3 = data.GetBaseGridWidth(isDragCross) * num;
		int num4 = data.GetBaseGridHeight(isDragCross) * num2;
		location.X -= (float)(num3 / 2);
		location.Z += (float)(num4 / 2);
		FHitResult fhitResult = new FHitResult();
		this.DragItem.GetRootItem().K2_SetWorldLocation(location, false, ref fhitResult, false);
	}

	// Token: 0x0600F008 RID: 61448 RVA: 0x00397652 File Offset: 0x00395852
	public UUIItem GetDragTipsRoot()
	{
		return this.DragItem.GetItemGridItem().GetTipsRoot();
	}

	// Token: 0x0600F009 RID: 61449 RVA: 0x00397664 File Offset: 0x00395864
	public FVector GetDragItemLocation()
	{
		return this.DragItem.GetRootItem().K2_GetComponentToWorld().GetLocation();
	}

	// Token: 0x0600F00A RID: 61450 RVA: 0x00397689 File Offset: 0x00395889
	public int GetDragItemIncId()
	{
		return this.DragItem.GetIncId();
	}

	// Token: 0x0600F00B RID: 61451 RVA: 0x00397698 File Offset: 0x00395898
	public bool DragBegin(HonamiStoryBackpackPanelBase backpackPanel, HonamiStoryGridItemBase item)
	{
		this.OperateAgent.Clear();
		this.OperateAgent.BaseWidth = 0f;
		this.OperateAgent.BaseHeight = 0f;
		this.OperateAgent.StartOperateBackpack = backpackPanel;
		this.OperateAgent.OperateData = item.GetData();
		this.RefreshDragItem(this.OperateAgent, false);
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == 4)
			{
				honamiStoryBackpackPanelBase.OnDragBegin(null, item);
				break;
			}
		}
		if (this.BackpackView != null)
		{
			this.BackpackView.OnDragBegin();
		}
		if (this.PickUpBackpackView != null)
		{
			this.PickUpBackpackView.OnDragBegin();
		}
		return true;
	}

	// Token: 0x0600F00C RID: 61452 RVA: 0x00397774 File Offset: 0x00395974
	[NullableContext(2)]
	public void OnDrag(ULGUIPointerEventData eventData)
	{
		if (eventData == null)
		{
			return;
		}
		bool flag = this.DragItem.IsUiActiveInHierarchy();
		this.DragItem.SetUiActive(true);
		if (!flag && HonamiStoryUtil.IsMobileView())
		{
			this.DragItem.PlayMoveItemSeq();
		}
		this.SetDragItemLocation(eventData.GetWorldPointInPlane());
		HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase = null;
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase2 in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase2.CheckDragItemInViewport(eventData))
			{
				if (!HonamiStoryUtil.IsMobileView())
				{
					honamiStoryBackpackPanelBase = honamiStoryBackpackPanelBase2;
					break;
				}
				if (honamiStoryBackpackPanelBase2.GetBackpackType() != 3)
				{
					honamiStoryBackpackPanelBase = honamiStoryBackpackPanelBase2;
					break;
				}
				honamiStoryBackpackPanelBase = honamiStoryBackpackPanelBase2;
			}
		}
		if (honamiStoryBackpackPanelBase == null)
		{
			HonamiStoryBackpackPanelBase targetOperateBackpack = this.OperateAgent.TargetOperateBackpack;
			if (targetOperateBackpack != null)
			{
				targetOperateBackpack.OnHoverEnd();
			}
			this.OperateAgent.TargetOperateBackpack = null;
			this.OperateAgent.TargetPosition = -1;
			return;
		}
		if (this.OperateAgent.TargetOperateBackpack == honamiStoryBackpackPanelBase)
		{
			this.OperateAgent.TargetOperateBackpack.OnHover(eventData, this.OperateAgent);
			return;
		}
		HonamiStoryBackpackPanelBase targetOperateBackpack2 = this.OperateAgent.TargetOperateBackpack;
		if (targetOperateBackpack2 != null)
		{
			targetOperateBackpack2.OnHoverEnd();
		}
		this.OperateAgent.TargetOperateBackpack = honamiStoryBackpackPanelBase;
		HonamiStoryBackpackPanelBase targetOperateBackpack3 = this.OperateAgent.TargetOperateBackpack;
		if (targetOperateBackpack3 == null)
		{
			return;
		}
		targetOperateBackpack3.OnHover(eventData, this.OperateAgent);
	}

	// Token: 0x0600F00D RID: 61453 RVA: 0x003978B8 File Offset: 0x00395AB8
	public void DragEnd([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		this.DragItem.SetUiActive(false);
		this.ExecuteOperate(eventData, item);
		if (this.OperateAgent.TargetOperateBackpack != null)
		{
			this.OperateAgent.TargetOperateBackpack.OnHoverEnd();
		}
		foreach (HonamiStoryBackpackPanelBase honamiStoryBackpackPanelBase in this.PanelBaseList)
		{
			if (honamiStoryBackpackPanelBase.GetBackpackType() == 4)
			{
				honamiStoryBackpackPanelBase.OnDragEnd(null, item);
				break;
			}
		}
		if (this.BackpackView != null)
		{
			this.BackpackView.OnDragEnd();
		}
		if (this.PickUpBackpackView != null)
		{
			this.PickUpBackpackView.OnDragEnd();
		}
	}

	// Token: 0x0600F00E RID: 61454 RVA: 0x00397970 File Offset: 0x00395B70
	private void ExecuteOperate([Nullable(2)] ULGUIPointerEventData eventData, HonamiStoryGridItemBase item)
	{
		if (eventData == null)
		{
			return;
		}
		if (this.OperateAgent.TargetOperateBackpack == null || this.OperateAgent.StartOperateBackpack == null)
		{
			HonamiStoryItemDataBase operateData = this.OperateAgent.OperateData;
			if (operateData != null)
			{
				operateData.SetIsDragCross(operateData.GetIsCross());
			}
			return;
		}
		if (item.GetIsUseCancel())
		{
			return;
		}
		List<HonamiStoryBagUpdateContext> list = new List<HonamiStoryBagUpdateContext>();
		if (this.OperateAgent.TargetOperateBackpack.GetBackpackType() != 4)
		{
			if (this.OperateAgent.TargetOperateBackpack == this.OperateAgent.StartOperateBackpack)
			{
				HonamiStoryBagUpdateContext updateInfoInSameBackpack = this.OperateAgent.TargetOperateBackpack.GetUpdateInfoInSameBackpack(eventData, this.OperateAgent.OperateData);
				if (updateInfoInSameBackpack == null)
				{
					return;
				}
				list.Add(updateInfoInSameBackpack);
			}
			else
			{
				HashSet<HonamiStoryItemDataBase> exchangeItemSet = this.OperateAgent.TargetOperateBackpack.GetExchangeItemSet(eventData, this.OperateAgent.OperateData);
				if (exchangeItemSet == null)
				{
					return;
				}
				if (this.OperateAgent.StartOperateBackpack.GetBackpackType() == 0 && exchangeItemSet.Count > 0)
				{
					int capacity = HonamiStoryModel.Instance.GetBackPackData(1, false).GetCapacity();
					if (this.OperateAgent.OperateData.GetPosition() >= capacity)
					{
						ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_NoSpaceForQuickAll", Array.Empty<object>());
						return;
					}
				}
				if (!this.CheckOperateOnPickUpValid(exchangeItemSet))
				{
					ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_TryDiscardLockItem", Array.Empty<object>());
					return;
				}
				HonamiStoryBagUpdateContext updateInfoInReceiveBackpack = this.OperateAgent.TargetOperateBackpack.GetUpdateInfoInReceiveBackpack(eventData, this.OperateAgent.OperateData, exchangeItemSet);
				if (updateInfoInReceiveBackpack == null)
				{
					return;
				}
				list.Add(updateInfoInReceiveBackpack);
				HonamiStoryBagUpdateContext updateInfoInSendBackpack = this.OperateAgent.StartOperateBackpack.GetUpdateInfoInSendBackpack(eventData, this.OperateAgent.OperateData, exchangeItemSet);
				if (updateInfoInSendBackpack == null)
				{
					return;
				}
				list.Add(updateInfoInSendBackpack);
			}
			HonamiStoryController.Instance.SendHonamiStoryBagOperateRequest(list);
			return;
		}
		if (this.OperateAgent.OperateData.IsLock())
		{
			ScrollingTipsController.Instance.ShowTipsByTextId("HonamiStory_TryDiscardLockItem", Array.Empty<object>());
			return;
		}
		if (!HonamiStoryModel.Instance.GetBackpackLogic().IsBackpackView())
		{
			int backpackType = this.OperateAgent.StartOperateBackpack.GetBackpackType();
			if (backpackType == 2)
			{
				return;
			}
			EHonamiStoryBackpack curBackpack = (backpackType == 3) ? EHonamiStoryBackpack.Player : EHonamiStoryBackpack.Backpack;
			HonamiStoryModel.Instance.SetItemIntoBag(this.OperateAgent.OperateData, curBackpack, EHonamiStoryBackpack.PickUpBox);
		}
		else
		{
			HashSet<HonamiStoryItemDataBase> exchangeItemSet2 = this.OperateAgent.TargetOperateBackpack.GetExchangeItemSet(eventData, this.OperateAgent.OperateData);
			if (exchangeItemSet2 == null)
			{
				return;
			}
			HonamiStoryBagUpdateContext updateInfoInSendBackpack2 = this.OperateAgent.StartOperateBackpack.GetUpdateInfoInSendBackpack(eventData, this.OperateAgent.OperateData, exchangeItemSet2);
			if (updateInfoInSendBackpack2 == null)
			{
				return;
			}
			HonamiStoryController.Instance.SendHonamiStoryDiscardItemRequest(updateInfoInSendBackpack2);
		}
		AudioSystem.Instance.PostEvent("play_ui_honamistory_backpack_discard");
	}

	// Token: 0x0600F00F RID: 61455 RVA: 0x00397C00 File Offset: 0x00395E00
	private bool CheckOperateOnPickUpValid(HashSet<HonamiStoryItemDataBase> exchangeItemSet)
	{
		bool flag = this.OperateAgent.StartOperateBackpack.GetBackpackType() == 2;
		bool flag2 = this.OperateAgent.TargetOperateBackpack.GetBackpackType() == 2;
		if (!flag && !flag2)
		{
			return true;
		}
		if (!flag2)
		{
			using (HashSet<HonamiStoryItemDataBase>.Enumerator enumerator = exchangeItemSet.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.IsLock())
					{
						return false;
					}
				}
			}
			return true;
		}
		if (this.OperateAgent.OperateData.IsLock())
		{
			return false;
		}
		HonamiStoryModel.Instance.ShowDiscardTips(this.OperateAgent.OperateData);
		return true;
	}

	// Token: 0x0600F010 RID: 61456 RVA: 0x00397CB0 File Offset: 0x00395EB0
	public void OnHoverItem(bool isEmptyGrid, UUIItem attachParent)
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return;
		}
		if (this.SelectedItem != null && attachParent == this.SelectedItem.GetPanelForHover())
		{
			return;
		}
		if (isEmptyGrid)
		{
			this.HoverGridUiItem.GetOriginalItem().SetUIParent(attachParent, false);
		}
		else
		{
			this.HoverItemUiItem.GetOriginalItem().SetUIParent(attachParent, false);
		}
		this.HoverGridUiItem.SetUiActive(isEmptyGrid);
		this.HoverItemUiItem.SetUiActive(!isEmptyGrid);
	}

	// Token: 0x0600F011 RID: 61457 RVA: 0x00397D20 File Offset: 0x00395F20
	public void OnUnHover()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return;
		}
		this.HoverGridUiItem.SetUiActive(false);
		this.HoverItemUiItem.SetUiActive(false);
	}

	// Token: 0x0600F012 RID: 61458 RVA: 0x00397D42 File Offset: 0x00395F42
	[NullableContext(2)]
	public void OnClickedItem(bool isSelected, int incId, HonamiStoryItemGridItem attachParent)
	{
		this.SelectedIncId = incId;
		this.SelectedItemUiItem.SetUiActive(isSelected);
		this.SelectedItem = attachParent;
		if (isSelected && attachParent != null)
		{
			this.SelectedItemUiItem.GetOriginalItem().SetUIParent(attachParent.GetPanelForHover(), false);
		}
	}

	// Token: 0x0600F013 RID: 61459 RVA: 0x00397D7C File Offset: 0x00395F7C
	public void RefreshSelectedUiItem()
	{
		if (this.SelectedItem == null || !this.SelectedItem.IsUiActiveInHierarchy() || this.SelectedIncId <= 0)
		{
			this.SelectedItemUiItem.SetUiActive(false);
			return;
		}
		HonamiStoryItemDataBase data = this.SelectedItem.GetData();
		if (data == null)
		{
			this.SelectedItemUiItem.SetUiActive(false);
			return;
		}
		this.SelectedItemUiItem.SetUiActive(data.GetIncId() == this.SelectedIncId);
	}

	// Token: 0x04006F03 RID: 28419
	private UUIItem AttachPanel;

	// Token: 0x04006F04 RID: 28420
	private HonamiStoryGridItemBase DragItem;

	// Token: 0x04006F05 RID: 28421
	private UiPanelBase HoverGridUiItem;

	// Token: 0x04006F06 RID: 28422
	private UiPanelBase HoverItemUiItem;

	// Token: 0x04006F07 RID: 28423
	private UiPanelBase SelectedItemUiItem;

	// Token: 0x04006F08 RID: 28424
	private int SelectedIncId = -1;

	// Token: 0x04006F09 RID: 28425
	[Nullable(2)]
	private HonamiStoryItemGridItem SelectedItem;

	// Token: 0x04006F0A RID: 28426
	public List<HonamiStoryBackpackPanelBase> PanelBaseList = new List<HonamiStoryBackpackPanelBase>();

	// Token: 0x04006F0B RID: 28427
	[Nullable(2)]
	public HonamiStoryBackpackView BackpackView;

	// Token: 0x04006F0C RID: 28428
	[Nullable(2)]
	public HonamiStoryPickUpBackpackView PickUpBackpackView;

	// Token: 0x04006F0D RID: 28429
	public bool IsSellDragging;

	// Token: 0x04006F0E RID: 28430
	private readonly HonamiStoryInteractOperateAgent OperateAgent = new HonamiStoryInteractOperateAgent();
}
