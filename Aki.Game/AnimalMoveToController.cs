using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002E25 RID: 11813
[NullableContext(1)]
[Nullable(0)]
public class AnimalMoveToController
{
	// Token: 0x06018E2D RID: 101933 RVA: 0x00669A78 File Offset: 0x00667C78
	public AnimalMoveToController(Entity entity)
	{
		this.ActorComp = entity.GetComponent<CharacterActorComponent>();
		if (UKuroStaticLibrary.IsObjectClassByName(this.ActorComp.Owner, CharacterNameDefines.Instance.BP_BASEANIMAL))
		{
			BP_BaseAnimal_C bp_BaseAnimal_C = this.ActorComp.Owner as BP_BaseAnimal_C;
			this.AngularVelocityCurve = ((bp_BaseAnimal_C != null) ? bp_BaseAnimal_C.TurnSpeedCurve : null);
		}
		else
		{
			this.AngularVelocityCurve = null;
		}
		this.StateComp = entity.GetComponent<BaseUnifiedStateComponent>();
		this.MoveComp = entity.GetComponent<CharacterMoveComponent>();
		this.MaxAccelerationConfigCache = this.MoveComp.CharacterMovement.MaxAcceleration;
	}

	// Token: 0x06018E2E RID: 101934 RVA: 0x00669B17 File Offset: 0x00667D17
	public void Init(ECharMoveState moveState, bool rootMotion)
	{
		this.MoveState = moveState;
		this.StateComp.SetMoveState(moveState);
		this.RootMotion = rootMotion;
		this.IsInited = true;
	}

	// Token: 0x06018E2F RID: 101935 RVA: 0x00669B3C File Offset: 0x00667D3C
	public void Start(Vector targetLocation, bool isNavigation, float turnSpeed, double distanceErrorThreshold = 100.0)
	{
		if (!this.IsInited)
		{
			return;
		}
		this.NavigationOn = isNavigation;
		this.RobustTurnSpeed = turnSpeed;
		this.DistanceErrorThreshold = distanceErrorThreshold;
		this.ForceStop = false;
		if (this.MoveState == ECharMoveState.NormalSwim && !this.RootMotion)
		{
			this.MoveComp.CharacterMovement.MaxAcceleration = this.MaxAccelerationConfigCache;
		}
		if (this.MovePath != null)
		{
			this.MovePath.Clear();
		}
		else
		{
			this.MovePath = new List<Vector>();
		}
		if (!this.NavigationOn)
		{
			Vector vector = Vector.Create();
			vector.DeepCopy(targetLocation);
			this.MovePath.Add(vector);
			this.CurrentMoveIndex = 0;
			return;
		}
		if (!AiControllerLibrary.NavigationFindPath(this.ActorComp.Owner.GetWorld(), this.ActorComp.ActorLocation, targetLocation.ToUeVector(false), this.MovePath, null, null))
		{
			Vector vector2 = Vector.Create();
			vector2.DeepCopy(targetLocation);
			this.MovePath.Add(vector2);
			this.CurrentMoveIndex = 0;
			return;
		}
		this.CurrentMoveIndex = 1;
	}

	// Token: 0x06018E30 RID: 101936 RVA: 0x00669C4C File Offset: 0x00667E4C
	public EAnimalMoveToState Update(float delta)
	{
		if (this.ForceStop)
		{
			return EAnimalMoveToState.Failure;
		}
		Vector vector = this.MovePath[this.CurrentMoveIndex];
		if (vector.ContainsNaN())
		{
			return EAnimalMoveToState.Failure;
		}
		vector.Subtraction(this.ActorComp.ActorLocationProxy, this.CacheVector);
		GravityUtils.Instance.ConvertToPlanarVectorForActor(this.ActorComp, this.CacheVector);
		if (this.CacheVector.Size() < this.DistanceErrorThreshold)
		{
			if (this.CurrentMoveIndex == this.MovePath.Count - 1)
			{
				return EAnimalMoveToState.Success;
			}
			this.CurrentMoveIndex++;
			return EAnimalMoveToState.Running;
		}
		else
		{
			this.CacheVector.Normalize(9.99999993922529E-09);
			if (vector.ContainsNaN())
			{
				return EAnimalMoveToState.Failure;
			}
			this.ExecuteInputMoveLogic(this.CacheVector);
			return EAnimalMoveToState.Running;
		}
	}

	// Token: 0x06018E31 RID: 101937 RVA: 0x00669D14 File Offset: 0x00667F14
	public void Stop()
	{
		this.ForceStop = true;
	}

	// Token: 0x06018E32 RID: 101938 RVA: 0x00669D20 File Offset: 0x00667F20
	public void Finish()
	{
		if (this.MoveState == ECharMoveState.NormalSwim && !this.RootMotion)
		{
			CharacterActorComponent actorComp = this.ActorComp;
			if (actorComp != null)
			{
				actorComp.ClearInput(false, true);
			}
			this.MoveComp.CharacterMovement.MaxAcceleration = this.MaxAccelerationConfigCache;
		}
		this.IsInited = false;
	}

	// Token: 0x06018E33 RID: 101939 RVA: 0x00669D70 File Offset: 0x00667F70
	private void ExecuteInputMoveLogic(Vector direction)
	{
		this.ActorComp.SetInputDirect(direction, false);
		float turnSpeed = this.RobustTurnSpeed;
		if (this.AngularVelocityCurve != null)
		{
			double num = MathUtils.Instance.GetAngleByVectorDot(this.ActorComp.ActorForwardProxy, direction) * 0.01745329238474369;
			float floatValue = this.AngularVelocityCurve.GetFloatValue((float)num);
			turnSpeed = MathUtils.Instance.Lerp(this.RobustTurnSpeed, 360f, floatValue);
		}
		AiControllerLibrary.TurnToDirect(this.ActorComp, direction, turnSpeed, false, 0f);
	}

	// Token: 0x0400BAAD RID: 47789
	private const int DISTANCE_ERROR_THRESHOLD = 100;

	// Token: 0x0400BAAE RID: 47790
	private const float MAX_TURN_SPEED = 360f;

	// Token: 0x0400BAAF RID: 47791
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400BAB0 RID: 47792
	private readonly BaseUnifiedStateComponent StateComp;

	// Token: 0x0400BAB1 RID: 47793
	private readonly CharacterMoveComponent MoveComp;

	// Token: 0x0400BAB2 RID: 47794
	[Nullable(2)]
	private readonly UCurveFloat AngularVelocityCurve;

	// Token: 0x0400BAB3 RID: 47795
	private ECharMoveState MoveState;

	// Token: 0x0400BAB4 RID: 47796
	private bool RootMotion;

	// Token: 0x0400BAB5 RID: 47797
	private bool NavigationOn;

	// Token: 0x0400BAB6 RID: 47798
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> MovePath;

	// Token: 0x0400BAB7 RID: 47799
	private int CurrentMoveIndex;

	// Token: 0x0400BAB8 RID: 47800
	private float RobustTurnSpeed;

	// Token: 0x0400BAB9 RID: 47801
	private bool IsInited;

	// Token: 0x0400BABA RID: 47802
	private bool ForceStop;

	// Token: 0x0400BABB RID: 47803
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400BABC RID: 47804
	private double DistanceErrorThreshold;

	// Token: 0x0400BABD RID: 47805
	private readonly float MaxAccelerationConfigCache;
}
