using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x02003102 RID: 12546
[NullableContext(1)]
[Nullable(0)]
public class MoveToLocation
{
	// Token: 0x0601AEC0 RID: 110272 RVA: 0x0074CFC9 File Offset: 0x0074B1C9
	[NullableContext(2)]
	public Vector GetCurrentMoveToLocation()
	{
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		return ((moveToLocationConfig != null) ? moveToLocationConfig.Position : null) ?? null;
	}

	// Token: 0x0601AEC1 RID: 110273 RVA: 0x0074CFE2 File Offset: 0x0074B1E2
	public void UpdateConfigMoveState(ECharMoveState? state)
	{
		if (this.MoveToLocationConfig == null)
		{
			return;
		}
		this.MoveToLocationConfig.MoveState = state;
	}

	// Token: 0x0601AEC2 RID: 110274 RVA: 0x0074CFFC File Offset: 0x0074B1FC
	[NullableContext(2)]
	public Vector GetLastMoveToLocation()
	{
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		Vector vector = (moveToLocationConfig != null) ? moveToLocationConfig.Position : null;
		MoveToPointConfig moveToLocationConfig2 = this.MoveToLocationConfig;
		bool flag;
		if (moveToLocationConfig2 == null)
		{
			flag = true;
		}
		else
		{
			Queue<Vector> nextMovePointConfig = moveToLocationConfig2.NextMovePointConfig;
			flag = !((nextMovePointConfig != null) ? new bool?(nextMovePointConfig.Empty) : null).GetValueOrDefault();
		}
		if (flag)
		{
			MoveToPointConfig moveToLocationConfig3 = this.MoveToLocationConfig;
			Vector vector2;
			if (moveToLocationConfig3 == null)
			{
				vector2 = null;
			}
			else
			{
				Queue<Vector> nextMovePointConfig2 = moveToLocationConfig3.NextMovePointConfig;
				vector2 = ((nextMovePointConfig2 != null) ? nextMovePointConfig2.Get(this.MoveToLocationConfig.NextMovePointConfig.Size - 1) : null);
			}
			vector = vector2;
		}
		return vector ?? null;
	}

	// Token: 0x0601AEC3 RID: 110275 RVA: 0x0074D08C File Offset: 0x0074B28C
	public float GetCurrentDistance()
	{
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		if (moveToLocationConfig != null && moveToLocationConfig.HasNextPoint())
		{
			Vector lastMoveToLocation = this.GetLastMoveToLocation();
			if (lastMoveToLocation != null)
			{
				return (float)((this.MoveToLocationConfig.IsFly != null && this.MoveToLocationConfig.IsFly.Value) ? Vector.Dist(this.ActorComp.ActorLocationProxy, lastMoveToLocation) : Vector.Dist2D(this.ActorComp.ActorLocationProxy, lastMoveToLocation));
			}
		}
		return this.CurrentDistance;
	}

	// Token: 0x0601AEC4 RID: 110276 RVA: 0x0074D110 File Offset: 0x0074B310
	public void Init(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = this.Entity.GetComponent<CharacterActorComponent>();
		this.StateComp = this.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.AnimComp = this.Entity.GetComponent<CharacterAnimationComponent>();
		this.PbDataId = this.ActorComp.CreatureData.GetPbDataId();
	}

	// Token: 0x0601AEC5 RID: 110277 RVA: 0x0074D16D File Offset: 0x0074B36D
	[NullableContext(2)]
	public bool SetMoveToLocation(IMoveToPointConfig location)
	{
		if (location == null)
		{
			return false;
		}
		this.Clear();
		this.UpdateMoveToLocationConfig(location);
		return true;
	}

