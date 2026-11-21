using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Effect;
using UnrealEngine;

// Token: 0x02002513 RID: 9491
[NullableContext(1)]
[Nullable(0)]
public class GameplayCueFollow : GameplayCueEffect
{
	// Token: 0x060177B7 RID: 96183 RVA: 0x006ED620 File Offset: 0x006EB820
	protected override void OnInit()
	{
		base.OnInit();
		this.IsLockRevolution = this.CueConfig.BLockRevolution;
		this.InterpSpeed = (float)this.CueConfig.InterpSpeed;
		Aki.Config.Vector value = this.CueConfig.FaultTolerance.Value;
		this.FaultTolerance = global::Vector.Create((double)Math.Abs(value.X), (double)Math.Abs(value.Y), (double)Math.Abs(value.Z));
		this.FarthestDistance = (float)this.CueConfig.FarthestDistance;
		Aki.Config.Vector value2 = this.CueConfig.LockRotation.Value;
		global::Vector vector = global::Vector.Create((double)value2.X, (double)value2.Y, (double)value2.Z);
		this.IsLockRotation = !vector.IsZero();
		vector.Rotation(this.LockRotation);
		this.IsLockCamera = this.CueConfig.LockCamera;
		WorldEntity entity = this.EntityHandle.Entity;
		this.MoveComp = ((entity != null) ? entity.GetComponent<BaseMoveComponent>() : null);
	}

	// Token: 0x060177B8 RID: 96184 RVA: 0x006ED729 File Offset: 0x006EB929
	protected override void OnTick(float delta)
	{
		base.OnTick(delta);
		this.RefreshEffectLocationAndRotation(new float?(delta));
	}

	// Token: 0x060177B9 RID: 96185 RVA: 0x006ED740 File Offset: 0x006EB940
	protected override void AttachEffect(bool _ = false)
	{
		this.RefreshEffectLocationAndRotation(null);
	}

	// Token: 0x060177BA RID: 96186 RVA: 0x006ED75C File Offset: 0x006EB95C
	protected override void SetTargetMeshAndSocket()
	{
		base.SetTargetMeshAndSocket();
		Transform socketTransform = this.SocketTransform;
		FTransformDouble ftransformDouble = this.TargetMesh.D_GetSocketTransform(this.TargetSocket, ERelativeTransformSpace.RTS_World);
		socketTransform.FromUeTransform(ftransformDouble);
		this.RelativeTransform.ComposeTransforms(this.SocketTransform, this.TargetTransform);
		global::Vector actorLocation = this.ActorLocation;
		FVectorDouble fvectorDouble = this.ActorInternal.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		this.ClosestDistance = global::Vector.Dist2D(this.TargetTransform.GetLocation(), this.ActorLocation);
	}

