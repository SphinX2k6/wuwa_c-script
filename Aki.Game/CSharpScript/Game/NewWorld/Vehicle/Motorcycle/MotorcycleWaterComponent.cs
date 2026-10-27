using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x0200702D RID: 28717
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleWaterComponent : EntityComponent, IComponentDependency
	{
		// Token: 0x17009BD3 RID: 39891
		// (get) Token: 0x06045E8B RID: 286347 RVA: 0x01165A11 File Offset: 0x01163C11
		public static Type[] Dependencies
		{
			get
			{
				return new Type[]
				{
					typeof(VehicleActorComponent),
					typeof(VehicleMoveComponent)
				};
			}
		}

		// Token: 0x17009BD4 RID: 39892
		// (get) Token: 0x06045E8C RID: 286348 RVA: 0x01165A33 File Offset: 0x01163C33
		// (set) Token: 0x06045E8D RID: 286349 RVA: 0x01165A3C File Offset: 0x01163C3C
		protected bool Immersion
		{
			get
			{
				return this.ImmersionInternal;
			}
			set
			{
				if (this.ImmersionInternal == value)
				{
					return;
				}
				this.ImmersionInternal = value;
				if (value)
				{
					BaseTagComponent tagComp = this.TagComp;
					if (tagComp == null)
					{
						return;
					}
					tagComp.AddTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.车体浸水"]));
					return;
				}
				else
				{
					BaseTagComponent tagComp2 = this.TagComp;
					if (tagComp2 == null)
					{
						return;
					}
					tagComp2.RemoveTag(new int?(GameplayTagDefine.EGameplayTagId["载具.摩托.移动.车体浸水"]));
					return;
				}
			}
		}

		// Token: 0x17009BD5 RID: 39893
		// (get) Token: 0x06045E8E RID: 286350 RVA: 0x01165AA7 File Offset: 0x01163CA7
		// (set) Token: 0x06045E8F RID: 286351 RVA: 0x01165AB0 File Offset: 0x01163CB0
		public bool InSwimArea
		{
			get
			{
				return this.InSwimAreaInternal;
			}
			protected set
			{
				if (this.InSwimAreaInternal == value)
				{
					return;
				}
				this.InSwimAreaInternal = value;
				EventSystem.Instance.EmitWithTarget<bool>(base.Entity, EEventName.MotorcycleWaterAreaChange, value);
				if (SundryModel.Instance.GetModuleDebugLevel("MotorWater") > 0)
				{
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Motor;
					ELogAuthor author = ELogAuthor.XDW;
					string message = "MotorcycleWaterComponent.MotorcycleWaterAreaChange";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("InArea", value);
					instance.Info(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
		}

		// Token: 0x06045E90 RID: 286352 RVA: 0x01165B28 File Offset: 0x01163D28
		private void RefreshSwimAreaHeight()
		{
			if (this.MoveComp != null && !this.MoveComp.IsStandardGravity)
			{
				this.InSwimArea = true;
				this.SwimAreaHeightAboveActor = 500.0;
				return;
			}
			float num = 0f;
			UObject owner = this.ActorComp.Owner;
			FVectorDouble actorLocation = this.ActorComp.ActorLocation;
			this.InSwimArea = UNavigationSystemV1.D_NavigationGetWaterSurface(owner, actorLocation, this.WaterAreaDetectExtent, ref num, this.ActorComp.Owner, null, 150f);
			if (this.InSwimArea)
			{
				double num2 = (double)num;
				this.SwimAreaHeightAboveActor = num2 - this.ActorComp.ActorLocationProxy.Z + 100.0;
				return;
			}
			this.SwimAreaHeightAboveActor = 0.0;
		}

		// Token: 0x06045E91 RID: 286353 RVA: 0x01165BE8 File Offset: 0x01163DE8
		protected override bool OnStart()
		{
			this.ActorComp = base.Entity.GetComponent<VehicleActorComponent>();
			this.MoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
			this.TagComp = base.Entity.GetComponent<BaseTagComponent>();
			this.TraceWaterCapability = new MotorcycleTraceWaterCapability(this.ActorComp);
			this.TraceWaterCapability.Activate();
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			EventSystem.Instance.AddWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			return true;
		}

		// Token: 0x06045E92 RID: 286354 RVA: 0x01165C8C File Offset: 0x01163E8C
		protected override bool OnEnd()
		{
			this.ActorComp = null;
			this.MoveComp = null;
			this.TagComp = null;
			MotorcycleTraceWaterCapability traceWaterCapability = this.TraceWaterCapability;
			if (traceWaterCapability != null)
			{
				traceWaterCapability.Deactivate();
			}
			this.TraceWaterCapability = null;
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenEntered, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenEntered));
			EventSystem.Instance.RemoveWithTarget<VehiclePassengerInfo, bool>(base.Entity, EEventName.OnVehicleBeenLeaved, new Action<VehiclePassengerInfo, bool>(this.OnVehicleBeenLeaved));
			return true;
		}

		// Token: 0x06045E93 RID: 286355 RVA: 0x01165D0C File Offset: 0x01163F0C
		protected override void OnTick(float delta)
		{
			VehicleActorComponent actorComp = this.ActorComp;
			if (this.LastPosition.Equals(actorComp.ActorLocationProxy, 1.0))
			{
				return;
			}
			this.LastPosition.DeepCopy(actorComp.ActorLocationProxy);
			this.RefreshSwimAreaHeight();
			if (!this.InSwimArea || this.TraceWaterCapability == null)
			{
				this.Immersion = false;
				return;
			}
			VehicleMoveComponent moveComp = this.MoveComp;
			TEnumAsByte<ECollisionResponse>? tenumAsByte;
			if (moveComp == null)
			{
				tenumAsByte = null;
			}
			else
			{
				UKuroVehicleMovementComponent vehicleMovement = moveComp.VehicleMovement;
				if (vehicleMovement == null)
				{
					tenumAsByte = null;
				}
				else
				{
					UPrimitiveComponent updatedPrimitive = vehicleMovement.UpdatedPrimitive;
					tenumAsByte = ((updatedPrimitive != null) ? new TEnumAsByte<ECollisionResponse>?(updatedPrimitive.GetCollisionResponseToChannel(KuroCollisionChannel.KuroWater)) : null);
				}
			}
			if (tenumAsByte == ECollisionResponse.ECR_Block)
			{
				this.Immersion = false;
				return;
			}
			TraceWaterResult traceWaterResult = this.TraceWaterCapability.TraceWater(this.SwimAreaHeightAboveActor, this.IMMERSION_DEPTH);
			if (!traceWaterResult.FoundWater)
			{
				this.Immersion = false;
				return;
			}
			if (this.TraceWaterCapability.CeilingCheck((double)traceWaterResult.MinWaterHeight))
			{
				this.Immersion = false;
				return;
			}
			if ((double)traceWaterResult.MinWaterHeight > this.LEAVE_MOTOR_DEPTH)
			{
				if (this.NextSendLeaveTime <= Time.Instance.Now)
				{
					this.NextSendLeaveTime = Time.Instance.Now + this.SEND_LEAVE_PERIOD;
					BaseVehiclePerformComponent component = base.Entity.GetComponent<BaseVehiclePerformComponent>();
					if (component != null)
					{
						component.TryLeaveAllAtOnce(ELeaveVehicleType.StandUp, "MotorWater");
					}
					CreatureController.Instance.SetEntityEnable(base.Entity, false, "MotorWater", true);
					this.Immersion = false;
					return;
				}
			}
			else
			{
				if ((double)traceWaterResult.MinWaterHeight > this.IMMERSION_DEPTH)
				{
					this.Immersion = true;
					return;
				}
				this.Immersion = false;
			}
		}

		// Token: 0x06045E94 RID: 286356 RVA: 0x01165EBD File Offset: 0x011640BD
		private void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (this.DisableHandle != null)
			{
				base.Enable(new int?(this.DisableHandle.Value), this.WATER_COMP_DISABLE_REASON);
			}
			this.DisableHandle = null;
			this.RefreshSwimAreaHeight();
		}

		// Token: 0x06045E95 RID: 286357 RVA: 0x01165EFB File Offset: 0x011640FB
		private void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
		{
			this.InSwimArea = false;
			this.Immersion = false;
			this.DisableHandle = new int?(base.Disable(this.WATER_COMP_DISABLE_REASON));
		}

		// Token: 0x06045E96 RID: 286358 RVA: 0x01165F24 File Offset: 0x01164124
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleWaterComponent motorcycleWaterComponent = (MotorcycleWaterComponent)componentTemplate;
			if (base.CanResetComponentProperty("TraceWaterCapability"))
			{
				if (motorcycleWaterComponent.TraceWaterCapability == null)
				{
					this.TraceWaterCapability = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<MotorcycleTraceWaterCapability>(this.TraceWaterCapability), "TraceWaterCapability"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("ActorComp"))
			{
				if (motorcycleWaterComponent.ActorComp == null)
				{
					this.ActorComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleActorComponent>(this.ActorComp), "ActorComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("MoveComp"))
			{
				if (motorcycleWaterComponent.MoveComp == null)
				{
					this.MoveComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleMoveComponent>(this.MoveComp), "MoveComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("TagComp"))
			{
				if (motorcycleWaterComponent.TagComp == null)
				{
					this.TagComp = null;
				}
				else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseTagComponent>(this.TagComp), "TagComp"))
				{
					return false;
				}
			}
			if (base.CanResetComponentProperty("InSwimAreaInternal"))
			{
				this.InSwimAreaInternal = motorcycleWaterComponent.InSwimAreaInternal;
			}
			if (base.CanResetComponentProperty("SwimAreaHeightAboveActor"))
			{
				this.SwimAreaHeightAboveActor = motorcycleWaterComponent.SwimAreaHeightAboveActor;
			}
			if (base.CanResetComponentProperty("NextSendLeaveTime"))
			{
				this.NextSendLeaveTime = motorcycleWaterComponent.NextSendLeaveTime;
			}
			if (base.CanResetComponentProperty("LastPosition") && motorcycleWaterComponent.LastPosition != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Vector>(this.LastPosition), "LastPosition"))
			{
				return false;
			}
			if (base.CanResetComponentProperty("DisableHandle"))
			{
				this.DisableHandle = motorcycleWaterComponent.DisableHandle;
			}
			if (base.CanResetComponentProperty("ImmersionInternal"))
			{
				this.ImmersionInternal = motorcycleWaterComponent.ImmersionInternal;
			}
			return true;
		}

		// Token: 0x040248DD RID: 149725
		private readonly FVectorDouble WaterAreaDetectExtent = new FVectorDouble(500.0, 500.0, 5000.0);

		// Token: 0x040248DE RID: 149726
		private readonly double IMMERSION_DEPTH = -5.0;

		// Token: 0x040248DF RID: 149727
		private readonly double LEAVE_MOTOR_DEPTH = 85.0;

		// Token: 0x040248E0 RID: 149728
		private readonly double SEND_LEAVE_PERIOD = 1000.0;

		// Token: 0x040248E1 RID: 149729
		private readonly string WATER_COMP_DISABLE_REASON = "OnVehicleBeenEntered";

		// Token: 0x040248E2 RID: 149730
		[Nullable(2)]
		public MotorcycleTraceWaterCapability TraceWaterCapability;

		// Token: 0x040248E3 RID: 149731
		[Nullable(2)]
		protected VehicleActorComponent ActorComp;

		// Token: 0x040248E4 RID: 149732
		[Nullable(2)]
		protected VehicleMoveComponent MoveComp;

		// Token: 0x040248E5 RID: 149733
		[Nullable(2)]
		protected BaseTagComponent TagComp;

		// Token: 0x040248E6 RID: 149734
		private bool InSwimAreaInternal;

		// Token: 0x040248E7 RID: 149735
		private double SwimAreaHeightAboveActor;

		// Token: 0x040248E8 RID: 149736
		private double NextSendLeaveTime;

		// Token: 0x040248E9 RID: 149737
		private readonly Vector LastPosition = Vector.Create();

		// Token: 0x040248EA RID: 149738
		private int? DisableHandle;

		// Token: 0x040248EB RID: 149739
		private bool ImmersionInternal;
	}
}