	// Token: 0x0601AEC6 RID: 110278 RVA: 0x0074D184 File Offset: 0x0074B384
	public void UpdateMove(float deltaSeconds)
	{
		if (this.MoveToLocationConfig == null)
		{
			return;
		}
		if (MoveToLocationController.DebugDraw && GlobalData.IsPlayInEditor)
		{
			this.DrawDebug();
		}
		this.DeltaTime += deltaSeconds;
		if (this.DeltaTime > 1f)
		{
			this.DeltaTime = 0f;
			this.UpdateMoveStateAndSpeed();
		}
		bool flag = this.UpdateMoveToDirection();
		if (!flag && this.TickProcessId == 0 && this.ShouldForceResetForLargeDelta(deltaSeconds))
		{
			this.TickProcessId = TickProcessSystem.Instance.RegisterOnceTickProcess(ETickingGroup.TG_PrePhysics, true, delegate(float delta)
			{
				this.TickProcessId = 0;
				this.ResetPullbackLocation();
			});
			return;
		}
		if (flag)
		{
			if (this.ResetLastPointCondition() && (this.MoveToLocationConfig.ResetCondition == null || this.MoveToLocationConfig.ResetCondition()))
			{
				this.ResetLastPatrolPoint(deltaSeconds);
			}
			this.MoveEnd(ELevelEventState.Success);
			return;
		}
		float? returnTimeoutFailed = this.MoveToLocationConfig.ReturnTimeoutFailed;
		float num = 0.0001f;
		if (returnTimeoutFailed.GetValueOrDefault() > num & returnTimeoutFailed != null)
		{
			this.CheckTimeout(deltaSeconds);
		}
	}

	// Token: 0x0601AEC7 RID: 110279 RVA: 0x0074D27C File Offset: 0x0074B47C
	public void ResetPullbackLocation()
	{
		if (this.TickProcessId != 0)
		{
			return;
		}
		this.MoveToLocationConfig.UpdateTargetPosition();
		this.LastPatrolPoint.DeepCopy(this.MoveToLocationConfig.Position);
		this.ResetLastPatrolPoint(Time.Instance.DeltaTime * 0.001f);
		this.MoveEnd(ELevelEventState.Success);
	}

	// Token: 0x0601AEC8 RID: 110280 RVA: 0x0074D2D1 File Offset: 0x0074B4D1
	public void Dispose()
	{
		this.StopMove(null);
	}

	// Token: 0x0601AEC9 RID: 110281 RVA: 0x0074D2DC File Offset: 0x0074B4DC
	private unsafe void CheckTimeout(float deltaSeconds)
	{
		if ((float)Math.Sqrt(GravityUtils.Instance.GetDistSquared2dForActor(this.ActorComp, this.ActorComp.ActorLocationProxy, this.ActorComp.LastActorLocation)) / deltaSeconds > 30f)
		{
			this.CurTimeoutTime = this.MoveToLocationConfig.ReturnTimeoutFailed.Value;
			return;
		}
		this.CurTimeoutTime -= deltaSeconds;
		if (this.CurTimeoutTime <= 0f)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "检测到移动行为不符合预期,持续卡住超时,返回移动失败";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.PbDataId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("EntityId", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("超时时限", this.MoveToLocationConfig.ReturnTimeoutFailed);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			this.MoveEnd(ELevelEventState.Failure);
		}
	}

