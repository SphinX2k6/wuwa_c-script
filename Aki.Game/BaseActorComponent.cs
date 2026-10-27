using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Data.Entity.Struct;
using CSharpScript.Game.Common.Event;
using UnrealEngine;

// Token: 0x0200326F RID: 12911
[NullableContext(1)]
[Nullable(0)]
public class BaseActorComponent : EntityComponent
{
	// Token: 0x17002665 RID: 9829
	// (get) Token: 0x0601BE73 RID: 114291 RVA: 0x007BCFA4 File Offset: 0x007BB1A4
	public float ScaledRadius
	{
		get
		{
			return (float)((double)this.RadiusInternal * this.ActorScaleProxy.X);
		}
	}

	// Token: 0x17002666 RID: 9830
	// (get) Token: 0x0601BE74 RID: 114292 RVA: 0x007BCFBA File Offset: 0x007BB1BA
	public float Radius
	{
		get
		{
			return this.RadiusInternal;
		}
	}

	// Token: 0x17002667 RID: 9831
	// (get) Token: 0x0601BE75 RID: 114293 RVA: 0x007BCFC2 File Offset: 0x007BB1C2
	public float ScaledHalfHeight
	{
		get
		{
			return (float)((double)this.HalfHeightInternal * this.ActorScaleProxy.Z);
		}
	}

	// Token: 0x17002668 RID: 9832
	// (get) Token: 0x0601BE76 RID: 114294 RVA: 0x007BCFD8 File Offset: 0x007BB1D8
	public float HalfHeight
	{
		get
		{
			return this.HalfHeightInternal;
		}
	}

	// Token: 0x17002669 RID: 9833
	// (get) Token: 0x0601BE77 RID: 114295 RVA: 0x007BCFE0 File Offset: 0x007BB1E0
	public float DefaultRadius
	{
		get
		{
			return this.DefaultRadiusInternal;
		}
	}

	// Token: 0x1700266A RID: 9834
	// (get) Token: 0x0601BE78 RID: 114296 RVA: 0x007BCFE8 File Offset: 0x007BB1E8
	public float DefaultHalfHeight
	{
		get
		{
			return this.DefaultHalfHeightInternal;
		}
	}

	// Token: 0x0601BE79 RID: 114297 RVA: 0x007BCFF0 File Offset: 0x007BB1F0
	protected virtual void InitSizeInternal()
	{
	}

	// Token: 0x1700266B RID: 9835
	// (get) Token: 0x0601BE7A RID: 114298 RVA: 0x007BCFF2 File Offset: 0x007BB1F2
	public bool IsAutonomousProxy
	{
		get
		{
			return this.LogicAutonomous;
		}
	}

	// Token: 0x1700266C RID: 9836
	// (get) Token: 0x0601BE7B RID: 114299 RVA: 0x007BCFFA File Offset: 0x007BB1FA
	public bool IsMoveAutonomousProxy
	{
		get
		{
			return this.MoveAutonomous;
		}
	}

	// Token: 0x0601BE7C RID: 114300 RVA: 0x007BD004 File Offset: 0x007BB204
	[NullableContext(2)]
	protected override bool OnCreate(IEntityArgs args = null)
	{
		this.DisableActorHandle = new DisableEntityHandle("SetActorHiddenInGame");
		this.DisableCollisionHandle = new DisableEntityHandle("SetActorEnableCollision");
		base.AddUnResetProperty(new string[]
		{
			"DisableActorHandle",
			"DisableCollisionHandle",
			"DisableTickHandle"
		});
		return true;
	}

	// Token: 0x0601BE7D RID: 114301 RVA: 0x007BD058 File Offset: 0x007BB258
	[NullableContext(2)]
	protected override bool OnInitData(IEntityArgs args = null)
	{
		this.CachedActorForward.Set(1.0, 0.0, 0.0);
		this.CachedActorRight.Set(0.0, 1.0, 0.0);
		this.CachedActorUp.Set(0.0, 0.0, 1.0);
		return true;
	}

	// Token: 0x0601BE7E RID: 114302 RVA: 0x007BD0D8 File Offset: 0x007BB2D8
	protected override bool OnStart()
	{
		this.MoveComp = base.Entity.GetComponent<BaseMoveComponent>();
		this.VehicleMoveComp = base.Entity.GetComponent<VehicleMoveComponent>();
		this.Handle = CreatureModel.Instance.GetEntityById(base.Entity.Id);
		return true;
	}

	// Token: 0x0601BE7F RID: 114303 RVA: 0x007BD118 File Offset: 0x007BB318
	protected override void OnActivate()
	{
		this.ActorInternal.Kuro_SetRole(this.MoveAutonomous ? EKuroNetRole.KURO_ROLE_AutonomousProxy : EKuroNetRole.KURO_ROLE_SimulatedProxy);
		this.LastActorLocation.DeepCopy(this.ActorLocationProxy);
		this.LastActorRotation.DeepCopy(this.ActorRotationProxy);
		this.ActorInternal.SetActorHiddenInGame(!this.DisableActorHandle.Empty);
		this.ActorInternal.SetActorEnableCollision(this.DisableCollisionHandle.Empty);
	}

