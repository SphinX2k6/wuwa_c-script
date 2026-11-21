using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

// Token: 0x020025D3 RID: 9683
[NullableContext(1)]
[Nullable(0)]
public class CharacterMovementSyncComponent : BaseMovementSyncComponent
{
	// Token: 0x060181E6 RID: 98790 RVA: 0x0073D209 File Offset: 0x0073B409
	private void OnCharSkillEnd(int entityId, int skillId)
	{
		this.CurEndSkillId = (long)skillId;
	}

	// Token: 0x170025BF RID: 9663
	// (get) Token: 0x060181E7 RID: 98791 RVA: 0x0073D213 File Offset: 0x0073B413
	private CharacterActorComponent CharActorComp
	{
		get
		{
			return this.ActorComp as CharacterActorComponent;
		}
	}

	// Token: 0x060181E8 RID: 98792 RVA: 0x0073D220 File Offset: 0x0073B420
	public CharacterMovementSyncComponent()
	{
		this.FastMoveSampleInternal = this.ReadOnlyFastMoveSampleInfo;
	}

	// Token: 0x060181E9 RID: 98793 RVA: 0x0073D259 File Offset: 0x0073B459
	protected override bool DefaultEnableMovementSync()
	{
		return true;
	}

	// Token: 0x060181EA RID: 98794 RVA: 0x0073D25C File Offset: 0x0073B45C
	protected override bool GetIsMoving()
	{
		int movementModeFromSample = this.GetMovementModeFromSample();
		double num = (double)base.Entity.TimeDilation;
		CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		float? num2 = (timeScaleComp != null) ? new float?(timeScaleComp.CurrentTimeScale) : null;
		double num3 = num * ((num2 != null) ? ((double)num2.GetValueOrDefault()) : 1.0);
		if (this.LastMovementMode == movementModeFromSample)
		{
			BaseUnifiedStateComponent unifiedComp = this.UnifiedComp;
			if ((unifiedComp == null || unifiedComp.DirectionState != ECharDirectionState.AimDirection) && !this.LastHasBaseMovement && this.GetLinearVelocityFromSample().IsZero() && this.LastLocation.Equals(this.GetLocationFromSample(), 9.999999747378752E-05) && this.LastRotation.Equals(this.GetRotationFromSample(), 0.0001f))
			{
				return this.LastTimeScale != num3;
			}
		}
		return true;
	}

	// Token: 0x060181EB RID: 98795 RVA: 0x0073D334 File Offset: 0x0073B534
	protected override bool GetImportantMove(bool moving)
	{
		int movementModeFromSample = this.GetMovementModeFromSample();
		double num = (double)base.Entity.TimeDilation;
		CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		float? num2 = (timeScaleComp != null) ? new float?(timeScaleComp.CurrentTimeScale) : null;
		double num3 = num * ((num2 != null) ? ((double)num2.GetValueOrDefault()) : 1.0);
		return this.LastMovementMode != movementModeFromSample || this.LastHasBaseMovement != this.MoveComp.HasBaseMovement || this.LastTimeScale != num3 || (!moving && this.LastMove);
	}

	// Token: 0x060181EC RID: 98796 RVA: 0x0073D3CC File Offset: 0x0073B5CC
	protected override bool GetSecondaryImportantMove()
	{
		if (this.CurEndSkillId <= 0L)
		{
			MoveReplaySample lastMoveSample = this.LastMoveSample;
			int? num = (lastMoveSample != null) ? new int?(lastMoveSample.MoveState) : null;
			int moveState = (int)this.UnifiedComp.MoveState;
			return !(num.GetValueOrDefault() == moveState & num != null);
		}
		return true;
	}

	// Token: 0x060181ED RID: 98797 RVA: 0x0073D428 File Offset: 0x0073B628
	protected override void CustomAfterTickInternal(float delta)
	{
		this.UpdateFastMoveSampleBase((double)delta);
		bool flag = this.DriveVehicleComp != null && this.DriveVehicleComp.Seat >= 0;
		if (this.CacheBaseEntityHandle != null && this.TransformFromRelativeMove(this.CacheBaseEntityHandle, this.CacheRelativeLocation, this.CacheRelativeRotator, this.CacheFinalLocation, this.CacheFinalRotator))
		{
			BaseActorComponent actorComp = this.ActorComp;
			if ((actorComp == null || !actorComp.IsMoveAutonomousProxy) && !flag)
			{
				this.ActorComp.SetActorLocationAndRotation(this.CacheFinalLocation.ToUeVector(false), this.CacheFinalRotator.ToUeRotator(), "角色移动同步.添加简单位移(帧末修正相对位置)", false, null);
				this.LastRelativeMove = true;
			}
		}
		base.CustomAfterTickInternal(delta);
	}