	// Token: 0x0601AECA RID: 110282 RVA: 0x0074D3F0 File Offset: 0x0074B5F0
	protected bool UpdateMoveToDirection()
	{
		this.UpdateCurrentTargetVector();
		if (this.CheckExceedTargetPoint())
		{
			return true;
		}
		this.DirectionVector.Normalize(9.99999993922529E-09);
		if (this.StateComp != null && this.StateComp.PositionState == ECharPositionState.Climb)
		{
			MoveToLocation.CacheQuat.DeepCopy(this.ActorComp.ActorQuatProxy);
			MoveToLocation.CacheQuat.Inverse(MoveToLocation.CacheQuat);
			MoveToLocation.CacheQuat.RotateVector(this.DirectionVector, this.DirectionVector);
			double x = this.DirectionVector.X;
			this.DirectionVector.X = this.DirectionVector.Z;
			this.DirectionVector.Z = x;
			this.ActorComp.SetInputDirect(this.DirectionVector, false);
			return false;
		}
		float? turnSpeed = this.MoveToLocationConfig.TurnSpeed;
		Entity entity = this.Entity;
		float? overrideTurnSpeed = turnSpeed * (float)((entity != null) ? entity.GetTickInterval() : 1);
		this.ActorComp.SetOverrideTurnSpeed(overrideTurnSpeed);
		if (this.StateComp != null && this.StateComp.MoveState == ECharMoveState.Walk)
		{
			MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
			if (moveToLocationConfig == null || !moveToLocationConfig.IsForward.GetValueOrDefault())
			{
				if (this.MoveToLocationConfig.FaceToPosition != null)
				{
					MoveToLocation.CacheVector3.DeepCopy(this.MoveToLocationConfig.FaceToPosition);
					MoveToLocation.CacheVector3.SubtractionEqual(this.ActorComp.ActorLocationProxy);
				}
				AiControllerLibrary.InputNearestDirection(this.ActorComp, this.DirectionVector, MoveToLocation.CacheQuat, MoveToLocation.CacheVector2, this.MoveToLocationConfig.TurnSpeed.Value, this.MoveToLocationConfig.UseNearestDirection.GetValueOrDefault(), (this.MoveToLocationConfig.FaceToPosition != null) ? MoveToLocation.CacheVector3 : null);
				return false;
			}
		}
		AiControllerLibrary.TurnToDirect(this.ActorComp, this.DirectionVector, overrideTurnSpeed.Value, this.MoveToLocationConfig.IsFly.GetValueOrDefault(), 0f);
		this.ActorComp.SetInputDirect(this.ActorComp.ActorForwardProxy, false);
		return false;
	}

	// Token: 0x0601AECB RID: 110283 RVA: 0x0074D621 File Offset: 0x0074B821
	[NullableContext(2)]
	public void StopMove(string context = null)
	{
		if (this.MoveToLocationConfig == null)
		{
			return;
		}
		this.Clear();
		this.ActorComp.ClearInput(false, true);
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		if (moveToLocationConfig != null)
		{
			moveToLocationConfig.Clear();
		}
		this.MoveToLocationConfig = null;
	}

	// Token: 0x0601AECC RID: 110284 RVA: 0x0074D658 File Offset: 0x0074B858
	public void MoveEnd(ELevelEventState state)
	{
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		if (moveToLocationConfig != null)
		{
			moveToLocationConfig.HasNextPoint();
		}
		MoveToPointConfig moveToLocationConfig2 = this.MoveToLocationConfig;
		bool? flag = (moveToLocationConfig2 != null) ? new bool?(moveToLocationConfig2.UpdateNextPoint()) : null;
		if (state == ELevelEventState.Success && flag.GetValueOrDefault())
		{
			this.CurTimeoutTime = this.MoveToLocationConfig.ReturnTimeoutFailed.GetValueOrDefault();
			this.ResetInputAndVelocity();
			return;
		}
		MoveToPointConfig moveToLocationConfig3 = this.MoveToLocationConfig;
		if (moveToLocationConfig3 != null)
		{
			moveToLocationConfig3.RunCallbackList(state);
		}
		this.Clear();
		this.StopMove(null);
		MoveToPointConfig moveToLocationConfig4 = this.MoveToLocationConfig;
		if (moveToLocationConfig4 != null)
		{
			moveToLocationConfig4.Clear();
		}
		this.MoveToLocationConfig = null;
	}

	// Token: 0x0601AECD RID: 110285 RVA: 0x0074D6FC File Offset: 0x0074B8FC
	private void UpdateMoveToLocationConfig(IMoveToPointConfig config)
	{
		this.StartMoveLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		MoveToPointConfig moveToPointConfig = config as MoveToPointConfig;
		if (moveToPointConfig != null)
		{
			this.MoveToLocationConfig = moveToPointConfig;
		}
		else if (this.MoveToLocationConfig != null)
		{
			this.MoveToLocationConfig.DeepCopy(config);
		}
		else
		{
			this.MoveToLocationConfig = new MoveToPointConfig(config, this.PointCacheVector);
		}
		this.CurTimeoutTime = this.MoveToLocationConfig.ReturnTimeoutFailed.Value;
	}

	// Token: 0x0601AECE RID: 110286 RVA: 0x0074D773 File Offset: 0x0074B973
	private void Clear()
	{
		this.CurTimeoutTime = 0f;
		this.StartMoveLocation.Reset();
		this.LastPatrolPoint.Reset();
	}