	// Token: 0x0601BE80 RID: 114304 RVA: 0x007BD18D File Offset: 0x007BB38D
	protected override bool OnEnd()
	{
		this.ClearDebugLocationCube();
		return true;
	}

	// Token: 0x0601BE81 RID: 114305 RVA: 0x007BD196 File Offset: 0x007BB396
	public virtual void SetAutonomous(bool logicAutonomous, bool? moveAutonomous = null)
	{
		this.LogicAutonomous = logicAutonomous;
		this.SetMoveAutonomous(moveAutonomous.GetValueOrDefault(logicAutonomous), "切换逻辑主控");
	}

	// Token: 0x0601BE82 RID: 114306 RVA: 0x007BD1B2 File Offset: 0x007BB3B2
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

	// Token: 0x0601BE83 RID: 114307 RVA: 0x007BD1D7 File Offset: 0x007BB3D7
	public virtual void SetMoveControlled(bool controlled, double maxControlTime = 2.0, string reason = "")
	{
		this.SetMoveAutonomous(controlled, reason);
	}

	// Token: 0x0601BE84 RID: 114308 RVA: 0x007BD1E1 File Offset: 0x007BB3E1
	public virtual void ResetMoveControlled(string reason = "")
	{
		this.SetMoveAutonomous(this.IsAutonomousProxy, reason);
	}

	// Token: 0x0601BE85 RID: 114309 RVA: 0x007BD1F0 File Offset: 0x007BB3F0
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

	// Token: 0x1700266D RID: 9837
	// (get) Token: 0x0601BE86 RID: 114310 RVA: 0x007BD243 File Offset: 0x007BB443
	public CreatureDataComponent CreatureData
	{
		get
		{
			return this.CreatureDataInternal;
		}
	}

	// Token: 0x1700266E RID: 9838
	// (get) Token: 0x0601BE87 RID: 114311 RVA: 0x007BD24B File Offset: 0x007BB44B
	public FQuat ActorQuat
	{
		get
		{
			return this.ActorQuatProxy.ToUeQuat();
		}
	}

	// Token: 0x1700266F RID: 9839
	// (get) Token: 0x0601BE88 RID: 114312 RVA: 0x007BD258 File Offset: 0x007BB458
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

	// Token: 0x17002670 RID: 9840
	// (get) Token: 0x0601BE89 RID: 114313 RVA: 0x007BD2CC File Offset: 0x007BB4CC
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

	// Token: 0x17002671 RID: 9841
	// (get) Token: 0x0601BE8A RID: 114314 RVA: 0x007BD340 File Offset: 0x007BB540
	public FRotator ActorRotation
	{
		get
		{
			return this.ActorRotationProxy.ToUeRotator();
		}
	}

	// Token: 0x17002672 RID: 9842
	// (get) Token: 0x0601BE8B RID: 114315 RVA: 0x007BD350 File Offset: 0x007BB550
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

	// Token: 0x17002673 RID: 9843
	// (get) Token: 0x0601BE8C RID: 114316 RVA: 0x007BD3A0 File Offset: 0x007BB5A0
	public FVectorDouble ActorScale
	{
		get
		{
			return this.ActorScaleProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002674 RID: 9844
	// (get) Token: 0x0601BE8D RID: 114317 RVA: 0x007BD3B0 File Offset: 0x007BB5B0
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

	// Token: 0x17002675 RID: 9845
	// (get) Token: 0x0601BE8E RID: 114318 RVA: 0x007BD410 File Offset: 0x007BB610
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

	// Token: 0x17002676 RID: 9846
	// (get) Token: 0x0601BE8F RID: 114319 RVA: 0x007BD43A File Offset: 0x007BB63A
	public FVectorDouble ActorLocation
	{
		get
		{
			return this.ActorLocationProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002677 RID: 9847
	// (get) Token: 0x0601BE90 RID: 114320 RVA: 0x007BD448 File Offset: 0x007BB648
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

	// Token: 0x0601BE91 RID: 114321 RVA: 0x007BD4B9 File Offset: 0x007BB6B9
	[Conditional("NO_SUPPORT")]
	protected void SetCachedActorLocationWritable(bool canWrite)
	{
		bool isPlayInEditor = GlobalData.IsPlayInEditor;
	}

	// Token: 0x17002678 RID: 9848
	// (get) Token: 0x0601BE92 RID: 114322 RVA: 0x007BD4C1 File Offset: 0x007BB6C1
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

	// Token: 0x17002679 RID: 9849
	// (get) Token: 0x0601BE93 RID: 114323 RVA: 0x007BD4D9 File Offset: 0x007BB6D9
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

	// Token: 0x1700267A RID: 9850
	// (get) Token: 0x0601BE94 RID: 114324 RVA: 0x007BD519 File Offset: 0x007BB719
	public FVectorDouble ActorRight
	{
		get
		{
			return this.ActorRightProxy.ToUeVector(false);
		}
	}

	// Token: 0x1700267B RID: 9851
	// (get) Token: 0x0601BE95 RID: 114325 RVA: 0x007BD527 File Offset: 0x007BB727
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

	// Token: 0x1700267C RID: 9852
	// (get) Token: 0x0601BE96 RID: 114326 RVA: 0x007BD567 File Offset: 0x007BB767
	public FVectorDouble ActorForward
	{
		get
		{
			return this.ActorForwardProxy.ToUeVector(false);
		}
	}

	// Token: 0x1700267D RID: 9853
	// (get) Token: 0x0601BE97 RID: 114327 RVA: 0x007BD575 File Offset: 0x007BB775
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

	// Token: 0x1700267E RID: 9854
	// (get) Token: 0x0601BE98 RID: 114328 RVA: 0x007BD5B5 File Offset: 0x007BB7B5
	public FVectorDouble ActorUp
	{
		get
		{
			return this.ActorUpProxy.ToUeVector(false);
		}
	}

	// Token: 0x1700267F RID: 9855
	// (get) Token: 0x0601BE99 RID: 114329 RVA: 0x007BD5C4 File Offset: 0x007BB7C4
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
					Aki.Protocol.Vector initGravityDirection = this.CreatureData.GetInitGravityDirection();
					if (initGravityDirection != null)
					{
						this.CachedActorGravityDirect.FromConfigVector(initGravityDirection);
					}
				}
			}
			return this.CachedActorGravityDirect;
		}
	}