	// Token: 0x060177BB RID: 96187 RVA: 0x006ED7DC File Offset: 0x006EB9DC
	private void RefreshEffectLocationAndRotation(float? delta = null)
	{
		if (!EffectSystem.Instance.IsValid(this.EffectViewHandle))
		{
			return;
		}
		OneOf<KuroEffectActorHandle, AActor> effectActor = EffectSystem.Instance.GetEffectActor(this.EffectViewHandle);
		global::Vector currentLocation = this.CurrentLocation;
		FVectorDouble fvectorDouble = effectActor.D_K2_GetActorLocation();
		currentLocation.FromUeVector(fvectorDouble);
		Rotator currentRotation = this.CurrentRotation;
		FRotator frotator = effectActor.K2_GetActorRotation();
		currentRotation.FromUeRotator(frotator);
		if (this.IsLockRevolution)
		{
			if (this.IsStandardGravity())
			{
				global::Vector targetLocation = this.TargetLocation;
				fvectorDouble = this.TargetMesh.D_GetSocketLocation(this.TargetSocket);
				targetLocation.FromUeVector(fvectorDouble);
				this.TargetLocation.AdditionEqual(this.RelativeTransform.GetLocation());
				Rotator targetRotation = this.TargetRotation;
				frotator = this.TargetMesh.GetSocketRotation(this.TargetSocket);
				targetRotation.FromUeRotator(frotator);
			}
			else
			{
				global::Vector targetLocation2 = this.TargetLocation;
				fvectorDouble = this.TargetMesh.D_GetSocketLocation(this.TargetSocket);
				targetLocation2.FromUeVector(fvectorDouble);
				if (this.TempLocationInGravity == null)
				{
					this.TempLocationInGravity = new global::Vector();
				}
				global::Vector location = this.RelativeTransform.GetLocation();
				FightCamera fightCamera = CameraModel.Instance.MainModel.FightCamera;
				Quat quat;
				if (fightCamera == null)
				{
					quat = null;
				}
				else
				{
					FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
					quat = ((logicComponent != null) ? logicComponent.GravityQuat : null);
				}
				Quat quat2 = quat;
				if (quat2 != null)
				{
					quat2.RotateVector(location, this.TempLocationInGravity);
				}
				else
				{
					this.TempLocationInGravity.FromUeVector(location);
				}
				this.TargetLocation.AdditionEqual(this.TempLocationInGravity);
				Rotator targetRotation2 = this.TargetRotation;
				frotator = this.TargetMesh.GetSocketRotation(this.TargetSocket);
				targetRotation2.FromUeRotator(frotator);
			}
		}
		else
		{
			Transform socketTransform = this.SocketTransform;
			FTransformDouble ftransformDouble = this.TargetMesh.D_GetSocketTransform(this.TargetSocket, ERelativeTransformSpace.RTS_World);
			socketTransform.FromUeTransform(ftransformDouble);
			if (this.IsLockCamera)
			{
				if (this.IsStandardGravity())
				{
					this.CameraRotation.Pitch = 0f;
					this.CameraRotation.Yaw = CameraController.Instance.MainModel.CameraRotator.Yaw;
					this.CameraRotation.Roll = 0f;
				}
				else
				{
					FightCamera fightCamera2 = CameraModel.Instance.MainModel.FightCamera;
					float? num;
					if (fightCamera2 == null)
					{
						num = null;
					}
					else
					{
						FightCameraLogicComponent logicComponent2 = fightCamera2.LogicComponent;
						num = ((logicComponent2 != null) ? new float?(logicComponent2.CameraRotationInGravity.Yaw) : null);
					}
					float? num2 = num;
					if (num2 != null)
					{
						if (this.TempRotationInGravity == null)
						{
							this.TempRotationInGravity = Rotator.Create(0f, 0f, 0f);
						}
						this.TempRotationInGravity.Yaw = num2.Value;
						CameraUtility.GetRotatorInNormal(this.TempRotationInGravity, this.CameraRotation);
					}
				}
				this.SocketTransform.SetRotation(this.CameraRotation.Quaternion(null));
			}
			this.RelativeTransform.ComposeTransforms(this.SocketTransform, this.TargetTransform);
			this.TargetLocation = this.TargetTransform.GetLocation();
			this.TargetRotation = this.TargetTransform.GetRotation().Rotator(null);
		}
		if (delta != null)
		{
			double num3 = global::Vector.Distance(this.CurrentLocation, this.TargetLocation);
			if (num3 < 0.10000000149011612)
			{
				this.IsMoving = false;
				return;
			}
			this.CorrectTargetByTolerance(this.CurrentLocation, this.TargetLocation);
			this.CorrectTargetByFarthestDistance(this.CurrentLocation, this.TargetLocation, this.CurrentRotation, this.TargetRotation, num3);
			MathUtils.Instance.VectorInterpTo(this.CurrentLocation, this.TargetLocation, (double)delta.Value, (double)this.InterpSpeed, this.TargetLocation);
			MathUtils.Instance.RotatorInterpTo(this.CurrentRotation, this.TargetRotation, (double)delta.Value, (double)this.InterpSpeed, this.TargetRotation);
		}
		global::Vector actorLocation = this.ActorLocation;
		fvectorDouble = this.ActorInternal.D_K2_GetActorLocation();
		actorLocation.FromUeVector(fvectorDouble);
		if (!this.CurrentRotation.Equals(this.TargetRotation, 0.1f) && global::Vector.Dist2D(this.TargetLocation, this.ActorLocation) < this.ClosestDistance && this.IsStandardGravity())
		{
			this.ActorLocation.Z = this.TargetLocation.Z;
			this.TargetLocation.Subtraction(this.ActorLocation, this.Direction);
			this.Direction.Normalize(9.99999993922529E-09);
			this.Direction.MultiplyEqual(this.ClosestDistance);
			this.ActorLocation.Addition(this.Direction, this.TargetLocation);
		}
		OneOf<KuroEffectActorHandle, AActor> self = effectActor;
		fvectorDouble = this.TargetLocation.ToUeVector(false);
		frotator = (this.IsLockRotation ? this.GetLockRotation().ToUeRotator() : this.TargetRotation.ToUeRotator());
		self.D_K2_SetActorLocationAndRotation(fvectorDouble, frotator, false, ref WorldGlobal.SweepHitResult, true);
	}

	// Token: 0x060177BC RID: 96188 RVA: 0x006EDC80 File Offset: 0x006EBE80
	private void CorrectTargetByTolerance(global::Vector currentLocation, global::Vector targetLocation)
	{
		if (!this.IsMoving)
		{
			targetLocation.X = MathUtils.Instance.Clamp(currentLocation.X, targetLocation.X - this.FaultTolerance.X, targetLocation.X + this.FaultTolerance.X);
			bool flag = targetLocation.X != currentLocation.X;
			targetLocation.Y = MathUtils.Instance.Clamp(currentLocation.Y, targetLocation.Y - this.FaultTolerance.Y, targetLocation.Y + this.FaultTolerance.Y);
			bool flag2 = targetLocation.Y != currentLocation.Y;
			targetLocation.Z = MathUtils.Instance.Clamp(currentLocation.Z, targetLocation.Z - this.FaultTolerance.Z, targetLocation.Z + this.FaultTolerance.Z);
			bool flag3 = targetLocation.Z != currentLocation.Z;
			if (flag || flag2 || flag3)
			{
				this.IsMoving = true;
			}
		}
	}