	// Token: 0x0601AECF RID: 110287 RVA: 0x0074D798 File Offset: 0x0074B998
	private void UpdateCurrentTargetVector()
	{
		if (this.MoveToLocationConfig.UpdateTargetPosition())
		{
			this.StartMoveLocation.DeepCopy(this.ActorComp.ActorLocationProxy);
		}
		this.DirectionVector.DeepCopy(this.MoveToLocationConfig.Position);
		this.DirectionVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.CurrentToTargetVector.DeepCopy(this.DirectionVector);
		BaseUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null && stateComp.PositionState == ECharPositionState.Climb)
		{
			MoveToLocation.CacheVector.DeepCopy(this.DirectionVector);
			double inB = MoveToLocation.CacheVector.DotProduct(this.ActorComp.ActorForwardProxy);
			MoveToLocation.CacheVector.DeepCopy(this.ActorComp.ActorForwardProxy);
			MoveToLocation.CacheVector.MultiplyEqual(inB);
			MoveToLocation.CacheVector.UnaryNegation(MoveToLocation.CacheVector);
			MoveToLocation.CacheVector.AdditionEqual(this.DirectionVector);
			this.DirectionVector.DeepCopy(MoveToLocation.CacheVector);
		}
		else if (!this.MoveToLocationConfig.IsFly.GetValueOrDefault())
		{
			GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.DirectionVector, 0.0);
		}
		this.CurrentDistance = (float)((this.MoveToLocationConfig.IsFly != null && this.MoveToLocationConfig.IsFly.Value) ? this.CurrentToTargetVector.Size() : ((double)((float)Math.Sqrt(GravityUtils.Instance.GetPlanarSizeSquared2dForActor(this.ActorComp, this.CurrentToTargetVector)))));
	}

	// Token: 0x0601AED0 RID: 110288 RVA: 0x0074D928 File Offset: 0x0074BB28
	private bool CheckExceedTargetPoint()
	{
		double num = (double)this.CurrentDistance;
		double? distance = this.MoveToLocationConfig.Distance;
		if (num <= distance.GetValueOrDefault() & distance != null)
		{
			return true;
		}
		this.MoveToLocationConfig.Position.Subtraction(this.StartMoveLocation, MoveToLocation.CacheVector);
		GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, MoveToLocation.CacheVector, 0.0);
		MoveToLocation.CacheVector2.DeepCopy(this.CurrentToTargetVector);
		GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, MoveToLocation.CacheVector2, 0.0);
		double num2 = MoveToLocation.CacheVector2.DotProduct(MoveToLocation.CacheVector);
		if (num2 < 0.0)
		{
			this.UpdateLastActorLocation();
		}
		return num2 < 0.0;
	}

	// Token: 0x0601AED1 RID: 110289 RVA: 0x0074D9F4 File Offset: 0x0074BBF4
	private void UpdateMoveStateAndSpeed()
	{
		BaseMoveComponent component = this.Entity.GetComponent<BaseMoveComponent>();
		if (component == null)
		{
			return;
		}
		float? moveSpeed = this.MoveToLocationConfig.MoveSpeed;
		if (this.MoveToLocationConfig.IsFly.GetValueOrDefault())
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.Actor.KuroSetMovementMode(new SetMovementModeInfo
				{
					Mode = EMovementMode.MOVE_Flying,
					Context = "[MoveToLocation.UpdateMoveStateAndSpeed]"
				});
			}
			if (moveSpeed != null)
			{
				component.SetMaxSpeed(moveSpeed.Value);
			}
			return;
		}
		if (moveSpeed != null)
		{
			component.SetMaxSpeed(moveSpeed.Value);
		}
		ECharMoveState? moveState = this.MoveToLocationConfig.MoveState;
		if (moveState != null)
		{
			this.StateComp.SetMoveState(moveState.Value);
		}
	}

	// Token: 0x0601AED2 RID: 110290 RVA: 0x0074DAB3 File Offset: 0x0074BCB3
	private void UpdateLastActorLocation()
	{
		this.MoveToLocationConfig.UpdateTargetPosition();
		this.LastPatrolPoint.DeepCopy(this.MoveToLocationConfig.Position);
	}

	// Token: 0x0601AED3 RID: 110291 RVA: 0x0074DAD8 File Offset: 0x0074BCD8
	private void ResetLastPatrolPoint(float deltaSeconds)
	{
		CharacterAnimationComponent animComp = this.AnimComp;
		if (animComp != null)
		{
			UAnimInstance mainAnimInstance = animComp.MainAnimInstance;
			if (mainAnimInstance != null)
			{
				mainAnimInstance.ConsumeExtractedRootMotion(1f);
			}
		}
		this.ActorComp.ClearInput(false, true);
		if (this.AnimComp != null && this.Entity.GetTickInterval() > 1)
		{
			FTransformDouble meshTransform = this.AnimComp.GetMeshTransform();
			this.SetLocationAndRotation();
			this.AnimComp.SetModelBuffer(meshTransform, deltaSeconds * 1000f * CharacterModel.Instance.InverseSelfCenteredTimeDilation);
		}
		else
		{
			this.SetLocationAndRotation();
		}
		this.LastPatrolPoint.Set(0.0, 0.0, 0.0);
	}

	// Token: 0x0601AED4 RID: 110292 RVA: 0x0074DB88 File Offset: 0x0074BD88
	private unsafe void SetLocationAndRotation()
	{
		if (this.MoveToLocationConfig.IsFly.GetValueOrDefault())
		{
			this.ActorComp.SetActorLocation(this.LastPatrolPoint.ToUeVector(false), "拉回目标点设置坐标", false);
			return;
		}
		if (!this.ActorComp.FixBornLocation("拉回目标点地面修正", true, this.LastPatrolPoint, false, true, true))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.AI;
			ELogAuthor author = ELogAuthor.CWZ;
			string message = "未能检测到地面，没设置拉回目标点";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("EntityId", this.Entity.Id);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("PbDataId", this.ActorComp.CreatureData.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("LastPatrolPoint", this.LastPatrolPoint);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ActorLocation", this.ActorComp.ActorLocationProxy);
			instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
	}

	// Token: 0x0601AED5 RID: 110293 RVA: 0x0074DCA0 File Offset: 0x0074BEA0
	private bool ResetLastPointCondition()
	{
		if (this.LastPatrolPoint.Size() < 1.0)
		{
			return false;
		}
		if (GravityUtils.Instance.GetDistSquared2dForActor(this.ActorComp, this.LastPatrolPoint, this.ActorComp.ActorLocationProxy) < MathUtils.Instance.Square(this.MoveToLocationConfig.Distance.Value + 10.0))
		{
			this.LastPatrolPoint.Set(0.0, 0.0, 0.0);
			return false;
		}
		return true;
	}

	// Token: 0x0601AED6 RID: 110294 RVA: 0x0074DD38 File Offset: 0x0074BF38
	private void ResetInputAndVelocity()
	{
		MoveToLocation.CacheVector.DeepCopy(this.MoveToLocationConfig.Position);
		MoveToLocation.CacheVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		if (moveToLocationConfig == null || !moveToLocationConfig.IsFly.GetValueOrDefault())
		{
			GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, MoveToLocation.CacheVector, 0.0);
		}
		MoveToLocation.CacheVector.Normalize(9.99999993922529E-09);
		CharacterActorComponent actorComp = this.ActorComp;
		if (actorComp != null)
		{
			actorComp.ClearInput(false, true);
		}
		CharacterActorComponent actorComp2 = this.ActorComp;
		if (actorComp2 != null)
		{
			actorComp2.SetInputDirect(MoveToLocation.CacheVector, false);
		}
		double inB = this.ActorComp.ActorVelocityProxy.Size();
		MoveToLocation.CacheVector.MultiplyEqual(inB);
		this.ActorComp.ActorVelocityProxy.Set(MoveToLocation.CacheVector.X, MoveToLocation.CacheVector.Y, MoveToLocation.CacheVector.Z);
	}

	// Token: 0x0601AED7 RID: 110295 RVA: 0x0074DE3C File Offset: 0x0074C03C
	private bool ShouldForceResetForLargeDelta(float deltaSeconds)
	{
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		if (moveToLocationConfig == null || !moveToLocationConfig.ForceResetOnLargeDelta.GetValueOrDefault() || moveToLocationConfig.ReferencePosition == null)
		{
			return false;
		}
		if (this.LastPatrolPoint.Size() >= 1.0)
		{
			return false;
		}
		double num = (double)this.CurrentDistance;
		double? num2 = moveToLocationConfig.Distance + (double)10;
		if (num <= num2.GetValueOrDefault() & num2 != null)
		{
			return false;
		}
		Entity entity = this.Entity;
		return (((entity != null) ? entity.GetTickInterval() : 1) > 1 || deltaSeconds >= 0.18f) && (float)Math.Sqrt(GravityUtils.Instance.GetDistSquared2dForActor(this.ActorComp, this.ActorComp.ActorLocationProxy, this.ActorComp.LastActorLocation)) >= (float)moveToLocationConfig.LargeDeltaResetMinMove.GetValueOrDefault(120);
	}

	// Token: 0x0601AED8 RID: 110296 RVA: 0x0074DF40 File Offset: 0x0074C140
	private void DrawDebug()
	{
		if (this.MoveToLocationConfig == null || !GlobalData.IsPlayInEditor)
		{
			return;
		}
		if (this.RandomColor == null)
		{
			this.RandomColor = new FLinearColor?(new FLinearColor(new Random().NextDouble() <= 0.5, new Random().NextDouble() <= 0.5, new Random().NextDouble() <= 0.5, 0f));
		}
		int segments = 10;
		int num = 30;
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.ActorComp.ActorLocation, (float)num, segments, this.RandomColor, 0f, 0f);
		UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, this.MoveToLocationConfig.Position.ToUeVector(false), (float)num, segments, this.RandomColor, 0f, 0f);
		if (moveToLocationConfig.NextMovePointConfig != null)
		{
			for (int i = 0; i < moveToLocationConfig.NextMovePointConfig.Size; i++)
			{
				UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, moveToLocationConfig.NextMovePointConfig.Get(i).ToUeVector(false), (float)num, segments, this.RandomColor, 0f, 0f);
			}
		}
	}

	// Token: 0x0400D0E7 RID: 53479
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400D0E8 RID: 53480
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D0E9 RID: 53481
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D0EA RID: 53482
	[Nullable(2)]
	private BaseUnifiedStateComponent StateComp;

	// Token: 0x0400D0EB RID: 53483
	[StaticVariableRuleIgnore]
	private static readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400D0EC RID: 53484
	[StaticVariableRuleIgnore]
	private static readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400D0ED RID: 53485
	[StaticVariableRuleIgnore]
	private static readonly Vector CacheVector3 = Vector.Create();

	// Token: 0x0400D0EE RID: 53486
	[StaticVariableRuleIgnore]
	private static readonly Quat CacheQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D0EF RID: 53487
	private float DeltaTime = 1f;

	// Token: 0x0400D0F0 RID: 53488
	private float CurrentDistance;

	// Token: 0x0400D0F1 RID: 53489
	private readonly Vector DirectionVector = Vector.Create();

	// Token: 0x0400D0F2 RID: 53490
	private readonly Vector CurrentToTargetVector = Vector.Create();

	// Token: 0x0400D0F3 RID: 53491
	private int PbDataId;

	// Token: 0x0400D0F4 RID: 53492
	private readonly Vector LastPatrolPoint = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D0F5 RID: 53493
	private readonly Vector StartMoveLocation = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D0F6 RID: 53494
	[Nullable(2)]
	private MoveToPointConfig MoveToLocationConfig;

	// Token: 0x0400D0F7 RID: 53495
	private readonly Vector PointCacheVector = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D0F8 RID: 53496
	private float CurTimeoutTime;

	// Token: 0x0400D0F9 RID: 53497
	private int TickProcessId;

	// Token: 0x0400D0FA RID: 53498
	private FLinearColor? RandomColor;
}
