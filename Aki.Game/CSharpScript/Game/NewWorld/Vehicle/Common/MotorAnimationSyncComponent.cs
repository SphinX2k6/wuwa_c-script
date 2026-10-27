using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.Vehicle.Motor;
using CSharpScript.Game.NewWorld.Character.Common.Component;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Common
{
	// Token: 0x02007051 RID: 28753
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorAnimationSyncComponent : CharacterAnimationSyncComponent
	{
		// Token: 0x06045FAB RID: 286635 RVA: 0x01170F5A File Offset: 0x0116F15A
		static MotorAnimationSyncComponent()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(MotorAnimationSyncComponent.CreateStaticDefaultValue), new Action(MotorAnimationSyncComponent.ResetStaticDefaultValue));
		}

		// Token: 0x06045FAC RID: 286636 RVA: 0x01170F79 File Offset: 0x0116F179
		protected override void OnActivate()
		{
			base.OnActivate();
			this.VehiclePerformComponent = base.Entity.CheckGetComponent<VehiclePerformComponent>();
			this.VehicleMovement = (this.ActorComp.Owner.GetComponentByClass(UKuroVehicleMovementComponent.StaticClass()) as UKuroVehicleMovementComponent);
		}

		// Token: 0x06045FAD RID: 286637 RVA: 0x01170FB7 File Offset: 0x0116F1B7
		protected override void AfterTickInner(float delta)
		{
			base.AfterTickInner(delta);
			this.TryCollectAnimationParams();
			this.TryPushAnimationParams();
		}

		// Token: 0x06045FAE RID: 286638 RVA: 0x01170FCD File Offset: 0x0116F1CD
		protected override void OnTick(float delta)
		{
			this.ApplyMotorAnimSample();
		}

		// Token: 0x06045FAF RID: 286639 RVA: 0x01170FD8 File Offset: 0x0116F1D8
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

		// Token: 0x06045FB0 RID: 286640 RVA: 0x011712FC File Offset: 0x0116F4FC
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

		// Token: 0x06045FB1 RID: 286641 RVA: 0x011713D8 File Offset: 0x0116F5D8
		public void ReceiveMotorAnimSample(IList<MotorAnimInfo> data)
		{
			foreach (MotorAnimInfo element in data)
			{
				this.ReplaySampleQueue.AddRear(element);
			}
		}

		// Token: 0x06045FB2 RID: 286642 RVA: 0x01171428 File Offset: 0x0116F628
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

		// Token: 0x06045FB3 RID: 286643 RVA: 0x011716CA File Offset: 0x0116F8CA
		public new static void CreateStaticDefaultValue()
		{
			MotorAnimationSyncComponent.WheelInfosRef = null;
			MotorAnimationSyncComponent.WheelInfos = null;
		}

		// Token: 0x06045FB4 RID: 286644 RVA: 0x011716D8 File Offset: 0x0116F8D8
		public new static void ResetStaticDefaultValue()
		{
			MotorAnimationSyncComponent.WheelInfosRef = null;
			MotorAnimationSyncComponent.WheelInfos = null;
		}

		// Token: 0x06045FB5 RID: 286645 RVA: 0x011716E8 File Offset: 0x0116F8E8
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorAnimationSyncComponent motorAnimationSyncComponent = (MotorAnimationSyncComponent)componentTemplate;
			if (base.CanResetComponentProperty("VehicleMovement"))
			{
				if (motorAnimationSyncComponent.VehicleMovement == null)
				{
					this.VehicleMovement = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UKuroVehicleMovementComponent>(this.VehicleMovement), "VehicleMovement"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("VehiclePerformComponent"))
			{
				if (motorAnimationSyncComponent.VehiclePerformComponent == null)
				{
					this.VehiclePerformComponent = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehiclePerformComponent>(this.VehiclePerformComponent), "VehiclePerformComponent"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("PendingAnimInfos"))
			{
				if (motorAnimationSyncComponent.PendingAnimInfos == null)
				{
					this.PendingAnimInfos = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<MotorAnimInfo>>(this.PendingAnimInfos), "PendingAnimInfos"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ReplaySampleQueue") && motorAnimationSyncComponent.ReplaySampleQueue != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Deque<MotorAnimInfo>>(this.ReplaySampleQueue), "ReplaySampleQueue"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("MotorAnimInstance"))
			{
				if (motorAnimationSyncComponent.MotorAnimInstance == null)
				{
					this.MotorAnimInstance = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ABP_Motor_BaseVehicle_C>(this.MotorAnimInstance), "MotorAnimInstance"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("LastPendingTime"))
			{
				this.LastPendingTime = motorAnimationSyncComponent.LastPendingTime;
			}
			if (base.CanResetComponentProperty("LastSyncImpactTime"))
			{
				this.LastSyncImpactTime = motorAnimationSyncComponent.LastSyncImpactTime;
			}
			if (base.CanResetComponentProperty("LastReplayBeingImpactedTime"))
			{
				this.LastReplayBeingImpactedTime = motorAnimationSyncComponent.LastReplayBeingImpactedTime;
			}
			if (base.CanResetComponentProperty("LastBeingImpacted"))
			{
				this.LastBeingImpacted = motorAnimationSyncComponent.LastBeingImpacted;
			}
			return true;
		}

		// Token: 0x04024A09 RID: 150025
		private const float ANIMSYNCUDPSENDINTERVAL = 0.1f;

		// Token: 0x04024A0A RID: 150026
		private const float COLLISIONANIMSYNCUDPSENDINTERVAL = 1f;

		// Token: 0x04024A0B RID: 150027
		private const float ANIM_SYNC_IMPACT_INTERVAL = 0.1f;

		// Token: 0x04024A0C RID: 150028
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static TArray<FMotorWheelDisplayInfo> WheelInfosRef;

		// Token: 0x04024A0D RID: 150029
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private static TArray<FMotorWheelDisplayInfo> WheelInfos;

		// Token: 0x04024A0E RID: 150030
		[Nullable(2)]
		public UKuroVehicleMovementComponent VehicleMovement;

		// Token: 0x04024A0F RID: 150031
		[Nullable(2)]
		private VehiclePerformComponent VehiclePerformComponent;

		// Token: 0x04024A10 RID: 150032
		public List<MotorAnimInfo> PendingAnimInfos = new List<MotorAnimInfo>();

		// Token: 0x04024A11 RID: 150033
		private readonly Deque<MotorAnimInfo> ReplaySampleQueue = new Deque<MotorAnimInfo>(4);

		// Token: 0x04024A12 RID: 150034
		[Nullable(2)]
		private ABP_Motor_BaseVehicle_C MotorAnimInstance;

		// Token: 0x04024A13 RID: 150035
		private double LastPendingTime;

		// Token: 0x04024A14 RID: 150036
		private double LastSyncImpactTime;

		// Token: 0x04024A15 RID: 150037
		private double LastReplayBeingImpactedTime;

		// Token: 0x04024A16 RID: 150038
		private bool LastBeingImpacted;
	}
}
