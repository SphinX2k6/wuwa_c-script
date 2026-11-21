using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001081 RID: 4225
[NullableContext(1)]
[Nullable(0)]
public class FormationViewDragController : UiControllerBase
{
	// Token: 0x0600A7E8 RID: 42984 RVA: 0x00316B44 File Offset: 0x00314D44
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600A7E9 RID: 42985 RVA: 0x00316B62 File Offset: 0x00314D62
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600A7EA RID: 42986 RVA: 0x00316B80 File Offset: 0x00314D80
	private void InputControllerChange(EInputControllerType eInputControllerType, EInputControllerType inputControllerType)
	{
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "Formation-InputControllerChange", default(ReadOnlySpan<ValueTuple<string, object>>));
		bool flag = Info.Instance.IsInGamepad();
		if (FormationViewDragController.IsGamepad != flag && FormationViewDragController.DragData != null)
		{
			if (FormationViewDragController.IsGamepad)
			{
				this.CancelDrag();
			}
			else if (FormationViewDragController.DragData.DragItemPosition > 0 && FormationViewDragController.DragData.DragItemPosition <= FormationViewDragController.DragData.DraggableSlots.Count)
			{
				IDraggableSlot draggableSlot = FormationViewDragController.DragData.DraggableSlots[FormationViewDragController.DragData.DragItemPosition - 1];
				if (draggableSlot != null)
				{
					draggableSlot.MouseCancelDrag();
				}
			}
		}
		FormationViewDragController.IsGamepad = flag;
	}

	// Token: 0x0600A7EB RID: 42987 RVA: 0x00316C26 File Offset: 0x00314E26
	public static void InitDragData(FormationDragData data)
	{
		FormationViewDragController.DragData = data;
		FormationViewDragController.IsGamepad = Info.Instance.IsInGamepad();
		FormationViewDragController.DraggingIndex = 0;
		FormationViewDragController.GamePadSelectModel = false;
	}

	// Token: 0x0600A7EC RID: 42988 RVA: 0x00316C49 File Offset: 0x00314E49
	[NullableContext(2)]
	public static void ClearDragData(FormationDragData owner = null)
	{
		if (owner != null && FormationViewDragController.DragData != owner)
		{
			return;
		}
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData != null)
		{
			dragData.ClearData();
		}
		FormationViewDragController.DragData = null;
	}

	// Token: 0x0600A7ED RID: 42989 RVA: 0x00316C6D File Offset: 0x00314E6D
	public static void AddCustomShieldHotKeyComponentSetData(int index)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		dragData.CustomShieldHotKeyComponentSet.Add(index);
	}

	// Token: 0x0600A7EE RID: 42990 RVA: 0x00316C85 File Offset: 0x00314E85
	public static void SetCustomShield(bool active)
	{
		if (FormationViewDragController.DragData == null)
		{
			return;
		}
		UiNavigationModel.Instance.CustomShieldHotKeyComponent(FormationViewDragController.DragData.CustomShieldHotKeyComponentSet, active);
	}

	// Token: 0x0600A7EF RID: 42991 RVA: 0x00316CA4 File Offset: 0x00314EA4
	[NullableContext(2)]
	public static void OnFormationRoleViewPointDown(ULGUIPointerEventData eventData, int configId, int roleSkinId, int editPosition)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null || eventData == null)
		{
			return;
		}
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, dragData.LastDragPos);
		dragData.TempPointerPosition.Set(dragData.LastDragPos.X, 0.0, dragData.LastDragPos.Y);
		FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
		if (dragRoleItem != null)
		{
			UUIItem rootItem = dragRoleItem.GetRootItem();
			FVector fvector = dragData.TempPointerPosition.ToUeVectorOld();
			rootItem.SetUIWorldLocation(fvector);
		}
		FormationRoleDragItem dragRoleItem2 = dragData.DragRoleItem;
		if (dragRoleItem2 != null)
		{
			dragRoleItem2.RefreshRoleIcon(configId, roleSkinId);
		}
		dragData.DragItemPosition = editPosition;
		FormationViewDragController.EndOtherSlotsDragItem(dragData, editPosition);
		FormationViewDragController.PrepareDragVisualsAndRefresh(dragData, configId, roleSkinId, editPosition, false).Forget();
	}

	// Token: 0x0600A7F0 RID: 42992 RVA: 0x00316D54 File Offset: 0x00314F54
	public static void OnFormationRoleViewGamePadDown(UUIItem item, int configId, int roleSkinId, int editPosition)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		FVector uiworldPosition = item.GetUIWorldPosition();
		FormationViewDragController.GamePadDragWorldPos.Set(uiworldPosition.X + 30f, uiworldPosition.Y, uiworldPosition.Z + -50f);
		FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
		if (dragRoleItem != null)
		{
			dragRoleItem.RefreshRoleIcon(configId, roleSkinId);
		}
		dragData.DragItemPosition = editPosition;
		FormationViewDragController.EndOtherSlotsDragItem(dragData, editPosition);
		FormationViewDragController.PrepareDragVisualsAndRefresh(dragData, configId, roleSkinId, editPosition, true).Forget();
	}

	// Token: 0x0600A7F1 RID: 42993 RVA: 0x00316DCA File Offset: 0x00314FCA
	public static bool CanFormationRoleViewStartDrag()
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		return ((dragData != null) ? dragData.DragRoleItem : null) != null;
	}

	// Token: 0x0600A7F2 RID: 42994 RVA: 0x00316DE0 File Offset: 0x00314FE0
	public static void OnFormationRoleViewStartDrag()
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
		if (dragRoleItem != null)
		{
			dragRoleItem.GetRootItem().SetUIActive(true);
		}
		foreach (IDraggableSlot draggableSlot in dragData.DraggableSlots)
		{
			draggableSlot.RefreshLockItemState(true);
		}
		FormationViewDragController.RefreshDragRoleItemState(dragData, true, false);
		UiNavigationViewManager.Instance.RefreshCurrentHotKey();
		if (Info.Instance.IsInGamepad())
		{
			FormationViewDragController.DragStartMoveFirstRelease = true;
			FormationViewDragController.SetGamePadSelectModel(true);
		}
	}

	// Token: 0x0600A7F3 RID: 42995 RVA: 0x00316E7C File Offset: 0x0031507C
	[NullableContext(2)]
	public static void OnFormationRoleViewMoveDrag(ULGUIPointerEventData eventData)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null || eventData == null)
		{
			return;
		}
		LguiUtil.Instance.ConvertPointerPositionToLguiCenterPosition(eventData.pointerPosition, dragData.CurDragPos);
		if (Vector2D.Create(dragData.CurDragPos.X, dragData.CurDragPos.Y).SubtractionEqual(dragData.LastDragPos).IsNearlyZero(0.0))
		{
			return;
		}
		FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
		if (dragRoleItem == null)
		{
			return;
		}
		UUIItem rootItem = dragRoleItem.GetRootItem();
		dragData.TempAnchorOffset.FromUeVector2D(rootItem.GetAnchorOffset());
		dragData.TempAnchorOffset.X += dragData.CurDragPos.X - dragData.LastDragPos.X;
		dragData.TempAnchorOffset.Y += dragData.CurDragPos.Y - dragData.LastDragPos.Y;
		rootItem.SetAnchorOffset(dragData.TempAnchorOffset.ToUeVector2D(false));
		dragData.LastDragPos.DeepCopy(dragData.CurDragPos);
		int? id = PlayerInfoModel.Instance.GetId();
		bool flag = false;
		bool hoverExchangeable = false;
		for (int i = 0; i < dragData.DraggableSlots.Count; i++)
		{
			IDraggableSlot draggableSlot = dragData.DraggableSlots[i];
			bool flag2 = draggableSlot.GetConfigId().GetValueOrDefault() > 0;
			bool positionInRange = FormationViewDragController.GetPositionInRange(draggableSlot.GetRootItem());
			if (i + 1 != dragData.DragItemPosition && positionInRange)
			{
				flag = true;
			}
			if (flag2 && positionInRange)
			{
				draggableSlot.ShowOtherItemUpState();
				if (i + 1 != dragData.DragItemPosition)
				{
					int playerId = draggableSlot.GetPlayerId();
					int? num = id;
					if (playerId == num.GetValueOrDefault() & num != null)
					{
						hoverExchangeable = true;
					}
				}
			}
			else
			{
				draggableSlot.EndShowDragItem();
			}
		}
		FormationViewDragController.RefreshDragRoleItemState(dragData, !flag, hoverExchangeable);
	}

	// Token: 0x0600A7F4 RID: 42996 RVA: 0x0031704C File Offset: 0x0031524C
	public static void OnFormationRoleViewEndDrag(bool isCancel = false)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		foreach (IDraggableSlot draggableSlot in dragData.DraggableSlots)
		{
			draggableSlot.RefreshLockItemState(false);
		}
		FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
		if (dragRoleItem != null)
		{
			dragRoleItem.GetRootItem().SetUIActive(false);
		}
		FormationViewDragController.RefreshDragRoleItemState(dragData, false, false);
		int? id = PlayerInfoModel.Instance.GetId();
		int num = -1;
		int num2 = 0;
		for (int i = 0; i < dragData.DraggableSlots.Count; i++)
		{
			IDraggableSlot draggableSlot2 = dragData.DraggableSlots[i];
			int valueOrDefault = draggableSlot2.GetConfigId().GetValueOrDefault();
			if (valueOrDefault > 0)
			{
				int playerId = draggableSlot2.GetPlayerId();
				int? num3 = id;
				if ((playerId == num3.GetValueOrDefault() & num3 != null) && FormationViewDragController.GetPositionInRange(draggableSlot2.GetRootItem()))
				{
					num = i + 1;
					num2 = valueOrDefault;
					break;
				}
			}
		}
		foreach (IDraggableSlot draggableSlot3 in dragData.DraggableSlots)
		{
			draggableSlot3.EndShowDragItem();
		}
		int dragItemPosition = dragData.DragItemPosition;
		if (num <= 0 || num2 <= 0 || num == dragItemPosition || isCancel)
		{
			return;
		}
		int valueOrDefault2 = dragData.DraggableSlots[dragItemPosition - 1].GetConfigId().GetValueOrDefault();
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "编队角色更换-拖拽", default(ReadOnlySpan<ValueTuple<string, object>>));
		Action<int, int, int, int> exchangeRoleCallBack = dragData.ExchangeRoleCallBack;
		if (exchangeRoleCallBack == null)
		{
			return;
		}
		exchangeRoleCallBack(num, dragItemPosition, valueOrDefault2, num2);
	}

	// Token: 0x0600A7F5 RID: 42997 RVA: 0x003171FC File Offset: 0x003153FC
	public static void OnGamePadPress()
	{
		IDraggableSlot draggableSlot = (FormationViewDragController.DragData != null) ? FormationViewDragController.DragData.DraggableSlots[FormationViewDragController.DragData.DragItemPosition - 1] : null;
		if (draggableSlot == null)
		{
			return;
		}
		draggableSlot.GamePadPress();
	}

	// Token: 0x0600A7F6 RID: 42998 RVA: 0x0031722D File Offset: 0x0031542D
	public static void OnGamePadRelease()
	{
		IDraggableSlot draggableSlot = (FormationViewDragController.DragData != null) ? FormationViewDragController.DragData.DraggableSlots[FormationViewDragController.DragData.DragItemPosition - 1] : null;
		if (draggableSlot == null)
		{
			return;
		}
		draggableSlot.GamePadRelease();
	}

	// Token: 0x0600A7F7 RID: 42999 RVA: 0x00317260 File Offset: 0x00315460
	public void DragConfirm()
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "Formation-GamePad-DragConfirm", default(ReadOnlySpan<ValueTuple<string, object>>));
		dragData.DraggableSlots[dragData.DragItemPosition - 1].GamePadUp(false);
		FormationViewDragController.SetGamePadSelectModel(false);
	}

	// Token: 0x0600A7F8 RID: 43000 RVA: 0x003172B4 File Offset: 0x003154B4
	public void CancelDrag()
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null || !FormationViewDragController.GamePadSelectModel)
		{
			return;
		}
		Log.Instance.Info(ELogModule.Formation, ELogAuthor.SYB, "Formation-GamePad-CancelDrag", default(ReadOnlySpan<ValueTuple<string, object>>));
		dragData.DraggableSlots[dragData.DragItemPosition - 1].GamePadUp(true);
		FormationViewDragController.SetGamePadSelectModel(false);
	}

	// Token: 0x0600A7F9 RID: 43001 RVA: 0x00317310 File Offset: 0x00315510
	public static void SetGamePadSelectPosition(int position)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		if (FormationViewDragController.GamePadSelectModel)
		{
			FormationViewDragController.PendingSelectPosition = position;
		}
		else
		{
			dragData.DragItemPosition = position;
			foreach (IDraggableSlot draggableSlot in dragData.DraggableSlots)
			{
				draggableSlot.GamePadUp(false);
			}
		}
		FVector uiworldPosition = dragData.DraggableSlots[position - 1].GetRootItem().GetUIWorldPosition();
		FormationViewDragController.GamePadDragWorldPos.Set(uiworldPosition.X + 30f, uiworldPosition.Y, uiworldPosition.Z + -50f);
		FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
		if (dragRoleItem == null)
		{
			return;
		}
		dragRoleItem.GetRootItem().SetUIWorldLocation(FormationViewDragController.GamePadDragWorldPos);
		if (!dragRoleItem.GetRootItem().IsUIActiveSelf())
		{
			return;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		bool hoverExchangeable = false;
		for (int i = 0; i < dragData.DraggableSlots.Count; i++)
		{
			IDraggableSlot draggableSlot2 = dragData.DraggableSlots[i];
			if (i == position - 1)
			{
				draggableSlot2.ShowOtherItemUpState();
				if (position != dragData.DragItemPosition && draggableSlot2.GetConfigId().GetValueOrDefault() > 0)
				{
					int playerId = draggableSlot2.GetPlayerId();
					int? num = id;
					if (playerId == num.GetValueOrDefault() & num != null)
					{
						hoverExchangeable = true;
					}
				}
			}
			else
			{
				draggableSlot2.EndShowDragItem();
			}
		}
		FormationViewDragController.RefreshDragRoleItemState(dragData, position == dragData.DragItemPosition, hoverExchangeable);
	}

	// Token: 0x0600A7FA RID: 43002 RVA: 0x00317488 File Offset: 0x00315688
	public static void SetGamePadSelectModel(bool isSelect)
	{
		FormationViewDragController.GamePadSelectModel = isSelect;
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		if (FormationViewDragController.GamePadSelectModel)
		{
			FormationViewDragController.PendingSelectPosition = dragData.DragItemPosition;
		}
		else
		{
			dragData.DragItemPosition = FormationViewDragController.PendingSelectPosition;
		}
		UiNavigationModel.Instance.CustomShieldHotKeyComponent(dragData.CustomShieldHotKeyComponentSet, !FormationViewDragController.GamePadSelectModel);
	}

	// Token: 0x0600A7FB RID: 43003 RVA: 0x003174DC File Offset: 0x003156DC
	public static bool GetDragItemUiActive()
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		bool? flag;
		if (dragData == null)
		{
			flag = null;
		}
		else
		{
			FormationRoleDragItem dragRoleItem = dragData.DragRoleItem;
			flag = ((dragRoleItem != null) ? new bool?(dragRoleItem.GetRootItem().IsUIActiveSelf()) : null);
		}
		bool? flag2 = flag;
		return flag2.GetValueOrDefault();
	}

	// Token: 0x0600A7FC RID: 43004 RVA: 0x00317528 File Offset: 0x00315728
	public static bool GetPositionInRange(UUIItem item)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		FormationRoleDragItem formationRoleDragItem = (dragData != null) ? dragData.DragRoleItem : null;
		if (dragData == null || formationRoleDragItem == null)
		{
			return false;
		}
		FVector lguispaceAbsolutePosition = item.GetLGUISpaceAbsolutePosition();
		float num = item.GetWidth() / 2f;
		float num2 = item.GetHeight() / 2f;
		FVector lguispaceAbsolutePosition2 = formationRoleDragItem.GetRootItem().GetLGUISpaceAbsolutePosition();
		return lguispaceAbsolutePosition2.X >= lguispaceAbsolutePosition.X - num && lguispaceAbsolutePosition2.X <= lguispaceAbsolutePosition.X + num && lguispaceAbsolutePosition2.Y >= lguispaceAbsolutePosition.Y - num2 && lguispaceAbsolutePosition2.Y <= lguispaceAbsolutePosition.Y + num2;
	}

	// Token: 0x0600A7FD RID: 43005 RVA: 0x003175C8 File Offset: 0x003157C8
	private static UniTask PrepareDragVisualsAndRefresh(FormationDragData dragData, int configId, int roleSkinId, int editPosition, bool isGamepad)
	{
		FormationViewDragController.<PrepareDragVisualsAndRefresh>d__28 <PrepareDragVisualsAndRefresh>d__;
		<PrepareDragVisualsAndRefresh>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<PrepareDragVisualsAndRefresh>d__.dragData = dragData;
		<PrepareDragVisualsAndRefresh>d__.configId = configId;
		<PrepareDragVisualsAndRefresh>d__.roleSkinId = roleSkinId;
		<PrepareDragVisualsAndRefresh>d__.editPosition = editPosition;
		<PrepareDragVisualsAndRefresh>d__.isGamepad = isGamepad;
		<PrepareDragVisualsAndRefresh>d__.<>1__state = -1;
		<PrepareDragVisualsAndRefresh>d__.<>t__builder.Start<FormationViewDragController.<PrepareDragVisualsAndRefresh>d__28>(ref <PrepareDragVisualsAndRefresh>d__);
		return <PrepareDragVisualsAndRefresh>d__.<>t__builder.Task;
	}

	// Token: 0x0600A7FE RID: 43006 RVA: 0x0031762C File Offset: 0x0031582C
	private static void RefreshDragRoleItemState(FormationDragData dragData, bool notInOtherSlot, bool hoverExchangeable)
	{
		FormationRoleDragAvatarItem formationRoleDragAvatarItem = dragData.DragRoleItem as FormationRoleDragAvatarItem;
		if (formationRoleDragAvatarItem == null)
		{
			return;
		}
		formationRoleDragAvatarItem.SetDraggingState(notInOtherSlot);
		formationRoleDragAvatarItem.SetBgLightState(hoverExchangeable);
	}

	// Token: 0x0600A7FF RID: 43007 RVA: 0x00317658 File Offset: 0x00315858
	private static void EndOtherSlotsDragItem(FormationDragData dragData, int exceptPosition)
	{
		for (int i = 0; i < dragData.DraggableSlots.Count; i++)
		{
			if (i + 1 != exceptPosition)
			{
				dragData.DraggableSlots[i].EndShowDragItem();
			}
		}
	}

	// Token: 0x17001191 RID: 4497
	// (get) Token: 0x0600A800 RID: 43008 RVA: 0x00317692 File Offset: 0x00315892
	public static FormationViewDragController Instance
	{
		get
		{
			return FormationViewDragController._Instance;
		}
	}

	// Token: 0x0600A801 RID: 43009 RVA: 0x00317699 File Offset: 0x00315899
	public static FormationViewDragController GetOrCreateInstance()
	{
		if (FormationViewDragController._Instance == null)
		{
			FormationViewDragController.CreateInstance();
		}
		return FormationViewDragController._Instance;
	}

	// Token: 0x0600A802 RID: 43010 RVA: 0x003176AD File Offset: 0x003158AD
	public static bool CreateInstance()
	{
		if (FormationViewDragController._Instance != null)
		{
			return true;
		}
		FormationViewDragController._Instance = new FormationViewDragController();
		return true;
	}

	// Token: 0x0600A803 RID: 43011 RVA: 0x003176C3 File Offset: 0x003158C3
	public static void CreateStaticDefaultValue()
	{
		FormationViewDragController.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600A804 RID: 43012 RVA: 0x003176CA File Offset: 0x003158CA
	public static void ResetStaticDefaultValue()
	{
		FormationViewDragController._Instance = null;
		FormationViewDragController.OnResetStaticDefaultValue();
	}

	// Token: 0x0600A805 RID: 43013 RVA: 0x003176D7 File Offset: 0x003158D7
	private static void OnCreateStaticDefaultValue()
	{
		FormationViewDragController.DragData = null;
		FormationViewDragController.DraggingIndex = 0;
		FormationViewDragController.DragStartMoveFirstRelease = false;
		FormationViewDragController.GamePadSelectModel = false;
		FormationViewDragController.IsGamepad = false;
		FormationViewDragController.PendingSelectPosition = 0;
		FormationViewDragController.GamePadDragWorldPos = default(FVector);
	}

	// Token: 0x0600A806 RID: 43014 RVA: 0x00317708 File Offset: 0x00315908
	private static void OnResetStaticDefaultValue()
	{
		FormationViewDragController.DragData = null;
		FormationViewDragController.DraggingIndex = 0;
		FormationViewDragController.DragStartMoveFirstRelease = false;
		FormationViewDragController.GamePadSelectModel = false;
		FormationViewDragController.IsGamepad = false;
		FormationViewDragController.PendingSelectPosition = 0;
		FormationViewDragController.GamePadDragWorldPos = default(FVector);
	}

	// Token: 0x0600A807 RID: 43015 RVA: 0x00317739 File Offset: 0x00315939
	static FormationViewDragController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationViewDragController.CreateStaticDefaultValue), new Action(FormationViewDragController.ResetStaticDefaultValue));
	}

	// Token: 0x040061A9 RID: 25001
	public static int DraggingIndex;

	// Token: 0x040061AA RID: 25002
	public static bool DragStartMoveFirstRelease;

	// Token: 0x040061AB RID: 25003
	public static bool GamePadSelectModel;

	// Token: 0x040061AC RID: 25004
	[Nullable(2)]
	private static FormationDragData DragData;

	// Token: 0x040061AD RID: 25005
	private static bool IsGamepad;

	// Token: 0x040061AE RID: 25006
	private static int PendingSelectPosition;

	// Token: 0x040061AF RID: 25007
	private static FVector GamePadDragWorldPos;

	// Token: 0x040061B0 RID: 25008
	[Nullable(2)]
	private static FormationViewDragController _Instance;
}
