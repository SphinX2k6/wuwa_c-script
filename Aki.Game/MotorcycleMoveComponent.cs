using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x0200286C RID: 10348
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMoveComponent : VehicleMoveComponent
{
	// Token: 0x17002AD5 RID: 10965
	// (get) Token: 0x0601A37D RID: 107389 RVA: 0x0081C495 File Offset: 0x0081A695
	// (set) Token: 0x0601A37E RID: 107390 RVA: 0x0081C4A0 File Offset: 0x0081A6A0
	private EMotorDriftModel DriftModel
	{
		get
		{
			return this.DriftModelInternal;
		}
		set
		{
			if (this.DriftModelInternal == value)
			{
				return;
			}
			if (MotorcycleMoveComponent.driftModelTagMap.ContainsKey(this.DriftModelInternal))
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.RemoveTag(new int?(MotorcycleMoveComponent.driftModelTagMap[this.DriftModelInternal]));
				}
			}
			this.DriftModelInternal = value;
			if (MotorcycleMoveComponent.driftModelTagMap.ContainsKey(value))
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null)
				{
					return;
				}
				tagComponent2.AddTag(new int?(MotorcycleMoveComponent.driftModelTagMap[value]));
			}
		}
	}

	// Token: 0x17002AD6 RID: 10966
	// (get) Token: 0x0601A37F RID: 107391 RVA: 0x0081C524 File Offset: 0x0081A724
	// (set) Token: 0x0601A380 RID: 107392 RVA: 0x0081C52C File Offset: 0x0081A72C
	public bool BackBraking
	{
		get
		{
			return this.BackBrakingInternal;
		}
		set
		{
			this.BackBrakingInternal = value;
		}
	}

	// Token: 0x17002AD7 RID: 10967
	// (get) Token: 0x0601A381 RID: 107393 RVA: 0x0081C535 File Offset: 0x0081A735
	// (set) Token: 0x0601A382 RID: 107394 RVA: 0x0081C540 File Offset: 0x0081A740
	public bool DriftingState
	{
		get
		{
			return this.DriftingStateInternal;
		}
		set
		{
			if (this.DriftingStateInternal == value)
			{
				return;
			}
			this.DriftingStateInternal = value;
			if (value)
			{
				this.DriftStartTime = Time.Instance.NowSeconds;
				this.DriftDistance = 0.0;
				this.DriftLastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent != null)
				{
					tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.漂移"]));
				}
				if (this.DriftBuffId > 0L)
				{
					VehicleBuffComponent buffComp = this.BuffComp;
					if (buffComp == null)
					{
						return;
					}
					buffComp.AddBuff(this.DriftBuffId, new AddBuffParam
					{
						InstigatorId = this.BuffComp.CreatureDataId,
						Reason = "漂移buff"
					});
					return;
				}
			}
			else
			{
				MotorDriftLogEvent motorDriftLogEvent = new MotorDriftLogEvent();
				motorDriftLogEvent.i_drift_distance = (float)((int)Math.Round(this.DriftDistance / 100.0));
				motorDriftLogEvent.i_drift_time = (float)((int)Math.Round(Time.Instance.NowSeconds - this.DriftStartTime));
				LogReportController.Instance.LogReport(motorDriftLogEvent);
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 != null)
				{
					tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.漂移"]));
				}
				if (this.DriftBuffId > 0L)
				{
					VehicleBuffComponent buffComp2 = this.BuffComp;
					if (buffComp2 == null)
					{
						return;
					}
					buffComp2.RemoveBuff(this.DriftBuffId, -1, "漂移buff", null, null, null);
				}
			}
		}
	}

	// Token: 0x17002AD8 RID: 10968
	// (get) Token: 0x0601A383 RID: 107395 RVA: 0x0081C6B6 File Offset: 0x0081A8B6
	// (set) Token: 0x0601A384 RID: 107396 RVA: 0x0081C6C0 File Offset: 0x0081A8C0
	public bool FrontBrakingState
	{
		get
		{
			return this.FrontBrakingStateInternal;
		}
		set
		{
			if (this.FrontBrakingStateInternal == value)
			{
				return;
			}
			this.FrontBrakingStateInternal = value;
			if (value)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent == null)
				{
					return;
				}
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.刹车.前轮刹"]));
				return;
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null)
				{
					return;
				}
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.刹车.前轮刹"]));
				return;
			}
		}
	}

	// Token: 0x17002AD9 RID: 10969
	// (get) Token: 0x0601A385 RID: 107397 RVA: 0x0081C72B File Offset: 0x0081A92B
	// (set) Token: 0x0601A386 RID: 107398 RVA: 0x0081C734 File Offset: 0x0081A934
	public bool BackBrakingState
	{
		get
		{
			return this.BackBrakingStateInternal;
		}
		set
		{
			if (this.BackBrakingStateInternal == value)
			{
				return;
			}
			this.BackBrakingStateInternal = value;
			if (value)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent == null)
				{
					return;
				}
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.刹车.后轮刹"]));
				return;
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null)
				{
					return;
				}
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.刹车.后轮刹"]));
				return;
			}
		}
	}

	// Token: 0x17002ADA RID: 10970
	// (get) Token: 0x0601A387 RID: 107399 RVA: 0x0081C79F File Offset: 0x0081A99F
	// (set) Token: 0x0601A388 RID: 107400 RVA: 0x0081C7A8 File Offset: 0x0081A9A8
	protected bool SideSlide
	{
		get
		{
			return this.SideSlideInternal;
		}
		set
		{
			if (this.SideSlideInternal == value)
			{
				return;
			}
			this.SideSlideInternal = value;
			if (value)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent == null)
				{
					return;
				}
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.车身侧滑"]));
				return;
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null)
				{
					return;
				}
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.车身侧滑"]));
				return;
			}
		}
	}

	// Token: 0x17002ADB RID: 10971
	// (get) Token: 0x0601A389 RID: 107401 RVA: 0x0081C813 File Offset: 0x0081AA13
	// (set) Token: 0x0601A38A RID: 107402 RVA: 0x0081C81C File Offset: 0x0081AA1C
	public EMotorSubState MotorSubState
	{
		get
		{
			return this.MotorSubStateInternal;
		}
		protected set
		{
			if (this.MotorSubStateInternal == value)
			{
				return;
			}
			if (this.TagComponent != null)
			{
				int num = MotorcycleMoveComponent.motorSubStateTagMap.ContainsKey(this.MotorSubStateInternal) ? MotorcycleMoveComponent.motorSubStateTagMap[this.MotorSubStateInternal] : 0;
				int num2 = MotorcycleMoveComponent.motorSubStateTagMap.ContainsKey(value) ? MotorcycleMoveComponent.motorSubStateTagMap[value] : GameplayTagDefine.EGameplayTagId["载具.摩托.状态.其他移动状态"];
				if (num != num2)
				{
					this.TagComponent.RemoveTag(new int?(num));
					this.TagComponent.AddTag(new int?(num2));
				}
			}
			EventSystem.Instance.EmitWithTarget<EMotorSubState, EMotorSubState>(base.Entity, EEventName.MotorSubStateModeChange, value, this.MotorSubStateInternal);
			this.MotorSubStateInternal = value;
			this.CheckAllowSoar();
		}
	}

	// Token: 0x17002ADC RID: 10972
	// (get) Token: 0x0601A38B RID: 107403 RVA: 0x0081C8DC File Offset: 0x0081AADC
	// (set) Token: 0x0601A38C RID: 107404 RVA: 0x0081C8E4 File Offset: 0x0081AAE4
	public bool AllowSoar
	{
		get
		{
			return this.AllowSoarInternal;
		}
		protected set
		{
			if (this.AllowSoarInternal == value)
			{
				return;
			}
			this.AllowSoarInternal = value;
			if (value)
			{
				BaseTagComponent tagComponent = this.TagComponent;
				if (tagComponent == null)
				{
					return;
				}
				tagComponent.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.滑翔高度足够"]));
				return;
			}
			else
			{
				BaseTagComponent tagComponent2 = this.TagComponent;
				if (tagComponent2 == null)
				{
					return;
				}
				tagComponent2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.滑翔高度足够"]));
				return;
			}
		}
	}

	// Token: 0x17002ADD RID: 10973
	// (get) Token: 0x0601A38D RID: 107405 RVA: 0x0081C94F File Offset: 0x0081AB4F
	// (set) Token: 0x0601A38E RID: 107406 RVA: 0x0081C958 File Offset: 0x0081AB58
	private bool BackingMotor
	{
		get
		{
			return this.BackingMotorInternal;
		}
		set
		{
			if (this.BackingMotorInternal == value)
			{
				return;
			}
			this.BackingMotorInternal = value;
			if (this.BackMotorBuff > 0L)
			{
				if (this.BackingMotorInternal)
				{
					VehicleBuffComponent buffComp = this.BuffComp;
					if (buffComp == null)
					{
						return;
					}
					buffComp.AddBuff(this.BackMotorBuff, new AddBuffParam
					{
						InstigatorId = this.BuffComp.CreatureDataId,
						Reason = "倒车buff"
					});
					return;
				}
				else
				{
					VehicleBuffComponent buffComp2 = this.BuffComp;
					if (buffComp2 == null)
					{
						return;
					}
					buffComp2.RemoveBuff(this.BackMotorBuff, -1, "倒车buff", null, null, null);
				}
			}
		}
	}

	// Token: 0x17002ADE RID: 10974
	// (get) Token: 0x0601A38F RID: 107407 RVA: 0x0081C9F7 File Offset: 0x0081ABF7
	// (set) Token: 0x0601A390 RID: 107408 RVA: 0x0081CA00 File Offset: 0x0081AC00
	protected long CurrentMoveBuff
	{
		get
		{
			return this.CurrentMoveBuffInternal;
		}
		set
		{
			if (this.CurrentMoveBuffInternal == value)
			{
				return;
			}
			if (this.CurrentMoveBuffInternal > 0L)
			{
				VehicleBuffComponent buffComp = this.BuffComp;
				if (buffComp != null)
				{
					buffComp.RemoveBuff(this.CurrentMoveBuffInternal, -1, "摩托移动buff", null, null, null);
				}
				Log instance = Log.Instance;
				ELogModule module = ELogModule.Test;
				ELogAuthor author = ELogAuthor.LCZ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(25, 1);
				defaultInterpolatedStringHandler.AppendLiteral("MotorMoveBuff RemoveBuff ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.CurrentMoveBuffInternal);
				instance.Warn(module, author, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			this.CurrentMoveBuffInternal = value;
			if (this.CurrentMoveBuffInternal > 0L)
			{
				VehicleBuffComponent buffComp2 = this.BuffComp;
				if (buffComp2 != null)
				{
					buffComp2.AddBuff(this.CurrentMoveBuffInternal, new AddBuffParam
					{
						InstigatorId = this.BuffComp.CreatureDataId,
						Reason = "摩托移动buff"
					});
				}
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.Test;
				ELogAuthor author2 = ELogAuthor.LCZ;
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(22, 1);
				defaultInterpolatedStringHandler.AppendLiteral("MotorMoveBuff AddBuff ");
				defaultInterpolatedStringHandler.AppendFormatted<long>(this.CurrentMoveBuffInternal);
				instance2.Warn(module2, author2, defaultInterpolatedStringHandler.ToStringAndClear(), default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
	}

	// Token: 0x0601A391 RID: 107409 RVA: 0x0081CB22 File Offset: 0x0081AD22
	public void SetIsFunctionOpenOverride(bool? @override)
	{
		this.IsFunctionOpenOverride = @override;
	}

	// Token: 0x0601A392 RID: 107410 RVA: 0x0081CB2B File Offset: 0x0081AD2B
	private bool IsSoarFunctionOpen()
	{
		if (this.IsFunctionOpenOverride != null)
		{
			return this.IsFunctionOpenOverride.Value;
		}
		return FunctionModel.Instance.IsOpen(EFunctionType.MotorSoar) && !FunctionModel.Instance.IsLimit(10154);
	}

	// Token: 0x0601A393 RID: 107411 RVA: 0x0081CB6C File Offset: 0x0081AD6C
	public void OnSkill(int skillId, bool _)
	{
		VehicleActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsAutonomousProxy)
		{
			return;
		}
		MotorSkillLogEvent motorSkillLogEvent = new MotorSkillLogEvent();
		motorSkillLogEvent.i_skill_id = skillId.ToString();
		LogReportController.Instance.LogReport(motorSkillLogEvent);
	}

	// Token: 0x0601A394 RID: 107412 RVA: 0x0081CBAF File Offset: 0x0081ADAF
	protected override void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (!byChangeRole)
		{
			this.SetMotorSubState(EMotorSubState.TwoWheelMoving, ESetMotorSubStateSource.LeaveVehicle);
		}
		base.OnLeaveVehicle(info, byChangeRole);
	}

	// Token: 0x0601A395 RID: 107413 RVA: 0x0081CBC4 File Offset: 0x0081ADC4
	public void OnSprintTagChange(int tagId, bool tagExist)
	{
		if (!tagExist)
		{
			this.DisableSprintTagFrame = Time.Instance.Frame;
			return;
		}
		if (this.DisableSprintTagFrame + 1 >= Time.Instance.Frame)
		{
			return;
		}
		this.DisableSprintTagFrame = Time.Instance.Frame;
		BaseVehiclePerformComponent performComp = this.PerformComp;
		bool flag;
		if (performComp == null)
		{
			flag = false;
		}
		else
		{
			Entity driver = performComp.Driver;
			bool? flag2;
			if (driver == null)
			{
				flag2 = null;
			}
			else
			{
				CharacterActorComponent component = driver.GetComponent<CharacterActorComponent>();
				flag2 = ((component != null) ? new bool?(component.IsRoleAndCtrlByMe) : null);
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (flag)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.第一人称"]))
			{
				CameraController.Instance.PlayCameraShake(this.SprintCameraShake, null, null, null, true, false, "MainCamera");
				return;
			}
			CameraController.Instance.PlayForceFeedbackFromCameraShake(new TSubclassOf<UCameraShakeBase>?(this.SprintCameraShake), "MainCamera");
		}
	}

	// Token: 0x0601A396 RID: 107414 RVA: 0x0081CCCC File Offset: 0x0081AECC
	[NullableContext(2)]
	private void OnVehicleDriverChange(Entity oldDriver, Entity newDriver)
	{
		if (newDriver != null)
		{
			CharacterActorComponent component = newDriver.GetComponent<CharacterActorComponent>();
			if (((component != null) ? new bool?(component.IsRoleAndCtrlByMe) : null).GetValueOrDefault())
			{
				this.DriftModel = (EMotorDriftModel)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.MotorDriftModel, 0, true);
				if (!EventSystem.Instance.Has<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting)))
				{
					EventSystem.Instance.Add<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
					return;
				}
				return;
			}
		}
		if (EventSystem.Instance.Has<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting)))
		{
			EventSystem.Instance.Remove<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
		}
		this.DriftModel = EMotorDriftModel.None;
	}

	// Token: 0x0601A397 RID: 107415 RVA: 0x0081CD96 File Offset: 0x0081AF96
	private void OnRefreshMenuSetting(EFunction functionId)
	{
		if (functionId == EFunction.MotorDriftModel)
		{
			this.DriftModel = (EMotorDriftModel)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.MotorDriftModel, 0, true);
		}
	}

	// Token: 0x0601A398 RID: 107416 RVA: 0x0081CDB8 File Offset: 0x0081AFB8
	protected override bool OnStart()
	{
		bool flag = base.OnStart();
		this.BuffComp = base.Entity.GetComponent<VehicleBuffComponent>();
		UKuroVehicleMovementComponent vehicleMovement = this.VehicleMovement;
		if (vehicleMovement != null)
		{
			vehicleMovement.ResetMotorcycle();
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Movement;
		ELogAuthor author = ELogAuthor.LCZ;
		string message = "Motorcycle Move OnStart";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Result", flag);
		instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		this.MotorSubState = EMotorSubState.AirMoving;
		this.PerformComp = base.Entity.GetComponent<BaseVehiclePerformComponent>();
		BaseVehiclePerformComponent performComp = this.PerformComp;
		object obj;
		if (performComp == null)
		{
			obj = null;
		}
		else
		{
			VehicleConfig config = performComp.Config;
			obj = ((config != null) ? config.Asset : null);
		}
		BP_MotorConfig_C bp_MotorConfig_C = obj as BP_MotorConfig_C;
		if (bp_MotorConfig_C == null)
		{
			return flag;
		}
		long num = (long)bp_MotorConfig_C.非加速状态buff.Num();
		this.SpeedBuffNotSprint.Clear();
		int num2 = 0;
		while ((long)num2 < num)
		{
			SFloatThresholdAndBuff sfloatThresholdAndBuff = bp_MotorConfig_C.非加速状态buff.Get(num2);
			this.SpeedBuffNotSprint.Add(new ValueTuple<float, long>(sfloatThresholdAndBuff.Threshold, sfloatThresholdAndBuff.BuffId));
			num2++;
		}
		num = (long)bp_MotorConfig_C.加速状态buff.Num();
		this.SpeedBuffSprint.Clear();
		int num3 = 0;
		while ((long)num3 < num)
		{
			SFloatThresholdAndBuff sfloatThresholdAndBuff2 = bp_MotorConfig_C.加速状态buff.Get(num3);
			this.SpeedBuffSprint.Add(new ValueTuple<float, long>(sfloatThresholdAndBuff2.Threshold, sfloatThresholdAndBuff2.BuffId));
			num3++;
		}
		num = (long)bp_MotorConfig_C.翱翔加速状态buff.Num();
		this.SpeedBuffSoarSprint.Clear();
		int num4 = 0;
		while ((long)num4 < num)
		{
			SFloatThresholdAndBuff sfloatThresholdAndBuff3 = bp_MotorConfig_C.翱翔加速状态buff.Get(num4);
			this.SpeedBuffSoarSprint.Add(new ValueTuple<float, long>(sfloatThresholdAndBuff3.Threshold, sfloatThresholdAndBuff3.BuffId));
			num4++;
		}
		this.DriftBuffId = bp_MotorConfig_C.漂移buff;
		this.BackMotorBuff = bp_MotorConfig_C.倒车buff;
		this.SprintCameraShake = bp_MotorConfig_C.冲刺震屏.Get().ToWeakClass();
		this.InitSeatTrans();
		EventSystem.Instance.AddWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnSkill));
		EventSystem.Instance.AddWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		if (this.SprintCameraShake != null)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTagChange), null);
			}
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.AddTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTagChange), null);
			}
		}
		return flag;
	}

	// Token: 0x0601A399 RID: 107417 RVA: 0x0081D040 File Offset: 0x0081B240
	protected override bool OnEnd()
	{
		bool result = base.OnEnd();
		EventSystem.Instance.RemoveWithTarget<int, bool>(base.Entity, EEventName.CharBeforeSkillWithTarget, new Action<int, bool>(this.OnSkill));
		EventSystem.Instance.RemoveWithTarget<Entity, Entity>(base.Entity, EEventName.OnVehicleDriverChange, new Action<Entity, Entity>(this.OnVehicleDriverChange));
		if (EventSystem.Instance.Has<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting)))
		{
			EventSystem.Instance.Remove<EFunction>(EEventName.RefreshMenuSetting, new Action<EFunction>(this.OnRefreshMenuSetting));
		}
		if (this.SprintCameraShake != null)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent != null)
			{
				tagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTagChange));
			}
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null)
			{
				tagComponent2.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"], new BaseTagComponent.TTagSwitchedCallback(this.OnSprintTagChange));
			}
		}
		this.ClearAllCacheData();
		return result;
	}

	// Token: 0x0601A39A RID: 107418 RVA: 0x0081D133 File Offset: 0x0081B333
	protected override void OnDisable(string reason)
	{
		base.OnDisable(reason);
		this.ClearAllCacheData();
	}

	// Token: 0x0601A39B RID: 107419 RVA: 0x0081D144 File Offset: 0x0081B344
	private void ClearAllCacheData()
	{
		this.BackingMotor = false;
		this.DriftingState = false;
		this.CurrentMoveBuff = 0L;
		if (this.CurrentBaseMovement.Count > 0)
		{
			this.CurrentBaseMovement.Clear();
			EventSystem.Instance.EmitWithTarget<IReadOnlySet<UPrimitiveComponent>>(base.Entity, EEventName.MotorcycleBaseMovementChanged, this.CurrentBaseMovement);
		}
	}

	// Token: 0x0601A39C RID: 107420 RVA: 0x0081D19C File Offset: 0x0081B39C
	protected override void SetInputOrder()
	{
		VehicleActorComponent actorComp = this.ActorComp;
		UKuroVehicleMovementComponent ukuroVehicleMovementComponent = (actorComp != null) ? actorComp.Actor.VehicleMovementComponent : null;
		if (ukuroVehicleMovementComponent == null)
		{
			return;
		}
		this.TmpInputDirect.DeepCopy(this.ActorComp.InputDirectProxy);
		double num = 0.0;
		double num2 = this.BackBraking > false;
		BaseTagComponent tagComponent = this.TagComponent;
		if (tagComponent != null && tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺"]))
		{
			this.TmpInputDirect.X = 1.0;
		}
		if (this.MotorSubState == EMotorSubState.Soaring)
		{
			num = 0.0;
			num2 = 0.0;
		}
		else
		{
			if (this.TmpInputDirect.X < 0.0 && !this.BackingMotor)
			{
				num = -this.TmpInputDirect.X;
				this.TmpInputDirect.X = 0.0;
			}
			BaseTagComponent tagComponent2 = this.TagComponent;
			if (tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.强制刹停"]))
			{
				this.TmpInputDirect.X = 0.0;
				num = 1.0;
				num2 = 1.0;
			}
		}
		if (num < 0.99 || num2 < 0.99)
		{
			BaseTagComponent tagComponent3 = this.TagComponent;
			if (tagComponent3 == null || !tagComponent3.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用转向"]))
			{
				goto IL_179;
			}
		}
		this.TmpInputDirect.Y = 0.0;
		IL_179:
		ukuroVehicleMovementComponent.SetMotorInput(this.TmpInputDirect.ToUeVectorOld(), (float)num, (float)num2, new FVector?((this.ActorComp as MotorcycleActorComponent).AirRotateInputProxy.ToUeVectorOld()));
	}

	// Token: 0x0601A39D RID: 107421 RVA: 0x0081D354 File Offset: 0x0081B554
	protected override void OnTick(float delta)
	{
		VehicleActorComponent actorComp = this.ActorComp;
		if (actorComp == null || !actorComp.IsMoveAutonomousProxy)
		{
			return;
		}
		this.TmpInputDirect.DeepCopy(this.ActorComp.InputDirectProxy);
		if (this.TmpInputDirect.X >= 0.0)
		{
			this.BackInputTime = 0.0;
			this.BackingMotor = false;
		}
		else if (this.BackBraking)
		{
			this.BackInputTime = 0.0;
			this.BackingMotor = false;
		}
		else if (this.BackInputTime < 100.0)
		{
			double num = this.ActorComp.ActorVelocityProxy.DotProduct(this.ActorComp.ActorForwardProxy);
			if (Math.Abs(this.ActorComp.ActorVelocityProxy.DotProduct(this.ActorComp.ActorRightProxy)) > 500.0 || num > 200.0)
			{
				this.BackInputTime = 0.0;
			}
			else
			{
				this.BackInputTime += (double)((long)Time.Instance.DeltaTime);
			}
			this.BackingMotor = (this.BackInputTime >= 100.0);
		}
		else
		{
			this.BackingMotor = true;
		}
		base.OnTick(delta);
		this.UpdateMoveState();
		this.UpdateMoveBuff();
		this.UpdateBaseMovement();
		this.CheckAllowSoar();
	}

	// Token: 0x0601A39E RID: 107422 RVA: 0x0081D4BC File Offset: 0x0081B6BC
	public override void MoveAlongPath(IMoveVehicleConfig config)
	{
		MotorcyclePathMoveTask mainTask = VehiclePathMoveController.Instance.CreateMotorcycleMoveTaskFromSplineId(base.Entity, config.SplineId);
		MotorcyclePathMoveTask mainTask2 = mainTask;
		if (mainTask2 == null || !mainTask2.IsValid())
		{
			return;
		}
		if (config.ForceToFirstPoint.GetValueOrDefault())
		{
			mainTask.NeedSync = config.NeedSync.GetValueOrDefault(true);
			mainTask.SimulateRotation = config.SimulateRotation.GetValueOrDefault(true);
			mainTask.KeepForward = config.KeepForward.GetValueOrDefault();
			mainTask.EnableDynamicGravity(config.DynamicGravity != null && config.DynamicGravity.Value);
			mainTask.OnMoveEndHandle = delegate(bool result)
			{
				if (config.OnMoveEndHandle != null)
				{
					config.OnMoveEndHandle(result);
				}
				this.DebugCurve = null;
			};
			VehiclePathMoveController.Instance.AddSplineMoveTask(mainTask);
			PathCurveInfo curveInfo = mainTask.CurveInfo;
			this.DebugCurve = ((curveInfo != null) ? curveInfo.SplineCurve : null);
			return;
		}
		int index = config.StartFromNearest.GetValueOrDefault() ? base.FindNearestNextPoint(mainTask.CurveInfo.SplineCurve) : 0;
		mainTask.JumpToPoint(index);
		mainTask.GetTransformAtSplineIndex(index, this.TmpTrans);
		IContinuesVariableSpeedMovementSpline splineConfig = mainTask.CurveInfo.SplineConfig;
		double speed = (double)((splineConfig != null && splineConfig.TransitionSpeed != null) ? ((float)mainTask.CurveInfo.SplineConfig.TransitionSpeed.Value) : (mainTask.CurveInfo.SplineCurve.GetSplineLength() / mainTask.CurveInfo.TotalTime));
		VehiclePathMoveTask vehiclePathMoveTask = VehiclePathMoveController.Instance.CreateMotorcycleMoveToTask(base.Entity, this.TmpTrans, speed);
		if (vehiclePathMoveTask == null || !vehiclePathMoveTask.IsValid())
		{
			VehiclePathMoveController.Instance.AddSplineMoveTask(mainTask);
			PathCurveInfo curveInfo2 = mainTask.CurveInfo;
			this.DebugCurve = ((curveInfo2 != null) ? curveInfo2.SplineCurve : null);
			return;
		}
		vehiclePathMoveTask.CurveInfo.SplineId = -config.SplineId;
		vehiclePathMoveTask.NeedSync = config.NeedSync.GetValueOrDefault(true);
		vehiclePathMoveTask.SimulateRotation = false;
		vehiclePathMoveTask.KeepForward = config.KeepForward.GetValueOrDefault();
		vehiclePathMoveTask.OnMoveEndHandle = delegate(bool result)
		{
			if (!result)
			{
				if (config.OnMoveEndHandle != null)
				{
					config.OnMoveEndHandle(false);
				}
				return;
			}
			VehiclePathMoveController.Instance.AddSplineMoveTask(mainTask);
			VehicleMoveComponent <>4__this = this;
			PathCurveInfo curveInfo4 = mainTask.CurveInfo;
			<>4__this.DebugCurve = ((curveInfo4 != null) ? curveInfo4.SplineCurve : null);
			if (config.OnArriveStartPointHandle != null)
			{
				config.OnArriveStartPointHandle(result);
			}
		};
		mainTask.NeedSync = config.NeedSync.GetValueOrDefault(true);
		mainTask.SimulateRotation = config.SimulateRotation.GetValueOrDefault(true);
		mainTask.KeepForward = config.KeepForward.GetValueOrDefault();
		mainTask.EnableDynamicGravity(config.DynamicGravity != null && config.DynamicGravity.Value);
		mainTask.OnMoveEndHandle = delegate(bool result)
		{
			if (config.OnMoveEndHandle != null)
			{
				config.OnMoveEndHandle(result);
			}
			this.DebugCurve = null;
		};
		VehiclePathMoveController.Instance.AddSplineMoveTask(vehiclePathMoveTask);
		PathCurveInfo curveInfo3 = vehiclePathMoveTask.CurveInfo;
		this.DebugCurve = ((curveInfo3 != null) ? curveInfo3.SplineCurve : null);
	}

	// Token: 0x0601A39F RID: 107423 RVA: 0x0081D820 File Offset: 0x0081BA20
	protected void UpdateMoveBuff()
	{
		double num = (double)this.VehicleMovement.MotorAccelConfig.MaxSpeed;
		double num2 = this.ActorComp.ActorVelocityProxy.DotProduct(this.ActorComp.ActorForwardProxy) / num;
		BaseTagComponent tagComponent = this.TagComponent;
		List<ValueTuple<float, long>> list;
		if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺"]))
		{
			BaseTagComponent tagComponent2 = this.TagComponent;
			list = ((tagComponent2 != null && tagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺"])) ? this.SpeedBuffSoarSprint : this.SpeedBuffNotSprint);
		}
		else
		{
			list = this.SpeedBuffSprint;
		}
		bool flag = false;
		foreach (ValueTuple<float, long> valueTuple in list)
		{
			float item = valueTuple.Item1;
			long item2 = valueTuple.Item2;
			if (num2 < (double)item)
			{
				this.CurrentMoveBuff = item2;
				flag = true;
				break;
			}
		}
		if (!flag)
		{
			this.CurrentMoveBuff = 0L;
		}
	}

	// Token: 0x0601A3A0 RID: 107424 RVA: 0x0081D920 File Offset: 0x0081BB20
	private void UpdateMoveState()
	{
		this.MotorSubState = this.VehicleMovement.MotorSubState;
		this.DriftingState = (this.BackBraking && this.ActorComp.InputDirectProxy.X > -1E-08 && Math.Abs(this.ActorComp.InputDirectProxy.Y) > 0.5 && (double)this.Speed > 500.0 && this.MotorSubState == EMotorSubState.TwoWheelMoving);
		if (this.DriftingState)
		{
			this.DriftDistance += global::Vector.Dist(this.ActorComp.ActorLocationProxy, this.DriftLastLocation);
			this.DriftLastLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		double num = this.ActorComp.ActorVelocityProxy.DotProduct(this.ActorComp.ActorForwardProxy);
		if (!this.DriftingState && num >= 200.0)
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if ((tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.强制刹停"])) && (this.MotorSubState == EMotorSubState.TwoWheelMoving || this.MotorSubState == EMotorSubState.OneWheelMoving))
			{
				this.FrontBrakingState = (!this.BackingMotor && this.ActorComp.InputDirectProxy.X < 0.0);
				this.BackBrakingState = this.BackBraking;
				goto IL_166;
			}
		}
		this.FrontBrakingState = false;
		this.BackBrakingState = false;
		IL_166:
		double value = 0.0;
		if (this.MotorSubState == EMotorSubState.TwoWheelMoving)
		{
			value = this.ActorComp.ActorRightProxy.DotProduct(this.ActorComp.ActorVelocityProxy);
		}
		this.SideSlide = (Math.Abs(value) > 200.0);
	}

	// Token: 0x0601A3A1 RID: 107425 RVA: 0x0081DADC File Offset: 0x0081BCDC
	private void UpdateBaseMovement()
	{
		UKuroVehicleMovementComponent vehicleMovement = this.VehicleMovement;
		if (vehicleMovement != null)
		{
			vehicleMovement.GetBaseMovement(ref this.BaseMovementArray);
		}
		TArray<UPrimitiveComponent> baseMovementArray = this.BaseMovementArray;
		int num = baseMovementArray.Num();
		bool flag = true;
		this.NextBaseMovement.Clear();
		for (long num2 = 0L; num2 < (long)num; num2 += 1L)
		{
			UPrimitiveComponent item = baseMovementArray.Get((int)num2);
			this.NextBaseMovement.Add(item);
			flag = (flag && this.CurrentBaseMovement.Contains(item));
		}
		if (!flag || this.CurrentBaseMovement.Count != this.NextBaseMovement.Count)
		{
			HashSet<UPrimitiveComponent> nextBaseMovement = this.NextBaseMovement;
			HashSet<UPrimitiveComponent> currentBaseMovement = this.CurrentBaseMovement;
			this.CurrentBaseMovement = nextBaseMovement;
			this.NextBaseMovement = currentBaseMovement;
			this.NextBaseMovement.Clear();
			EventSystem.Instance.EmitWithTarget<IReadOnlySet<UPrimitiveComponent>>(base.Entity, EEventName.MotorcycleBaseMovementChanged, this.CurrentBaseMovement);
		}
	}

	// Token: 0x0601A3A2 RID: 107426 RVA: 0x0081DBC0 File Offset: 0x0081BDC0
	private void InitSeatTrans()
	{
		IReadOnlyList<float> floatArrayConfig = ConfigCommonParamById.GetFloatArrayConfig("MotorGetOnSeatTrans");
		if (floatArrayConfig != null && floatArrayConfig.Count >= 9)
		{
			global::Vector location = global::Vector.Create((double)floatArrayConfig[0], (double)floatArrayConfig[1], (double)floatArrayConfig[2]);
			Rotator rotator = Rotator.Create(floatArrayConfig[3], floatArrayConfig[4], floatArrayConfig[5]);
			global::Vector scale3D = global::Vector.Create((double)floatArrayConfig[6], (double)floatArrayConfig[7], (double)floatArrayConfig[8]);
			this.DefaultSeatTrans.SetLocation(location);
			this.DefaultSeatTrans.SetRotation(rotator.Quaternion(null));
			this.DefaultSeatTrans.SetScale3D(scale3D);
		}
	}

	// Token: 0x0601A3A3 RID: 107427 RVA: 0x0081DC6C File Offset: 0x0081BE6C
	[NullableContext(2)]
	public unsafe Transform GetMotorcycleSummonTrans(int entityId, FTransform? trans = null)
	{
		CharacterActorComponent component = EntitySystem.Instance.GetComponent<CharacterActorComponent>(entityId);
		if (component == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Vehicle;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SummonAndRideMotorcycle Error. No ActorComp.";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ActorEntityId", entityId);
			instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		FTransform ftransform = trans ?? this.DefaultSeatTrans.ToUeTransformOld();
		MotorcycleMoveComponent.tmpTrans.FromUeTransform(ftransform);
		MotorcycleMoveComponent.leftTurn90.Multiply(MotorcycleMoveComponent.tmpTrans.GetRotation(), MotorcycleMoveComponent.tmpQuat2);
		MotorcycleMoveComponent.tmpQuat2.Inverse(MotorcycleMoveComponent.tmpQuat);
		component.ActorQuatProxy.Multiply(MotorcycleMoveComponent.tmpQuat, MotorcycleMoveComponent.tmpQuat2);
		MotorcycleMoveComponent.tmpTrans.SetRotation(MotorcycleMoveComponent.tmpQuat2);
		MotorcycleMoveComponent.leftTurn90.RotateVector(MotorcycleMoveComponent.tmpTrans.GetLocation(), MotorcycleMoveComponent.tmpVector);
		MotorcycleMoveComponent.tmpVector.Z += (double)(component.HalfHeight - 45f);
		MotorcycleMoveComponent.tmpQuat2.RotateVector(MotorcycleMoveComponent.tmpVector, MotorcycleMoveComponent.tmpVector);
		component.ActorLocationProxy.Subtraction(MotorcycleMoveComponent.tmpVector, MotorcycleMoveComponent.tmpVector);
		MotorcycleMoveComponent.tmpTrans.SetLocation(MotorcycleMoveComponent.tmpVector);
		UTraceSphereElement actorTrace = TraceElementModel.Instance.GetActorTrace();
		UTraceBaseElement utraceBaseElement = actorTrace;
		UKuroVehicleMovementComponent vehicleMovement = this.VehicleMovement;
		utraceBaseElement.WorldContextObject = ((vehicleMovement != null) ? vehicleMovement.GetOwner() : null);
		actorTrace.Radius = 5f;
		TraceElementCommon.Instance.SetStartLocation(actorTrace, component.ActorLocationProxy);
		TraceElementCommon.Instance.SetEndLocation(actorTrace, MotorcycleMoveComponent.tmpVector);
		if (TraceElementCommon.Instance.ShapeTrace(component.Actor.CapsuleComponent, actorTrace, "SummonAndRideMotorcycle", "SummonAndRideMotorcycle"))
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Vehicle;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "SummonAndRideMotorcycle  Error. Block.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", component.Actor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("tmpTrans", MotorcycleMoveComponent.tmpTrans);
			instance2.Warn(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		UKuroVehicleMovementComponent vehicleMovement2 = this.VehicleMovement;
		bool? flag = (vehicleMovement2 != null) ? new bool?(vehicleMovement2.IsValidTransform(MotorcycleMoveComponent.tmpTrans.ToUeTransform(), null)) : null;
		if (flag == null || !flag.Value)
		{
			Log instance3 = Log.Instance;
			ELogModule module3 = ELogModule.Vehicle;
			ELogAuthor author3 = ELogAuthor.LCZ;
			string message3 = "SummonAndRideMotorcycle Error. Not ValidTrans.";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", component.Actor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("tmpTrans", MotorcycleMoveComponent.tmpTrans);
			instance3.Warn(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
			return null;
		}
		return MotorcycleMoveComponent.tmpTrans;
	}

	// Token: 0x0601A3A4 RID: 107428 RVA: 0x0081DF1F File Offset: 0x0081C11F
	protected override void UpdateUeMovementDisableState(float delta)
	{
		if (this.CurrentBaseMovement.Count > 0)
		{
			this.StopMoveContinuousTime = 0f;
			base.EnableUeMovementTick("CurrentBaseMovement不为空");
			return;
		}
		base.UpdateUeMovementDisableState(delta);
	}

	// Token: 0x0601A3A5 RID: 107429 RVA: 0x0081DF50 File Offset: 0x0081C150
	protected void CheckAllowSoar()
	{
		if (this.MotorSubState == EMotorSubState.Soaring)
		{
			this.AllowSoar = true;
			return;
		}
		if (this.IsSoarFunctionOpen())
		{
			BaseTagComponent tagComponent = this.TagComponent;
			if (tagComponent == null || !tagComponent.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用翱翔"]))
			{
				if (this.MotorSubState != EMotorSubState.AirMoving)
				{
					this.AllowSoar = false;
					return;
				}
				if (Time.Instance.Now < this.NextCheckAllowTime)
				{
					this.LastCheckAllowHeightPosition.Subtraction(this.ActorComp.ActorLocationProxy, this.TmpVector);
					if (GravityUtils.Instance.GetZnInGravityForActor(this.ActorComp, this.TmpVector) < 100.0)
					{
						return;
					}
				}
				this.NextCheckAllowTime = Time.Instance.Now + 200.0;
				this.LastCheckAllowHeightPosition.DeepCopy(this.ActorComp.ActorLocationProxy);
				this.AllowSoar = (base.GetHeightAboveGround(900f) > 800f);
				return;
			}
		}
		this.AllowSoar = false;
	}

	// Token: 0x0601A3A6 RID: 107430 RVA: 0x0081E04B File Offset: 0x0081C24B
	public override void SetMotorSubState(EMotorSubState subState, ESetMotorSubStateSource source)
	{
		base.SetMotorSubState(subState, source);
		this.MotorSubState = this.VehicleMovement.MotorSubState;
	}

	// Token: 0x0601A3A7 RID: 107431 RVA: 0x0081E068 File Offset: 0x0081C268
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleMoveComponent motorcycleMoveComponent = (MotorcycleMoveComponent)componentTemplate;
		if (motorcycleMoveComponent.BuffComp == null)
		{
			this.BuffComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BuffComp), "BuffComp"))
		{
			return false;
		}
		if (motorcycleMoveComponent.PerformComp == null)
		{
			this.PerformComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PerformComp), "PerformComp"))
		{
			return false;
		}
		if (motorcycleMoveComponent.TmpInputDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpInputDirect), "TmpInputDirect"))
		{
			return false;
		}
		if (motorcycleMoveComponent.DefaultSeatTrans != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultSeatTrans), "DefaultSeatTrans"))
		{
			return false;
		}
		if (motorcycleMoveComponent.BaseMovementArray == null)
		{
			this.BaseMovementArray = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.BaseMovementArray), "BaseMovementArray"))
		{
			return false;
		}
		if (motorcycleMoveComponent.CurrentBaseMovement == null)
		{
			this.CurrentBaseMovement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.CurrentBaseMovement), "CurrentBaseMovement"))
		{
			return false;
		}
		if (motorcycleMoveComponent.NextBaseMovement == null)
		{
			this.NextBaseMovement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.NextBaseMovement), "NextBaseMovement"))
		{
			return false;
		}
		this.DriftModelInternal = motorcycleMoveComponent.DriftModelInternal;
		this.BackInputTime = motorcycleMoveComponent.BackInputTime;
		this.BackBrakingInternal = motorcycleMoveComponent.BackBrakingInternal;
		this.DriftingStateInternal = motorcycleMoveComponent.DriftingStateInternal;
		this.DriftDistance = motorcycleMoveComponent.DriftDistance;
		this.DriftStartTime = motorcycleMoveComponent.DriftStartTime;
		if (motorcycleMoveComponent.DriftLastLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.DriftLastLocation), "DriftLastLocation"))
		{
			return false;
		}
		this.FrontBrakingStateInternal = motorcycleMoveComponent.FrontBrakingStateInternal;
		this.BackBrakingStateInternal = motorcycleMoveComponent.BackBrakingStateInternal;
		this.SideSlideInternal = motorcycleMoveComponent.SideSlideInternal;
		this.MotorSubStateInternal = motorcycleMoveComponent.MotorSubStateInternal;
		this.NextCheckAllowTime = motorcycleMoveComponent.NextCheckAllowTime;
		if (motorcycleMoveComponent.LastCheckAllowHeightPosition != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastCheckAllowHeightPosition), "LastCheckAllowHeightPosition"))
		{
			return false;
		}
		this.AllowSoarInternal = motorcycleMoveComponent.AllowSoarInternal;
		this.DriftBuffId = motorcycleMoveComponent.DriftBuffId;
		this.BackMotorBuff = motorcycleMoveComponent.BackMotorBuff;
		this.BackingMotorInternal = motorcycleMoveComponent.BackingMotorInternal;
		if (motorcycleMoveComponent.SpeedBuffNotSprint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpeedBuffNotSprint), "SpeedBuffNotSprint"))
		{
			return false;
		}
		if (motorcycleMoveComponent.SpeedBuffSprint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpeedBuffSprint), "SpeedBuffSprint"))
		{
			return false;
		}
		if (motorcycleMoveComponent.SpeedBuffSoarSprint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.SpeedBuffSoarSprint), "SpeedBuffSoarSprint"))
		{
			return false;
		}
		this.CurrentMoveBuffInternal = motorcycleMoveComponent.CurrentMoveBuffInternal;
		if (motorcycleMoveComponent.SprintCameraShake == null)
		{
			this.SprintCameraShake = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SprintCameraShake), "SprintCameraShake"))
		{
			return false;
		}
		this.IsFunctionOpenOverride = motorcycleMoveComponent.IsFunctionOpenOverride;
		this.DisableSprintTagFrame = motorcycleMoveComponent.DisableSprintTagFrame;
		return (motorcycleMoveComponent.Stat0 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Stat0), "Stat0")) && (motorcycleMoveComponent.Stat1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Stat1), "Stat1")) && (motorcycleMoveComponent.Stat2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Stat2), "Stat2")) && (motorcycleMoveComponent.Stat3 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Stat3), "Stat3")) && (motorcycleMoveComponent.Stat4 == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.Stat4), "Stat4"));
	}

	// Token: 0x17002ADF RID: 10975
	// (get) Token: 0x0601A3A8 RID: 107432 RVA: 0x0081E3FA File Offset: 0x0081C5FA
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE0 RID: 10976
	// (get) Token: 0x0601A3A9 RID: 107433 RVA: 0x0081E3FD File Offset: 0x0081C5FD
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE1 RID: 10977
	// (get) Token: 0x0601A3AA RID: 107434 RVA: 0x0081E400 File Offset: 0x0081C600
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE2 RID: 10978
	// (get) Token: 0x0601A3AB RID: 107435 RVA: 0x0081E403 File Offset: 0x0081C603
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE3 RID: 10979
	// (get) Token: 0x0601A3AC RID: 107436 RVA: 0x0081E406 File Offset: 0x0081C606
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AE4 RID: 10980
	// (get) Token: 0x0601A3AD RID: 107437 RVA: 0x0081E409 File Offset: 0x0081C609
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E619 RID: 58905
	private const float BRAKE_FORWARD_SPEED_THRESHOLD = 200f;

	// Token: 0x0400E61A RID: 58906
	private const float BRAKE_RIGHT_SPEED_THRESHOLD = 500f;

	// Token: 0x0400E61B RID: 58907
	private const float BACK_TIME_THRESHOLD = 100f;

	// Token: 0x0400E61C RID: 58908
	private const float SIDE_SLIDE_SPEED_THRESHOLD = 200f;

	// Token: 0x0400E61D RID: 58909
	private const double DRIFT_INPUT_X_THRESHOLD = -1E-08;

	// Token: 0x0400E61E RID: 58910
	private const double DRIFT_INPUT_Y_THRESHOLD = 0.5;

	// Token: 0x0400E61F RID: 58911
	private const double DRIFT_SPEED_THRESHOLD = 500.0;

	// Token: 0x0400E620 RID: 58912
	private const float CHECK_ALLOW_SOAR_PERIOD = 200f;

	// Token: 0x0400E621 RID: 58913
	private const float CHECK_ALLOW_SOAR_HEIGHT_THRESHOLD = 100f;

	// Token: 0x0400E622 RID: 58914
	private const float ALLOW_SOAR_HEIGHT = 800f;

	// Token: 0x0400E623 RID: 58915
	[StaticVariableRuleIgnore]
	private static readonly Transform tmpTrans = Transform.Create();

	// Token: 0x0400E624 RID: 58916
	[StaticVariableRuleIgnore]
	private static readonly Quat tmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E625 RID: 58917
	[StaticVariableRuleIgnore]
	private static readonly Quat tmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E626 RID: 58918
	[StaticVariableRuleIgnore]
	private static readonly global::Vector tmpVector = global::Vector.Create();

	// Token: 0x0400E627 RID: 58919
	[StaticVariableRuleIgnore]
	private static readonly Quat leftTurn90 = Rotator.Create(0f, -90f, 0f).Quaternion(null);

	// Token: 0x0400E628 RID: 58920
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EMotorDriftModel, int> driftModelTagMap = new Dictionary<EMotorDriftModel, int>
	{
		{
			EMotorDriftModel.KartingMode,
			GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.新版漂移"]
		}
	};

	// Token: 0x0400E629 RID: 58921
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EMotorSubState, int> motorSubStateTagMap = new Dictionary<EMotorSubState, int>
	{
		{
			EMotorSubState.Stop,
			GameplayTagDefine.EGameplayTagId["载具.摩托.状态.地面.待机状态"]
		},
		{
			EMotorSubState.OneWheelMoving,
			GameplayTagDefine.EGameplayTagId["载具.摩托.状态.地面.独轮"]
		},
		{
			EMotorSubState.TwoWheelMoving,
			GameplayTagDefine.EGameplayTagId["载具.摩托.状态.地面.双轮"]
		},
		{
			EMotorSubState.BrakingTurn,
			GameplayTagDefine.EGameplayTagId["载具.摩托.状态.地面.烧胎"]
		},
		{
			EMotorSubState.AirMoving,
			GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.普通"]
		},
		{
			EMotorSubState.Soaring,
			GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]
		}
	};

	// Token: 0x0400E62A RID: 58922
	[Nullable(2)]
	private VehicleBuffComponent BuffComp;

	// Token: 0x0400E62B RID: 58923
	[Nullable(2)]
	private BaseVehiclePerformComponent PerformComp;

	// Token: 0x0400E62C RID: 58924
	private readonly global::Vector TmpInputDirect = global::Vector.Create();

	// Token: 0x0400E62D RID: 58925
	private readonly Transform DefaultSeatTrans = Transform.Create();

	// Token: 0x0400E62E RID: 58926
	private TArray<UPrimitiveComponent> BaseMovementArray = new TArray<UPrimitiveComponent>();

	// Token: 0x0400E62F RID: 58927
	private HashSet<UPrimitiveComponent> CurrentBaseMovement = new HashSet<UPrimitiveComponent>();

	// Token: 0x0400E630 RID: 58928
	private HashSet<UPrimitiveComponent> NextBaseMovement = new HashSet<UPrimitiveComponent>();

	// Token: 0x0400E631 RID: 58929
	private EMotorDriftModel DriftModelInternal;

	// Token: 0x0400E632 RID: 58930
	private double BackInputTime;

	// Token: 0x0400E633 RID: 58931
	private bool BackBrakingInternal;

	// Token: 0x0400E634 RID: 58932
	private bool DriftingStateInternal;

	// Token: 0x0400E635 RID: 58933
	private double DriftDistance;

	// Token: 0x0400E636 RID: 58934
	private double DriftStartTime;

	// Token: 0x0400E637 RID: 58935
	private readonly global::Vector DriftLastLocation = global::Vector.Create();

	// Token: 0x0400E638 RID: 58936
	private bool FrontBrakingStateInternal;

	// Token: 0x0400E639 RID: 58937
	private bool BackBrakingStateInternal;

	// Token: 0x0400E63A RID: 58938
	private bool SideSlideInternal;

	// Token: 0x0400E63B RID: 58939
	private EMotorSubState MotorSubStateInternal = EMotorSubState.TwoWheelMoving;

	// Token: 0x0400E63C RID: 58940
	private double NextCheckAllowTime;

	// Token: 0x0400E63D RID: 58941
	private readonly global::Vector LastCheckAllowHeightPosition = global::Vector.Create();

	// Token: 0x0400E63E RID: 58942
	private bool AllowSoarInternal;

	// Token: 0x0400E63F RID: 58943
	private long DriftBuffId;

	// Token: 0x0400E640 RID: 58944
	private long BackMotorBuff;

	// Token: 0x0400E641 RID: 58945
	private bool BackingMotorInternal;

	// Token: 0x0400E642 RID: 58946
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<float, long>> SpeedBuffNotSprint = new List<ValueTuple<float, long>>();

	// Token: 0x0400E643 RID: 58947
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<float, long>> SpeedBuffSprint = new List<ValueTuple<float, long>>();

	// Token: 0x0400E644 RID: 58948
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<float, long>> SpeedBuffSoarSprint = new List<ValueTuple<float, long>>();

	// Token: 0x0400E645 RID: 58949
	private long CurrentMoveBuffInternal;

	// Token: 0x0400E646 RID: 58950
	[Nullable(2)]
	private UClass SprintCameraShake;

	// Token: 0x0400E647 RID: 58951
	private bool? IsFunctionOpenOverride;

	// Token: 0x0400E648 RID: 58952
	private int DisableSprintTagFrame;

	// Token: 0x0400E649 RID: 58953
	[StaticVariableRuleIgnore]
	private readonly Stat Stat0 = Stat.Create("BackingMotor", "", "");

	// Token: 0x0400E64A RID: 58954
	[StaticVariableRuleIgnore]
	private readonly Stat Stat1 = Stat.Create("super.OnTick", "", "");

	// Token: 0x0400E64B RID: 58955
	[StaticVariableRuleIgnore]
	private readonly Stat Stat2 = Stat.Create("UpdateMoveState", "", "");

	// Token: 0x0400E64C RID: 58956
	[StaticVariableRuleIgnore]
	private readonly Stat Stat3 = Stat.Create("UpdateMoveBuff", "", "");

	// Token: 0x0400E64D RID: 58957
	[StaticVariableRuleIgnore]
	private readonly Stat Stat4 = Stat.Create("UpdateBaseMovement", "", "");
}
