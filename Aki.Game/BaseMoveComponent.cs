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

// Token: 0x0200258D RID: 9613
[NullableContext(1)]
[Nullable(0)]
public class BaseMoveComponent : EntityComponent, IStaticVariableResetter
{
	// Token: 0x06017BC2 RID: 97218 RVA: 0x007069D9 File Offset: 0x00704BD9
	static BaseMoveComponent()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BaseMoveComponent.CreateStaticDefaultValue), new Action(BaseMoveComponent.ResetStaticDefaultValue));
	}

	// Token: 0x170024DD RID: 9437
	// (get) Token: 0x06017BC3 RID: 97219 RVA: 0x007069F8 File Offset: 0x00704BF8
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

	// Token: 0x06017BC4 RID: 97220 RVA: 0x00706A1C File Offset: 0x00704C1C
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

	// Token: 0x06017BC5 RID: 97221 RVA: 0x00706ABC File Offset: 0x00704CBC
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

	// Token: 0x170024DE RID: 9438
	// (get) Token: 0x06017BC6 RID: 97222 RVA: 0x00706B27 File Offset: 0x00704D27
	public bool IsJump
	{
		get
		{
			return this.JumpFrameCount > 0;
		}
	}

	// Token: 0x170024DF RID: 9439
	// (get) Token: 0x06017BC7 RID: 97223 RVA: 0x00706B32 File Offset: 0x00704D32
	[Nullable(2)]
	public SMovementSetting_State DefaultMovementDataReadonly
	{
		[NullableContext(2)]
		get
		{
			return this.DefaultMovementData;
		}
	}

	// Token: 0x170024E0 RID: 9440
	// (get) Token: 0x06017BC8 RID: 97224 RVA: 0x00706B3A File Offset: 0x00704D3A
	// (set) Token: 0x06017BC9 RID: 97225 RVA: 0x00706B44 File Offset: 0x00704D44
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
			if (this.CharacterMovement != null)
			{
				UCharacterMovementComponent characterMovement = this.CharacterMovement;
				FKuroMovementSetting fkuroMovementSetting = new FKuroMovementSetting
				{
					Acceleration = value.Acceleration,
					ControllerRotationSpeed = value.ControllerRotationSpeed,
					ControllerRotationSpeedSetting = new FKuroMovementRotationSetting(value.ControllerRotationSpeedSetting.最大旋转速度, value.ControllerRotationSpeedSetting.最大角度差, value.ControllerRotationSpeedSetting.最小旋转速度, value.ControllerRotationSpeedSetting.最小角度差, (int)value.ControllerRotationSpeedSetting.渐变曲线.CurveType, value.ControllerRotationSpeedSetting.渐变曲线.N),
					FastSwimSpeed = value.FastSwimSpeed,
					GroundFriction = value.GroundFriction,
					MovementCurve = value.MovementCurve,
					NormalSwimSpeed = value.NormalSwimSpeed,
					RotationRateCurve = value.RotationRateCurve,
					RunSpeed = value.RunSpeed,
					SprintSpeed = value.SprintSpeed,
					SwingAcceleration = value.SwingAcceleration,
					SwingSpeed = value.SwingSpeed,
					WalkSpeed = value.WalkSpeed
				};
				characterMovement.SetKuroMovementSettings(fkuroMovementSetting);
			}
		}
	}

	// Token: 0x06017BCA RID: 97226 RVA: 0x00706C73 File Offset: 0x00704E73
	public void SetGravityDirectWithoutRotate(IVector v)
	{
		this.SetGravityDirectWithoutRotateByNumber(v.X, v.Y, v.Z);
	}

	// Token: 0x06017BCB RID: 97227 RVA: 0x00706C90 File Offset: 0x00704E90
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

	// Token: 0x06017BCC RID: 97228 RVA: 0x00706DE4 File Offset: 0x00704FE4
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
					this.ActorComp.SetInputDirect(this.TmpVector, true, EInputDirectSpace.World);
					this.TmpQuat.RotateVector(this.ActorComp.InputFacingProxy, this.TmpVector);
					this.ActorComp.SetInputFacing(this.TmpVector, true);
					goto IL_304;
				}
			}
			this.ActorComp.ClearInput(false, true);
		}
		else
		{
			this.ActorComp.ClearInput(false, true);
		}
		IL_304:
		this.ActorComp.ResetGravityRelatedCachedTime();
		EventSystem.Instance.EmitWithTarget<global::Vector, bool>(base.Entity, EEventName.CharGravityDirectChanged, this.GravityDirect, this.IsStandardGravity);
		EventSystem.Instance.Emit<Entity, global::Vector, bool>(EEventName.AnyCharGravityDirectChanged, base.Entity, this.GravityDirect, this.IsStandardGravity);
	}

	// Token: 0x06017BCD RID: 97229 RVA: 0x00707144 File Offset: 0x00705344
	public void SetGravityDirect(IVector v)
	{
		this.SetGravityDirectByNumber(v.X, v.Y, v.Z, true, -1f);
	}

	// Token: 0x06017BCE RID: 97230 RVA: 0x00707164 File Offset: 0x00705364
	public void SetGravityDirect(Aki.Protocol.Vector v)
	{
		this.SetGravityDirectByNumber((double)v.X, (double)v.Y, (double)v.Z, true, -1f);
	}

	// Token: 0x170024E1 RID: 9441
	// (get) Token: 0x06017BCF RID: 97231 RVA: 0x00707187 File Offset: 0x00705387
	public global::Vector GravityDirect
	{
		get
		{
			return this.GravityDirectInternal;
		}
	}

	// Token: 0x170024E2 RID: 9442
	// (get) Token: 0x06017BD0 RID: 97232 RVA: 0x00707190 File Offset: 0x00705390
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

	// Token: 0x170024E3 RID: 9443
	// (get) Token: 0x06017BD1 RID: 97233 RVA: 0x007071DF File Offset: 0x007053DF
	public bool IsStandardGravity
	{
		get
		{
			return this.IsStandardGravityInternal;
		}
	}

	// Token: 0x170024E4 RID: 9444
	// (get) Token: 0x06017BD3 RID: 97235 RVA: 0x007071F7 File Offset: 0x007053F7
	// (set) Token: 0x06017BD2 RID: 97234 RVA: 0x007071E7 File Offset: 0x007053E7
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

	// Token: 0x06017BD4 RID: 97236 RVA: 0x007071FF File Offset: 0x007053FF
	public void SetFallingHorizontalMaxSpeed(float v)
	{
		this.FallingHorizontalMaxSpeed = v;
	}

	// Token: 0x06017BD5 RID: 97237 RVA: 0x00707208 File Offset: 0x00705408
	public void ClearFallingHorizontalMaxSpeed()
	{
		this.FallingHorizontalMaxSpeed = 700f;
	}

	// Token: 0x06017BD6 RID: 97238 RVA: 0x00707218 File Offset: 0x00705418
	protected override bool OnInit()
	{
		this.IsStandardGravityInternal = true;
		this.GravityDirectInternal.Set(0.0, 0.0, -1.0);
		this.GravityUpInternal.Set(0.0, 0.0, 1.0);
		return true;
	}

	// Token: 0x06017BD7 RID: 97239 RVA: 0x00707279 File Offset: 0x00705479
	protected override bool OnStart()
	{
		this.TimeScaleComp = base.Entity.GetComponent<PawnTimeScaleComponent>();
		return true;
	}

	// Token: 0x06017BD8 RID: 97240 RVA: 0x0070728D File Offset: 0x0070548D
	public void SetUseDebugMovementSetting(bool newSelect)
	{
		this.UseDebugMovementSetting = newSelect;
	}

	// Token: 0x06017BD9 RID: 97241 RVA: 0x00707296 File Offset: 0x00705496
	public void SetDebugMovementSetting(SMovementSetting newSetting)
	{
		this.DebugMovementSetting = newSetting;
	}

	// Token: 0x06017BDA RID: 97242 RVA: 0x0070729F File Offset: 0x0070549F
	public void ApplyDebugMovementSetting()
	{
		this.CurrentMovementSettings = this.DebugMovementSetting;
	}

	// Token: 0x06017BDB RID: 97243 RVA: 0x007072B0 File Offset: 0x007054B0
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

	// Token: 0x06017BDC RID: 97244 RVA: 0x00707328 File Offset: 0x00705528
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

	// Token: 0x06017BDD RID: 97245 RVA: 0x00707390 File Offset: 0x00705590
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

	// Token: 0x06017BDE RID: 97246 RVA: 0x00707490 File Offset: 0x00705690
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

	// Token: 0x06017BDF RID: 97247 RVA: 0x007074F8 File Offset: 0x007056F8
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

	// Token: 0x06017BE0 RID: 97248 RVA: 0x0070758C File Offset: 0x0070578C
	protected void OnDirectionStateChange(ECharDirectionState oldDirectionState, ECharDirectionState newDirectionState)
	{
		this.ResetMovementSetting(new ECharDirectionState?(newDirectionState));
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		global::ECharMoveState? newMoveState = (unifiedStateComponent != null) ? new global::ECharMoveState?(unifiedStateComponent.MoveState) : null;
		this.ResetMaxSpeed(newMoveState);
		this.ResetCharacterMovementInfo(newMoveState);
	}

	// Token: 0x06017BE1 RID: 97249 RVA: 0x007075D4 File Offset: 0x007057D4
	protected void OnMoveStateChange(global::ECharMoveState oldMoveState, global::ECharMoveState newMoveState)
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		ECharDirectionState? newDirectionState = (unifiedStateComponent != null) ? new ECharDirectionState?(unifiedStateComponent.DirectionState) : null;
		this.ResetMovementSetting(newDirectionState);
		this.ResetMaxSpeed(new global::ECharMoveState?(newMoveState));
		this.ResetCharacterMovementInfo(new global::ECharMoveState?(newMoveState));
	}

	// Token: 0x06017BE2 RID: 97250 RVA: 0x00707620 File Offset: 0x00705820
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

	// Token: 0x06017BE3 RID: 97251 RVA: 0x00707684 File Offset: 0x00705884
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

	// Token: 0x06017BE4 RID: 97252 RVA: 0x007077BA File Offset: 0x007059BA
	public void SetAddMoveRotation(FRotator rotation)
	{
		this.AddMoveRotation.DeepCopy(rotation);
	}

	// Token: 0x06017BE5 RID: 97253 RVA: 0x007077C9 File Offset: 0x007059C9
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

	// Token: 0x06017BE6 RID: 97254 RVA: 0x007077FD File Offset: 0x007059FD
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

	// Token: 0x06017BE7 RID: 97255 RVA: 0x00707831 File Offset: 0x00705A31
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

	// Token: 0x06017BE8 RID: 97256 RVA: 0x00707868 File Offset: 0x00705A68
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

	// Token: 0x06017BE9 RID: 97257 RVA: 0x0070793C File Offset: 0x00705B3C
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CurrentGravityScale = new GravityScale(0f, 0f, 0f, 0f, 0f, 0f, false, false);
		this.ForceSpeed.Set(-100000000.0, -100000000.0, -100000000.0);
		return true;
	}

	// Token: 0x06017BEA RID: 97258 RVA: 0x0070799C File Offset: 0x00705B9C
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

	// Token: 0x06017BEB RID: 97259 RVA: 0x00707A3C File Offset: 0x00705C3C
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

	// Token: 0x06017BEC RID: 97260 RVA: 0x00707B50 File Offset: 0x00705D50
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

	// Token: 0x06017BED RID: 97261 RVA: 0x00707BAC File Offset: 0x00705DAC
	protected void PrintAnimInstanceMovementInfo()
	{
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Test;
		ELogAuthor author = ELogAuthor.LJM;
		string message = "TickInfo:";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("HasMoveInput", this.HasMoveInput);
		instance.Warn(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
	}

	// Token: 0x06017BEE RID: 97262 RVA: 0x00707BEC File Offset: 0x00705DEC
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

	// Token: 0x06017BEF RID: 97263 RVA: 0x00707C58 File Offset: 0x00705E58
	public void ResetHitPriorityAndGoThrough()
	{
		if (this.CreatureProperty == null)
		{
			return;
		}
		this.CharacterMovement.HitPriority = this.CreatureProperty.碰撞优先级;
		this.CharacterMovement.GoThroughPriority = this.CreatureProperty.穿透优先级;
	}

	// Token: 0x06017BF0 RID: 97264 RVA: 0x00707C95 File Offset: 0x00705E95
	public void ResetMass()
	{
		if (this.CreatureProperty == null)
		{
			return;
		}
		this.CharacterMovement.Mass = (float)this.CreatureProperty.重量;
	}

	// Token: 0x06017BF1 RID: 97265 RVA: 0x00707CBD File Offset: 0x00705EBD
	public bool CanResponseInput()
	{
		return this.CannotResponseInputCount == 0;
	}

	// Token: 0x06017BF2 RID: 97266 RVA: 0x00707CC8 File Offset: 0x00705EC8
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

	// Token: 0x06017BF3 RID: 97267 RVA: 0x00707DB3 File Offset: 0x00705FB3
	protected void CacheVar()
	{
		this.PreviousVelocity.DeepCopy(this.ActorComp.ActorVelocityProxy);
		this.PreviousAimYaw = this.ActorComp.ActorRotation.Yaw;
	}

	// Token: 0x06017BF4 RID: 97268 RVA: 0x00707DE4 File Offset: 0x00705FE4
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

	// Token: 0x06017BF5 RID: 97269 RVA: 0x00707E50 File Offset: 0x00706050
	public void StartCacheRootMotionRotationSpeedBlend()
	{
		if (this.RootMotionAfterTickId != -1)
		{
			TickSystem.Instance.Remove(this.RootMotionAfterTickId);
		}
		this.RootMotionAfterTickId = TickSystem.Instance.Add(new Action<float>(this.RootMotionAfterTickProxy), "BaseMovementAfterTickProxy", ETickingGroup.TG_PostPhysics, false, 0, false).Id;
	}

	// Token: 0x06017BF6 RID: 97270 RVA: 0x00707EA4 File Offset: 0x007060A4
	public void FinishCacheRootMotionRotationSpeedBlend(bool isGoingMove)
	{
		if (this.RootMotionAfterTickId != -1)
		{
			TickSystem.Instance.Remove(this.RootMotionAfterTickId);
			this.RootMotionAfterTickId = -1;
		}
		if (!isGoingMove)
		{
			return;
		}
		if (this.CharacterMovement != null)
		{
			CharacterAnimationComponent animComp = this.AnimComp;
			if (animComp != null && animComp.HasKuroRootMotion)
			{
				float currentValue = this.LastFrameAnimRootMotionRotateSpeed * 57.29578f;
				this.RootMotionRotationBlendFromSpeed = MathUtils.Instance.Clamp(currentValue, 0f, 1200f);
				this.RootMotionRotationBlendElapsed = 0f;
				return;
			}
		}
		this.RootMotionRotationBlendFromSpeed = -1f;
	}

	// Token: 0x06017BF7 RID: 97271 RVA: 0x00707F34 File Offset: 0x00706134
	protected float GetRotationSpeedWithRootMotionBlend(float targetSpeed)
	{
		if (this.RootMotionRotationBlendFromSpeed < 0f)
		{
			if (this.RootMotionAfterTickId != -1 && !MathUtils.Instance.IsNearlyZero((double)this.LastFrameAnimRootMotionRotateSpeed, null))
			{
				return this.LastFrameAnimRootMotionRotateSpeed * 57.29578f;
			}
			return targetSpeed;
		}
		else
		{
			this.RootMotionRotationBlendElapsed += this.DeltaTimeSeconds;
			float num = this.RootMotionRotationBlendElapsed / 0.25f;
			if (num >= 1f)
			{
				this.RootMotionRotationBlendFromSpeed = -1f;
				return targetSpeed;
			}
			return MathUtils.Instance.Lerp(this.RootMotionRotationBlendFromSpeed, targetSpeed, num);
		}
	}

	// Token: 0x06017BF8 RID: 97272 RVA: 0x00707FC9 File Offset: 0x007061C9
	public void SetLockedRotation(bool @lock)
	{
		this.IsLockedRotation = @lock;
	}

	// Token: 0x170024E5 RID: 9445
	// (get) Token: 0x06017BF9 RID: 97273 RVA: 0x00707FD2 File Offset: 0x007061D2
	public bool LockedRotation
	{
		get
		{
			return this.IsLockedRotation;
		}
	}

	// Token: 0x06017BFA RID: 97274 RVA: 0x00707FDC File Offset: 0x007061DC
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
		bool flag = base.Entity.GetTickInterval() > 1;
		if (this.CaptureFacingMode)
		{
			this.CapturedFacingRotator.DeepCopy(this.TmpRotator);
			this.HasCapturedFacing = true;
			return;
		}
		if (flag)
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

	// Token: 0x06017BFB RID: 97275 RVA: 0x00708154 File Offset: 0x00706354
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

	// Token: 0x06017BFC RID: 97276 RVA: 0x007081A2 File Offset: 0x007063A2
	public virtual bool ConsumeForceFallingSpeed()
	{
		return true;
	}

	// Token: 0x06017BFD RID: 97277 RVA: 0x007081A8 File Offset: 0x007063A8
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

	// Token: 0x06017BFE RID: 97278 RVA: 0x00708224 File Offset: 0x00706424
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

	// Token: 0x06017BFF RID: 97279 RVA: 0x007082C4 File Offset: 0x007064C4
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

	// Token: 0x06017C00 RID: 97280 RVA: 0x0070847C File Offset: 0x0070667C
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

	// Token: 0x06017C01 RID: 97281 RVA: 0x007084F2 File Offset: 0x007066F2
	public bool StopAddMove(int handler)
	{
		return this.VelocityAdditionMap.Remove(handler);
	}

	// Token: 0x06017C02 RID: 97282 RVA: 0x00708500 File Offset: 0x00706700
	public bool StopAddMoveWithMesh(UMeshComponent mesh)
	{
		int key;
		this.VelocityAdditionMapByMesh.TryGetValue(mesh, out key);
		return this.VelocityAdditionMap.Remove(key);
	}

	// Token: 0x06017C03 RID: 97283 RVA: 0x00708528 File Offset: 0x00706728
	public void StopAllAddMove()
	{
		this.VelocityAdditionMap.Clear();
	}

	// Token: 0x06017C04 RID: 97284 RVA: 0x00708538 File Offset: 0x00706738
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

	// Token: 0x06017C05 RID: 97285 RVA: 0x007085D4 File Offset: 0x007067D4
	private void RootMotionAfterTickProxy(float delta)
	{
		UCharacterMovementComponent characterMovement = this.CharacterMovement;
		if (characterMovement == null || !characterMovement.IsValid())
		{
			this.LastFrameAnimRootMotionRotateAxis.DeepCopy(global::Vector.UpVectorProxy);
			this.LastFrameAnimRootMotionRotateSpeed = 0f;
			return;
		}
		global::Vector lastFrameAnimRootMotionRotateAxis = this.LastFrameAnimRootMotionRotateAxis;
		FVector animRootMotionRotateAxis = this.CharacterMovement.AnimRootMotionRotateAxis;
		FVectorDouble fvectorDouble = animRootMotionRotateAxis;
		lastFrameAnimRootMotionRotateAxis.DeepCopy(fvectorDouble);
		this.LastFrameAnimRootMotionRotateSpeed = this.CharacterMovement.AnimRootMotionRotateSpeed;
	}

	// Token: 0x06017C06 RID: 97286 RVA: 0x00708648 File Offset: 0x00706848
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

	// Token: 0x06017C07 RID: 97287 RVA: 0x00708768 File Offset: 0x00706968
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

	// Token: 0x06017C08 RID: 97288 RVA: 0x00708B6C File Offset: 0x00706D6C
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

	// Token: 0x06017C09 RID: 97289 RVA: 0x00708C78 File Offset: 0x00706E78
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

	// Token: 0x06017C0A RID: 97290 RVA: 0x00708D83 File Offset: 0x00706F83
	public bool IsInAir()
	{
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		return unifiedStateComponent != null && unifiedStateComponent.PositionState == global::ECharPositionState.Air;
	}

	// Token: 0x06017C0B RID: 97291 RVA: 0x00708D9C File Offset: 0x00706F9C
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

	// Token: 0x06017C0C RID: 97292 RVA: 0x00708E3C File Offset: 0x0070703C
	public void SetSpeedLock()
	{
		this.SpeedLockFrame = 5;
	}

	// Token: 0x06017C0D RID: 97293 RVA: 0x00708E45 File Offset: 0x00707045
	public void SetOverrideMaxSpeed(float speed)
	{
		this.OverrideMaxSpeed = speed;
		this.SetMaxSpeed(speed);
	}

	// Token: 0x06017C0E RID: 97294 RVA: 0x00708E55 File Offset: 0x00707055
	public void ResetOverrideMaxSpeed()
	{
		this.OverrideMaxSpeed = 0f;
	}

	// Token: 0x170024E6 RID: 9446
	// (get) Token: 0x06017C0F RID: 97295 RVA: 0x00708E62 File Offset: 0x00707062
	// (set) Token: 0x06017C10 RID: 97296 RVA: 0x00708E6A File Offset: 0x0070706A
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

	// Token: 0x06017C11 RID: 97297 RVA: 0x00708E74 File Offset: 0x00707074
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

	// Token: 0x06017C12 RID: 97298 RVA: 0x00708F70 File Offset: 0x00707170
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

	// Token: 0x06017C13 RID: 97299 RVA: 0x00708FD0 File Offset: 0x007071D0
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

	// Token: 0x06017C14 RID: 97300 RVA: 0x0070904C File Offset: 0x0070724C
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

	// Token: 0x06017C15 RID: 97301 RVA: 0x007090A4 File Offset: 0x007072A4
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

	// Token: 0x06017C16 RID: 97302 RVA: 0x007091B0 File Offset: 0x007073B0
	protected void UpdateGroundedRotation()
	{
		float angleOffsetFromCurrentToInputAbs = GravityUtils.Instance.GetAngleOffsetFromCurrentToInputAbs(this.ActorComp);
		float rotationSpeedWithRootMotionBlend = this.GetRotationSpeedWithRootMotionBlend(this.CurrentMovementRotationSetting.GetSpeed(angleOffsetFromCurrentToInputAbs));
		BaseUnifiedStateComponent unifiedStateComponent = this.UnifiedStateComponent;
		if (unifiedStateComponent == null || unifiedStateComponent.MoveState != global::ECharMoveState.Stand || this.HasInputPrevFrame)
		{
			this.SmoothCharacterRotation(this.ActorComp.InputRotatorProxy, rotationSpeedWithRootMotionBlend, this.DeltaTimeSeconds, false, "Movement.UpdateGroundedRotation.ROTATION_MEDIUM", true);
		}
		this.HasInputPrevFrame = (angleOffsetFromCurrentToInputAbs > 1f);
	}

	// Token: 0x06017C17 RID: 97303 RVA: 0x00709230 File Offset: 0x00707430
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

	// Token: 0x06017C18 RID: 97304 RVA: 0x00709287 File Offset: 0x00707487
	protected void UpdateUsingControllerRotation()
	{
		this.SmoothCharacterRotation(this.ActorComp.InputRotatorProxy, 1500f, this.DeltaTimeSeconds, false, "Movement.UpdateGroundedRotation.ROTATION_AIM", true);
	}

	// Token: 0x06017C19 RID: 97305 RVA: 0x007092AC File Offset: 0x007074AC
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

	// Token: 0x06017C1A RID: 97306 RVA: 0x0070961B File Offset: 0x0070781B
	protected virtual float SpeedScaled(float speed)
	{
		return speed;
	}

	// Token: 0x170024E7 RID: 9447
	// (get) Token: 0x06017C1B RID: 97307 RVA: 0x0070961E File Offset: 0x0070781E
	// (set) Token: 0x06017C1C RID: 97308 RVA: 0x00709626 File Offset: 0x00707826
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

	// Token: 0x06017C1D RID: 97309 RVA: 0x0070962F File Offset: 0x0070782F
	public void AddInputMovementLock(string key)
	{
		this.InputMovementLocks.Add(key);
	}

	// Token: 0x06017C1E RID: 97310 RVA: 0x0070963E File Offset: 0x0070783E
	public void RemoveInputMovementLock(string key)
	{
		this.InputMovementLocks.Remove(key);
	}

	// Token: 0x06017C1F RID: 97311 RVA: 0x0070964D File Offset: 0x0070784D
	public bool CanApplyInputMovement()
	{
		return this.InputMovementLocks.Count == 0;
	}

	// Token: 0x06017C20 RID: 97312 RVA: 0x0070965D File Offset: 0x0070785D
	public virtual bool CanMove()
	{
		return this.CanMoveFromInputInternal && (this.CanMoveWithDistanceInternal || this.UnifiedStateComponent.IsInFighting);
	}

	// Token: 0x06017C21 RID: 97313 RVA: 0x0070967E File Offset: 0x0070787E
	public virtual bool CanMoveWithDistance()
	{
		return this.CanMoveWithDistanceInternal;
	}

	// Token: 0x06017C22 RID: 97314 RVA: 0x00709686 File Offset: 0x00707886
	public virtual bool CanJumpPress()
	{
		return false;
	}

	// Token: 0x06017C23 RID: 97315 RVA: 0x00709689 File Offset: 0x00707889
	public virtual bool CanWalkPress()
	{
		return false;
	}

	// Token: 0x06017C24 RID: 97316 RVA: 0x0070968C File Offset: 0x0070788C
	public bool IsMovingToLocation()
	{
		return this.MoveController.IsMoving();
	}

	// Token: 0x06017C25 RID: 97317 RVA: 0x00709699 File Offset: 0x00707899
	[NullableContext(2)]
	public void StopMoveWithCallback(ELevelEventState result, string context = null)
	{
		this.MoveController.StopMoveWithCallback(result, context);
	}

	// Token: 0x06017C26 RID: 97318 RVA: 0x007096A8 File Offset: 0x007078A8
	[NullableContext(2)]
	public void StopMoveToLocation(string context = null)
	{
		this.MoveController.StopMoveToLocation(context);
	}

	// Token: 0x06017C27 RID: 97319 RVA: 0x007096B6 File Offset: 0x007078B6
	public int MoveAlongPath(MoveCharacterConfig config, [Nullable(2)] string context = null)
	{
		this.IsStopInternal = false;
		return this.MoveController.MoveAlongPath(config, context);
	}

	// Token: 0x170024E8 RID: 9448
	// (get) Token: 0x06017C28 RID: 97320 RVA: 0x007096CC File Offset: 0x007078CC
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

	// Token: 0x06017C29 RID: 97321 RVA: 0x007096ED File Offset: 0x007078ED
	public void SetTurnRate(float v)
	{
		this.TurnRate = v;
	}

	// Token: 0x06017C2A RID: 97322 RVA: 0x007096F6 File Offset: 0x007078F6
	public void ResetTurnRate()
	{
		this.TurnRate = 1f;
	}

	// Token: 0x06017C2B RID: 97323 RVA: 0x00709703 File Offset: 0x00707903
	public void SetAirControl(float v)
	{
		this.CharacterMovement.AirControl = v;
	}

	// Token: 0x06017C2C RID: 97324 RVA: 0x00709711 File Offset: 0x00707911
	public void ResetAirControl()
	{
		this.CharacterMovement.AirControl = 0.05f;
	}

	// Token: 0x06017C2D RID: 97325 RVA: 0x00709723 File Offset: 0x00707923
	public void ResetCharTraceHeight()
	{
		this.CharHeightAboveGround = -1f;
		this.CharHeightAboveGroundDetectHeight = -1f;
		this.CharHeightAboveWater = -1f;
		this.CharHeightAboveWaterDetectHeight = -1f;
	}

	// Token: 0x06017C2E RID: 97326 RVA: 0x00709754 File Offset: 0x00707954
	protected override bool OnClear()
	{
		base.OnClear();
		if (this.RootMotionAfterTickId != -1)
		{
			TickSystem.Instance.Remove(this.RootMotionAfterTickId);
			this.RootMotionAfterTickId = -1;
		}
		this.IsNeedDelayCheckWalkOffLedge = false;
		this.InputMovementLocks.Clear();
		this.WalkOffLedgeCheckFrame = 0;
		this.RootMotionRotationBlendFromSpeed = -1f;
		this.RootMotionRotationBlendElapsed = 0f;
		this.LastFrameAnimRootMotionRotateAxis.DeepCopy(global::Vector.UpVectorProxy);
		this.LastFrameAnimRootMotionRotateSpeed = 0f;
		return true;
	}

	// Token: 0x06017C2F RID: 97327 RVA: 0x007097D4 File Offset: 0x007079D4
	public void AddPauseLock(string key)
	{
		this.PauseLocks[key] = true;
	}

	// Token: 0x06017C30 RID: 97328 RVA: 0x007097E4 File Offset: 0x007079E4
	public void RemovePauseLock(string key)
	{
		bool flag;
		this.PauseLocks.TryGetValue(key, out flag);
		if (flag)
		{
			this.PauseLocks.Remove(key);
		}
	}

	// Token: 0x06017C31 RID: 97329 RVA: 0x00709810 File Offset: 0x00707A10
	public void SetInputMaxDegree(float degree)
	{
		this.MaxMoveDegree = degree;
	}

	// Token: 0x06017C32 RID: 97330 RVA: 0x00709819 File Offset: 0x00707A19
	public void SetInputScale(float scale)
	{
		this.InputScale = scale;
	}

	// Token: 0x06017C33 RID: 97331 RVA: 0x00709822 File Offset: 0x00707A22
	public bool HasInputMoveLimit()
	{
		return this.MaxMoveDegree > 0f;
	}

	// Token: 0x06017C34 RID: 97332 RVA: 0x00709834 File Offset: 0x00707A34
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

	// Token: 0x06017C35 RID: 97333 RVA: 0x00709930 File Offset: 0x00707B30
	public static void CreateStaticDefaultValue()
	{
		BaseMoveComponent.VelocityAdditionTotal = global::Vector.Create();
		BaseMoveComponent.VelocityAdditionDestination = global::Vector.Create();
	}

	// Token: 0x06017C36 RID: 97334 RVA: 0x00709946 File Offset: 0x00707B46
	public static void ResetStaticDefaultValue()
	{
		BaseMoveComponent.BaseMoveInheritCurveInternal = null;
		BaseMoveComponent.VelocityAdditionTotal = null;
		BaseMoveComponent.VelocityAdditionDestination = null;
	}

	// Token: 0x06017C37 RID: 97335 RVA: 0x0070995C File Offset: 0x00707B5C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseMoveComponent baseMoveComponent = (BaseMoveComponent)componentTemplate;
		this.IsInputDrivenCharacter = baseMoveComponent.IsInputDrivenCharacter;
		if (baseMoveComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (baseMoveComponent.CharacterMovement == null)
		{
			this.CharacterMovement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CharacterMovement), "CharacterMovement"))
		{
			return false;
		}
		if (baseMoveComponent.AnimComp == null)
		{
			this.AnimComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AnimComp), "AnimComp"))
		{
			return false;
		}
		if (baseMoveComponent.TimeScaleComp == null)
		{
			this.TimeScaleComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TimeScaleComp), "TimeScaleComp"))
		{
			return false;
		}
		if (baseMoveComponent.MoveControllerInternal == null)
		{
			this.MoveControllerInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveControllerInternal), "MoveControllerInternal"))
		{
			return false;
		}
		this.HasMoveInput = baseMoveComponent.HasMoveInput;
		this.ForceExitStateStop = baseMoveComponent.ForceExitStateStop;
		this.IsMoving = baseMoveComponent.IsMoving;
		this.Speed = baseMoveComponent.Speed;
		this.IsSpecialMove = baseMoveComponent.IsSpecialMove;
		this.NeedRootMotionWhenAttached = baseMoveComponent.NeedRootMotionWhenAttached;
		this.CanMoveWithDistanceInternal = baseMoveComponent.CanMoveWithDistanceInternal;
		this.CanMoveFromInputInternal = baseMoveComponent.CanMoveFromInputInternal;
		if (baseMoveComponent.InputMovementLocks != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<string>(this.InputMovementLocks), "InputMovementLocks"))
		{
			return false;
		}
		this.DeltaTimeSeconds = baseMoveComponent.DeltaTimeSeconds;
		this.JumpUpRate = baseMoveComponent.JumpUpRate;
		this.ConfigChainLengthSquared = baseMoveComponent.ConfigChainLengthSquared;
		this.CurrentChainLengthSquared = baseMoveComponent.CurrentChainLengthSquared;
		if (baseMoveComponent.ChainCenter != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChainCenter), "ChainCenter"))
		{
			return false;
		}
		if (baseMoveComponent.ChainTempPredicted != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChainTempPredicted), "ChainTempPredicted"))
		{
			return false;
		}
		if (baseMoveComponent.ChainTempToCenter != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ChainTempToCenter), "ChainTempToCenter"))
		{
			return false;
		}
		this.RootMotionAfterTickId = baseMoveComponent.RootMotionAfterTickId;
		if (baseMoveComponent.LastFrameAnimRootMotionRotateAxis != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastFrameAnimRootMotionRotateAxis), "LastFrameAnimRootMotionRotateAxis"))
		{
			return false;
		}
		this.LastFrameAnimRootMotionRotateSpeed = baseMoveComponent.LastFrameAnimRootMotionRotateSpeed;
		if (baseMoveComponent.ForceSpeed != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ForceSpeed), "ForceSpeed"))
		{
			return false;
		}
		if (baseMoveComponent.Acceleration == null)
		{
			this.Acceleration = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Acceleration), "Acceleration"))
		{
			return false;
		}
		if (baseMoveComponent.PreviousVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.PreviousVelocity), "PreviousVelocity"))
		{
			return false;
		}
		if (baseMoveComponent.TmpVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector), "TmpVector"))
		{
			return false;
		}
		if (baseMoveComponent.TmpVector2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpVector2), "TmpVector2"))
		{
			return false;
		}
		if (baseMoveComponent.TmpQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat), "TmpQuat"))
		{
			return false;
		}
		if (baseMoveComponent.TmpQuat2 != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpQuat2), "TmpQuat2"))
		{
			return false;
		}
		if (baseMoveComponent.TmpRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.TmpRotator), "TmpRotator"))
		{
			return false;
		}
		this.PreviousAimYaw = baseMoveComponent.PreviousAimYaw;
		this.AimYawRate = baseMoveComponent.AimYawRate;
		this.RootMotionRotationBlendFromSpeed = baseMoveComponent.RootMotionRotationBlendFromSpeed;
		this.RootMotionRotationBlendElapsed = baseMoveComponent.RootMotionRotationBlendElapsed;
		this.IsFallingIntoWater = baseMoveComponent.IsFallingIntoWater;
		this.JumpFrameCount = baseMoveComponent.JumpFrameCount;
		this.CharHeightAboveGround = baseMoveComponent.CharHeightAboveGround;
		this.CharHeightAboveGroundDetectHeight = baseMoveComponent.CharHeightAboveGroundDetectHeight;
		this.CharHeightAboveWater = baseMoveComponent.CharHeightAboveWater;
		this.CharHeightAboveWaterDetectHeight = baseMoveComponent.CharHeightAboveWaterDetectHeight;
		if (baseMoveComponent.CreatureProperty == null)
		{
			this.CreatureProperty = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureProperty), "CreatureProperty"))
		{
			return false;
		}
		if (baseMoveComponent.DefaultMovementData == null)
		{
			this.DefaultMovementData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DefaultMovementData), "DefaultMovementData"))
		{
			return false;
		}
		if (baseMoveComponent.MovementDataMap == null)
		{
			this.MovementDataMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MovementDataMap), "MovementDataMap"))
		{
			return false;
		}
		if (baseMoveComponent.MovementData == null)
		{
			this.MovementData = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MovementData), "MovementData"))
		{
			return false;
		}
		if (baseMoveComponent.CurrentMovementSettingsInternal == null)
		{
			this.CurrentMovementSettingsInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentMovementSettingsInternal), "CurrentMovementSettingsInternal"))
		{
			return false;
		}
		if (baseMoveComponent.CurrentMovementRotationSetting != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentMovementRotationSetting), "CurrentMovementRotationSetting"))
		{
			return false;
		}
		if (baseMoveComponent.UnifiedStateComponent == null)
		{
			this.UnifiedStateComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedStateComponent), "UnifiedStateComponent"))
		{
			return false;
		}
		this.HasBaseMovement = baseMoveComponent.HasBaseMovement;
		this.OldMovementMode = baseMoveComponent.OldMovementMode;
		this.IsHidden = baseMoveComponent.IsHidden;
		this.HasDeltaBaseMovementData = baseMoveComponent.HasDeltaBaseMovementData;
		this.DeltaBaseMovementOffset = baseMoveComponent.DeltaBaseMovementOffset;
		this.DeltaBaseMovementSpeed = baseMoveComponent.DeltaBaseMovementSpeed;
		this.DeltaConveyBeltSpeed = baseMoveComponent.DeltaConveyBeltSpeed;
		if (baseMoveComponent.DeltaBaseMovementQuat == null)
		{
			this.DeltaBaseMovementQuat = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DeltaBaseMovementQuat), "DeltaBaseMovementQuat"))
		{
			return false;
		}
		if (baseMoveComponent.BasedMovementActor == null)
		{
			this.BasedMovementActor = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BasedMovementActor), "BasedMovementActor"))
		{
			return false;
		}
		if (baseMoveComponent.BasePlatform == null)
		{
			this.BasePlatform = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.BasePlatform), "BasePlatform"))
		{
			return false;
		}
		this.IsLockedRotation = baseMoveComponent.IsLockedRotation;
		this.CaptureFacingMode = baseMoveComponent.CaptureFacingMode;
		this.HasCapturedFacing = baseMoveComponent.HasCapturedFacing;
		if (baseMoveComponent.CapturedFacingRotator != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CapturedFacingRotator), "CapturedFacingRotator"))
		{
			return false;
		}
		this.SpeedLockFrame = baseMoveComponent.SpeedLockFrame;
		this.OverrideMaxSpeed = baseMoveComponent.OverrideMaxSpeed;
		if (baseMoveComponent.VelocityVector != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.VelocityVector), "VelocityVector"))
		{
			return false;
		}
		this.IsStopInternal = baseMoveComponent.IsStopInternal;
		if (baseMoveComponent.DebugMovementSetting == null)
		{
			this.DebugMovementSetting = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugMovementSetting), "DebugMovementSetting"))
		{
			return false;
		}
		this.UseDebugMovementSetting = baseMoveComponent.UseDebugMovementSetting;
		this.WalkOffCount = baseMoveComponent.WalkOffCount;
		this.PerchEdgeDirectionCount = baseMoveComponent.PerchEdgeDirectionCount;
		this.CannotResponseInputCount = baseMoveComponent.CannotResponseInputCount;
		if (baseMoveComponent.CapsuleOffset == null)
		{
			this.CapsuleOffset = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CapsuleOffset), "CapsuleOffset"))
		{
			return false;
		}
		if (baseMoveComponent.SphereTrace == null)
		{
			this.SphereTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SphereTrace), "SphereTrace"))
		{
			return false;
		}
		if (baseMoveComponent.WaterSphereTrace == null)
		{
			this.WaterSphereTrace = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.WaterSphereTrace), "WaterSphereTrace"))
		{
			return false;
		}
		this.AccelerationChangeMoveState = baseMoveComponent.AccelerationChangeMoveState;
		if (baseMoveComponent.AccelerationLerpCurve == null)
		{
			this.AccelerationLerpCurve = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AccelerationLerpCurve), "AccelerationLerpCurve"))
		{
			return false;
		}
		this.FallingHorizontalMaxSpeed = baseMoveComponent.FallingHorizontalMaxSpeed;
		this.DesireMaxAccelerationLerpTime = baseMoveComponent.DesireMaxAccelerationLerpTime;
		this.MaxAccelerationLerpTime = baseMoveComponent.MaxAccelerationLerpTime;
		this.IsNeedDelayCheckWalkOffLedge = baseMoveComponent.IsNeedDelayCheckWalkOffLedge;
		this.WalkOffLedgeCheckFrame = baseMoveComponent.WalkOffLedgeCheckFrame;
		this.TurnRate = baseMoveComponent.TurnRate;
		this.IsRegionMoveMode = baseMoveComponent.IsRegionMoveMode;
		if (baseMoveComponent.GravityDirectInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravityDirectInternal), "GravityDirectInternal"))
		{
			return false;
		}
		if (baseMoveComponent.GravityUpInternal != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.GravityUpInternal), "GravityUpInternal"))
		{
			return false;
		}
		this.IsStandardGravityInternal = baseMoveComponent.IsStandardGravityInternal;
		if (baseMoveComponent.JumpDelayTimer == null)
		{
			this.JumpDelayTimer = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.JumpDelayTimer), "JumpDelayTimer"))
		{
			return false;
		}
		this.GroundedTimeUe = baseMoveComponent.GroundedTimeUe;
		this.VelocityAdditionIncId = baseMoveComponent.VelocityAdditionIncId;
		if (baseMoveComponent.VelocityAdditionMap != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.VelocityAdditionMap), "VelocityAdditionMap"))
		{
			return false;
		}
		if (baseMoveComponent.VelocityAdditionMapByMesh != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.VelocityAdditionMapByMesh), "VelocityAdditionMapByMesh"))
		{
			return false;
		}
		this.AddMoveOffset = baseMoveComponent.AddMoveOffset;
		if (baseMoveComponent.AddMoveRotation == null)
		{
			this.AddMoveRotation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AddMoveRotation), "AddMoveRotation"))
		{
			return false;
		}
		if (baseMoveComponent.CurrentGravityScale == null)
		{
			this.CurrentGravityScale = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CurrentGravityScale), "CurrentGravityScale"))
		{
			return false;
		}
		this.HasInputPrevFrame = baseMoveComponent.HasInputPrevFrame;
		if (baseMoveComponent.PauseLocks == null)
		{
			this.PauseLocks = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PauseLocks), "PauseLocks"))
		{
			return false;
		}
		this.MaxMoveDegree = baseMoveComponent.MaxMoveDegree;
		this.InputScale = baseMoveComponent.InputScale;
		return true;
	}

	// Token: 0x170024E9 RID: 9449
	// (get) Token: 0x06017C38 RID: 97336 RVA: 0x0070A2D4 File Offset: 0x007084D4
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024EA RID: 9450
	// (get) Token: 0x06017C39 RID: 97337 RVA: 0x0070A2D7 File Offset: 0x007084D7
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024EB RID: 9451
	// (get) Token: 0x06017C3A RID: 97338 RVA: 0x0070A2DA File Offset: 0x007084DA
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024EC RID: 9452
	// (get) Token: 0x06017C3B RID: 97339 RVA: 0x0070A2DD File Offset: 0x007084DD
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170024ED RID: 9453
	// (get) Token: 0x06017C3C RID: 97340 RVA: 0x0070A2E0 File Offset: 0x007084E0
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CA7A RID: 51834
	[Nullable(2)]
	protected static UCurveFloat BaseMoveInheritCurveInternal;

	// Token: 0x0400CA7B RID: 51835
	public const string PROFILE_KEY = "CharacterMoveComponent_GetHeightAboveGround";

	// Token: 0x0400CA7C RID: 51836
	public const float ROTATION_AIM = 1500f;

	// Token: 0x0400CA7D RID: 51837
	public const float HEIGHT_DETECT = 500f;

	// Token: 0x0400CA7E RID: 51838
	public const float ROTATABLE_THREADHOLD = 0.5f;

	// Token: 0x0400CA7F RID: 51839
	public const float ROOT_MOTION_ROTATION_BLEND_DURATION = 0.25f;

	// Token: 0x0400CA80 RID: 51840
	public const float ROOT_MOTION_ROTATION_BLEND_MAX_START_SPEED = 1200f;

	// Token: 0x0400CA81 RID: 51841
	public const float BASE_MOVEMENT_VELOCITY_RATE = 0.2f;

	// Token: 0x0400CA82 RID: 51842
	public const int SPEED_LOCK_FRAME = 5;

	// Token: 0x0400CA83 RID: 51843
	public const float INVALID_FORCE_SPEED = -100000000f;

	// Token: 0x0400CA84 RID: 51844
	public const bool OPEN_DEBUG = false;

	// Token: 0x0400CA85 RID: 51845
	public const float DEFAULT_MAX_FALLING_VELOCITY_2D = 700f;

	// Token: 0x0400CA86 RID: 51846
	public const float DEFAULT_AIR_CONTROL = 0.05f;

	// Token: 0x0400CA87 RID: 51847
	public const int WALK_OFF_LEDGE_DELAY_FRAME = 1;

	// Token: 0x0400CA88 RID: 51848
	protected bool IsInputDrivenCharacter;

	// Token: 0x0400CA89 RID: 51849
	[Nullable(2)]
	public CharacterActorComponent ActorComp;

	// Token: 0x0400CA8A RID: 51850
	[Nullable(2)]
	public UCharacterMovementComponent CharacterMovement;

	// Token: 0x0400CA8B RID: 51851
	[Nullable(2)]
	protected CharacterAnimationComponent AnimComp;

	// Token: 0x0400CA8C RID: 51852
	[Nullable(2)]
	protected PawnTimeScaleComponent TimeScaleComp;

	// Token: 0x0400CA8D RID: 51853
	[Nullable(2)]
	protected MoveToLocationController MoveControllerInternal;

	// Token: 0x0400CA8E RID: 51854
	public bool HasMoveInput;

	// Token: 0x0400CA8F RID: 51855
	public bool ForceExitStateStop;

	// Token: 0x0400CA90 RID: 51856
	public bool IsMoving;

	// Token: 0x0400CA91 RID: 51857
	public float Speed;

	// Token: 0x0400CA92 RID: 51858
	public bool IsSpecialMove;

	// Token: 0x0400CA93 RID: 51859
	public bool NeedRootMotionWhenAttached;

	// Token: 0x0400CA94 RID: 51860
	protected bool CanMoveWithDistanceInternal = true;

	// Token: 0x0400CA95 RID: 51861
	protected bool CanMoveFromInputInternal = true;

	// Token: 0x0400CA96 RID: 51862
	private readonly HashSet<string> InputMovementLocks = new HashSet<string>();

	// Token: 0x0400CA97 RID: 51863
	protected float DeltaTimeSeconds;

	// Token: 0x0400CA98 RID: 51864
	public float JumpUpRate = 1f;

	// Token: 0x0400CA99 RID: 51865
	protected double ConfigChainLengthSquared = -1.0;

	// Token: 0x0400CA9A RID: 51866
	protected double CurrentChainLengthSquared;

	// Token: 0x0400CA9B RID: 51867
	protected readonly global::Vector ChainCenter = global::Vector.Create();

	// Token: 0x0400CA9C RID: 51868
	private readonly global::Vector ChainTempPredicted = global::Vector.Create();

	// Token: 0x0400CA9D RID: 51869
	private readonly global::Vector ChainTempToCenter = global::Vector.Create();

	// Token: 0x0400CA9E RID: 51870
	public int RootMotionAfterTickId = -1;

	// Token: 0x0400CA9F RID: 51871
	public readonly global::Vector LastFrameAnimRootMotionRotateAxis = global::Vector.Create();

	// Token: 0x0400CAA0 RID: 51872
	public float LastFrameAnimRootMotionRotateSpeed;

	// Token: 0x0400CAA1 RID: 51873
	protected readonly global::Vector ForceSpeed = global::Vector.Create(-100000000.0, -100000000.0, -100000000.0);

	// Token: 0x0400CAA2 RID: 51874
	public global::Vector Acceleration = global::Vector.Create();

	// Token: 0x0400CAA3 RID: 51875
	protected readonly global::Vector PreviousVelocity = global::Vector.Create();

	// Token: 0x0400CAA4 RID: 51876
	protected readonly global::Vector TmpVector = global::Vector.Create();

	// Token: 0x0400CAA5 RID: 51877
	protected readonly global::Vector TmpVector2 = global::Vector.Create();

	// Token: 0x0400CAA6 RID: 51878
	protected readonly Quat TmpQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CAA7 RID: 51879
	protected readonly Quat TmpQuat2 = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CAA8 RID: 51880
	protected readonly global::Rotator TmpRotator = global::Rotator.Create();

	// Token: 0x0400CAA9 RID: 51881
	protected float PreviousAimYaw;

	// Token: 0x0400CAAA RID: 51882
	public float AimYawRate;

	// Token: 0x0400CAAB RID: 51883
	protected float RootMotionRotationBlendFromSpeed = -1f;

	// Token: 0x0400CAAC RID: 51884
	protected float RootMotionRotationBlendElapsed;

	// Token: 0x0400CAAD RID: 51885
	public bool IsFallingIntoWater;

	// Token: 0x0400CAAE RID: 51886
	protected int JumpFrameCount;

	// Token: 0x0400CAAF RID: 51887
	protected float CharHeightAboveGround = -1f;

	// Token: 0x0400CAB0 RID: 51888
	protected float CharHeightAboveGroundDetectHeight = -1f;

	// Token: 0x0400CAB1 RID: 51889
	protected float CharHeightAboveWater = -1f;

	// Token: 0x0400CAB2 RID: 51890
	protected float CharHeightAboveWaterDetectHeight = -1f;

	// Token: 0x0400CAB3 RID: 51891
	[Nullable(2)]
	protected SEntityProperty CreatureProperty;

	// Token: 0x0400CAB4 RID: 51892
	[Nullable(2)]
	protected SMovementSetting_State DefaultMovementData;

	// Token: 0x0400CAB5 RID: 51893
	protected Dictionary<int, SMovementSetting_State> MovementDataMap = new Dictionary<int, SMovementSetting_State>();

	// Token: 0x0400CAB6 RID: 51894
	[Nullable(2)]
	public SMovementSetting_State MovementData;

	// Token: 0x0400CAB7 RID: 51895
	[Nullable(2)]
	private SMovementSetting CurrentMovementSettingsInternal;

	// Token: 0x0400CAB8 RID: 51896
	public readonly RotationSetting CurrentMovementRotationSetting = new RotationSetting();

	// Token: 0x0400CAB9 RID: 51897
	[Nullable(2)]
	protected BaseUnifiedStateComponent UnifiedStateComponent;

	// Token: 0x0400CABA RID: 51898
	public bool HasBaseMovement;

	// Token: 0x0400CABB RID: 51899
	protected EMovementMode? OldMovementMode;

	// Token: 0x0400CABC RID: 51900
	protected bool IsHidden;

	// Token: 0x0400CABD RID: 51901
	public bool HasDeltaBaseMovementData;

	// Token: 0x0400CABE RID: 51902
	public FVectorDouble? DeltaBaseMovementOffset;

	// Token: 0x0400CABF RID: 51903
	public FVectorDouble? DeltaBaseMovementSpeed;

	// Token: 0x0400CAC0 RID: 51904
	public FVectorDouble? DeltaConveyBeltSpeed;

	// Token: 0x0400CAC1 RID: 51905
	public Quat DeltaBaseMovementQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400CAC2 RID: 51906
	[Nullable(2)]
	private AActor BasedMovementActor;

	// Token: 0x0400CAC3 RID: 51907
	[Nullable(2)]
	public BasePlatform BasePlatform;

	// Token: 0x0400CAC4 RID: 51908
	protected bool IsLockedRotation;

	// Token: 0x0400CAC5 RID: 51909
	protected bool CaptureFacingMode;

	// Token: 0x0400CAC6 RID: 51910
	protected bool HasCapturedFacing;

	// Token: 0x0400CAC7 RID: 51911
	protected readonly global::Rotator CapturedFacingRotator = global::Rotator.Create();

	// Token: 0x0400CAC8 RID: 51912
	protected int SpeedLockFrame;

	// Token: 0x0400CAC9 RID: 51913
	protected float OverrideMaxSpeed;

	// Token: 0x0400CACA RID: 51914
	protected readonly global::Vector VelocityVector = global::Vector.Create();

	// Token: 0x0400CACB RID: 51915
	protected bool IsStopInternal;

	// Token: 0x0400CACC RID: 51916
	[Nullable(2)]
	protected SMovementSetting DebugMovementSetting;

	// Token: 0x0400CACD RID: 51917
	protected bool UseDebugMovementSetting;

	// Token: 0x0400CACE RID: 51918
	protected int WalkOffCount;

	// Token: 0x0400CACF RID: 51919
	private int PerchEdgeDirectionCount;

	// Token: 0x0400CAD0 RID: 51920
	protected int CannotResponseInputCount;

	// Token: 0x0400CAD1 RID: 51921
	[Nullable(2)]
	protected global::Vector CapsuleOffset;

	// Token: 0x0400CAD2 RID: 51922
	[Nullable(2)]
	protected UTraceSphereElement SphereTrace;

	// Token: 0x0400CAD3 RID: 51923
	[Nullable(2)]
	protected UTraceSphereElement WaterSphereTrace;

	// Token: 0x0400CAD4 RID: 51924
	public global::ECharMoveState? AccelerationChangeMoveState;

	// Token: 0x0400CAD5 RID: 51925
	[Nullable(2)]
	protected UCurveFloat AccelerationLerpCurve;

	// Token: 0x0400CAD6 RID: 51926
	protected float FallingHorizontalMaxSpeed = 700f;

	// Token: 0x0400CAD7 RID: 51927
	protected float DesireMaxAccelerationLerpTime;

	// Token: 0x0400CAD8 RID: 51928
	protected float MaxAccelerationLerpTime;

	// Token: 0x0400CAD9 RID: 51929
	private bool IsNeedDelayCheckWalkOffLedge;

	// Token: 0x0400CADA RID: 51930
	private int WalkOffLedgeCheckFrame;

	// Token: 0x0400CADB RID: 51931
	protected float TurnRate = 1f;

	// Token: 0x0400CADC RID: 51932
	public bool IsRegionMoveMode;

	// Token: 0x0400CADD RID: 51933
	protected readonly global::Vector GravityDirectInternal = global::Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400CADE RID: 51934
	protected readonly global::Vector GravityUpInternal = global::Vector.Create(0.0, 0.0, 1.0);

	// Token: 0x0400CADF RID: 51935
	protected bool IsStandardGravityInternal = true;

	// Token: 0x0400CAE0 RID: 51936
	[Nullable(2)]
	protected TimerHandle JumpDelayTimer;

	// Token: 0x0400CAE1 RID: 51937
	public float GroundedTimeUe;

	// Token: 0x0400CAE2 RID: 51938
	protected int VelocityAdditionIncId = 1;

	// Token: 0x0400CAE3 RID: 51939
	protected static global::Vector VelocityAdditionTotal;

	// Token: 0x0400CAE4 RID: 51940
	protected static global::Vector VelocityAdditionDestination;

	// Token: 0x0400CAE5 RID: 51941
	protected readonly Dictionary<int, VelocityAddition> VelocityAdditionMap = new Dictionary<int, VelocityAddition>();

	// Token: 0x0400CAE6 RID: 51942
	protected readonly Dictionary<UMeshComponent, int> VelocityAdditionMapByMesh = new Dictionary<UMeshComponent, int>();

	// Token: 0x0400CAE7 RID: 51943
	protected FVectorDouble? AddMoveOffset;

	// Token: 0x0400CAE8 RID: 51944
	protected global::Rotator AddMoveRotation = global::Rotator.Create();

	// Token: 0x0400CAE9 RID: 51945
	[Nullable(2)]
	public GravityScale CurrentGravityScale;

	// Token: 0x0400CAEA RID: 51946
	private bool HasInputPrevFrame;

	// Token: 0x0400CAEB RID: 51947
	protected Dictionary<string, bool> PauseLocks = new Dictionary<string, bool>();

	// Token: 0x0400CAEC RID: 51948
	protected float MaxMoveDegree;

	// Token: 0x0400CAED RID: 51949
	protected float InputScale = 1f;
}