	// Token: 0x17002680 RID: 9856
	// (get) Token: 0x0601BE9A RID: 114330 RVA: 0x007BD654 File Offset: 0x007BB854
	public FVectorDouble ActorGravityDirection
	{
		get
		{
			return this.ActorGravityDirectProxy.ToUeVector(false);
		}
	}

	// Token: 0x17002681 RID: 9857
	// (get) Token: 0x0601BE9B RID: 114331 RVA: 0x007BD662 File Offset: 0x007BB862
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

	// Token: 0x17002682 RID: 9858
	// (get) Token: 0x0601BE9C RID: 114332 RVA: 0x007BD682 File Offset: 0x007BB882
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

	// Token: 0x17002683 RID: 9859
	// (get) Token: 0x0601BE9D RID: 114333 RVA: 0x007BD698 File Offset: 0x007BB898
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

	// Token: 0x0601BE9E RID: 114334 RVA: 0x007BD6B4 File Offset: 0x007BB8B4
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

	// Token: 0x0601BE9F RID: 114335 RVA: 0x007BD7D6 File Offset: 0x007BB9D6
	public virtual float GetRadius()
	{
		return 0f;
	}

	// Token: 0x17002684 RID: 9860
	// (get) Token: 0x0601BEA0 RID: 114336 RVA: 0x007BD7DD File Offset: 0x007BB9DD
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

	// Token: 0x17002685 RID: 9861
	// (get) Token: 0x0601BEA1 RID: 114337 RVA: 0x007BD800 File Offset: 0x007BBA00
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

	// Token: 0x17002686 RID: 9862
	// (get) Token: 0x0601BEA2 RID: 114338 RVA: 0x007BD84E File Offset: 0x007BBA4E
	public FVector ActorVelocity
	{
		get
		{
			return this.ActorVelocityProxy.ToUeVectorOld();
		}
	}

	// Token: 0x17002687 RID: 9863
	// (get) Token: 0x0601BEA3 RID: 114339 RVA: 0x007BD85B File Offset: 0x007BBA5B
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

	// Token: 0x17002688 RID: 9864
	// (get) Token: 0x0601BEA4 RID: 114340 RVA: 0x007BD87C File Offset: 0x007BBA7C
	[Nullable(2)]
	public virtual USkeletalMeshComponent SkeletalMesh
	{
		[NullableContext(2)]
		get
		{
			return null;
		}
	}

	// Token: 0x0601BEA5 RID: 114341 RVA: 0x007BD87F File Offset: 0x007BBA7F
	public virtual bool HasMesh()
	{
		return false;
	}

	// Token: 0x0601BEA6 RID: 114342 RVA: 0x007BD882 File Offset: 0x007BBA82
	protected virtual void OnTeleport()
	{
		this.LastActorLocation.DeepCopy(this.ActorLocationProxy);
		this.LastActorRotation.DeepCopy(this.ActorRotationProxy);
	}

	// Token: 0x0601BEA7 RID: 114343 RVA: 0x007BD8A8 File Offset: 0x007BBAA8
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

	// Token: 0x0601BEA8 RID: 114344 RVA: 0x007BDA48 File Offset: 0x007BBC48
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

	// Token: 0x0601BEA9 RID: 114345 RVA: 0x007BDBE0 File Offset: 0x007BBDE0
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

	// Token: 0x0601BEAA RID: 114346 RVA: 0x007BDD8F File Offset: 0x007BBF8F
	public void ResetLocationCachedTime()
	{
		this.CachedTransformTime = -1;
		this.CachedLocationTime = -1;
	}

	// Token: 0x0601BEAB RID: 114347 RVA: 0x007BDDA0 File Offset: 0x007BBFA0
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

