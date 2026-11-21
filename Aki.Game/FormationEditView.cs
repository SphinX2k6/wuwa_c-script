using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using CSharpScript.Module.InstanceDungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020010C0 RID: 4288
[NullableContext(1)]
[Nullable(0)]
public class FormationEditView : UiViewBase
{
	// Token: 0x0600AA17 RID: 43543 RVA: 0x00322344 File Offset: 0x00320544
	public FormationEditView(UiViewInfo viewInfo) : base(viewInfo)
	{
	}

	// Token: 0x0600AA18 RID: 43544 RVA: 0x003223A4 File Offset: 0x003205A4
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

	// Token: 0x0600AA19 RID: 43545 RVA: 0x00322512 File Offset: 0x00320712
	protected override bool OnCheckIfNeedScene()
	{
		return UiManager.Instance.IsViewOpen(EUiViewName.Formation3DView);
	}

	// Token: 0x0600AA1A RID: 43546 RVA: 0x00322524 File Offset: 0x00320724
	protected override UniTask OnBeforeStartAsync()
	{
		FormationEditView.<OnBeforeStartAsync>d__36 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<FormationEditView.<OnBeforeStartAsync>d__36>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x0600AA1B RID: 43547 RVA: 0x00322568 File Offset: 0x00320768
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

	// Token: 0x0600AA1C RID: 43548 RVA: 0x003226D0 File Offset: 0x003208D0
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

	// Token: 0x0600AA1D RID: 43549 RVA: 0x00322738 File Offset: 0x00320938
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

	// Token: 0x0600AA1E RID: 43550 RVA: 0x00322798 File Offset: 0x00320998
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

	// Token: 0x0600AA1F RID: 43551 RVA: 0x003227D4 File Offset: 0x003209D4
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

	// Token: 0x0600AA20 RID: 43552 RVA: 0x00322864 File Offset: 0x00320A64
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

	// Token: 0x0600AA21 RID: 43553 RVA: 0x00322896 File Offset: 0x00320A96
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

	// Token: 0x0600AA22 RID: 43554 RVA: 0x003228CC File Offset: 0x00320ACC
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

	// Token: 0x0600AA23 RID: 43555 RVA: 0x00322A18 File Offset: 0x00320C18
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

	// Token: 0x0600AA24 RID: 43556 RVA: 0x00322AE8 File Offset: 0x00320CE8
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

	// Token: 0x0600AA25 RID: 43557 RVA: 0x00322B70 File Offset: 0x00320D70
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

	// Token: 0x0600AA26 RID: 43558 RVA: 0x00322C10 File Offset: 0x00320E10
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

	// Token: 0x0600AA27 RID: 43559 RVA: 0x00322C68 File Offset: 0x00320E68
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

	// Token: 0x0600AA28 RID: 43560 RVA: 0x00322CA0 File Offset: 0x00320EA0
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

	// Token: 0x0600AA29 RID: 43561 RVA: 0x00322CF3 File Offset: 0x00320EF3
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

	// Token: 0x0600AA2A RID: 43562 RVA: 0x00322D1C File Offset: 0x00320F1C
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

	// Token: 0x0600AA2B RID: 43563 RVA: 0x00322DE5 File Offset: 0x00320FE5
	private void RefreshDragOverlayArrow()
	{
		FormationEditItem dragOverlayItem = this.DragOverlayItem;
		if (dragOverlayItem == null)
		{
			return;
		}
		dragOverlayItem.SetArrowVisible(this.DragCurSlot > 0, this.DragCurSlot < this.DisplayFormationIds.Count - 1);
	}

	// Token: 0x0600AA2C RID: 43564 RVA: 0x00322E15 File Offset: 0x00321015
	private void RefreshDragPointerWorldZ(ULGUIPointerEventData eventData)
	{
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, this.DragPointerPos);
		this.DragPointerWorldZ = this.DragPointerPos.Y + (double)UiLayer.Instance.UiRootItem.GetUIWorldPosition().Z;
	}

	// Token: 0x0600AA2D RID: 43565 RVA: 0x00322E54 File Offset: 0x00321054
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

	// Token: 0x0600AA2E RID: 43566 RVA: 0x00322EDC File Offset: 0x003210DC
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

	// Token: 0x0600AA2F RID: 43567 RVA: 0x00322F68 File Offset: 0x00321168
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

