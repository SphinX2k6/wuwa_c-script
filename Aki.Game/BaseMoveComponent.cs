using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.LevelGamePlay;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02003037 RID: 12343
[NullableContext(1)]
[Nullable(0)]
public class BaseMoveComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x0601A264 RID: 107108 RVA: 0x006DECE5 File Offset: 0x006DCEE5
	static BaseMoveComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseMoveComponent.CreateStaticDefaultValue), new Action(BaseMoveComponent.ResetStaticDefaultValue));
	}

	// Token: 0x170023F9 RID: 9209
	// (get) Token: 0x0601A265 RID: 107109 RVA: 0x006DED04 File Offset: 0x006DCF04
	[Nullable(2)]
	protected static UCurveFloat BaseMoveInheritCurve
	{
		[NullableContext(2)]
		get
		{
			if (BaseMoveComponent.BaseMoveInheritCurveInternal == null)
			{
				BaseMoveComponent.BaseMoveInheritCurveInternal = ResourceSystem.Instance.GetLoadedAsset<UCurveFloat>("/Game/Aki/Character/BaseCharacter/Curves/CURVE_HorizontalVelocity.CURVE_HorizontalVelocity");
			}
			return BaseMoveComponent.BaseMoveInheritCurveInternal;
		}
	}

	// Token: 0x0601A266 RID: 107110 RVA: 0x006DED28 File Offset: 0x006DCF28
	public global::Vector ClampOffsetByChain(global::Vector offset)
	{
		if (this.ConfigChainLengthSquared < 0.0)
		{
			return offset;
		}
		double num = Math.Sqrt(this.ConfigChainLengthSquared);
		global::Vector chainTempPredicted = this.ChainTempPredicted;
		this.ActorComp.ActorLocationProxy.Addition(offset, chainTempPredicted);
		global::Vector chainTempToCenter = this.ChainTempToCenter;
		this.ChainCenter.Subtraction(chainTempPredicted, chainTempToCenter);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, chainTempToCenter);
		double num2 = chainTempToCenter.SizeSquared();
		if (num2 > this.ConfigChainLengthSquared)
		{
			double num3 = Math.Sqrt(num2);
			double num4 = num3 - num;
			chainTempToCenter.MultiplyEqual(num4 / num3);
			offset.AdditionEqual(chainTempToCenter);
		}
		return offset;
	}

	// Token: 0x0601A267 RID: 107111 RVA: 0x006DEDC8 File Offset: 0x006DCFC8
	public void SetForceSpeed(IVector speed)
	{
		if (speed.ContainsNaN())
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "SetForceSpeed Contains NaN";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("speed", speed);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		this.ForceSpeed.DeepCopy(speed);
		if (this.ActorComp != null)
		{
			this.ActorComp.SetActorVelocity(this.ForceSpeed);
			this.ActorComp.ResetCachedVelocityTime();
		}
	}

	// Token: 0x170023FA RID: 9210
	// (get) Token: 0x0601A268 RID: 107112 RVA: 0x006DEE33 File Offset: 0x006DD033
	public bool IsJump
	{
		get
		{
			return this.JumpFrameCount > 0;
		}
	}

	// Token: 0x170023FB RID: 9211
	// (get) Token: 0x0601A269 RID: 107113 RVA: 0x006DEE3E File Offset: 0x006DD03E
	// (set) Token: 0x0601A26A RID: 107114 RVA: 0x006DEE48 File Offset: 0x006DD048
	[Nullable(2)]
	public SMovementSetting CurrentMovementSettings
	{
		[NullableContext(2)]
		get
		{
			return this.CurrentMovementSettingsInternal;
		}
		[NullableContext(2)]
		protected set
		{
			this.CurrentMovementSettingsInternal = value;
			this.CurrentMovementRotationSetting.UpdateSettings(value.ControllerRotationSpeedSetting);
			if (this.CharacterMovement != null && value != null)
			{
				UCharacterMovementComponent characterMovement = this.CharacterMovement;
				FKuroMovementSetting fkuroMovementSetting = new FKuroMovementSetting(value.Acceleration, value.ControllerRotationSpeed, new FKuroMovementRotationSetting(value.ControllerRotationSpeedSetting.最大旋转速度, value.ControllerRotationSpeedSetting.最大角度差, value.ControllerRotationSpeedSetting.最小旋转速度, value.ControllerRotationSpeedSetting.最小角度差, (int)value.ControllerRotationSpeedSetting.渐变曲线.CurveType, value.ControllerRotationSpeedSetting.渐变曲线.N), value.FastSwimSpeed, value.GroundFriction, value.MovementCurve, value.NormalSwimSpeed, value.RotationRateCurve, value.RunSpeed, value.SprintSpeed, value.SwingAcceleration, value.SwingSpeed, value.WalkSpeed);
				characterMovement.SetKuroMovementSettings(fkuroMovementSetting);
			}
		}
	}

	// Token: 0x0601A26B RID: 107115 RVA: 0x006DEF35 File Offset: 0x006DD135
	public void SetGravityDirectWithoutRotate(IVector v)
	{
		this.SetGravityDirectWithoutRotateByNumber(v.X, v.Y, v.Z);
	}

	// Token: 0x0601A26C RID: 107116 RVA: 0x006DEF50 File Offset: 0x006DD150
	public void SetGravityDirectWithoutRotateByNumber(double x, double y, double z)
	{
		this.TmpVector.X = x;
		this.TmpVector.Y = y;
		this.TmpVector.Z = z;
		if (!this.TmpVector.Normalize(9.99999993922529E-09))
		{
			return;
		}
		if (this.GravityDirectInternal.Equals(this.TmpVector, 9.999999747378752E-05))
		{
			return;
		}
		this.IsStandardGravityInternal = MathUtils.Instance.IsNearlyEqual(this.TmpVector.Z, -1.0, null);
		if (this.IsStandardGravityInternal)
		{
			this.GravityDirectInternal.Set(0.0, 0.0, -1.0);
		}
		else
		{
			this.GravityDirectInternal.DeepCopy(this.TmpVector);
		}
		this.GravityDirectInternal.UnaryNegation(this.GravityUpInternal);
		if (this.CharacterMovement != null)
		{
			this.CharacterMovement.Kuro_SetGravityDirect(this.GravityDirectInternal.ToUeVectorOld());
		}
		this.ActorComp.ResetGravityRelatedCachedTime();
		EventSystem.Instance.EmitWithTarget<global::Vector, bool>(base.Entity, EEventName.CharGravityDirectChanged, this.GravityDirect, this.IsStandardGravity);
		EventSystem.Instance.Emit<Entity, global::Vector, bool>(EEventName.AnyCharGravityDirectChanged, base.Entity, this.GravityDirect, this.IsStandardGravity);
	}

	// Token: 0x0601A26D RID: 107117 RVA: 0x006DF0A4 File Offset: 0x006DD2A4
	public void SetGravityDirectByNumber(double x, double y, double z, bool clearGround = true, float overrideSmoothTime = -1f)
	{
		this.TmpVector.X = x;
		this.TmpVector.Y = y;
		this.TmpVector.Z = z;
		if (!this.TmpVector.Normalize(9.99999993922529E-09))
		{
			return;
		}
		if (this.GravityDirectInternal.Equals(this.TmpVector, 9.999999747378752E-05))
		{
			return;
		}
		float timeLength = (float)((overrideSmoothTime > 0f) ? ((double)overrideSmoothTime) : (Math.Acos(global::Vector.DotProduct(this.GravityDirectInternal, this.TmpVector)) / 3.141592653589793 * 500.0));
		Quat.FindBetween(this.GravityDirectInternal, this.TmpVector, this.TmpQuat);
		this.IsStandardGravityInternal = MathUtils.Instance.IsNearlyEqual(this.TmpVector.Z, -1.0, null);
		if (this.IsStandardGravityInternal)
		{
			this.GravityDirectInternal.Set(0.0, 0.0, -1.0);
		}
		else
		{
			this.GravityDirectInternal.DeepCopy(this.TmpVector);
		}
		this.GravityDirectInternal.UnaryNegation(this.GravityUpInternal);
		if (this.CharacterMovement != null)
		{
			this.CharacterMovement.Kuro_SetGravityDirect(this.GravityDirectInternal.ToUeVectorOld());
			if (clearGround)
			{
				BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
				if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Ground)
				{
					CharacterActorComponent actorComp = this.ActorComp;
					if (actorComp != null)
					{
						actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
						{
							Mode = EMovementMode.MOVE_Falling,
							Context = "[BaseMoveComponent.SetGravityDirectByNumber]"
						});
					}
				}
			}
		}
		if (this.ActorComp.ActorUpProxy.DotProduct(this.TmpVector) > -0.9999)
		{
			this.TmpQuat.RotateVector(global::Vector.UpVectorProxy, this.TmpVector);
			this.TmpQuat.Multiply(this.ActorComp.ActorQuatProxy, this.TmpQuat2);
			this.TmpQuat2.Rotator(this.TmpRotator);
			if (this.AnimComp != null)
			{
				this.AnimComp.SetLocationAndRotatorWithModelBuffer(this.ActorComp.ActorLocationProxy.ToUeVector(false), this.TmpRotator.ToUeRotator(), timeLength, "SetGravity", ESetRotationPriority.Anim, true);
			}
			else
			{
				this.ActorComp.SetActorRotation(this.TmpRotator.ToUeRotator(), "SetGravity", false);
			}
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null && actorComp2.IsRoleAndCtrlByMe)
			{
				CharacterInputComponent component = base.Entity.GetComponent<CharacterInputComponent>();
				if (component == null || !component.IsLocalInput)
				{
					this.TmpQuat.RotateVector(this.ActorComp.InputDirectProxy, this.TmpVector);
					this.ActorComp.SetInputDirect(this.TmpVector, true);
					this.TmpQuat.RotateVector(this.ActorComp.InputFacingProxy, this.TmpVector);
					this.ActorComp.SetInputFacing(this.TmpVector, true);
					goto IL_303;
				}
			}
			this.ActorComp.ClearInput(false, true);
		}
		else
		{
			this.ActorComp.ClearInput(false, true);
		}
		IL_303:
		this.ActorComp.ResetGravityRelatedCachedTime();
		EventSystem.Instance.EmitWithTarget<global::Vector, bool>(base.Entity, EEventName.CharGravityDirectChanged, this.GravityDirect, this.IsStandardGravity);
		EventSystem.Instance.Emit<Entity, global::Vector, bool>(EEventName.AnyCharGravityDirectChanged, base.Entity, this.GravityDirect, this.IsStandardGravity);
	}

	// Token: 0x0601A26E RID: 107118 RVA: 0x006DF403 File Offset: 0x006DD603
	public void SetGravityDirect(IVector v)
	{
		this.SetGravityDirectByNumber(v.X, v.Y, v.Z, true, -1f);
	}

	// Token: 0x0601A26F RID: 107119 RVA: 0x006DF423 File Offset: 0x006DD623
	public void SetGravityDirect(Aki.Protocol.Vector v)
	{
		this.SetGravityDirectByNumber((double)v.X, (double)v.Y, (double)v.Z, true, -1f);
	}

	// Token: 0x170023FC RID: 9212
	// (get) Token: 0x0601A270 RID: 107120 RVA: 0x006DF446 File Offset: 0x006DD646
	public global::Vector GravityDirect
	{
		get
		{
			return this.GravityDirectInternal;
		}
	}

	// Token: 0x170023FD RID: 9213
	// (get) Token: 0x0601A271 RID: 107121 RVA: 0x006DF450 File Offset: 0x006DD650
	public global::Vector GravityUp
	{
		get
		{
			if (this.GravityUpInternal.Equals(global::Vector.ZeroVectorProxy, 9.999999747378752E-05))
			{
				Log.Instance.Error(ELogModule.Movement, ELogAuthor.YZ, "GravityUp is zero", default(ReadOnlySpan<ValueTuple<string, object>>));
				return global::Vector.UpVectorProxy;
			}
			return this.GravityUpInternal;
		}
	}

	// Token: 0x170023FE RID: 9214
	// (get) Token: 0x0601A272 RID: 107122 RVA: 0x006DF49F File Offset: 0x006DD69F
	public bool IsStandardGravity
	{
		get
		{
			return this.IsStandardGravityInternal;
		}
	}

	// Token: 0x170023FF RID: 9215
	// (get) Token: 0x0601A274 RID: 107124 RVA: 0x006DF4B7 File Offset: 0x006DD6B7
	// (set) Token: 0x0601A273 RID: 107123 RVA: 0x006DF4A7 File Offset: 0x006DD6A7
	public float AccelerationLerpTime
	{
		get
		{
			return this.DesireMaxAccelerationLerpTime;
		}
		set
		{
			this.DesireMaxAccelerationLerpTime = value;
			this.MaxAccelerationLerpTime = value;
		}
	}

	// Token: 0x0601A275 RID: 107125 RVA: 0x006DF4BF File Offset: 0x006DD6BF
	public void SetFallingHorizontalMaxSpeed(float v)
	{
		this.FallingHorizontalMaxSpeed = v;
	}

	// Token: 0x0601A276 RID: 107126 RVA: 0x006DF4C8 File Offset: 0x006DD6C8
	public void ClearFallingHorizontalMaxSpeed()
	{
		this.FallingHorizontalMaxSpeed = 700f;
	}

	// Token: 0x0601A277 RID: 107127 RVA: 0x006DF4D8 File Offset: 0x006DD6D8
	protected override bool OnInit()
	{
		this.IsStandardGravityInternal = true;
		this.GravityDirectInternal.Set(0.0, 0.0, -1.0);
		this.GravityUpInternal.Set(0.0, 0.0, 1.0);
		return true;
	}

	// Token: 0x0601A278 RID: 107128 RVA: 0x006DF539 File Offset: 0x006DD739
	protected override bool OnStart()
	{
		this.TimeScaleComp = base.Entity.GetComponent<PawnTimeScaleComponent>();
		return true;
	}

	// Token: 0x0601A279 RID: 107129 RVA: 0x006DF54D File Offset: 0x006DD74D
	public void SetUseDebugMovementSetting(bool newSelect)
	{
		this.UseDebugMovementSetting = newSelect;
	}

	// Token: 0x0601A27A RID: 107130 RVA: 0x006DF556 File Offset: 0x006DD756
	public void SetDebugMovementSetting(SMovementSetting newSetting)
	{
		this.DebugMovementSetting = newSetting;
	}

	// Token: 0x0601A27B RID: 107131 RVA: 0x006DF55F File Offset: 0x006DD75F
	public void ApplyDebugMovementSetting()
	{
		this.CurrentMovementSettings = this.DebugMovementSetting;
	}

	// Token: 0x0601A27C RID: 107132 RVA: 0x006DF570 File Offset: 0x006DD770
	protected void ResetMovementSettingByDirectionState(ECharDirectionState? newDirectionState)
	{
		if (newDirectionState != null)
		{
			switch (newDirectionState.GetValueOrDefault())
			{
			case ECharDirectionState.LockDirection:
				this.CurrentMovementSettings = this.MovementData.LockDirection.Standing;
				return;
			case ECharDirectionState.AimDirection:
				this.CurrentMovementSettings = this.MovementData.AimDirection.Standing;
				break;
			case ECharDirectionState.FaceDirection:
				this.CurrentMovementSettings = this.MovementData.FaceDirection.Standing;
				return;
			default:
				return;
			}
		}
	}

	// Token: 0x0601A27D RID: 107133 RVA: 0x006DF5E8 File Offset: 0x006DD7E8
	protected void ResetMovementSetting(ECharDirectionState? newDirectionState)
	{
		if (this.MovementData == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Character;
			ELogAuthor author = ELogAuthor.LJM;
			string message = "以下BP_{Character}没有在蓝图中配置Dt_BaseMovementSetting找对应的蓝图负责人处理";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Character", this.ActorComp.Actor.GetName());
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return;
		}
		if (this.UseDebugMovementSetting)
		{
			this.ApplyDebugMovementSetting();
			return;
		}
		this.ResetMovementSettingByDirectionState(newDirectionState);
	}

	// Token: 0x0601A27E RID: 107134 RVA: 0x006DF650 File Offset: 0x006DD850
	public void ResetMaxSpeed(global::ECharMoveState? newMoveState)
	{
		if (this.SpeedLockFrame > 0)
		{
			return;
		}
		float maxFixSpeed = this.ActorComp.Actor.TsCharacterDebugComponent.MaxFixSpeed;
		if (newMoveState != null)
		{
			global::ECharMoveState valueOrDefault = newMoveState.GetValueOrDefault();
			switch (valueOrDefault)
			{
			case global::ECharMoveState.Walk:
			{
				float num = maxFixSpeed;
				SMovementSetting currentMovementSettings = this.CurrentMovementSettings;
				this.SetMaxSpeed(num + ((currentMovementSettings != null) ? currentMovementSettings.WalkSpeed : 0f));
				return;
			}
			case global::ECharMoveState.WalkStop:
			case global::ECharMoveState.RunStop:
				break;
			case global::ECharMoveState.Run:
			{
				float num2 = maxFixSpeed;
				SMovementSetting currentMovementSettings2 = this.CurrentMovementSettings;
				this.SetMaxSpeed(num2 + ((currentMovementSettings2 != null) ? currentMovementSettings2.RunSpeed : 0f));
				return;
			}
			case global::ECharMoveState.Sprint:
			{
				float num3 = maxFixSpeed;
				SMovementSetting currentMovementSettings3 = this.CurrentMovementSettings;
				this.SetMaxSpeed(num3 + ((currentMovementSettings3 != null) ? currentMovementSettings3.SprintSpeed : 0f));
				return;
			}
			default:
				if (valueOrDefault == global::ECharMoveState.Swing)
				{
					float num4 = maxFixSpeed;
					SMovementSetting currentMovementSettings4 = this.CurrentMovementSettings;
					this.SetMaxSpeed(num4 + ((currentMovementSettings4 != null) ? currentMovementSettings4.SwingSpeed : 0f));
					return;
				}
				break;
			}
		}
		float num5 = maxFixSpeed;
		SMovementSetting currentMovementSettings5 = this.CurrentMovementSettings;
		this.SetMaxSpeed(num5 + ((currentMovementSettings5 != null) ? currentMovementSettings5.RunSpeed : 0f));
	}

	// Token: 0x0601A27F RID: 107135 RVA: 0x006DF750 File Offset: 0x006DD950
	public virtual void SetMaxSpeed(float newSpeed)
	{
		float num = newSpeed;
		if (this.OverrideMaxSpeed > 0f)
		{
			num = this.OverrideMaxSpeed;
		}
		float num2 = 10000f;
		num2 /= 10000f;
		float num3 = num * num2;
		if (this.CharacterMovement.MovementMode == EMovementMode.MOVE_Flying)
		{
			this.CharacterMovement.MaxFlySpeed = num3;
			return;
		}
		this.CharacterMovement.MaxWalkSpeed = num3;
	}

	// Token: 0x0601A280 RID: 107136 RVA: 0x006DF7B8 File Offset: 0x006DD9B8
	public void ResetCharacterMovementInfo(global::ECharMoveState? newMoveState)
	{
		this.CharacterMovement.MaxWalkSpeedCrouched = this.CharacterMovement.MaxWalkSpeed;
		if (newMoveState.GetValueOrDefault() == global::ECharMoveState.Swing)
		{
			UCharacterMovementComponent characterMovement = this.CharacterMovement;
			SMovementSetting currentMovementSettings = this.CurrentMovementSettings;
			characterMovement.MaxAcceleration = ((currentMovementSettings != null) ? currentMovementSettings.SwingAcceleration : 0f);
		}
		else
		{
			UCharacterMovementComponent characterMovement2 = this.CharacterMovement;
			SMovementSetting currentMovementSettings2 = this.CurrentMovementSettings;
			characterMovement2.MaxAcceleration = ((currentMovementSettings2 != null) ? currentMovementSettings2.Acceleration : 0f);
		}
		UCharacterMovementComponent characterMovement3 = this.CharacterMovement;
		SMovementSetting currentMovementSettings3 = this.CurrentMovementSettings;
		characterMovement3.GroundFriction = ((currentMovementSettings3 != null) ? currentMovementSettings3.GroundFriction : 0f);
	}

	// Token: 0x0601A281 RID: 107137 RVA: 0x006DF84C File Offset: 0x006DDA4C
	protected void OnDirectionStateChange(ECharDirectionState oldDirectionState, ECharDirectionState newDirectionState)
	{
		this.ResetMovementSetting(new ECharDirectionState?(newDirectionState));
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharMoveState? newMoveState = (unifiedStateComponent != null) ? new global::ECharMoveState?(unifiedStateComponent.MoveState) : null;
		this.ResetMaxSpeed(newMoveState);
		this.ResetCharacterMovementInfo(newMoveState);
	}

	// Token: 0x0601A282 RID: 107138 RVA: 0x006DF894 File Offset: 0x006DDA94
	protected void OnMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		ECharDirectionState? newDirectionState = (unifiedStateComponent != null) ? new ECharDirectionState?(unifiedStateComponent.DirectionState) : null;
		this.ResetMovementSetting(newDirectionState);
		this.ResetMaxSpeed(new global::ECharMoveState?(newMoveState));
		this.ResetCharacterMovementInfo(new global::ECharMoveState?(newMoveState));
	}

	// Token: 0x0601A283 RID: 107139 RVA: 0x006DF8E0 File Offset: 0x006DDAE0
	protected void OnPositionStateChange(global::ECharPositionState oldPositionState, global::ECharPositionState newPositionState)
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		ECharDirectionState? newDirectionState = (unifiedStateComponent != null) ? new ECharDirectionState?(unifiedStateComponent.DirectionState) : null;
		this.ResetMovementSetting(newDirectionState);
		BaseUnifiedStateComponent unifiedStateComponent2 = this.UnifiedStateComponent;
		global::ECharMoveState? newMoveState = (unifiedStateComponent2 != null) ? new global::ECharMoveState?(unifiedStateComponent2.MoveState) : null;
		this.ResetMaxSpeed(newMoveState);
		this.ResetCharacterMovementInfo(newMoveState);
	}

	// Token: 0x0601A284 RID: 107140 RVA: 0x006DF944 File Offset: 0x006DDB44
	public unsafe void SetAddMoveOffset(FVectorDouble? offset)
	{
		if (offset != null && !MathUtils.Instance.IsValidVector(offset, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Movement;
			ELogAuthor author = ELogAuthor.LCZ;
			string message = "AddMove NaN";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Actor", this.ActorComp.Actor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Offset", offset);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		this.AddMoveOffset = offset;
		if (this.ActorComp.IsRoleAndCtrlByMe && offset != null && offset.Value.SizeSquared() > 1000000.0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "AddMove超过了10米";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("Actor", this.ActorComp.Actor.GetName());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Offset", offset);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
	}

	// Token: 0x0601A285 RID: 107141 RVA: 0x006DFA7A File Offset: 0x006DDC7A
	public void SetAddMoveRotation(FRotator rotation)
	{
		this.AddMoveRotation.DeepCopy(rotation);
	}

	// Token: 0x0601A286 RID: 107142 RVA: 0x006DFA89 File Offset: 0x006DDC89
	[NullableContext(2)]
	public void StopMove(bool isStop, string context = null)
	{
		if (isStop)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorVelocity(global::Vector.ZeroVectorProxy);
			}
			MoveToLocationController moveController = this.MoveController;
			if (moveController != null)
			{
				moveController.StopMove(context);
			}
		}
		this.IsStopInternal = isStop;
	}

	// Token: 0x0601A287 RID: 107143 RVA: 0x006DFABD File Offset: 0x006DDCBD
	[NullableContext(2)]
	public void StopMoveNew(string context = null)
	{
		this.Speed = 0f;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.SetActorVelocity(global::Vector.ZeroVectorProxy);
		}
		MoveToLocationController moveController = this.MoveController;
		if (moveController == null)
		{
			return;
		}
		moveController.StopMove(context);
	}

	// Token: 0x0601A288 RID: 107144 RVA: 0x006DFAF1 File Offset: 0x006DDCF1
	[NullableContext(2)]
	public void StopMoveByHandleId(int handleId, string context = null)
	{
		this.Speed = 0f;
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.SetActorVelocity(global::Vector.ZeroVectorProxy);
		}
		MoveToLocationController moveController = this.MoveController;
		if (moveController == null)
		{
			return;
		}
		moveController.StopMoveByHandleId(handleId, context);
	}

	// Token: 0x0601A289 RID: 107145 RVA: 0x006DFB28 File Offset: 0x006DDD28
	public void SetHiddenMovementMode(bool isHidden)
	{
		if (isHidden == this.IsHidden)
		{
			return;
		}
		if (isHidden)
		{
			UCharacterMovementComponent characterMovement = this.CharacterMovement;
			TEnumAsByte<EMovementMode>? tenumAsByte = (characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null;
			this.OldMovementMode = ((tenumAsByte != null) ? new EMovementMode?(tenumAsByte.GetValueOrDefault()) : null);
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_None,
					Context = "[BaseMoveComponent.SetHiddenMovementMode] if true"
				});
			}
		}
		else
		{
			CharacterActorComponent actorComp2 = this.ActorComp;
			if (actorComp2 != null)
			{
				actorComp2.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = this.OldMovementMode.Value,
					Context = "[BaseMoveComponent.SetHiddenMovementMode]"
				});
			}
		}
		this.IsHidden = isHidden;
	}

	// Token: 0x0601A28A RID: 107146 RVA: 0x006DFBFC File Offset: 0x006DDDFC
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CurrentGravityScale = new GravityScale(0f, 0f, 0f, 0f, 0f, 0f, false, false);
		this.ForceSpeed.Set(-100000000.0, -100000000.0, -100000000.0);
		return true;
	}

	// Token: 0x0601A28B RID: 107147 RVA: 0x006DFC5C File Offset: 0x006DDE5C
	protected void InitTraceInfo()
	{
		this.SphereTrace = new UTraceSphereElement();
		this.SphereTrace.WorldContextObject = this.ActorComp.Owner;
		this.SphereTrace.bIsSingle = true;
		this.SphereTrace.bIgnoreSelf = true;
		this.SphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Visible);
		this.WaterSphereTrace = new UTraceSphereElement();
		this.WaterSphereTrace.WorldContextObject = this.ActorComp.Owner;
		this.WaterSphereTrace.bIsSingle = true;
		this.WaterSphereTrace.bIgnoreSelf = true;
		this.WaterSphereTrace.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
	}

	// Token: 0x0601A28C RID: 107148 RVA: 0x006DFCFC File Offset: 0x006DDEFC
	protected void InitBaseState()
	{
		EEntityType entityType = this.ActorComp.CreatureData.GetEntityType();
		switch (entityType)
		{
		case EEntityType.Player:
			this.CharacterMovement.bKuroAutoActiveNav = false;
			this.CharacterMovement.bKuroStillBlockInNav = true;
			this.CharacterMovement.bProjectNavMeshWalking = false;
			this.IsInputDrivenCharacter = true;
			goto IL_E1;
		case EEntityType.Npc:
			this.CharacterMovement.bKuroAutoActiveNav = false;
			this.CharacterMovement.bKuroStillBlockInNav = false;
			this.CharacterMovement.bProjectNavMeshWalking = false;
			this.IsInputDrivenCharacter = true;
			goto IL_E1;
		case EEntityType.Monster:
			break;
		default:
			if (entityType != EEntityType.Vision)
			{
				this.CharacterMovement.bKuroAutoActiveNav = false;
				this.CharacterMovement.bKuroStillBlockInNav = false;
				this.CharacterMovement.bProjectNavMeshWalking = true;
				this.IsInputDrivenCharacter = true;
				goto IL_E1;
			}
			break;
		}
		this.CharacterMovement.bKuroAutoActiveNav = false;
		this.CharacterMovement.bKuroStillBlockInNav = true;
		this.CharacterMovement.bProjectNavMeshWalking = false;
		this.IsInputDrivenCharacter = false;
		IL_E1:
		this.CharacterMovement.bImpartBaseVelocityZ = false;
		this.CharacterMovement.bImpartBaseVelocityX = false;
		this.CharacterMovement.bImpartBaseVelocityY = false;
	}

	// Token: 0x0601A28D RID: 107149 RVA: 0x006DFE10 File Offset: 0x006DE010
	protected override void OnActivate()
	{
		this.OnMoveStateChange(global::ECharMoveState.Stand, global::ECharMoveState.Run);
		if (this.CharacterMovement.MovementMode == EMovementMode.MOVE_NavWalking)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp == null)
			{
				return;
			}
			actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
			{
				Mode = EMovementMode.MOVE_Walking,
				Context = "[BaseMoveComponent.OnActivate]"
			});
		}
	}

	// Token: 0x0601A28E RID: 107150 RVA: 0x006DFE6C File Offset: 0x006DE06C
	protected void PrintAnimInstanceMovementInfo()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "TickInfo:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HasMoveInput", this.HasMoveInput);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x0601A28F RID: 107151 RVA: 0x006DFEAC File Offset: 0x006DE0AC
	protected virtual void InitCreatureProperty()
	{
		CreatureDataComponent component = base.Entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return;
		}
		this.CreatureProperty = component.GetEntityPropertyConfig();
		this.CharacterMovement.Mass = (float)this.CreatureProperty.重量;
		this.CharacterMovement.HitPriority = this.CreatureProperty.碰撞优先级;
		this.CharacterMovement.GoThroughPriority = this.CreatureProperty.穿透优先级;
	}

	// Token: 0x0601A290 RID: 107152 RVA: 0x006DFF18 File Offset: 0x006DE118
	public void ResetHitPriorityAndGoThrough()
	{
		if (this.CreatureProperty == null)
		{
			return;
		}
		this.CharacterMovement.HitPriority = this.CreatureProperty.碰撞优先级;
		this.CharacterMovement.GoThroughPriority = this.CreatureProperty.穿透优先级;
	}

	// Token: 0x0601A291 RID: 107153 RVA: 0x006DFF55 File Offset: 0x006DE155
	public void ResetMass()
	{
		if (this.CreatureProperty == null)
		{
			return;
		}
		this.CharacterMovement.Mass = (float)this.CreatureProperty.重量;
	}

	// Token: 0x0601A292 RID: 107154 RVA: 0x006DFF7D File Offset: 0x006DE17D
	public bool CanResponseInput()
	{
		return this.CannotResponseInputCount == 0;
	}

	// Token: 0x0601A293 RID: 107155 RVA: 0x006DFF88 File Offset: 0x006DE188
	protected void SetInfoVar()
	{
		if ((double)this.DeltaTimeSeconds > 1E-08)
		{
			this.Acceleration.DeepCopy(this.ActorComp.ActorVelocityProxy);
			this.Acceleration.SubtractionEqual(this.PreviousVelocity);
			this.Acceleration.DivisionEqual((double)this.DeltaTimeSeconds);
			this.AimYawRate = Math.Abs(this.ActorComp.ActorRotationProxy.Yaw - this.PreviousAimYaw) / this.DeltaTimeSeconds;
		}
		bool hasMoveInput = this.HasMoveInput;
		this.HasMoveInput = (this.ActorComp.InputDirectProxy.SizeSquared() > 1E-08 && (double)this.CharacterMovement.MaxAcceleration > 1E-08);
		if (hasMoveInput != this.HasMoveInput)
		{
			EventSystem.Instance.EmitWithTarget<bool, bool>(base.Entity, EEventName.OnInputMoveChanged, hasMoveInput, this.HasMoveInput);
		}
	}

	// Token: 0x0601A294 RID: 107156 RVA: 0x006E0073 File Offset: 0x006DE273
	protected void CacheVar()
	{
		this.PreviousVelocity.DeepCopy(this.ActorComp.ActorVelocityProxy);
		this.PreviousAimYaw = this.ActorComp.ActorRotation.Yaw;
	}

	// Token: 0x0601A295 RID: 107157 RVA: 0x006E00A4 File Offset: 0x006DE2A4
	public bool CanUpdateMovingRotation()
	{
		if (this.UnifiedStateComponent.DirectionState != ECharDirectionState.AimDirection)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null && animComp.Valid && this.AnimComp.HasKuroRootMotion)
			{
				return this.AnimComp.ShellAnimInstance.GetMainAnimsCurveValueWithDelta(CharacterNameDefines.Instance.ROOT_ROTATABLE, 0f, false, false) >= 0.5f;
			}
		}
		return true;
	}

	// Token: 0x0601A296 RID: 107158 RVA: 0x006E0110 File Offset: 0x006DE310
	public void SetLockedRotation(bool @lock)
	{
		this.IsLockedRotation = @lock;
	}

	// Token: 0x17002400 RID: 9216
	// (get) Token: 0x0601A297 RID: 107159 RVA: 0x006E0119 File Offset: 0x006DE319
	public bool LockedRotation
	{
		get
		{
			return this.IsLockedRotation;
		}
	}

	// Token: 0x0601A298 RID: 107160 RVA: 0x006E0124 File Offset: 0x006DE324
	public void SmoothCharacterRotation(IRotator target, float speed, float deltaTimeSeconds, bool clearMeshRotationBuffer = false, string context = "Movement.SmoothCharacterRotation", bool influenceByTimeDilation = true)
	{
		if (this.IsLockedRotation)
		{
			return;
		}
		global::Rotator actorRotationProxy = this.ActorComp.ActorRotationProxy;
		if (actorRotationProxy.Equals2(target, 0.0001f))
		{
			return;
		}
		if (this.IsStandardGravity)
		{
			this.TmpRotator.DeepCopy(target);
			MathUtils.Instance.RotatorInterpConstantTo(actorRotationProxy, this.TmpRotator, deltaTimeSeconds, (influenceByTimeDilation ? this.SpeedScaled(speed) : speed) * this.TurnRate, this.TmpRotator);
		}
		else
		{
			this.TmpRotator.DeepCopy(target);
			GravityUtils.Instance.RotatorInterpConstantToForActor(this.ActorComp, actorRotationProxy, this.TmpRotator, deltaTimeSeconds, (influenceByTimeDilation ? this.SpeedScaled(speed) : speed) * this.TurnRate, this.TmpRotator);
		}
		if (base.Entity.GetTickInterval() > 1)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null && animComp.Valid && this.ActorComp.Owner.WasRecentlyRenderedOnScreen(0.2f))
			{
				FTransformDouble meshTransform = this.AnimComp.GetMeshTransform();
				this.ActorComp.SetActorRotationWithPriority(this.TmpRotator.ToUeRotator(), context, ESetRotationPriority.Movement, clearMeshRotationBuffer, false);
				this.AnimComp.SetModelBuffer(meshTransform, deltaTimeSeconds * 1000f * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
				return;
			}
		}
		this.ActorComp.SetActorRotationWithPriority(this.TmpRotator.ToUeRotator(), context, ESetRotationPriority.Movement, clearMeshRotationBuffer, false);
	}

	// Token: 0x0601A299 RID: 107161 RVA: 0x006E0278 File Offset: 0x006DE478
	public void ApplyForceSpeedAndRecordSpeed()
	{
		if (this.ForceSpeed.X != -100000000.0)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.SetActorVelocity(this.ForceSpeed);
			}
			this.ForceSpeed.X = -100000000.0;
		}
	}

	// Token: 0x0601A29A RID: 107162 RVA: 0x006E02C6 File Offset: 0x006DE4C6
	public virtual bool ConsumeForceFallingSpeed()
	{
		return true;
	}

	// Token: 0x0601A29B RID: 107163 RVA: 0x006E02CC File Offset: 0x006DE4CC
	[NullableContext(2)]
	public void SetAddMoveWorldSpeedWithMesh(UMeshComponent mesh, FVectorDouble speed)
	{
		if (mesh == null)
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WCL, "[CharacterMoveComponent.SetAddMoveWorldSpeedWithMesh] 叠加位移失败，mesh为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num;
		this.VelocityAdditionMapByMesh.TryGetValue(mesh, out num);
		num = this.SetAddMoveWorld(new FVectorDouble?(speed), -1f, null, new int?(num), null, global::EVelocityCurveType.None, 0f, 1f);
		if (num != 0)
		{
			this.VelocityAdditionMapByMesh[mesh] = num;
		}
	}

	// Token: 0x0601A29C RID: 107164 RVA: 0x006E0348 File Offset: 0x006DE548
	public virtual void SetAddMoveWithMesh(UMeshComponent mesh, FVectorDouble speed, float timeLength, [Nullable(2)] UCurveFloat curve = null)
	{
		if (mesh == null)
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WCL, "[CharacterMoveComponent.SetAddMoveWithMesh] 叠加位移失败，mesh为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num;
		this.VelocityAdditionMapByMesh.TryGetValue(mesh, out num);
		FRotator actorRotation = this.ActorComp.ActorRotation;
		FVector fvector = speed;
		FVector fvector2 = actorRotation.RotateVector(fvector);
		FVectorDouble value = fvector2;
		num = this.SetAddMoveWorld(new FVectorDouble?(value), timeLength, curve, new int?(num), null, global::EVelocityCurveType.None, 0f, 1f);
		if (num != 0)
		{
			this.VelocityAdditionMapByMesh[mesh] = num;
		}
	}

	// Token: 0x0601A29D RID: 107165 RVA: 0x006E03E8 File Offset: 0x006DE5E8
	[NullableContext(2)]
	public unsafe int SetAddMoveWorld(FVectorDouble? speed, float timeLength, UCurveFloat curve, int? handler, int? movementMode, global::EVelocityCurveType velocityCurveType = global::EVelocityCurveType.None, float velocityCurveMin = 0f, float velocityCurveMax = 1f)
	{
		if (speed == null)
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WCL, "[CharacterMoveComponent.SetAddMoveWorldNew] 叠加位移失败，速度为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return 0;
		}
		if (GlobalData.IsPlayInEditor && (velocityCurveMin >= velocityCurveMax || MathUtils.Instance.Clamp(velocityCurveMin, 0f, 1f) != velocityCurveMin || MathUtils.Instance.Clamp(velocityCurveMax, 0f, 1f) != velocityCurveMax))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Game;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "速度曲线配置错误";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Min", velocityCurveMin);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Max", velocityCurveMax);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return 0;
		}
		VelocityAddition velocityAddition = null;
		if (handler != null && handler.GetValueOrDefault() != 0)
		{
			this.VelocityAdditionMap.TryGetValue(handler.Value, out velocityAddition);
			if (velocityAddition != null)
			{
				if (speed.ContainsNaN())
				{
					Log instance2 = Log.Instance;
					ELogModule module2 = ELogModule.Movement;
					ELogAuthor author2 = ELogAuthor.LCZ;
					string message2 = "SetAddMoveWorld Contains NaN";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("speed", speed);
					instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
				velocityAddition.ElapsedTime = 0f;
				velocityAddition.Velocity = speed;
				velocityAddition.Duration = timeLength;
				velocityAddition.CurveFloat = curve;
				velocityAddition.MovementMode = movementMode.GetValueOrDefault();
				return handler.Value;
			}
		}
		velocityAddition = new VelocityAddition(timeLength, speed.Value, curve, movementMode.GetValueOrDefault(), velocityCurveType, velocityCurveMin, velocityCurveMax);
		int num = this.VelocityAdditionIncId + 1;
		this.VelocityAdditionIncId = num;
		int num2 = num;
		this.VelocityAdditionMap[num2] = velocityAddition;
		return num2;
	}

	// Token: 0x0601A29E RID: 107166 RVA: 0x006E05A0 File Offset: 0x006DE7A0
	public void SetAddMoveWorldWithMesh(UMeshComponent mesh, FVectorDouble speed, float timeLength, [Nullable(2)] UCurveFloat curve)
	{
		if (mesh == null)
		{
			Log.Instance.Error(ELogModule.Game, ELogAuthor.WCL, "[CharacterMoveComponent.SetAddMoveWorldWithMesh] 叠加位移失败，mesh为空", default(ReadOnlySpan<ValueTuple<string, object>>));
			return;
		}
		int num;
		this.VelocityAdditionMapByMesh.TryGetValue(mesh, out num);
		num = this.SetAddMoveWorld(new FVectorDouble?(speed), timeLength, curve, new int?(num), null, global::EVelocityCurveType.None, 0f, 1f);
		if (num != 0)
		{
			this.VelocityAdditionMapByMesh[mesh] = num;
		}
	}

	// Token: 0x0601A29F RID: 107167 RVA: 0x006E0616 File Offset: 0x006DE816
	public bool StopAddMove(int handler)
	{
		return this.VelocityAdditionMap.Remove(handler);
	}

	// Token: 0x0601A2A0 RID: 107168 RVA: 0x006E0624 File Offset: 0x006DE824
	public bool StopAddMoveWithMesh(UMeshComponent mesh)
	{
		int key;
		this.VelocityAdditionMapByMesh.TryGetValue(mesh, out key);
		return this.VelocityAdditionMap.Remove(key);
	}

	// Token: 0x0601A2A1 RID: 107169 RVA: 0x006E064C File Offset: 0x006DE84C
	public void StopAllAddMove()
	{
		this.VelocityAdditionMap.Clear();
	}

	// Token: 0x0601A2A2 RID: 107170 RVA: 0x006E065C File Offset: 0x006DE85C
	protected override void OnTick(float delta)
	{
		this.CharHeightAboveGround = -1f;
		this.CharHeightAboveGroundDetectHeight = -1f;
		this.CharHeightAboveWater = -1f;
		this.CharHeightAboveWaterDetectHeight = -1f;
		this.CanMoveWithDistanceInternal = (base.Entity.DistanceWithCamera <= 7000f);
		if (this.IsNeedDelayCheckWalkOffLedge && this.WalkOffLedgeCheckFrame + 1 <= Time.Instance.Frame)
		{
			this.WalkOffLedgeCheckFrame = Time.Instance.Frame;
			this.SetWalkOffLedge(this.WalkOffCount <= 0);
			this.IsNeedDelayCheckWalkOffLedge = false;
		}
	}

	// Token: 0x0601A2A3 RID: 107171 RVA: 0x006E06F8 File Offset: 0x006DE8F8
	protected void OnTickGravityScale()
	{
		if (!this.CurrentGravityScale.Enable)
		{
			return;
		}
		if (this.CurrentGravityScale.ElapsedTime < this.CurrentGravityScale.Duration)
		{
			BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
			if (unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Air)
			{
				this.CurrentGravityScale.ElapsedTime += this.DeltaTimeSeconds;
				if (this.CurrentGravityScale.VelocityTop < Math.Abs(this.CharacterMovement.Velocity.Z))
				{
					this.CharacterMovement.GravityScale = 2f * ((this.CharacterMovement.Velocity.Z > 0f) ? this.CurrentGravityScale.ScaleUp : this.CurrentGravityScale.ScaleDown);
					return;
				}
				this.CharacterMovement.GravityScale = 2f * this.CurrentGravityScale.ScaleTop;
				if (this.CurrentGravityScale.ForceVelocityZero)
				{
					this.CharacterMovement.Velocity = FVector.ZeroVector;
				}
				return;
			}
		}
		this.CharacterMovement.GravityScale = 2f;
		this.CurrentGravityScale.Enable = false;
	}

	// Token: 0x0601A2A4 RID: 107172 RVA: 0x006E0818 File Offset: 0x006DEA18
	public unsafe virtual void GetAndConsumeAddMove(float deltaSeconds, global::Vector outVector, global::Rotator outRotator)
	{
		outVector.Reset();
		outRotator.Reset();
		if (this.AddMoveOffset != null)
		{
			global::Vector tmpVector = this.TmpVector;
			FVectorDouble value = this.AddMoveOffset.Value;
			tmpVector.FromUeVector(value);
			outVector.AdditionEqual(this.TmpVector);
			this.AddMoveOffset = null;
		}
		if (!this.AddMoveRotation.IsNearlyZero())
		{
			outRotator.DeepCopy(this.AddMoveRotation);
			this.AddMoveRotation.Reset();
		}
		if (this.VelocityAdditionMap.Count == 0)
		{
			return;
		}
		BaseMoveComponent.VelocityAdditionTotal.Reset();
		foreach (KeyValuePair<int, VelocityAddition> keyValuePair in this.VelocityAdditionMap)
		{
			int num;
			VelocityAddition velocityAddition;
			keyValuePair.Deconstruct(out num, out velocityAddition);
			int num2 = num;
			VelocityAddition velocityAddition2 = velocityAddition;
			if (velocityAddition2.Duration >= 0f && velocityAddition2.ElapsedTime >= velocityAddition2.Duration)
			{
				this.VelocityAdditionMap.Remove(num2);
			}
			else if (velocityAddition2.MovementMode > 0 && (int)this.CharacterMovement.CustomMovementMode != velocityAddition2.MovementMode)
			{
				this.VelocityAdditionMap.Remove(num2);
			}
			else
			{
				velocityAddition2.ElapsedTime += deltaSeconds;
				if (this.PauseLocks.Count <= 0)
				{
					global::Vector velocityVector = this.VelocityVector;
					FVectorDouble value = velocityAddition2.Velocity.Value;
					velocityVector.FromUeVector(value);
					if (velocityAddition2.VelocityCurveType != global::EVelocityCurveType.None)
					{
						float num3 = velocityAddition2.VelocityCurveFunc((velocityAddition2.Duration > 0f) ? (velocityAddition2.ElapsedTime / velocityAddition2.Duration) : 1f);
						global::Vector velocityVector2 = this.VelocityVector;
						value = velocityAddition2.Velocity.Value;
						velocityVector2.FromUeVector(value);
						this.VelocityVector.MultiplyEqual((double)num3);
					}
					else
					{
						UCurveFloat curveFloat = velocityAddition2.CurveFloat;
						if (curveFloat != null && curveFloat.IsValid())
						{
							this.VelocityVector.MultiplyEqual((double)velocityAddition2.CurveFloat.GetFloatValue((velocityAddition2.Duration > 0f) ? (velocityAddition2.ElapsedTime / velocityAddition2.Duration) : 1f));
						}
					}
					if (velocityAddition2.Duration > 0f && velocityAddition2.ElapsedTime > velocityAddition2.Duration)
					{
						float num4 = velocityAddition2.ElapsedTime - velocityAddition2.Duration;
						float num5 = (deltaSeconds - num4) / deltaSeconds;
						this.VelocityVector.MultiplyEqual((double)num5);
					}
					BaseMoveComponent.VelocityAdditionTotal.AdditionEqual(this.VelocityVector);
					if (this.VelocityVector.ContainsNaN())
					{
						Log instance = Log.Instance;
						ELogModule module = ELogModule.Movement;
						ELogAuthor author = ELogAuthor.LCZ;
						string message = "VelocityVector NaN";
						<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("key", num2);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("VelocityVector", this.VelocityVector);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("velocityAddition.Velocity", velocityAddition2.Velocity);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("deltaTimeSeconds", deltaSeconds);
						instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
						this.VelocityAdditionMap.Remove(num2);
						return;
					}
				}
			}
		}
		BaseMoveComponent.VelocityAdditionTotal.Multiply((double)deltaSeconds, BaseMoveComponent.VelocityAdditionDestination);
		if (BaseMoveComponent.VelocityAdditionDestination.ContainsNaN())
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Movement;
			ELogAuthor author2 = ELogAuthor.LCZ;
			string message2 = "VelocityAdditionDestination NaN";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("VelocityAdditionDestination", BaseMoveComponent.VelocityAdditionDestination);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("VelocityAdditionTotal", BaseMoveComponent.VelocityAdditionTotal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("deltaTimeSeconds", deltaSeconds);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
			return;
		}
		outVector.AdditionEqual(BaseMoveComponent.VelocityAdditionDestination);
	}

	// Token: 0x0601A2A5 RID: 107173 RVA: 0x006E0C1C File Offset: 0x006DEE1C
	public float GetHeightAboveGround(float heightDetect = 500f)
	{
		if (this.CharHeightAboveGroundDetectHeight >= heightDetect)
		{
			return Math.Min(this.CharHeightAboveGround, heightDetect);
		}
		this.CharHeightAboveGroundDetectHeight = heightDetect;
		this.TmpVector.DeepCopy(this.ActorComp.FloorLocation);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)this.ActorComp.ScaledRadius);
		TraceElementCommon.Instance.SetStartLocation(this.SphereTrace, this.TmpVector);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)(-(double)heightDetect));
		TraceElementCommon.Instance.SetEndLocation(this.SphereTrace, this.TmpVector);
		this.SphereTrace.Radius = this.ActorComp.ScaledRadius;
		bool flag = TraceElementCommon.Instance.SphereTrace(this.SphereTrace, "CharacterMoveComponent_GetHeightAboveGround");
		UKuroHitResult hitResult = this.SphereTrace.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			this.CharHeightAboveGround = hitResult.TimeArray.Get(0) * heightDetect;
		}
		else
		{
			this.CharHeightAboveGround = heightDetect;
		}
		return this.CharHeightAboveGround;
	}

	// Token: 0x0601A2A6 RID: 107174 RVA: 0x006E0D28 File Offset: 0x006DEF28
	public float GetHeightAboveWater(float heightDetect = 500f)
	{
		if (this.CharHeightAboveWaterDetectHeight >= heightDetect)
		{
			return Math.Min(this.CharHeightAboveWater, heightDetect);
		}
		this.CharHeightAboveWaterDetectHeight = heightDetect;
		this.TmpVector.DeepCopy(this.ActorComp.FloorLocation);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)this.ActorComp.ScaledRadius);
		TraceElementCommon.Instance.SetStartLocation(this.WaterSphereTrace, this.TmpVector);
		GravityUtils.Instance.AddZnInGravityForActor(this.ActorComp, this.TmpVector, (double)(-(double)heightDetect));
		TraceElementCommon.Instance.SetEndLocation(this.WaterSphereTrace, this.TmpVector);
		this.WaterSphereTrace.Radius = this.ActorComp.ScaledRadius;
		bool flag = TraceElementCommon.Instance.SphereTrace(this.WaterSphereTrace, "CharacterMoveComponent_GetHeightAboveGround");
		UKuroHitResult hitResult = this.WaterSphereTrace.HitResult;
		if (flag && hitResult.bBlockingHit)
		{
			this.CharHeightAboveWater = hitResult.TimeArray.Get(0) * heightDetect;
		}
		else
		{
			this.CharHeightAboveWater = heightDetect;
		}
		return this.CharHeightAboveWater;
	}

	// Token: 0x0601A2A7 RID: 107175 RVA: 0x006E0E33 File Offset: 0x006DF033
	public bool IsInAir()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		return unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Air;
	}

	// Token: 0x0601A2A8 RID: 107176 RVA: 0x006E0E4C File Offset: 0x006DF04C
	public bool IsInRoll()
	{
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null) == EMovementMode.MOVE_Custom)
		{
			UCharacterMovementComponent characterMovement2 = this.CharacterMovement;
			byte? b = (characterMovement2 != null) ? new byte?(characterMovement2.CustomMovementMode) : null;
			return ((b != null) ? new int?((int)b.GetValueOrDefault()) : null).GetValueOrDefault() == 9;
		}
		return false;
	}

	// Token: 0x0601A2A9 RID: 107177 RVA: 0x006E0EEC File Offset: 0x006DF0EC
	public void SetSpeedLock()
	{
		this.SpeedLockFrame = 5;
	}

	// Token: 0x0601A2AA RID: 107178 RVA: 0x006E0EF5 File Offset: 0x006DF0F5
	public void SetOverrideMaxSpeed(float speed)
	{
		this.OverrideMaxSpeed = speed;
		this.SetMaxSpeed(speed);
	}

	// Token: 0x0601A2AB RID: 107179 RVA: 0x006E0F05 File Offset: 0x006DF105
	public void ResetOverrideMaxSpeed()
	{
		this.OverrideMaxSpeed = 0f;
	}

	// Token: 0x17002401 RID: 9217
	// (get) Token: 0x0601A2AC RID: 107180 RVA: 0x006E0F12 File Offset: 0x006DF112
	// (set) Token: 0x0601A2AD RID: 107181 RVA: 0x006E0F1A File Offset: 0x006DF11A
	public bool FallingIntoWater
	{
		get
		{
			return this.IsFallingIntoWater;
		}
		set
		{
			this.IsFallingIntoWater = value;
		}
	}

	// Token: 0x0601A2AE RID: 107182 RVA: 0x006E0F24 File Offset: 0x006DF124
	public void MoveCharacter(global::Vector offset, float deltaTime, string reason = "")
	{
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		bool flag;
		if (!(((characterMovement != null) ? new TEnumAsByte<EMovementMode>?(characterMovement.MovementMode) : null) == EMovementMode.MOVE_Walking))
		{
			UCharacterMovementComponent characterMovement2 = this.CharacterMovement;
			flag = (((characterMovement2 != null) ? new TEnumAsByte<EMovementMode>?(characterMovement2.MovementMode) : null) == EMovementMode.MOVE_NavWalking);
		}
		else
		{
			flag = true;
		}
		if (flag)
		{
			offset.DivisionEqual((double)deltaTime);
			this.ActorComp.KuroMoveAlongFloor(offset.ToUeVectorOld(), deltaTime, (reason != "") ? reason : "MoveCharacter");
		}
		else
		{
			this.ActorComp.AddActorWorldOffset(offset.ToUeVector(false), (reason != "") ? reason : "MoveCharacter", true);
		}
		this.ActorComp.ResetAllCachedTime();
	}

	// Token: 0x0601A2AF RID: 107183 RVA: 0x006E1020 File Offset: 0x006DF220
	public void SetWalkOffLedgeRecord(bool walkOff)
	{
		if (walkOff)
		{
			int num = this.WalkOffCount - 1;
			this.WalkOffCount = num;
			if (num == 0)
			{
				this.IsNeedDelayCheckWalkOffLedge = true;
				this.WalkOffLedgeCheckFrame = Time.Instance.Frame;
				return;
			}
		}
		else
		{
			int num = this.WalkOffCount + 1;
			this.WalkOffCount = num;
			if (num == 1)
			{
				this.IsNeedDelayCheckWalkOffLedge = false;
				this.SetWalkOffLedge(false);
			}
		}
	}

	// Token: 0x0601A2B0 RID: 107184 RVA: 0x006E1080 File Offset: 0x006DF280
	protected void SetWalkOffLedge(bool walkOff)
	{
		if (walkOff)
		{
			this.CharacterMovement.bCanWalkOffLedges = true;
			this.CharacterMovement.PerchRadiusThreshold = 0f;
			this.CharacterMovement.PerchAdditionalHeight = 40f;
			return;
		}
		this.CharacterMovement.bCanWalkOffLedges = false;
		this.CharacterMovement.PerchRadiusThreshold = this.ActorComp.ScaledRadius;
		this.CharacterMovement.PerchAdditionalHeight = this.ActorComp.ScaledRadius * 2f;
	}

	// Token: 0x0601A2B1 RID: 107185 RVA: 0x006E10FC File Offset: 0x006DF2FC
	public void SetPerchWalkOffLedgeRecord(bool walkOff)
	{
		if (walkOff)
		{
			int num = this.PerchEdgeDirectionCount - 1;
			this.PerchEdgeDirectionCount = num;
			if (num == 0)
			{
				this.CharacterMovement.bKuroUsePerchEdgeDirection = false;
			}
		}
		else
		{
			int num = this.PerchEdgeDirectionCount + 1;
			this.PerchEdgeDirectionCount = num;
			if (num == 1)
			{
				this.CharacterMovement.bKuroUsePerchEdgeDirection = true;
			}
		}
		this.SetWalkOffLedgeRecord(walkOff);
	}

	// Token: 0x0601A2B2 RID: 107186 RVA: 0x006E1154 File Offset: 0x006DF354
	protected void LerpMaxAcceleration()
	{
		if (this.DesireMaxAccelerationLerpTime <= 0f)
		{
			return;
		}
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharMoveState? echarMoveState = (unifiedStateComponent != null) ? new global::ECharMoveState?(unifiedStateComponent.MoveState) : null;
		global::ECharMoveState? accelerationChangeMoveState = this.AccelerationChangeMoveState;
		if (!(echarMoveState.GetValueOrDefault() == accelerationChangeMoveState.GetValueOrDefault() & echarMoveState != null == (accelerationChangeMoveState != null)))
		{
			this.DesireMaxAccelerationLerpTime = 0f;
			return;
		}
		SMovementSetting currentMovementSettings = this.CurrentMovementSettings;
		float num = (currentMovementSettings != null) ? currentMovementSettings.Acceleration : 0f;
		this.DesireMaxAccelerationLerpTime -= this.DeltaTimeSeconds;
		float inTime = (this.MaxAccelerationLerpTime - this.DesireMaxAccelerationLerpTime) / this.MaxAccelerationLerpTime;
		float floatValue = this.AccelerationLerpCurve.GetFloatValue(inTime);
		this.CharacterMovement.MaxAcceleration = floatValue * num;
		float num2 = (MathUtils.Instance.Clamp(floatValue, 1f, 2f) - 1f) * 0.8f + 1f;
		this.SetMaxSpeed(this.CurrentMovementSettings.SprintSpeed * num2);
	}

	// Token: 0x0601A2B3 RID: 107187 RVA: 0x006E1260 File Offset: 0x006DF460
	protected void UpdateGroundedRotation()
	{
		float angleOffsetFromCurrentToInputAbs = GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.ActorComp);
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent == null || unifiedStateComponent.MoveState != global::ECharMoveState.Stand || this.HasInputPrevFrame)
		{
			this.SmoothCharacterRotation(this.ActorComp.InputRotatorProxy, this.CurrentMovementRotationSetting.GetSpeed(angleOffsetFromCurrentToInputAbs), this.DeltaTimeSeconds, false, "Movement.UpdateGroundedRotation.ROTATION_MEDIUM", true);
		}
		this.HasInputPrevFrame = (angleOffsetFromCurrentToInputAbs > 1f);
	}

	// Token: 0x0601A2B4 RID: 107188 RVA: 0x006E12D8 File Offset: 0x006DF4D8
	protected void UpdateInAirRotation()
	{
		if (this.UnifiedStateComponent == null)
		{
			return;
		}
		if (this.UnifiedStateComponent.MoveState == global::ECharMoveState.Glide || this.UnifiedStateComponent.MoveState == global::ECharMoveState.Slide)
		{
			this.SmoothCharacterRotation(this.ActorComp.InputRotatorProxy, 60f, this.DeltaTimeSeconds, false, "Movement.UpdateInAirRotation", true);
		}
	}

	// Token: 0x0601A2B5 RID: 107189 RVA: 0x006E132F File Offset: 0x006DF52F
	protected void UpdateUsingControllerRotation()
	{
		this.SmoothCharacterRotation(this.ActorComp.InputRotatorProxy, 1500f, this.DeltaTimeSeconds, false, "Movement.UpdateGroundedRotation.ROTATION_AIM", true);
	}

	// Token: 0x0601A2B6 RID: 107190 RVA: 0x006E1354 File Offset: 0x006DF554
	protected unsafe void UpdateBaseMovement()
	{
		FBasedMovementInfo basedMovement = this.ActorComp.Actor.BasedMovement;
		AActor aactor;
		if (basedMovement == null)
		{
			aactor = null;
		}
		else
		{
			UPrimitiveComponent movementBase = basedMovement.MovementBase;
			aactor = ((movementBase != null) ? movementBase.GetOwner() : null);
		}
		AActor aactor2 = aactor;
		if (this.BasedMovementActor != aactor2)
		{
			this.BasedMovementActor = aactor2;
			if (aactor2 != null && !(aactor2 is TsBaseCharacter))
			{
				TEnumAsByte<EComponentMobility>? tenumAsByte;
				if (basedMovement == null)
				{
					tenumAsByte = null;
				}
				else
				{
					UPrimitiveComponent movementBase2 = basedMovement.MovementBase;
					tenumAsByte = ((movementBase2 != null) ? new TEnumAsByte<EComponentMobility>?(movementBase2.Mobility) : null);
				}
				if (tenumAsByte == EComponentMobility.Movable)
				{
					TickSystem.Instance.AddTickPrerequisiteActor(ETickingGroup.TG_PrePhysics, aactor2, 2);
				}
			}
		}
		bool flag = false;
		BasePlatform basePlatformByBasedMovementInfo = BasePlatformController.GetBasePlatformByBasedMovementInfo(basedMovement);
		if (this.HasBaseMovement != basedMovement.bRelativeRotation || this.BasePlatform != basePlatformByBasedMovementInfo)
		{
			this.HasBaseMovement = basedMovement.bRelativeRotation;
			this.BasePlatform = basePlatformByBasedMovementInfo;
			flag = true;
		}
		if (this.HasBaseMovement)
		{
			TEnumAsByte<EComponentMobility>? tenumAsByte2;
			if (basedMovement == null)
			{
				tenumAsByte2 = null;
			}
			else
			{
				UPrimitiveComponent movementBase3 = basedMovement.MovementBase;
				tenumAsByte2 = ((movementBase3 != null) ? new TEnumAsByte<EComponentMobility>?(movementBase3.Mobility) : null);
			}
			if (tenumAsByte2 == EComponentMobility.Movable)
			{
				FQuat baseDeltaQuat = this.CharacterMovement.BaseDeltaQuat;
				this.DeltaBaseMovementQuat.FromUeQuat(baseDeltaQuat);
				FVector baseDeltaPosition = this.CharacterMovement.BaseDeltaPosition;
				this.DeltaBaseMovementOffset = new FVectorDouble?(new FVectorDouble(ref baseDeltaPosition));
				FVectorDouble fvectorDouble;
				if (MathUtils.Instance.IsNearlyZero((double)this.DeltaTimeSeconds, null))
				{
					fvectorDouble = new FVectorDouble(0.0, 0.0, 0.0);
				}
				else
				{
					FVectorDouble value = this.DeltaBaseMovementOffset.Value;
					fvectorDouble = value / (double)(this.DeltaTimeSeconds * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
				}
				if (basePlatformByBasedMovementInfo != null && !basePlatformByBasedMovementInfo.IsDeltaBaseSpeedNeedZ)
				{
					fvectorDouble.Z = 0.0;
				}
				if (this.DeltaBaseMovementSpeed != null)
				{
					FVectorDouble value2 = this.DeltaBaseMovementSpeed.Value;
					MathUtils.Instance.LerpVector(this.DeltaBaseMovementSpeed.Value, fvectorDouble, 0.2f, ref value2);
					this.DeltaBaseMovementSpeed = new FVectorDouble?(value2);
				}
				else
				{
					this.DeltaBaseMovementSpeed = new FVectorDouble?(fvectorDouble);
				}
				if (Math.Abs(this.DeltaBaseMovementSpeed.Value.X) > 3000.0 || Math.Abs(this.DeltaBaseMovementSpeed.Value.Y) > 3000.0 || Math.Abs(this.DeltaBaseMovementSpeed.Value.Z) > 3000.0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Movement;
					ELogAuthor author = ELogAuthor.LCZ;
					string message = "异常惯性速度";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Speed", this.DeltaBaseMovementSpeed);
					ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
					string item = "BasedMovement";
					AActor owner = basedMovement.MovementBase.GetOwner();
					ptr = new ValueTuple<string, object>(item, (owner != null) ? owner.GetName() : null);
					instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				}
				this.HasDeltaBaseMovementData = true;
				goto IL_349;
			}
		}
		this.DeltaBaseMovementQuat.Reset();
		this.DeltaBaseMovementSpeed = null;
		this.HasDeltaBaseMovementData = false;
		IL_349:
		if (flag)
		{
			EventSystem.Instance.EmitWithTarget(base.Entity, EEventName.CharBasePlatformChanged);
		}
	}

	// Token: 0x0601A2B7 RID: 107191 RVA: 0x006E16C3 File Offset: 0x006DF8C3
	protected virtual float SpeedScaled(float speed)
	{
		return speed;
	}

	// Token: 0x17002402 RID: 9218
	// (get) Token: 0x0601A2B8 RID: 107192 RVA: 0x006E16C6 File Offset: 0x006DF8C6
	// (set) Token: 0x0601A2B9 RID: 107193 RVA: 0x006E16CE File Offset: 0x006DF8CE
	public bool CanMoveFromInput
	{
		get
		{
			return this.CanMoveFromInputInternal;
		}
		set
		{
			this.CanMoveFromInputInternal = value;
		}
	}

	// Token: 0x0601A2BA RID: 107194 RVA: 0x006E16D7 File Offset: 0x006DF8D7
	public void AddInputMovementLock(string key)
	{
		this.InputMovementLocks.Add(key);
	}

	// Token: 0x0601A2BB RID: 107195 RVA: 0x006E16E6 File Offset: 0x006DF8E6
	public void RemoveInputMovementLock(string key)
	{
		this.InputMovementLocks.Remove(key);
	}

	// Token: 0x0601A2BC RID: 107196 RVA: 0x006E16F5 File Offset: 0x006DF8F5
	public bool CanApplyInputMovement()
	{
		return this.InputMovementLocks.Count == 0;
	}

	// Token: 0x0601A2BD RID: 107197 RVA: 0x006E1705 File Offset: 0x006DF905
	public virtual bool CanMove()
	{
		return this.CanMoveFromInputInternal && (this.CanMoveWithDistanceInternal || this.UnifiedStateComponent.IsInFighting);
	}

	// Token: 0x0601A2BE RID: 107198 RVA: 0x006E1726 File Offset: 0x006DF926
	public virtual bool CanMoveWithDistance()
	{
		return this.CanMoveWithDistanceInternal;
	}

	// Token: 0x0601A2BF RID: 107199 RVA: 0x006E172E File Offset: 0x006DF92E
	public virtual bool CanJumpPress()
	{
		return false;
	}

	// Token: 0x0601A2C0 RID: 107200 RVA: 0x006E1731 File Offset: 0x006DF931
	public virtual bool CanWalkPress()
	{
		return false;
	}

	// Token: 0x0601A2C1 RID: 107201 RVA: 0x006E1734 File Offset: 0x006DF934
	public bool IsMovingToLocation()
	{
		return this.MoveController.IsMoving();
	}

	// Token: 0x0601A2C2 RID: 107202 RVA: 0x006E1741 File Offset: 0x006DF941
	[NullableContext(2)]
	public void StopMoveWithCallback(ELevelEventState result, string context = null)
	{
		this.MoveController.StopMoveWithCallback(result, context);
	}

	// Token: 0x0601A2C3 RID: 107203 RVA: 0x006E1750 File Offset: 0x006DF950
	[NullableContext(2)]
	public void StopMoveToLocation(string context = null)
	{
		this.MoveController.StopMoveToLocation(context);
	}

	// Token: 0x0601A2C4 RID: 107204 RVA: 0x006E175E File Offset: 0x006DF95E
	public int MoveAlongPath(MoveCharacterConfig config, [Nullable(2)] string context = null)
	{
		this.IsStopInternal = false;
		return this.MoveController.MoveAlongPath(config, context);
	}

	// Token: 0x17002403 RID: 9219
	// (get) Token: 0x0601A2C5 RID: 107205 RVA: 0x006E1774 File Offset: 0x006DF974
	public MoveToLocationController MoveController
	{
		get
		{
			if (this.MoveControllerInternal == null)
			{
				this.MoveControllerInternal = new MoveToLocationController(base.Entity);
			}
			return this.MoveControllerInternal;
		}
	}

	// Token: 0x0601A2C6 RID: 107206 RVA: 0x006E1795 File Offset: 0x006DF995
	public void SetTurnRate(float v)
	{
		this.TurnRate = v;
	}

	// Token: 0x0601A2C7 RID: 107207 RVA: 0x006E179E File Offset: 0x006DF99E
	public void ResetTurnRate()
	{
		this.TurnRate = 1f;
	}

	// Token: 0x0601A2C8 RID: 107208 RVA: 0x006E17AB File Offset: 0x006DF9AB
	public void SetAirControl(float v)
	{
		this.CharacterMovement.AirControl = v;
	}

	// Token: 0x0601A2C9 RID: 107209 RVA: 0x006E17B9 File Offset: 0x006DF9B9
	public void ResetAirControl()
	{
		this.CharacterMovement.AirControl = 0.05f;
	}

	// Token: 0x0601A2CA RID: 107210 RVA: 0x006E17CB File Offset: 0x006DF9CB
	public void ResetCharTraceHeight()
	{
		this.CharHeightAboveGround = -1f;
		this.CharHeightAboveGroundDetectHeight = -1f;
		this.CharHeightAboveWater = -1f;
		this.CharHeightAboveWaterDetectHeight = -1f;
	}

	// Token: 0x0601A2CB RID: 107211 RVA: 0x006E17F9 File Offset: 0x006DF9F9
	protected override bool OnClear()
	{
		base.OnClear();
		this.IsNeedDelayCheckWalkOffLedge = false;
		this.InputMovementLocks.Clear();
		this.WalkOffLedgeCheckFrame = 0;
		return true;
	}

	// Token: 0x0601A2CC RID: 107212 RVA: 0x006E181C File Offset: 0x006DFA1C
	public void AddPauseLock(string key)
	{
		this.PauseLocks[key] = true;
	}

	// Token: 0x0601A2CD RID: 107213 RVA: 0x006E182C File Offset: 0x006DFA2C
	public void RemovePauseLock(string key)
	{
		bool flag;
		this.PauseLocks.TryGetValue(key, out flag);
		if (flag)
		{
			this.PauseLocks.Remove(key);
		}
	}

	// Token: 0x0601A2CE RID: 107214 RVA: 0x006E1858 File Offset: 0x006DFA58
	public void SetInputMaxDegree(float degree)
	{
		this.MaxMoveDegree = degree;
	}

	// Token: 0x0601A2CF RID: 107215 RVA: 0x006E1861 File Offset: 0x006DFA61
	public void SetInputScale(float scale)
	{
		this.InputScale = scale;
	}

	// Token: 0x0601A2D0 RID: 107216 RVA: 0x006E186A File Offset: 0x006DFA6A
	public bool HasInputMoveLimit()
	{
		return this.MaxMoveDegree > 0f;
	}

	// Token: 0x0601A2D1 RID: 107217 RVA: 0x006E187C File Offset: 0x006DFA7C
	public void GetFixInputMoveDirection(IVector direction, global::Vector @out)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		this.TmpVector.DeepCopy(direction);
		if (this.TmpVector.IsNearlyZero(9.999999747378752E-05))
		{
			return;
		}
		if (MathUtils.Instance.GetAngleByVectorDot(this.ActorComp.ActorForwardProxy, direction) <= (double)this.MaxMoveDegree)
		{
			return;
		}
		this.ActorComp.ActorForwardProxy.CrossProduct(this.TmpVector, this.TmpVector2);
		bool flag = MathUtils.Instance.DotProduct(this.TmpVector2, this.ActorComp.ActorUpProxy) > 0.0;
		this.TmpVector2.DeepCopy(this.ActorComp.ActorForwardProxy);
		this.TmpVector2.RotateAngleAxis((double)(flag ? this.MaxMoveDegree : (-1f * this.MaxMoveDegree)), this.ActorComp.ActorUpProxy, @out);
		if (this.InputScale != 1f)
		{
			@out.MultiplyEqual((double)this.InputScale);
		}
	}

	// Token: 0x0601A2D2 RID: 107218 RVA: 0x006E1978 File Offset: 0x006DFB78
	public static void CreateStaticDefaultValue()
	{
		BaseMoveComponent.VelocityAdditionTotal = global::Vector.Create();
		BaseMoveComponent.VelocityAdditionDestination = global::Vector.Create();
	}

	// Token: 0x0601A2D3 RID: 107219 RVA: 0x006E198E File Offset: 0x006DFB8E
	public static void ResetStaticDefaultValue()
	{
		BaseMoveComponent.BaseMoveInheritCurveInternal = null;
		BaseMoveComponent.VelocityAdditionTotal = null;
		BaseMoveComponent.VelocityAdditionDestination = null;
	}

	// Token: 0x0601A2D4 RID: 107220 RVA: 0x006E19A4 File Offset: 0x006DFBA4
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseMoveComponent baseMoveComponent = (BaseMoveComponent)componentTemplate;
		if (base.CanResetComponentProperty("IsInputDrivenCharacter"))
		{
			this.IsInputDrivenCharacter = baseMoveComponent.IsInputDrivenCharacter;
		}
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (baseMoveComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CharacterMovement"))
		{
			if (baseMoveComponent.CharacterMovement == null)
			{
				this.CharacterMovement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCharacterMovementComponent>(this.CharacterMovement), "CharacterMovement"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AnimComp"))
		{
			if (baseMoveComponent.AnimComp == null)
			{
				this.AnimComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAnimationComponent>(this.AnimComp), "AnimComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("TimeScaleComp"))
		{
			if (baseMoveComponent.TimeScaleComp == null)
			{
				this.TimeScaleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<PawnTimeScaleComponent>(this.TimeScaleComp), "TimeScaleComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MoveControllerInternal"))
		{
			if (baseMoveComponent.MoveControllerInternal == null)
			{
				this.MoveControllerInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MoveToLocationController>(this.MoveControllerInternal), "MoveControllerInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasMoveInput"))
		{
			this.HasMoveInput = baseMoveComponent.HasMoveInput;
		}
		if (base.CanResetComponentProperty("ForceExitStateStop"))
		{
			this.ForceExitStateStop = baseMoveComponent.ForceExitStateStop;
		}
		if (base.CanResetComponentProperty("IsMoving"))
		{
			this.IsMoving = baseMoveComponent.IsMoving;
		}
		if (base.CanResetComponentProperty("Speed"))
		{
			this.Speed = baseMoveComponent.Speed;
		}
		if (base.CanResetComponentProperty("IsSpecialMove"))
		{
			this.IsSpecialMove = baseMoveComponent.IsSpecialMove;
		}
		if (base.CanResetComponentProperty("NeedRootMotionWhenAttached"))
		{
			this.NeedRootMotionWhenAttached = baseMoveComponent.NeedRootMotionWhenAttached;
		}
		if (base.CanResetComponentProperty("CanMoveWithDistanceInternal"))
		{
			this.CanMoveWithDistanceInternal = baseMoveComponent.CanMoveWithDistanceInternal;
		}
		if (base.CanResetComponentProperty("CanMoveFromInputInternal"))
		{
			this.CanMoveFromInputInternal = baseMoveComponent.CanMoveFromInputInternal;
		}
		if (base.CanResetComponentProperty("InputMovementLocks") && baseMoveComponent.InputMovementLocks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.InputMovementLocks), "InputMovementLocks"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("DeltaTimeSeconds"))
		{
			this.DeltaTimeSeconds = baseMoveComponent.DeltaTimeSeconds;
		}
		if (base.CanResetComponentProperty("JumpUpRate"))
		{
			this.JumpUpRate = baseMoveComponent.JumpUpRate;
		}
		if (base.CanResetComponentProperty("ConfigChainLengthSquared"))
		{
			this.ConfigChainLengthSquared = baseMoveComponent.ConfigChainLengthSquared;
		}
		if (base.CanResetComponentProperty("CurrentChainLengthSquared"))
		{
			this.CurrentChainLengthSquared = baseMoveComponent.CurrentChainLengthSquared;
		}
		if (base.CanResetComponentProperty("ChainCenter") && baseMoveComponent.ChainCenter != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ChainCenter), "ChainCenter"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ChainTempPredicted") && baseMoveComponent.ChainTempPredicted != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ChainTempPredicted), "ChainTempPredicted"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ChainTempToCenter") && baseMoveComponent.ChainTempToCenter != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ChainTempToCenter), "ChainTempToCenter"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ForceSpeed") && baseMoveComponent.ForceSpeed != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.ForceSpeed), "ForceSpeed"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("Acceleration"))
		{
			if (baseMoveComponent.Acceleration == null)
			{
				this.Acceleration = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.Acceleration), "Acceleration"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("PreviousVelocity") && baseMoveComponent.PreviousVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.PreviousVelocity), "PreviousVelocity"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpVector") && baseMoveComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector), "TmpVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpVector2") && baseMoveComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.TmpVector2), "TmpVector2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpQuat") && baseMoveComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat), "TmpQuat"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpQuat2") && baseMoveComponent.TmpQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.TmpQuat2), "TmpQuat2"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("TmpRotator") && baseMoveComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.TmpRotator), "TmpRotator"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("PreviousAimYaw"))
		{
			this.PreviousAimYaw = baseMoveComponent.PreviousAimYaw;
		}
		if (base.CanResetComponentProperty("AimYawRate"))
		{
			this.AimYawRate = baseMoveComponent.AimYawRate;
		}
		if (base.CanResetComponentProperty("IsFallingIntoWater"))
		{
			this.IsFallingIntoWater = baseMoveComponent.IsFallingIntoWater;
		}
		if (base.CanResetComponentProperty("JumpFrameCount"))
		{
			this.JumpFrameCount = baseMoveComponent.JumpFrameCount;
		}
		if (base.CanResetComponentProperty("CharHeightAboveGround"))
		{
			this.CharHeightAboveGround = baseMoveComponent.CharHeightAboveGround;
		}
		if (base.CanResetComponentProperty("CharHeightAboveGroundDetectHeight"))
		{
			this.CharHeightAboveGroundDetectHeight = baseMoveComponent.CharHeightAboveGroundDetectHeight;
		}
		if (base.CanResetComponentProperty("CharHeightAboveWater"))
		{
			this.CharHeightAboveWater = baseMoveComponent.CharHeightAboveWater;
		}
		if (base.CanResetComponentProperty("CharHeightAboveWaterDetectHeight"))
		{
			this.CharHeightAboveWaterDetectHeight = baseMoveComponent.CharHeightAboveWaterDetectHeight;
		}
		if (base.CanResetComponentProperty("CreatureProperty"))
		{
			if (baseMoveComponent.CreatureProperty == null)
			{
				this.CreatureProperty = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SEntityProperty>(this.CreatureProperty), "CreatureProperty"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DefaultMovementData"))
		{
			if (baseMoveComponent.DefaultMovementData == null)
			{
				this.DefaultMovementData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SMovementSetting_State>(this.DefaultMovementData), "DefaultMovementData"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MovementDataMap"))
		{
			if (baseMoveComponent.MovementDataMap == null)
			{
				this.MovementDataMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, SMovementSetting_State>>(this.MovementDataMap), "MovementDataMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MovementData"))
		{
			if (baseMoveComponent.MovementData == null)
			{
				this.MovementData = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SMovementSetting_State>(this.MovementData), "MovementData"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentMovementSettingsInternal"))
		{
			if (baseMoveComponent.CurrentMovementSettingsInternal == null)
			{
				this.CurrentMovementSettingsInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SMovementSetting>(this.CurrentMovementSettingsInternal), "CurrentMovementSettingsInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentMovementRotationSetting") && baseMoveComponent.CurrentMovementRotationSetting != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<RotationSetting>(this.CurrentMovementRotationSetting), "CurrentMovementRotationSetting"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("UnifiedStateComponent"))
		{
			if (baseMoveComponent.UnifiedStateComponent == null)
			{
				this.UnifiedStateComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseUnifiedStateComponent>(this.UnifiedStateComponent), "UnifiedStateComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasBaseMovement"))
		{
			this.HasBaseMovement = baseMoveComponent.HasBaseMovement;
		}
		if (base.CanResetComponentProperty("OldMovementMode"))
		{
			this.OldMovementMode = baseMoveComponent.OldMovementMode;
		}
		if (base.CanResetComponentProperty("IsHidden"))
		{
			this.IsHidden = baseMoveComponent.IsHidden;
		}
		if (base.CanResetComponentProperty("HasDeltaBaseMovementData"))
		{
			this.HasDeltaBaseMovementData = baseMoveComponent.HasDeltaBaseMovementData;
		}
		if (base.CanResetComponentProperty("DeltaBaseMovementOffset"))
		{
			this.DeltaBaseMovementOffset = baseMoveComponent.DeltaBaseMovementOffset;
		}
		if (base.CanResetComponentProperty("DeltaBaseMovementSpeed"))
		{
			this.DeltaBaseMovementSpeed = baseMoveComponent.DeltaBaseMovementSpeed;
		}
		if (base.CanResetComponentProperty("DeltaConveyBeltSpeed"))
		{
			this.DeltaConveyBeltSpeed = baseMoveComponent.DeltaConveyBeltSpeed;
		}
		if (base.CanResetComponentProperty("DeltaBaseMovementQuat"))
		{
			if (baseMoveComponent.DeltaBaseMovementQuat == null)
			{
				this.DeltaBaseMovementQuat = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.DeltaBaseMovementQuat), "DeltaBaseMovementQuat"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BasedMovementActor"))
		{
			if (baseMoveComponent.BasedMovementActor == null)
			{
				this.BasedMovementActor = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.BasedMovementActor), "BasedMovementActor"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("BasePlatform"))
		{
			if (baseMoveComponent.BasePlatform == null)
			{
				this.BasePlatform = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BasePlatform>(this.BasePlatform), "BasePlatform"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsLockedRotation"))
		{
			this.IsLockedRotation = baseMoveComponent.IsLockedRotation;
		}
		if (base.CanResetComponentProperty("SpeedLockFrame"))
		{
			this.SpeedLockFrame = baseMoveComponent.SpeedLockFrame;
		}
		if (base.CanResetComponentProperty("OverrideMaxSpeed"))
		{
			this.OverrideMaxSpeed = baseMoveComponent.OverrideMaxSpeed;
		}
		if (base.CanResetComponentProperty("VelocityVector") && baseMoveComponent.VelocityVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.VelocityVector), "VelocityVector"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsStopInternal"))
		{
			this.IsStopInternal = baseMoveComponent.IsStopInternal;
		}
		if (base.CanResetComponentProperty("DebugMovementSetting"))
		{
			if (baseMoveComponent.DebugMovementSetting == null)
			{
				this.DebugMovementSetting = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SMovementSetting>(this.DebugMovementSetting), "DebugMovementSetting"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UseDebugMovementSetting"))
		{
			this.UseDebugMovementSetting = baseMoveComponent.UseDebugMovementSetting;
		}
		if (base.CanResetComponentProperty("WalkOffCount"))
		{
			this.WalkOffCount = baseMoveComponent.WalkOffCount;
		}
		if (base.CanResetComponentProperty("PerchEdgeDirectionCount"))
		{
			this.PerchEdgeDirectionCount = baseMoveComponent.PerchEdgeDirectionCount;
		}
		if (base.CanResetComponentProperty("CannotResponseInputCount"))
		{
			this.CannotResponseInputCount = baseMoveComponent.CannotResponseInputCount;
		}
		if (base.CanResetComponentProperty("CapsuleOffset"))
		{
			if (baseMoveComponent.CapsuleOffset == null)
			{
				this.CapsuleOffset = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CapsuleOffset), "CapsuleOffset"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SphereTrace"))
		{
			if (baseMoveComponent.SphereTrace == null)
			{
				this.SphereTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.SphereTrace), "SphereTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("WaterSphereTrace"))
		{
			if (baseMoveComponent.WaterSphereTrace == null)
			{
				this.WaterSphereTrace = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceSphereElement>(this.WaterSphereTrace), "WaterSphereTrace"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AccelerationChangeMoveState"))
		{
			this.AccelerationChangeMoveState = baseMoveComponent.AccelerationChangeMoveState;
		}
		if (base.CanResetComponentProperty("AccelerationLerpCurve"))
		{
			if (baseMoveComponent.AccelerationLerpCurve == null)
			{
				this.AccelerationLerpCurve = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UCurveFloat>(this.AccelerationLerpCurve), "AccelerationLerpCurve"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FallingHorizontalMaxSpeed"))
		{
			this.FallingHorizontalMaxSpeed = baseMoveComponent.FallingHorizontalMaxSpeed;
		}
		if (base.CanResetComponentProperty("DesireMaxAccelerationLerpTime"))
		{
			this.DesireMaxAccelerationLerpTime = baseMoveComponent.DesireMaxAccelerationLerpTime;
		}
		if (base.CanResetComponentProperty("MaxAccelerationLerpTime"))
		{
			this.MaxAccelerationLerpTime = baseMoveComponent.MaxAccelerationLerpTime;
		}
		if (base.CanResetComponentProperty("IsNeedDelayCheckWalkOffLedge"))
		{
			this.IsNeedDelayCheckWalkOffLedge = baseMoveComponent.IsNeedDelayCheckWalkOffLedge;
		}
		if (base.CanResetComponentProperty("WalkOffLedgeCheckFrame"))
		{
			this.WalkOffLedgeCheckFrame = baseMoveComponent.WalkOffLedgeCheckFrame;
		}
		if (base.CanResetComponentProperty("TurnRate"))
		{
			this.TurnRate = baseMoveComponent.TurnRate;
		}
		if (base.CanResetComponentProperty("IsRegionMoveMode"))
		{
			this.IsRegionMoveMode = baseMoveComponent.IsRegionMoveMode;
		}
		if (base.CanResetComponentProperty("GravityDirectInternal") && baseMoveComponent.GravityDirectInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.GravityDirectInternal), "GravityDirectInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("GravityUpInternal") && baseMoveComponent.GravityUpInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.GravityUpInternal), "GravityUpInternal"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsStandardGravityInternal"))
		{
			this.IsStandardGravityInternal = baseMoveComponent.IsStandardGravityInternal;
		}
		if (base.CanResetComponentProperty("JumpDelayTimer"))
		{
			if (baseMoveComponent.JumpDelayTimer == null)
			{
				this.JumpDelayTimer = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<TimerHandle>(this.JumpDelayTimer), "JumpDelayTimer"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("GroundedTimeUe"))
		{
			this.GroundedTimeUe = baseMoveComponent.GroundedTimeUe;
		}
		if (base.CanResetComponentProperty("VelocityAdditionIncId"))
		{
			this.VelocityAdditionIncId = baseMoveComponent.VelocityAdditionIncId;
		}
		if (base.CanResetComponentProperty("VelocityAdditionMap") && baseMoveComponent.VelocityAdditionMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<int, VelocityAddition>>(this.VelocityAdditionMap), "VelocityAdditionMap"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("VelocityAdditionMapByMesh") && baseMoveComponent.VelocityAdditionMapByMesh != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<UMeshComponent, int>>(this.VelocityAdditionMapByMesh), "VelocityAdditionMapByMesh"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("AddMoveOffset"))
		{
			this.AddMoveOffset = baseMoveComponent.AddMoveOffset;
		}
		if (base.CanResetComponentProperty("AddMoveRotation"))
		{
			if (baseMoveComponent.AddMoveRotation == null)
			{
				this.AddMoveRotation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.AddMoveRotation), "AddMoveRotation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurrentGravityScale"))
		{
			if (baseMoveComponent.CurrentGravityScale == null)
			{
				this.CurrentGravityScale = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<GravityScale>(this.CurrentGravityScale), "CurrentGravityScale"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("HasInputPrevFrame"))
		{
			this.HasInputPrevFrame = baseMoveComponent.HasInputPrevFrame;
		}
		if (base.CanResetComponentProperty("PauseLocks"))
		{
			if (baseMoveComponent.PauseLocks == null)
			{
				this.PauseLocks = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, bool>>(this.PauseLocks), "PauseLocks"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("MaxMoveDegree"))
		{
			this.MaxMoveDegree = baseMoveComponent.MaxMoveDegree;
		}
		if (base.CanResetComponentProperty("InputScale"))
		{
			this.InputScale = baseMoveComponent.InputScale;
		}
		return true;
	}

	// Token: 0x0400C6AB RID: 50859
	[Nullable(2)]
	protected static UCurveFloat BaseMoveInheritCurveInternal;

	// Token: 0x0400C6AC RID: 50860
	public const string PROFILE_KEY = "CharacterMoveComponent_GetHeightAboveGround";

	// Token: 0x0400C6AD RID: 50861
	public const float ROTATION_AIM = 1500f;

	// Token: 0x0400C6AE RID: 50862
	public const float HEIGHT_DETECT = 500f;

	// Token: 0x0400C6AF RID: 50863
	public const float ROTATABLE_THREADHOLD = 0.5f;

	// Token: 0x0400C6B0 RID: 50864
	public const float BASE_MOVEMENT_VELOCITY_RATE = 0.2f;

	// Token: 0x0400C6B1 RID: 50865
	public const int SPEED_LOCK_FRAME = 5;

	// Token: 0x0400C6B2 RID: 50866
	public const float INVALID_FORCE_SPEED = -100000000f;

	// Token: 0x0400C6B3 RID: 50867
	public const bool OPEN_DEBUG = false;

	// Token: 0x0400C6B4 RID: 50868
	public const float DEFAULT_MAX_FALLING_VELOCITY_2D = 700f;

	// Token: 0x0400C6B5 RID: 50869
	public const float DEFAULT_AIR_CONTROL = 0.05f;

	// Token: 0x0400C6B6 RID: 50870
	public const int WALK_OFF_LEDGE_DELAY_FRAME = 1;

	// Token: 0x0400C6B7 RID: 50871
	protected bool IsInputDrivenCharacter;

	// Token: 0x0400C6B8 RID: 50872
	[Nullable(2)]
	public CharacterActorComponent ActorComp;

	// Token: 0x0400C6B9 RID: 50873
	[Nullable(2)]
	public UCharacterMovementComponent CharacterMovement;

	// Token: 0x0400C6BA RID: 50874
	[Nullable(2)]
	protected CharacterAnimationComponent AnimComp;

	// Token: 0x0400C6BB RID: 50875
	[Nullable(2)]
	protected PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400C6BC RID: 50876
	[Nullable(2)]
	protected MoveToLocationController MoveControllerInternal;

	// Token: 0x0400C6BD RID: 50877
	public bool HasMoveInput;

	// Token: 0x0400C6BE RID: 50878
	public bool ForceExitStateStop;

	// Token: 0x0400C6BF RID: 50879
	public bool IsMoving;

	// Token: 0x0400C6C0 RID: 50880
	public float Speed;

	// Token: 0x0400C6C1 RID: 50881
	public bool IsSpecialMove;

	// Token: 0x0400C6C2 RID: 50882
	public bool NeedRootMotionWhenAttached;

	// Token: 0x0400C6C3 RID: 50883
	protected bool CanMoveWithDistanceInternal = true;

	// Token: 0x0400C6C4 RID: 50884
	protected bool CanMoveFromInputInternal = true;

	// Token: 0x0400C6C5 RID: 50885
	private readonly HashSet<string> InputMovementLocks = new HashSet<string>();

	// Token: 0x0400C6C6 RID: 50886
	protected float DeltaTimeSeconds;

	// Token: 0x0400C6C7 RID: 50887
	public float JumpUpRate = 1f;

	// Token: 0x0400C6C8 RID: 50888
	protected double ConfigChainLengthSquared = -1.0;

	// Token: 0x0400C6C9 RID: 50889
	protected double CurrentChainLengthSquared;

	// Token: 0x0400C6CA RID: 50890
	protected readonly global::Vector ChainCenter = global::Vector.Create();

	// Token: 0x0400C6CB RID: 50891
	private readonly global::Vector ChainTempPredicted = global::Vector.Create();

	// Token: 0x0400C6CC RID: 50892
	private readonly global::Vector ChainTempToCenter = global::Vector.Create();

	// Token: 0x0400C6CD RID: 50893
	protected readonly global::Vector ForceSpeed = global::Vector.Create(-100000000.0, -100000000.0, -100000000.0);

	// Token: 0x0400C6CE RID: 50894
	public global::Vector Acceleration = global::Vector.Create();

	// Token: 0x0400C6CF RID: 50895
	protected readonly global::Vector PreviousVelocity = global::Vector.Create();

	// Token: 0x0400C6D0 RID: 50896
	protected readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400C6D1 RID: 50897
	protected readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400C6D2 RID: 50898
	protected readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C6D3 RID: 50899
	protected readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C6D4 RID: 50900
	protected readonly global::Rotator TmpRotator = global::Rotator.Create();

	// Token: 0x0400C6D5 RID: 50901
	protected float PreviousAimYaw;

	// Token: 0x0400C6D6 RID: 50902
	public float AimYawRate;

	// Token: 0x0400C6D7 RID: 50903
	public bool IsFallingIntoWater;

	// Token: 0x0400C6D8 RID: 50904
	protected int JumpFrameCount;

	// Token: 0x0400C6D9 RID: 50905
	protected float CharHeightAboveGround = -1f;

	// Token: 0x0400C6DA RID: 50906
	protected float CharHeightAboveGroundDetectHeight = -1f;

	// Token: 0x0400C6DB RID: 50907
	protected float CharHeightAboveWater = -1f;

	// Token: 0x0400C6DC RID: 50908
	protected float CharHeightAboveWaterDetectHeight = -1f;

	// Token: 0x0400C6DD RID: 50909
	[Nullable(2)]
	protected SEntityProperty CreatureProperty;

	// Token: 0x0400C6DE RID: 50910
	[Nullable(2)]
	protected SMovementSetting_State DefaultMovementData;

	// Token: 0x0400C6DF RID: 50911
	protected Dictionary<int, SMovementSetting_State> MovementDataMap = new Dictionary<int, SMovementSetting_State>();

	// Token: 0x0400C6E0 RID: 50912
	[Nullable(2)]
	public SMovementSetting_State MovementData;

	// Token: 0x0400C6E1 RID: 50913
	[Nullable(2)]
	private SMovementSetting CurrentMovementSettingsInternal;

	// Token: 0x0400C6E2 RID: 50914
	public readonly RotationSetting CurrentMovementRotationSetting = new RotationSetting();

	// Token: 0x0400C6E3 RID: 50915
	[Nullable(2)]
	protected BaseUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400C6E4 RID: 50916
	public bool HasBaseMovement;

	// Token: 0x0400C6E5 RID: 50917
	protected EMovementMode? OldMovementMode;

	// Token: 0x0400C6E6 RID: 50918
	protected bool IsHidden;

	// Token: 0x0400C6E7 RID: 50919
	public bool HasDeltaBaseMovementData;

	// Token: 0x0400C6E8 RID: 50920
	public FVectorDouble? DeltaBaseMovementOffset;

	// Token: 0x0400C6E9 RID: 50921
	public FVectorDouble? DeltaBaseMovementSpeed;

	// Token: 0x0400C6EA RID: 50922
	public FVectorDouble? DeltaConveyBeltSpeed;

	// Token: 0x0400C6EB RID: 50923
	public Quat DeltaBaseMovementQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400C6EC RID: 50924
	[Nullable(2)]
	private AActor BasedMovementActor;

	// Token: 0x0400C6ED RID: 50925
	[Nullable(2)]
	public BasePlatform BasePlatform;

	// Token: 0x0400C6EE RID: 50926
	protected bool IsLockedRotation;

	// Token: 0x0400C6EF RID: 50927
	protected int SpeedLockFrame;

	// Token: 0x0400C6F0 RID: 50928
	protected float OverrideMaxSpeed;

	// Token: 0x0400C6F1 RID: 50929
	protected readonly global::Vector VelocityVector = global::Vector.Create();

	// Token: 0x0400C6F2 RID: 50930
	protected bool IsStopInternal;

	// Token: 0x0400C6F3 RID: 50931
	[Nullable(2)]
	protected SMovementSetting DebugMovementSetting;

	// Token: 0x0400C6F4 RID: 50932
	protected bool UseDebugMovementSetting;

	// Token: 0x0400C6F5 RID: 50933
	protected int WalkOffCount;

	// Token: 0x0400C6F6 RID: 50934
	private int PerchEdgeDirectionCount;

	// Token: 0x0400C6F7 RID: 50935
	protected int CannotResponseInputCount;

	// Token: 0x0400C6F8 RID: 50936
	[Nullable(2)]
	protected global::Vector CapsuleOffset;

	// Token: 0x0400C6F9 RID: 50937
	[Nullable(2)]
	protected UTraceSphereElement SphereTrace;

	// Token: 0x0400C6FA RID: 50938
	[Nullable(2)]
	protected UTraceSphereElement WaterSphereTrace;

	// Token: 0x0400C6FB RID: 50939
	public global::ECharMoveState? AccelerationChangeMoveState;

	// Token: 0x0400C6FC RID: 50940
	[Nullable(2)]
	protected UCurveFloat AccelerationLerpCurve;

	// Token: 0x0400C6FD RID: 50941
	protected float FallingHorizontalMaxSpeed = 700f;

	// Token: 0x0400C6FE RID: 50942
	protected float DesireMaxAccelerationLerpTime;

	// Token: 0x0400C6FF RID: 50943
	protected float MaxAccelerationLerpTime;

	// Token: 0x0400C700 RID: 50944
	private bool IsNeedDelayCheckWalkOffLedge;

	// Token: 0x0400C701 RID: 50945
	private int WalkOffLedgeCheckFrame;

	// Token: 0x0400C702 RID: 50946
	protected float TurnRate = 1f;

	// Token: 0x0400C703 RID: 50947
	public bool IsRegionMoveMode;

	// Token: 0x0400C704 RID: 50948
	protected readonly global::Vector GravityDirectInternal = global::Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400C705 RID: 50949
	protected readonly global::Vector GravityUpInternal = global::Vector.Create(0.0, 0.0, 1.0);

	// Token: 0x0400C706 RID: 50950
	protected bool IsStandardGravityInternal = true;

	// Token: 0x0400C707 RID: 50951
	[Nullable(2)]
	protected TimerHandle JumpDelayTimer;

	// Token: 0x0400C708 RID: 50952
	public float GroundedTimeUe;

	// Token: 0x0400C709 RID: 50953
	protected int VelocityAdditionIncId = 1;

	// Token: 0x0400C70A RID: 50954
	protected static global::Vector VelocityAdditionTotal;

	// Token: 0x0400C70B RID: 50955
	protected static global::Vector VelocityAdditionDestination;

	// Token: 0x0400C70C RID: 50956
	protected readonly Dictionary<int, VelocityAddition> VelocityAdditionMap = new Dictionary<int, VelocityAddition>();

	// Token: 0x0400C70D RID: 50957
	protected readonly Dictionary<UMeshComponent, int> VelocityAdditionMapByMesh = new Dictionary<UMeshComponent, int>();

	// Token: 0x0400C70E RID: 50958
	protected FVectorDouble? AddMoveOffset;

	// Token: 0x0400C70F RID: 50959
	protected global::Rotator AddMoveRotation = global::Rotator.Create();

	// Token: 0x0400C710 RID: 50960
	[Nullable(2)]
	public GravityScale CurrentGravityScale;

	// Token: 0x0400C711 RID: 50961
	private bool HasInputPrevFrame;

	// Token: 0x0400C712 RID: 50962
	protected Dictionary<string, bool> PauseLocks = new Dictionary<string, bool>();

	// Token: 0x0400C713 RID: 50963
	protected float MaxMoveDegree;

	// Token: 0x0400C714 RID: 50964
	protected float InputScale = 1f;
}
