using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.HonamiStory;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001356 RID: 4950
[NullableContext(1)]
[Nullable(0)]
public class HonamiStoryInteractController
{
	// Token: 0x0600C41E RID: 50206 RVA: 0x003A3000 File Offset: 0x003A1200
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

	// Token: 0x0600C41F RID: 50207 RVA: 0x003A304B File Offset: 0x003A124B
	public void OnBeforeShow()
	{
		this.DragItem.GetRootItem().SetPivot(new FVector2D(0.5f, 0.5f));
		this.DragItem.GetOriginalItem().SetUIParent(this.AttachPanel, false);
	}

	// Token: 0x0600C420 RID: 50208 RVA: 0x003A3083 File Offset: 0x003A1283
	public void RegisterPanel(HonamiStoryBackpackPanelBase panel)
	{
		this.PanelBaseList.Add(panel);
	}

	// Token: 0x0600C421 RID: 50209 RVA: 0x003A3091 File Offset: 0x003A1291
	public void RegisterBackpackView(HonamiStoryBackpackView view)
	{
		this.BackpackView = view;
	}

	// Token: 0x0600C422 RID: 50210 RVA: 0x003A309A File Offset: 0x003A129A
	public void RegisterPickUpView(HonamiStoryPickUpBackpackView view)
	{
		this.PickUpBackpackView = view;
	}

	// Token: 0x0600C423 RID: 50211 RVA: 0x003A30A3 File Offset: 0x003A12A3
	public void ClearPanel()
	{
		this.PanelBaseList = new List<HonamiStoryBackpackPanelBase>();
	}

	// Token: 0x0600C424 RID: 50212 RVA: 0x003A30B0 File Offset: 0x003A12B0
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

	// Token: 0x0600C425 RID: 50213 RVA: 0x003A315C File Offset: 0x003A135C
	public void SetDragItemPositionByItem(HonamiStoryGridItemBase item)
	{
		FVector dragItemLocation = item.GetRootItem().K2_GetComponentLocation();
		this.SetDragItemLocation(dragItemLocation);
	}

	// Token: 0x0600C426 RID: 50214 RVA: 0x003A317C File Offset: 0x003A137C
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

	// Token: 0x0600C427 RID: 50215 RVA: 0x003A320E File Offset: 0x003A140E
	public UUIItem GetDragTipsRoot()
	{
		return this.DragItem.GetItemGridItem().GetTipsRoot();
	}

	// Token: 0x0600C428 RID: 50216 RVA: 0x003A3220 File Offset: 0x003A1420
	public FVector GetDragItemLocation()
	{
		return this.DragItem.GetRootItem().K2_GetComponentToWorld().GetLocation();
	}

	// Token: 0x0600C429 RID: 50217 RVA: 0x003A3245 File Offset: 0x003A1445
	public int GetDragItemIncId()
	{
		return this.DragItem.GetIncId();
	}

	// Token: 0x0600C42A RID: 50218 RVA: 0x003A3254 File Offset: 0x003A1454
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

	// Token: 0x0600C42B RID: 50219 RVA: 0x003A3330 File Offset: 0x003A1530
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

	// Token: 0x0600C42C RID: 50220 RVA: 0x003A3474 File Offset: 0x003A1674
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

	// Token: 0x0600C42D RID: 50221 RVA: 0x003A352C File Offset: 0x003A172C
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

	// Token: 0x0600C42E RID: 50222 RVA: 0x003A37BC File Offset: 0x003A19BC
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

	// Token: 0x0600C42F RID: 50223 RVA: 0x003A386C File Offset: 0x003A1A6C
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

	// Token: 0x0600C430 RID: 50224 RVA: 0x003A38DC File Offset: 0x003A1ADC
	public void OnUnHover()
	{
		if (HonamiStoryUtil.IsMobileView())
		{
			return;
		}
		this.HoverGridUiItem.SetUiActive(false);
		this.HoverItemUiItem.SetUiActive(false);
	}

	// Token: 0x0600C431 RID: 50225 RVA: 0x003A38FE File Offset: 0x003A1AFE
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

	// Token: 0x0600C432 RID: 50226 RVA: 0x003A3938 File Offset: 0x003A1B38
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

	// Token: 0x04006FE4 RID: 28644
	private UUIItem AttachPanel;

	// Token: 0x04006FE5 RID: 28645
	private HonamiStoryGridItemBase DragItem;

	// Token: 0x04006FE6 RID: 28646
	private UiPanelBase HoverGridUiItem;

	// Token: 0x04006FE7 RID: 28647
	private UiPanelBase HoverItemUiItem;

	// Token: 0x04006FE8 RID: 28648
	private UiPanelBase SelectedItemUiItem;

	// Token: 0x04006FE9 RID: 28649
	private int SelectedIncId = -1;

	// Token: 0x04006FEA RID: 28650
	[Nullable(2)]
	private HonamiStoryItemGridItem SelectedItem;

	// Token: 0x04006FEB RID: 28651
	public List<HonamiStoryBackpackPanelBase> PanelBaseList = new List<HonamiStoryBackpackPanelBase>();

	// Token: 0x04006FEC RID: 28652
	[Nullable(2)]
	public HonamiStoryBackpackView BackpackView;

	// Token: 0x04006FED RID: 28653
	[Nullable(2)]
	public HonamiStoryPickUpBackpackView PickUpBackpackView;

	// Token: 0x04006FEE RID: 28654
	public bool IsSellDragging;

	// Token: 0x04006FEF RID: 28655
	private readonly HonamiStoryInteractOperateAgent OperateAgent = new HonamiStoryInteractOperateAgent();
}
