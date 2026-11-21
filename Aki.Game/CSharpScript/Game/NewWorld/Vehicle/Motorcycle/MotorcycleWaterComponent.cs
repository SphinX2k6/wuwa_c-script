using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle
{
	// Token: 0x020061AE RID: 25006
	[NullableContext(1)]
	[Nullable(0)]
	public class MotorcycleWaterComponent : EntityComponent
	{
		// Token: 0x17007138 RID: 28984
		// (get) Token: 0x0603C064 RID: 245860 RVA: 0x0110F971 File Offset: 0x0110DB71
		public override Type[] Dependencies
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

		// Token: 0x17007139 RID: 28985
		// (get) Token: 0x0603C065 RID: 245861 RVA: 0x0110F993 File Offset: 0x0110DB93
		// (set) Token: 0x0603C066 RID: 245862 RVA: 0x0110F99C File Offset: 0x0110DB9C
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

		// Token: 0x1700713A RID: 28986
		// (get) Token: 0x0603C067 RID: 245863 RVA: 0x0110FA07 File Offset: 0x0110DC07
		// (set) Token: 0x0603C068 RID: 245864 RVA: 0x0110FA10 File Offset: 0x0110DC10
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

		// Token: 0x0603C069 RID: 245865 RVA: 0x0110FA88 File Offset: 0x0110DC88
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
			this.InSwimArea = UNavigationSystemV1.D_NavigationGetWaterSurface(owner, actorLocation, MotorcycleWaterComponent.WaterAreaDetectExtent, ref num, this.ActorComp.Owner, null, 150f);
			if (this.InSwimArea)
			{
				double num2 = (double)num;
				this.SwimAreaHeightAboveActor = num2 - this.ActorComp.ActorLocationProxy.Z + 100.0;
				return;
			}
			this.SwimAreaHeightAboveActor = 0.0;
		}

		// Token: 0x0603C06A RID: 245866 RVA: 0x0110FB48 File Offset: 0x0110DD48
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

		// Token: 0x0603C06B RID: 245867 RVA: 0x0110FBEC File Offset: 0x0110DDEC
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

		// Token: 0x0603C06C RID: 245868 RVA: 0x0110FC6C File Offset: 0x0110DE6C
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
			TraceWaterResult traceWaterResult = this.TraceWaterCapability.TraceWater(this.SwimAreaHeightAboveActor, -5.0);
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
			if ((double)traceWaterResult.MinWaterHeight > 85.0)
			{
				if (this.NextSendLeaveTime <= Time.Instance.Now)
				{
					this.NextSendLeaveTime = Time.Instance.Now + 1000.0;
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
				if ((double)traceWaterResult.MinWaterHeight > -5.0)
				{
					this.Immersion = true;
					return;
				}
				this.Immersion = false;
			}
		}

		// Token: 0x0603C06D RID: 245869 RVA: 0x0110FE29 File Offset: 0x0110E029
		private void OnVehicleBeenEntered(VehiclePassengerInfo info, bool byChangeRole)
		{
			if (this.DisableHandle != null)
			{
				base.Enable(new int?(this.DisableHandle.Value), "OnVehicleBeenEntered");
			}
			this.DisableHandle = null;
			this.RefreshSwimAreaHeight();
		}

		// Token: 0x0603C06E RID: 245870 RVA: 0x0110FE66 File Offset: 0x0110E066
		private void OnVehicleBeenLeaved(VehiclePassengerInfo info, bool byChangeRole)
		{
			this.InSwimArea = false;
			this.Immersion = false;
			this.DisableHandle = new int?(base.Disable("OnVehicleBeenEntered"));
		}

		// Token: 0x0603C06F RID: 245871 RVA: 0x0110FE8C File Offset: 0x0110E08C
		public override bool ClearComponent(EntityComponent componentTemplate)
		{
			if (!base.ClearComponent(componentTemplate))
			{
				return false;
			}
			MotorcycleWaterComponent motorcycleWaterComponent = (MotorcycleWaterComponent)componentTemplate;
			if (motorcycleWaterComponent.TraceWaterCapability == null)
			{
				this.TraceWaterCapability = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceWaterCapability), "TraceWaterCapability"))
			{
				return false;
			}
			if (motorcycleWaterComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
			{
				return false;
			}
			if (motorcycleWaterComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
			{
				return false;
			}
			if (motorcycleWaterComponent.TagComp == null)
			{
				this.TagComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TagComp), "TagComp"))
			{
				return false;
			}
			this.InSwimAreaInternal = motorcycleWaterComponent.InSwimAreaInternal;
			this.SwimAreaHeightAboveActor = motorcycleWaterComponent.SwimAreaHeightAboveActor;
			this.NextSendLeaveTime = motorcycleWaterComponent.NextSendLeaveTime;
			if (motorcycleWaterComponent.LastPosition != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastPosition), "LastPosition"))
			{
				return false;
			}
			this.DisableHandle = motorcycleWaterComponent.DisableHandle;
			this.ImmersionInternal = motorcycleWaterComponent.ImmersionInternal;
			return true;
		}

		// Token: 0x1700713B RID: 28987
		// (get) Token: 0x0603C070 RID: 245872 RVA: 0x0110FFB6 File Offset: 0x0110E1B6
		public override bool NeedStartInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700713C RID: 28988
		// (get) Token: 0x0603C071 RID: 245873 RVA: 0x0110FFB9 File Offset: 0x0110E1B9
		public override bool NeedEndInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700713D RID: 28989
		// (get) Token: 0x0603C072 RID: 245874 RVA: 0x0110FFBC File Offset: 0x0110E1BC
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401FB93 RID: 129939
		[StaticVariableRuleIgnore]
		private static readonly FVectorDouble WaterAreaDetectExtent = new FVectorDouble(500.0, 500.0, 5000.0);

		// Token: 0x0401FB94 RID: 129940
		private const double IMMERSION_DEPTH = -5.0;

		// Token: 0x0401FB95 RID: 129941
		private const double LEAVE_MOTOR_DEPTH = 85.0;

		// Token: 0x0401FB96 RID: 129942
		private const double SEND_LEAVE_PERIOD = 1000.0;

		// Token: 0x0401FB97 RID: 129943
		private const string WATER_COMP_DISABLE_REASON = "OnVehicleBeenEntered";

		// Token: 0x0401FB98 RID: 129944
		[Nullable(2)]
		public MotorcycleTraceWaterCapability TraceWaterCapability;

		// Token: 0x0401FB99 RID: 129945
		[Nullable(2)]
		protected VehicleActorComponent ActorComp;

		// Token: 0x0401FB9A RID: 129946
		[Nullable(2)]
		protected VehicleMoveComponent MoveComp;

		// Token: 0x0401FB9B RID: 129947
		[Nullable(2)]
		protected BaseTagComponent TagComp;

		// Token: 0x0401FB9C RID: 129948
		private bool InSwimAreaInternal;

		// Token: 0x0401FB9D RID: 129949
		private double SwimAreaHeightAboveActor;

		// Token: 0x0401FB9E RID: 129950
		private double NextSendLeaveTime;

		// Token: 0x0401FB9F RID: 129951
		private readonly Vector LastPosition = Vector.Create();

		// Token: 0x0401FBA0 RID: 129952
		private int? DisableHandle;

		// Token: 0x0401FBA1 RID: 129953
		private bool ImmersionInternal;
	}
}