	// Token: 0x060177BD RID: 96189 RVA: 0x006EDD88 File Offset: 0x006EBF88
	private void CorrectTargetByFarthestDistance(global::Vector currentLocation, global::Vector targetLocation, Rotator currentRotation, Rotator targetRotation, double distance)
	{
		double num = (double)this.FarthestDistance / Math.Max(distance, 0.10000000149011612);
		if (num < 1.0)
		{
			global::Vector.Lerp(targetLocation, currentLocation, num, this.BorderLocation);
			Rotator.Lerp(targetRotation, currentRotation, (float)num, this.BorderRotation);
			currentLocation.DeepCopy(this.BorderLocation);
			currentRotation.DeepCopy(this.BorderRotation);
		}
	}

	// Token: 0x060177BE RID: 96190 RVA: 0x006EDDF0 File Offset: 0x006EBFF0
	private bool IsStandardGravity()
	{
		return this.MoveComp == null || this.MoveComp.IsStandardGravity;
	}

	// Token: 0x060177BF RID: 96191 RVA: 0x006EDE08 File Offset: 0x006EC008
	private Rotator GetLockRotation()
	{
		if (this.IsStandardGravity())
		{
			return this.LockRotation;
		}
		FightCamera fightCamera = CameraModel.Instance.MainModel.FightCamera;
		Quat quat;
		if (fightCamera == null)
		{
			quat = null;
		}
		else
		{
			FightCameraLogicComponent logicComponent = fightCamera.LogicComponent;
			quat = ((logicComponent != null) ? logicComponent.GravityQuat : null);
		}
		Quat quat2 = quat;
		if (quat2 != null)
		{
			if (this.LockRotationInGravity == null)
			{
				this.LockRotationInGravity = Rotator.Create();
			}
			quat2.Rotator(this.LockRotationInGravity);
			this.LockRotationInGravity.AdditionEqual(this.LockRotation);
			return this.LockRotationInGravity;
		}
		return this.LockRotation;
	}

	// Token: 0x0400C7B0 RID: 51120
	private const float MAGIC_NUMBER = 0.1f;

	// Token: 0x0400C7B1 RID: 51121
	private readonly global::Vector ActorLocation = global::Vector.Create();

	// Token: 0x0400C7B2 RID: 51122
	private readonly global::Vector Direction = global::Vector.Create();

	// Token: 0x0400C7B3 RID: 51123
	private readonly global::Vector BorderLocation = global::Vector.Create();

	// Token: 0x0400C7B4 RID: 51124
	private readonly Rotator BorderRotation = Rotator.Create();

	// Token: 0x0400C7B5 RID: 51125
	private readonly global::Vector CurrentLocation = global::Vector.Create();

	// Token: 0x0400C7B6 RID: 51126
	private readonly Rotator CurrentRotation = Rotator.Create();

	// Token: 0x0400C7B7 RID: 51127
	private global::Vector TargetLocation = global::Vector.Create();

	// Token: 0x0400C7B8 RID: 51128
	private Rotator TargetRotation = Rotator.Create();

	// Token: 0x0400C7B9 RID: 51129
	private bool IsLockRevolution;

	// Token: 0x0400C7BA RID: 51130
	private bool IsLockRotation;

	// Token: 0x0400C7BB RID: 51131
	private bool IsLockCamera;

	// Token: 0x0400C7BC RID: 51132
	private readonly Rotator LockRotation = Rotator.Create();

	// Token: 0x0400C7BD RID: 51133
	private readonly Rotator CameraRotation = Rotator.Create();

	// Token: 0x0400C7BE RID: 51134
	private float InterpSpeed;

	// Token: 0x0400C7BF RID: 51135
	[Nullable(2)]
	private global::Vector FaultTolerance;

	// Token: 0x0400C7C0 RID: 51136
	private float FarthestDistance;

	// Token: 0x0400C7C1 RID: 51137
	private double ClosestDistance;

	// Token: 0x0400C7C2 RID: 51138
	private bool IsMoving;

	// Token: 0x0400C7C3 RID: 51139
	[Nullable(2)]
	private BaseMoveComponent MoveComp;

	// Token: 0x0400C7C4 RID: 51140
	[Nullable(2)]
	private global::Vector TempLocationInGravity;

	// Token: 0x0400C7C5 RID: 51141
	[Nullable(2)]
	private Rotator TempRotationInGravity;

	// Token: 0x0400C7C6 RID: 51142
	[Nullable(2)]
	private Rotator LockRotationInGravity;
}
