using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x0200265E RID: 9822
[NullableContext(1)]
[Nullable(0)]
public class PatrolMoveLogic
{
	// Token: 0x06018979 RID: 100729 RVA: 0x007746DF File Offset: 0x007728DF
	public void Init(Entity entity)
	{
		this.Entity = entity;
		this.ActorComp = entity.CheckGetComponent<CharacterActorComponent>();
		this.AnimComp = entity.CheckGetComponent<CharacterAnimationComponent>();
		this.StateComp = entity.GetComponent<BaseUnifiedStateComponent>();
	}

	// Token: 0x0601897A RID: 100730 RVA: 0x0077470C File Offset: 0x0077290C
	[NullableContext(2)]
	public Vector GetMovePoint(int index)
	{
		if (index >= 0 && index < this.MovePoint.Count)
		{
			return this.MovePoint[index];
		}
		return null;
	}

	// Token: 0x0601897B RID: 100731 RVA: 0x0077472E File Offset: 0x0077292E
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

	// Token: 0x0601897C RID: 100732 RVA: 0x0077476B File Offset: 0x0077296B
	public void StopMove()
	{
		this.MovePoint.Clear();
		this.PreviousIndex = 0;
		this.CurrentIndex = 0;
	}

	// Token: 0x0601897D RID: 100733 RVA: 0x00774788 File Offset: 0x00772988
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
			this.ActorComp.SetInputDirect(this.DirectionVector, false, EInputDirectSpace.Relative);
			return true;
		}
		this.ActorComp.SetOverrideTurnSpeed(new float?(this.TurnSpeed));
		if (this.IsFly)
		{
			this.ActorComp.SetInputDirect(this.ActorComp.ActorForwardProxy, false, EInputDirectSpace.World);
		}
		else
		{
			this.ActorComp.SetInputDirect(this.DirectionVector, false, EInputDirectSpace.World);
		}
		AiControllerLibrary.TurnToDirect(this.ActorComp, this.DirectionVector, this.TurnSpeed, this.IsFly, 0f);
		return true;
	}

	// Token: 0x0601897E RID: 100734 RVA: 0x0077492D File Offset: 0x00772B2D
	private void UpdateMovePoint(int newIndex)
	{
		this.PreviousIndex = this.CurrentIndex;
		this.CurrentIndex = newIndex;
		this.CurrentToLocation = this.MovePoint[this.CurrentIndex];
		this.UpdateCurrentTargetVector();
	}

	// Token: 0x0601897F RID: 100735 RVA: 0x00774960 File Offset: 0x00772B60
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

	// Token: 0x06018980 RID: 100736 RVA: 0x00774A88 File Offset: 0x00772C88
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

	// Token: 0x06018981 RID: 100737 RVA: 0x00774B70 File Offset: 0x00772D70
	private void ResetActorLocation()
	{
		this.LastPatrolPoint.DeepCopy(this.CurrentToLocation);
	}

	// Token: 0x06018982 RID: 100738 RVA: 0x00774B84 File Offset: 0x00772D84
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

	// Token: 0x06018983 RID: 100739 RVA: 0x00774BF8 File Offset: 0x00772DF8
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

	// Token: 0x06018984 RID: 100740 RVA: 0x00774CA8 File Offset: 0x00772EA8
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

	// Token: 0x06018985 RID: 100741 RVA: 0x00774DB0 File Offset: 0x00772FB0
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

	// Token: 0x06018986 RID: 100742 RVA: 0x00774E34 File Offset: 0x00773034
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

	// Token: 0x0400D52B RID: 54571
	private const int WHILE_UPDATE_MOVE_POINT_COUNT = 2;

	// Token: 0x0400D52C RID: 54572
	private const float RESET_LOCATION_TOLERANCE = 10f;

	// Token: 0x0400D52D RID: 54573
	[Nullable(2)]
	protected Entity Entity;

	// Token: 0x0400D52E RID: 54574
	[Nullable(2)]
	private CharacterActorComponent ActorComp;

	// Token: 0x0400D52F RID: 54575
	[Nullable(2)]
	private CharacterAnimationComponent AnimComp;

	// Token: 0x0400D530 RID: 54576
	[Nullable(2)]
	private BaseUnifiedStateComponent StateComp;

	// Token: 0x0400D531 RID: 54577
	private bool IsFly;

	// Token: 0x0400D532 RID: 54578
	private float TurnSpeed;

	// Token: 0x0400D533 RID: 54579
	private float Distance;

	// Token: 0x0400D534 RID: 54580
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400D535 RID: 54581
	private readonly Vector CacheVector2 = Vector.Create();

	// Token: 0x0400D536 RID: 54582
	private readonly Quat CacheQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400D537 RID: 54583
	private float CurrentDistance;

	// Token: 0x0400D538 RID: 54584
	private readonly Vector DirectionVector = Vector.Create();

	// Token: 0x0400D539 RID: 54585
	private readonly Vector CurrentToTargetVector = Vector.Create();

	// Token: 0x0400D53A RID: 54586
	private readonly Vector LastPatrolPoint = Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400D53B RID: 54587
	private int PreviousIndex;

	// Token: 0x0400D53C RID: 54588
	private int CurrentIndex;

	// Token: 0x0400D53D RID: 54589
	private Vector CurrentToLocation = Vector.Create();

	// Token: 0x0400D53E RID: 54590
	private readonly List<Vector> MovePoint = new List<Vector>();
}
