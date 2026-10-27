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

// Token: 0x020032FA RID: 13050
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleMoveComponent : VehicleMoveComponent
{
	// Token: 0x1700274F RID: 10063
	// (get) Token: 0x0601C6A3 RID: 116387 RVA: 0x007F60C9 File Offset: 0x007F42C9
	// (set) Token: 0x0601C6A4 RID: 116388 RVA: 0x007F60D4 File Offset: 0x007F42D4
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

	// Token: 0x17002750 RID: 10064
	// (get) Token: 0x0601C6A5 RID: 116389 RVA: 0x007F6158 File Offset: 0x007F4358
	// (set) Token: 0x0601C6A6 RID: 116390 RVA: 0x007F6160 File Offset: 0x007F4360
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

	// Token: 0x17002751 RID: 10065
	// (get) Token: 0x0601C6A7 RID: 116391 RVA: 0x007F6169 File Offset: 0x007F4369
	// (set) Token: 0x0601C6A8 RID: 116392 RVA: 0x007F6174 File Offset: 0x007F4374
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

	// Token: 0x17002752 RID: 10066
	// (get) Token: 0x0601C6A9 RID: 116393 RVA: 0x007F62EA File Offset: 0x007F44EA
	// (set) Token: 0x0601C6AA RID: 116394 RVA: 0x007F62F4 File Offset: 0x007F44F4
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

	// Token: 0x17002753 RID: 10067
	// (get) Token: 0x0601C6AB RID: 116395 RVA: 0x007F635F File Offset: 0x007F455F
	// (set) Token: 0x0601C6AC RID: 116396 RVA: 0x007F6368 File Offset: 0x007F4568
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

	// Token: 0x17002754 RID: 10068
	// (get) Token: 0x0601C6AD RID: 116397 RVA: 0x007F63D3 File Offset: 0x007F45D3
	// (set) Token: 0x0601C6AE RID: 116398 RVA: 0x007F63DC File Offset: 0x007F45DC
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

	// Token: 0x17002755 RID: 10069
	// (get) Token: 0x0601C6AF RID: 116399 RVA: 0x007F6447 File Offset: 0x007F4647
	// (set) Token: 0x0601C6B0 RID: 116400 RVA: 0x007F6450 File Offset: 0x007F4650
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

	// Token: 0x17002756 RID: 10070
	// (get) Token: 0x0601C6B1 RID: 116401 RVA: 0x007F6510 File Offset: 0x007F4710
	// (set) Token: 0x0601C6B2 RID: 116402 RVA: 0x007F6518 File Offset: 0x007F4718
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

	// Token: 0x17002757 RID: 10071
	// (get) Token: 0x0601C6B3 RID: 116403 RVA: 0x007F6583 File Offset: 0x007F4783
	// (set) Token: 0x0601C6B4 RID: 116404 RVA: 0x007F658C File Offset: 0x007F478C
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

	// Token: 0x17002758 RID: 10072
	// (get) Token: 0x0601C6B5 RID: 116405 RVA: 0x007F662B File Offset: 0x007F482B
	// (set) Token: 0x0601C6B6 RID: 116406 RVA: 0x007F6634 File Offset: 0x007F4834
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

	// Token: 0x0601C6B7 RID: 116407 RVA: 0x007F6756 File Offset: 0x007F4956
	public void SetIsFunctionOpenOverride(bool? @override)
	{
		this.IsFunctionOpenOverride = @override;
	}

	// Token: 0x0601C6B8 RID: 116408 RVA: 0x007F675F File Offset: 0x007F495F
	private bool IsSoarFunctionOpen()
	{
		if (this.IsFunctionOpenOverride != null)
		{
			return this.IsFunctionOpenOverride.Value;
		}
		return FunctionModel.Instance.IsOpen(EFunctionType.MotorSoar) && !FunctionModel.Instance.IsLimit(10154);
	}

	// Token: 0x0601C6B9 RID: 116409 RVA: 0x007F67A0 File Offset: 0x007F49A0
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

	// Token: 0x0601C6BA RID: 116410 RVA: 0x007F67E3 File Offset: 0x007F49E3
	protected override void OnLeaveVehicle(VehiclePassengerInfo info, bool byChangeRole)
	{
		if (!byChangeRole)
		{
			this.SetMotorSubState(EMotorSubState.TwoWheelMoving);
		}
		base.OnLeaveVehicle(info, byChangeRole);
	}

	// Token: 0x0601C6BB RID: 116411 RVA: 0x007F67F8 File Offset: 0x007F49F8
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

	// Token: 0x0601C6BC RID: 116412 RVA: 0x007F6900 File Offset: 0x007F4B00
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

	// Token: 0x0601C6BD RID: 116413 RVA: 0x007F69CA File Offset: 0x007F4BCA
	private void OnRefreshMenuSetting(EFunction functionId)
	{
		if (functionId == EFunction.MotorDriftModel)
		{
			this.DriftModel = (EMotorDriftModel)GameSettingsManager.Instance.GetCurrentValueSafely(EFunction.MotorDriftModel, 0, true);
		}
	}

	// Token: 0x0601C6BE RID: 116414 RVA: 0x007F69EC File Offset: 0x007F4BEC
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

	// Token: 0x0601C6BF RID: 116415 RVA: 0x007F6C74 File Offset: 0x007F4E74
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

	// Token: 0x0601C6C0 RID: 116416 RVA: 0x007F6D67 File Offset: 0x007F4F67
	protected override void OnDisable(string reason)
	{
		base.OnDisable(reason);
		this.ClearAllCacheData();
	}

	// Token: 0x0601C6C1 RID: 116417 RVA: 0x007F6D78 File Offset: 0x007F4F78
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

	// Token: 0x0601C6C2 RID: 116418 RVA: 0x007F6DD0 File Offset: 0x007F4FD0
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

	// Token: 0x0601C6C3 RID: 116419 RVA: 0x007F6F88 File Offset: 0x007F5188
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

	// Token: 0x0601C6C4 RID: 116420 RVA: 0x007F70F0 File Offset: 0x007F52F0
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

	// Token: 0x0601C6C5 RID: 116421 RVA: 0x007F7454 File Offset: 0x007F5654
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

	// Token: 0x0601C6C6 RID: 116422 RVA: 0x007F7554 File Offset: 0x007F5754
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

	// Token: 0x0601C6C7 RID: 116423 RVA: 0x007F7710 File Offset: 0x007F5910
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

	// Token: 0x0601C6C8 RID: 116424 RVA: 0x007F77F4 File Offset: 0x007F59F4
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

	// Token: 0x0601C6C9 RID: 116425 RVA: 0x007F78A0 File Offset: 0x007F5AA0
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

	// Token: 0x0601C6CA RID: 116426 RVA: 0x007F7B53 File Offset: 0x007F5D53
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

	// Token: 0x0601C6CB RID: 116427 RVA: 0x007F7B84 File Offset: 0x007F5D84
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

	// Token: 0x0601C6CC RID: 116428 RVA: 0x007F7C7F File Offset: 0x007F5E7F
	public override void SetMotorSubState(EMotorSubState subState)
	{
		base.SetMotorSubState(subState);
		this.MotorSubState = this.VehicleMovement.MotorSubState;
	}

	// Token: 0x0601C6CD RID: 116429 RVA: 0x007F7C9C File Offset: 0x007F5E9C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleMoveComponent motorcycleMoveComponent = (MotorcycleMoveComponent)componentTemplate;
		if (base.CanResetComponentProperty("BuffComp"))
		{
			if (motorcycleMoveComponent.BuffComp == null)
			{
				this.BuffComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleBuffComponent>(this.BuffComp), "BuffComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PerformComp"))
		{
			if (motorcycleMoveComponent.PerformComp == null)
			{
				this.PerformComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseVehiclePerformComponent>(this.PerformComp), "PerformComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TmpInputDirect") && motorcycleMoveComponent.TmpInputDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpInputDirect), "TmpInputDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DefaultSeatTrans") && motorcycleMoveComponent.DefaultSeatTrans != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Transform>(this.DefaultSeatTrans), "DefaultSeatTrans"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("BaseMovementArray"))
		{
			if (motorcycleMoveComponent.BaseMovementArray == null)
			{
				this.BaseMovementArray = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.BaseMovementArray), "BaseMovementArray"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentBaseMovement"))
		{
			if (motorcycleMoveComponent.CurrentBaseMovement == null)
			{
				this.CurrentBaseMovement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.CurrentBaseMovement), "CurrentBaseMovement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("NextBaseMovement"))
		{
			if (motorcycleMoveComponent.NextBaseMovement == null)
			{
				this.NextBaseMovement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UPrimitiveComponent>(this.NextBaseMovement), "NextBaseMovement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DriftModelInternal"))
		{
			this.DriftModelInternal = motorcycleMoveComponent.DriftModelInternal;
		}
		if (base.CanResetComponentProperty("BackInputTime"))
		{
			this.BackInputTime = motorcycleMoveComponent.BackInputTime;
		}
		if (base.CanResetComponentProperty("BackBrakingInternal"))
		{
			this.BackBrakingInternal = motorcycleMoveComponent.BackBrakingInternal;
		}
		if (base.CanResetComponentProperty("DriftingStateInternal"))
		{
			this.DriftingStateInternal = motorcycleMoveComponent.DriftingStateInternal;
		}
		if (base.CanResetComponentProperty("DriftDistance"))
		{
			this.DriftDistance = motorcycleMoveComponent.DriftDistance;
		}
		if (base.CanResetComponentProperty("DriftStartTime"))
		{
			this.DriftStartTime = motorcycleMoveComponent.DriftStartTime;
		}
		if (base.CanResetComponentProperty("DriftLastLocation") && motorcycleMoveComponent.DriftLastLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.DriftLastLocation), "DriftLastLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("FrontBrakingStateInternal"))
		{
			this.FrontBrakingStateInternal = motorcycleMoveComponent.FrontBrakingStateInternal;
		}
		if (base.CanResetComponentProperty("BackBrakingStateInternal"))
		{
			this.BackBrakingStateInternal = motorcycleMoveComponent.BackBrakingStateInternal;
		}
		if (base.CanResetComponentProperty("SideSlideInternal"))
		{
			this.SideSlideInternal = motorcycleMoveComponent.SideSlideInternal;
		}
		if (base.CanResetComponentProperty("MotorSubStateInternal"))
		{
			this.MotorSubStateInternal = motorcycleMoveComponent.MotorSubStateInternal;
		}
		if (base.CanResetComponentProperty("NextCheckAllowTime"))
		{
			this.NextCheckAllowTime = motorcycleMoveComponent.NextCheckAllowTime;
		}
		if (base.CanResetComponentProperty("LastCheckAllowHeightPosition") && motorcycleMoveComponent.LastCheckAllowHeightPosition != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastCheckAllowHeightPosition), "LastCheckAllowHeightPosition"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AllowSoarInternal"))
		{
			this.AllowSoarInternal = motorcycleMoveComponent.AllowSoarInternal;
		}
		if (base.CanResetComponentProperty("DriftBuffId"))
		{
			this.DriftBuffId = motorcycleMoveComponent.DriftBuffId;
		}
		if (base.CanResetComponentProperty("BackMotorBuff"))
		{
			this.BackMotorBuff = motorcycleMoveComponent.BackMotorBuff;
		}
		if (base.CanResetComponentProperty("BackingMotorInternal"))
		{
			this.BackingMotorInternal = motorcycleMoveComponent.BackingMotorInternal;
		}
		if (base.CanResetComponentProperty("SpeedBuffNotSprint") && motorcycleMoveComponent.SpeedBuffNotSprint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ValueTuple<float, long>>>(this.SpeedBuffNotSprint), "SpeedBuffNotSprint"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SpeedBuffSprint") && motorcycleMoveComponent.SpeedBuffSprint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ValueTuple<float, long>>>(this.SpeedBuffSprint), "SpeedBuffSprint"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("SpeedBuffSoarSprint") && motorcycleMoveComponent.SpeedBuffSoarSprint != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<List<ValueTuple<float, long>>>(this.SpeedBuffSoarSprint), "SpeedBuffSoarSprint"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CurrentMoveBuffInternal"))
		{
			this.CurrentMoveBuffInternal = motorcycleMoveComponent.CurrentMoveBuffInternal;
		}
		if (base.CanResetComponentProperty("SprintCameraShake"))
		{
			if (motorcycleMoveComponent.SprintCameraShake == null)
			{
				this.SprintCameraShake = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UClass>(this.SprintCameraShake), "SprintCameraShake"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsFunctionOpenOverride"))
		{
			this.IsFunctionOpenOverride = motorcycleMoveComponent.IsFunctionOpenOverride;
		}
		if (base.CanResetComponentProperty("DisableSprintTagFrame"))
		{
			this.DisableSprintTagFrame = motorcycleMoveComponent.DisableSprintTagFrame;
		}
		return (!base.CanResetComponentProperty("Stat0") || motorcycleMoveComponent.Stat0 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.Stat0), "Stat0")) && (!base.CanResetComponentProperty("Stat1") || motorcycleMoveComponent.Stat1 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.Stat1), "Stat1")) && (!base.CanResetComponentProperty("Stat2") || motorcycleMoveComponent.Stat2 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.Stat2), "Stat2")) && (!base.CanResetComponentProperty("Stat3") || motorcycleMoveComponent.Stat3 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.Stat3), "Stat3")) && (!base.CanResetComponentProperty("Stat4") || motorcycleMoveComponent.Stat4 == null || base.CheckClearObject(EntityComponentSystem.ClearObject<Stat>(this.Stat4), "Stat4"));
	}

	// Token: 0x0400E16E RID: 57710
	private const float BRAKE_FORWARD_SPEED_THRESHOLD = 200f;

	// Token: 0x0400E16F RID: 57711
	private const float BRAKE_RIGHT_SPEED_THRESHOLD = 500f;

	// Token: 0x0400E170 RID: 57712
	private const float BACK_TIME_THRESHOLD = 100f;

	// Token: 0x0400E171 RID: 57713
	private const float SIDE_SLIDE_SPEED_THRESHOLD = 200f;

	// Token: 0x0400E172 RID: 57714
	private const double DRIFT_INPUT_X_THRESHOLD = -1E-08;

	// Token: 0x0400E173 RID: 57715
	private const double DRIFT_INPUT_Y_THRESHOLD = 0.5;

	// Token: 0x0400E174 RID: 57716
	private const double DRIFT_SPEED_THRESHOLD = 500.0;

	// Token: 0x0400E175 RID: 57717
	private const float CHECK_ALLOW_SOAR_PERIOD = 200f;

	// Token: 0x0400E176 RID: 57718
	private const float CHECK_ALLOW_SOAR_HEIGHT_THRESHOLD = 100f;

	// Token: 0x0400E177 RID: 57719
	private const float ALLOW_SOAR_HEIGHT = 800f;

	// Token: 0x0400E178 RID: 57720
	[StaticVariableRuleIgnore]
	private static readonly Transform tmpTrans = Transform.Create();

	// Token: 0x0400E179 RID: 57721
	[StaticVariableRuleIgnore]
	private static readonly Quat tmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E17A RID: 57722
	[StaticVariableRuleIgnore]
	private static readonly Quat tmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E17B RID: 57723
	[StaticVariableRuleIgnore]
	private static readonly global::Vector tmpVector = global::Vector.Create();

	// Token: 0x0400E17C RID: 57724
	[StaticVariableRuleIgnore]
	private static readonly Quat leftTurn90 = Rotator.Create(0f, -90f, 0f).Quaternion(null);

	// Token: 0x0400E17D RID: 57725
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EMotorDriftModel, int> driftModelTagMap = new Dictionary<EMotorDriftModel, int>
	{
		{
			EMotorDriftModel.KartingMode,
			GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.新版漂移"]
		}
	};

	// Token: 0x0400E17E RID: 57726
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

	// Token: 0x0400E17F RID: 57727
	[Nullable(2)]
	private VehicleBuffComponent BuffComp;

	// Token: 0x0400E180 RID: 57728
	[Nullable(2)]
	private BaseVehiclePerformComponent PerformComp;

	// Token: 0x0400E181 RID: 57729
	private readonly global::Vector TmpInputDirect = global::Vector.Create();

	// Token: 0x0400E182 RID: 57730
	private readonly Transform DefaultSeatTrans = Transform.Create();

	// Token: 0x0400E183 RID: 57731
	private TArray<UPrimitiveComponent> BaseMovementArray = new TArray<UPrimitiveComponent>();

	// Token: 0x0400E184 RID: 57732
	private HashSet<UPrimitiveComponent> CurrentBaseMovement = new HashSet<UPrimitiveComponent>();

	// Token: 0x0400E185 RID: 57733
	private HashSet<UPrimitiveComponent> NextBaseMovement = new HashSet<UPrimitiveComponent>();

	// Token: 0x0400E186 RID: 57734
	private EMotorDriftModel DriftModelInternal;

	// Token: 0x0400E187 RID: 57735
	private double BackInputTime;

	// Token: 0x0400E188 RID: 57736
	private bool BackBrakingInternal;

	// Token: 0x0400E189 RID: 57737
	private bool DriftingStateInternal;

	// Token: 0x0400E18A RID: 57738
	private double DriftDistance;

	// Token: 0x0400E18B RID: 57739
	private double DriftStartTime;

	// Token: 0x0400E18C RID: 57740
	private readonly global::Vector DriftLastLocation = global::Vector.Create();

	// Token: 0x0400E18D RID: 57741
	private bool FrontBrakingStateInternal;

	// Token: 0x0400E18E RID: 57742
	private bool BackBrakingStateInternal;

	// Token: 0x0400E18F RID: 57743
	private bool SideSlideInternal;

	// Token: 0x0400E190 RID: 57744
	private EMotorSubState MotorSubStateInternal = EMotorSubState.TwoWheelMoving;

	// Token: 0x0400E191 RID: 57745
	private double NextCheckAllowTime;

	// Token: 0x0400E192 RID: 57746
	private readonly global::Vector LastCheckAllowHeightPosition = global::Vector.Create();

	// Token: 0x0400E193 RID: 57747
	private bool AllowSoarInternal;

	// Token: 0x0400E194 RID: 57748
	private long DriftBuffId;

	// Token: 0x0400E195 RID: 57749
	private long BackMotorBuff;

	// Token: 0x0400E196 RID: 57750
	private bool BackingMotorInternal;

	// Token: 0x0400E197 RID: 57751
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<float, long>> SpeedBuffNotSprint = new List<ValueTuple<float, long>>();

	// Token: 0x0400E198 RID: 57752
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<float, long>> SpeedBuffSprint = new List<ValueTuple<float, long>>();

	// Token: 0x0400E199 RID: 57753
	[Nullable(new byte[]
	{
		1,
		0
	})]
	private readonly List<ValueTuple<float, long>> SpeedBuffSoarSprint = new List<ValueTuple<float, long>>();

	// Token: 0x0400E19A RID: 57754
	private long CurrentMoveBuffInternal;

	// Token: 0x0400E19B RID: 57755
	[Nullable(2)]
	private UClass SprintCameraShake;

	// Token: 0x0400E19C RID: 57756
	private bool? IsFunctionOpenOverride;

	// Token: 0x0400E19D RID: 57757
	private int DisableSprintTagFrame;

	// Token: 0x0400E19E RID: 57758
	[StaticVariableRuleIgnore]
	private readonly Stat Stat0 = Stat.Create("BackingMotor", "", "");

	// Token: 0x0400E19F RID: 57759
	[StaticVariableRuleIgnore]
	private readonly Stat Stat1 = Stat.Create("super.OnTick", "", "");

	// Token: 0x0400E1A0 RID: 57760
	[StaticVariableRuleIgnore]
	private readonly Stat Stat2 = Stat.Create("UpdateMoveState", "", "");

	// Token: 0x0400E1A1 RID: 57761
	[StaticVariableRuleIgnore]
	private readonly Stat Stat3 = Stat.Create("UpdateMoveBuff", "", "");

	// Token: 0x0400E1A2 RID: 57762
	[StaticVariableRuleIgnore]
	private readonly Stat Stat4 = Stat.Create("UpdateBaseMovement", "", "");
}
