using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x02000EA1 RID: 3745
[NullableContext(1)]
[Nullable(0)]
[Controller(0)]
public class ControlScreenController : UiControllerBase
{
	// Token: 0x060095B4 RID: 38324 RVA: 0x002C6968 File Offset: 0x002C4B68
	protected override bool OnInit()
	{
		return true;
	}

	// Token: 0x060095B5 RID: 38325 RVA: 0x002C696C File Offset: 0x002C4B6C
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

	// Token: 0x060095B6 RID: 38326 RVA: 0x002C69F8 File Offset: 0x002C4BF8
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

	// Token: 0x060095B7 RID: 38327 RVA: 0x002C6A90 File Offset: 0x002C4C90
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

	// Token: 0x060095B8 RID: 38328 RVA: 0x002C6B74 File Offset: 0x002C4D74
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

	// Token: 0x060095B9 RID: 38329 RVA: 0x002C6BC8 File Offset: 0x002C4DC8
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

	// Token: 0x060095BA RID: 38330 RVA: 0x002C6C10 File Offset: 0x002C4E10
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

	// Token: 0x060095BB RID: 38331 RVA: 0x002C6C64 File Offset: 0x002C4E64
	public bool RefreshCameraSpringLength(EFingerIndex aFingerIndex, EFingerIndex bFingerIndex)
	{
		if (!this.CanCameraZoomInput())
		{
			return false;
		}
		this.ExecuteCameraZoom(aFingerIndex, bFingerIndex);
		return true;
	}

	// Token: 0x060095BC RID: 38332 RVA: 0x002C6C7C File Offset: 0x002C4E7C
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

	// Token: 0x060095BD RID: 38333 RVA: 0x002C6CEC File Offset: 0x002C4EEC
	public void ExecuteCameraZoom(EFingerIndex aFingerIndex, EFingerIndex bFingerIndex)
	{
		ControlScreenModel instance = ControlScreenModel.Instance;
		float fingerExpandCloseValue = TouchFingerManager.Instance.GetFingerExpandCloseValue(aFingerIndex, bFingerIndex);
		float value = MathUtils.Instance.RangeClamp(fingerExpandCloseValue, instance.MinTouchMoveDifference, instance.MaxTouchMoveDifference, instance.MinTouchMoveValue, instance.MaxTouchMoveValue);
		InputController.Instance.InputAxis(EInputAxis.Zoom, value, true);
	}

	// Token: 0x060095BE RID: 38334 RVA: 0x002C6D44 File Offset: 0x002C4F44
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

	// Token: 0x060095BF RID: 38335 RVA: 0x002C6D78 File Offset: 0x002C4F78
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

	// Token: 0x060095C0 RID: 38336 RVA: 0x002C6DAC File Offset: 0x002C4FAC
	public void OnRoleGoDown(int creatureDataId)
	{
		EntityHandle entity = CreatureModel.Instance.GetEntity((long)creatureDataId);
		if (entity == null)
		{
			return;
		}
		this.RemoveRoleEvents(entity);
	}

	// Token: 0x060095C1 RID: 38337 RVA: 0x002C6DD4 File Offset: 0x002C4FD4
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

	// Token: 0x060095C2 RID: 38338 RVA: 0x002C6E30 File Offset: 0x002C5030
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

	// Token: 0x060095C3 RID: 38339 RVA: 0x002C6EE0 File Offset: 0x002C50E0
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

	// Token: 0x060095C4 RID: 38340 RVA: 0x002C6F6E File Offset: 0x002C516E
	public void OnCharCameraStateChanged(ECharDirectionState oldMoveState, ECharDirectionState newMoveState)
	{
		if (newMoveState == oldMoveState)
		{
			return;
		}
		ControlScreenModel.Instance.RefreshRotationScreenRate();
	}

	// Token: 0x060095C5 RID: 38341 RVA: 0x002C6F7F File Offset: 0x002C517F
	private bool CanCameraRotationInput()
	{
		return InputDistributeController.Instance.IsAllowFightCameraRotationInput();
	}

	// Token: 0x060095C6 RID: 38342 RVA: 0x002C6F8B File Offset: 0x002C518B
	private bool CanCameraZoomInput()
	{
		return InputDistributeController.Instance.IsAllowFightCameraZoomInput();
	}

	// Token: 0x17001054 RID: 4180
	// (get) Token: 0x060095C7 RID: 38343 RVA: 0x002C6F97 File Offset: 0x002C5197
	public static ControlScreenController Instance
	{
		get
		{
			return ControlScreenController._Instance;
		}
	}

	// Token: 0x060095C8 RID: 38344 RVA: 0x002C6F9E File Offset: 0x002C519E
	public static ControlScreenController GetOrCreateInstance()
	{
		if (ControlScreenController._Instance == null)
		{
			ControlScreenController.CreateInstance();
		}
		return ControlScreenController._Instance;
	}

	// Token: 0x060095C9 RID: 38345 RVA: 0x002C6FB2 File Offset: 0x002C51B2
	public static bool CreateInstance()
	{
		if (ControlScreenController._Instance != null)
		{
			return true;
		}
		ControlScreenController._Instance = new ControlScreenController();
		return true;
	}

	// Token: 0x060095CA RID: 38346 RVA: 0x002C6FC8 File Offset: 0x002C51C8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060095CB RID: 38347 RVA: 0x002C6FCA File Offset: 0x002C51CA
	public static void ResetStaticDefaultValue()
	{
		ControlScreenController._Instance = null;
	}

	// Token: 0x060095CC RID: 38348 RVA: 0x002C6FD2 File Offset: 0x002C51D2
	static ControlScreenController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ControlScreenController.CreateStaticDefaultValue), new Action(ControlScreenController.ResetStaticDefaultValue));
	}

	// Token: 0x04005A0B RID: 23051
	private int CurrentAddEventEntityId;

	// Token: 0x04005A0C RID: 23052
	[Nullable(2)]
	private static ControlScreenController _Instance;
}