	// Token: 0x060181EE RID: 98798 RVA: 0x0073D4E2 File Offset: 0x0073B6E2
	public override void TickReplaySamples()
	{
		if (this.DriveVehicleComp != null && this.DriveVehicleComp.Seat >= 0)
		{
			return;
		}
		base.TickReplaySamples();
	}

	// Token: 0x060181EF RID: 98799 RVA: 0x0073D504 File Offset: 0x0073B704
	private void UpdateFastMoveSampleBase(double delta)
	{
		CharacterActorComponent charActorComp = this.CharActorComp;
		if (charActorComp != null && charActorComp.IsActorMoveInfoCache)
		{
			if (!this.ReadOnlyFastMoveSampleInfo.IsInit)
			{
				this.ReadOnlyFastMoveSampleInfo.IsInit = true;
				ReadOnlyFastMoveSample readOnlyFastMoveSampleInfo = this.ReadOnlyFastMoveSampleInfo;
				CharacterActorComponent charActorComp2 = this.CharActorComp;
				readOnlyFastMoveSampleInfo.Location = ((charActorComp2 != null) ? charActorComp2.ActorLocationProxy : null);
				ReadOnlyFastMoveSample readOnlyFastMoveSampleInfo2 = this.ReadOnlyFastMoveSampleInfo;
				CharacterActorComponent charActorComp3 = this.CharActorComp;
				readOnlyFastMoveSampleInfo2.Rotation = ((charActorComp3 != null) ? charActorComp3.ActorRotationProxy : null);
				ReadOnlyFastMoveSample readOnlyFastMoveSampleInfo3 = this.ReadOnlyFastMoveSampleInfo;
				CharacterActorComponent charActorComp4 = this.CharActorComp;
				readOnlyFastMoveSampleInfo3.LinearVelocity = ((charActorComp4 != null) ? charActorComp4.ActorVelocityProxy : null);
			}
			this.ReadOnlyFastMoveSampleInfo.MovementMode = (int)this.MoveComp.CharacterMovement.MovementMode;
			this.FastMoveSampleInternal = this.ReadOnlyFastMoveSampleInfo;
			return;
		}
		this.UpdateFastMoveSampleBase(ref this.FastMoveSampleInfo, this.CharActorComp.Actor, this.MoveComp.CharacterMovement);
		this.FastMoveSampleInternal = this.FastMoveSampleInfo;
	}

	// Token: 0x060181F0 RID: 98800 RVA: 0x0073D5F4 File Offset: 0x0073B7F4
	private int GetMovementModeFromSample()
	{
		FastMoveSample fastMoveSample = this.FastMoveSampleInternal as FastMoveSample;
		if (fastMoveSample != null)
		{
			return fastMoveSample.MovementMode;
		}
		ReadOnlyFastMoveSample readOnlyFastMoveSample = this.FastMoveSampleInternal as ReadOnlyFastMoveSample;
		if (readOnlyFastMoveSample != null)
		{
			return readOnlyFastMoveSample.MovementMode;
		}
		return 0;
	}

	// Token: 0x060181F1 RID: 98801 RVA: 0x0073D630 File Offset: 0x0073B830
	private global::Vector GetLocationFromSample()
	{
		FastMoveSample fastMoveSample = this.FastMoveSampleInternal as FastMoveSample;
		if (fastMoveSample != null)
		{
			return fastMoveSample.Location;
		}
		ReadOnlyFastMoveSample readOnlyFastMoveSample = this.FastMoveSampleInternal as ReadOnlyFastMoveSample;
		if (readOnlyFastMoveSample != null)
		{
			return readOnlyFastMoveSample.Location;
		}
		return global::Vector.Create();
	}

	// Token: 0x060181F2 RID: 98802 RVA: 0x0073D670 File Offset: 0x0073B870
	private global::Rotator GetRotationFromSample()
	{
		FastMoveSample fastMoveSample = this.FastMoveSampleInternal as FastMoveSample;
		if (fastMoveSample != null)
		{
			return fastMoveSample.Rotation;
		}
		ReadOnlyFastMoveSample readOnlyFastMoveSample = this.FastMoveSampleInternal as ReadOnlyFastMoveSample;
		if (readOnlyFastMoveSample != null)
		{
			return readOnlyFastMoveSample.Rotation;
		}
		return global::Rotator.Create();
	}

