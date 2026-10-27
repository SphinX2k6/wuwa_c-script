using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x020019E2 RID: 6626
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ControlScreenController : UiControllerBase
{
	// Token: 0x0600C1A7 RID: 49575 RVA: 0x002BB990 File Offset: 0x002B9B90
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x0600C1A8 RID: 49576 RVA: 0x002BB994 File Offset: 0x002B9B94
	protected override void OnAddEvents()
	{
		EventSystem.Instance.Add(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoadCompleted));
		EventSystem.Instance.Add<EntityHandle, EntityHandle>(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Add(EEventName.OnRoleGoDown, new Action<int>(this.OnRoleGoDown));
		InputDistributeController.Instance.BindTouches(new int[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x0600C1A9 RID: 49577 RVA: 0x002BBA20 File Offset: 0x002B9C20
	protected override void OnRemoveEvents()
	{
		EventSystem.Instance.Remove(EEventName.OnUpdateSceneTeam, new Action(this.OnFormationLoadCompleted));
		EventSystem.Instance.Remove(EEventName.OnChangeRole, new Action<EntityHandle, EntityHandle>(this.OnChangeRole));
		EventSystem.Instance.Remove(EEventName.OnRoleGoDown, new Action<int>(this.OnRoleGoDown));
		EventSystem.Instance.RemoveAllTargetUseKey(this);
		InputDistributeController.Instance.UnBindTouches(new int[]
		{
			0,
			1,
			2,
			3,
			4,
			5,
			6,
			7,
			8,
			9
		}, new TInputHandle<InputDistributeDefine.ITouchData>(this.OnTouch));
	}

	// Token: 0x0600C1AA RID: 49578 RVA: 0x002BBAB8 File Offset: 0x002B9CB8
	private void TouchTrigger(bool bTouchPress, int touchId)
	{
		TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData((EFingerIndex)touchId);
		if (touchFingerData == null)
		{
			return;
		}
		ControlScreenModel instance = ControlScreenModel.Instance;
		if (bTouchPress)
		{
			ULGUIPointerEventData pointerEventData = touchFingerData.GetPointerEventData();
			USceneComponent usceneComponent = (pointerEventData != null) ? pointerEventData.enterComponent : null;
			USceneComponent usceneComponent2 = (pointerEventData != null) ? pointerEventData.pressComponent : null;
			if (!touchFingerData.IsTouchEmpty() && !touchFingerData.IsTouchComponentContainTag(ControlScreenDefine.ignoreTag))
			{
				touchFingerData.GetFingerIndex();
				if (pointerEventData != null)
				{
					bool isOpenJoystickLog = BattleUiModel.Instance.IsOpenJoystickLog;
					return;
				}
				bool isOpenJoystickLog2 = BattleUiModel.Instance.IsOpenJoystickLog;
				return;
			}
			else
			{
				instance.AddTouchEmptyFingerData(touchFingerData);
				if (instance.IsDoubleTouch(touchId) && instance.IsDoubleTouchResetCameraComponent(touchFingerData, ControlScreenDefine.resetCameraTag))
				{
					BattleUiControl.Instance.ResetFocus();
				}
				instance.SetCurrentTouchTimeStamp(TimeUtil.Instance.GetServerTimeStamp());
				instance.SetCurrentTouchId(touchId);
				if (usceneComponent != null)
				{
					instance.SetCurrentEnterComponent(usceneComponent);
				}
				if (usceneComponent2 != null)
				{
					instance.SetCurrentPressComponent(usceneComponent2);
					return;
				}
			}
		}
		else
		{
			instance.RemoveTouchEmptyFingerData(touchFingerData);
		}
	}

	// Token: 0x0600C1AB RID: 49579 RVA: 0x002BBB9C File Offset: 0x002B9D9C
	private void TouchMoved(int touchId)
	{
		ControlScreenModel instance = ControlScreenModel.Instance;
		int touchEmptyFingerDataCount = instance.GetTouchEmptyFingerDataCount();
		if (touchEmptyFingerDataCount == 1)
		{
			this.RefreshCameraRotation((EFingerIndex)touchId);
			return;
		}
		if (touchEmptyFingerDataCount != 2)
		{
			return;
		}
		TouchFingerData[] touchEmptyFingerDataByCount = instance.GetTouchEmptyFingerDataByCount(2);
		TouchFingerData touchFingerData = touchEmptyFingerDataByCount[0];
		TouchFingerData touchFingerData2 = touchEmptyFingerDataByCount[1];
		EFingerIndex fingerIndex = touchFingerData.GetFingerIndex();
		EFingerIndex fingerIndex2 = touchFingerData2.GetFingerIndex();
		this.RefreshCameraSpringLength(fingerIndex, fingerIndex2);
	}

	// Token: 0x0600C1AC RID: 49580 RVA: 0x002BBBF0 File Offset: 0x002B9DF0
	private void OnTouch(string touchIdName, InputDistributeDefine.ITouchData touchData, InputIdentification _)
	{
		InputDistributeDefine.ETouchType touchType = touchData.TouchType;
		int touchId = int.Parse(touchIdName);
		switch (touchType)
		{
		case InputDistributeDefine.ETouchType.TouchBegin:
			this.TouchTrigger(true, touchId);
			return;
		case InputDistributeDefine.ETouchType.TouchEnd:
			this.TouchTrigger(false, touchId);
			return;
		case InputDistributeDefine.ETouchType.TouchMove:
			this.TouchMoved(touchId);
			return;
		default:
			return;
		}
	}

	// Token: 0x0600C1AD RID: 49581 RVA: 0x002BBC38 File Offset: 0x002B9E38
	public bool RefreshCameraRotation(EFingerIndex fingerIndex)
	{
		if (!this.CanCameraRotationInput())
		{
			bool isOpenJoystickLog = BattleUiModel.Instance.IsOpenJoystickLog;
			return false;
		}
		TouchFingerData touchFingerData = TouchFingerManager.Instance.GetTouchFingerData(fingerIndex);
		if (touchFingerData == null)
		{
			return false;
		}
		if (!touchFingerData.IsInTouch())
		{
			return false;
		}
		if (!ControlScreenModel.Instance.IsTouchEmpty(fingerIndex))
		{
			return false;
		}
		this.ExecuteCameraRotation(fingerIndex);
		return true;
	}

	// Token: 0x0600C1AE RID: 49582 RVA: 0x002BBC8C File Offset: 0x002B9E8C
	public bool RefreshCameraSpringLength(EFingerIndex aFingerIndex, EFingerIndex bFingerIndex)
	{
		if (!this.CanCameraZoomInput())
		{
			return false;
		}
		this.ExecuteCameraZoom(aFingerIndex, bFingerIndex);
		return true;
	}

	// Token: 0x0600C1AF RID: 49583 RVA: 0x002BBCA4 File Offset: 0x002B9EA4
	public void ExecuteCameraRotation(EFingerIndex fingerIndex)
	{
		ValueTuple<float, float>? fingerDirection = TouchFingerManager.Instance.GetFingerDirection(fingerIndex);
		if (fingerDirection == null)
		{
			return;
		}
		float rotationScreenRate = ControlScreenModel.Instance.GetRotationScreenRate();
		float value = fingerDirection.Value.Item1 * rotationScreenRate;
		float value2 = fingerDirection.Value.Item2 * rotationScreenRate;
		InputController.Instance.InputAxis(EInputAxis.Turn, value, true);
		InputController.Instance.InputAxis(EInputAxis.LookUp, value2, true);
	}

	// Token: 0x0600C1B0 RID: 49584 RVA: 0x002BBD14 File Offset: 0x002B9F14
	public void ExecuteCameraZoom(EFingerIndex aFingerIndex, EFingerIndex bFingerIndex)
	{
		ControlScreenModel instance = ControlScreenModel.Instance;
		float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(aFingerIndex, bFingerIndex);
		float value = MathUtils.Instance.RangeClamp(fingerExpandCloseValue, instance.MinTouchMoveDifference, instance.MaxTouchMoveDifference, instance.MinTouchMoveValue, instance.MaxTouchMoveValue);
		InputController.Instance.InputAxis(EInputAxis.Zoom, value, true);
	}

	// Token: 0x0600C1B1 RID: 49585 RVA: 0x002BBD6C File Offset: 0x002B9F6C
	public void OnFormationLoadCompleted()
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return;
		}
		ControlScreenModel.Instance.RefreshRotationScreenRate();
		this.AddRoleEvents(getCurrentEntity.Entity);
	}

	// Token: 0x0600C1B2 RID: 49586 RVA: 0x002BBDA0 File Offset: 0x002B9FA0
	public void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle)
	{
		EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
		if (getCurrentEntity == null)
		{
			return;
		}
		ControlScreenModel.Instance.RefreshRotationScreenRate();
		this.AddRoleEvents(getCurrentEntity.Entity);
	}

	// Token: 0x0600C1B3 RID: 49587 RVA: 0x002BBDD4 File Offset: 0x002B9FD4
	public void OnRoleGoDown(int creatureDataId)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity((long)creatureDataId);
		if (entity == null)
		{
			return;
		}
		this.RemoveRoleEvents(entity);
	}

	// Token: 0x0600C1B4 RID: 49588 RVA: 0x002BBDFC File Offset: 0x002B9FFC
	public void OnRemoveEntity(ERemoveEntityType removeType, EntityHandle handle)
	{
		CreatureDataComponent component = handle.Entity.GetComponent<CreatureDataComponent>();
		if (component == null || !component.Valid)
		{
			return;
		}
		if (component.GetEntityType() != EEntityType.Player)
		{
			return;
		}
		int? id = PlayerInfoModel.Instance.GetId();
		int playerId = component.GetPlayerId();
		if (!(id.GetValueOrDefault() == playerId & id != null))
		{
			return;
		}
		this.RemoveRoleEvents(handle);
	}

	// Token: 0x0600C1B5 RID: 49589 RVA: 0x002BBE58 File Offset: 0x002BA058
	private void AddRoleEvents(Entity entity)
	{
		int id = entity.Id;
		if (this.CurrentAddEventEntityId == id)
		{
			return;
		}
		this.CurrentAddEventEntityId = id;
		if (entity == null)
		{
			return;
		}
		if (!EventSystem.Instance.HasWithTarget(entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.OnCharCameraStateChanged)))
		{
			EventSystem.Instance.AddWithTarget(entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.OnCharCameraStateChanged));
		}
		EntityHandle entityById = CreatureModel.Instance.GetEntityById(id);
		if (entityById != null && !EventSystem.Instance.HasWithTarget(entityById, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
		{
			EventSystem.Instance.AddWithTargetUseHoldKey<ERemoveEntityType, EntityHandle>(this, entityById, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0600C1B6 RID: 49590 RVA: 0x002BBF08 File Offset: 0x002BA108
	private void RemoveRoleEvents(EntityHandle handle)
	{
		if (EventSystem.Instance.HasWithTarget(handle.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.OnCharCameraStateChanged)))
		{
			EventSystem.Instance.RemoveWithTarget(handle.Entity, EEventName.CharOnDirectionStateChanged, new Action<ECharDirectionState, ECharDirectionState>(this.OnCharCameraStateChanged));
		}
		if (EventSystem.Instance.HasWithTarget(handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity)))
		{
			EventSystem.Instance.RemoveWithTargetUseKey(this, handle, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnRemoveEntity));
		}
	}

	// Token: 0x0600C1B7 RID: 49591 RVA: 0x002BBF96 File Offset: 0x002BA196
	public void OnCharCameraStateChanged(ECharDirectionState oldMoveState, ECharDirectionState newMoveState)
	{
		if (newMoveState == oldMoveState)
		{
			return;
		}
		ControlScreenModel.Instance.RefreshRotationScreenRate();
	}

	// Token: 0x0600C1B8 RID: 49592 RVA: 0x002BBFA7 File Offset: 0x002BA1A7
	private bool CanCameraRotationInput()
	{
		return InputDistributeController.Instance.IsAllowFightCameraRotationInput();
	}

	// Token: 0x0600C1B9 RID: 49593 RVA: 0x002BBFB3 File Offset: 0x002BA1B3
	private bool CanCameraZoomInput()
	{
		return InputDistributeController.Instance.IsAllowFightCameraZoomInput();
	}

	// Token: 0x1700102F RID: 4143
	// (get) Token: 0x0600C1BA RID: 49594 RVA: 0x002BBFBF File Offset: 0x002BA1BF
	public static ControlScreenController Instance
	{
		get
		{
			return ControlScreenController._Instance;
		}
	}

	// Token: 0x0600C1BB RID: 49595 RVA: 0x002BBFC6 File Offset: 0x002BA1C6
	public static ControlScreenController GetOrCreateInstance()
	{
		if (ControlScreenController._Instance == null)
		{
			ControlScreenController.CreateInstance();
		}
		return ControlScreenController._Instance;
	}

	// Token: 0x0600C1BC RID: 49596 RVA: 0x002BBFDA File Offset: 0x002BA1DA
	public static bool CreateInstance()
	{
		if (ControlScreenController._Instance != null)
		{
			return true;
		}
		ControlScreenController._Instance = new ControlScreenController();
		return true;
	}

	// Token: 0x0600C1BD RID: 49597 RVA: 0x002BBFF0 File Offset: 0x002BA1F0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C1BE RID: 49598 RVA: 0x002BBFF2 File Offset: 0x002BA1F2
	public static void ResetStaticDefaultValue()
	{
		ControlScreenController._Instance = null;
	}

	// Token: 0x0600C1BF RID: 49599 RVA: 0x002BBFFA File Offset: 0x002BA1FA
	static ControlScreenController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ControlScreenController.CreateStaticDefaultValue), new Action(ControlScreenController.ResetStaticDefaultValue));
	}

	// Token: 0x0400593C RID: 22844
	private int CurrentAddEventEntityId;

	// Token: 0x0400593D RID: 22845
	[Nullable(2)]
	private static ControlScreenController _Instance;
}
