using System;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.UiNavigation;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001BC2 RID: 7106
[NullableContext(1)]
[Nullable(0)]
public class FormationViewDragController : UiControllerBase
{
	// Token: 0x0600D3D6 RID: 54230 RVA: 0x0030B9F8 File Offset: 0x00309BF8
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add<EInputControllerType, EInputControllerType>(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600D3D7 RID: 54231 RVA: 0x0030BA16 File Offset: 0x00309C16
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.InputControllerChange, new Action<EInputControllerType, EInputControllerType>(this.InputControllerChange));
	}

	// Token: 0x0600D3D8 RID: 54232 RVA: 0x0030BA34 File Offset: 0x00309C34
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
			else
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

	// Token: 0x0600D3D9 RID: 54233 RVA: 0x0030BAB2 File Offset: 0x00309CB2
	public static void InitDragData(FormationDragData data)
	{
		FormationViewDragController.DragData = data;
		FormationViewDragController.IsGamepad = Info.Instance.IsInGamepad();
		FormationViewDragController.DraggingIndex = 0;
		FormationViewDragController.GamePadSelectModel = false;
	}

	// Token: 0x0600D3DA RID: 54234 RVA: 0x0030BAD5 File Offset: 0x00309CD5
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

	// Token: 0x0600D3DB RID: 54235 RVA: 0x0030BAF9 File Offset: 0x00309CF9
	public static void AddCustomShieldHotKeyComponentSetData(int index)
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		if (dragData == null)
		{
			return;
		}
		dragData.CustomShieldHotKeyComponentSet.Add(index);
	}

	// Token: 0x0600D3DC RID: 54236 RVA: 0x0030BB11 File Offset: 0x00309D11
	public static void SetCustomShield(bool active)
	{
		if (FormationViewDragController.DragData == null)
		{
			return;
		}
		UiNavigationModel.Instance.CustomShieldHotKeyComponent(FormationViewDragController.DragData.CustomShieldHotKeyComponentSet, active);
	}

	// Token: 0x0600D3DD RID: 54237 RVA: 0x0030BB30 File Offset: 0x00309D30
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

	// Token: 0x0600D3DE RID: 54238 RVA: 0x0030BBE0 File Offset: 0x00309DE0
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

	// Token: 0x0600D3DF RID: 54239 RVA: 0x0030BC56 File Offset: 0x00309E56
	public static bool CanFormationRoleViewStartDrag()
	{
		FormationDragData dragData = FormationViewDragController.DragData;
		return ((dragData != null) ? dragData.DragRoleItem : null) != null;
	}

	// Token: 0x0600D3E0 RID: 54240 RVA: 0x0030BC6C File Offset: 0x00309E6C
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

	// Token: 0x0600D3E1 RID: 54241 RVA: 0x0030BD08 File Offset: 0x00309F08
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

	// Token: 0x0600D3E2 RID: 54242 RVA: 0x0030BED8 File Offset: 0x0030A0D8
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

	// Token: 0x0600D3E3 RID: 54243 RVA: 0x0030C088 File Offset: 0x0030A288
	public static void OnGamePadPress()
	{
		IDraggableSlot draggableSlot = (FormationViewDragController.DragData != null) ? FormationViewDragController.DragData.DraggableSlots[FormationViewDragController.DragData.DragItemPosition - 1] : null;
		if (draggableSlot == null)
		{
			return;
		}
		draggableSlot.GamePadPress();
	}

	// Token: 0x0600D3E4 RID: 54244 RVA: 0x0030C0B9 File Offset: 0x0030A2B9
	public static void OnGamePadRelease()
	{
		IDraggableSlot draggableSlot = (FormationViewDragController.DragData != null) ? FormationViewDragController.DragData.DraggableSlots[FormationViewDragController.DragData.DragItemPosition - 1] : null;
		if (draggableSlot == null)
		{
			return;
		}
		draggableSlot.GamePadRelease();
	}

	// Token: 0x0600D3E5 RID: 54245 RVA: 0x0030C0EC File Offset: 0x0030A2EC
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

	// Token: 0x0600D3E6 RID: 54246 RVA: 0x0030C140 File Offset: 0x0030A340
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

	// Token: 0x0600D3E7 RID: 54247 RVA: 0x0030C19C File Offset: 0x0030A39C
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

	// Token: 0x0600D3E8 RID: 54248 RVA: 0x0030C314 File Offset: 0x0030A514
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

	// Token: 0x0600D3E9 RID: 54249 RVA: 0x0030C368 File Offset: 0x0030A568
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

	// Token: 0x0600D3EA RID: 54250 RVA: 0x0030C3B4 File Offset: 0x0030A5B4
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

	// Token: 0x0600D3EB RID: 54251 RVA: 0x0030C454 File Offset: 0x0030A654
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

	// Token: 0x0600D3EC RID: 54252 RVA: 0x0030C4B8 File Offset: 0x0030A6B8
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

	// Token: 0x0600D3ED RID: 54253 RVA: 0x0030C4E4 File Offset: 0x0030A6E4
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

	// Token: 0x1700116C RID: 4460
	// (get) Token: 0x0600D3EE RID: 54254 RVA: 0x0030C51E File Offset: 0x0030A71E
	public static FormationViewDragController Instance
	{
		get
		{
			return FormationViewDragController._Instance;
		}
	}

	// Token: 0x0600D3EF RID: 54255 RVA: 0x0030C525 File Offset: 0x0030A725
	public static FormationViewDragController GetOrCreateInstance()
	{
		if (FormationViewDragController._Instance == null)
		{
			FormationViewDragController.CreateInstance();
		}
		return FormationViewDragController._Instance;
	}

	// Token: 0x0600D3F0 RID: 54256 RVA: 0x0030C539 File Offset: 0x0030A739
	public static bool CreateInstance()
	{
		if (FormationViewDragController._Instance != null)
		{
			return true;
		}
		FormationViewDragController._Instance = new FormationViewDragController();
		return true;
	}

	// Token: 0x0600D3F1 RID: 54257 RVA: 0x0030C54F File Offset: 0x0030A74F
	public static void CreateStaticDefaultValue()
	{
		FormationViewDragController.OnCreateStaticDefaultValue();
	}

	// Token: 0x0600D3F2 RID: 54258 RVA: 0x0030C556 File Offset: 0x0030A756
	public static void ResetStaticDefaultValue()
	{
		FormationViewDragController._Instance = null;
		FormationViewDragController.OnResetStaticDefaultValue();
	}

	// Token: 0x0600D3F3 RID: 54259 RVA: 0x0030C563 File Offset: 0x0030A763
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

	// Token: 0x0600D3F4 RID: 54260 RVA: 0x0030C594 File Offset: 0x0030A794
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

	// Token: 0x0600D3F5 RID: 54261 RVA: 0x0030C5C5 File Offset: 0x0030A7C5
	static FormationViewDragController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FormationViewDragController.CreateStaticDefaultValue), new Action(FormationViewDragController.ResetStaticDefaultValue));
	}

	// Token: 0x040060DA RID: 24794
	public static int DraggingIndex;

	// Token: 0x040060DB RID: 24795
	public static bool DragStartMoveFirstRelease;

	// Token: 0x040060DC RID: 24796
	public static bool GamePadSelectModel;

	// Token: 0x040060DD RID: 24797
	[Nullable(2)]
	private static FormationDragData DragData;

	// Token: 0x040060DE RID: 24798
	private static bool IsGamepad;

	// Token: 0x040060DF RID: 24799
	private static int PendingSelectPosition;

	// Token: 0x040060E0 RID: 24800
	private static FVector GamePadDragWorldPos;

	// Token: 0x040060E1 RID: 24801
	[Nullable(2)]
	private static FormationViewDragController _Instance;
}