	// Token: 0x060181F3 RID: 98803 RVA: 0x0073D6B0 File Offset: 0x0073B8B0
	private global::Vector GetLinearVelocityFromSample()
	{
		FastMoveSample fastMoveSample = this.FastMoveSampleInternal as FastMoveSample;
		if (fastMoveSample != null)
		{
			return fastMoveSample.LinearVelocity;
		}
		ReadOnlyFastMoveSample readOnlyFastMoveSample = this.FastMoveSampleInternal as ReadOnlyFastMoveSample;
		if (readOnlyFastMoveSample != null)
		{
			return readOnlyFastMoveSample.LinearVelocity;
		}
		return global::Vector.Create();
	}

	// Token: 0x060181F4 RID: 98804 RVA: 0x0073D6F0 File Offset: 0x0073B8F0
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.InputComp = base.Entity.GetComponent<CharacterInputComponent>();
		this.SlideComponent = base.Entity.GetComponent<CharacterSlideComponent>();
		this.UnifiedComp = base.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.DriveVehicleComp = base.Entity.GetComponent<CharacterDriveVehicleComponent>();
		this.AiComponent = base.Entity.GetComponent<CharacterAiComponent>();
		EventSystem.Instance.AddWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
		return true;
	}

	// Token: 0x060181F5 RID: 98805 RVA: 0x0073D77C File Offset: 0x0073B97C
	protected override bool OnEnd()
	{
		if (!base.OnEnd())
		{
			return false;
		}
		EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
		return true;
	}

	// Token: 0x060181F6 RID: 98806 RVA: 0x0073D7A8 File Offset: 0x0073B9A8
	protected override void ApplyInput(int input, global::Rotator rotation)
	{
		if (this.InputComp != null)
		{
			if (input != 65535)
			{
				int input2 = input >> 8;
				int num = input & 255;
				this.UnpackInputDirection(input2, this.TmpVector);
				this.UnpackInputDirection(num, this.TmpVector2);
				this.InputComp.SetMoveVectorCache(this.TmpVector, this.TmpVector2);
				CharacterActorComponent charActorComp = this.CharActorComp;
				if (charActorComp == null)
				{
					return;
				}
				charActorComp.SetInputRotatorByNumber(0f, (float)num / 255f * 360f, 0f);
				return;
			}
			else
			{
				this.InputComp.ResetMoveVectorCache();
				CharacterActorComponent charActorComp2 = this.CharActorComp;
				if (charActorComp2 == null)
				{
					return;
				}
				charActorComp2.SetInputRotator(rotation);
			}
		}
	}

	// Token: 0x060181F7 RID: 98807 RVA: 0x0073D84C File Offset: 0x0073BA4C
	private void UnpackInputDirection(int input, global::Vector outVector)
	{
		if (input == 255)
		{
			outVector.Reset();
			return;
		}
		double num = MathUtils.Instance.RangeClamp((double)input, 0.0, 255.0, 0.0, 6.283185307179586);
		outVector.X = Math.Cos(num);
		outVector.Y = Math.Sin(num);
	}

	// Token: 0x060181F8 RID: 98808 RVA: 0x0073D8B4 File Offset: 0x0073BAB4
	public unsafe override MoveReplaySample GetCurrentMoveSample()
	{
		MoveReplaySample moveReplaySample = MoveReplaySample.Create();
		moveReplaySample.Location = new Aki.Protocol.Vector
		{
			X = 0f,
			Y = 0f,
			Z = 0f
		};
		moveReplaySample.LinearVelocity = new Aki.Protocol.Vector
		{
			X = 0f,
			Y = 0f,
			Z = 0f
		};
		moveReplaySample.Rotation = new Aki.Protocol.Rotator
		{
			Pitch = 0f,
			Roll = 0f,
			Yaw = 0f
		};
		CharacterInputComponent inputComp = this.InputComp;
		float valueOrDefault = ((inputComp != null) ? inputComp.QueryInputAxis(EInputAxis.MoveForward) : null).GetValueOrDefault();
		CharacterInputComponent inputComp2 = this.InputComp;
		float valueOrDefault2 = ((inputComp2 != null) ? inputComp2.QueryInputAxis(EInputAxis.MoveRight) : null).GetValueOrDefault();
		CharacterActorComponent charActorComp = this.CharActorComp;
		this.UpdateFastMoveSampleInput(ref moveReplaySample, (charActorComp != null) ? charActorComp.Actor : null, this.MoveComp.CharacterMovement, valueOrDefault, valueOrDefault2, 255f, CameraController.Instance.MainModel.CameraRotator.Yaw);
		GameModeModel instance = GameModeModel.Instance;
		if (instance != null && instance.InstanceType == InstanceType.BigWorldInstance && moveReplaySample.Location.X == 0f && moveReplaySample.Location.Y == 0f && moveReplaySample.Location.Z == 0f)
		{
			CombatLog instance2 = CombatLog.Instance;
			CombatLog.EDebugModule flag = CombatLog.EDebugModule.Move;
			Entity entity = base.Entity;
			string message = "移动坐标点为0";
			<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("Component", this.CharActorComp != null);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "Actor";
			CharacterActorComponent charActorComp2 = this.CharActorComp;
			ptr = new ValueTuple<string, object>(item, ((charActorComp2 != null) ? charActorComp2.Actor : null) != null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Location", moveReplaySample.Location);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("LinearVelocity", moveReplaySample.LinearVelocity);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Rotation", moveReplaySample.Rotation);
			instance2.Warn(flag, entity, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
		}
		MoveReplaySample moveReplaySample2 = moveReplaySample;
		BaseUnifiedStateComponent unifiedComp = this.UnifiedComp;
		moveReplaySample2.MoveState = (int)((unifiedComp != null) ? unifiedComp.MoveState : global::ECharMoveState.Other);
		moveReplaySample.ServerTimeStamp = (long)Time.Instance.CombatServerTime;
		moveReplaySample.TimeStamp = (float)Time.Instance.NowSeconds;
		if (base.Entity.GetTickInterval() > 1 && this.LastLogicTickTime > 0.0 && this.NowLogicTickTime > 0.0)
		{
			moveReplaySample.TickInterval = (int)(this.NowLogicTickTime - this.LastLogicTickTime) * 1000;
		}
		moveReplaySample.RTT = (int)Net.Instance.RttMs;
		MoveReplaySample moveReplaySample3 = moveReplaySample;
		float timeDilation = base.Entity.TimeDilation;
		CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		moveReplaySample3.TimeScale = timeDilation * ((timeScaleComp != null) ? timeScaleComp.CurrentTimeScale : 1f);
		if (this.SlideComponent != null)
		{
			global::Vector slideForward = this.SlideComponent.SlideForward;
			moveReplaySample.SlideForward = new Aki.Protocol.Vector
			{
				X = (float)slideForward.X,
				Y = (float)slideForward.Y,
				Z = (float)slideForward.Z
			};
		}
		BaseMoveComponent moveComp = this.MoveComp;
		if (((moveComp != null) ? moveComp.BasePlatform : null) != null)
		{
			moveReplaySample.RelativeMoveReplaySample = this.GetRelativeMoveSample(this.MoveComp.BasePlatform, false);
		}
		else if (this.LastHasBaseMovement)
		{
			if (this.LastBasePlatform != null)
			{
				moveReplaySample.RelativeMoveReplaySample = this.GetRelativeMoveSample(this.LastBasePlatform, true);
			}
			else
			{
				this.LastHasBaseMovement = false;
			}
		}
		moveReplaySample.SkillId = this.CurEndSkillId;
		this.CurEndSkillId = 0L;
		this.LastMoveSample = moveReplaySample;
		base.CompressData(moveReplaySample);
		return moveReplaySample;
	}

	// Token: 0x060181F9 RID: 98809 RVA: 0x0073DC90 File Offset: 0x0073BE90
	[return: Nullable(2)]
	protected RelativeMoveReplaySample GetRelativeMoveSample(BasePlatform platform, bool checkLeave = false)
	{
		EntityHandle entityHandle = platform.EntityHandle;
		if (entityHandle == null || !entityHandle.Valid)
		{
			this.LastHasBaseMovement = false;
			this.LastBasePlatform = null;
			return null;
		}
		if (checkLeave && platform.CheckLeave(base.Entity, this.GetLocationFromSample()))
		{
			this.LastHasBaseMovement = false;
			this.LastBasePlatform = null;
			return null;
		}
		FRotator actorRotation = this.ActorComp.ActorRotation;
		float scaledHalfHeight = this.CharActorComp.ScaledHalfHeight;
		FVectorDouble inPosition = this.CharActorComp.Actor.D_K2_GetActorLocation();
		inPosition.Z -= (double)scaledHalfHeight;
		FVectorDouble fvectorDouble = new FVectorDouble();
		FRotator frotator = new FRotator();
		platform.TransformToRelativeSpace(inPosition, actorRotation, ref fvectorDouble, ref frotator);
		RelativeMoveReplaySample relativeMoveReplaySample = RelativeMoveReplaySample.Create();
		relativeMoveReplaySample.BaseMovementEntityId = MathUtils.Instance.NumberToLong(platform.EntityHandle.CreatureDataId);
		relativeMoveReplaySample.RelativeLocation = new Aki.Protocol.Vector
		{
			X = (float)fvectorDouble.X,
			Y = (float)fvectorDouble.Y,
			Z = (float)fvectorDouble.Z
		};
		relativeMoveReplaySample.RelativeRotation = new Aki.Protocol.Rotator
		{
			Pitch = frotator.Pitch,
			Roll = frotator.Roll,
			Yaw = frotator.Yaw
		};
		return relativeMoveReplaySample;
	}

	// Token: 0x060181FA RID: 98810 RVA: 0x0073DDC0 File Offset: 0x0073BFC0
	protected override void RecordLastData(bool isMove = false)
	{
		this.LastMovementMode = this.GetMovementModeFromSample();
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp != null && moveComp.HasBaseMovement)
		{
			BaseMoveComponent moveComp2 = this.MoveComp;
			if (((moveComp2 != null) ? moveComp2.BasePlatform : null) != null)
			{
				this.LastHasBaseMovement = this.MoveComp.HasBaseMovement;
				if (this.MoveComp.BasePlatform != this.LastBasePlatform)
				{
					this.LastBasePlatform = this.MoveComp.BasePlatform;
					this.LastBasePlatform.OnCharacterEnter(base.Entity, this.MoveComp.CharacterMovement);
				}
			}
		}
		this.LastLocation.DeepCopy(this.GetLocationFromSample());
		this.LastRotation.DeepCopy(this.GetRotationFromSample());
		this.LastMoveAutonomousProxy = this.ActorComp.IsMoveAutonomousProxy;
		this.LastMove = isMove;
		double num = (double)base.Entity.TimeDilation;
		CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		float? num2 = (timeScaleComp != null) ? new float?(timeScaleComp.CurrentTimeScale) : null;
		double lastTimeScale = num * ((num2 != null) ? ((double)num2.GetValueOrDefault()) : 1.0);
		this.LastTimeScale = lastTimeScale;
	}

	// Token: 0x060181FB RID: 98811 RVA: 0x0073DEE0 File Offset: 0x0073C0E0
	protected override bool CalcRelativeMove(ReplaySample sample1, ReplaySample sample2, float lerpPercent, global::Vector outLocation, global::Rotator outRotator)
	{
		if (sample1.RelativeMove == null || sample2.RelativeMove == null)
		{
			return false;
		}
		EntityHandle entityHandle = CreatureModel.Instance.GetEntity(sample1.RelativeMove.BaseMovementEntityId);
		if (entityHandle == null)
		{
			entityHandle = CreatureModel.Instance.GetEntityWithDelayRemoveContainer(sample1.RelativeMove.BaseMovementEntityId);
		}
		if (entityHandle == null)
		{
			return false;
		}
		BasePlatform basePlatformByEntity = BasePlatformController.GetBasePlatformByEntity(entityHandle);
		if (basePlatformByEntity == null)
		{
			return false;
		}
		global::Vector.Lerp(sample1.RelativeMove.RelativeLocation, sample2.RelativeMove.RelativeLocation, (double)lerpPercent, outLocation);
		global::Rotator.Lerp(sample1.RelativeMove.RelativeRotation, sample2.RelativeMove.RelativeRotation, lerpPercent, outRotator);
		FVectorDouble fvectorDouble = new FVectorDouble();
		FRotator frotator = new FRotator();
		basePlatformByEntity.TransformFromRelativeSpace(outLocation.ToUeVector(false), outRotator.ToUeRotator(), ref fvectorDouble, ref frotator);
		outLocation.DeepCopy(fvectorDouble);
		float scaledHalfHeight = this.CharActorComp.ScaledHalfHeight;
		outLocation.Z += (double)scaledHalfHeight;
		outRotator.DeepCopy(frotator);
		return true;
	}

	// Token: 0x060181FC RID: 98812 RVA: 0x0073DFD4 File Offset: 0x0073C1D4
	[return: Nullable(2)]
	protected override EntityHandle CheckRelativeMove(ReplaySample sample1, ReplaySample sample2, float lerpPercent, global::Vector outLocation, global::Rotator outRotator)
	{
		if (sample1.RelativeMove == null || sample2.RelativeMove == null)
		{
			return null;
		}
		EntityHandle entityHandle = CreatureModel.Instance.GetEntity(sample1.RelativeMove.BaseMovementEntityId);
		if (entityHandle == null)
		{
			entityHandle = CreatureModel.Instance.GetEntityWithDelayRemoveContainer(sample1.RelativeMove.BaseMovementEntityId);
		}
		if (entityHandle == null)
		{
			return null;
		}
		if (BasePlatformController.GetBasePlatformByEntity(entityHandle) == null)
		{
			return null;
		}
		global::Vector.Lerp(sample1.RelativeMove.RelativeLocation, sample2.RelativeMove.RelativeLocation, (double)lerpPercent, outLocation);
		global::Rotator.Lerp(sample1.RelativeMove.RelativeRotation, sample2.RelativeMove.RelativeRotation, lerpPercent, outRotator);
		return entityHandle;
	}

	// Token: 0x060181FD RID: 98813 RVA: 0x0073E070 File Offset: 0x0073C270
	protected override bool TransformFromRelativeMove(EntityHandle handle, global::Vector location, global::Rotator rotator, global::Vector outLocation, global::Rotator outRotator)
	{
		BasePlatform basePlatformByEntity = BasePlatformController.GetBasePlatformByEntity(handle);
		if (basePlatformByEntity == null)
		{
			return false;
		}
		FVectorDouble fvectorDouble = new FVectorDouble();
		FRotator frotator = new FRotator();
		basePlatformByEntity.TransformFromRelativeSpace(location.ToUeVector(false), rotator.ToUeRotator(), ref fvectorDouble, ref frotator);
		outLocation.DeepCopy(fvectorDouble);
		float scaledHalfHeight = this.CharActorComp.ScaledHalfHeight;
		outLocation.Z += (double)scaledHalfHeight;
		outRotator.DeepCopy(frotator);
		return true;
	}

	// Token: 0x060181FE RID: 98814 RVA: 0x0073E0E0 File Offset: 0x0073C2E0
	protected override void ApplyMoveSample(int movementMode, global::Vector location, global::Rotator rotator, global::Vector linearVelocity, global::Vector slideForward, int controllerPlayerId, int input, float controllerPitch, float timeScale, long serverTimeStamp, float originRtt)
	{
		base.ApplyMoveSample(movementMode, location, rotator, linearVelocity, slideForward, controllerPlayerId, input, controllerPitch, timeScale, serverTimeStamp, originRtt);
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp != null)
		{
			moveComp.SetForceSpeed(linearVelocity);
		}
		this.ControllerPlayerId = controllerPlayerId;
		CharacterSlideComponent slideComponent = this.SlideComponent;
		if (slideComponent != null)
		{
			slideComponent.SlideForward.DeepCopy(slideForward);
		}
		CharacterAiComponent aiComponent = this.AiComponent;
		bool flag;
		if (aiComponent == null)
		{
			flag = false;
		}
		else
		{
			AiController aiController = aiComponent.AiController;
			flag = ((aiController != null) ? new bool?(aiController.IsWaitingReceiveControl()) : null).GetValueOrDefault();
		}
		if (flag)
		{
			this.LastReceivedMovementMode = movementMode;
		}
		else
		{
			CharacterActorComponent charActorComp = this.CharActorComp;
			if (charActorComp != null)
			{
				charActorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = (EMovementMode)movementMode,
					Context = "[CharacterMovementSyncComponent.ApplyMoveSample]"
				});
			}
		}
		this.ApplyInput(input, rotator);
		this.CacheFinalRotator.Reset();
		this.CacheFinalRotator.Pitch = controllerPitch;
		AController controller = this.CharActorComp.Actor.Controller;
		if (controller != null)
		{
			FRotator frotator = this.CacheFinalRotator.ToUeRotator();
			controller.SetControlRotation(frotator);
		}
		CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		if (timeScaleComp != null)
		{
			timeScaleComp.SetMoveSyncTimeScale(timeScale);
		}
		double num = 0.0;
		if (this.LastReceiveMoveSample != null)
		{
			num = (this.LastReceiveMoveSample.TimeStamp - Time.Instance.NowSeconds) * 1000.0;
		}
		base.ReportMoveDataApplyInfo((float)Time.Instance.CombatServerTime - (float)serverTimeStamp, (float)num, originRtt);
	}

	// Token: 0x060181FF RID: 98815 RVA: 0x0073E24D File Offset: 0x0073C44D
	public void ClearBasePlatform()
	{
		this.LastHasBaseMovement = false;
		this.LastBasePlatform = null;
	}

	// Token: 0x06018200 RID: 98816 RVA: 0x0073E260 File Offset: 0x0073C460
	private void UpdateFastMoveSampleBase(ref FastMoveSample moveSample, [Nullable(2)] APawn pawn, UCharacterMovementComponent moveComp)
	{
		if (pawn == null)
		{
			return;
		}
		FVectorDouble fvectorDouble = pawn.D_K2_GetActorLocation();
		FRotator frotator = pawn.K2_GetActorRotation();
		FVector velocity = pawn.GetVelocity();
		moveSample.Location.X = (double)((float)fvectorDouble.X);
		moveSample.Location.Y = (double)((float)fvectorDouble.Y);
		moveSample.Location.Z = (double)((float)fvectorDouble.Z);
		moveSample.Rotation.Pitch = frotator.Pitch;
		moveSample.Rotation.Yaw = frotator.Yaw;
		moveSample.Rotation.Roll = frotator.Roll;
		moveSample.LinearVelocity.X = (double)velocity.X;
		moveSample.LinearVelocity.Y = (double)velocity.Y;
		moveSample.LinearVelocity.Z = (double)velocity.Z;
		moveSample.MovementMode = (int)moveComp.MovementMode;
	}

	// Token: 0x06018201 RID: 98817 RVA: 0x0073E34C File Offset: 0x0073C54C
	private void UpdateFastMoveSampleInput(ref MoveReplaySample moveSample, [Nullable(2)] APawn pawn, UCharacterMovementComponent moveComp, float inputX, float inputY, float inputSize, float cameraYaw)
	{
		if (pawn == null)
		{
			return;
		}
		FVector2D fvector2D = new FVector2D(inputX, inputY);
		float controllerPitch = 0f;
		if (pawn.GetController() != null)
		{
			controllerPitch = pawn.GetController().GetControlRotation().Pitch;
		}
		FVectorDouble fvectorDouble = pawn.D_K2_GetActorLocation();
		FRotator frotator = pawn.K2_GetActorRotation();
		FVector velocity = pawn.GetVelocity();
		moveSample.Location.X = (float)fvectorDouble.X;
		moveSample.Location.Y = (float)fvectorDouble.Y;
		moveSample.Location.Z = (float)fvectorDouble.Z;
		moveSample.Rotation.Pitch = frotator.Pitch;
		moveSample.Rotation.Yaw = frotator.Yaw;
		moveSample.Rotation.Roll = frotator.Roll;
		moveSample.LinearVelocity.X = velocity.X;
		moveSample.LinearVelocity.Y = velocity.Y;
		moveSample.LinearVelocity.Z = velocity.Z;
		moveSample.ControllerPitch = controllerPitch;
		moveSample.InputDirection = this.CalculateInputDirection(fvector2D.GetSafeNormal(1E-08f), inputSize, cameraYaw);
		moveSample.MovementMode = (int)moveComp.MovementMode;
	}

	// Token: 0x06018202 RID: 98818 RVA: 0x0073E484 File Offset: 0x0073C684
	private int CalculateInputDirection(FVector2D inputDirection, float inputDirectionSize, float cameraRotatorYaw)
	{
		int num = (int)this.PackJoystickInput(inputDirection, inputDirectionSize);
		FVector2D rotated = inputDirection.GetRotated(cameraRotatorYaw);
		int num2 = (int)this.PackJoystickInput(rotated, inputDirectionSize);
		return num << 8 | num2;
	}

	// Token: 0x06018203 RID: 98819 RVA: 0x0073E4B4 File Offset: 0x0073C6B4
	private float PackJoystickInput(FVector2D inputDirection, float inputDirectionSize)
	{
		if (inputDirection.IsNearlyZero(1E-08f))
		{
			return 255f;
		}
		float num = FMath.Asin(inputDirection.Y);
		if (inputDirection.X < 0f)
		{
			num = 3.1415927f - num;
		}
		if (num < 0f)
		{
			num += 6.2831855f;
		}
		return UKismetMathLibrary.MapRangeClamped(num, 0f, 6.2831855f, 0f, 255f);
	}

	// Token: 0x06018204 RID: 98820 RVA: 0x0073E520 File Offset: 0x0073C720
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMovementSyncComponent characterMovementSyncComponent = (CharacterMovementSyncComponent)componentTemplate;
		this.LastMovementMode = characterMovementSyncComponent.LastMovementMode;
		this.LastReceivedMovementMode = characterMovementSyncComponent.LastReceivedMovementMode;
		this.LastTimeScale = characterMovementSyncComponent.LastTimeScale;
		if (characterMovementSyncComponent.InputComp == null)
		{
			this.InputComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.InputComp), "InputComp"))
		{
			return false;
		}
		if (characterMovementSyncComponent.SlideComponent == null)
		{
			this.SlideComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SlideComponent), "SlideComponent"))
		{
			return false;
		}
		if (characterMovementSyncComponent.UnifiedComp == null)
		{
			this.UnifiedComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.UnifiedComp), "UnifiedComp"))
		{
			return false;
		}
		if (characterMovementSyncComponent.DriveVehicleComp == null)
		{
			this.DriveVehicleComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DriveVehicleComp), "DriveVehicleComp"))
		{
			return false;
		}
		if (characterMovementSyncComponent.AiComponent == null)
		{
			this.AiComponent = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AiComponent), "AiComponent"))
		{
			return false;
		}
		if (characterMovementSyncComponent.FastMoveSampleInfo == null)
		{
			this.FastMoveSampleInfo = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FastMoveSampleInfo), "FastMoveSampleInfo"))
		{
			return false;
		}
		if (characterMovementSyncComponent.ReadOnlyFastMoveSampleInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReadOnlyFastMoveSampleInfo), "ReadOnlyFastMoveSampleInfo"))
		{
			return false;
		}
		if (characterMovementSyncComponent.FastMoveSampleInternal == null)
		{
			this.FastMoveSampleInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.FastMoveSampleInternal), "FastMoveSampleInternal"))
		{
			return false;
		}
		this.CurEndSkillId = characterMovementSyncComponent.CurEndSkillId;
		return true;
	}

	// Token: 0x170025C0 RID: 9664
	// (get) Token: 0x06018205 RID: 98821 RVA: 0x0073E6BF File Offset: 0x0073C8BF
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025C1 RID: 9665
	// (get) Token: 0x06018206 RID: 98822 RVA: 0x0073E6C2 File Offset: 0x0073C8C2
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025C2 RID: 9666
	// (get) Token: 0x06018207 RID: 98823 RVA: 0x0073E6C5 File Offset: 0x0073C8C5
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025C3 RID: 9667
	// (get) Token: 0x06018208 RID: 98824 RVA: 0x0073E6C8 File Offset: 0x0073C8C8
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170025C4 RID: 9668
	// (get) Token: 0x06018209 RID: 98825 RVA: 0x0073E6CB File Offset: 0x0073C8CB
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400CF46 RID: 53062
	private const int InputDirectionSize = 255;

	// Token: 0x0400CF47 RID: 53063
	private const int InvalidInput = 65535;

	// Token: 0x0400CF48 RID: 53064
	private const float PI = 3.1415927f;

	// Token: 0x0400CF49 RID: 53065
	protected int LastMovementMode;

	// Token: 0x0400CF4A RID: 53066
	protected int LastReceivedMovementMode;

	// Token: 0x0400CF4B RID: 53067
	protected double LastTimeScale = 1.0;

	// Token: 0x0400CF4C RID: 53068
	[Nullable(2)]
	private CharacterInputComponent InputComp;

	// Token: 0x0400CF4D RID: 53069
	[Nullable(2)]
	private CharacterSlideComponent SlideComponent;

	// Token: 0x0400CF4E RID: 53070
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CF4F RID: 53071
	[Nullable(2)]
	private CharacterDriveVehicleComponent DriveVehicleComp;

	// Token: 0x0400CF50 RID: 53072
	[Nullable(2)]
	private CharacterAiComponent AiComponent;

	// Token: 0x0400CF51 RID: 53073
	private FastMoveSample FastMoveSampleInfo = new FastMoveSample();

	// Token: 0x0400CF52 RID: 53074
	private readonly ReadOnlyFastMoveSample ReadOnlyFastMoveSampleInfo = new ReadOnlyFastMoveSample();

	// Token: 0x0400CF53 RID: 53075
	private object FastMoveSampleInternal;

	// Token: 0x0400CF54 RID: 53076
	private long CurEndSkillId;
}
