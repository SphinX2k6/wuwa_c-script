using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x020027DE RID: 10206
[NullableContext(1)]
[Nullable(0)]
public class BaseActorComponent : EntityComponent
{
	// Token: 0x170028F8 RID: 10488
	// (get) Token: 0x06019A4E RID: 105038 RVA: 0x007E487C File Offset: 0x007E2A7C
	public float ScaledRadius
	{
		get
		{
			return (float)((double)this.RadiusInternal * this.ActorScaleProxy.X);
		}
	}

	// Token: 0x170028F9 RID: 10489
	// (get) Token: 0x06019A4F RID: 105039 RVA: 0x007E4892 File Offset: 0x007E2A92
	public float Radius
	{
		get
		{
			return this.RadiusInternal;
		}
	}

	// Token: 0x170028FA RID: 10490
	// (get) Token: 0x06019A50 RID: 105040 RVA: 0x007E489A File Offset: 0x007E2A9A
	public float ScaledHalfHeight
	{
		get
		{
			return (float)((double)this.HalfHeightInternal * this.ActorScaleProxy.Z);
		}
	}

	// Token: 0x170028FB RID: 10491
	// (get) Token: 0x06019A51 RID: 105041 RVA: 0x007E48B0 File Offset: 0x007E2AB0
	public float HalfHeight
	{
		get
		{
			return this.HalfHeightInternal;
		}
	}

	// Token: 0x170028FC RID: 10492
	// (get) Token: 0x06019A52 RID: 105042 RVA: 0x007E48B8 File Offset: 0x007E2AB8
	public float DefaultRadius
	{
		get
		{
			return this.DefaultRadiusInternal;
		}
	}

	// Token: 0x170028FD RID: 10493
	// (get) Token: 0x06019A53 RID: 105043 RVA: 0x007E48C0 File Offset: 0x007E2AC0
	public float DefaultHalfHeight
	{
		get
		{
			return this.DefaultHalfHeightInternal;
		}
	}

	// Token: 0x06019A54 RID: 105044 RVA: 0x007E48C8 File Offset: 0x007E2AC8
	protected virtual void InitSizeInternal()
	{
	}

	// Token: 0x170028FE RID: 10494
	// (get) Token: 0x06019A55 RID: 105045 RVA: 0x007E48CA File Offset: 0x007E2ACA
	public bool IsAutonomousProxy
	{
		get
		{
			return this.LogicAutonomous;
		}
	}

	// Token: 0x170028FF RID: 10495
	// (get) Token: 0x06019A56 RID: 105046 RVA: 0x007E48D2 File Offset: 0x007E2AD2
	public bool IsMoveAutonomousProxy
	{
		get
		{
			return this.MoveAutonomous;
		}
	}