	// Token: 0x0600AA30 RID: 43568 RVA: 0x00323043 File Offset: 0x00321243
	public bool CanBeginGamePadSort()
	{
		if (this.DraggingItem == null && !this.IsReorderRequesting)
		{
			GenericScrollViewNew<FormationEditItem, int> formationScrollView = this.FormationScrollView;
			return ((formationScrollView != null) ? formationScrollView.GetScrollItemByKey(this.SelectFormationId) : null) != null;
		}
		return false;
	}

	// Token: 0x0600AA31 RID: 43569 RVA: 0x00323078 File Offset: 0x00321278
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

	// Token: 0x0600AA32 RID: 43570 RVA: 0x00323146 File Offset: 0x00321346
	private void OnSortTick(float deltaTime)
	{
		this.UpdateShiftAnimation(deltaTime);
		this.SnapSortGridToCurSlot();
		this.ScrollToSortSlotIfNeeded();
		this.RefreshSortOverlayPos();
	}

	// Token: 0x0600AA33 RID: 43571 RVA: 0x00323164 File Offset: 0x00321364
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

	// Token: 0x0600AA34 RID: 43572 RVA: 0x003231F8 File Offset: 0x003213F8
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

	// Token: 0x0600AA35 RID: 43573 RVA: 0x003232C0 File Offset: 0x003214C0
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

	// Token: 0x0600AA36 RID: 43574 RVA: 0x00323304 File Offset: 0x00321504
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

	// Token: 0x0600AA37 RID: 43575 RVA: 0x0032333C File Offset: 0x0032153C
	private void ScrollToSortSlotIfNeeded()
	{
		UUIItem sortGridItem = this.GetSortGridItem();
		if (sortGridItem == null || this.FormationScrollView.IsItemInViewport(sortGridItem, 1f) == EOutOfBoundsType.NotOut)
		{
			return;
		}
		this.FormationScrollView.ScrollTo(sortGridItem, false);
	}

	// Token: 0x0600AA38 RID: 43576 RVA: 0x00323374 File Offset: 0x00321574
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

	// Token: 0x0600AA39 RID: 43577 RVA: 0x003233C0 File Offset: 0x003215C0
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

	// Token: 0x0600AA3A RID: 43578 RVA: 0x00323448 File Offset: 0x00321648
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

	// Token: 0x0600AA3B RID: 43579 RVA: 0x003234CB File Offset: 0x003216CB
	private void OnQuickSelectHideFinish()
	{
		this.RefreshFormationList(false);
	}

	// Token: 0x0600AA3C RID: 43580 RVA: 0x003234D4 File Offset: 0x003216D4
	private void OnClickConfirm()
	{
		if (this.IsConfirming || !this.IsAllowConfirm())
		{
			return;
		}
		this.IsConfirming = true;
		this.OnClickClose();
	}

	// Token: 0x0600AA3D RID: 43581 RVA: 0x003234F4 File Offset: 0x003216F4
	private void OnClickClose()
	{
		UiManager.Instance.CloseView(this.ViewInfo.Name, null);
	}

