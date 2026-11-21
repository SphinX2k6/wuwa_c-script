using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Character.Input.Enum;
using AkiClient.Game.Aki.Character.Input.Structures;
using AkiClient.Game.Aki.Character.Vehicle.Motor.Data;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.NewWorld.Vehicle.Motorcycle;
using CSharpScript.Game.Ui;
using UnrealEngine;

// Token: 0x0200286A RID: 10346
[NullableContext(1)]
[Nullable(0)]
public class MotorcycleInputComponent : VehicleInputComponent
{
	// Token: 0x17002ACE RID: 10958
	// (get) Token: 0x0601A340 RID: 107328 RVA: 0x0081A88D File Offset: 0x00818A8D
	// (set) Token: 0x0601A341 RID: 107329 RVA: 0x0081A898 File Offset: 0x00818A98
	protected bool InSprint
	{
		get
		{
			return this.InSprintInternal;
		}
		set
		{
			if (this.InSprintInternal == value)
			{
				return;
			}
			this.InSprintInternal = value;
			BaseTagComponent tagComp = this.TagComp;
			int value2 = (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"])) ? GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺.玩家输入"] : GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺.玩家输入"];
			if (value)
			{
				this.TagComp.AddTag(new int?(value2));
				return;
			}
			this.TagComp.RemoveTag(new int?(value2));
		}
	}