	// Token: 0x06019A57 RID: 105047 RVA: 0x007E48DA File Offset: 0x007E2ADA
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		this.DisableActorHandle = new DisableEntityHandle("SetActorHiddenInGame");
		this.DisableCollisionHandle = new DisableEntityHandle("SetActorEnableCollision");
		return true;
	}

	// Token: 0x06019A58 RID: 105048 RVA: 0x007E4900 File Offset: 0x007E2B00
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CachedActorForward.Set(1.0, 0.0, 0.0);
		this.CachedActorRight.Set(0.0, 1.0, 0.0);
		this.CachedActorUp.Set(0.0, 0.0, 1.0);
		return true;
	}

	// Token: 0x06019A59 RID: 105049 RVA: 0x007E4980 File Offset: 0x007E2B80
	protected override bool OnStart()
	{
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		this.VehicleMoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
		this.Handle = CreatureModel.Instance.GetEntityById(base.Entity.Id);
		return true;
	}

	// Token: 0x06019A5A RID: 105050 RVA: 0x007E49C0 File Offset: 0x007E2BC0
	protected override void OnActivate()
	{
		this.ActorInternal.Kuro_SetRole(this.MoveAutonomous ? EKuroNetRole.KURO_ROLE_AutonomousProxy : EKuroNetRole.KURO_ROLE_SimulatedProxy);
		this.LastActorLocation.DeepCopy(this.ActorLocationProxy);
		this.LastActorRotation.DeepCopy(this.ActorRotationProxy);
		this.ActorInternal.SetActorHiddenInGame(!this.DisableActorHandle.Empty);
		this.ActorInternal.SetActorEnableCollision(this.DisableCollisionHandle.Empty);
	}

	// Token: 0x06019A5B RID: 105051 RVA: 0x007E4A35 File Offset: 0x007E2C35
	protected override bool OnEnd()
	{
		this.ClearDebugLocationCube();
		return true;
	}

	// Token: 0x06019A5C RID: 105052 RVA: 0x007E4A3E File Offset: 0x007E2C3E
	public virtual void SetAutonomous(bool logicAutonomous, bool? moveAutonomous = null)
	{
		this.LogicAutonomous = logicAutonomous;
		this.SetMoveAutonomous(moveAutonomous.GetValueOrDefault(logicAutonomous), "切换逻辑主控");
	}

	// Token: 0x06019A5D RID: 105053 RVA: 0x007E4A5A File Offset: 0x007E2C5A
	protected virtual void SetMoveAutonomous(bool moveAutonomous, string reason = "")
	{
		this.MoveAutonomous = moveAutonomous;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal == null)
		{
			return;
		}
		actorInternal.Kuro_SetRole(this.MoveAutonomous ? EKuroNetRole.KURO_ROLE_AutonomousProxy : EKuroNetRole.KURO_ROLE_SimulatedProxy);
	}

	// Token: 0x06019A5E RID: 105054 RVA: 0x007E4A7F File Offset: 0x007E2C7F
	public virtual void SetMoveControlled(bool controlled, double maxControlTime = 2.0, string reason = "")
	{
		this.SetMoveAutonomous(controlled, reason);
	}

	// Token: 0x06019A5F RID: 105055 RVA: 0x007E4A89 File Offset: 0x007E2C89
	public virtual void ResetMoveControlled(string reason = "")
	{
		this.SetMoveAutonomous(this.IsAutonomousProxy, reason);
	}

	// Token: 0x06019A60 RID: 105056 RVA: 0x007E4A98 File Offset: 0x007E2C98
	protected bool InitCreatureData()
	{
		this.CreatureDataInternal = base.Entity.GetComponent<CreatureDataComponent>();
		CreatureDataComponent creatureDataInternal = this.CreatureDataInternal;
		if (creatureDataInternal == null || !creatureDataInternal.Valid)
		{
			Log.Instance.Error(ELogModule.Entity, ELogAuthor.LFJW, "creature数据加载失败。", default(ReadOnlySpan<ValueTuple<string, object>>));
			return false;
		}
		return true;
	}

	// Token: 0x17002900 RID: 10496
	// (get) Token: 0x06019A61 RID: 105057 RVA: 0x007E4AEB File Offset: 0x007E2CEB
	public CreatureDataComponent CreatureData
	{
		get
		{
			return this.CreatureDataInternal;
		}
	}

	// Token: 0x17002901 RID: 10497
	// (get) Token: 0x06019A62 RID: 105058 RVA: 0x007E4AF3 File Offset: 0x007E2CF3
	public FQuat ActorQuat
	{
		get
		{
			return this.ActorQuatProxy.ToUeQuat();
		}
	}

	// Token: 0x17002902 RID: 10498
	// (get) Token: 0x06019A63 RID: 105059 RVA: 0x007E4B00 File Offset: 0x007E2D00
	public Quat ActorQuatProxy
	{
		get
		{
			if (this.CachedRotationTime < Time.Instance.Frame)
			{
				AActor actorInternal = this.ActorInternal;
				if (actorInternal != null && actorInternal.IsValid())
				{
					this.CachedRotationTime = Time.Instance.Frame;
					global::Rotator cachedActorRotation = this.CachedActorRotation;
					FRotator frotator = this.ActorInternal.K2_GetActorRotation();
					cachedActorRotation.DeepCopy(frotator);
					this.CachedActorRotation.Quaternion(this.CachedActorQuat);
				}
			}
			return this.CachedActorQuat;
		}
	}

	// Token: 0x17002903 RID: 10499
	// (get) Token: 0x06019A64 RID: 105060 RVA: 0x007E4B74 File Offset: 0x007E2D74
	public global::Rotator ActorRotationProxy
	{
		get
		{
			if (this.CachedRotationTime < Time.Instance.Frame)
			{
				AActor actorInternal = this.ActorInternal;
				if (actorInternal != null && actorInternal.IsValid())
				{
					this.CachedRotationTime = Time.Instance.Frame;
					global::Rotator cachedActorRotation = this.CachedActorRotation;
					FRotator frotator = this.ActorInternal.K2_GetActorRotation();
					cachedActorRotation.DeepCopy(frotator);
					this.CachedActorRotation.Quaternion(this.CachedActorQuat);
				}
			}
			return this.CachedActorRotation;
		}
	}

	// Token: 0x17002904 RID: 10500
	// (get) Token: 0x06019A65 RID: 105061 RVA: 0x007E4BE8 File Offset: 0x007E2DE8
	public FRotator ActorRotation
	{
		get
		{
			return this.ActorRotationProxy.ToUeRotator();
		}
	}

	// Token: 0x17002905 RID: 10501
	// (get) Token: 0x06019A66 RID: 105062 RVA: 0x007E4BF8 File Offset: 0x007E2DF8
	public global::Vector ActorScaleProxy
	{
		get
		{
			if (this.CachedScaleTime <= 0)
			{
				AActor actorInternal = this.ActorInternal;
				if (actorInternal != null && actorInternal.IsValid())
				{
					this.CachedScaleTime = 1;
					global::Vector cachedActorScale = this.CachedActorScale;
					FVectorDouble fvectorDouble = this.ActorInternal.D_GetActorScale3D();
					cachedActorScale.FromUeVector(fvectorDouble);
				}
			}
			return this.CachedActorScale;
		}
	}

	// Token: 0x17002906 RID: 10502
	// (get) Token: 0x06019A67 RID: 105063 RVA: 0x007E4C48 File Offset: 0x007E2E48
	public FVectorDouble ActorScale
	{
		get
		{
			return this.ActorScaleProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002907 RID: 10503
	// (get) Token: 0x06019A68 RID: 105064 RVA: 0x007E4C58 File Offset: 0x007E2E58
	public FTransformDouble? ActorTransformOrNull
	{
		get
		{
			if (this.CachedTransformTime < Time.Instance.Frame)
			{
				AActor actorInternal = this.ActorInternal;
				if (actorInternal != null && actorInternal.IsValid())
				{
					this.CachedTransformTime = Time.Instance.Frame;
					this.CachedActorTransform = new FTransformDouble?(this.ActorInternal.D_GetTransform());
				}
			}
			return this.CachedActorTransform;
		}
	}

	// Token: 0x17002908 RID: 10504
	// (get) Token: 0x06019A69 RID: 105065 RVA: 0x007E4CB8 File Offset: 0x007E2EB8
	public FTransformDouble ActorTransform
	{
		get
		{
			FTransformDouble? actorTransformOrNull = this.ActorTransformOrNull;
			if (actorTransformOrNull == null)
			{
				return new FTransformDouble();
			}
			return actorTransformOrNull.GetValueOrDefault();
		}
	}

	// Token: 0x17002909 RID: 10505
	// (get) Token: 0x06019A6A RID: 105066 RVA: 0x007E4CE2 File Offset: 0x007E2EE2
	public FVectorDouble ActorLocation
	{
		get
		{
			return this.ActorLocationProxy.ToUeVector(false);
		}
	}

	// Token: 0x1700290A RID: 10506
	// (get) Token: 0x06019A6B RID: 105067 RVA: 0x007E4CF0 File Offset: 0x007E2EF0
	public virtual global::Vector ActorLocationProxy
	{
		get
		{
			if (this.IsChangingLocation)
			{
				return this.CachedDesiredActorLocation;
			}
			if (this.CachedLocationTime < Time.Instance.Frame)
			{
				AActor actorInternal = this.ActorInternal;
				if (actorInternal != null && actorInternal.IsValid())
				{
					this.CachedLocationTime = Time.Instance.Frame;
					global::Vector cachedActorLocation = this.CachedActorLocation;
					FVectorDouble fvectorDouble = this.ActorInternal.D_K2_GetActorLocation();
					cachedActorLocation.FromUeVector(fvectorDouble);
				}
			}
			return this.CachedActorLocation;
		}
	}

	// Token: 0x06019A6C RID: 105068 RVA: 0x007E4D61 File Offset: 0x007E2F61
	[Conditional("NO_SUPPORT")]
	protected void SetCachedActorLocationWritable(bool canWrite)
	{
		bool isPlayInEditor = GlobalData.IsPlayInEditor;
	}

	// Token: 0x1700290B RID: 10507
	// (get) Token: 0x06019A6D RID: 105069 RVA: 0x007E4D69 File Offset: 0x007E2F69
	public global::Vector ActorLocationProxyNoUpdate
	{
		get
		{
			if (this.CachedLocationTime <= 0)
			{
				return this.ActorLocationProxy;
			}
			return this.CachedActorLocation;
		}
	}

	// Token: 0x1700290C RID: 10508
	// (get) Token: 0x06019A6E RID: 105070 RVA: 0x007E4D81 File Offset: 0x007E2F81
	public global::Vector ActorForwardProxy
	{
		get
		{
			if (this.CachedForwardTime < Time.Instance.Frame)
			{
				this.CachedForwardTime = Time.Instance.Frame;
				this.ActorQuatProxy.RotateVector(global::Vector.ForwardVectorProxy, this.CachedActorForward);
			}
			return this.CachedActorForward;
		}
	}

	// Token: 0x1700290D RID: 10509
	// (get) Token: 0x06019A6F RID: 105071 RVA: 0x007E4DC1 File Offset: 0x007E2FC1
	public FVectorDouble ActorRight
	{
		get
		{
			return this.ActorRightProxy.ToUeVector(false);
		}
	}

	// Token: 0x1700290E RID: 10510
	// (get) Token: 0x06019A70 RID: 105072 RVA: 0x007E4DCF File Offset: 0x007E2FCF
	public global::Vector ActorRightProxy
	{
		get
		{
			if (this.CachedRightTime < Time.Instance.Frame)
			{
				this.CachedRightTime = Time.Instance.Frame;
				this.ActorQuatProxy.RotateVector(global::Vector.RightVectorProxy, this.CachedActorRight);
			}
			return this.CachedActorRight;
		}
	}

	// Token: 0x1700290F RID: 10511
	// (get) Token: 0x06019A71 RID: 105073 RVA: 0x007E4E0F File Offset: 0x007E300F
	public FVectorDouble ActorForward
	{
		get
		{
			return this.ActorForwardProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002910 RID: 10512
	// (get) Token: 0x06019A72 RID: 105074 RVA: 0x007E4E1D File Offset: 0x007E301D
	public global::Vector ActorUpProxy
	{
		get
		{
			if (this.CachedUpTime < Time.Instance.Frame)
			{
				this.CachedUpTime = Time.Instance.Frame;
				this.ActorQuatProxy.RotateVector(global::Vector.UpVectorProxy, this.CachedActorUp);
			}
			return this.CachedActorUp;
		}
	}

	// Token: 0x17002911 RID: 10513
	// (get) Token: 0x06019A73 RID: 105075 RVA: 0x007E4E5D File Offset: 0x007E305D
	public FVectorDouble ActorUp
	{
		get
		{
			return this.ActorUpProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002912 RID: 10514
	// (get) Token: 0x06019A74 RID: 105076 RVA: 0x007E4E6C File Offset: 0x007E306C
	public virtual global::Vector ActorGravityDirectProxy
	{
		get
		{
			if (this.CachedGravityDirectTime < Time.Instance.Frame)
			{
				this.CachedGravityDirectTime = Time.Instance.Frame;
				if (this.VehicleMoveComp != null)
				{
					this.CachedActorGravityDirect.DeepCopy(this.VehicleMoveComp.GravityDirect);
				}
				else if (this.MoveComp != null)
				{
					this.CachedActorGravityDirect.DeepCopy(this.MoveComp.GravityDirect);
				}
				else
				{
					CreatureDataComponent creatureData = this.CreatureData;
					Aki.Protocol.Vector vector = (creatureData != null) ? creatureData.GetInitGravityDirection() : null;
					if (vector != null)
					{
						this.CachedActorGravityDirect.FromConfigVector(vector);
					}
				}
			}
			return this.CachedActorGravityDirect;
		}
	}

	// Token: 0x17002913 RID: 10515
	// (get) Token: 0x06019A75 RID: 105077 RVA: 0x007E4F03 File Offset: 0x007E3103
	public FVectorDouble ActorGravityDirection
	{
		get
		{
			return this.ActorGravityDirectProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002914 RID: 10516
	// (get) Token: 0x06019A76 RID: 105078 RVA: 0x007E4F11 File Offset: 0x007E3111
	public bool ActorInitNotStandardGravity
	{
		get
		{
			if (this.CachedActorInitNotStandardGravity == null)
			{
				this.InitCacheGravityRotation();
			}
			return this.CachedActorInitNotStandardGravity.Value;
		}
	}

	// Token: 0x17002915 RID: 10517
	// (get) Token: 0x06019A77 RID: 105079 RVA: 0x007E4F31 File Offset: 0x007E3131
	public global::Rotator ActorInitGravityRotationProxy
	{
		get
		{
			if (this.CachedActorInitGravityRotation == null)
			{
				this.InitCacheGravityRotation();
			}
			return this.CachedActorInitGravityRotation;
		}
	}

	// Token: 0x17002916 RID: 10518
	// (get) Token: 0x06019A78 RID: 105080 RVA: 0x007E4F47 File Offset: 0x007E3147
	public FRotator ActorInitGravityRotation
	{
		get
		{
			if (this.CachedActorInitGravityRotation == null)
			{
				this.InitCacheGravityRotation();
			}
			return this.CachedActorInitGravityRotation.ToUeRotator();
		}
	}

	// Token: 0x06019A79 RID: 105081 RVA: 0x007E4F64 File Offset: 0x007E3164
	private void InitCacheGravityRotation()
	{
		Aki.Protocol.Vector initGravityDirection = this.CreatureData.GetInitGravityDirection();
		if (initGravityDirection != null)
		{
			global::Vector vector = global::Vector.Create();
			vector.FromConfigVector(initGravityDirection);
			if (vector.Normalize(9.99999993922529E-09) && !MathUtils.Instance.IsNearlyEqual((double)initGravityDirection.Z, -1.0, null))
			{
				global::Vector vector2 = global::Vector.Create();
				Quat quat = Quat.Create(0.0, 0.0, 0.0, 1.0);
				vector.UnaryNegation(vector2);
				if (Math.Abs(vector2.DotProduct(global::Vector.ForwardVectorProxy)) < 0.9999)
				{
					MathUtils.Instance.LookRotationUpFirst(global::Vector.ForwardVectorProxy, vector2, quat);
				}
				else
				{
					MathUtils.Instance.LookRotationUpFirst(global::Vector.UpVectorProxy, vector2, quat);
				}
				this.CachedActorInitNotStandardGravity = new bool?(true);
				this.CachedActorInitGravityRotation = quat.Rotator(null);
				return;
			}
		}
		this.CachedActorInitNotStandardGravity = new bool?(false);
		this.CachedActorInitGravityRotation = global::Rotator.Create(0f, 0f, 0f);
	}

	// Token: 0x06019A7A RID: 105082 RVA: 0x007E5086 File Offset: 0x007E3286
	public virtual float GetRadius()
	{
		return 0f;
	}

	// Token: 0x17002917 RID: 10519
	// (get) Token: 0x06019A7B RID: 105083 RVA: 0x007E508D File Offset: 0x007E328D
	[Nullable(2)]
	public AActor Owner
	{
		[NullableContext(2)]
		get
		{
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null || !actorInternal.IsValid())
			{
				return null;
			}
			return this.ActorInternal;
		}
	}

	// Token: 0x17002918 RID: 10520
	// (get) Token: 0x06019A7C RID: 105084 RVA: 0x007E50B0 File Offset: 0x007E32B0
	[Obsolete("非安全获取速度，需要提前校验ActorInternal, 或者使用SafeActorVelocityProxy")]
	public global::Vector ActorVelocityProxy
	{
		get
		{
			if (this.CachedVelocityTime < Time.Instance.Frame)
			{
				this.CachedVelocityTime = Time.Instance.Frame;
				global::Vector cachedActorVelocity = this.CachedActorVelocity;
				FVectorDouble fvectorDouble = this.ActorInternal.D_GetVelocity();
				cachedActorVelocity.DeepCopy(fvectorDouble);
			}
			return this.CachedActorVelocity;
		}
	}

	// Token: 0x17002919 RID: 10521
	// (get) Token: 0x06019A7D RID: 105085 RVA: 0x007E50FE File Offset: 0x007E32FE
	public FVector ActorVelocity
	{
		get
		{
			return this.ActorVelocityProxy.ToUeVectorOld();
		}
	}

	// Token: 0x1700291A RID: 10522
	// (get) Token: 0x06019A7E RID: 105086 RVA: 0x007E510B File Offset: 0x007E330B
	[Nullable(2)]
	public global::Vector SafeActorVelocityProxy
	{
		[NullableContext(2)]
		get
		{
			AActor actorInternal = this.ActorInternal;
			if (actorInternal == null || !actorInternal.IsValid())
			{
				return null;
			}
			return this.ActorVelocityProxy;
		}
	}

	// Token: 0x1700291B RID: 10523
	// (get) Token: 0x06019A7F RID: 105087 RVA: 0x007E512C File Offset: 0x007E332C
	[Nullable(2)]
	public virtual USkeletalMeshComponent SkeletalMesh
	{
		[NullableContext(2)]
		get
		{
			return null;
		}
	}

	// Token: 0x06019A80 RID: 105088 RVA: 0x007E512F File Offset: 0x007E332F
	public virtual bool HasMesh()
	{
		return false;
	}

	// Token: 0x06019A81 RID: 105089 RVA: 0x007E5132 File Offset: 0x007E3332
	protected virtual void OnTeleport()
	{
		this.LastActorLocation.DeepCopy(this.ActorLocationProxy);
		this.LastActorRotation.DeepCopy(this.ActorRotationProxy);
	}

	// Token: 0x06019A82 RID: 105090 RVA: 0x007E5158 File Offset: 0x007E3358
	public unsafe virtual bool SetActorLocation(FVectorDouble value, string context = "unknown", bool sweep = true)
	{
		if (!MathUtils.Instance.IsValidVector(value, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "SetActorLocation的value无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		bool result = false;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			this.CachedDesiredActorLocation.FromUeVector(value);
			this.IsChangingLocation = true;
			result = this.ActorInternal.D_K2_SetActorLocation(value, sweep, ref WorldGlobal.SweepHitResult, true);
			this.IsChangingLocation = false;
			this.CheckIsForbidSettingLocAndRot(true, false, true);
			if (this.DebugMovementComp != null)
			{
				this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
			}
		}
		this.ResetLocationCachedTime();
		this.OnTeleport();
		AActor actorInternal2 = this.ActorInternal;
		if (actorInternal2 != null && actorInternal2.IsValid() && SundryModel.Instance.SceneCheckOn)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[SetActorLocation]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("location:", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("owner", this.Owner);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		return result;
	}

	// Token: 0x06019A83 RID: 105091 RVA: 0x007E52F8 File Offset: 0x007E34F8
	public unsafe virtual bool SetActorLocationNoTeleport(FVectorDouble value, string context = "unknown", bool sweep = true)
	{
		if (!MathUtils.Instance.IsValidVector(value, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "SetActorLocation的value无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		bool result = false;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			this.CachedDesiredActorLocation.FromUeVector(value);
			this.IsChangingLocation = true;
			result = this.ActorInternal.D_K2_SetActorLocation(value, sweep, ref WorldGlobal.SweepHitResult, true);
			this.IsChangingLocation = false;
			this.CheckIsForbidSettingLocAndRot(true, false, true);
			if (this.DebugMovementComp != null)
			{
				this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
			}
		}
		this.ResetLocationCachedTime();
		AActor actorInternal2 = this.ActorInternal;
		if (actorInternal2 != null && actorInternal2.IsValid() && SundryModel.Instance.SceneCheckOn)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[SetActorLocation]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("location:", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("owner", this.Owner);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		return result;
	}

	// Token: 0x06019A84 RID: 105092 RVA: 0x007E5490 File Offset: 0x007E3690
	public unsafe virtual bool TeleportTo(FVectorDouble location, FRotator rotator, string context = "unknown")
	{
		if (!MathUtils.Instance.IsValidVector(location, 100000000) || !MathUtils.Instance.IsValidRotator(rotator, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "TeleportTo的location无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("location", location);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		bool result = false;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			this.CachedDesiredActorLocation.FromUeVector(location);
			this.IsChangingLocation = true;
			result = this.ActorInternal.D_K2_KuroTeleportTo(location, rotator);
			this.IsChangingLocation = false;
			this.CheckIsForbidSettingLocAndRot(true, true, true);
			if (this.DebugMovementComp != null)
			{
				this.DebugMovementComp.MarkDebugRecord(context + ".TeleportTo", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), true);
			}
		}
		this.ResetLocationCachedTime();
		this.OnTeleport();
		AActor actorInternal2 = this.ActorInternal;
		if (actorInternal2 != null && actorInternal2.IsValid() && SundryModel.Instance.SceneCheckOn)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[TeleportTo]";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("location:", location);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("owner", this.Owner);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
		}
		return result;
	}

	// Token: 0x06019A85 RID: 105093 RVA: 0x007E563F File Offset: 0x007E383F
	public void ResetLocationCachedTime()
	{
		this.CachedTransformTime = -1;
		this.CachedLocationTime = -1;
	}

	// Token: 0x06019A86 RID: 105094 RVA: 0x007E5650 File Offset: 0x007E3850
	public virtual bool SetActorRotation(FRotator value, string context = "unknown", bool sweep = true)
	{
		bool result = false;
		AActor actorInternal = this.ActorInternal;
		if (actorInternal != null && actorInternal.IsValid())
		{
			result = this.ActorInternal.K2_KuroSetActorRotation(value, sweep, false, false);
			this.CheckIsForbidSettingLocAndRot(false, true, true);
			if (this.DebugMovementComp != null)
			{
				this.DebugMovementComp.MarkDebugRecord(context + ".SetActorRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
			}
		}
		this.ResetRotationCachedTime();
		return result;
	}

	// Token: 0x06019A87 RID: 105095 RVA: 0x007E56B9 File Offset: 0x007E38B9
	public void ResetRotationCachedTime()
	{
		this.CachedTransformTime = 0;
		this.CachedRotationTime = 0;
		this.CachedUpTime = 0;
		this.CachedRightTime = 0;
		this.CachedForwardTime = 0;
	}

	// Token: 0x06019A88 RID: 105096 RVA: 0x007E56E0 File Offset: 0x007E38E0
	public unsafe virtual bool SetActorLocationAndRotation(FVectorDouble location, FRotator rotation, string context = "unknown", bool sweep = false, ESetRotationPriority? priority = null)
	{
		if (!MathUtils.Instance.IsValidVector(location, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "SetActorLocationAndRotation的location无效";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("location", location);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		this.CachedDesiredActorLocation.FromUeVector(location);
		this.IsChangingLocation = true;
		bool result = this.ActorInternal.D_K2_SetActorLocationAndRotation(location, rotation, sweep, ref WorldGlobal.SweepHitResult, true);
		this.IsChangingLocation = false;
		this.ResetTransformCachedTime();
		this.OnTeleport();
		this.CheckIsForbidSettingLocAndRot(true, true, true);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorLocationAndRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		if (SundryModel.Instance.SceneCheckOn)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Test;
			ELogAuthor author2 = ELogAuthor.LJM;
			string message2 = "[SetActorLocationAndRotation]";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("location:", location);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("rotation:", rotation);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("owner", this.Owner);
			instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 3));
		}
		return result;
	}

	// Token: 0x06019A89 RID: 105097 RVA: 0x007E5874 File Offset: 0x007E3A74
	public unsafe virtual bool SetActorTransform(FTransformDouble value, string context = "unknown", bool sweep = true, ESetRotationPriority? priority = null)
	{
		FVectorDouble location = value.GetLocation();
		if (!MathUtils.Instance.IsValidVector(location, 100000000))
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "SetActorTransform的value参数";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("value", value);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Location", location);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData != null) ? new long?(creatureData.GetCreatureDataId()) : null);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
			return false;
		}
		global::Vector cachedDesiredActorLocation = this.CachedDesiredActorLocation;
		FVectorDouble location2 = value.GetLocation();
		cachedDesiredActorLocation.FromUeVector(location2);
		bool result;
		if (this.ActorLocationProxy.Equals(this.CachedDesiredActorLocation, 9.999999747378752E-05))
		{
			result = this.SetActorRotation(value.GetRotation().Rotator(), context, sweep);
		}
		else
		{
			this.IsChangingLocation = true;
			result = this.ActorInternal.D_K2_SetActorTransform(value, sweep, ref WorldGlobal.SweepHitResult, true);
			this.IsChangingLocation = false;
		}
		this.CheckIsForbidSettingLocAndRot(true, true, true);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".SetActorTransform", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ResetTransformCachedTime();
		this.OnTeleport();
		return result;
	}

	// Token: 0x06019A8A RID: 105098 RVA: 0x007E59EC File Offset: 0x007E3BEC
	public virtual void AddActorWorldOffset(FVectorDouble offset, string context = "unknown", bool sweep = true)
	{
		if (this.CheckIsForbidSettingLocAndRot(true, false, true))
		{
			return;
		}
		this.ActorInternal.D_K2_AddActorWorldOffset(offset, sweep, ref WorldGlobal.SweepHitResult, false);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldOffset", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ResetLocationCachedTime();
	}

	// Token: 0x06019A8B RID: 105099 RVA: 0x007E5A44 File Offset: 0x007E3C44
	public virtual void AddActorLocalOffset(FVectorDouble offset, string context = "unknown", bool sweep = true)
	{
		if (this.CheckIsForbidSettingLocAndRot(true, false, true))
		{
			return;
		}
		this.ActorInternal.D_K2_AddActorLocalOffset(offset, sweep, ref WorldGlobal.SweepHitResult, false);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorLocalOffset", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ResetLocationCachedTime();
	}

	// Token: 0x06019A8C RID: 105100 RVA: 0x007E5A9C File Offset: 0x007E3C9C
	public virtual void AddActorWorldRotation(FRotator rotation, string context = "unknown", bool sweep = false)
	{
		if (this.CheckIsForbidSettingLocAndRot(false, true, true))
		{
			return;
		}
		this.ActorInternal.K2_AddActorWorldRotation(rotation, sweep, ref WorldGlobal.SweepHitResult, false);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ResetRotationCachedTime();
	}

	// Token: 0x06019A8D RID: 105101 RVA: 0x007E5AF4 File Offset: 0x007E3CF4
	public virtual void AddActorLocalRotation(FRotator rotation, string context = "unknown", bool sweep = false)
	{
		if (this.CheckIsForbidSettingLocAndRot(false, true, true))
		{
			return;
		}
		this.ActorInternal.K2_AddActorLocalRotation(rotation, sweep, ref WorldGlobal.SweepHitResult, false);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorLocalRotation", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ResetRotationCachedTime();
	}

	// Token: 0x06019A8E RID: 105102 RVA: 0x007E5B4C File Offset: 0x007E3D4C
	public virtual void AddActorWorldOffsetAndQuat(FVectorDouble offset, FQuat quatOffset, string context = "unknown", bool sweep = true)
	{
		if (this.CheckIsForbidSettingLocAndRot(true, false, true))
		{
			return;
		}
		this.ActorInternal.D_K2_AddActorWorldOffset(offset, sweep, ref WorldGlobal.SweepHitResult, false);
		this.ActorInternal.K2_AddActorWorldRotation(quatOffset.Rotator(), sweep, ref WorldGlobal.SweepHitResult, false);
		if (this.DebugMovementComp != null)
		{
			this.DebugMovementComp.MarkDebugRecord(context + ".AddActorWorldOffsetAndQuat", new EKDMRecordType?(EKDMRecordType.KDM_LOCATION), false);
		}
		this.ResetTransformCachedTime();
	}

	// Token: 0x06019A8F RID: 105103 RVA: 0x007E5BC0 File Offset: 0x007E3DC0
	protected void ResetTransformCachedTime()
	{
		this.CachedTransformTime = 0;
		this.CachedLocationTime = 0;
		this.CachedRotationTime = 0;
		this.CachedUpTime = 0;
		this.CachedRightTime = 0;
		this.CachedForwardTime = 0;
		this.CachedGravityDirectTime = 0;
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.ResetCharTraceHeight();
	}

	// Token: 0x06019A90 RID: 105104 RVA: 0x007E5C10 File Offset: 0x007E3E10
	public void ResetAllCachedTime()
	{
		this.CachedTransformTime = -1;
		this.CachedLocationTime = -1;
		this.CachedRotationTime = -1;
		this.CachedUpTime = -1;
		this.CachedRightTime = -1;
		this.CachedForwardTime = -1;
		this.CachedVelocityTime = -1;
		this.CachedGravityDirectTime = -1;
		BaseMoveComponent moveComp = this.MoveComp;
		if (moveComp == null)
		{
			return;
		}
		moveComp.ResetCharTraceHeight();
	}

	// Token: 0x06019A91 RID: 105105 RVA: 0x007E5C65 File Offset: 0x007E3E65
	public void ResetCachedVelocityTime()
	{
		this.CachedVelocityTime = -1;
	}

	// Token: 0x06019A92 RID: 105106 RVA: 0x007E5C6E File Offset: 0x007E3E6E
	public void ResetGravityRelatedCachedTime()
	{
		this.CachedGravityDirectTime = -1;
	}

	// Token: 0x06019A93 RID: 105107 RVA: 0x007E5C77 File Offset: 0x007E3E77
	private void SetForbidSettingLocAndRotInternal(bool forbid, EForbidSettingLocAndRotReason reason, HashSet<EForbidSettingLocAndRotReason> target)
	{
		if (forbid)
		{
			target.Add(reason);
			return;
		}
		target.Remove(reason);
	}

	// Token: 0x06019A94 RID: 105108 RVA: 0x007E5C90 File Offset: 0x007E3E90
	public void SetForbidSettingLocAndRot(bool forbid, EForbidSettingLocAndRotReason reason)
	{
		switch (ForbidSettingLocAndRotTypeDefines.Values[(int)reason])
		{
		case EForbidSettingLocAndRotType.Location:
			this.SetForbidSettingLocAndRotInternal(forbid, reason, this.ForbidSettingLocSet);
			return;
		case EForbidSettingLocAndRotType.Rotation:
			this.SetForbidSettingLocAndRotInternal(forbid, reason, this.ForbidSettingRotSet);
			return;
		case (EForbidSettingLocAndRotType)3:
			break;
		case EForbidSettingLocAndRotType.Both:
			this.SetForbidSettingLocAndRotInternal(forbid, reason, this.ForbidSettingLocSet);
			this.SetForbidSettingLocAndRotInternal(forbid, reason, this.ForbidSettingRotSet);
			break;
		default:
			return;
		}
	}

	// Token: 0x06019A95 RID: 105109 RVA: 0x007E5CF8 File Offset: 0x007E3EF8
	protected unsafe bool CheckIsForbidSettingLocAndRot(bool Loc = false, bool Rot = false, bool Debug = true)
	{
		bool flag = this.ForbidSettingRotSet.Count > 0 && Rot;
		bool flag2 = this.ForbidSettingLocSet.Count > 0 && Loc;
		if (!flag && !flag2)
		{
			return false;
		}
		if (Debug)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Test;
			ELogAuthor author = ELogAuthor.YJX;
			string message = "[BaseActorComp] 检测到异常的设置位置或旋转行为";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("PbDataId", this.CreatureData.GetPbDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("CreatureId", this.CreatureData.GetCreatureDataId());
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("TargetLoc", this.ActorLocationProxy);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("TargetRot", this.ActorRotationProxy);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		return true;
	}

	// Token: 0x06019A96 RID: 105110 RVA: 0x007E5DE0 File Offset: 0x007E3FE0
	[NullableContext(2)]
	protected virtual void OnSetActorActive(bool active, string reason = null)
	{
		if (active)
		{
			this.EnableActor(this.ActorHandleForEntityDisable.Value);
			this.EnableCollision(this.CollisionHandleForEntityDisable.Value);
			this.ActorHandleForEntityDisable = null;
			this.CollisionHandleForEntityDisable = null;
			return;
		}
		this.ActorHandleForEntityDisable = new int?(this.DisableActor(reason));
		this.CollisionHandleForEntityDisable = new int?(this.DisableCollision(reason));
	}

	// Token: 0x06019A97 RID: 105111 RVA: 0x007E5E51 File Offset: 0x007E4051
	public void SetSequenceBinding(bool inEnable)
	{
		this.IsInSequenceBinding = inEnable;
	}

	// Token: 0x06019A98 RID: 105112 RVA: 0x007E5E5A File Offset: 0x007E405A
	public bool GetSequenceBinding()
	{
		return this.IsInSequenceBinding;
	}

	// Token: 0x06019A99 RID: 105113 RVA: 0x007E5E64 File Offset: 0x007E4064
	public unsafe int DisableActor(string reason)
	{
		int num = this.DisableActorHandle.Disable(reason, base.GetType().Name);
		CreatureController instance = CreatureController.Instance;
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (instance.CheckEnableEntityLog((eentityType != null) ? new OneOf<EEntityType, EntityHandle>?(eentityType.GetValueOrDefault()) : null))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "DisableActor";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData2 = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureData3 = this.CreatureData;
			ptr2 = new ValueTuple<string, object>(item2, (creatureData3 != null) ? new int?(creatureData3.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		AActor actorInternal = this.ActorInternal;
		if (actorInternal == null || !actorInternal.IsValid())
		{
			return num;
		}
		if (this.ActorInternal.bHidden)
		{
			return num;
		}
		this.ActorInternal.SetActorHiddenInGame(true);
		EventSystem.Instance.Emit<int, bool>(EEventName.OnSetActorHidden, base.Entity.Id, false);
		if (this.Handle != null)
		{
			EventSystem.Instance.EmitWithTarget<int, bool>(this.Handle, EEventName.OnSetActorHidden, base.Entity.Id, false);
		}
		return num;
	}

	// Token: 0x06019A9A RID: 105114 RVA: 0x007E6028 File Offset: 0x007E4228
	public unsafe int DisableCollision(string reason)
	{
		int num = this.DisableCollisionHandle.Disable(reason, base.GetType().Name);
		CreatureController instance = CreatureController.Instance;
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (instance.CheckEnableEntityLog((eentityType != null) ? new OneOf<EEntityType, EntityHandle>?(eentityType.GetValueOrDefault()) : null))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "DisableCollision";
			<>y__InlineArray4<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray4<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData2 = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureData3 = this.CreatureData;
			ptr2 = new ValueTuple<string, object>(item2, (creatureData3 != null) ? new int?(creatureData3.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", num);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("Reason", reason);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray4<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 4));
		}
		AActor actorInternal = this.ActorInternal;
		if (actorInternal == null || !actorInternal.IsValid())
		{
			return num;
		}
		this.ActorInternal.SetActorEnableCollision(false);
		return num;
	}

	// Token: 0x06019A9B RID: 105115 RVA: 0x007E6198 File Offset: 0x007E4398
	public unsafe bool EnableActor(int handle)
	{
		CreatureController instance = CreatureController.Instance;
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (instance.CheckEnableEntityLog((eentityType != null) ? new OneOf<EEntityType, EntityHandle>?(eentityType.GetValueOrDefault()) : null))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "EnableActor";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData2 = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureData3 = this.CreatureData;
			ptr2 = new ValueTuple<string, object>(item2, (creatureData3 != null) ? new int?(creatureData3.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", handle);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		bool flag = this.DisableActorHandle.Enable(handle, base.GetType().Name);
		if (!flag)
		{
			return flag;
		}
		AActor actorInternal = this.ActorInternal;
		if (actorInternal == null || !actorInternal.IsValid())
		{
			return flag;
		}
		if (this.ActorInternal.bHidden == !this.DisableActorHandle.Empty)
		{
			return flag;
		}
		EventSystem.Instance.EmitWithTarget<int, bool>(CharacterModel.Instance.GetHandleByEntity(base.Entity), EEventName.OnPreSetActorHidden, base.Entity.Id, this.DisableActorHandle.Empty);
		if (base.Entity.GetComponent<UeSkeletalTickManageComponent>() != null)
		{
			TimerSystem.Instance.Next(delegate(float _)
			{
				AActor actorInternal2 = this.ActorInternal;
				if (actorInternal2 == null || !actorInternal2.IsValid())
				{
					return;
				}
				this.<EnableActor>g__SetVisible|164_0();
			}, null, null);
		}
		else
		{
			this.<EnableActor>g__SetVisible|164_0();
		}
		return flag;
	}

	// Token: 0x06019A9C RID: 105116 RVA: 0x007E636C File Offset: 0x007E456C
	public unsafe bool EnableCollision(int handle)
	{
		CreatureController instance = CreatureController.Instance;
		CreatureDataComponent creatureData = this.CreatureData;
		EEntityType? eentityType = (creatureData != null) ? new EEntityType?(creatureData.GetEntityType()) : null;
		if (instance.CheckEnableEntityLog((eentityType != null) ? new OneOf<EEntityType, EntityHandle>?(eentityType.GetValueOrDefault()) : null))
		{
			Log instance2 = Log.Instance;
			ELogModule module = ELogModule.Entity;
			ELogAuthor author = ELogAuthor.LFJW;
			string message = "EnableCollision";
			<>y__InlineArray3<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray3<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "CreatureDataId";
			CreatureDataComponent creatureData2 = this.CreatureData;
			ptr = new ValueTuple<string, object>(item, (creatureData2 != null) ? new long?(creatureData2.GetCreatureDataId()) : null);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1);
			string item2 = "PbDataId";
			CreatureDataComponent creatureData3 = this.CreatureData;
			ptr2 = new ValueTuple<string, object>(item2, (creatureData3 != null) ? new int?(creatureData3.GetPbDataId()) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("Handle", handle);
			instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray3<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 3));
		}
		bool flag = this.DisableCollisionHandle.Enable(handle, base.GetType().Name);
		if (!flag)
		{
			return flag;
		}
		AActor actorInternal = this.ActorInternal;
		if (actorInternal == null || !actorInternal.IsValid())
		{
			return flag;
		}
		this.ActorInternal.SetActorEnableCollision(this.DisableCollisionHandle.Empty);
		return flag;
	}

	// Token: 0x06019A9D RID: 105117 RVA: 0x007E64D2 File Offset: 0x007E46D2
	public string DumpDisableActorInfo()
	{
		return this.DisableActorHandle.DumpDisableInfo();
	}

	// Token: 0x06019A9E RID: 105118 RVA: 0x007E64DF File Offset: 0x007E46DF
	public string DumpDisableCollisionInfo()
	{
		return this.DisableCollisionHandle.DumpDisableInfo();
	}

	// Token: 0x06019A9F RID: 105119 RVA: 0x007E64EC File Offset: 0x007E46EC
	public string DumpDisableTickInfo()
	{
		UeActorTickManageComponent component = base.Entity.GetComponent<UeActorTickManageComponent>();
		return ((component != null) ? component.DumpDisableTickInfo() : null) ?? "";
	}

	// Token: 0x06019AA0 RID: 105120 RVA: 0x007E6510 File Offset: 0x007E4710
	public void SetActorVisible(bool visible, string reason)
	{
		if (!visible)
		{
			if (this.ActorHandleForCommon != null)
			{
				return;
			}
			this.ActorHandleForCommon = new int?(this.DisableActor(reason));
			return;
		}
		else
		{
			if (this.ActorHandleForCommon == null)
			{
				return;
			}
			this.EnableActor(this.ActorHandleForCommon.Value);
			this.ActorHandleForCommon = null;
			return;
		}
	}

	// Token: 0x06019AA1 RID: 105121 RVA: 0x007E6570 File Offset: 0x007E4770
	public void SetCollisionEnable(bool enable, string reason)
	{
		if (!enable)
		{
			if (this.CollisionHandleForCommon != null)
			{
				return;
			}
			this.CollisionHandleForCommon = new int?(this.DisableCollision(reason));
			return;
		}
		else
		{
			if (this.CollisionHandleForCommon == null)
			{
				return;
			}
			this.EnableCollision(this.CollisionHandleForCommon.Value);
			this.CollisionHandleForCommon = null;
			return;
		}
	}

	// Token: 0x06019AA2 RID: 105122 RVA: 0x007E65D0 File Offset: 0x007E47D0
	public void SetTickEnable(bool enable, string reason)
	{
		if (!enable)
		{
			if (this.TickHandleForCommon != null)
			{
				return;
			}
			UeActorTickManageComponent component = base.Entity.GetComponent<UeActorTickManageComponent>();
			this.TickHandleForCommon = ((component != null) ? new int?(component.DisableTickWithLog(reason)) : null);
			return;
		}
		else
		{
			if (this.TickHandleForCommon == null)
			{
				return;
			}
			UeActorTickManageComponent component2 = base.Entity.GetComponent<UeActorTickManageComponent>();
			if (component2 != null)
			{
				component2.EnableTickWithLog(this.TickHandleForCommon.Value, reason);
			}
			this.TickHandleForCommon = null;
			return;
		}
	}

	// Token: 0x06019AA3 RID: 105123 RVA: 0x007E6657 File Offset: 0x007E4857
	protected override bool OnClear()
	{
		if (this.CreatureDataInternal != null)
		{
			this.CreatureDataInternal.Reset();
			this.CreatureDataInternal = null;
		}
		this.DisableActorHandle.Clear();
		this.DisableCollisionHandle.Clear();
		this.ResetAllCachedTime();
		return true;
	}

	// Token: 0x06019AA4 RID: 105124 RVA: 0x007E6690 File Offset: 0x007E4890
	public virtual FTransformDouble GetSocketTransform(FName socketName)
	{
		return this.ActorTransform;
	}

	// Token: 0x06019AA5 RID: 105125 RVA: 0x007E6698 File Offset: 0x007E4898
	public virtual FVectorDouble GetSocketLocation(FName socketName)
	{
		return this.ActorLocation;
	}

	// Token: 0x06019AA6 RID: 105126 RVA: 0x007E66A0 File Offset: 0x007E48A0
	public virtual global::Vector GetWatchedPoint()
	{
		return this.ActorLocationProxy;
	}

	// Token: 0x06019AA7 RID: 105127 RVA: 0x007E66A8 File Offset: 0x007E48A8
	[return: Nullable(2)]
	public string GetReplaceEffect(string path)
	{
		return this.ReplaceEffectMap.GetValueOrDefault(path);
	}

	// Token: 0x06019AA8 RID: 105128 RVA: 0x007E66B6 File Offset: 0x007E48B6
	public void SetReplaceEffect(Dictionary<string, string> map)
	{
		this.ReplaceEffectMap = map;
	}

	// Token: 0x06019AA9 RID: 105129 RVA: 0x007E66BF File Offset: 0x007E48BF
	[return: Nullable(2)]
	public string GetReplaceMontage(string path)
	{
		return this.ReplaceMontageMap.GetValueOrDefault(path);
	}

	// Token: 0x06019AAA RID: 105130 RVA: 0x007E66D0 File Offset: 0x007E48D0
	public void SetupReplacement([Nullable(2)] SModelConfig modelConfig, EntityAssetElement entityAssetElement)
	{
		if (modelConfig != null)
		{
			string text = modelConfig.特效替换表.ToAssetPathName();
			if (!string.IsNullOrEmpty(text))
			{
				this.ReplaceEffectMap = entityAssetElement.MainAsset.SetupReplaceEffect(text);
			}
		}
		if (modelConfig != null)
		{
			string text2 = modelConfig.蒙太奇替换表.ToAssetPathName();
			if (!string.IsNullOrEmpty(text2))
			{
				this.ReplaceMontageMap = entityAssetElement.MainAsset.SetupReplaceMontage(text2);
			}
		}
	}

	// Token: 0x06019AAB RID: 105131 RVA: 0x007E673B File Offset: 0x007E493B
	public static void RegisterDebugCube(AStaticMeshActor cube)
	{
		BaseActorComponent.AllDebugCubes.Add(cube);
		cube.SetActorHiddenInGame(!BaseActorComponent.AllDebugCubesVisible);
	}

	// Token: 0x06019AAC RID: 105132 RVA: 0x007E6757 File Offset: 0x007E4957
	public static void UnregisterDebugCube(AStaticMeshActor cube)
	{
		BaseActorComponent.AllDebugCubes.Remove(cube);
	}

	// Token: 0x06019AAD RID: 105133 RVA: 0x007E6768 File Offset: 0x007E4968
	public static void SetAllDebugCubesVisible(bool visible)
	{
		BaseActorComponent.AllDebugCubesVisible = visible;
		foreach (AStaticMeshActor astaticMeshActor in new List<AStaticMeshActor>(BaseActorComponent.AllDebugCubes))
		{
			if (astaticMeshActor != null && astaticMeshActor.IsValid())
			{
				astaticMeshActor.SetActorHiddenInGame(!visible);
			}
			else
			{
				BaseActorComponent.AllDebugCubes.Remove(astaticMeshActor);
			}
		}
	}

	// Token: 0x06019AAE RID: 105134 RVA: 0x007E67E4 File Offset: 0x007E49E4
	public static void ApplyDebugCubeMaterial(UStaticMeshComponent meshComp)
	{
		if (BaseActorComponent.DebugCubeMaterialCache == null)
		{
			BaseActorComponent.DebugCubeMaterialCache = ResourceSystem.Instance.Load<UMaterialInterface>("/Game/Aki/UniverseEditor/Res/M_Sphere.M_Sphere", "js_undefined");
		}
		if (BaseActorComponent.DebugCubeMaterialCache != null)
		{
			meshComp.SetMaterial(0, BaseActorComponent.DebugCubeMaterialCache);
		}
	}

	// Token: 0x06019AAF RID: 105135 RVA: 0x007E681C File Offset: 0x007E4A1C
	public void ShowDebugLocationCube(bool enable)
	{
		if (!enable)
		{
			this.ClearDebugLocationCube();
			return;
		}
		if (GlobalData.IsPlayInEditor)
		{
			AActor actorInternal = this.ActorInternal;
			if (actorInternal != null && actorInternal.IsValid())
			{
				AStaticMeshActor debugPositionCube = this.DebugPositionCube;
				if (debugPositionCube == null || !debugPositionCube.IsValid())
				{
					this.DebugPositionCube = this.SpawnDebugCube(new FVectorDouble(0.6, 0.6, 0.6), new FVectorDouble(0.0, 0.0, 0.0), false);
				}
				AStaticMeshActor debugFootCube = this.DebugFootCube;
				if (debugFootCube == null || !debugFootCube.IsValid())
				{
					this.DebugFootCube = this.SpawnDebugCube(new FVectorDouble(0.3, 0.3, 0.3), new FVectorDouble(0.0, 0.0, (double)(-(double)this.ScaledHalfHeight)), false);
				}
				AStaticMeshActor debugForwardCube = this.DebugForwardCube;
				if (debugForwardCube == null || !debugForwardCube.IsValid())
				{
					this.DebugForwardCube = this.SpawnDebugCube(new FVectorDouble(1.2, 0.2, 0.2), new FVectorDouble(80.0, 0.0, 0.0), true);
				}
				return;
			}
		}
	}

	// Token: 0x06019AB0 RID: 105136 RVA: 0x007E6980 File Offset: 0x007E4B80
	public void ClearDebugLocationCube()
	{
		AStaticMeshActor debugPositionCube = this.DebugPositionCube;
		if (debugPositionCube != null && debugPositionCube.IsValid())
		{
			BaseActorComponent.UnregisterDebugCube(this.DebugPositionCube);
			this.DebugPositionCube.K2_DestroyActor();
		}
		this.DebugPositionCube = null;
		AStaticMeshActor debugFootCube = this.DebugFootCube;
		if (debugFootCube != null && debugFootCube.IsValid())
		{
			BaseActorComponent.UnregisterDebugCube(this.DebugFootCube);
			this.DebugFootCube.K2_DestroyActor();
		}
		this.DebugFootCube = null;
		AStaticMeshActor debugForwardCube = this.DebugForwardCube;
		if (debugForwardCube != null && debugForwardCube.IsValid())
		{
			BaseActorComponent.UnregisterDebugCube(this.DebugForwardCube);
			this.DebugForwardCube.K2_DestroyActor();
		}
		this.DebugForwardCube = null;
	}

	// Token: 0x06019AB1 RID: 105137 RVA: 0x007E6A20 File Offset: 0x007E4C20
	[NullableContext(2)]
	private AStaticMeshActor SpawnDebugCube(FVectorDouble scale, FVectorDouble relativeLocation, bool followRotation)
	{
		AStaticMeshActor astaticMeshActor = ActorSystem.Instance.Spawn(AStaticMeshActor.StaticClass(), this.ActorTransform, null) as AStaticMeshActor;
		if (astaticMeshActor == null)
		{
			return null;
		}
		UStaticMeshComponent staticMeshComponent = astaticMeshActor.StaticMeshComponent;
		if (staticMeshComponent != null)
		{
			staticMeshComponent.SetMobility(EComponentMobility.Movable);
			staticMeshComponent.SetStaticMesh(ResourceSystem.Instance.Load<UStaticMesh>("/Engine/BasicShapes/Cube.Cube", "js_undefined"));
			staticMeshComponent.SetHiddenInGame(false, false);
			BaseActorComponent.ApplyDebugCubeMaterial(staticMeshComponent);
		}
		astaticMeshActor.SetActorEnableCollision(false);
		astaticMeshActor.SetActorHiddenInGame(false);
		astaticMeshActor.D_SetActorScale3D(scale);
		EAttachmentRule rotationRule = followRotation ? EAttachmentRule.SnapToTarget : EAttachmentRule.KeepWorld;
		astaticMeshActor.K2_AttachToActor(this.ActorInternal, FName.NAME_None, EAttachmentRule.SnapToTarget, rotationRule, EAttachmentRule.KeepWorld, true, true);
		astaticMeshActor.D_K2_SetActorRelativeLocation(relativeLocation, false, ref WorldGlobal.SweepHitResult, true);
		BaseActorComponent.RegisterDebugCube(astaticMeshActor);
		return astaticMeshActor;
	}

	// Token: 0x06019AB2 RID: 105138 RVA: 0x007E6AD0 File Offset: 0x007E4CD0
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseActorComponent baseActorComponent = (BaseActorComponent)componentTemplate;
		if (baseActorComponent.MoveComp == null)
		{
			this.MoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.MoveComp), "MoveComp"))
		{
			return false;
		}
		if (baseActorComponent.VehicleMoveComp == null)
		{
			this.VehicleMoveComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.VehicleMoveComp), "VehicleMoveComp"))
		{
			return false;
		}
		if (baseActorComponent.ActorInternal == null)
		{
			this.ActorInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ActorInternal), "ActorInternal"))
		{
			return false;
		}
		this.CachedActorTransform = baseActorComponent.CachedActorTransform;
		if (baseActorComponent.CachedActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorLocation), "CachedActorLocation"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorRotation), "CachedActorRotation"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorScale != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorScale), "CachedActorScale"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorQuat), "CachedActorQuat"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorForward), "CachedActorForward"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorRight != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorRight), "CachedActorRight"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorUp != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorUp), "CachedActorUp"))
		{
			return false;
		}
		if (baseActorComponent.CachedActorGravityDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorGravityDirect), "CachedActorGravityDirect"))
		{
			return false;
		}
		this.CachedActorInitNotStandardGravity = baseActorComponent.CachedActorInitNotStandardGravity;
		if (baseActorComponent.CachedActorInitGravityRotation == null)
		{
			this.CachedActorInitGravityRotation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorInitGravityRotation), "CachedActorInitGravityRotation"))
		{
			return false;
		}
		this.CachedLocationTime = baseActorComponent.CachedLocationTime;
		this.CachedForwardTime = baseActorComponent.CachedForwardTime;
		this.CachedScaleTime = baseActorComponent.CachedScaleTime;
		this.CachedRotationTime = baseActorComponent.CachedRotationTime;
		this.CachedTransformTime = baseActorComponent.CachedTransformTime;
		this.CachedRightTime = baseActorComponent.CachedRightTime;
		this.CachedUpTime = baseActorComponent.CachedUpTime;
		this.CachedVelocityTime = baseActorComponent.CachedVelocityTime;
		if (baseActorComponent.CachedActorVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedActorVelocity), "CachedActorVelocity"))
		{
			return false;
		}
		this.CachedGravityDirectTime = baseActorComponent.CachedGravityDirectTime;
		if (baseActorComponent.CachedDesiredActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject(this.CachedDesiredActorLocation), "CachedDesiredActorLocation"))
		{
			return false;
		}
		this.IsChangingLocation = baseActorComponent.IsChangingLocation;
		if (baseActorComponent.CreatureDataInternal == null)
		{
			this.CreatureDataInternal = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.CreatureDataInternal), "CreatureDataInternal"))
		{
			return false;
		}
		if (baseActorComponent.DebugMovementComp == null)
		{
			this.DebugMovementComp = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugMovementComp), "DebugMovementComp"))
		{
			return false;
		}
		this.LogicAutonomous = baseActorComponent.LogicAutonomous;
		this.MoveAutonomous = baseActorComponent.MoveAutonomous;
		this.IsInSequenceBinding = baseActorComponent.IsInSequenceBinding;
		this.ActorHandleForCommon = baseActorComponent.ActorHandleForCommon;
		this.CollisionHandleForCommon = baseActorComponent.CollisionHandleForCommon;
		this.TickHandleForCommon = baseActorComponent.TickHandleForCommon;
		this.ActorHandleForEntityDisable = baseActorComponent.ActorHandleForEntityDisable;
		this.CollisionHandleForEntityDisable = baseActorComponent.CollisionHandleForEntityDisable;
		if (baseActorComponent.LastActorLocation == null)
		{
			this.LastActorLocation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastActorLocation), "LastActorLocation"))
		{
			return false;
		}
		if (baseActorComponent.LastActorRotation == null)
		{
			this.LastActorRotation = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.LastActorRotation), "LastActorRotation"))
		{
			return false;
		}
		if (baseActorComponent.SimulatedVelocity == null)
		{
			this.SimulatedVelocity = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.SimulatedVelocity), "SimulatedVelocity"))
		{
			return false;
		}
		this.SimulatedRotYawSpeed = baseActorComponent.SimulatedRotYawSpeed;
		if (baseActorComponent.Handle == null)
		{
			this.Handle = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.Handle), "Handle"))
		{
			return false;
		}
		this.IsRoleAndCtrlByMe = baseActorComponent.IsRoleAndCtrlByMe;
		this.RadiusInternal = baseActorComponent.RadiusInternal;
		this.HalfHeightInternal = baseActorComponent.HalfHeightInternal;
		this.DefaultRadiusInternal = baseActorComponent.DefaultRadiusInternal;
		this.DefaultHalfHeightInternal = baseActorComponent.DefaultHalfHeightInternal;
		if (baseActorComponent.ForbidSettingLocSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForbidSettingLocAndRotReason>(this.ForbidSettingLocSet), "ForbidSettingLocSet"))
		{
			return false;
		}
		if (baseActorComponent.ForbidSettingRotSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForbidSettingLocAndRotReason>(this.ForbidSettingRotSet), "ForbidSettingRotSet"))
		{
			return false;
		}
		if (baseActorComponent.OwnedBasePlatform == null)
		{
			this.OwnedBasePlatform = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.OwnedBasePlatform), "OwnedBasePlatform"))
		{
			return false;
		}
		if (baseActorComponent.ReplaceEffectMap == null)
		{
			this.ReplaceEffectMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReplaceEffectMap), "ReplaceEffectMap"))
		{
			return false;
		}
		if (baseActorComponent.ReplaceMontageMap == null)
		{
			this.ReplaceMontageMap = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.ReplaceMontageMap), "ReplaceMontageMap"))
		{
			return false;
		}
		if (baseActorComponent.DebugPositionCube == null)
		{
			this.DebugPositionCube = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugPositionCube), "DebugPositionCube"))
		{
			return false;
		}
		if (baseActorComponent.DebugFootCube == null)
		{
			this.DebugFootCube = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugFootCube), "DebugFootCube"))
		{
			return false;
		}
		if (baseActorComponent.DebugForwardCube == null)
		{
			this.DebugForwardCube = null;
		}
		else if (!base.CheckClearObject(EntityComponentSystem.ClearObject(this.DebugForwardCube), "DebugForwardCube"))
		{
			return false;
		}
		return true;
	}

	// Token: 0x1700291C RID: 10524
	// (get) Token: 0x06019AB3 RID: 105139 RVA: 0x007E7070 File Offset: 0x007E5270
	public override bool NeedCreateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700291D RID: 10525
	// (get) Token: 0x06019AB4 RID: 105140 RVA: 0x007E7073 File Offset: 0x007E5273
	public override bool NeedClearInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700291E RID: 10526
	// (get) Token: 0x06019AB5 RID: 105141 RVA: 0x007E7076 File Offset: 0x007E5276
	public override bool NeedStartInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x1700291F RID: 10527
	// (get) Token: 0x06019AB6 RID: 105142 RVA: 0x007E7079 File Offset: 0x007E5279
	public override bool NeedActivateInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x17002920 RID: 10528
	// (get) Token: 0x06019AB7 RID: 105143 RVA: 0x007E707C File Offset: 0x007E527C
	public override bool NeedEndInternal
	{
		get
		{
			return true;
		}
	}

	// Token: 0x06019ABA RID: 105146 RVA: 0x007E7270 File Offset: 0x007E5470
	[CompilerGenerated]
	private void <EnableActor>g__SetVisible|164_0()
	{
		bool empty = this.DisableActorHandle.Empty;
		this.ActorInternal.SetActorHiddenInGame(!empty);
		EventSystem.Instance.Emit<int, bool>(EEventName.OnSetActorHidden, base.Entity.Id, empty);
		if (this.Handle != null)
		{
			EventSystem.Instance.EmitWithTarget<int, bool>(this.Handle, EEventName.OnSetActorHidden, base.Entity.Id, empty);
		}
	}

	// Token: 0x0400E0D6 RID: 57558
	[Nullable(2)]
	public BaseMoveComponent MoveComp;

	// Token: 0x0400E0D7 RID: 57559
	[Nullable(2)]
	public VehicleMoveComponent VehicleMoveComp;

	// Token: 0x0400E0D8 RID: 57560
	[Nullable(2)]
	protected AActor ActorInternal;

	// Token: 0x0400E0D9 RID: 57561
	protected FTransformDouble? CachedActorTransform;

	// Token: 0x0400E0DA RID: 57562
	protected readonly global::Vector CachedActorLocation = global::Vector.Create();

	// Token: 0x0400E0DB RID: 57563
	protected readonly global::Rotator CachedActorRotation = global::Rotator.Create(0f, 0f, 0f);

	// Token: 0x0400E0DC RID: 57564
	protected readonly global::Vector CachedActorScale = global::Vector.Create();

	// Token: 0x0400E0DD RID: 57565
	protected readonly Quat CachedActorQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400E0DE RID: 57566
	protected readonly global::Vector CachedActorForward = global::Vector.Create(1.0, 0.0, 0.0);

	// Token: 0x0400E0DF RID: 57567
	protected readonly global::Vector CachedActorRight = global::Vector.Create(0.0, 1.0, 0.0);

	// Token: 0x0400E0E0 RID: 57568
	protected readonly global::Vector CachedActorUp = global::Vector.Create(0.0, 0.0, 1.0);

	// Token: 0x0400E0E1 RID: 57569
	protected readonly global::Vector CachedActorGravityDirect = global::Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400E0E2 RID: 57570
	protected bool? CachedActorInitNotStandardGravity;

	// Token: 0x0400E0E3 RID: 57571
	[Nullable(2)]
	protected global::Rotator CachedActorInitGravityRotation;

	// Token: 0x0400E0E4 RID: 57572
	protected int CachedLocationTime = -1;

	// Token: 0x0400E0E5 RID: 57573
	protected int CachedForwardTime = -1;

	// Token: 0x0400E0E6 RID: 57574
	protected int CachedScaleTime = -1;

	// Token: 0x0400E0E7 RID: 57575
	protected int CachedRotationTime = -1;

	// Token: 0x0400E0E8 RID: 57576
	protected int CachedTransformTime = -1;

	// Token: 0x0400E0E9 RID: 57577
	protected int CachedRightTime = -1;

	// Token: 0x0400E0EA RID: 57578
	protected int CachedUpTime = -1;

	// Token: 0x0400E0EB RID: 57579
	protected int CachedVelocityTime = -1;

	// Token: 0x0400E0EC RID: 57580
	protected readonly global::Vector CachedActorVelocity = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400E0ED RID: 57581
	protected int CachedGravityDirectTime = -1;

	// Token: 0x0400E0EE RID: 57582
	protected readonly global::Vector CachedDesiredActorLocation = global::Vector.Create();

	// Token: 0x0400E0EF RID: 57583
	protected bool IsChangingLocation;

	// Token: 0x0400E0F0 RID: 57584
	[Nullable(2)]
	protected CreatureDataComponent CreatureDataInternal;

	// Token: 0x0400E0F1 RID: 57585
	[Nullable(2)]
	public ActorDebugMovementComponent DebugMovementComp;

	// Token: 0x0400E0F2 RID: 57586
	private bool LogicAutonomous = true;

	// Token: 0x0400E0F3 RID: 57587
	private bool MoveAutonomous = true;

	// Token: 0x0400E0F4 RID: 57588
	protected bool IsInSequenceBinding;

	// Token: 0x0400E0F5 RID: 57589
	[Nullable(2)]
	[UnResetProperty]
	public DisableEntityHandle DisableActorHandle;

	// Token: 0x0400E0F6 RID: 57590
	[Nullable(2)]
	[UnResetProperty]
	public DisableEntityHandle DisableCollisionHandle;

	// Token: 0x0400E0F7 RID: 57591
	private int? ActorHandleForCommon;

	// Token: 0x0400E0F8 RID: 57592
	private int? CollisionHandleForCommon;

	// Token: 0x0400E0F9 RID: 57593
	private int? TickHandleForCommon;

	// Token: 0x0400E0FA RID: 57594
	private int? ActorHandleForEntityDisable;

	// Token: 0x0400E0FB RID: 57595
	private int? CollisionHandleForEntityDisable;

	// Token: 0x0400E0FC RID: 57596
	public global::Vector LastActorLocation = global::Vector.Create();

	// Token: 0x0400E0FD RID: 57597
	public global::Rotator LastActorRotation = global::Rotator.Create();

	// Token: 0x0400E0FE RID: 57598
	public global::Vector SimulatedVelocity = global::Vector.Create();

	// Token: 0x0400E0FF RID: 57599
	public float SimulatedRotYawSpeed;

	// Token: 0x0400E100 RID: 57600
	[Nullable(2)]
	private EntityHandle Handle;

	// Token: 0x0400E101 RID: 57601
	public bool IsRoleAndCtrlByMe;

	// Token: 0x0400E102 RID: 57602
	protected float RadiusInternal;

	// Token: 0x0400E103 RID: 57603
	protected float HalfHeightInternal;

	// Token: 0x0400E104 RID: 57604
	protected float DefaultRadiusInternal;

	// Token: 0x0400E105 RID: 57605
	protected float DefaultHalfHeightInternal;

	// Token: 0x0400E106 RID: 57606
	private readonly HashSet<EForbidSettingLocAndRotReason> ForbidSettingLocSet = new HashSet<EForbidSettingLocAndRotReason>();

	// Token: 0x0400E107 RID: 57607
	private readonly HashSet<EForbidSettingLocAndRotReason> ForbidSettingRotSet = new HashSet<EForbidSettingLocAndRotReason>();

	// Token: 0x0400E108 RID: 57608
	[Nullable(2)]
	public BasePlatform OwnedBasePlatform;

	// Token: 0x0400E109 RID: 57609
	public Dictionary<string, string> ReplaceEffectMap = new Dictionary<string, string>();

	// Token: 0x0400E10A RID: 57610
	public Dictionary<string, string> ReplaceMontageMap = new Dictionary<string, string>();

	// Token: 0x0400E10B RID: 57611
	[StaticVariableRuleIgnore]
	private static readonly HashSet<AStaticMeshActor> AllDebugCubes = new HashSet<AStaticMeshActor>();

	// Token: 0x0400E10C RID: 57612
	[StaticVariableRuleIgnore]
	private static bool AllDebugCubesVisible = false;

	// Token: 0x0400E10D RID: 57613
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	private static UMaterialInterface DebugCubeMaterialCache = null;

	// Token: 0x0400E10E RID: 57614
	[Nullable(2)]
	private AStaticMeshActor DebugPositionCube;

	// Token: 0x0400E10F RID: 57615
	[Nullable(2)]
	private AStaticMeshActor DebugFootCube;

	// Token: 0x0400E110 RID: 57616
	[Nullable(2)]
	private AStaticMeshActor DebugForwardCube;
}
