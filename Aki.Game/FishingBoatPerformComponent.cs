using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x020032E7 RID: 13031
[NullableContext(1)]
[Nullable(0)]
public class FishingBoatPerformComponent : GongduolaPerformComponent
{
	// Token: 0x0601C591 RID: 116113 RVA: 0x007EDAAE File Offset: 0x007EBCAE
	protected override bool OnInit()
	{
		if (!base.OnInit())
		{
			return false;
		}
		this.IsHidePassenger = true;
		return true;
	}

	// Token: 0x0601C592 RID: 116114 RVA: 0x007EDAC4 File Offset: 0x007EBCC4
	protected override bool OnStart()
	{
		if (!base.OnStart())
		{
			return false;
		}
		this.AttributeComp = base.Entity.GetComponent<BaseAttributeComponent>();
		if (this.AttributeComp != null)
		{
			this.AttributeComp.AddListener(EAttributeType.SpeedRatio, new Action<EAttributeType, float, float>(this.OnSpeedRatioChanged), "FishingBoatPerformComponent");
		}
		return true;
	}

	// Token: 0x0601C593 RID: 116115 RVA: 0x007EDB14 File Offset: 0x007EBD14
	protected override void OnActivate()
	{
		base.OnActivate();
		VehicleActorComponent actorComp = this.ActorComp;
		long? num;
		if (actorComp == null)
		{
			num = null;
		}
		else
		{
			CreatureDataComponent creatureData = actorComp.CreatureData;
			num = ((creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
		}
		long? num2 = num;
		long valueOrDefault = num2.GetValueOrDefault();
		FishingModel.Instance.GetShipData().RefreshShipEntity(valueOrDefault);
	}

	// Token: 0x0601C594 RID: 116116 RVA: 0x007EDB73 File Offset: 0x007EBD73
	protected override bool OnEnd()
	{
		if (this.AttributeComp != null)
		{
			this.AttributeComp.RemoveListener(EAttributeType.SpeedRatio, new Action<EAttributeType, float, float>(this.OnSpeedRatioChanged));
		}
		return base.OnEnd();
	}

	// Token: 0x0601C595 RID: 116117 RVA: 0x007EDBA0 File Offset: 0x007EBDA0
	protected override bool InitVehicleConfig()
	{
		BP_VehicleConfig_C bp_VehicleConfig_C = this.LoadVehicleConfigAsset();
		if (bp_VehicleConfig_C == null || !bp_VehicleConfig_C.IsValid())
		{
			return false;
		}
		this.Config = new FishingBoatConfig(base.Entity, bp_VehicleConfig_C as BP_GongduolaConfig_C);
		this.ConfigInternal = this.Config.DeepCopy();
		return this.Config.Init();
	}

	// Token: 0x0601C596 RID: 116118 RVA: 0x007EDBFA File Offset: 0x007EBDFA
	private void OnSpeedRatioChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		if (!this.IsSprint)
		{
			(this.Config as FishingBoatConfig).SetBaseStateMoveConfig(this.ActorComp.Actor.VehicleMovementComponent);
		}
	}

	// Token: 0x0601C597 RID: 116119 RVA: 0x007EDC24 File Offset: 0x007EBE24
	public override bool CheckCanPerformHit()
	{
		foreach (VehiclePassengerInfo vehiclePassengerInfo in this.PassengerInfoMap.Values)
		{
			if (vehiclePassengerInfo.IsDriver && vehiclePassengerInfo.IsRolePassenger(false))
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x0601C598 RID: 116120 RVA: 0x007EDC90 File Offset: 0x007EBE90
	public override void OnBulletHit(global::HitInformation hitData, BulletInfo bulletInfo)
	{
		if (this.ActorComp == null)
		{
			return;
		}
		BaseActorComponent attackerActorComp = bulletInfo.AttackerActorComp;
		if (attackerActorComp != null && attackerActorComp.Valid)
		{
			this.ActorComp.ActorLocationProxy.Subtraction(attackerActorComp.ActorLocationProxy, this.HitDirect);
			if (!this.HitDirect.Normalize(9.99999993922529E-09))
			{
				this.ActorComp.ActorForwardProxy.Multiply(-1.0, this.HitDirect);
			}
		}
		else
		{
			this.ActorComp.ActorForwardProxy.Multiply(-1.0, this.HitDirect);
		}
		this.CollisionStrength = 1f;
		this.HitDirect.GetSafeNormal2D(this.HitDirect, 9.99999993922529E-09);
		float num = (float)(Math.Acos(this.HitDirect.CosineAngle2D(this.ActorComp.ActorForwardProxy, 9.999999747378752E-05)) * 57.295780181884766);
		this.CollisionDirection = num * (float)Math.Sign(this.HitDirect.DotProduct(this.ActorComp.ActorRightProxy));
		base.BeginCollisionPerform(1000f);
	}

	// Token: 0x0601C599 RID: 116121 RVA: 0x007EDDB1 File Offset: 0x007EBFB1
	public void FishingBoatEnterSprint(float sprintMaxSpeedRatio, float sprintExceedLimitDuration, float sprintDuration)
	{
		(this.Config as FishingBoatConfig).RefreshSprintConfig(sprintMaxSpeedRatio, sprintExceedLimitDuration, sprintDuration);
		this.TryEnterSprint(false);
	}

	// Token: 0x0601C59A RID: 116122 RVA: 0x007EDDCE File Offset: 0x007EBFCE
	public bool CheckCanSprint()
	{
		return !this.IsInSprintStartAction && this.ActorComp.InputDirectProxy.X >= 0.0;
	}

	// Token: 0x0601C59B RID: 116123 RVA: 0x007EDDF6 File Offset: 0x007EBFF6
	public override bool TryEnterSprint(bool fromEvent = false)
	{
		if (this.CheckCanSprint())
		{
			this.IsEnterSprint = true;
			return true;
		}
		return false;
	}

	// Token: 0x0601C59C RID: 116124 RVA: 0x007EDE0A File Offset: 0x007EC00A
	public override void HandlePendingDestroy()
	{
		CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
	}

	// Token: 0x0601C59D RID: 116125 RVA: 0x007EDE1C File Offset: 0x007EC01C
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		FishingBoatPerformComponent fishingBoatPerformComponent = (FishingBoatPerformComponent)componentTemplate;
		if (base.CanResetComponentProperty("AttributeComp"))
		{
			if (fishingBoatPerformComponent.AttributeComp == null)
			{
				this.AttributeComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseAttributeComponent>(this.AttributeComp), "AttributeComp"))
			{
				return false;
			}
		}
		return !base.CanResetComponentProperty("HitDirect") || fishingBoatPerformComponent.HitDirect == null || base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.HitDirect), "HitDirect");
	}

	// Token: 0x0400E0A5 RID: 57509
	[Nullable(2)]
	private BaseAttributeComponent AttributeComp;

	// Token: 0x0400E0A6 RID: 57510
	private readonly global::Vector HitDirect = global::Vector.Create();
}
