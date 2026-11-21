using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.NPC.Animal;
using UnrealEngine;
using UnrealEngine.Extension;

// Token: 0x02002381 RID: 9089
[NullableContext(1)]
[Nullable(0)]
public class AnimalMoveToController
{
	// Token: 0x060166FA RID: 91898 RVA: 0x0068F95C File Offset: 0x0068DB5C
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

	// Token: 0x060166FB RID: 91899 RVA: 0x0068F9FB File Offset: 0x0068DBFB
	public void Init(ECharMoveState moveState, bool rootMotion)
	{
		this.MoveState = moveState;
		this.StateComp.SetMoveState(moveState);
		this.RootMotion = rootMotion;
		this.IsInited = true;
	}

	// Token: 0x060166FC RID: 91900 RVA: 0x0068FA20 File Offset: 0x0068DC20
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

	// Token: 0x060166FD RID: 91901 RVA: 0x0068FB30 File Offset: 0x0068DD30
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

	// Token: 0x060166FE RID: 91902 RVA: 0x0068FBF8 File Offset: 0x0068DDF8
	public void Stop()
	{
		this.ForceStop = true;
	}

	// Token: 0x060166FF RID: 91903 RVA: 0x0068FC04 File Offset: 0x0068DE04
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

	// Token: 0x06016700 RID: 91904 RVA: 0x0068FC54 File Offset: 0x0068DE54
	private void ExecuteInputMoveLogic(Vector direction)
	{
		this.ActorComp.SetInputDirect(direction, false, EInputDirectSpace.World);
		float turnSpeed = this.RobustTurnSpeed;
		if (this.AngularVelocityCurve != null)
		{
			double num = MathUtils.Instance.GetAngleByVectorDot(this.ActorComp.ActorForwardProxy, direction) * 0.01745329238474369;
			float floatValue = this.AngularVelocityCurve.GetFloatValue((float)num);
			turnSpeed = MathUtils.Instance.Lerp(this.RobustTurnSpeed, 360f, floatValue);
		}
		AiControllerLibrary.TurnToDirect(this.ActorComp, direction, turnSpeed, false, 0f);
	}

	// Token: 0x0400BE3B RID: 48699
	private const int DISTANCE_ERROR_THRESHOLD = 100;

	// Token: 0x0400BE3C RID: 48700
	private const float MAX_TURN_SPEED = 360f;

	// Token: 0x0400BE3D RID: 48701
	private readonly CharacterActorComponent ActorComp;

	// Token: 0x0400BE3E RID: 48702
	private readonly BaseUnifiedStateComponent StateComp;

	// Token: 0x0400BE3F RID: 48703
	private readonly CharacterMoveComponent MoveComp;

	// Token: 0x0400BE40 RID: 48704
	[Nullable(2)]
	private readonly UCurveFloat AngularVelocityCurve;

	// Token: 0x0400BE41 RID: 48705
	private ECharMoveState MoveState;

	// Token: 0x0400BE42 RID: 48706
	private bool RootMotion;

	// Token: 0x0400BE43 RID: 48707
	private bool NavigationOn;

	// Token: 0x0400BE44 RID: 48708
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private List<Vector> MovePath;

	// Token: 0x0400BE45 RID: 48709
	private int CurrentMoveIndex;

	// Token: 0x0400BE46 RID: 48710
	private float RobustTurnSpeed;

	// Token: 0x0400BE47 RID: 48711
	private bool IsInited;

	// Token: 0x0400BE48 RID: 48712
	private bool ForceStop;

	// Token: 0x0400BE49 RID: 48713
	private readonly Vector CacheVector = Vector.Create();

	// Token: 0x0400BE4A RID: 48714
	private double DistanceErrorThreshold;

	// Token: 0x0400BE4B RID: 48715
	private readonly float MaxAccelerationConfigCache;
}
