using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.SceneItem.Manipulate
{
	// Token: 0x020071DF RID: 29151
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneItemManipulableBoomerangCastState : SceneItemManipulableCastState
	{
		// Token: 0x060475A6 RID: 292262 RVA: 0x0122454C File Offset: 0x0122274C
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

		// Token: 0x060475A7 RID: 292263 RVA: 0x012246A8 File Offset: 0x012228A8
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

		// Token: 0x060475A8 RID: 292264 RVA: 0x0122470B File Offset: 0x0122290B
		public void SetVelocityDirection(Vector dire)
		{
			this.VelocityDirection.DeepCopy(dire);
		}

		// Token: 0x060475A9 RID: 292265 RVA: 0x0122471C File Offset: 0x0122291C
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

		// Token: 0x060475AA RID: 292266 RVA: 0x0122476C File Offset: 0x0122296C
		protected override void UpdateLocation(float delta)
		{
			this.SimulationTimer += delta;
			Vector slalomLocation = this.GetSlalomLocation(this.PrevLoc, this.VelocityDirection, this.UpVector, delta);
			this.SceneItem.ActorComp.SetActorLocation(slalomLocation.ToUeVector(false), "[ManipulableCastState.UpdateSlalomLocation]", true);
			this.PrevLoc = slalomLocation;
		}

		// Token: 0x060475AB RID: 292267 RVA: 0x012247C8 File Offset: 0x012229C8
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

		// Token: 0x060475AC RID: 292268 RVA: 0x012248F0 File Offset: 0x01222AF0
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

		// Token: 0x060475AD RID: 292269 RVA: 0x01224A12 File Offset: 0x01222C12
		public override bool IsNoLockCasting()
		{
			return true;
		}

		// Token: 0x0402583C RID: 153660
		private readonly float Velocity;

		// Token: 0x0402583D RID: 153661
		[Nullable(2)]
		private readonly Vector VelocityDirection;

		// Token: 0x0402583E RID: 153662
		private readonly float RotateSpeed = 180f;

		// Token: 0x0402583F RID: 153663
		private readonly Vector UpVector = Vector.Create();

		// Token: 0x04025840 RID: 153664
		[Nullable(2)]
		private readonly ICircumnutation BoomerangConfig;

		// Token: 0x04025841 RID: 153665
		[Nullable(2)]
		private UCurveFloat AngularVelocityCurve;

		// Token: 0x04025842 RID: 153666
		[Nullable(2)]
		private UCurveFloat VelocityCurve;

		// Token: 0x04025843 RID: 153667
		private float SimulationTimer;

		// Token: 0x04025844 RID: 153668
		private readonly float LifeTime;

		// Token: 0x04025845 RID: 153669
		private readonly float TimeStepLimit = 0.033f;

		// Token: 0x04025846 RID: 153670
		private Vector PrevLoc = Vector.Create();

		// Token: 0x04025847 RID: 153671
		private Vector LastLoc = Vector.Create();

		// Token: 0x04025848 RID: 153672
		private float TempDelta;
	}
}
