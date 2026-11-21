using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Vehicle.Motor;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x020061D2 RID: 25042
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorAnimationSyncComponent : CharacterAnimationSyncComponent
	{
		// Token: 0x0603C191 RID: 246161 RVA: 0x0111ACF6 File Offset: 0x01118EF6
		static MotorAnimationSyncComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorAnimationSyncComponent.CreateStaticDefaultValue), new Action(MotorAnimationSyncComponent.ResetStaticDefaultValue));
		}

		// Token: 0x0603C192 RID: 246162 RVA: 0x0111AD15 File Offset: 0x01118F15
		protected override void OnActivate()
		{
			base.OnActivate();
			this.VehiclePerformComponent = base.Entity.CheckGetComponent<VehiclePerformComponent>();
			this.VehicleMovement = (this.ActorComp.Owner.GetComponentByClass(UKuroVehicleMovementComponent.StaticClass()) as UKuroVehicleMovementComponent);
		}

		// Token: 0x0603C193 RID: 246163 RVA: 0x0111AD53 File Offset: 0x01118F53
		protected override void AfterTickInner(float delta)
		{
			base.AfterTickInner(delta);
			this.TryCollectAnimationParams();
			this.TryPushAnimationParams();
		}

		// Token: 0x0603C194 RID: 246164 RVA: 0x0111AD69 File Offset: 0x01118F69
		protected override void OnTick(float delta)
		{
			this.ApplyMotorAnimSample();
		}

		// Token: 0x0603C195 RID: 246165 RVA: 0x0111AD74 File Offset: 0x01118F74
		private bool TryCollectAnimationParams()
		{
			if (GameModeModel.Instance.IsMulti)
			{
				BaseActorComponent actorComp = this.ActorComp;
				if (actorComp != null && actorComp.IsMoveAutonomousProxy && this.VehicleMovement != null)
				{
					VehiclePerformComponent vehiclePerformComponent = this.VehiclePerformComponent;
					bool flag = vehiclePerformComponent != null && vehiclePerformComponent.IsBeingImpacted;
					if ((!flag || Time.Instance.NowSeconds - this.LastSyncImpactTime < 0.10000000149011612) && Time.Instance.NowSeconds - this.LastPendingTime < 0.10000000149011612)
					{
						return false;
					}
					if (!flag && this.VehicleMovement.MotorSubState == EMotorSubState.Stop)
					{
						return false;
					}
					MotorAnimInfo motorAnimInfo = MotorAnimInfo.Create();
					UMotorWheelDisplayInfoObject wheelDisplayInfosObj = this.VehicleMovement.WheelDisplayInfosObj;
					if (wheelDisplayInfosObj != null)
					{
						FMotorWheelDisplayInfo fmotorWheelDisplayInfo = wheelDisplayInfosObj.DisplayInfos.Get(0);
						if (fmotorWheelDisplayInfo != null)
						{
							motorAnimInfo.FrontWheelInfo = new MotorWheelInfo
							{
								Accel = fmotorWheelDisplayInfo.WheelAccel,
								Speed = fmotorWheelDisplayInfo.WheelSpeed,
								Location = new Aki.Protocol.Vector
								{
									X = fmotorWheelDisplayInfo.WheelLocation.X,
									Y = fmotorWheelDisplayInfo.WheelLocation.Y,
									Z = fmotorWheelDisplayInfo.WheelLocation.Z
								}
							};
						}
						FMotorWheelDisplayInfo fmotorWheelDisplayInfo2 = wheelDisplayInfosObj.DisplayInfos.Get(1);
						if (fmotorWheelDisplayInfo2 != null)
						{
							motorAnimInfo.BackWheelInfo = new MotorWheelInfo
							{
								Accel = fmotorWheelDisplayInfo2.WheelAccel,
								Speed = fmotorWheelDisplayInfo2.WheelSpeed,
								Location = new Aki.Protocol.Vector
								{
									X = fmotorWheelDisplayInfo2.WheelLocation.X,
									Y = fmotorWheelDisplayInfo2.WheelLocation.Y,
									Z = fmotorWheelDisplayInfo2.WheelLocation.Z
								}
							};
						}
					}
					else
					{
						Log.Instance.Warn(ELogModule.Vehicle, ELogAuthor.ZFJ, "MotorAnimParam NoWheelInfoObj", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					if (this.VehiclePerformComponent != null && flag != this.LastBeingImpacted)
					{
						this.LastBeingImpacted = flag;
						VehiclePerformComponent vehiclePerformComponent2 = this.VehiclePerformComponent;
						motorAnimInfo.IsBeingImpacted = flag;
						if (flag)
						{
							motorAnimInfo.ImpactedVelocity = new Aki.Protocol.Vector
							{
								X = (float)vehiclePerformComponent2.ImpactedVelocity.X,
								Y = (float)vehiclePerformComponent2.ImpactedVelocity.Y,
								Z = (float)vehiclePerformComponent2.ImpactedVelocity.Z
							};
							if (vehiclePerformComponent2.CacheImpactHitResult != null)
							{
								global::Vector vector = global::Vector.Create(vehiclePerformComponent2.CacheImpactHitResult.Normal);
								motorAnimInfo.ImpactedNormal = new Aki.Protocol.Vector
								{
									X = (float)vector.X,
									Y = (float)vector.Y,
									Z = (float)vector.Z
								};
							}
							this.LastSyncImpactTime = Time.Instance.NowSeconds;
						}
					}
					if (this.MotorAnimInstance == null)
					{
						this.MotorAnimInstance = (base.MainAnimInstance as ABP_Motor_BaseVehicle_C);
					}
					if (this.MotorAnimInstance != null)
					{
						motorAnimInfo.MoveMix = new Aki.Protocol.Vector
						{
							X = this.MotorAnimInstance.移动混合.X,
							Y = this.MotorAnimInstance.移动混合.Y,
							Z = 0f
						};
					}
					this.PendingAnimInfos.Add(motorAnimInfo);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0603C196 RID: 246166 RVA: 0x0111B098 File Offset: 0x01119298
		private void TryPushAnimationParams()
		{
			if (this.PendingAnimInfos.Count == 0)
			{
				return;
			}
			MotorAnimEntity motorAnimEntity = MotorAnimEntity.Create();
			motorAnimEntity.EntityId = MathUtils.Instance.NumberToLong(this.ActorComp.CreatureData.GetCreatureDataId());
			foreach (MotorAnimInfo item in this.PendingAnimInfos)
			{
				motorAnimEntity.MotorAnimInfos.Add(item);
			}
			MotorAnimReplaySampleUdpPush motorAnimReplaySampleUdpPush = MotorAnimReplaySampleUdpPush.Create();
			motorAnimReplaySampleUdpPush.MotorAnimEntities.Add(motorAnimEntity);
			motorAnimReplaySampleUdpPush.SceneOwnerId = OnlineModel.Instance.OwnerId;
			Net.Instance.Send(EPushMessageId.MotorAnimReplaySampleUdpPush, motorAnimReplaySampleUdpPush);
			this.LastPendingTime = Time.Instance.NowSeconds;
			this.PendingAnimInfos = new List<MotorAnimInfo>();
		}

		// Token: 0x0603C197 RID: 246167 RVA: 0x0111B174 File Offset: 0x01119374
		public void ReceiveMotorAnimSample(IList<MotorAnimInfo> data)
		{
			foreach (MotorAnimInfo element in data)
			{
				this.ReplaySampleQueue.AddRear(element);
			}
		}

		// Token: 0x0603C198 RID: 246168 RVA: 0x0111B1C4 File Offset: 0x011193C4
		private void ApplyMotorAnimSample()
		{
			if (!GameModeModel.Instance.IsMulti)
			{
				return;
			}
			BaseActorComponent actorComp = this.ActorComp;
			if (actorComp != null && actorComp.IsMoveAutonomousProxy)
			{
				return;
			}
			if (this.VehiclePerformComponent == null || this.VehicleMovement == null)
			{
				return;
			}
			if (this.ReplaySampleQueue.Empty)
			{
				return;
			}
			while (!this.ReplaySampleQueue.Empty)
			{
				MotorAnimInfo motorAnimInfo = this.ReplaySampleQueue.RemoveFront();
				if (MotorAnimationSyncComponent.WheelInfos == null)
				{
					MotorAnimationSyncComponent.WheelInfos = new TArray<FMotorWheelDisplayInfo>();
					MotorAnimationSyncComponent.WheelInfos.Add(new FMotorWheelDisplayInfo());
					MotorAnimationSyncComponent.WheelInfos.Add(new FMotorWheelDisplayInfo());
				}
				FMotorWheelDisplayInfo fmotorWheelDisplayInfo = MotorAnimationSyncComponent.WheelInfos.Get(0);
				if (fmotorWheelDisplayInfo != null)
				{
					MotorWheelInfo frontWheelInfo = motorAnimInfo.FrontWheelInfo;
					fmotorWheelDisplayInfo.WheelSpeed = frontWheelInfo.Speed;
					fmotorWheelDisplayInfo.WheelAccel = frontWheelInfo.Accel;
					Aki.Protocol.Vector location = frontWheelInfo.Location;
					fmotorWheelDisplayInfo.WheelLocation = new FVector(location.X, location.Y, location.Z);
				}
				FMotorWheelDisplayInfo fmotorWheelDisplayInfo2 = MotorAnimationSyncComponent.WheelInfos.Get(1);
				if (fmotorWheelDisplayInfo2 != null)
				{
					MotorWheelInfo backWheelInfo = motorAnimInfo.BackWheelInfo;
					fmotorWheelDisplayInfo2.WheelSpeed = backWheelInfo.Speed;
					fmotorWheelDisplayInfo2.WheelAccel = backWheelInfo.Accel;
					Aki.Protocol.Vector location2 = backWheelInfo.Location;
					fmotorWheelDisplayInfo2.WheelLocation = new FVector(location2.X, location2.Y, location2.Z);
				}
				MotorAnimationSyncComponent.WheelInfosRef = MotorAnimationSyncComponent.WheelInfos;
				this.VehicleMovement.SetSimulatedMotorWheelInfos(ref MotorAnimationSyncComponent.WheelInfosRef);
				MotorAnimationSyncComponent.WheelInfosRef = null;
				VehiclePerformComponent vehiclePerformComponent = this.VehiclePerformComponent;
				vehiclePerformComponent.IsBeingImpacted = motorAnimInfo.IsBeingImpacted;
				if (motorAnimInfo.IsBeingImpacted && Time.Instance.NowSeconds - this.LastReplayBeingImpactedTime >= 1.0)
				{
					this.LastReplayBeingImpactedTime = Time.Instance.NowSeconds;
					VehiclePerformComponent vehiclePerformComponent2 = vehiclePerformComponent;
					Aki.Protocol.Vector impactedVelocity = motorAnimInfo.ImpactedVelocity;
					float velocityX = (impactedVelocity != null) ? impactedVelocity.X : 0f;
					Aki.Protocol.Vector impactedVelocity2 = motorAnimInfo.ImpactedVelocity;
					float velocityY = (impactedVelocity2 != null) ? impactedVelocity2.Y : 0f;
					Aki.Protocol.Vector impactedVelocity3 = motorAnimInfo.ImpactedVelocity;
					float velocityZ = (impactedVelocity3 != null) ? impactedVelocity3.Z : 0f;
					Aki.Protocol.Vector impactedNormal = motorAnimInfo.ImpactedNormal;
					float normalX = (impactedNormal != null) ? impactedNormal.X : 0f;
					Aki.Protocol.Vector impactedNormal2 = motorAnimInfo.ImpactedNormal;
					float normalY = (impactedNormal2 != null) ? impactedNormal2.Y : 0f;
					Aki.Protocol.Vector impactedNormal3 = motorAnimInfo.ImpactedNormal;
					vehiclePerformComponent2.SimulatedImpactInfo(velocityX, velocityY, velocityZ, normalX, normalY, (impactedNormal3 != null) ? impactedNormal3.Z : 0f);
				}
				if (this.MotorAnimInstance == null)
				{
					this.MotorAnimInstance = (base.MainAnimInstance as ABP_Motor_BaseVehicle_C);
				}
				if (this.MotorAnimInstance != null && motorAnimInfo.MoveMix != null)
				{
					this.MotorAnimInstance.移动混合 = new FVector2D(motorAnimInfo.MoveMix.X, motorAnimInfo.MoveMix.Y);
				}
			}
		}

		// Token: 0x0603C199 RID: 246169 RVA: 0x0111B466 File Offset: 0x01119666
		public new static void CreateStaticDefaultValue()
		{
			MotorAnimationSyncComponent.WheelInfosRef = null;
			MotorAnimationSyncComponent.WheelInfos = null;
		}

		// Token: 0x0603C19A RID: 246170 RVA: 0x0111B474 File Offset: 0x01119674
		public new static void ResetStaticDefaultValue()
		{
			MotorAnimationSyncComponent.WheelInfosRef = null;
			MotorAnimationSyncComponent.WheelInfos = null;
		}

		// Token: 0x0603C19B RID: 246171 RVA: 0x0111B484 File Offset: 0x01119684
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorAnimationSyncComponent motorAnimationSyncComponent = (MotorAnimationSyncComponent)componentTemplate;
			if (motorAnimationSyncComponent.VehicleMovement == null)
			{
				this.VehicleMovement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleMovement), "VehicleMovement"))
			{
				return false;
			}
			if (motorAnimationSyncComponent.VehiclePerformComponent == null)
			{
				this.VehiclePerformComponent = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehiclePerformComponent), "VehiclePerformComponent"))
			{
				return false;
			}
			if (motorAnimationSyncComponent.PendingAnimInfos == null)
			{
				this.PendingAnimInfos = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.PendingAnimInfos), "PendingAnimInfos"))
			{
				return false;
			}
			if (motorAnimationSyncComponent.ReplaySampleQueue != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReplaySampleQueue), "ReplaySampleQueue"))
			{
				return false;
			}
			if (motorAnimationSyncComponent.MotorAnimInstance == null)
			{
				this.MotorAnimInstance = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MotorAnimInstance), "MotorAnimInstance"))
			{
				return false;
			}
			this.LastPendingTime = motorAnimationSyncComponent.LastPendingTime;
			this.LastSyncImpactTime = motorAnimationSyncComponent.LastSyncImpactTime;
			this.LastReplayBeingImpactedTime = motorAnimationSyncComponent.LastReplayBeingImpactedTime;
			this.LastBeingImpacted = motorAnimationSyncComponent.LastBeingImpacted;
			return true;
		}

		// Token: 0x17007160 RID: 29024
		// (get) Token: 0x0603C19C RID: 246172 RVA: 0x0111B5A2 File Offset: 0x011197A2
		public override bool NeedClearInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007161 RID: 29025
		// (get) Token: 0x0603C19D RID: 246173 RVA: 0x0111B5A5 File Offset: 0x011197A5
		public override bool NeedActivateInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007162 RID: 29026
		// (get) Token: 0x0603C19E RID: 246174 RVA: 0x0111B5A8 File Offset: 0x011197A8
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007163 RID: 29027
		// (get) Token: 0x0603C19F RID: 246175 RVA: 0x0111B5AB File Offset: 0x011197AB
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FCBF RID: 130239
		private const float ANIMSYNCUDPSENDINTERVAL = 0.1f;

		// Token: 0x0401FCC0 RID: 130240
		private const float COLLISIONANIMSYNCUDPSENDINTERVAL = 1f;

		// Token: 0x0401FCC1 RID: 130241
		private const float ANIM_SYNC_IMPACT_INTERVAL = 0.1f;

		// Token: 0x0401FCC2 RID: 130242
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static TArray<FMotorWheelDisplayInfo> WheelInfosRef;

		// Token: 0x0401FCC3 RID: 130243
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static TArray<FMotorWheelDisplayInfo> WheelInfos;

		// Token: 0x0401FCC4 RID: 130244
		[Nullable(2)]
		public UKuroVehicleMovementComponent VehicleMovement;

		// Token: 0x0401FCC5 RID: 130245
		[Nullable(2)]
		private VehiclePerformComponent VehiclePerformComponent;

		// Token: 0x0401FCC6 RID: 130246
		public List<MotorAnimInfo> PendingAnimInfos = new List<MotorAnimInfo>();

		// Token: 0x0401FCC7 RID: 130247
		private readonly Deque<MotorAnimInfo> ReplaySampleQueue = new Deque<MotorAnimInfo>(4);

		// Token: 0x0401FCC8 RID: 130248
		[Nullable(2)]
		private ABP_Motor_BaseVehicle_C MotorAnimInstance;

		// Token: 0x0401FCC9 RID: 130249
		private double LastPendingTime;

		// Token: 0x0401FCCA RID: 130250
		private double LastSyncImpactTime;

		// Token: 0x0401FCCB RID: 130251
		private double LastReplayBeingImpactedTime;

		// Token: 0x0401FCCC RID: 130252
		private bool LastBeingImpacted;
	}
}
