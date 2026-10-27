using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.TDConfigMgr.Component;
using AkiClient.Game.Aki.Character.BaseCharacter;
using CSharpScript.Game;
using CSharpScript.Game.Module.AiInteraction.AiWeapon;
using CSharpScript.Game.NewWorld.SceneItem;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020032A8 RID: 12968
[NullableContext(2)]
[Nullable(0)]
public class AiWeaponMovementComponent : EntityComponent
{
	// Token: 0x0601C100 RID: 114944 RVA: 0x007CD7CC File Offset: 0x007CB9CC
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CreatureDataComp = base.Entity.GetComponent<CreatureDataComponent>();
		this.ItemMass = 0.01;
		WeaponComponent component = TdUtils.GetComponent<WeaponComponent>(this.CreatureDataComp.GetPbEntityInitData().ComponentsData, EConfigComponent.WeaponComponent);
		if (component != null)
		{
			int weaponId = component.WeaponId;
			SAiWeaponSocket staticWeaponConfig = AiWeaponModel.Instance.GetStaticWeaponConfig(component.WeaponId);
			this.ItemMass = (double)staticWeaponConfig.Mass;
		}
		this.EnableMovement = new bool?(true);
		this.ItemMovementState = EItemMovementState.Born;
		return true;
	}

	// Token: 0x0601C101 RID: 114945 RVA: 0x007CD84D File Offset: 0x007CBA4D
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
		return true;
	}

	// Token: 0x0601C102 RID: 114946 RVA: 0x007CD861 File Offset: 0x007CBA61
	protected override void OnTick(float delta)
	{
		if (this.EnableMovement == null || !this.EnableMovement.Value)
		{
			return;
		}
		this.UpdateMovement((double)delta);
	}

	// Token: 0x0601C103 RID: 114947 RVA: 0x007CD888 File Offset: 0x007CBA88
	public void UpdateMovement(double delta)
	{
		this.ActorComp.SetActorLocation(this.ActorComp.StaticMesh.D_K2_GetComponentLocation(), "unknown", true);
		switch (this.ItemMovementState)
		{
		case EItemMovementState.Born:
			this.UpdateItemBorn(delta);
			return;
		case EItemMovementState.Fall:
			this.UpdateItemFall(delta);
			return;
		case EItemMovementState.Stay:
			this.UpdateItemStay(delta);
			return;
		default:
			return;
		}
	}

	// Token: 0x0601C104 RID: 114948 RVA: 0x007CD8E8 File Offset: 0x007CBAE8
	public void UpdateItemBorn(double delta)
	{
		global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		if (this.CreatureDataComp.GetInitLinearVelocity() != null)
		{
			commonTempVector.FromConfigVector(this.CreatureDataComp.GetInitLinearVelocity());
		}
		else
		{
			commonTempVector.FromConfigVector(global::Vector.ZeroVector);
		}
		if (commonTempVector.IsNearlyZero(9.999999747378752E-05))
		{
			this.ItemMovementState = EItemMovementState.Stay;
			return;
		}
		this.InitPhysics();
		this.ItemMovementState = EItemMovementState.Fall;
	}

	// Token: 0x0601C105 RID: 114949 RVA: 0x007CD958 File Offset: 0x007CBB58
	public void UpdateItemFall(double delta)
	{
		if (!this.CheckDropOutOfRange() && !this.CheckDropAtGround() && !this.CheckDropAtWater())
		{
			return;
		}
		this.ItemMovementState = EItemMovementState.Stay;
		this.DisablePhysics();
		if (!GameModeModel.Instance.IsMulti)
		{
			SceneItemMovementSyncComponent component = base.Entity.GetComponent<SceneItemMovementSyncComponent>();
			if (component == null)
			{
				return;
			}
			component.CollectSampleAndSend(true);
		}
	}

	// Token: 0x0601C106 RID: 114950 RVA: 0x007CD9AD File Offset: 0x007CBBAD
	public void UpdateItemStay(double delta)
	{
		this.EnableMovement = new bool?(false);
	}

	// Token: 0x0601C107 RID: 114951 RVA: 0x007CD9BC File Offset: 0x007CBBBC
	private void InitPhysics()
	{
		UStaticMeshComponent staticMesh = this.ActorComp.StaticMesh;
		staticMesh.SetCollisionProfileName(AiWeaponMovementComponent.COLLISION_PROFILE_NAME, true);
		staticMesh.SetCollisionEnabled(ECollisionEnabled.PhysicsOnly);
		staticMesh.SetSimulatePhysics(true);
		if (this.ItemMass >= 0.0)
		{
			staticMesh.SetMassOverrideInKg(FNameUtil.NONE, (float)this.ItemMass, true);
		}
		staticMesh.SetEnableGravity(true);
		staticMesh.SetConstraintMode(EDOFMode.None);
		staticMesh.SetUseCCD(true, default(FName));
		global::Vector commonTempVector = MathUtils.Instance.CommonTempVector;
		if (this.CreatureDataComp.GetInitLinearVelocity() != null)
		{
			commonTempVector.FromConfigVector(this.CreatureDataComp.GetInitLinearVelocity());
		}
		else
		{
			commonTempVector.FromConfigVector(global::Vector.ZeroVector);
		}
		if (commonTempVector.SizeSquared2D() <= 4.0)
		{
			global::Vector vector = global::Vector.Create();
			commonTempVector.GetSignVector(vector);
			vector.MultiplyEqual(Math.Sqrt(5.0));
			vector.Z = 0.0;
			commonTempVector.AdditionEqual(vector);
		}
		staticMesh.SetPhysicsLinearVelocity(commonTempVector.ToUeVectorOld(), false, default(FName));
	}

	// Token: 0x0601C108 RID: 114952 RVA: 0x007CDACC File Offset: 0x007CBCCC
	private void DisablePhysics()
	{
		UStaticMeshComponent staticMesh = this.ActorComp.StaticMesh;
		staticMesh.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		staticMesh.SetSimulatePhysics(false);
		staticMesh.SetEnableGravity(false);
		staticMesh.SetPhysicsLinearVelocity(global::Vector.ZeroVector, false, default(FName));
		staticMesh.SetPhysicsAngularVelocity(global::Vector.ZeroVector, false, default(FName));
		staticMesh.SetConstraintMode(EDOFMode.Default);
		staticMesh.SetUseCCD(false, default(FName));
	}

	// Token: 0x0601C109 RID: 114953 RVA: 0x007CDB3C File Offset: 0x007CBD3C
	private void InitWaterTrace()
	{
		if (this.TraceElement == null)
		{
			this.TraceElement = new UTraceLineElement();
		}
		this.TraceElement.WorldContextObject = GlobalData.World;
		this.TraceElement.bIsSingle = true;
		this.TraceElement.bIgnoreSelf = true;
		this.TraceElement.SetTraceTypeQuery(KuroTraceTypeQuery.Water);
		this.TraceElement.SetDrawDebugTrace(EDrawDebugTrace.ForDuration);
		this.TraceElement.DrawTime = 5f;
		TraceElementCommon.Instance.SetTraceColor(this.TraceElement, ColorUtils.LinearGreen);
		TraceElementCommon.Instance.SetTraceHitColor(this.TraceElement, ColorUtils.LinearRed);
	}

	// Token: 0x0601C10A RID: 114954 RVA: 0x007CDBDC File Offset: 0x007CBDDC
	private bool TraceHitWater(double zOffset)
	{
		this.InitWaterTrace();
		global::Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
		this.TraceElement.SetStartLocation(actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z);
		this.TraceElement.SetEndLocation(actorLocationProxy.X, actorLocationProxy.Y, actorLocationProxy.Z + zOffset);
		bool result;
		if (TraceElementCommon.Instance.LineTrace(this.TraceElement, "AiWeaponMovementComponent.TraceHitWater"))
		{
			UKuroHitResult hitResult = this.TraceElement.HitResult;
			result = (hitResult != null && hitResult.bBlockingHit);
		}
		else
		{
			result = false;
		}
		this.TraceElement.ClearCacheData(false);
		return result;
	}

	// Token: 0x0601C10B RID: 114955 RVA: 0x007CDC74 File Offset: 0x007CBE74
	private bool CheckDropOutOfRange()
	{
		if (this.ActorComp.StaticMesh.GetComponentVelocity().Z > 0f)
		{
			return false;
		}
		Aki.Protocol.Vector initLocation = this.CreatureDataComp.GetInitLocation();
		if (Math.Abs((initLocation != null) ? (this.ActorComp.ActorLocationProxy.Z - (double)initLocation.Z) : 0.0) > 10000.0)
		{
			return true;
		}
		TsBaseCharacter baseCharacter = Global.BaseCharacter;
		FVectorDouble? fvectorDouble = (baseCharacter != null) ? new FVectorDouble?(baseCharacter.CharacterActorComponent.ActorLocation) : null;
		return Math.Abs((fvectorDouble != null) ? (this.ActorComp.ActorLocationProxy.Z - fvectorDouble.Value.Z) : 0.0) > 10000.0;
	}

	// Token: 0x0601C10C RID: 114956 RVA: 0x007CDD4C File Offset: 0x007CBF4C
	private bool CheckDropAtGround()
	{
		FVector componentVelocity = this.ActorComp.StaticMesh.GetComponentVelocity();
		return componentVelocity.Z <= 0f && (double)Math.Abs(componentVelocity.Z) <= 2.0 && (double)componentVelocity.SizeSquared2D() <= 4.0;
	}

	// Token: 0x0601C10D RID: 114957 RVA: 0x007CDDA4 File Offset: 0x007CBFA4
	private bool CheckDropAtWater()
	{
		return this.ActorComp.StaticMesh.GetComponentVelocity().Z <= 0f && this.TraceHitWater(-5.0);
	}

	// Token: 0x0601C10E RID: 114958 RVA: 0x007CDDD8 File Offset: 0x007CBFD8
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AiWeaponMovementComponent aiWeaponMovementComponent = (AiWeaponMovementComponent)componentTemplate;
		if (base.CanResetComponentProperty("ActorComp"))
		{
			if (aiWeaponMovementComponent.ActorComp == null)
			{
				this.ActorComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<SceneItemActorComponent>(this.ActorComp), "ActorComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CreatureDataComp"))
		{
			if (aiWeaponMovementComponent.CreatureDataComp == null)
			{
				this.CreatureDataComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataComp), "CreatureDataComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("EnableMovement"))
		{
			this.EnableMovement = aiWeaponMovementComponent.EnableMovement;
		}
		if (base.CanResetComponentProperty("ItemMovementState"))
		{
			this.ItemMovementState = aiWeaponMovementComponent.ItemMovementState;
		}
		if (base.CanResetComponentProperty("ItemMass"))
		{
			this.ItemMass = aiWeaponMovementComponent.ItemMass;
		}
		if (base.CanResetComponentProperty("TraceElement"))
		{
			if (aiWeaponMovementComponent.TraceElement == null)
			{
				this.TraceElement = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<UTraceLineElement>(this.TraceElement), "TraceElement"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400DDD2 RID: 56786
	private static readonly FName COLLISION_PROFILE_NAME = new FName("DropItem");

	// Token: 0x0400DDD3 RID: 56787
	private const double GROUND_MAX_XY_VEL_SQUARED = 4.0;

	// Token: 0x0400DDD4 RID: 56788
	private const double GROUND_MAX_Z_VEL = 2.0;

	// Token: 0x0400DDD5 RID: 56789
	private const double MAX_DROP_HEIGHT = 10000.0;

	// Token: 0x0400DDD6 RID: 56790
	private const double ON_WATER_MAX_DIST = 5.0;

	// Token: 0x0400DDD7 RID: 56791
	private SceneItemActorComponent ActorComp;

	// Token: 0x0400DDD8 RID: 56792
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400DDD9 RID: 56793
	public bool? EnableMovement;

	// Token: 0x0400DDDA RID: 56794
	private EItemMovementState ItemMovementState = EItemMovementState.Fall;

	// Token: 0x0400DDDB RID: 56795
	private double ItemMass;

	// Token: 0x0400DDDC RID: 56796
	private UTraceLineElement TraceElement;
}
