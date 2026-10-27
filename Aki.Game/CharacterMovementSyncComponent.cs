using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

// Token: 0x0200307C RID: 12412
[NullableContext(1)]
[Nullable(0)]
public class CharacterMovementSyncComponent : BaseMovementSyncComponent
{
	// Token: 0x0601A815 RID: 108565 RVA: 0x00716AB9 File Offset: 0x00714CB9
	private void OnCharSkillEnd(int entityId, int skillId)
	{
		this.CurEndSkillId = (long)skillId;
	}

	// Token: 0x1700247A RID: 9338
	// (get) Token: 0x0601A816 RID: 108566 RVA: 0x00716AC3 File Offset: 0x00714CC3
	private CharacterActorComponent CharActorComp
	{
		get
		{
			return this.ActorComp as CharacterActorComponent;
		}
	}

	// Token: 0x0601A817 RID: 108567 RVA: 0x00716AD0 File Offset: 0x00714CD0
	public CharacterMovementSyncComponent()
	{
		this.FastMoveSampleInternal = this.ReadOnlyFastMoveSampleInfo;
	}

	// Token: 0x0601A818 RID: 108568 RVA: 0x00716B09 File Offset: 0x00714D09
	protected override bool DefaultEnableMovementSync()
	{
		return true;
	}

	// Token: 0x0601A819 RID: 108569 RVA: 0x00716B0C File Offset: 0x00714D0C
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

	// Token: 0x0601A81A RID: 108570 RVA: 0x00716BE4 File Offset: 0x00714DE4
	protected override bool GetImportantMove(bool moving)
	{
		int movementModeFromSample = this.GetMovementModeFromSample();
		double num = (double)base.Entity.TimeDilation;
		CharacterTimeScaleComponent timeScaleComp = this.TimeScaleComp;
		float? num2 = (timeScaleComp != null) ? new float?(timeScaleComp.CurrentTimeScale) : null;
		double num3 = num * ((num2 != null) ? ((double)num2.GetValueOrDefault()) : 1.0);
		return this.LastMovementMode != movementModeFromSample || this.LastHasBaseMovement != this.MoveComp.HasBaseMovement || this.LastTimeScale != num3 || (!moving && this.LastMove);
	}

	// Token: 0x0601A81B RID: 108571 RVA: 0x00716C7C File Offset: 0x00714E7C
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

	// Token: 0x0601A81C RID: 108572 RVA: 0x00716CD8 File Offset: 0x00714ED8
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

	// Token: 0x0601A81D RID: 108573 RVA: 0x00716D92 File Offset: 0x00714F92
	public override void TickReplaySamples()
	{
		if (this.DriveVehicleComp != null && this.DriveVehicleComp.Seat >= 0)
		{
			return;
		}
		base.TickReplaySamples();
	}

	// Token: 0x0601A81E RID: 108574 RVA: 0x00716DB4 File Offset: 0x00714FB4
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

	// Token: 0x0601A81F RID: 108575 RVA: 0x00716EA4 File Offset: 0x007150A4
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

	// Token: 0x0601A820 RID: 108576 RVA: 0x00716EE0 File Offset: 0x007150E0
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

	// Token: 0x0601A821 RID: 108577 RVA: 0x00716F20 File Offset: 0x00715120
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

	// Token: 0x0601A822 RID: 108578 RVA: 0x00716F60 File Offset: 0x00715160
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

	// Token: 0x0601A823 RID: 108579 RVA: 0x00716FA0 File Offset: 0x007151A0
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

	// Token: 0x0601A824 RID: 108580 RVA: 0x0071702C File Offset: 0x0071522C
	protected override bool OnEnd()
	{
		if (!base.OnEnd())
		{
			return false;
		}
		EventSystem.Instance.RemoveWithTarget<int, int>(base.Entity, EEventName.OnSkillEnd, new Action<int, int>(this.OnCharSkillEnd));
		return true;
	}

	// Token: 0x0601A825 RID: 108581 RVA: 0x00717058 File Offset: 0x00715258
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

	// Token: 0x0601A826 RID: 108582 RVA: 0x007170FC File Offset: 0x007152FC
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

	// Token: 0x0601A827 RID: 108583 RVA: 0x00717164 File Offset: 0x00715364
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

	// Token: 0x0601A828 RID: 108584 RVA: 0x00717540 File Offset: 0x00715740
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

	// Token: 0x0601A829 RID: 108585 RVA: 0x00717670 File Offset: 0x00715870
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

	// Token: 0x0601A82A RID: 108586 RVA: 0x00717790 File Offset: 0x00715990
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

	// Token: 0x0601A82B RID: 108587 RVA: 0x00717884 File Offset: 0x00715A84
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

	// Token: 0x0601A82C RID: 108588 RVA: 0x00717920 File Offset: 0x00715B20
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

	// Token: 0x0601A82D RID: 108589 RVA: 0x00717990 File Offset: 0x00715B90
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

	// Token: 0x0601A82E RID: 108590 RVA: 0x00717AFD File Offset: 0x00715CFD
	public void ClearBasePlatform()
	{
		this.LastHasBaseMovement = false;
		this.LastBasePlatform = null;
	}

	// Token: 0x0601A82F RID: 108591 RVA: 0x00717B10 File Offset: 0x00715D10
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