	// Token: 0x0601BEAC RID: 114348 RVA: 0x007BDE09 File Offset: 0x007BC009
	public void ResetRotationCachedTime()
	{
		this.CachedTransformTime = 0;
		this.CachedRotationTime = 0;
		this.CachedUpTime = 0;
		this.CachedRightTime = 0;
		this.CachedForwardTime = 0;
	}

	// Token: 0x0601BEAD RID: 114349 RVA: 0x007BDE30 File Offset: 0x007BC030
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

	// Token: 0x0601BEAE RID: 114350 RVA: 0x007BDFC4 File Offset: 0x007BC1C4
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

	// Token: 0x0601BEAF RID: 114351 RVA: 0x007BE13C File Offset: 0x007BC33C
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

	// Token: 0x0601BEB0 RID: 114352 RVA: 0x007BE194 File Offset: 0x007BC394
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

	// Token: 0x0601BEB1 RID: 114353 RVA: 0x007BE1EC File Offset: 0x007BC3EC
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

	// Token: 0x0601BEB2 RID: 114354 RVA: 0x007BE244 File Offset: 0x007BC444
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

	// Token: 0x0601BEB3 RID: 114355 RVA: 0x007BE29C File Offset: 0x007BC49C
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

	// Token: 0x0601BEB4 RID: 114356 RVA: 0x007BE310 File Offset: 0x007BC510
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

	// Token: 0x0601BEB5 RID: 114357 RVA: 0x007BE360 File Offset: 0x007BC560
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

	// Token: 0x0601BEB6 RID: 114358 RVA: 0x007BE3B5 File Offset: 0x007BC5B5
	public void ResetCachedVelocityTime()
	{
		this.CachedVelocityTime = -1;
	}

	// Token: 0x0601BEB7 RID: 114359 RVA: 0x007BE3BE File Offset: 0x007BC5BE
	public void ResetGravityRelatedCachedTime()
	{
		this.CachedGravityDirectTime = -1;
	}

	// Token: 0x0601BEB8 RID: 114360 RVA: 0x007BE3C7 File Offset: 0x007BC5C7
	private void SetForbidSettingLocAndRotInternal(bool forbid, EForbidSettingLocAndRotReason reason, HashSet<EForbidSettingLocAndRotReason> target)
	{
		if (forbid)
		{
			target.Add(reason);
			return;
		}
		target.Remove(reason);
	}

	// Token: 0x0601BEB9 RID: 114361 RVA: 0x007BE3E0 File Offset: 0x007BC5E0
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

	// Token: 0x0601BEBA RID: 114362 RVA: 0x007BE448 File Offset: 0x007BC648
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

	// Token: 0x0601BEBB RID: 114363 RVA: 0x007BE530 File Offset: 0x007BC730
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

	// Token: 0x0601BEBC RID: 114364 RVA: 0x007BE5A1 File Offset: 0x007BC7A1
	public void SetSequenceBinding(bool inEnable)
	{
		this.IsInSequenceBinding = inEnable;
	}

	// Token: 0x0601BEBD RID: 114365 RVA: 0x007BE5AA File Offset: 0x007BC7AA
	public bool GetSequenceBinding()
	{
		return this.IsInSequenceBinding;
	}

	// Token: 0x0601BEBE RID: 114366 RVA: 0x007BE5B4 File Offset: 0x007BC7B4
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

	// Token: 0x0601BEBF RID: 114367 RVA: 0x007BE778 File Offset: 0x007BC978
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

	// Token: 0x0601BEC0 RID: 114368 RVA: 0x007BE8E8 File Offset: 0x007BCAE8
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

	// Token: 0x0601BEC1 RID: 114369 RVA: 0x007BEABC File Offset: 0x007BCCBC
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

	// Token: 0x0601BEC2 RID: 114370 RVA: 0x007BEC22 File Offset: 0x007BCE22
	public string DumpDisableActorInfo()
	{
		return this.DisableActorHandle.DumpDisableInfo();
	}

	// Token: 0x0601BEC3 RID: 114371 RVA: 0x007BEC2F File Offset: 0x007BCE2F
	public string DumpDisableCollisionInfo()
	{
		return this.DisableCollisionHandle.DumpDisableInfo();
	}

	// Token: 0x0601BEC4 RID: 114372 RVA: 0x007BEC3C File Offset: 0x007BCE3C
	public string DumpDisableTickInfo()
	{
		UeActorTickManageComponent component = base.Entity.GetComponent<UeActorTickManageComponent>();
		return ((component != null) ? component.DumpDisableTickInfo() : null) ?? "";
	}

	// Token: 0x0601BEC5 RID: 114373 RVA: 0x007BEC60 File Offset: 0x007BCE60
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

	// Token: 0x0601BEC6 RID: 114374 RVA: 0x007BECC0 File Offset: 0x007BCEC0
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

	// Token: 0x0601BEC7 RID: 114375 RVA: 0x007BED20 File Offset: 0x007BCF20
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

	// Token: 0x0601BEC8 RID: 114376 RVA: 0x007BEDA7 File Offset: 0x007BCFA7
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

