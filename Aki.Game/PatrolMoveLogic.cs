using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x02003106 RID: 12550
[NullableContext(1)]
[Nullable(0)]
public class PatrolMoveLogic
{
	// Token: 0x0601AF47 RID: 110407 RVA: 0x0074E89F File Offset: 0x0074CA9F
	public void Init(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = entity.CheckGetComponent<CharacterActorComponent>();
		this.AnimComp = entity.CheckGetComponent<CharacterAnimationComponent>();
		this.StateComp = entity.GetComponent<BaseUnifiedStateComponent>();
	}

	// Token: 0x0601AF48 RID: 110408 RVA: 0x0074E8CC File Offset: 0x0074CACC
	[NullableContext(2)]
	public Vector GetMovePoint(int index)
	{
		if (index >= 0 && index < this.MovePoint.Count)
		{
			return this.MovePoint[index];
		}
		return null;
	}

	// Token: 0x0601AF49 RID: 110409 RVA: 0x0074E8EE File Offset: 0x0074CAEE
	public void UpdateMovePath(List<Vector> path, bool fly, float turnSpeed, float distance)
	{
		this.MovePoint.Clear();
		this.MovePoint.AddRange(path);
		this.Distance = distance;
		this.IsFly = fly;
		this.TurnSpeed = turnSpeed;
		this.CurrentIndex = 0;
		this.UpdateMovePoint(1);
	}

	// Token: 0x0601AF4A RID: 110410 RVA: 0x0074E92B File Offset: 0x0074CB2B
	public void StopMove()
	{
		this.MovePoint.Clear();
		this.PreviousIndex = 0;
		this.CurrentIndex = 0;
	}