	// Token: 0x0601A830 RID: 108592 RVA: 0x00717BFC File Offset: 0x00715DFC
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

	// Token: 0x0601A831 RID: 108593 RVA: 0x00717D34 File Offset: 0x00715F34
	private int CalculateInputDirection(FVector2D inputDirection, float inputDirectionSize, float cameraRotatorYaw)
	{
		int num = (int)this.PackJoystickInput(inputDirection, inputDirectionSize);
		FVector2D rotated = inputDirection.GetRotated(cameraRotatorYaw);
		int num2 = (int)this.PackJoystickInput(rotated, inputDirectionSize);
		return num << 8 | num2;
	}

	// Token: 0x0601A832 RID: 108594 RVA: 0x00717D64 File Offset: 0x00715F64
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

	// Token: 0x0601A833 RID: 108595 RVA: 0x00717DD0 File Offset: 0x00715FD0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		CharacterMovementSyncComponent characterMovementSyncComponent = (CharacterMovementSyncComponent)componentTemplate;
		if (base.CanResetComponentProperty("LastMovementMode"))
		{
			this.LastMovementMode = characterMovementSyncComponent.LastMovementMode;
		}
		if (base.CanResetComponentProperty("LastReceivedMovementMode"))
		{
			this.LastReceivedMovementMode = characterMovementSyncComponent.LastReceivedMovementMode;
		}
		if (base.CanResetComponentProperty("LastTimeScale"))
		{
			this.LastTimeScale = characterMovementSyncComponent.LastTimeScale;
		}
		if (base.CanResetComponentProperty("InputComp"))
		{
			if (characterMovementSyncComponent.InputComp == null)
			{
				this.InputComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterInputComponent>(this.InputComp), "InputComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SlideComponent"))
		{
			if (characterMovementSyncComponent.SlideComponent == null)
			{
				this.SlideComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterSlideComponent>(this.SlideComponent), "SlideComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("UnifiedComp"))
		{
			if (characterMovementSyncComponent.UnifiedComp == null)
			{
				this.UnifiedComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseUnifiedStateComponent>(this.UnifiedComp), "UnifiedComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DriveVehicleComp"))
		{
			if (characterMovementSyncComponent.DriveVehicleComp == null)
			{
				this.DriveVehicleComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterDriveVehicleComponent>(this.DriveVehicleComp), "DriveVehicleComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("AiComponent"))
		{
			if (characterMovementSyncComponent.AiComponent == null)
			{
				this.AiComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CharacterAiComponent>(this.AiComponent), "AiComponent"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("FastMoveSampleInfo"))
		{
			if (characterMovementSyncComponent.FastMoveSampleInfo == null)
			{
				this.FastMoveSampleInfo = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<FastMoveSample>(this.FastMoveSampleInfo), "FastMoveSampleInfo"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ReadOnlyFastMoveSampleInfo") && characterMovementSyncComponent.ReadOnlyFastMoveSampleInfo != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<ReadOnlyFastMoveSample>(this.ReadOnlyFastMoveSampleInfo), "ReadOnlyFastMoveSampleInfo"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("FastMoveSampleInternal"))
		{
			if (characterMovementSyncComponent.FastMoveSampleInternal == null)
			{
				this.FastMoveSampleInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<object>(this.FastMoveSampleInternal), "FastMoveSampleInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CurEndSkillId"))
		{
			this.CurEndSkillId = characterMovementSyncComponent.CurEndSkillId;
		}
		return true;
	}

	// Token: 0x0400CB63 RID: 52067
	private const int InputDirectionSize = 255;

	// Token: 0x0400CB64 RID: 52068
	private const int InvalidInput = 65535;

	// Token: 0x0400CB65 RID: 52069
	private const float PI = 3.1415927f;

	// Token: 0x0400CB66 RID: 52070
	protected int LastMovementMode;

	// Token: 0x0400CB67 RID: 52071
	protected int LastReceivedMovementMode;

	// Token: 0x0400CB68 RID: 52072
	protected double LastTimeScale = 1.0;

	// Token: 0x0400CB69 RID: 52073
	[Nullable(2)]
	private CharacterInputComponent InputComp;

	// Token: 0x0400CB6A RID: 52074
	[Nullable(2)]
	private CharacterSlideComponent SlideComponent;

	// Token: 0x0400CB6B RID: 52075
	[Nullable(2)]
	private BaseUnifiedStateComponent UnifiedComp;

	// Token: 0x0400CB6C RID: 52076
	[Nullable(2)]
	private CharacterDriveVehicleComponent DriveVehicleComp;

	// Token: 0x0400CB6D RID: 52077
	[Nullable(2)]
	private CharacterAiComponent AiComponent;

	// Token: 0x0400CB6E RID: 52078
	private FastMoveSample FastMoveSampleInfo = new FastMoveSample();

	// Token: 0x0400CB6F RID: 52079
	private readonly ReadOnlyFastMoveSample ReadOnlyFastMoveSampleInfo = new ReadOnlyFastMoveSample();

	// Token: 0x0400CB70 RID: 52080
	private object FastMoveSampleInternal;

	// Token: 0x0400CB71 RID: 52081
	private long CurEndSkillId;
}