	// Token: 0x0601BEC9 RID: 114377 RVA: 0x007BEDE0 File Offset: 0x007BCFE0
	public virtual FTransformDouble GetSocketTransform(FName socketName)
	{
		return this.ActorTransform;
	}

	// Token: 0x0601BECA RID: 114378 RVA: 0x007BEDE8 File Offset: 0x007BCFE8
	public virtual FVectorDouble GetSocketLocation(FName socketName)
	{
		return this.ActorLocation;
	}

	// Token: 0x0601BECB RID: 114379 RVA: 0x007BEDF0 File Offset: 0x007BCFF0
	public virtual global::Vector GetWatchedPoint()
	{
		return this.ActorLocationProxy;
	}

	// Token: 0x0601BECC RID: 114380 RVA: 0x007BEDF8 File Offset: 0x007BCFF8
	[return: Nullable(2)]
	public string GetReplaceEffect(string path)
	{
		return this.ReplaceEffectMap.GetValueOrDefault(path);
	}

	// Token: 0x0601BECD RID: 114381 RVA: 0x007BEE06 File Offset: 0x007BD006
	public void SetReplaceEffect(Dictionary<string, string> map)
	{
		this.ReplaceEffectMap = map;
	}

	// Token: 0x0601BECE RID: 114382 RVA: 0x007BEE0F File Offset: 0x007BD00F
	[return: Nullable(2)]
	public string GetReplaceMontage(string path)
	{
		return this.ReplaceMontageMap.GetValueOrDefault(path);
	}

	// Token: 0x0601BECF RID: 114383 RVA: 0x007BEE20 File Offset: 0x007BD020
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

	// Token: 0x0601BED0 RID: 114384 RVA: 0x007BEE8B File Offset: 0x007BD08B
	public static void RegisterDebugCube(AStaticMeshActor cube)
	{
		BaseActorComponent.AllDebugCubes.Add(cube);
		cube.SetActorHiddenInGame(!BaseActorComponent.AllDebugCubesVisible);
	}

	// Token: 0x0601BED1 RID: 114385 RVA: 0x007BEEA7 File Offset: 0x007BD0A7
	public static void UnregisterDebugCube(AStaticMeshActor cube)
	{
		BaseActorComponent.AllDebugCubes.Remove(cube);
	}

	// Token: 0x0601BED2 RID: 114386 RVA: 0x007BEEB8 File Offset: 0x007BD0B8
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

	// Token: 0x0601BED3 RID: 114387 RVA: 0x007BEF34 File Offset: 0x007BD134
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

	// Token: 0x0601BED4 RID: 114388 RVA: 0x007BEF6C File Offset: 0x007BD16C
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

	// Token: 0x0601BED5 RID: 114389 RVA: 0x007BF0D0 File Offset: 0x007BD2D0
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

	// Token: 0x0601BED6 RID: 114390 RVA: 0x007BF170 File Offset: 0x007BD370
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

