using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelGamePlay;
using UnrealEngine;

// Token: 0x0200265A RID: 9818
[NullableContext(1)]
[Nullable(0)]
public class MoveToLocation
{
	// Token: 0x060188F2 RID: 100594 RVA: 0x00772E05 File Offset: 0x00771005
	[NullableContext(2)]
	public Vector GetCurrentMoveToLocation()
	{
		MoveToPointConfig moveToLocationConfig = this.MoveToLocationConfig;
		return ((moveToLocationConfig != null) ? moveToLocationConfig.Position : null) ?? null;
	}

	// Token: 0x060188F3 RID: 100595 RVA: 0x00772E1E File Offset: 0x0077101E
	public void UpdateConfigMoveState(ECharMoveState? state)
	{
		if (this.MoveToLocationConfig == null)
		{
			return;
		}
		this.MoveToLocationConfig.MoveState = state;
	}

	// Token: 0x060188F4 RID: 100596 RVA: 0x00772E38 File Offset: 0x00771038
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

	// Token: 0x060188F5 RID: 100597 RVA: 0x00772EC8 File Offset: 0x007710C8
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

	// Token: 0x060188F6 RID: 100598 RVA: 0x00772F4C File Offset: 0x0077114C
	public void Init(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = this.Entity.GetComponent<CharacterActorComponent>();
		this.StateComp = this.Entity.GetComponent<BaseUnifiedStateComponent>();
		this.AnimComp = this.Entity.GetComponent<CharacterAnimationComponent>();
		this.PbDataId = this.ActorComp.CreatureData.GetPbDataId();
	}

	// Token: 0x060188F7 RID: 100599 RVA: 0x00772FA9 File Offset: 0x007711A9
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

	// Token: 0x060188F8 RID: 100600 RVA: 0x00772FC0 File Offset: 0x007711C0
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

	// Token: 0x060188F9 RID: 100601 RVA: 0x007730B8 File Offset: 0x007712B8
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

	// Token: 0x060188FA RID: 100602 RVA: 0x0077310D File Offset: 0x0077130D
	public void Dispose()
	{
		this.StopMove(null);
	}

	// Token: 0x060188FB RID: 100603 RVA: 0x00773118 File Offset: 0x00771318
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

	// Token: 0x060188FC RID: 100604 RVA: 0x0077322C File Offset: 0x0077142C
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
			this.ActorComp.SetInputDirect(this.DirectionVector, false, EInputDirectSpace.Relative);
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
		this.ActorComp.SetInputDirect(this.ActorComp.ActorForwardProxy, false, EInputDirectSpace.World);
		return false;
	}

	// Token: 0x060188FD RID: 100605 RVA: 0x0077345F File Offset: 0x0077165F
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

	// Token: 0x060188FE RID: 100606 RVA: 0x00773498 File Offset: 0x00771698
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

	// Token: 0x060188FF RID: 100607 RVA: 0x0077353C File Offset: 0x0077173C
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

	// Token: 0x06018900 RID: 100608 RVA: 0x007735B3 File Offset: 0x007717B3
	private void Clear()
	{
		this.CurTimeoutTime = 0f;
		this.StartMoveLocation.Reset();
		this.LastPatrolPoint.Reset();
	}

	// Token: 0x06018901 RID: 100609 RVA: 0x007735D8 File Offset: 0x007717D8
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

	// Token: 0x06018902 RID: 100610 RVA: 0x00773768 File Offset: 0x00771968
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

	// Token: 0x06018903 RID: 100611 RVA: 0x00773834 File Offset: 0x00771A34
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

	// Token: 0x06018904 RID: 100612 RVA: 0x007738F3 File Offset: 0x00771AF3
	private void UpdateLastActorLocation()
	{
		this.MoveToLocationConfig.UpdateTargetPosition();
		this.LastPatrolPoint.DeepCopy(this.MoveToLocationConfig.Position);
	}

	// Token: 0x06018905 RID: 100613 RVA: 0x00773918 File Offset: 0x00771B18
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

	// Token: 0x06018906 RID: 100614 RVA: 0x007739C8 File Offset: 0x00771BC8
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

	// Token: 0x06018907 RID: 100615 RVA: 0x00773AE0 File Offset: 0x00771CE0
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

	// Token: 0x06018908 RID: 100616 RVA: 0x00773B78 File Offset: 0x00771D78
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
			actorComp2.SetInputDirect(MoveToLocation.CacheVector, false, EInputDirectSpace.World);
		}
		double inB = this.ActorComp.ActorVelocityProxy.Size();
		MoveToLocation.CacheVector.MultiplyEqual(inB);
		this.ActorComp.ActorVelocityProxy.Set(MoveToLocation.CacheVector.X, MoveToLocation.CacheVector.Y, MoveToLocation.CacheVector.Z);
	}

	// Token: 0x06018909 RID: 100617 RVA: 0x00773C7C File Offset: 0x00771E7C
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

	// Token: 0x0601890A RID: 100618 RVA: 0x00773D80 File Offset: 0x00771F80
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

	// Token: 0x0400D4F5 RID: 54517
	[Nullable(2)]
	private Entity Entity;

	// Token: 0x0400D4F6 RID: 54518
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D4F7 RID: 54519
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D4F8 RID: 54520
	[Nullable(2)]
	private BaseUnifiedStateComponent StateComp;

	// Token: 0x0400D4F9 RID: 54521
	[StaticVariableRuleIgnore]
	private static readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400D4FA RID: 54522
	[StaticVariableRuleIgnore]
	private static readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400D4FB RID: 54523
	[StaticVariableRuleIgnore]
	private static readonly Vector CacheVector3 = Vector.Create();

	// Token: 0x0400D4FC RID: 54524
	[StaticVariableRuleIgnore]
	private static readonly Quat CacheQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D4FD RID: 54525
	private float DeltaTime = 1f;

	// Token: 0x0400D4FE RID: 54526
	private float CurrentDistance;

	// Token: 0x0400D4FF RID: 54527
	private readonly Vector DirectionVector = Vector.Create();

	// Token: 0x0400D500 RID: 54528
	private readonly Vector CurrentToTargetVector = Vector.Create();

	// Token: 0x0400D501 RID: 54529
	private int PbDataId;

	// Token: 0x0400D502 RID: 54530
	private readonly Vector LastPatrolPoint = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D503 RID: 54531
	private readonly Vector StartMoveLocation = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D504 RID: 54532
	[Nullable(2)]
	private MoveToPointConfig MoveToLocationConfig;

	// Token: 0x0400D505 RID: 54533
	private readonly Vector PointCacheVector = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D506 RID: 54534
	private float CurTimeoutTime;

	// Token: 0x0400D507 RID: 54535
	private int TickProcessId;

	// Token: 0x0400D508 RID: 54536
	private FLinearColor? RandomColor;
}
