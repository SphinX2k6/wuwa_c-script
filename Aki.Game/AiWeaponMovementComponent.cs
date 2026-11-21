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

// Token: 0x02002819 RID: 10265
[NullableContext(2)]
[Nullable(0)]
public class AiWeaponMovementComponent : EntityComponent
{
	// Token: 0x06019D37 RID: 105783 RVA: 0x007F49F4 File Offset: 0x007F2BF4
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

	// Token: 0x06019D38 RID: 105784 RVA: 0x007F4A75 File Offset: 0x007F2C75
	protected override bool OnStart()
	{
		this.ActorComp = base.Entity.GetComponent<SceneItemActorComponent>();
		return true;
	}

	// Token: 0x06019D39 RID: 105785 RVA: 0x007F4A89 File Offset: 0x007F2C89
	protected override void OnTick(float delta)
	{
		if (this.EnableMovement == null || !this.EnableMovement.Value)
		{
			return;
		}
		this.UpdateMovement((double)delta);
	}

	// Token: 0x06019D3A RID: 105786 RVA: 0x007F4AB0 File Offset: 0x007F2CB0
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

	// Token: 0x06019D3B RID: 105787 RVA: 0x007F4B10 File Offset: 0x007F2D10
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

	// Token: 0x06019D3C RID: 105788 RVA: 0x007F4B80 File Offset: 0x007F2D80
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

	// Token: 0x06019D3D RID: 105789 RVA: 0x007F4BD5 File Offset: 0x007F2DD5
	public void UpdateItemStay(double delta)
	{
		this.EnableMovement = new bool?(false);
	}

	// Token: 0x06019D3E RID: 105790 RVA: 0x007F4BE4 File Offset: 0x007F2DE4
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

	// Token: 0x06019D3F RID: 105791 RVA: 0x007F4CF4 File Offset: 0x007F2EF4
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

	// Token: 0x06019D40 RID: 105792 RVA: 0x007F4D64 File Offset: 0x007F2F64
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

	// Token: 0x06019D41 RID: 105793 RVA: 0x007F4E04 File Offset: 0x007F3004
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

	// Token: 0x06019D42 RID: 105794 RVA: 0x007F4E9C File Offset: 0x007F309C
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

	// Token: 0x06019D43 RID: 105795 RVA: 0x007F4F74 File Offset: 0x007F3174
	private bool CheckDropAtGround()
	{
		FVector componentVelocity = this.ActorComp.StaticMesh.GetComponentVelocity();
		return componentVelocity.Z <= 0f && (double)Math.Abs(componentVelocity.Z) <= 2.0 && (double)componentVelocity.SizeSquared2D() <= 4.0;
	}

	// Token: 0x06019D44 RID: 105796 RVA: 0x007F4FCC File Offset: 0x007F31CC
	private bool CheckDropAtWater()
	{
		return this.ActorComp.StaticMesh.GetComponentVelocity().Z <= 0f && this.TraceHitWater(-5.0);
	}

	// Token: 0x06019D45 RID: 105797 RVA: 0x007F5000 File Offset: 0x007F3200
	[NullableContext(1)]
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		AiWeaponMovementComponent aiWeaponMovementComponent = (AiWeaponMovementComponent)componentTemplate;
		if (aiWeaponMovementComponent.ActorComp == null)
		{
			this.ActorComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorComp), "ActorComp"))
		{
			return false;
		}
		if (aiWeaponMovementComponent.CreatureDataComp == null)
		{
			this.CreatureDataComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataComp), "CreatureDataComp"))
		{
			return false;
		}
		this.EnableMovement = aiWeaponMovementComponent.EnableMovement;
		this.ItemMovementState = aiWeaponMovementComponent.ItemMovementState;
		this.ItemMass = aiWeaponMovementComponent.ItemMass;
		if (aiWeaponMovementComponent.TraceElement == null)
		{
			this.TraceElement = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.TraceElement), "TraceElement"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x170029A4 RID: 10660
	// (get) Token: 0x06019D46 RID: 105798 RVA: 0x007F50C5 File Offset: 0x007F32C5
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x170029A5 RID: 10661
	// (get) Token: 0x06019D47 RID: 105799 RVA: 0x007F50C8 File Offset: 0x007F32C8
	public override bool NeedTickInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x0400E279 RID: 57977
	private static readonly FName COLLISION_PROFILE_NAME = new FName("DropItem");

	// Token: 0x0400E27A RID: 57978
	private const double GROUND_MAX_XY_VEL_SQUARED = 4.0;

	// Token: 0x0400E27B RID: 57979
	private const double GROUND_MAX_Z_VEL = 2.0;

	// Token: 0x0400E27C RID: 57980
	private const double MAX_DROP_HEIGHT = 10000.0;

	// Token: 0x0400E27D RID: 57981
	private const double ON_WATER_MAX_DIST = 5.0;

	// Token: 0x0400E27E RID: 57982
	private SceneItemActorComponent ActorComp;

	// Token: 0x0400E27F RID: 57983
	private CreatureDataComponent CreatureDataComp;

	// Token: 0x0400E280 RID: 57984
	public bool? EnableMovement;

	// Token: 0x0400E281 RID: 57985
	private EItemMovementState ItemMovementState = EItemMovementState.Fall;

	// Token: 0x0400E282 RID: 57986
	private double ItemMass;

	// Token: 0x0400E283 RID: 57987
	private UTraceLineElement TraceElement;
}