	// Token: 0x0601BED7 RID: 114391 RVA: 0x007BF220 File Offset: 0x007BD420
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BaseActorComponent baseActorComponent = (BaseActorComponent)componentTemplate;
		if (base.CanResetComponentProperty("MoveComp"))
		{
			if (baseActorComponent.MoveComp == null)
			{
				this.MoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BaseMoveComponent>(this.MoveComp), "MoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("VehicleMoveComp"))
		{
			if (baseActorComponent.VehicleMoveComp == null)
			{
				this.VehicleMoveComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<VehicleMoveComponent>(this.VehicleMoveComp), "VehicleMoveComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorInternal"))
		{
			if (baseActorComponent.ActorInternal == null)
			{
				this.ActorInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AActor>(this.ActorInternal), "ActorInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CachedActorTransform"))
		{
			this.CachedActorTransform = baseActorComponent.CachedActorTransform;
		}
		if (base.CanResetComponentProperty("CachedActorLocation") && baseActorComponent.CachedActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorLocation), "CachedActorLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorRotation") && baseActorComponent.CachedActorRotation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.CachedActorRotation), "CachedActorRotation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorScale") && baseActorComponent.CachedActorScale != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorScale), "CachedActorScale"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorQuat") && baseActorComponent.CachedActorQuat != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<Quat>(this.CachedActorQuat), "CachedActorQuat"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorForward") && baseActorComponent.CachedActorForward != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorForward), "CachedActorForward"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorRight") && baseActorComponent.CachedActorRight != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorRight), "CachedActorRight"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorUp") && baseActorComponent.CachedActorUp != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorUp), "CachedActorUp"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorGravityDirect") && baseActorComponent.CachedActorGravityDirect != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorGravityDirect), "CachedActorGravityDirect"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedActorInitNotStandardGravity"))
		{
			this.CachedActorInitNotStandardGravity = baseActorComponent.CachedActorInitNotStandardGravity;
		}
		if (base.CanResetComponentProperty("CachedActorInitGravityRotation"))
		{
			if (baseActorComponent.CachedActorInitGravityRotation == null)
			{
				this.CachedActorInitGravityRotation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.CachedActorInitGravityRotation), "CachedActorInitGravityRotation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("CachedLocationTime"))
		{
			this.CachedLocationTime = baseActorComponent.CachedLocationTime;
		}
		if (base.CanResetComponentProperty("CachedForwardTime"))
		{
			this.CachedForwardTime = baseActorComponent.CachedForwardTime;
		}
		if (base.CanResetComponentProperty("CachedScaleTime"))
		{
			this.CachedScaleTime = baseActorComponent.CachedScaleTime;
		}
		if (base.CanResetComponentProperty("CachedRotationTime"))
		{
			this.CachedRotationTime = baseActorComponent.CachedRotationTime;
		}
		if (base.CanResetComponentProperty("CachedTransformTime"))
		{
			this.CachedTransformTime = baseActorComponent.CachedTransformTime;
		}
		if (base.CanResetComponentProperty("CachedRightTime"))
		{
			this.CachedRightTime = baseActorComponent.CachedRightTime;
		}
		if (base.CanResetComponentProperty("CachedUpTime"))
		{
			this.CachedUpTime = baseActorComponent.CachedUpTime;
		}
		if (base.CanResetComponentProperty("CachedVelocityTime"))
		{
			this.CachedVelocityTime = baseActorComponent.CachedVelocityTime;
		}
		if (base.CanResetComponentProperty("CachedActorVelocity") && baseActorComponent.CachedActorVelocity != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedActorVelocity), "CachedActorVelocity"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("CachedGravityDirectTime"))
		{
			this.CachedGravityDirectTime = baseActorComponent.CachedGravityDirectTime;
		}
		if (base.CanResetComponentProperty("CachedDesiredActorLocation") && baseActorComponent.CachedDesiredActorLocation != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.CachedDesiredActorLocation), "CachedDesiredActorLocation"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("IsChangingLocation"))
		{
			this.IsChangingLocation = baseActorComponent.IsChangingLocation;
		}
		if (base.CanResetComponentProperty("CreatureDataInternal"))
		{
			if (baseActorComponent.CreatureDataInternal == null)
			{
				this.CreatureDataInternal = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<CreatureDataComponent>(this.CreatureDataInternal), "CreatureDataInternal"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugMovementComp"))
		{
			if (baseActorComponent.DebugMovementComp == null)
			{
				this.DebugMovementComp = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<ActorDebugMovementComponent>(this.DebugMovementComp), "DebugMovementComp"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LogicAutonomous"))
		{
			this.LogicAutonomous = baseActorComponent.LogicAutonomous;
		}
		if (base.CanResetComponentProperty("MoveAutonomous"))
		{
			this.MoveAutonomous = baseActorComponent.MoveAutonomous;
		}
		if (base.CanResetComponentProperty("IsInSequenceBinding"))
		{
			this.IsInSequenceBinding = baseActorComponent.IsInSequenceBinding;
		}
		if (base.CanResetComponentProperty("DisableActorHandle"))
		{
			if (baseActorComponent.DisableActorHandle == null)
			{
				this.DisableActorHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DisableEntityHandle>(this.DisableActorHandle), "DisableActorHandle"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DisableCollisionHandle"))
		{
			if (baseActorComponent.DisableCollisionHandle == null)
			{
				this.DisableCollisionHandle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<DisableEntityHandle>(this.DisableCollisionHandle), "DisableCollisionHandle"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ActorHandleForCommon"))
		{
			this.ActorHandleForCommon = baseActorComponent.ActorHandleForCommon;
		}
		if (base.CanResetComponentProperty("CollisionHandleForCommon"))
		{
			this.CollisionHandleForCommon = baseActorComponent.CollisionHandleForCommon;
		}
		if (base.CanResetComponentProperty("TickHandleForCommon"))
		{
			this.TickHandleForCommon = baseActorComponent.TickHandleForCommon;
		}
		if (base.CanResetComponentProperty("ActorHandleForEntityDisable"))
		{
			this.ActorHandleForEntityDisable = baseActorComponent.ActorHandleForEntityDisable;
		}
		if (base.CanResetComponentProperty("CollisionHandleForEntityDisable"))
		{
			this.CollisionHandleForEntityDisable = baseActorComponent.CollisionHandleForEntityDisable;
		}
		if (base.CanResetComponentProperty("LastActorLocation"))
		{
			if (baseActorComponent.LastActorLocation == null)
			{
				this.LastActorLocation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.LastActorLocation), "LastActorLocation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("LastActorRotation"))
		{
			if (baseActorComponent.LastActorRotation == null)
			{
				this.LastActorRotation = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Rotator>(this.LastActorRotation), "LastActorRotation"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SimulatedVelocity"))
		{
			if (baseActorComponent.SimulatedVelocity == null)
			{
				this.SimulatedVelocity = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<global::Vector>(this.SimulatedVelocity), "SimulatedVelocity"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("SimulatedRotYawSpeed"))
		{
			this.SimulatedRotYawSpeed = baseActorComponent.SimulatedRotYawSpeed;
		}
		if (base.CanResetComponentProperty("Handle"))
		{
			if (baseActorComponent.Handle == null)
			{
				this.Handle = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<EntityHandle>(this.Handle), "Handle"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsRoleAndCtrlByMe"))
		{
			this.IsRoleAndCtrlByMe = baseActorComponent.IsRoleAndCtrlByMe;
		}
		if (base.CanResetComponentProperty("RadiusInternal"))
		{
			this.RadiusInternal = baseActorComponent.RadiusInternal;
		}
		if (base.CanResetComponentProperty("HalfHeightInternal"))
		{
			this.HalfHeightInternal = baseActorComponent.HalfHeightInternal;
		}
		if (base.CanResetComponentProperty("DefaultRadiusInternal"))
		{
			this.DefaultRadiusInternal = baseActorComponent.DefaultRadiusInternal;
		}
		if (base.CanResetComponentProperty("DefaultHalfHeightInternal"))
		{
			this.DefaultHalfHeightInternal = baseActorComponent.DefaultHalfHeightInternal;
		}
		if (base.CanResetComponentProperty("ForbidSettingLocSet") && baseActorComponent.ForbidSettingLocSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForbidSettingLocAndRotReason>(this.ForbidSettingLocSet), "ForbidSettingLocSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("ForbidSettingRotSet") && baseActorComponent.ForbidSettingRotSet != null && !base.CheckClearObject(EntityComponentSystem.ClearObject<EForbidSettingLocAndRotReason>(this.ForbidSettingRotSet), "ForbidSettingRotSet"))
		{
			return false;
		}
		if (base.CanResetComponentProperty("OwnedBasePlatform"))
		{
			if (baseActorComponent.OwnedBasePlatform == null)
			{
				this.OwnedBasePlatform = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<BasePlatform>(this.OwnedBasePlatform), "OwnedBasePlatform"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ReplaceEffectMap"))
		{
			if (baseActorComponent.ReplaceEffectMap == null)
			{
				this.ReplaceEffectMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, string>>(this.ReplaceEffectMap), "ReplaceEffectMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("ReplaceMontageMap"))
		{
			if (baseActorComponent.ReplaceMontageMap == null)
			{
				this.ReplaceMontageMap = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<Dictionary<string, string>>(this.ReplaceMontageMap), "ReplaceMontageMap"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugPositionCube"))
		{
			if (baseActorComponent.DebugPositionCube == null)
			{
				this.DebugPositionCube = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AStaticMeshActor>(this.DebugPositionCube), "DebugPositionCube"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugFootCube"))
		{
			if (baseActorComponent.DebugFootCube == null)
			{
				this.DebugFootCube = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AStaticMeshActor>(this.DebugFootCube), "DebugFootCube"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("DebugForwardCube"))
		{
			if (baseActorComponent.DebugForwardCube == null)
			{
				this.DebugForwardCube = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<AStaticMeshActor>(this.DebugForwardCube), "DebugForwardCube"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0601BEDA RID: 114394 RVA: 0x007BFCE0 File Offset: 0x007BDEE0
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

	// Token: 0x0400DC37 RID: 56375
	[Nullable(2)]
	public BaseMoveComponent MoveComp;

	// Token: 0x0400DC38 RID: 56376
	[Nullable(2)]
	public VehicleMoveComponent VehicleMoveComp;

	// Token: 0x0400DC39 RID: 56377
	[Nullable(2)]
	protected AActor ActorInternal;

	// Token: 0x0400DC3A RID: 56378
	protected FTransformDouble? CachedActorTransform;

	// Token: 0x0400DC3B RID: 56379
	protected readonly global::Vector CachedActorLocation = global::Vector.Create();

	// Token: 0x0400DC3C RID: 56380
	protected readonly global::Rotator CachedActorRotation = global::Rotator.Create(0f, 0f, 0f);

	// Token: 0x0400DC3D RID: 56381
	protected readonly global::Vector CachedActorScale = global::Vector.Create();

	// Token: 0x0400DC3E RID: 56382
	protected readonly Quat CachedActorQuat = Quat.Create(0.0, 0.0, 0.0, 1.0);

	// Token: 0x0400DC3F RID: 56383
	protected readonly global::Vector CachedActorForward = global::Vector.Create(1.0, 0.0, 0.0);

	// Token: 0x0400DC40 RID: 56384
	protected readonly global::Vector CachedActorRight = global::Vector.Create(0.0, 1.0, 0.0);

	// Token: 0x0400DC41 RID: 56385
	protected readonly global::Vector CachedActorUp = global::Vector.Create(0.0, 0.0, 1.0);

	// Token: 0x0400DC42 RID: 56386
	protected readonly global::Vector CachedActorGravityDirect = global::Vector.Create(0.0, 0.0, -1.0);

	// Token: 0x0400DC43 RID: 56387
	protected bool? CachedActorInitNotStandardGravity;

	// Token: 0x0400DC44 RID: 56388
	[Nullable(2)]
	protected global::Rotator CachedActorInitGravityRotation;

	// Token: 0x0400DC45 RID: 56389
	protected int CachedLocationTime = -1;

	// Token: 0x0400DC46 RID: 56390
	protected int CachedForwardTime = -1;

	// Token: 0x0400DC47 RID: 56391
	protected int CachedScaleTime = -1;

	// Token: 0x0400DC48 RID: 56392
	protected int CachedRotationTime = -1;

	// Token: 0x0400DC49 RID: 56393
	protected int CachedTransformTime = -1;

	// Token: 0x0400DC4A RID: 56394
	protected int CachedRightTime = -1;

	// Token: 0x0400DC4B RID: 56395
	protected int CachedUpTime = -1;

	// Token: 0x0400DC4C RID: 56396
	protected int CachedVelocityTime = -1;

	// Token: 0x0400DC4D RID: 56397
	protected readonly global::Vector CachedActorVelocity = global::Vector.Create(0.0, 0.0, 0.0);

	// Token: 0x0400DC4E RID: 56398
	protected int CachedGravityDirectTime = -1;

	// Token: 0x0400DC4F RID: 56399
	protected readonly global::Vector CachedDesiredActorLocation = global::Vector.Create();

	// Token: 0x0400DC50 RID: 56400
	protected bool IsChangingLocation;

	// Token: 0x0400DC51 RID: 56401
	[Nullable(2)]
	protected CreatureDataComponent CreatureDataInternal;

	// Token: 0x0400DC52 RID: 56402
	[Nullable(2)]
	public ActorDebugMovementComponent DebugMovementComp;

	// Token: 0x0400DC53 RID: 56403
	private bool LogicAutonomous = true;

	// Token: 0x0400DC54 RID: 56404
	private bool MoveAutonomous = true;

	// Token: 0x0400DC55 RID: 56405
	protected bool IsInSequenceBinding;

	// Token: 0x0400DC56 RID: 56406
	[Nullable(2)]
	public DisableEntityHandle DisableActorHandle;

	// Token: 0x0400DC57 RID: 56407
	[Nullable(2)]
	public DisableEntityHandle DisableCollisionHandle;

	// Token: 0x0400DC58 RID: 56408
	private int? ActorHandleForCommon;

	// Token: 0x0400DC59 RID: 56409
	private int? CollisionHandleForCommon;

	// Token: 0x0400DC5A RID: 56410
	private int? TickHandleForCommon;

	// Token: 0x0400DC5B RID: 56411
	private int? ActorHandleForEntityDisable;

	// Token: 0x0400DC5C RID: 56412
	private int? CollisionHandleForEntityDisable;

	// Token: 0x0400DC5D RID: 56413
	public global::Vector LastActorLocation = global::Vector.Create();

	// Token: 0x0400DC5E RID: 56414
	public global::Rotator LastActorRotation = global::Rotator.Create();

	// Token: 0x0400DC5F RID: 56415
	public global::Vector SimulatedVelocity = global::Vector.Create();

	// Token: 0x0400DC60 RID: 56416
	public float SimulatedRotYawSpeed;

	// Token: 0x0400DC61 RID: 56417
	[Nullable(2)]
	private EntityHandle Handle;

	// Token: 0x0400DC62 RID: 56418
	public bool IsRoleAndCtrlByMe;

	// Token: 0x0400DC63 RID: 56419
	protected float RadiusInternal;

	// Token: 0x0400DC64 RID: 56420
	protected float HalfHeightInternal;

	// Token: 0x0400DC65 RID: 56421
	protected float DefaultRadiusInternal;

	// Token: 0x0400DC66 RID: 56422
	protected float DefaultHalfHeightInternal;

	// Token: 0x0400DC67 RID: 56423
	private readonly HashSet<EForbidSettingLocAndRotReason> ForbidSettingLocSet = new HashSet<EForbidSettingLocAndRotReason>();

	// Token: 0x0400DC68 RID: 56424
	private readonly HashSet<EForbidSettingLocAndRotReason> ForbidSettingRotSet = new HashSet<EForbidSettingLocAndRotReason>();

	// Token: 0x0400DC69 RID: 56425
	[Nullable(2)]
	public BasePlatform OwnedBasePlatform;

	// Token: 0x0400DC6A RID: 56426
	public Dictionary<string, string> ReplaceEffectMap = new Dictionary<string, string>();

	// Token: 0x0400DC6B RID: 56427
	public Dictionary<string, string> ReplaceMontageMap = new Dictionary<string, string>();

	// Token: 0x0400DC6C RID: 56428
	[StaticVariableRuleIgnore]
	private static readonly HashSet<AStaticMeshActor> AllDebugCubes = new HashSet<AStaticMeshActor>();

	// Token: 0x0400DC6D RID: 56429
	[StaticVariableRuleIgnore]
	private static bool AllDebugCubesVisible = false;

	// Token: 0x0400DC6E RID: 56430
	[Nullable(2)]
	[StaticVariableRuleIgnore]
	private static UMaterialInterface DebugCubeMaterialCache = null;

	// Token: 0x0400DC6F RID: 56431
	[Nullable(2)]
	private AStaticMeshActor DebugPositionCube;

	// Token: 0x0400DC70 RID: 56432
	[Nullable(2)]
	private AStaticMeshActor DebugFootCube;

	// Token: 0x0400DC71 RID: 56433
	[Nullable(2)]
	private AStaticMeshActor DebugForwardCube;
}