	// Token: 0x0600AA3E RID: 43582 RVA: 0x0032350C File Offset: 0x0032170C
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
			int[] editingRoleIdList = instance.GetEditingRoleIdList(this.SelectFormationId);
			bool flag3 = false;
			for (int i = 0; i < editingRoleIdList.Length; i++)
			{
				if (RoleUtils.IsSpecialTrialRole(editingRoleIdList[i]))
				{
					flag3 = true;
					break;
				}
			}
			flag2 = !flag3;
		}
		this.BtnConfirm.SetEnableClick(flag2);
		this.BtnConfirm.SetLocalText(flag ? "EditBattleTeamFight" : "EditBattleTeamFighting", Array.Empty<object>());
	}

	// Token: 0x0600AA3F RID: 43583 RVA: 0x003235C4 File Offset: 0x003217C4
	private bool IsAllowConfirm()
	{
		FormationModel instance = FormationModel.Instance;
		int[] editingRoleIdList = instance.GetEditingRoleIdList(this.SelectFormationId);
		if (editingRoleIdList.Length == 0)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditBattleTeamNoRole", Array.Empty<object>());
			return false;
		}
		bool flag = true;
		for (int i = 0; i < editingRoleIdList.Length; i++)
		{
			if (!instance.IsRoleDead(editingRoleIdList[i]))
			{
				flag = false;
				break;
			}
		}
		if (flag)
		{
			ScrollingTipsController.Instance.ShowTipsById("EditFormationAllDead", Array.Empty<object>());
			return false;
		}
		return true;
	}

	// Token: 0x040062B8 RID: 25272
	private const double DRAG_SHIFT_SMOOTH_TIME = 0.06;

	// Token: 0x040062B9 RID: 25273
	private const double DRAG_SHIFT_SNAP_DISTANCE = 0.5;

	// Token: 0x040062BA RID: 25274
	private const float DRAG_SOURCE_ALPHA = 0f;

	// Token: 0x040062BB RID: 25275
	private const double AUTO_SCROLL_EDGE_SIZE = 100.0;

	// Token: 0x040062BC RID: 25276
	private const double AUTO_SCROLL_SPEED = 800.0;

	// Token: 0x040062BD RID: 25277
	[Nullable(2)]
	private PopupCaptionItem CaptionItem;

	// Token: 0x040062BE RID: 25278
	[Nullable(2)]
	private ButtonItem BtnConfirm;

	// Token: 0x040062BF RID: 25279
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private GenericScrollViewNew<FormationEditItem, int> FormationScrollView;

	// Token: 0x040062C0 RID: 25280
	private int SelectFormationId;

	// Token: 0x040062C1 RID: 25281
	private bool CanUseSpecialTrailRole = true;

	// Token: 0x040062C2 RID: 25282
	[Nullable(2)]
	private Func<int, bool> SwitchFormationCallback;

	// Token: 0x040062C3 RID: 25283
	[Nullable(2)]
	private Action<int> RenameFormationCallback;

	// Token: 0x040062C4 RID: 25284
	[Nullable(2)]
	private Action CloseCallback;

	// Token: 0x040062C5 RID: 25285
	[Nullable(2)]
	private Action ConfirmCallback;

	// Token: 0x040062C6 RID: 25286
	private bool IsConfirming;

	// Token: 0x040062C7 RID: 25287
	private List<int> DisplayFormationIds = new List<int>();

	// Token: 0x040062C8 RID: 25288
	private bool IsReorderRequesting;

	// Token: 0x040062C9 RID: 25289
	[Nullable(2)]
	private FormationEditItem DragOverlayItem;

	// Token: 0x040062CA RID: 25290
	[Nullable(2)]
	private FormationEditItem DraggingItem;

	// Token: 0x040062CB RID: 25291
	private int DragCurSlot;

	// Token: 0x040062CC RID: 25292
	private readonly List<double> DragSlotCenters = new List<double>();

	// Token: 0x040062CD RID: 25293
	private double DragContentStartZ;

	// Token: 0x040062CE RID: 25294
	private readonly List<double> DragSlotOffsetYs = new List<double>();

	// Token: 0x040062CF RID: 25295
	private readonly Dictionary<int, int> DragGridIndexByFormationId = new Dictionary<int, int>();

	// Token: 0x040062D0 RID: 25296
	private int AutoScrollDir;

	// Token: 0x040062D1 RID: 25297
	[Nullable(2)]
	private UUIScrollViewWithScrollbarComponent ScrollComp;

	// Token: 0x040062D2 RID: 25298
	[Nullable(2)]
	private UUILayoutBase ContentLayout;

	// Token: 0x040062D3 RID: 25299
	private readonly Vector2D DragPointerPos = Vector2D.Create();

	// Token: 0x040062D4 RID: 25300
	private double DragPointerWorldZ;

	// Token: 0x040062D5 RID: 25301
	private double DragOverlayGrabOffsetZ;

	// Token: 0x040062D6 RID: 25302
	private readonly Vector2D DragTempOffset = Vector2D.Create();

	// Token: 0x040062D7 RID: 25303
	public bool IsGamePadSort;

	// Token: 0x02007331 RID: 29489
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04025814 RID: 153620
		ScrollInfo,
		// Token: 0x04025815 RID: 153621
		ScrollItem,
		// Token: 0x04025816 RID: 153622
		CaptionItem,
		// Token: 0x04025817 RID: 153623
		BtnQuickSelect,
		// Token: 0x04025818 RID: 153624
		BtnConfirm,
		// Token: 0x04025819 RID: 153625
		BtnClose,
		// Token: 0x0402581A RID: 153626
		DragItem
	}
}