	// Token: 0x0601AF4B RID: 110411 RVA: 0x0074E948 File Offset: 0x0074CB48
	public bool UpdateMove(float deltaSeconds)
	{
		if (this.GetMovePoint(this.CurrentIndex) == null)
		{
			this.StopMove();
			return false;
		}
		if (GlobalData.IsPlayInEditor && MoveToLocationController.DebugDraw)
		{
			this.DrawDebug();
		}
		this.UpdateCurrentTargetVector();
		int num = 0;
		while (this.CheckExceedTargetPoint() && num < 2)
		{
			num++;
			if (this.CurrentIndex == this.MovePoint.Count - 1)
			{
				return false;
			}
			this.UpdateMovePoint(this.CurrentIndex + 1);
		}
		this.DirectionVector.Normalize(9.99999993922529E-09);
		BaseUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null && stateComp.PositionState == ECharPositionState.Climb)
		{
			this.CacheQuat.DeepCopy(this.ActorComp.ActorQuatProxy);
			this.CacheQuat.Inverse(this.CacheQuat);
			this.CacheQuat.RotateVector(this.DirectionVector, this.DirectionVector);
			float num2 = (float)this.DirectionVector.X;
			this.DirectionVector.X = this.DirectionVector.Z;
			this.DirectionVector.Z = (double)num2;
			this.ActorComp.SetInputDirect(this.DirectionVector, false);
			return true;
		}
		this.ActorComp.SetOverrideTurnSpeed(new float?(this.TurnSpeed));
		if (this.IsFly)
		{
			this.ActorComp.SetInputDirect(this.ActorComp.ActorForwardProxy, false);
		}
		else
		{
			this.ActorComp.SetInputDirect(this.DirectionVector, false);
		}
		AiControllerLibrary.TurnToDirect(this.ActorComp, this.DirectionVector, this.TurnSpeed, this.IsFly, 0f);
		return true;
	}

	// Token: 0x0601AF4C RID: 110412 RVA: 0x0074EAEA File Offset: 0x0074CCEA
	private void UpdateMovePoint(int newIndex)
	{
		this.PreviousIndex = this.CurrentIndex;
		this.CurrentIndex = newIndex;
		this.CurrentToLocation = this.MovePoint[this.CurrentIndex];
		this.UpdateCurrentTargetVector();
	}

	// Token: 0x0601AF4D RID: 110413 RVA: 0x0074EB1C File Offset: 0x0074CD1C
	private void UpdateCurrentTargetVector()
	{
		this.DirectionVector.DeepCopy(this.CurrentToLocation);
		this.DirectionVector.SubtractionEqual(this.ActorComp.ActorLocationProxy);
		this.CurrentToTargetVector.DeepCopy(this.DirectionVector);
		BaseUnifiedStateComponent stateComp = this.StateComp;
		if (stateComp != null && stateComp.PositionState == ECharPositionState.Climb)
		{
			this.CacheVector.DeepCopy(this.DirectionVector);
			float num = (float)this.CacheVector.DotProduct(this.ActorComp.ActorForwardProxy);
			this.CacheVector.DeepCopy(this.ActorComp.ActorForwardProxy);
			this.CacheVector.MultiplyEqual((double)num);
			this.CacheVector.UnaryNegation(this.CacheVector);
			this.CacheVector.AdditionEqual(this.DirectionVector);
			this.DirectionVector.DeepCopy(this.CacheVector);
		}
		else if (!this.IsFly)
		{
			this.DirectionVector.Z = 0.0;
		}
		this.CurrentDistance = (float)(this.IsFly ? this.CurrentToTargetVector.Size() : this.CurrentToTargetVector.Size2D());
	}

	// Token: 0x0601AF4E RID: 110414 RVA: 0x0074EC44 File Offset: 0x0074CE44
	private bool CheckExceedTargetPoint()
	{
		if (this.PreviousIndex == this.CurrentIndex || this.CurrentDistance <= this.Distance)
		{
			this.ResetActorLocation();
			return true;
		}
		this.CurrentToLocation.Subtraction(this.MovePoint[this.PreviousIndex], this.CacheVector);
		GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.CacheVector, 0.0);
		this.CacheVector2.DeepCopy(this.CurrentToTargetVector);
		GravityUtils.Instance.SetZnInGravityForActor(this.ActorComp, this.CacheVector2, 0.0);
		float num = (float)this.CacheVector2.DotProduct(this.CacheVector);
		if (num < 0f || this.CurrentDistance < this.Distance)
		{
			this.ResetActorLocation();
		}
		return num < 0f || this.CurrentDistance < this.Distance;
	}

	// Token: 0x0601AF4F RID: 110415 RVA: 0x0074ED2C File Offset: 0x0074CF2C
	private void ResetActorLocation()
	{
		this.LastPatrolPoint.DeepCopy(this.CurrentToLocation);
	}

	// Token: 0x0601AF50 RID: 110416 RVA: 0x0074ED40 File Offset: 0x0074CF40
	public bool ResetLastPointCondition()
	{
		if (this.LastPatrolPoint.Size() < 1.0)
		{
			return false;
		}
		if (Vector.Dist2D(this.LastPatrolPoint, this.ActorComp.ActorLocationProxy) < (double)(this.Distance + 10f))
		{
			this.LastPatrolPoint.Set(0.0, 0.0, 0.0);
			return false;
		}
		return true;
	}

	// Token: 0x0601AF51 RID: 110417 RVA: 0x0074EDB4 File Offset: 0x0074CFB4
	public void ResetLastPatrolPoint(float deltaSeconds)
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

	// Token: 0x0601AF52 RID: 110418 RVA: 0x0074EE64 File Offset: 0x0074D064
	private unsafe void SetLocationAndRotation()
	{
		if (this.IsFly)
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

	// Token: 0x0601AF53 RID: 110419 RVA: 0x0074EF6C File Offset: 0x0074D16C
	private void DrawDebug()
	{
		if (this.MovePoint.Count == 0 || !GlobalData.IsPlayInEditor)
		{
			return;
		}
		for (int i = this.MovePoint.Count - 1; i > -1; i--)
		{
			Vector vector = this.MovePoint[i];
			UKismetSystemLibrary.D_DrawDebugSphere(GlobalData.World, vector.ToUeVector(false), 35f, 10, new FLinearColor?((i == this.CurrentIndex) ? ColorUtils.LinearRed : ColorUtils.LinearGreen), 1f, 0f);
		}
	}

	// Token: 0x0601AF54 RID: 110420 RVA: 0x0074EFF0 File Offset: 0x0074D1F0
	public void ForceSetToLastPatrolPoint(Vector targetLocation, float deltaSeconds)
	{
		this.LastPatrolPoint.DeepCopy(targetLocation);
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

	// Token: 0x0400D11D RID: 53533
	private const int WHILE_UPDATE_MOVE_POINT_COUNT = 2;

	// Token: 0x0400D11E RID: 53534
	private const float RESET_LOCATION_TOLERANCE = 10f;

	// Token: 0x0400D11F RID: 53535
	[Nullable(2)]
	protected Entity Entity;

	// Token: 0x0400D120 RID: 53536
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D121 RID: 53537
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D122 RID: 53538
	[Nullable(2)]
	private BaseUnifiedStateComponent StateComp;

	// Token: 0x0400D123 RID: 53539
	private bool IsFly;

	// Token: 0x0400D124 RID: 53540
	private float TurnSpeed;

	// Token: 0x0400D125 RID: 53541
	private float Distance;

	// Token: 0x0400D126 RID: 53542
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400D127 RID: 53543
	private readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400D128 RID: 53544
	private readonly Quat CacheQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D129 RID: 53545
	private float CurrentDistance;

	// Token: 0x0400D12A RID: 53546
	private readonly Vector DirectionVector = Vector.Create();

	// Token: 0x0400D12B RID: 53547
	private readonly Vector CurrentToTargetVector = Vector.Create();

	// Token: 0x0400D12C RID: 53548
	private readonly Vector LastPatrolPoint = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D12D RID: 53549
	private int PreviousIndex;

	// Token: 0x0400D12E RID: 53550
	private int CurrentIndex;

	// Token: 0x0400D12F RID: 53551
	private Vector CurrentToLocation = Vector.Create();

	// Token: 0x0400D130 RID: 53552
	private readonly List<Vector> MovePoint = new List<Vector>();
}
