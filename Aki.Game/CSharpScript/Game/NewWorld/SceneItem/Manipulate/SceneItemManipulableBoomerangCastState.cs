using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x02006294 RID: 25236
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableBoomerangCastState : SceneItemManipulableCastState
	{
		// Token: 0x0603CEA8 RID: 249512 RVA: 0x0117E380 File Offset: 0x0117C580
		public SceneItemManipulableBoomerangCastState(SceneItemManipulatableComponent sceneItem, [Nullable(new byte[]
		{
			0,
			1
		})] TSubclassOf<UCameraShakeBase> cameraShake, [Nullable(2)] UKuroForceFeedbackEffect gamepadShake) : base(sceneItem, new TSubclassOf<UCameraShakeBase>?(cameraShake), gamepadShake)
		{
			this.BoomerangConfig = (this.SceneItem.Config.ThrowCfg.MotionConfig as ICircumnutation);
			this.Velocity = this.BoomerangConfig.Velocity;
			this.RotateSpeed = this.BoomerangConfig.AngularVelocity;
			if (!StringUtils.IsEmpty(this.BoomerangConfig.AngularVelocityCurve))
			{
				ResourceSystem.Instance.LoadAsync<UCurveFloat>(this.BoomerangConfig.AngularVelocityCurve, delegate([Nullable(2)] UCurveFloat result, string _)
				{
					this.AngularVelocityCurve = result;
				}, 100, "js_undefined");
			}
			if (!StringUtils.IsEmpty(this.BoomerangConfig.VelocityCurve))
			{
				ResourceSystem.Instance.LoadAsync<UCurveFloat>(this.BoomerangConfig.VelocityCurve, delegate([Nullable(2)] UCurveFloat result, string _)
				{
					this.VelocityCurve = result;
				}, 100, "js_undefined");
			}
			this.VelocityDirection = Vector.Create();
			IRenderTrajectoryConfig renderTrajectoryConfig = (this.SceneItem.Config.ThrowCfg.MotionConfig as ICircumnutation).RenderTrajectoryConfig;
			this.LifeTime = ((renderTrajectoryConfig != null) ? new float?(renderTrajectoryConfig.Time) : null).GetValueOrDefault();
		}

		// Token: 0x0603CEA9 RID: 249513 RVA: 0x0117E4DC File Offset: 0x0117C6DC
		protected override void OnEnter()
		{
			base.OnEnter();
			this.SimulationTimer = 0f;
			this.PrevLoc.DeepCopy(this.LastLoc);
			if (this.HitCallback != null)
			{
				this.SceneItem.ActorComp.Owner.OnActorHit.Add(this.HitCallback);
			}
			this.SceneItem.ForceMoving = true;
		}

		// Token: 0x0603CEAA RID: 249514 RVA: 0x0117E53F File Offset: 0x0117C73F
		public void SetVelocityDirection(Vector dire)
		{
			this.VelocityDirection.DeepCopy(dire);
		}

		// Token: 0x0603CEAB RID: 249515 RVA: 0x0117E550 File Offset: 0x0117C750
		protected override void OnTick(float delta)
		{
			this.TempDelta += delta;
			while (this.TempDelta > this.TimeStepLimit)
			{
				this.UpdateLocation(this.TimeStepLimit);
				this.TempDelta -= this.TimeStepLimit;
			}
			this.UpdateRotationAccordingToVelocity();
		}

		// Token: 0x0603CEAC RID: 249516 RVA: 0x0117E5A0 File Offset: 0x0117C7A0
		protected override void UpdateLocation(float delta)
		{
			this.SimulationTimer += delta;
			Vector slalomLocation = this.GetSlalomLocation(this.PrevLoc, this.VelocityDirection, this.UpVector, delta);
			this.SceneItem.ActorComp.SetActorLocation(slalomLocation.ToUeVector(false), "[ManipulableCastState.UpdateSlalomLocation]", true);
			this.PrevLoc = slalomLocation;
		}

		// Token: 0x0603CEAD RID: 249517 RVA: 0x0117E5FC File Offset: 0x0117C7FC
		private Vector GetSlalomLocation(Vector startLoc, Vector velocityDirection, Vector upVector, float timeStep)
		{
			float num = this.RotateSpeed * timeStep;
			UCurveFloat angularVelocityCurve = this.AngularVelocityCurve;
			if (angularVelocityCurve != null && angularVelocityCurve.IsValid())
			{
				num *= this.AngularVelocityCurve.GetFloatValue(this.SimulationTimer);
			}
			num *= (float)((this.BoomerangConfig.Direction == EDirection.Right) ? 1 : -1);
			num = (float)Math.Floor((double)(num * 100f)) / 100f;
			velocityDirection.RotateAngleAxis((double)num, upVector, velocityDirection);
			Vector vector = Vector.Create();
			velocityDirection.Multiply((double)(this.Velocity * timeStep), vector);
			UCurveFloat velocityCurve = this.VelocityCurve;
			if (velocityCurve != null && velocityCurve.IsValid())
			{
				vector.MultiplyEqual((double)this.VelocityCurve.GetFloatValue(this.SimulationTimer));
			}
			vector.Set(Math.Floor(vector.X * 100.0) / 100.0, Math.Floor(vector.Y * 100.0) / 100.0, Math.Floor(vector.Z * 100.0) / 100.0);
			startLoc.Addition(vector, vector);
			return vector;
		}

		// Token: 0x0603CEAE RID: 249518 RVA: 0x0117E724 File Offset: 0x0117C924
		public List<Vector> GetCastPath(Vector targetDirection, float? time = null)
		{
			List<Vector> list = new List<Vector>();
			this.VelocityDirection.DeepCopy(targetDirection);
			this.LastLoc = Vector.Create(this.SceneItem.ActorComp.ActorLocationProxy);
			Vector vector = Vector.Create(this.LastLoc);
			Vector vector2 = Vector.Create(Vector.UpVectorProxy);
			vector2.CrossProduct(this.VelocityDirection, vector2);
			vector2.Normalize(9.99999993922529E-09);
			this.UpVector.DeepCopy(vector2);
			this.VelocityDirection.CrossProduct(this.UpVector, this.UpVector);
			this.UpVector.Normalize(9.99999993922529E-09);
			this.SimulationTimer = 0f;
			list.Add(vector);
			float num = time ?? this.LifeTime;
			for (float num2 = 0f; num2 < num; num2 += this.TimeStepLimit)
			{
				this.SimulationTimer += this.TimeStepLimit;
				Vector slalomLocation = this.GetSlalomLocation(vector, targetDirection, this.UpVector, this.TimeStepLimit);
				vector = slalomLocation;
				list.Add(slalomLocation);
			}
			return list;
		}

		// Token: 0x0603CEAF RID: 249519 RVA: 0x0117E846 File Offset: 0x0117CA46
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x040204AB RID: 132267
		private readonly float Velocity;

		// Token: 0x040204AC RID: 132268
		[Nullable(2)]
		private readonly Vector VelocityDirection;

		// Token: 0x040204AD RID: 132269
		private readonly float RotateSpeed = 180f;

		// Token: 0x040204AE RID: 132270
		private readonly Vector UpVector = Vector.Create();

		// Token: 0x040204AF RID: 132271
		[Nullable(2)]
		private readonly ICircumnutation BoomerangConfig;

		// Token: 0x040204B0 RID: 132272
		[Nullable(2)]
		private UCurveFloat AngularVelocityCurve;

		// Token: 0x040204B1 RID: 132273
		[Nullable(2)]
		private UCurveFloat VelocityCurve;

		// Token: 0x040204B2 RID: 132274
		private float SimulationTimer;

		// Token: 0x040204B3 RID: 132275
		private readonly float LifeTime;

		// Token: 0x040204B4 RID: 132276
		private readonly float TimeStepLimit = 0.033f;

		// Token: 0x040204B5 RID: 132277
		private Vector PrevLoc = Vector.Create();

		// Token: 0x040204B6 RID: 132278
		private Vector LastLoc = Vector.Create();

		// Token: 0x040204B7 RID: 132279
		private float TempDelta;
	}
}