	// Token: 0x0601A342 RID: 107330 RVA: 0x0081A924 File Offset: 0x00818B24
	protected void BanSprint(int tagId, bool isTagExist)
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		BaseTagComponent baseTagComponent;
		if (performComp == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity driver = performComp.Driver;
			baseTagComponent = ((driver != null) ? driver.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		bool bannedSprint;
		if (baseTagComponent2 == null || !baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用氮气"]))
		{
			BaseTagComponent tagComp = this.TagComp;
			bannedSprint = (tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用氮气"]));
		}
		else
		{
			bannedSprint = true;
		}
		this.BannedSprint = bannedSprint;
		this.RefreshSprint();
	}

	// Token: 0x0601A343 RID: 107331 RVA: 0x0081A99C File Offset: 0x00818B9C
	protected void RefreshSprint()
	{
		bool flag = this.CheckNitroBoostPress();
		bool flag2;
		if ((this.PressingSprint || flag) && !this.BannedSprint)
		{
			BaseTagComponent tagComp = this.TagComp;
			flag2 = ((tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.新版漂移"])) || !this.InBackBraking);
		}
		else
		{
			flag2 = false;
		}
		bool flag3 = flag2;
		MotorcycleAudioComponent audioComp = this.AudioComp;
		if (audioComp != null)
		{
			audioComp.MotorNitroAccelerationFailure(this.BannedSprint, flag3, this.PressingSprint);
		}
		this.InSprint = flag3;
	}

	// Token: 0x17002ACF RID: 10959
	// (get) Token: 0x0601A344 RID: 107332 RVA: 0x0081AA1A File Offset: 0x00818C1A
	// (set) Token: 0x0601A345 RID: 107333 RVA: 0x0081AA22 File Offset: 0x00818C22
	protected bool InBackBraking
	{
		get
		{
			return this.InBackBrakingInternal;
		}
		set
		{
			if (this.InBackBrakingInternal == value)
			{
				return;
			}
			this.InBackBrakingInternal = value;
			this.MoveComp.BackBraking = value;
		}
	}

	// Token: 0x0601A346 RID: 107334 RVA: 0x0081AA44 File Offset: 0x00818C44
	protected void BanDrift(int tagId, bool isTagExist)
	{
		BaseVehiclePerformComponent performComp = this.PerformComp;
		BaseTagComponent baseTagComponent;
		if (performComp == null)
		{
			baseTagComponent = null;
		}
		else
		{
			Entity driver = performComp.Driver;
			baseTagComponent = ((driver != null) ? driver.GetComponent<BaseTagComponent>() : null);
		}
		BaseTagComponent baseTagComponent2 = baseTagComponent;
		bool bannedBackBraking;
		if (baseTagComponent2 == null || !baseTagComponent2.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用漂移"]))
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用漂移"]))
			{
				BaseTagComponent tagComp2 = this.TagComp;
				bannedBackBraking = (tagComp2 != null && tagComp2.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]));
				goto IL_81;
			}
		}
		bannedBackBraking = true;
		IL_81:
		this.BannedBackBraking = bannedBackBraking;
		this.RefreshBackBraking();
	}

	// Token: 0x0601A347 RID: 107335 RVA: 0x0081AAE0 File Offset: 0x00818CE0
	protected void OnSoarChanged(int tagId, bool tagExist)
	{
		if (!this.InSprint)
		{
			return;
		}
		if (tagExist)
		{
			this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺.玩家输入"]));
			this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺.玩家输入"]));
			return;
		}
		this.TagComp.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.翱翔冲刺.玩家输入"]));
		this.TagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.冲刺.玩家输入"]));
	}

	// Token: 0x0601A348 RID: 107336 RVA: 0x0081AB78 File Offset: 0x00818D78
	protected void RefreshBackBraking()
	{
		this.InBackBraking = (this.PressingBackBraking && !this.BannedBackBraking);
		this.RefreshSprint();
	}

	// Token: 0x0601A349 RID: 107337 RVA: 0x0081AB9A File Offset: 0x00818D9A
	protected override void OnEnterOrLeaveVehicle(VehiclePassengerInfo info, bool enter)
	{
		base.OnEnterOrLeaveVehicle(info, enter);
		if (!info.IsDriver)
		{
			return;
		}
		this.IsDriving = enter;
		if (enter)
		{
			this.EnterVehicle(info);
		}
		else
		{
			this.LeaveVehicle(info);
		}
		this.BanSprint(0, false);
		this.BanDrift(0, false);
	}

	// Token: 0x0601A34A RID: 107338 RVA: 0x0081ABD8 File Offset: 0x00818DD8
	private void EnterVehicle(VehiclePassengerInfo info)
	{
		Entity passengerEntity = info.PassengerEntity;
		BaseTagComponent baseTagComponent = (passengerEntity != null) ? passengerEntity.GetComponent<BaseTagComponent>() : null;
		if (baseTagComponent != null)
		{
			baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用氮气"]), new BaseTagComponent.TTagSwitchedCallback(this.BanSprint), null);
		}
		if (baseTagComponent != null)
		{
			baseTagComponent.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用漂移"]), new BaseTagComponent.TTagSwitchedCallback(this.BanDrift), null);
		}
		EventSystem.Instance.AddWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		if (baseTagComponent != null)
		{
			EventSystem.Instance.AddWithTarget<int, int, bool>(baseTagComponent.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			EventSystem.Instance.AddWithTarget(baseTagComponent.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		}
		EventSystem.Instance.Add<string>(EEventName.ForceReleaseInput, new Action<string>(this.OnForceReleaseInput));
	}

	// Token: 0x0601A34B RID: 107339 RVA: 0x0081ACD0 File Offset: 0x00818ED0
	private void LeaveVehicle(VehiclePassengerInfo info)
	{
		Entity passengerEntity = info.PassengerEntity;
		BaseTagComponent baseTagComponent = (passengerEntity != null) ? passengerEntity.GetComponent<BaseTagComponent>() : null;
		this.PressingBackBraking = false;
		this.PressingSprint = false;
		this.InSprint = false;
		this.InBackBraking = false;
		if (baseTagComponent != null)
		{
			baseTagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用氮气"], new BaseTagComponent.TTagSwitchedCallback(this.BanSprint));
		}
		if (baseTagComponent != null)
		{
			baseTagComponent.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用漂移"], new BaseTagComponent.TTagSwitchedCallback(this.BanDrift));
		}
		EventSystem.Instance.RemoveWithTarget<int, int, bool>(base.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
		if (baseTagComponent != null)
		{
			EventSystem.Instance.RemoveWithTarget<int, int, bool>(baseTagComponent.Entity, EEventName.CharUseSkill, new Action<int, int, bool>(this.OnCharUseSkill));
			EventSystem.Instance.RemoveWithTarget(baseTagComponent.Entity, EEventName.CharOnRoleDeadTargetSelf, new Action(this.OnRoleDead));
		}
		EventSystem.Instance.Remove<string>(EEventName.ForceReleaseInput, new Action<string>(this.OnForceReleaseInput));
	}

	// Token: 0x0601A34C RID: 107340 RVA: 0x0081ADD4 File Offset: 0x00818FD4
	protected override bool OnStart()
	{
		base.OnStart();
		this.MoveComp = base.Entity.GetComponent<MotorcycleMoveComponent>();
		this.AudioComp = base.Entity.GetComponent<MotorcycleAudioComponent>();
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用氮气"]), new BaseTagComponent.TTagSwitchedCallback(this.BanSprint), null);
		}
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null)
		{
			tagComp2.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用漂移"]), new BaseTagComponent.TTagSwitchedCallback(this.BanDrift), null);
		}
		BaseTagComponent tagComp3 = this.TagComp;
		if (tagComp3 != null)
		{
			tagComp3.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]), new BaseTagComponent.TTagSwitchedCallback(this.BanDrift), null);
		}
		BaseTagComponent tagComp4 = this.TagComp;
		if (tagComp4 != null)
		{
			tagComp4.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]), new BaseTagComponent.TTagSwitchedCallback(this.OnSoarChanged), null);
		}
		BaseTagComponent tagComp5 = this.TagComp;
		if (tagComp5 != null)
		{
			tagComp5.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.油门维持"]), new BaseTagComponent.TTagSwitchedCallback(this.HoldThrottleChange), null);
		}
		BaseTagComponent tagComp6 = this.TagComp;
		if (tagComp6 != null)
		{
			tagComp6.ListenForTagAddOrRemove(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.氮气维持"]), new BaseTagComponent.TTagSwitchedCallback(this.NitroBoostChange), null);
		}
		EventSystem.Instance.Add<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewShow));
		this.InitInputAssistConfig();
		this.InitCommandActionMap();
		float? floatConfig = ConfigCommonParamById.GetFloatConfig("MotorJoyStickAngle1");
		this.MotorJoyStickAngle1 = ((floatConfig != null) ? ((double)floatConfig.GetValueOrDefault()) : this.MotorJoyStickAngle1);
		floatConfig = ConfigCommonParamById.GetFloatConfig("MotorJoyStickAngle2");
		this.MotorJoyStickAngle2 = ((floatConfig != null) ? ((double)floatConfig.GetValueOrDefault()) : this.MotorJoyStickAngle2);
		return true;
	}

	// Token: 0x0601A34D RID: 107341 RVA: 0x0081AFB8 File Offset: 0x008191B8
	protected override bool OnEnd()
	{
		base.OnEnd();
		BaseTagComponent tagComp = this.TagComp;
		if (tagComp != null)
		{
			tagComp.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用氮气"], new BaseTagComponent.TTagSwitchedCallback(this.BanSprint));
		}
		BaseTagComponent tagComp2 = this.TagComp;
		if (tagComp2 != null)
		{
			tagComp2.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用漂移"], new BaseTagComponent.TTagSwitchedCallback(this.BanDrift));
		}
		BaseTagComponent tagComp3 = this.TagComp;
		if (tagComp3 != null)
		{
			tagComp3.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"], new BaseTagComponent.TTagSwitchedCallback(this.BanDrift));
		}
		BaseTagComponent tagComp4 = this.TagComp;
		if (tagComp4 != null)
		{
			tagComp4.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"], new BaseTagComponent.TTagSwitchedCallback(this.OnSoarChanged));
		}
		BaseTagComponent tagComp5 = this.TagComp;
		if (tagComp5 != null)
		{
			tagComp5.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.油门维持"], new BaseTagComponent.TTagSwitchedCallback(this.HoldThrottleChange));
		}
		BaseTagComponent tagComp6 = this.TagComp;
		if (tagComp6 != null)
		{
			tagComp6.RemoveTagAddOrRemoveListener(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.氮气维持"], new BaseTagComponent.TTagSwitchedCallback(this.NitroBoostChange));
		}
		EventSystem.Instance.Remove<EUiViewName, int>(EEventName.OpenView, new Action<EUiViewName, int>(this.OnViewShow));
		return true;
	}

	// Token: 0x0601A34E RID: 107342 RVA: 0x0081B0ED File Offset: 0x008192ED
	protected override void OnDisable(string reason)
	{
		this.AirRotateInput = 0.0;
	}

	// Token: 0x0601A34F RID: 107343 RVA: 0x0081B100 File Offset: 0x00819300
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		if (!this.MoveVectorCache.IsNearlyZero(9.999999747378752E-05) || this.InSprint || this.InBackBraking)
		{
			this.LastInputSeconds = Time.Instance.NowSeconds;
		}
		this.UpdateAssistedInput((double)delta);
	}

	// Token: 0x0601A350 RID: 107344 RVA: 0x0081B154 File Offset: 0x00819354
	protected override void UpdateVehicleInputDirectAndFacing()
	{
		OneOf<CharacterActorComponent, VehicleActorComponent> value = this.ActorComp.Value;
		MotorcycleActorComponent motorcycleActorComponent = value.Match<VehicleActorComponent>(([Nullable(1)] CharacterActorComponent t1) => null, ([Nullable(1)] VehicleActorComponent t2) => t2) as MotorcycleActorComponent;
		if (Info.Instance.IsInTouch())
		{
			base.GetMoveVector(this.MotorInputCache);
			this.InputAdjustedTouch(this.MotorInputCache);
			motorcycleActorComponent.SetAirRotateInput(this.MotorInputCache);
		}
		else
		{
			base.GetMoveVector(this.MotorInputCache);
			this.MotorInputCache.X = MathUtils.Instance.Clamp(this.MotorInputCache.X, -1.0, 1.0);
			this.MotorInputCache.Y = MathUtils.Instance.Clamp(this.MotorInputCache.Y, -1.0, 1.0);
			motorcycleActorComponent.SetAirRotateInput(this.MotorInputCache);
		}
		if (Info.Instance.IsPcInputModel() && !Info.Instance.IsInTouch() && !Info.Instance.IsInGamepad() && this.MoveComp.MotorSubState != EMotorSubState.Soaring)
		{
			this.TmpVector1.DeepCopy(motorcycleActorComponent.AirRotateInputProxy);
			this.TmpVector1.X = Math.Min(0.0, this.TmpVector1.X) + this.AirRotateInput;
			motorcycleActorComponent.SetAirRotateInput(this.TmpVector1);
		}
		if (this.MoveComp.MotorSubState == EMotorSubState.Soaring && GameSettingsManager.Instance.GetCurrentValue(EFunction.MotorFlyControlMode, true, true).GetValueOrDefault() == 1)
		{
			this.TmpVector1.DeepCopy(motorcycleActorComponent.AirRotateInputProxy);
			this.TmpVector1.X = -this.TmpVector1.X;
			motorcycleActorComponent.SetAirRotateInput(this.TmpVector1);
		}
		this.PlayerMotorInput.DeepCopy(this.MotorInputCache);
		MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo = this.HoldThrottleInfo1;
		if (holdThrottleInfo == null || !holdThrottleInfo.UpdateAutoState())
		{
			MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo = this.NitroBoostInfo1;
			if (nitroBoostInfo == null || !nitroBoostInfo.UpdateAutoState())
			{
				goto IL_22A;
			}
		}
		this.MotorInputCache.X = 1.0;
		IL_22A:
		if (this.CheckAssistDrift())
		{
			if (!this.PressingBackBraking)
			{
				MotorcycleMoveComponent moveComp = this.MoveComp;
				if (moveComp == null || !moveComp.DriftingState)
				{
					goto IL_262;
				}
			}
			this.MotorInputCache.X = 1.0;
		}
		IL_262:
		value = this.ActorComp.Value;
		value.Switch(delegate(CharacterActorComponent t1)
		{
			t1.SetInputDirect(this.MotorInputCache, false, EInputDirectSpace.Relative);
		}, delegate(VehicleActorComponent t2)
		{
			t2.SetInputDirect(this.MotorInputCache, false, EInputDirectSpace.Relative);
		});
		this.SetInputFacingFromInputDirect(true);
	}

	// Token: 0x0601A351 RID: 107345 RVA: 0x0081B3F8 File Offset: 0x008195F8
	protected override void SetInputFacingFromInputDirect(bool clearWhenNoInput = true)
	{
		this.ActorComp.Value.Switch(delegate(CharacterActorComponent t1)
		{
			t1.SetInputFacing(t1.ActorForwardProxy, false);
		}, delegate(VehicleActorComponent t2)
		{
			t2.SetInputFacing(t2.ActorForwardProxy, false);
		});
	}

	// Token: 0x0601A352 RID: 107346 RVA: 0x0081B458 File Offset: 0x00819658
	protected void InputAdjustedTouch(global::Vector outInputDirect)
	{
		if (BattleUiModel.Instance.MotorcycleData.GetIsRoundJoystick())
		{
			if (this.MoveComp.MotorSubState != EMotorSubState.Soaring)
			{
				this.PrevIsPositive = MotorcycleInputComponent.ConvertPolarInput(this.MoveVectorCache, this.TmpVector1, this.MotorJoyStickAngle1, this.MotorJoyStickAngle2, this.PrevIsPositive);
			}
			else
			{
				MotorcycleInputComponent.ConvertCycleInputToSquared(this.MotorInputCache, this.TmpVector1);
			}
		}
		else
		{
			this.TmpVector1.X = MathUtils.Instance.Clamp(this.MotorInputCache.X, -1.0, 1.0);
			this.TmpVector1.Y = MathUtils.Instance.Clamp(this.MotorInputCache.Y, -1.0, 1.0);
		}
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
				BaseTagComponent component = driver.GetComponent<BaseTagComponent>();
				flag2 = ((component != null) ? new bool?(component.HasTag(GameplayTagDefine.EGameplayTagId["角色.Common.载具驾驶.摩托.功能开关.禁用刹车"])) : null);
			}
			bool? flag3 = flag2;
			flag = flag3.GetValueOrDefault();
		}
		if (!flag)
		{
			BaseTagComponent tagComp = this.TagComp;
			if (tagComp == null || !tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.功能开关.禁用刹车"]))
			{
				goto IL_160;
			}
		}
		this.TmpVector1.X = Math.Max(0.0, this.TmpVector1.X);
		IL_160:
		outInputDirect.DeepCopy(this.TmpVector1);
	}

	// Token: 0x0601A353 RID: 107347 RVA: 0x0081B5D4 File Offset: 0x008197D4
	public override void ExecuteInputCommand(InputCommand inputCommand, string context)
	{
		SInputCommand command = inputCommand.Command;
		byte b = command.CommandType;
		switch (b)
		{
		case 1:
			this.ExecuteSkill(command);
			return;
		case 2:
			this.ExecuteJump(command);
			return;
		case 3:
			break;
		case 4:
			this.ExecuteSprint(command);
			return;
		default:
			if (b != 8)
			{
				return;
			}
			this.ExecuteSwitchWalk(command);
			break;
		}
	}

	// Token: 0x0601A354 RID: 107348 RVA: 0x0081B630 File Offset: 0x00819830
	protected override void ExecuteSprint(SInputCommand command)
	{
		this.PressingSprint = (command.IntValue != 0);
		this.RefreshSprint();
	}

	// Token: 0x0601A355 RID: 107349 RVA: 0x0081B647 File Offset: 0x00819847
	protected override void ExecuteJump(SInputCommand command)
	{
		this.PressingBackBraking = (command.IntValue != 0);
		this.RefreshBackBraking();
		if (command.IntValue != 0)
		{
			MotorcycleMoveComponent moveComp = this.MoveComp;
			if (moveComp == null)
			{
				return;
			}
			moveComp.SwitchAirMode();
		}
	}

	// Token: 0x0601A356 RID: 107350 RVA: 0x0081B678 File Offset: 0x00819878
	protected override void ExecuteSkill(SInputCommand command)
	{
		this.LastInputSeconds = Time.Instance.NowSeconds;
		if (command.IntValue == 210012)
		{
			BaseVehiclePerformComponent component = base.Entity.GetComponent<BaseVehiclePerformComponent>();
			if (((component != null) ? component.Driver : null) != null)
			{
				component.TryLeave(component.Driver, ELeaveVehicleType.Launch);
				return;
			}
		}
		else
		{
			this.BeginSkill(command.IntValue);
		}
	}

	// Token: 0x0601A357 RID: 107351 RVA: 0x0081B6D7 File Offset: 0x008198D7
	protected void ExecuteSwitchWalk(SInputCommand command)
	{
		this.AirRotateInput = (command.IntValue != 0);
	}

	// Token: 0x0601A358 RID: 107352 RVA: 0x0081B6E9 File Offset: 0x008198E9
	private void BeginSkill(int skillId)
	{
		base.Entity.GetComponent<BaseSkillComponent>().BeginSkill(skillId, new SkillParam
		{
			Reason = "MotorInputComponent.ExecuteSkill"
		});
	}

	// Token: 0x0601A359 RID: 107353 RVA: 0x0081B70D File Offset: 0x0081990D
	public void ForceRefreshBraking()
	{
		this.InBackBraking = !this.InBackBraking;
		this.InBackBraking = !this.InBackBraking;
		this.RefreshSprint();
	}

	// Token: 0x0601A35A RID: 107354 RVA: 0x0081B733 File Offset: 0x00819933
	protected void OnAddBlockAction(AkiClient.Game.Aki.Character.Input.Enum.EInputAction inputAction)
	{
		if (inputAction == AkiClient.Game.Aki.Character.Input.Enum.EInputAction.跳跃)
		{
			if (this.PressingBackBraking)
			{
				this.PressingBackBraking = false;
				this.RefreshBackBraking();
				return;
			}
		}
		else if (inputAction == AkiClient.Game.Aki.Character.Input.Enum.EInputAction.闪避 && this.PressingSprint)
		{
			this.PressingSprint = false;
			this.RefreshSprint();
		}
	}

	// Token: 0x0601A35B RID: 107355 RVA: 0x0081B768 File Offset: 0x00819968
	protected override bool IsEnableExecuteCommandImmediately()
	{
		return true;
	}

	// Token: 0x0601A35C RID: 107356 RVA: 0x0081B76C File Offset: 0x0081996C
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	protected override List<InputCommand> GetImmediateInputCommands(List<InputCommand> inputCommands)
	{
		if (inputCommands.Count == 0)
		{
			return null;
		}
		this.CommandIndexMap.Clear();
		this.CommandPriorityMap.Clear();
		List<InputCommand> list = new List<InputCommand>();
		int num = -1;
		foreach (InputCommand inputCommand in inputCommands)
		{
			TEnumAsByte<ECommandType> commandType = inputCommand.Command.CommandType;
			int index;
			if (this.CommandIndexMap.TryGetValue(commandType, out index))
			{
				int valueOrDefault = this.QueryCommandPriority(inputCommand.Command).GetValueOrDefault(-1);
				int num2;
				if (valueOrDefault > (this.CommandPriorityMap.TryGetValue(commandType, out num2) ? num2 : -1))
				{
					list[index] = inputCommand;
					this.CommandPriorityMap[commandType] = valueOrDefault;
				}
			}
			else
			{
				int valueOrDefault2 = this.QueryCommandPriority(inputCommand.Command).GetValueOrDefault(-1);
				if (valueOrDefault2 > -1)
				{
					list.Add(inputCommand);
					num = (this.CommandIndexMap[commandType] = num + 1);
					this.CommandPriorityMap[commandType] = valueOrDefault2;
				}
			}
		}
		return list;
	}

	// Token: 0x0601A35D RID: 107357 RVA: 0x0081B8AC File Offset: 0x00819AAC
	protected override int QuerySkillPriority(int skillId)
	{
		return 2;
	}

	// Token: 0x0601A35E RID: 107358 RVA: 0x0081B8B0 File Offset: 0x00819AB0
	protected override int? QueryCommandPriority(SInputCommand command)
	{
		AkiClient.Game.Aki.Character.Input.Enum.EInputAction action;
		if (this.CommandActionMap.TryGetValue(command.CommandType, out action))
		{
			string actionNameByInputAction = InputModel.Instance.GetInputData(EInputDataType.NormalWorldMotor).GetActionNameByInputAction(action);
			if (actionNameByInputAction != null)
			{
				bool flag = InputDistributeModel.Instance.IsActionInPress(actionNameByInputAction);
				if (command.IntValue == 1 && flag)
				{
					return new int?(1);
				}
				if (command.IntValue == 0)
				{
					return new int?(1);
				}
				return new int?(-1);
			}
		}
		return null;
	}

	// Token: 0x0601A35F RID: 107359 RVA: 0x0081B930 File Offset: 0x00819B30
	private void InitCommandActionMap()
	{
		this.CommandActionMap[ECommandType.Jump] = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.跳跃;
		this.CommandActionMap[ECommandType.Sprint] = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.闪避;
		this.CommandActionMap[ECommandType.SwitchWalk] = AkiClient.Game.Aki.Character.Input.Enum.EInputAction.走跑切换;
	}

	// Token: 0x0601A360 RID: 107360 RVA: 0x0081B959 File Offset: 0x00819B59
	private void InitInputAssistConfig()
	{
		ResourceSystem.Instance.LoadTypeAsync("BP_MotorAssistInputConfig_C", delegate
		{
			ResourceSystem.Instance.LoadAsync<BP_MotorAssistInputConfig_C>("/Game/Aki/Character/Vehicle/Motor/Data/DA/DA_MotorAssistInputConfig.DA_MotorAssistInputConfig", delegate([Nullable(2)] BP_MotorAssistInputConfig_C result, string _)
			{
				if (result == null || this.TagComp == null)
				{
					return;
				}
				this.DebugAssistDrift = result.DebugAssistDrift;
				this.HoldThrottleInfo1 = new MotorcycleInputComponent.HoldThrottleInfo(this.TagComp, GameplayTagDefine.EGameplayTagId["载具.摩托.移动.油门维持"]);
				this.HoldThrottleInfo1.InitConfig(result);
				this.NitroBoostInfo1 = new MotorcycleInputComponent.NitroBoostInfo(this.TagComp, GameplayTagDefine.EGameplayTagId["载具.摩托.移动.氮气维持"]);
				this.NitroBoostInfo1.InitConfig(result);
			}, 100, "js_undefined");
		}, "js_undefined");
	}

	// Token: 0x0601A361 RID: 107361 RVA: 0x0081B97B File Offset: 0x00819B7B
	private bool CheckAssistDrift()
	{
		return BattleUiModel.Instance.MotorcycleData.DriftAcceleratorSettingEnable || this.DebugAssistDrift;
	}

	// Token: 0x0601A362 RID: 107362 RVA: 0x0081B998 File Offset: 0x00819B98
	[NullableContext(2)]
	private void ResetAssistInput(string context = null, bool nitro = true, bool throttle = true)
	{
		if (nitro)
		{
			MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo = this.NitroBoostInfo1;
			if (nitroBoostInfo != null && nitroBoostInfo.UpdateAutoState())
			{
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo2 = this.NitroBoostInfo1;
				if (nitroBoostInfo2 != null)
				{
					nitroBoostInfo2.ResetAutoState(context);
				}
			}
			else
			{
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo3 = this.NitroBoostInfo1;
				if (nitroBoostInfo3 != null)
				{
					nitroBoostInfo3.ClearTimeAccumulation();
				}
			}
		}
		if (throttle)
		{
			MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo = this.HoldThrottleInfo1;
			if (holdThrottleInfo != null && holdThrottleInfo.UpdateAutoState())
			{
				MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo2 = this.HoldThrottleInfo1;
				if (holdThrottleInfo2 == null)
				{
					return;
				}
				holdThrottleInfo2.ResetAutoState(context);
				return;
			}
			else
			{
				MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo3 = this.HoldThrottleInfo1;
				if (holdThrottleInfo3 == null)
				{
					return;
				}
				holdThrottleInfo3.ClearTimeAccumulation();
			}
		}
	}

	// Token: 0x0601A363 RID: 107363 RVA: 0x0081BA1A File Offset: 0x00819C1A
	private void UpdateAssistedInput(double delta)
	{
		if (!this.IsDriving)
		{
			this.ResetAssistInput("角色离开载具", true, true);
			return;
		}
		this.UpdateNitroBoost(delta);
		this.UpdateHoldThrottle(delta);
	}

	// Token: 0x0601A364 RID: 107364 RVA: 0x0081BA40 File Offset: 0x00819C40
	private void UpdateNitroBoost(double delta)
	{
		MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo = this.NitroBoostInfo1;
		bool? flag = (nitroBoostInfo != null) ? new bool?(nitroBoostInfo.GetSettingEnable()) : null;
		bool flag2 = !this.BannedSprint && !this.InBackBraking;
		bool flag3 = this.PlayerMotorInput.X >= 0.0;
		BaseTagComponent tagComp = this.TagComp;
		bool flag4 = tagComp != null && tagComp.HasTag(GameplayTagDefine.EGameplayTagId["载具.摩托.状态.空中.翱翔"]);
		bool flag5 = flag.GetValueOrDefault() && flag2 && (flag4 || flag3) && this.IsDriving;
		MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo2 = this.NitroBoostInfo1;
		if (((nitroBoostInfo2 != null) ? new bool?(nitroBoostInfo2.UpdateAutoState()) : null).GetValueOrDefault())
		{
			if (!flag5)
			{
				this.ResetAssistInput("氮气维持，不在冲刺或刹车", true, false);
				return;
			}
		}
		else
		{
			MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo3 = this.NitroBoostInfo1;
			bool? flag6 = (nitroBoostInfo3 != null) ? new bool?(nitroBoostInfo3.IsIgnoreInput()) : null;
			if (this.InSprint && flag5 && !flag6.GetValueOrDefault())
			{
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo4 = this.NitroBoostInfo1;
				if (nitroBoostInfo4 != null)
				{
					nitroBoostInfo4.AddTimeAccumulation(delta);
				}
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo5 = this.NitroBoostInfo1;
				if (((nitroBoostInfo5 != null) ? new bool?(nitroBoostInfo5.CheckTimeDuration()) : null).GetValueOrDefault())
				{
					MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo6 = this.NitroBoostInfo1;
					if (nitroBoostInfo6 != null)
					{
						nitroBoostInfo6.SetStartEnter(true);
					}
					MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo7 = this.NitroBoostInfo1;
					if (nitroBoostInfo7 == null)
					{
						return;
					}
					nitroBoostInfo7.SetAutoState(true);
					return;
				}
			}
			else
			{
				if (!this.PressingSprint && flag6.GetValueOrDefault())
				{
					MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo8 = this.NitroBoostInfo1;
					if (nitroBoostInfo8 != null)
					{
						nitroBoostInfo8.SetIgnoreInput(false);
					}
				}
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo9 = this.NitroBoostInfo1;
				if (nitroBoostInfo9 == null)
				{
					return;
				}
				nitroBoostInfo9.ClearTimeAccumulation();
			}
		}
	}

	// Token: 0x0601A365 RID: 107365 RVA: 0x0081BBE4 File Offset: 0x00819DE4
	private void UpdateHoldThrottle(double delta)
	{
		MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo = this.HoldThrottleInfo1;
		bool? flag = (holdThrottleInfo != null) ? new bool?(holdThrottleInfo.GetSettingEnable()) : null;
		bool flag2 = this.MoveComp.Speed > 0f;
		bool flag3 = this.PlayerMotorInput.X > 0.0;
		bool flag4 = flag.GetValueOrDefault() && flag2 && flag3 && this.IsDriving;
		bool isRoundJoystick = BattleUiModel.Instance.MotorcycleData.GetIsRoundJoystick();
		MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo2 = this.HoldThrottleInfo1;
		if (!((holdThrottleInfo2 != null) ? new bool?(holdThrottleInfo2.UpdateAutoState()) : null).GetValueOrDefault())
		{
			MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo3 = this.HoldThrottleInfo1;
			bool? flag5 = (holdThrottleInfo3 != null) ? new bool?(holdThrottleInfo3.IsIgnoreInput()) : null;
			if (flag4 && !flag5.GetValueOrDefault())
			{
				MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo4 = this.HoldThrottleInfo1;
				if (holdThrottleInfo4 != null)
				{
					holdThrottleInfo4.AddTimeAccumulation(delta);
				}
				MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo5 = this.HoldThrottleInfo1;
				if (((holdThrottleInfo5 != null) ? new bool?(holdThrottleInfo5.CheckTimeDuration()) : null).GetValueOrDefault())
				{
					MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo6 = this.HoldThrottleInfo1;
					if (holdThrottleInfo6 != null)
					{
						holdThrottleInfo6.SetStartEnter(true);
					}
					MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo7 = this.HoldThrottleInfo1;
					if (holdThrottleInfo7 == null)
					{
						return;
					}
					holdThrottleInfo7.SetAutoState(true);
					return;
				}
			}
			else
			{
				if (!flag3 && flag5.GetValueOrDefault())
				{
					MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo8 = this.HoldThrottleInfo1;
					if (holdThrottleInfo8 != null)
					{
						holdThrottleInfo8.SetIgnoreInput(false);
					}
				}
				MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo9 = this.HoldThrottleInfo1;
				if (holdThrottleInfo9 == null)
				{
					return;
				}
				holdThrottleInfo9.ClearTimeAccumulation();
			}
			return;
		}
		MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo10 = this.HoldThrottleInfo1;
		bool? flag6 = (holdThrottleInfo10 != null) ? new bool?(holdThrottleInfo10.IsStartEnter()) : null;
		if (this.PlayerMotorInput.X < 0.0)
		{
			this.ResetAssistInput("油门维持，不在移动或刹车", true, true);
			return;
		}
		if (this.PlayerMotorInput.X != 0.0 || !flag6.GetValueOrDefault())
		{
			if (!flag6.GetValueOrDefault() && flag3 && !isRoundJoystick)
			{
				this.ResetAssistInput("给了新的油门，退出油门维持", true, true);
				MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo11 = this.HoldThrottleInfo1;
				if (holdThrottleInfo11 == null)
				{
					return;
				}
				holdThrottleInfo11.SetIgnoreInput(true);
			}
			return;
		}
		MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo12 = this.HoldThrottleInfo1;
		if (holdThrottleInfo12 == null)
		{
			return;
		}
		holdThrottleInfo12.SetStartEnter(false);
	}

	// Token: 0x0601A366 RID: 107366 RVA: 0x0081BDF8 File Offset: 0x00819FF8
	private bool CheckNitroBoostPress()
	{
		MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo = this.NitroBoostInfo1;
		bool flag = nitroBoostInfo != null && nitroBoostInfo.UpdateAutoState();
		if (flag)
		{
			if (this.PressingSprint)
			{
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo2 = this.NitroBoostInfo1;
				if (nitroBoostInfo2 == null || !nitroBoostInfo2.IsStartEnter())
				{
					this.ResetAssistInput("氮气维持被新输入打断", true, false);
					MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo3 = this.NitroBoostInfo1;
					if (nitroBoostInfo3 != null)
					{
						nitroBoostInfo3.SetIgnoreInput(true);
					}
					return false;
				}
			}
			if (!this.PressingSprint)
			{
				MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo4 = this.NitroBoostInfo1;
				if (nitroBoostInfo4 != null)
				{
					nitroBoostInfo4.SetStartEnter(false);
				}
			}
		}
		return flag;
	}

	// Token: 0x0601A367 RID: 107367 RVA: 0x0081BE76 File Offset: 0x0081A076
	private void HoldThrottleChange(int tagId, bool tagExist)
	{
	}

	// Token: 0x0601A368 RID: 107368 RVA: 0x0081BE78 File Offset: 0x0081A078
	protected void NitroBoostChange(int tagId, bool tagExist)
	{
		this.RefreshSprint();
	}

	// Token: 0x0601A369 RID: 107369 RVA: 0x0081BE80 File Offset: 0x0081A080
	private void OnCharUseSkill(int charId, int skillId, bool isAutonomousProxy)
	{
		MotorcycleInputComponent.NitroBoostInfo nitroBoostInfo = this.NitroBoostInfo1;
		if (nitroBoostInfo == null || !nitroBoostInfo.CheckPermitSkill(skillId))
		{
			this.ResetAssistInput("氮气维持，使用了技能" + skillId.ToString(), true, false);
		}
		MotorcycleInputComponent.HoldThrottleInfo holdThrottleInfo = this.HoldThrottleInfo1;
		if (holdThrottleInfo == null || !holdThrottleInfo.CheckPermitSkill(skillId))
		{
			this.ResetAssistInput("油门维持，使用了技能" + skillId.ToString(), false, true);
		}
	}

	// Token: 0x0601A36A RID: 107370 RVA: 0x0081BEEF File Offset: 0x0081A0EF
	private void OnRoleDead()
	{
		this.ResetAssistInput("角色死亡", true, true);
	}

	// Token: 0x0601A36B RID: 107371 RVA: 0x0081BF00 File Offset: 0x0081A100
	private void OnForceReleaseInput(string reason)
	{
		if (this.PressingSprint)
		{
			AkiClient.Game.Aki.Character.Input.Enum.EInputAction einputAction;
			string text = this.CommandActionMap.TryGetValue(ECommandType.Sprint, out einputAction) ? einputAction.ToString() : null;
			if (text != null)
			{
				InputDistributeController.Instance.InputAction(text, false);
			}
		}
		if (this.PressingBackBraking)
		{
			AkiClient.Game.Aki.Character.Input.Enum.EInputAction einputAction2;
			string text2 = this.CommandActionMap.TryGetValue(ECommandType.Jump, out einputAction2) ? einputAction2.ToString() : null;
			if (text2 != null)
			{
				InputDistributeController.Instance.InputAction(text2, false);
			}
		}
	}

	// Token: 0x0601A36C RID: 107372 RVA: 0x0081BF80 File Offset: 0x0081A180
	private void OnViewShow(EUiViewName viewName, int _)
	{
		UiShow? uiShowConfig = UiViewConfig.Instance.GetUiShowConfig(viewName);
		if (uiShowConfig != null && !uiShowConfig.Value.AllowAutoMotor)
		{
			this.ResetAssistInput("打开了UI" + viewName, true, true);
		}
	}

	// Token: 0x0601A36D RID: 107373 RVA: 0x0081BFCB File Offset: 0x0081A1CB
	[NullableContext(2)]
	public MotorcycleInputComponent.NitroBoostInfo GetNitroBoostInfo()
	{
		return this.NitroBoostInfo1;
	}

	// Token: 0x0601A36E RID: 107374 RVA: 0x0081BFD3 File Offset: 0x0081A1D3
	[NullableContext(2)]
	public MotorcycleInputComponent.HoldThrottleInfo GetHoldThrottleInfo()
	{
		return this.HoldThrottleInfo1;
	}

	// Token: 0x0601A36F RID: 107375 RVA: 0x0081BFDB File Offset: 0x0081A1DB
	[NullableContext(2)]
	public void ExternalResetAssistInput(string context = null, bool nitro = true, bool throttle = true)
	{
		this.ResetAssistInput(context, nitro, throttle);
	}

	// Token: 0x0601A370 RID: 107376 RVA: 0x0081BFE8 File Offset: 0x0081A1E8
	public static void ConvertCycleInputToSquared(global::Vector inInput, global::Vector outInput)
	{
		double num = inInput.Size();
		if (num <= 0.0001)
		{
			outInput.DeepCopy(inInput);
			return;
		}
		inInput.Multiply(num / Math.Max(Math.Abs(inInput.X), Math.Abs(inInput.Y)), outInput);
	}

	// Token: 0x0601A371 RID: 107377 RVA: 0x0081C038 File Offset: 0x0081A238
	public static bool ConvertPolarInput(global::Vector inInput, global::Vector outInput, double positiveLimit, double negativeLimit, bool prevIsPositive)
	{
		if (inInput.IsNearlyZero(9.999999747378752E-05))
		{
			outInput.Reset();
			return true;
		}
		double value = Rotator.NormalizeAxis(Math.Atan2(inInput.Y, inInput.X) * 57.295780181884766);
		double num = Math.Abs(value);
		double num2 = (double)Math.Sign(value);
		if (num < positiveLimit)
		{
			outInput.X = inInput.Size();
			outInput.Y = num2 * (num / positiveLimit);
			return true;
		}
		if (num < negativeLimit)
		{
			outInput.X = inInput.Size() * (double)(prevIsPositive ? 1 : -1);
			outInput.Y = num2;
			return prevIsPositive;
		}
		outInput.X = -inInput.Size();
		outInput.Y = num2 * ((180.0 - num) / (180.0 - negativeLimit));
		return false;
	}

	// Token: 0x0601A372 RID: 107378 RVA: 0x0081C0FC File Offset: 0x0081A2FC
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		MotorcycleInputComponent motorcycleInputComponent = (MotorcycleInputComponent)componentTemplate;
		this.IsDriving = motorcycleInputComponent.IsDriving;
		if (motorcycleInputComponent.PlayerMotorInput != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PlayerMotorInput), "PlayerMotorInput"))
		{
			return false;
		}
		if (motorcycleInputComponent.NitroBoostInfo1 == null)
		{
			this.NitroBoostInfo1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.NitroBoostInfo1), "NitroBoostInfo1"))
		{
			return false;
		}
		if (motorcycleInputComponent.HoldThrottleInfo1 == null)
		{
			this.HoldThrottleInfo1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.HoldThrottleInfo1), "HoldThrottleInfo1"))
		{
			return false;
		}
		if (motorcycleInputComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (motorcycleInputComponent.AudioComp == null)
		{
			this.AudioComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AudioComp), "AudioComp"))
		{
			return false;
		}
		this.LastInputSeconds = motorcycleInputComponent.LastInputSeconds;
		if (motorcycleInputComponent.TmpVector1 == null)
		{
			this.TmpVector1 = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector1), "TmpVector1"))
		{
			return false;
		}
		if (motorcycleInputComponent.MotorInputCache == null)
		{
			this.MotorInputCache = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MotorInputCache), "MotorInputCache"))
		{
			return false;
		}
		this.PressingBackBraking = motorcycleInputComponent.PressingBackBraking;
		this.PressingSprint = motorcycleInputComponent.PressingSprint;
		this.InSprintInternal = motorcycleInputComponent.InSprintInternal;
		this.BannedSprint = motorcycleInputComponent.BannedSprint;
		this.InBackBrakingInternal = motorcycleInputComponent.InBackBrakingInternal;
		this.BannedBackBraking = motorcycleInputComponent.BannedBackBraking;
		this.MotorJoyStickAngle1 = motorcycleInputComponent.MotorJoyStickAngle1;
		this.MotorJoyStickAngle2 = motorcycleInputComponent.MotorJoyStickAngle2;
		this.PrevIsPositive = motorcycleInputComponent.PrevIsPositive;
		this.AirRotateInput = motorcycleInputComponent.AirRotateInput;
		if (motorcycleInputComponent.CommandIndexMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommandIndexMap), "CommandIndexMap"))
		{
			return false;
		}
		if (motorcycleInputComponent.CommandPriorityMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommandPriorityMap), "CommandPriorityMap"))
		{
			return false;
		}
		if (motorcycleInputComponent.CommandActionMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CommandActionMap), "CommandActionMap"))
		{
			return false;
		}
		this.DebugAssistDrift = motorcycleInputComponent.DebugAssistDrift;
		return true;
	}

	// Token: 0x17002AD0 RID: 10960
	// (get) Token: 0x0601A373 RID: 107379 RVA: 0x0081C342 File Offset: 0x0081A542
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AD1 RID: 10961
	// (get) Token: 0x0601A374 RID: 107380 RVA: 0x0081C345 File Offset: 0x0081A545
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AD2 RID: 10962
	// (get) Token: 0x0601A375 RID: 107381 RVA: 0x0081C348 File Offset: 0x0081A548
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AD3 RID: 10963
	// (get) Token: 0x0601A376 RID: 107382 RVA: 0x0081C34B File Offset: 0x0081A54B
	public override bool NeedDisableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002AD4 RID: 10964
	// (get) Token: 0x0601A377 RID: 107383 RVA: 0x0081C34E File Offset: 0x0081A54E
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E5FE RID: 58878
	private const string ASSIST_INPUT_DATA_ASSET_PATH = "/Game/Aki/Character/Vehicle/Motor/Data/DA/DA_MotorAssistInputConfig.DA_MotorAssistInputConfig";

	// Token: 0x0400E5FF RID: 58879
	private bool IsDriving;

	// Token: 0x0400E600 RID: 58880
	private readonly global::Vector PlayerMotorInput = global::Vector.Create();

	// Token: 0x0400E601 RID: 58881
	[Nullable(2)]
	private MotorcycleInputComponent.NitroBoostInfo NitroBoostInfo1;

	// Token: 0x0400E602 RID: 58882
	[Nullable(2)]
	private MotorcycleInputComponent.HoldThrottleInfo HoldThrottleInfo1;

	// Token: 0x0400E603 RID: 58883
	[Nullable(2)]
	protected MotorcycleMoveComponent MoveComp;

	// Token: 0x0400E604 RID: 58884
	[Nullable(2)]
	protected MotorcycleAudioComponent AudioComp;

	// Token: 0x0400E605 RID: 58885
	public double LastInputSeconds;

	// Token: 0x0400E606 RID: 58886
	protected global::Vector TmpVector1 = global::Vector.Create();

	// Token: 0x0400E607 RID: 58887
	protected global::Vector MotorInputCache = global::Vector.Create();

	// Token: 0x0400E608 RID: 58888
	protected bool PressingBackBraking;

	// Token: 0x0400E609 RID: 58889
	protected bool PressingSprint;

	// Token: 0x0400E60A RID: 58890
	protected bool InSprintInternal;

	// Token: 0x0400E60B RID: 58891
	private bool BannedSprint;

	// Token: 0x0400E60C RID: 58892
	protected bool InBackBrakingInternal;

	// Token: 0x0400E60D RID: 58893
	private bool BannedBackBraking;

	// Token: 0x0400E60E RID: 58894
	private double MotorJoyStickAngle1 = 60.0;

	// Token: 0x0400E60F RID: 58895
	private double MotorJoyStickAngle2 = 120.0;

	// Token: 0x0400E610 RID: 58896
	private bool PrevIsPositive = true;

	// Token: 0x0400E611 RID: 58897
	public double AirRotateInput;

	// Token: 0x0400E612 RID: 58898
	private readonly Dictionary<ECommandType, int> CommandIndexMap = new Dictionary<ECommandType, int>();

	// Token: 0x0400E613 RID: 58899
	private readonly Dictionary<ECommandType, int> CommandPriorityMap = new Dictionary<ECommandType, int>();

	// Token: 0x0400E614 RID: 58900
	private readonly Dictionary<ECommandType, AkiClient.Game.Aki.Character.Input.Enum.EInputAction> CommandActionMap = new Dictionary<ECommandType, AkiClient.Game.Aki.Character.Input.Enum.EInputAction>();

	// Token: 0x0400E615 RID: 58901
	private bool DebugAssistDrift;

	// Token: 0x020089A7 RID: 35239
	[Nullable(0)]
	public class AssistedInputInfo
	{
		// Token: 0x060429F3 RID: 272883 RVA: 0x013C86D0 File Offset: 0x013C68D0
		public AssistedInputInfo(BaseTagComponent tagComp, int gameplayTag)
		{
			this.GameplayTag = gameplayTag;
			this.TagComp = tagComp;
		}

		// Token: 0x060429F4 RID: 272884 RVA: 0x013C8721 File Offset: 0x013C6921
		public virtual void InitConfig(BP_MotorAssistInputConfig_C asset)
		{
		}

		// Token: 0x060429F5 RID: 272885 RVA: 0x013C8723 File Offset: 0x013C6923
		public virtual bool UpdateAutoState()
		{
			return false;
		}

		// Token: 0x060429F6 RID: 272886 RVA: 0x013C8726 File Offset: 0x013C6926
		public void SetAutoState(bool value)
		{
			if (value == this.LastState)
			{
				return;
			}
			this.LastState = value;
			this.UpdateAutoTag(value);
		}

		// Token: 0x060429F7 RID: 272887 RVA: 0x013C8740 File Offset: 0x013C6940
		public void AddTimeAccumulation(double delta)
		{
			if (!this.CheckForbiddenTag())
			{
				this.ClearTimeAccumulation();
				return;
			}
			this.CurrentTime += delta;
		}

		// Token: 0x060429F8 RID: 272888 RVA: 0x013C875F File Offset: 0x013C695F
		public void ClearTimeAccumulation()
		{
			this.CurrentTime = 0.0;
		}

		// Token: 0x060429F9 RID: 272889 RVA: 0x013C8770 File Offset: 0x013C6970
		[NullableContext(2)]
		public void ResetAutoState(string context = null)
		{
			this.ClearTimeAccumulation();
			this.SetAutoState(false);
		}

		// Token: 0x060429FA RID: 272890 RVA: 0x013C8781 File Offset: 0x013C6981
		public bool CheckTimeDuration()
		{
			return this.CurrentTime > this.Duration;
		}

		// Token: 0x060429FB RID: 272891 RVA: 0x013C8791 File Offset: 0x013C6991
		public double GetCurrentTime()
		{
			return this.CurrentTime;
		}

		// Token: 0x060429FC RID: 272892 RVA: 0x013C8799 File Offset: 0x013C6999
		public double GetDuration()
		{
			return this.Duration;
		}

		// Token: 0x060429FD RID: 272893 RVA: 0x013C87A4 File Offset: 0x013C69A4
		private bool CheckForbiddenTag()
		{
			if (this.TagList != null && this.TagList.Count > 0)
			{
				foreach (int tagId in this.TagList)
				{
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp != null && tagComp.HasTag(tagId))
					{
						return false;
					}
				}
				return true;
			}
			return true;
		}

		// Token: 0x060429FE RID: 272894 RVA: 0x013C8824 File Offset: 0x013C6A24
		public bool CheckPermitSkill(int skillId)
		{
			return this.SkillList.Contains((long)skillId);
		}

		// Token: 0x060429FF RID: 272895 RVA: 0x013C8833 File Offset: 0x013C6A33
		public bool IsStartEnter()
		{
			return this.StartEnter;
		}

		// Token: 0x06042A00 RID: 272896 RVA: 0x013C883B File Offset: 0x013C6A3B
		public void SetStartEnter(bool value)
		{
			this.StartEnter = value;
		}

		// Token: 0x06042A01 RID: 272897 RVA: 0x013C8844 File Offset: 0x013C6A44
		public bool IsIgnoreInput()
		{
			return this.IgnoreInput;
		}

		// Token: 0x06042A02 RID: 272898 RVA: 0x013C884C File Offset: 0x013C6A4C
		public void SetIgnoreInput(bool value)
		{
			this.IgnoreInput = value;
		}

		// Token: 0x06042A03 RID: 272899 RVA: 0x013C8855 File Offset: 0x013C6A55
		protected bool CheckGameplayTag()
		{
			BaseTagComponent tagComp = this.TagComp;
			return tagComp != null && tagComp.HasTag(this.GameplayTag) && this.CheckForbiddenTag();
		}

		// Token: 0x06042A04 RID: 272900 RVA: 0x013C887C File Offset: 0x013C6A7C
		protected void UpdateAutoTag(bool value)
		{
			if (value)
			{
				BaseTagComponent tagComp = this.TagComp;
				if (tagComp == null || !tagComp.HasTag(this.GameplayTag))
				{
					BaseTagComponent tagComp2 = this.TagComp;
					if (tagComp2 != null)
					{
						tagComp2.AddTag(new int?(this.GameplayTag));
					}
				}
			}
			if (!value)
			{
				BaseTagComponent tagComp3 = this.TagComp;
				if (tagComp3 != null && tagComp3.HasTag(this.GameplayTag))
				{
					BaseTagComponent tagComp4 = this.TagComp;
					if (tagComp4 == null)
					{
						return;
					}
					tagComp4.RemoveTag(new int?(this.GameplayTag));
				}
			}
		}

		// Token: 0x0402BD88 RID: 179592
		protected bool LastState;

		// Token: 0x0402BD89 RID: 179593
		protected double CurrentTime;

		// Token: 0x0402BD8A RID: 179594
		private bool StartEnter;

		// Token: 0x0402BD8B RID: 179595
		private bool IgnoreInput;

		// Token: 0x0402BD8C RID: 179596
		protected double Duration = 3.402823466E+38;

		// Token: 0x0402BD8D RID: 179597
		protected readonly List<int> TagList = new List<int>();

		// Token: 0x0402BD8E RID: 179598
		protected readonly List<long> SkillList = new List<long>();

		// Token: 0x0402BD8F RID: 179599
		protected string DebugText = "";

		// Token: 0x0402BD90 RID: 179600
		[Nullable(2)]
		protected BaseTagComponent TagComp;

		// Token: 0x0402BD91 RID: 179601
		protected int GameplayTag;
	}

	// Token: 0x020089A8 RID: 35240
	[Nullable(0)]
	public class NitroBoostInfo : MotorcycleInputComponent.AssistedInputInfo
	{
		// Token: 0x06042A05 RID: 272901 RVA: 0x013C88FE File Offset: 0x013C6AFE
		public NitroBoostInfo(BaseTagComponent tagComp, int gameplayTag) : base(tagComp, gameplayTag)
		{
			this.DebugText = "氮气维持";
		}

		// Token: 0x06042A06 RID: 272902 RVA: 0x013C8914 File Offset: 0x013C6B14
		public override bool UpdateAutoState()
		{
			bool flag = this.GetSettingEnable() && base.CheckGameplayTag();
			if (this.LastState && !flag)
			{
				base.ResetAutoState("不满足默认条件");
			}
			return flag;
		}

		// Token: 0x06042A07 RID: 272903 RVA: 0x013C894A File Offset: 0x013C6B4A
		public bool GetSettingEnable()
		{
			return BattleUiModel.Instance.MotorcycleData.AutoNitrogenSettingEnable || this.DebugEnable;
		}

		// Token: 0x06042A08 RID: 272904 RVA: 0x013C8968 File Offset: 0x013C6B68
		public override void InitConfig(BP_MotorAssistInputConfig_C asset)
		{
			this.Duration = (double)asset.NitroBoostTime;
			this.DebugEnable = asset.DebugNitroBoost;
			for (int i = 0; i < asset.ForbidNitroBoostTag.GameplayTags.Num(); i++)
			{
				this.TagList.Add(asset.ForbidNitroBoostTag.GameplayTags.Get(i).TagId());
			}
			for (int j = 0; j < asset.NitroBoostSkill.Num(); j++)
			{
				this.SkillList.Add((long)asset.NitroBoostSkill.Get(j));
			}
		}

		// Token: 0x0402BD92 RID: 179602
		private bool DebugEnable;
	}

	// Token: 0x020089A9 RID: 35241
	[Nullable(0)]
	public class HoldThrottleInfo : MotorcycleInputComponent.AssistedInputInfo
	{
		// Token: 0x06042A09 RID: 272905 RVA: 0x013C89F8 File Offset: 0x013C6BF8
		public HoldThrottleInfo(BaseTagComponent tagComp, int gameplayTag) : base(tagComp, gameplayTag)
		{
			this.DebugText = "油门维持";
		}

		// Token: 0x06042A0A RID: 272906 RVA: 0x013C8A10 File Offset: 0x013C6C10
		public override bool UpdateAutoState()
		{
			bool flag = this.GetSettingEnable() && base.CheckGameplayTag();
			if (this.LastState && !flag)
			{
				base.ResetAutoState("不满足默认条件");
			}
			return flag;
		}

		// Token: 0x06042A0B RID: 272907 RVA: 0x013C8A46 File Offset: 0x013C6C46
		public bool GetSettingEnable()
		{
			return BattleUiModel.Instance.MotorcycleData.AutoAcceleratorSettingEnable || this.DebugEnable;
		}

		// Token: 0x06042A0C RID: 272908 RVA: 0x013C8A64 File Offset: 0x013C6C64
		public override void InitConfig(BP_MotorAssistInputConfig_C asset)
		{
			this.Duration = (double)asset.HoldThrottleTime;
			this.DebugEnable = asset.DebugHoldThrottle;
			for (int i = 0; i < asset.ForbidHoldThrottleTag.GameplayTags.Num(); i++)
			{
				this.TagList.Add(asset.ForbidHoldThrottleTag.GameplayTags.Get(i).TagId());
			}
			for (int j = 0; j < asset.HoldThrottleSkill.Num(); j++)
			{
				this.SkillList.Add((long)asset.HoldThrottleSkill.Get(j));
			}
		}

		// Token: 0x0402BD93 RID: 179603
		private bool DebugEnable;
	}
}
