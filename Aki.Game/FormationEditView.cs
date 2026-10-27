using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C01 RID: 7169
[NullableContext(1)]
[Nullable(0)]
public class FormationEditView : UiViewBase
{
	// Token: 0x0600D604 RID: 54788 RVA: 0x0031706C File Offset: 0x0031526C
	public FormationEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600D605 RID: 54789 RVA: 0x003170CC File Offset: 0x003152CC
	protected unsafe override void OnRegisterComponent()
	{
		int num = 7;
		List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
		CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
		Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
		int num2 = 0;
		*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIScrollViewWithScrollbarComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
		num2++;
		*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
		this.ComponentRegisterInfos = list;
		num2 = 2;
		List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
		CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
		Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
		num = 0;
		*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickQuickSelect));
		num++;
		*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnClickClose));
		this.BtnBindInfo = list2;
	}

	// Token: 0x0600D606 RID: 54790 RVA: 0x0031723A File Offset: 0x0031543A
	protected override bool OnCheckIfNeedScene()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.Formation3DView);
	}

	// Token: 0x0600D607 RID: 54791 RVA: 0x0031724C File Offset: 0x0031544C
	protected override UniTask OnBeforeStartAsync()
	{
		FormationEditView.<OnBeforeStartAsync>d__36 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationEditView.<OnBeforeStartAsync>d__36>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600D608 RID: 54792 RVA: 0x00317290 File Offset: 0x00315490
	protected override void OnStart()
	{
		IFormationEditViewData formationEditViewData = this.OpenParam as IFormationEditViewData;
		this.IsConfirming = false;
		this.SwitchFormationCallback = ((formationEditViewData != null) ? formationEditViewData.SwitchFormationCallback : null);
		this.RenameFormationCallback = ((formationEditViewData != null) ? formationEditViewData.RenameFormationCallback : null);
		this.CloseCallback = ((formationEditViewData != null) ? formationEditViewData.CloseCallback : null);
		this.ConfirmCallback = ((formationEditViewData != null) ? formationEditViewData.ConfirmCallback : null);
		this.SelectFormationId = (((formationEditViewData != null) ? formationEditViewData.InitialFormationId : null) ?? FormationModel.Instance.CurrentFormationId.GetValueOrDefault(1));
		bool flag = InstanceDungeonEntranceModel.Instance.GetMatchingState() > EInstanceMatchState.Default;
		this.CanUseSpecialTrailRole = (RoleModel.Instance.CanUseSpecialTrialRole(null) && !flag);
		this.ScrollComp = base.GetScrollViewWithScrollbar(0);
		this.FormationScrollView = new GenericScrollViewNew<FormationEditItem, int>(this.ScrollComp, new Func<FormationEditItem>(this.CreateFormationItem), base.GetItem(1).GetOwner() as AUIBaseActor, false, null);
		this.ContentLayout = (this.ScrollComp.GetContent().GetComponentByClass(UUILayoutBase.StaticClass()) as UUILayoutBase);
		base.GetItem(6).SetUIActive(false);
		this.DisplayFormationIds = FormationEditView.BuildFormationIdList();
		this.RefreshFormationList(true);
		this.RefreshConfirmButton();
		base.RefreshUiBlurBehaviour();
	}

	// Token: 0x0600D609 RID: 54793 RVA: 0x003173F8 File Offset: 0x003155F8
	private FormationEditItem CreateFormationItem()
	{
		return new FormationEditItem
		{
			OnToggleSelect = new Func<int, int, bool>(this.OnFormationItemSelect),
			OnRenameSuccess = this.RenameFormationCallback,
			OnDragHandleBegin = new Action<FormationEditItem, ULGUIPointerEventData>(this.OnItemDragBegin),
			OnDragHandleMove = new Action<ULGUIPointerEventData>(this.OnItemDragMove),
			OnDragHandleEnd = new Action(this.OnItemDragEnd)
		};
	}

	// Token: 0x0600D60A RID: 54794 RVA: 0x00317460 File Offset: 0x00315660
	protected override void OnBeforeDestroy()
	{
		if (this.IsGamePadSort)
		{
			FormationEditSortController.ReleaseInputBlock();
		}
		if (this.DraggingItem != null || this.IsGamePadSort)
		{
			UUIScrollViewWithScrollbarComponent scrollComp = this.ScrollComp;
			if (scrollComp != null)
			{
				scrollComp.OnLateUpdate.Unbind();
			}
			UUILayoutBase contentLayout = this.ContentLayout;
			if (contentLayout != null)
			{
				contentLayout.SetEnable(true);
			}
			this.DraggingItem = null;
			this.IsGamePadSort = false;
		}
	}

	// Token: 0x0600D60B RID: 54795 RVA: 0x003174C0 File Offset: 0x003156C0
	protected override void OnAfterDestroy()
	{
		Action closeCallback = this.CloseCallback;
		if (closeCallback != null)
		{
			closeCallback();
		}
		this.CloseCallback = null;
		if (this.IsConfirming)
		{
			Action confirmCallback = this.ConfirmCallback;
			if (confirmCallback != null)
			{
				confirmCallback();
			}
		}
		this.ConfirmCallback = null;
	}

	// Token: 0x0600D60C RID: 54796 RVA: 0x003174FC File Offset: 0x003156FC
	private void RefreshFormationList(bool hideUntilScrolled = false)
	{
		List<int> formationIdList = this.DisplayFormationIds;
		UUIItem contentItem = this.ScrollComp.ContentUIItem.Get();
		float contentAlpha = contentItem.GetAlpha();
		if (hideUntilScrolled)
		{
			contentItem.SetAlpha(0f);
		}
		this.FormationScrollView.RefreshByData(formationIdList, delegate
		{
			int num = formationIdList.IndexOf(this.SelectFormationId);
			if (num >= 0)
			{
				this.FormationScrollView.SelectGridProxy(num, false);
				UUIItem itemByIndex = this.FormationScrollView.GetItemByIndex(num);
				if (itemByIndex != null)
				{
					this.FormationScrollView.LateScrollTo(itemByIndex, new Action(base.<RefreshFormationList>g__FinishScroll|1), false);
					return;
				}
			}
			base.<RefreshFormationList>g__FinishScroll|1();
		}, false);
	}

	// Token: 0x0600D60D RID: 54797 RVA: 0x0031758C File Offset: 0x0031578C
	private static List<int> BuildFormationIdList()
	{
		List<int> list = new List<int>();
		int maxFormationId = FormationConfig.Instance.GetMaxFormationId();
		for (int i = 1; i <= maxFormationId; i++)
		{
			list.Add(i);
		}
		return list;
	}

	// Token: 0x0600D60E RID: 54798 RVA: 0x003175BE File Offset: 0x003157BE
	private bool OnFormationItemSelect(int formationId, int gridIndex)
	{
		if (this.SwitchFormationCallback != null && !this.SwitchFormationCallback(formationId))
		{
			return false;
		}
		this.SelectFormationId = formationId;
		this.FormationScrollView.SelectGridProxy(gridIndex, false);
		this.RefreshConfirmButton();
		return true;
	}

	// Token: 0x0600D60F RID: 54799 RVA: 0x003175F4 File Offset: 0x003157F4
	private void OnItemDragBegin(FormationEditItem item, [Nullable(2)] ULGUIPointerEventData eventData)
	{
		if (this.DraggingItem != null || this.IsReorderRequesting || eventData == null || this.FormationScrollView == null)
		{
			return;
		}
		if (!this.SnapshotDragSlots())
		{
			return;
		}
		this.DragContentStartZ = (double)this.ScrollComp.ContentUIItem.Get().GetUIWorldPosition().Z;
		this.DraggingItem = item;
		this.DragCurSlot = item.GridIndex;
		this.AutoScrollDir = 0;
		UUILayoutBase contentLayout = this.ContentLayout;
		if (contentLayout != null)
		{
			contentLayout.SetEnable(false);
		}
		this.ScrollComp.StopMovement();
		this.ScrollComp.SetCanScroll(false);
		item.GetRootItem().SetAlpha(0f);
		this.RefreshDragPointerWorldZ(eventData);
		UUIItem item2 = base.GetItem(6);
		FVector uiworldPosition = item2.GetUIWorldPosition();
		FVector uiworldPosition2 = item.GetRootItem().GetUIWorldPosition();
		this.DragOverlayGrabOffsetZ = (double)uiworldPosition2.Z - this.DragPointerWorldZ;
		FVector fvector = new FVector(uiworldPosition2.X, uiworldPosition.Y, uiworldPosition2.Z);
		item2.SetUIWorldLocation(fvector);
		this.DragOverlayItem.Refresh(this.DisplayFormationIds[this.DragCurSlot], true, this.DragCurSlot);
		this.RefreshDragOverlayArrow();
		item2.SetUIActive(true);
		this.ScrollComp.OnLateUpdate.Bind(new Action<float>(this.OnDragTick));
	}

	// Token: 0x0600D610 RID: 54800 RVA: 0x00317740 File Offset: 0x00315940
	[NullableContext(2)]
	private void OnItemDragMove(ULGUIPointerEventData eventData)
	{
		if (this.DraggingItem == null || eventData == null)
		{
			return;
		}
		this.RefreshDragPointerWorldZ(eventData);
		UUIItem item = base.GetItem(6);
		UUIItem uuiitem = this.ScrollComp.ContentParentUIItem.Get();
		float num = (uuiitem.GetHeight() - item.GetHeight()) / 2f;
		float z = uuiitem.GetUIWorldPosition().Z;
		double num2 = MathUtils.Instance.Clamp(this.DragPointerWorldZ + this.DragOverlayGrabOffsetZ, (double)(z - num), (double)(z + num));
		this.DragTempOffset.FromUeVector2D(item.GetAnchorOffset());
		this.DragTempOffset.Y += num2 - (double)item.GetUIWorldPosition().Z;
		item.SetAnchorOffset(this.DragTempOffset.ToUeVector2D(false));
		this.RefreshAutoScrollDir();
		this.ApplyDragTargetSlot();
	}

	// Token: 0x0600D611 RID: 54801 RVA: 0x00317810 File Offset: 0x00315A10
	private void OnItemDragEnd()
	{
		if (this.DraggingItem == null || this.FormationScrollView == null)
		{
			return;
		}
		this.ScrollComp.OnLateUpdate.Unbind();
		base.GetItem(6).SetUIActive(false);
		this.DraggingItem.GetRootItem().SetAlpha(1f);
		this.DraggingItem = null;
		this.ScrollComp.SetCanScroll(true);
		this.RestoreDragSlotOffsets();
		UUILayoutBase contentLayout = this.ContentLayout;
		if (contentLayout != null)
		{
			contentLayout.SetEnable(true);
		}
		this.RefreshFormationList(false);
		this.TryRequestReorder();
	}

	// Token: 0x0600D612 RID: 54802 RVA: 0x00317898 File Offset: 0x00315A98
	private bool SnapshotDragSlots()
	{
		this.DragSlotCenters.Clear();
		this.DragSlotOffsetYs.Clear();
		this.DragGridIndexByFormationId.Clear();
		for (int i = 0; i < this.DisplayFormationIds.Count; i++)
		{
			UUIItem itemByIndex = this.FormationScrollView.GetItemByIndex(i);
			if (itemByIndex == null)
			{
				return false;
			}
			this.DragSlotCenters.Add((double)itemByIndex.GetUIWorldPosition().Z);
			this.DragSlotOffsetYs.Add((double)itemByIndex.GetAnchorOffset().Y);
			this.DragGridIndexByFormationId[this.DisplayFormationIds[i]] = i;
		}
		return true;
	}

	// Token: 0x0600D613 RID: 54803 RVA: 0x00317938 File Offset: 0x00315B38
	private void RestoreDragSlotOffsets()
	{
		for (int i = 0; i < this.DragSlotOffsetYs.Count; i++)
		{
			UUIItem itemByIndex = this.FormationScrollView.GetItemByIndex(i);
			if (itemByIndex != null)
			{
				FVector2D anchorOffset = itemByIndex.GetAnchorOffset();
				itemByIndex.SetAnchorOffset(new FVector2D(anchorOffset.X, (float)this.DragSlotOffsetYs[i]));
			}
		}
	}

	// Token: 0x0600D614 RID: 54804 RVA: 0x00317990 File Offset: 0x00315B90
	private void TryRequestReorder()
	{
		int num = this.DisplayFormationIds[this.DragCurSlot];
		int num2 = this.DragCurSlot + 1;
		if (num == num2)
		{
			return;
		}
		this.RequestReorderFormation(num, num2);
	}

	// Token: 0x0600D615 RID: 54805 RVA: 0x003179C8 File Offset: 0x00315BC8
	private UniTask RequestReorderFormation(int formationId, int targetId)
	{
		FormationEditView.<RequestReorderFormation>d__50 <RequestReorderFormation>d__;
		<RequestReorderFormation>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<RequestReorderFormation>d__.<>4__this = this;
		<RequestReorderFormation>d__.formationId = formationId;
		<RequestReorderFormation>d__.targetId = targetId;
		<RequestReorderFormation>d__.<>1__state = -1;
		<RequestReorderFormation>d__.<>t__builder.Start<FormationEditView.<RequestReorderFormation>d__50>(ref <RequestReorderFormation>d__);
		return <RequestReorderFormation>d__.<>t__builder.Task;
	}

	// Token: 0x0600D616 RID: 54806 RVA: 0x00317A1B File Offset: 0x00315C1B
	private static int GetReorderedId(int oldId, int fromId, int targetId)
	{
		if (oldId == fromId)
		{
			return targetId;
		}
		if (fromId < targetId && oldId > fromId && oldId <= targetId)
		{
			return oldId - 1;
		}
		if (targetId < fromId && oldId >= targetId && oldId < fromId)
		{
			return oldId + 1;
		}
		return oldId;
	}

	// Token: 0x0600D617 RID: 54807 RVA: 0x00317A44 File Offset: 0x00315C44
	private void ApplyDragTargetSlot()
	{
		double num = (double)this.ScrollComp.ContentUIItem.Get().GetUIWorldPosition().Z - this.DragContentStartZ;
		int num2 = 0;
		double num3 = double.MaxValue;
		for (int i = 0; i < this.DragSlotCenters.Count; i++)
		{
			double num4 = Math.Abs(this.DragPointerWorldZ - (this.DragSlotCenters[i] + num));
			if (num4 < num3)
			{
				num3 = num4;
				num2 = i;
			}
		}
		if (num2 == this.DragCurSlot)
		{
			return;
		}
		int item = this.DisplayFormationIds[this.DragCurSlot];
		this.DisplayFormationIds.RemoveAt(this.DragCurSlot);
		this.DisplayFormationIds.Insert(num2, item);
		this.DragCurSlot = num2;
		this.RefreshDragOverlayArrow();
	}

	// Token: 0x0600D618 RID: 54808 RVA: 0x00317B0D File Offset: 0x00315D0D
	private void RefreshDragOverlayArrow()
	{
		FormationEditItem dragOverlayItem = this.DragOverlayItem;
		if (dragOverlayItem == null)
		{
			return;
		}
		dragOverlayItem.SetArrowVisible(this.DragCurSlot > 0, this.DragCurSlot < this.DisplayFormationIds.Count - 1);
	}

	// Token: 0x0600D619 RID: 54809 RVA: 0x00317B3D File Offset: 0x00315D3D
	private void RefreshDragPointerWorldZ(ULGUIPointerEventData eventData)
	{
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, this.DragPointerPos);
		this.DragPointerWorldZ = this.DragPointerPos.Y + (double)UiLayer.Instance.UiRootItem.GetUIWorldPosition().Z;
	}

	// Token: 0x0600D61A RID: 54810 RVA: 0x00317B7C File Offset: 0x00315D7C
	private void RefreshAutoScrollDir()
	{
		this.AutoScrollDir = 0;
		if (!this.FormationScrollView.IsExpand)
		{
			return;
		}
		UUIItem uuiitem = this.ScrollComp.ContentParentUIItem.Get();
		float z = uuiitem.GetUIWorldPosition().Z;
		float num = uuiitem.GetHeight() / 2f;
		if (this.DragPointerWorldZ > (double)(z + num) - 100.0)
		{
			this.AutoScrollDir = -1;
			return;
		}
		if (this.DragPointerWorldZ < (double)(z - num) + 100.0)
		{
			this.AutoScrollDir = 1;
		}
	}

	// Token: 0x0600D61B RID: 54811 RVA: 0x00317C04 File Offset: 0x00315E04
	private void OnDragTick(float deltaTime)
	{
		if (this.DraggingItem == null)
		{
			return;
		}
		this.UpdateShiftAnimation(deltaTime);
		if (this.AutoScrollDir == 0)
		{
			return;
		}
		float num = this.ScrollComp.ContentUIItem.Get().Height - this.ScrollComp.ContentParentUIItem.Get().Height;
		if (num <= 0f)
		{
			return;
		}
		this.ScrollComp.SetScrollProgressIncrement((float)((double)this.AutoScrollDir * 800.0 * (double)deltaTime / (double)num));
		this.ApplyDragTargetSlot();
	}

	// Token: 0x0600D61C RID: 54812 RVA: 0x00317C90 File Offset: 0x00315E90
	private void UpdateShiftAnimation(float deltaTime)
	{
		double num = 1.0 - Math.Exp((double)(-(double)deltaTime) / 0.06);
		for (int i = 0; i < this.DisplayFormationIds.Count; i++)
		{
			int index;
			if (this.DragGridIndexByFormationId.TryGetValue(this.DisplayFormationIds[i], out index))
			{
				UUIItem itemByIndex = this.FormationScrollView.GetItemByIndex(index);
				if (itemByIndex != null)
				{
					FVector2D anchorOffset = itemByIndex.GetAnchorOffset();
					double num2 = this.DragSlotOffsetYs[i];
					double num3 = num2 - (double)anchorOffset.Y;
					if (num3 != 0.0)
					{
						double num4 = (Math.Abs(num3) < 0.5) ? num2 : ((double)anchorOffset.Y + num3 * num);
						itemByIndex.SetAnchorOffset(new FVector2D(anchorOffset.X, (float)num4));
					}
				}
			}
		}
	}

	// Token: 0x0600D61D RID: 54813 RVA: 0x00317D6B File Offset: 0x00315F6B
	public bool CanBeginGamePadSort()
	{
		if (this.DraggingItem == null && !this.IsReorderRequesting)
		{
			GenericScrollViewNew<FormationEditItem, int> formationScrollView = this.FormationScrollView;
			return ((formationScrollView != null) ? formationScrollView.GetScrollItemByKey(this.SelectFormationId) : null) != null;
		}
		return false;
	}

	// Token: 0x0600D61E RID: 54814 RVA: 0x00317DA0 File Offset: 0x00315FA0
	public void BeginGamePadSort()
	{
		GenericScrollViewNew<FormationEditItem, int> formationScrollView = this.FormationScrollView;
		FormationEditItem formationEditItem = (formationScrollView != null) ? formationScrollView.GetScrollItemByKey(this.SelectFormationId) : null;
		if (formationEditItem == null || !this.SnapshotDragSlots())
		{
			return;
		}
		this.IsGamePadSort = true;
		this.DragCurSlot = formationEditItem.GridIndex;
		UUILayoutBase contentLayout = this.ContentLayout;
		if (contentLayout != null)
		{
			contentLayout.SetEnable(false);
		}
		formationEditItem.GetRootItem().SetAlpha(0f);
		this.DragOverlayItem.Refresh(this.SelectFormationId, true, this.DragCurSlot);
		this.RefreshDragOverlayArrow();
		base.GetItem(6).SetUIActive(true);
		this.RefreshSortOverlayPos();
		this.ScrollComp.OnLateUpdate.Bind(new Action<float>(this.OnSortTick));
		UiNavigationNewController.Instance.SetNavigationFocusForView(base.GetItem(6), false, true, false);
	}

	// Token: 0x0600D61F RID: 54815 RVA: 0x00317E6E File Offset: 0x0031606E
	private void OnSortTick(float deltaTime)
	{
		this.UpdateShiftAnimation(deltaTime);
		this.SnapSortGridToCurSlot();
		this.ScrollToSortSlotIfNeeded();
		this.RefreshSortOverlayPos();
	}

	// Token: 0x0600D620 RID: 54816 RVA: 0x00317E8C File Offset: 0x0031608C
	public void MoveGamePadSort(int delta)
	{
		if (!this.IsGamePadSort)
		{
			return;
		}
		int num = MathUtils.Instance.Clamp(this.DragCurSlot + delta, 0, this.DisplayFormationIds.Count - 1);
		if (num == this.DragCurSlot)
		{
			return;
		}
		int item = this.DisplayFormationIds[this.DragCurSlot];
		this.DisplayFormationIds.RemoveAt(this.DragCurSlot);
		this.DisplayFormationIds.Insert(num, item);
		this.DragCurSlot = num;
		this.RefreshDragOverlayArrow();
		this.SnapSortGridToCurSlot();
		this.RefreshSortOverlayPos();
		UiNavigationModel.Instance.RepeatMove();
	}

	// Token: 0x0600D621 RID: 54817 RVA: 0x00317F20 File Offset: 0x00316120
	public void EndGamePadSort(bool isCancel)
	{
		if (!this.IsGamePadSort)
		{
			return;
		}
		this.IsGamePadSort = false;
		this.ScrollComp.OnLateUpdate.Unbind();
		base.GetItem(6).SetUIActive(false);
		UUIItem sortGridItem = this.GetSortGridItem();
		if (sortGridItem != null)
		{
			sortGridItem.SetAlpha(1f);
		}
		this.RestoreDragSlotOffsets();
		UUILayoutBase contentLayout = this.ContentLayout;
		if (contentLayout != null)
		{
			contentLayout.SetEnable(true);
		}
		if (isCancel)
		{
			this.DisplayFormationIds = FormationEditView.BuildFormationIdList();
			this.RefreshFormationList(false);
		}
		else
		{
			this.RefreshFormationList(false);
			this.TryRequestReorder();
		}
		GenericScrollViewNew<FormationEditItem, int> formationScrollView = this.FormationScrollView;
		UUIItem uuiitem;
		if (formationScrollView == null)
		{
			uuiitem = null;
		}
		else
		{
			FormationEditItem scrollItemByKey = formationScrollView.GetScrollItemByKey(this.SelectFormationId);
			uuiitem = ((scrollItemByKey != null) ? scrollItemByKey.GetRootItem() : null);
		}
		UUIItem uuiitem2 = uuiitem;
		if (uuiitem2 != null)
		{
			UiNavigationNewController.Instance.SetNavigationFocusForView(uuiitem2, true, false, false);
		}
	}

	// Token: 0x0600D622 RID: 54818 RVA: 0x00317FE8 File Offset: 0x003161E8
	private void SnapSortGridToCurSlot()
	{
		UUIItem sortGridItem = this.GetSortGridItem();
		if (sortGridItem == null)
		{
			return;
		}
		FVector2D anchorOffset = sortGridItem.GetAnchorOffset();
		sortGridItem.SetAnchorOffset(new FVector2D(anchorOffset.X, (float)this.DragSlotOffsetYs[this.DragCurSlot]));
	}

	// Token: 0x0600D623 RID: 54819 RVA: 0x0031802C File Offset: 0x0031622C
	[NullableContext(2)]
	private UUIItem GetSortGridItem()
	{
		int index;
		if (!this.DragGridIndexByFormationId.TryGetValue(this.SelectFormationId, out index))
		{
			return null;
		}
		GenericScrollViewNew<FormationEditItem, int> formationScrollView = this.FormationScrollView;
		if (formationScrollView == null)
		{
			return null;
		}
		return formationScrollView.GetItemByIndex(index);
	}

	// Token: 0x0600D624 RID: 54820 RVA: 0x00318064 File Offset: 0x00316264
	private void ScrollToSortSlotIfNeeded()
	{
		UUIItem sortGridItem = this.GetSortGridItem();
		if (sortGridItem == null || this.FormationScrollView.IsItemInViewport(sortGridItem, 1f) == EOutOfBoundsType.NotOut)
		{
			return;
		}
		this.FormationScrollView.ScrollTo(sortGridItem, false);
	}

	// Token: 0x0600D625 RID: 54821 RVA: 0x0031809C File Offset: 0x0031629C
	private void RefreshSortOverlayPos()
	{
		UUIItem sortGridItem = this.GetSortGridItem();
		if (sortGridItem == null)
		{
			return;
		}
		UUIItem item = base.GetItem(6);
		FVector uiworldPosition = sortGridItem.GetUIWorldPosition();
		FVector uiworldPosition2 = item.GetUIWorldPosition();
		FVector fvector = new FVector(uiworldPosition.X, uiworldPosition2.Y, uiworldPosition.Z);
		item.SetUIWorldLocation(fvector);
	}

	// Token: 0x0600D626 RID: 54822 RVA: 0x003180E8 File Offset: 0x003162E8
	private void OnClickQuickSelect()
	{
		if (UiManager.Instance.IsViewOpen(EUiViewName.QuickRoleSelectView))
		{
			return;
		}
		int[] editingRoleIdList = FormationModel.Instance.GetEditingRoleIdList(this.SelectFormationId);
		List<RoleDataBase> roleDataList = RoleModel.Instance.GetRoleDataList(false);
		QuickRoleSelectViewData param = new QuickRoleSelectViewData(EFilterSortGroupId.EditFormation, editingRoleIdList, roleDataList)
		{
			OnConfirm = new Action<int[]>(this.OnQuickSelectConfirm),
			OnHideFinish = new Action(this.OnQuickSelectHideFinish)
		};
		UiManager.Instance.OpenView(EUiViewName.QuickRoleSelectView, param, delegate(bool isSuccess, int viewId)
		{
			if (isSuccess)
			{
				base.AddChildViewById(viewId);
			}
		});
	}

	// Token: 0x0600D627 RID: 54823 RVA: 0x00318170 File Offset: 0x00316370
	private void OnQuickSelectConfirm(int[] roleIdList)
	{
		FormationModel instance = FormationModel.Instance;
		for (int i = 0; i < 3; i++)
		{
			int roleId = (i < roleIdList.Length) ? roleIdList[i] : 0;
			instance.SetEditingRoleId(this.SelectFormationId, i + 1, roleId, false);
		}
		IFormationEditViewData formationEditViewData = this.OpenParam as IFormationEditViewData;
		if (formationEditViewData != null)
		{
			Action<int> quickSelectConfirmCallback = formationEditViewData.QuickSelectConfirmCallback;
			if (quickSelectConfirmCallback != null)
			{
				quickSelectConfirmCallback(this.SelectFormationId);
			}
		}
		Func<int, bool> switchFormationCallback = this.SwitchFormationCallback;
		if (switchFormationCallback != null)
		{
			switchFormationCallback(this.SelectFormationId);
		}
		this.RefreshConfirmButton();
	}

	// Token: 0x0600D628 RID: 54824 RVA: 0x003181F3 File Offset: 0x003163F3
	private void OnQuickSelectHideFinish()
	{
		this.RefreshFormationList(false);
	}

	// Token: 0x0600D629 RID: 54825 RVA: 0x003181FC File Offset: 0x003163FC
	private void OnClickConfirm()
	{
		if (this.IsConfirming || !this.IsAllowConfirm())
		{
			return;
		}
		this.IsConfirming = true;
		this.OnClickClose();
	}

	// Token: 0x0600D62A RID: 54826 RVA: 0x0031821C File Offset: 0x0031641C
	private void OnClickClose()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600D62B RID: 54827 RVA: 0x00318234 File Offset: 0x00316434
	private void RefreshConfirmButton()
	{
		if (GameModeModel.Instance.IsMulti)
		{
			return;
		}
		FormationModel instance = FormationModel.Instance;
		int selectFormationId = this.SelectFormationId;
		int? currentFormationId = instance.CurrentFormationId;
		bool flag = !(selectFormationId == currentFormationId.GetValueOrDefault() & currentFormationId != null);
		bool flag2 = flag;
		if (flag2 && !this.CanUseSpecialTrailRole)
		{
			IEnumerable<int> editingRoleIdList = instance.GetEditingRoleIdList(this.SelectFormationId);
			Func<int, bool> predicate;
			if ((predicate = FormationEditView.<>O.<0>__IsSpecialTrialRole) == null)
			{
				predicate = (FormationEditView.<>O.<0>__IsSpecialTrialRole = new Func<int, bool>(RoleUtils.IsSpecialTrialRole));
			}
			flag2 = !editingRoleIdList.Any(predicate);
		}
		this.BtnConfirm.SetEnableClick(flag2);
		this.BtnConfirm.SetLocalText(flag ? "EditBattleTeamFight" : "EditBattleTeamFighting", Array.Empty<object>());
	}

	// Token: 0x0600D62C RID: 54828 RVA: 0x003182E0 File Offset: 0x003164E0
	private bool IsAllowConfirm()
	{
		FormationModel instance = FormationModel.Instance;
		int[] editingRoleIdList = instance.GetEditingRoleIdList(this.SelectFormationId);
		if (editingRoleIdList.Length == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamNoRole", Array.Empty<object>());
			return false;
		}
		if (editingRoleIdList.All(new Func<int, bool>(instance.IsRoleDead)))
		{
			ScrollingTipsController.Instance.ShowTipsById("EditFormationAllDead", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x040061E6 RID: 25062
	private const double DRAG_SHIFT_SMOOTH_TIME = 0.06;

	// Token: 0x040061E7 RID: 25063
	private const double DRAG_SHIFT_SNAP_DISTANCE = 0.5;

	// Token: 0x040061E8 RID: 25064
	private const float DRAG_SOURCE_ALPHA = 0f;

	// Token: 0x040061E9 RID: 25065
	private const double AUTO_SCROLL_EDGE_SIZE = 100.0;

	// Token: 0x040061EA RID: 25066
	private const double AUTO_SCROLL_SPEED = 800.0;

	// Token: 0x040061EB RID: 25067
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040061EC RID: 25068
	[Nullable(2)]
	private ButtonItem BtnConfirm;

	// Token: 0x040061ED RID: 25069
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FormationEditItem, int> FormationScrollView;

	// Token: 0x040061EE RID: 25070
	private int SelectFormationId;

	// Token: 0x040061EF RID: 25071
	private bool CanUseSpecialTrailRole = true;

	// Token: 0x040061F0 RID: 25072
	[Nullable(2)]
	private Func<int, bool> SwitchFormationCallback;

	// Token: 0x040061F1 RID: 25073
	[Nullable(2)]
	private Action<int> RenameFormationCallback;

	// Token: 0x040061F2 RID: 25074
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x040061F3 RID: 25075
	[Nullable(2)]
	private Action ConfirmCallback;

	// Token: 0x040061F4 RID: 25076
	private bool IsConfirming;

	// Token: 0x040061F5 RID: 25077
	private List<int> DisplayFormationIds = new List<int>();

	// Token: 0x040061F6 RID: 25078
	private bool IsReorderRequesting;

	// Token: 0x040061F7 RID: 25079
	[Nullable(2)]
	private FormationEditItem DragOverlayItem;

	// Token: 0x040061F8 RID: 25080
	[Nullable(2)]
	private FormationEditItem DraggingItem;

	// Token: 0x040061F9 RID: 25081
	private int DragCurSlot;

	// Token: 0x040061FA RID: 25082
	private readonly List<double> DragSlotCenters = new List<double>();

	// Token: 0x040061FB RID: 25083
	private double DragContentStartZ;

	// Token: 0x040061FC RID: 25084
	private readonly List<double> DragSlotOffsetYs = new List<double>();

	// Token: 0x040061FD RID: 25085
	private readonly Dictionary<int, int> DragGridIndexByFormationId = new Dictionary<int, int>();

	// Token: 0x040061FE RID: 25086
	private int AutoScrollDir;

	// Token: 0x040061FF RID: 25087
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollComp;

	// Token: 0x04006200 RID: 25088
	[Nullable(2)]
	private UUILayoutBase ContentLayout;

	// Token: 0x04006201 RID: 25089
	private readonly Vector2D DragPointerPos = Vector2D.Create();

	// Token: 0x04006202 RID: 25090
	private double DragPointerWorldZ;

	// Token: 0x04006203 RID: 25091
	private double DragOverlayGrabOffsetZ;

	// Token: 0x04006204 RID: 25092
	private readonly Vector2D DragTempOffset = Vector2D.Create();

	// Token: 0x04006205 RID: 25093
	public bool IsGamePadSort;

	// Token: 0x020081A6 RID: 33190
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402A4E9 RID: 173289
		ScrollInfo,
		// Token: 0x0402A4EA RID: 173290
		ScrollItem,
		// Token: 0x0402A4EB RID: 173291
		CaptionItem,
		// Token: 0x0402A4EC RID: 173292
		BtnQuickSelect,
		// Token: 0x0402A4ED RID: 173293
		BtnConfirm,
		// Token: 0x0402A4EE RID: 173294
		BtnClose,
		// Token: 0x0402A4EF RID: 173295
		DragItem
	}

	// Token: 0x020081A7 RID: 33191
	[CompilerGenerated]
	private static class <>O
	{
		// Token: 0x0402A4F0 RID: 173296
		[Nullable(0)]
		public static Func<int, bool> <0>__IsSpecialTrialRole;
	}
}
