using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Level.Vehicle;
using CSharpScript.Game.Module.Activity.ActivityContent.Fishing;

// Token: 0x02002859 RID: 10329
[NullableContext(1)]
[Nullable(0)]
public class FishingBoatPerformComponent : GongduolaPerformComponent
{
	// Token: 0x0601A23C RID: 107068 RVA: 0x008141F5 File Offset: 0x008123F5
	protected override bool OnInit()
	{
		if (!base.OnInit())
		{
			return false;
		}
		this.IsHidePassenger = true;
		return true;
	}

	// Token: 0x0601A23D RID: 107069 RVA: 0x0081420C File Offset: 0x0081240C
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

	// Token: 0x0601A23E RID: 107070 RVA: 0x0081425C File Offset: 0x0081245C
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

	// Token: 0x0601A23F RID: 107071 RVA: 0x008142BB File Offset: 0x008124BB
	protected override bool OnEnd()
	{
		if (this.AttributeComp != null)
		{
			this.AttributeComp.RemoveListener(EAttributeType.SpeedRatio, new Action<EAttributeType, float, float>(this.OnSpeedRatioChanged));
		}
		return base.OnEnd();
	}

	// Token: 0x0601A240 RID: 107072 RVA: 0x008142E8 File Offset: 0x008124E8
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

	// Token: 0x0601A241 RID: 107073 RVA: 0x00814342 File Offset: 0x00812542
	private void OnSpeedRatioChanged(EAttributeType attrId, float newValue, float oldValue)
	{
		if (!this.IsSprint)
		{
			(this.Config as FishingBoatConfig).SetBaseStateMoveConfig(this.ActorComp.Actor.VehicleMovementComponent);
		}
	}

	// Token: 0x0601A242 RID: 107074 RVA: 0x0081436C File Offset: 0x0081256C
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

	// Token: 0x0601A243 RID: 107075 RVA: 0x008143D8 File Offset: 0x008125D8
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

	// Token: 0x0601A244 RID: 107076 RVA: 0x008144F9 File Offset: 0x008126F9
	public void FishingBoatEnterSprint(float sprintMaxSpeedRatio, float sprintExceedLimitDuration, float sprintDuration)
	{
		(this.Config as FishingBoatConfig).RefreshSprintConfig(sprintMaxSpeedRatio, sprintExceedLimitDuration, sprintDuration);
		this.TryEnterSprint(false);
	}

	// Token: 0x0601A245 RID: 107077 RVA: 0x00814516 File Offset: 0x00812716
	public bool CheckCanSprint()
	{
		return !this.IsInSprintStartAction && this.ActorComp.InputDirectProxy.X >= 0.0;
	}

	// Token: 0x0601A246 RID: 107078 RVA: 0x0081453E File Offset: 0x0081273E
	public override bool TryEnterSprint(bool fromEvent = false)
	{
		if (this.CheckCanSprint())
		{
			this.IsEnterSprint = true;
			return true;
		}
		return false;
	}

	// Token: 0x0601A247 RID: 107079 RVA: 0x00814552 File Offset: 0x00812752
	public override void HandlePendingDestroy()
	{
		CreatureController.Instance.DelayRemoveEntityFinished(base.Entity);
	}

	// Token: 0x0601A248 RID: 107080 RVA: 0x00814564 File Offset: 0x00812764
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		FishingBoatPerformComponent fishingBoatPerformComponent = (FishingBoatPerformComponent)componentTemplate;
		if (fishingBoatPerformComponent.AttributeComp == null)
		{
			this.AttributeComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.AttributeComp), "AttributeComp"))
		{
			return false;
		}
		return fishingBoatPerformComponent.HitDirect == null || base.CheckClearObject(EntityComponentSystem.ClearObject(this.HitDirect), "HitDirect");
	}

	// Token: 0x17002A96 RID: 10902
	// (get) Token: 0x0601A249 RID: 107081 RVA: 0x008145D1 File Offset: 0x008127D1
	public override bool NeedInitInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A97 RID: 10903
	// (get) Token: 0x0601A24A RID: 107082 RVA: 0x008145D4 File Offset: 0x008127D4
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A98 RID: 10904
	// (get) Token: 0x0601A24B RID: 107083 RVA: 0x008145D7 File Offset: 0x008127D7
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A99 RID: 10905
	// (get) Token: 0x0601A24C RID: 107084 RVA: 0x008145DA File Offset: 0x008127DA
	public override bool NeedPostActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A9A RID: 10906
	// (get) Token: 0x0601A24D RID: 107085 RVA: 0x008145DD File Offset: 0x008127DD
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A9B RID: 10907
	// (get) Token: 0x0601A24E RID: 107086 RVA: 0x008145E0 File Offset: 0x008127E0
	public override bool NeedEnableInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A9C RID: 10908
	// (get) Token: 0x0601A24F RID: 107087 RVA: 0x008145E3 File Offset: 0x008127E3
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002A9D RID: 10909
	// (get) Token: 0x0601A250 RID: 107088 RVA: 0x008145E6 File Offset: 0x008127E6
	public override bool NeedAfterTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E550 RID: 58704
	[Nullable(2)]
	private BaseAttributeComponent AttributeComp;

	// Token: 0x0400E551 RID: 58705
	private readonly global::Vector HitDirect = global::Vector.Create();
}
