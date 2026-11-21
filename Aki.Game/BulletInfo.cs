using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x0200236D RID: 9069
[NullableContext(2)]
[Nullable(0)]
public class BulletInfo : IStaticVariableResetter
{
	// Token: 0x06016572 RID: 91506 RVA: 0x00680D6C File Offset: 0x0067EF6C
	static BulletInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletInfo.CreateStaticDefaultValue), new Action(BulletInfo.ResetStaticDefaultValue));
	}

	// Token: 0x170022B8 RID: 8888
	// (get) Token: 0x06016573 RID: 91507 RVA: 0x00680D8B File Offset: 0x0067EF8B
	public int BulletEntityId
	{
		get
		{
			return this.Id;
		}
	}

	// Token: 0x170022B9 RID: 8889
	// (get) Token: 0x06016574 RID: 91508 RVA: 0x00680D93 File Offset: 0x0067EF93
	public bool HasCheckedPosition
	{
		get
		{
			return this.HasCheckedPositionInternal;
		}
	}

	// Token: 0x06016575 RID: 91509 RVA: 0x00680D9B File Offset: 0x0067EF9B
	public void CheckedPosition()
	{
		this.HasCheckedPositionInternal = true;
	}

	// Token: 0x170022BA RID: 8890
	// (get) Token: 0x06016576 RID: 91510 RVA: 0x00680DA4 File Offset: 0x0067EFA4
	[Nullable(1)]
	public BulletInitParams BulletInitParams
	{
		[NullableContext(1)]
		get
		{
			return this.InitParams;
		}
	}

	// Token: 0x170022BB RID: 8891
	// (get) Token: 0x06016577 RID: 91511 RVA: 0x00680DAC File Offset: 0x0067EFAC
	public FTransformDouble? TransformCreate
	{
		get
		{
			return this.InitParams.InitialTransform;
		}
	}

	// Token: 0x170022BC RID: 8892
	// (get) Token: 0x06016578 RID: 91512 RVA: 0x00680DB9 File Offset: 0x0067EFB9
	public int BaseVelocityEntityId
	{
		get
		{
			return this.InitParams.BaseVelocityId;
		}
	}

	// Token: 0x170022BD RID: 8893
	// (get) Token: 0x06016579 RID: 91513 RVA: 0x00680DC6 File Offset: 0x0067EFC6
	[Nullable(1)]
	public string BulletRowName
	{
		[NullableContext(1)]
		get
		{
			return this.InitParams.BulletRowName;
		}
	}

	// Token: 0x0601657A RID: 91514 RVA: 0x00680DD3 File Offset: 0x0067EFD3
	public BaseActorComponent GetBaseVelocityTarget()
	{
		Entity entity = EntitySystem.Instance.Get(this.InitParams.BaseVelocityId);
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseActorComponent>();
	}

	// Token: 0x170022BE RID: 8894
	// (get) Token: 0x0601657B RID: 91515 RVA: 0x00680DF5 File Offset: 0x0067EFF5
	public BulletDataMain BulletDataMain
	{
		get
		{
			return this.Config;
		}
	}

	// Token: 0x170022BF RID: 8895
	// (get) Token: 0x0601657C RID: 91516 RVA: 0x00680DFD File Offset: 0x0067EFFD
	public bool IsTensile
	{
		get
		{
			BulletDataMain bulletDataMain = this.BulletDataMain;
			return bulletDataMain != null && bulletDataMain.Move.FollowType == EBulletFollowType.攻击者锁定拉伸;
		}
	}

	// Token: 0x170022C0 RID: 8896
	// (get) Token: 0x0601657D RID: 91517 RVA: 0x00680E18 File Offset: 0x0067F018
	public EntityHandle BaseTransformEntity
	{
		get
		{
			if (!this.BaseTransformEntityHasInit && this.BaseTransformEntityInternal == null)
			{
				EntityHandle handle = CharacterModel.Instance.GetHandle(this.InitParams.BaseTransformId);
				if (handle != null && handle.Valid)
				{
					this.BaseTransformEntityInternal = handle;
				}
				this.BaseTransformEntityHasInit = true;
			}
			return this.BaseTransformEntityInternal;
		}
	}

	// Token: 0x0601657E RID: 91518 RVA: 0x00680E6C File Offset: 0x0067F06C
	[NullableContext(1)]
	public void SetActorLocation(global::Vector value)
	{
		if (double.IsNaN(value.X) || double.IsNaN(value.Y) || double.IsNaN(value.Z))
		{
			BulletController.Instance.DestroyBullet(this.BulletEntityId, false, EBulletDestroyReason.Normal, false);
			return;
		}
		this.LocationCache.FromUeVector(value);
		this.IsCacheLocation = true;
	}

	// Token: 0x0601657F RID: 91519 RVA: 0x00680EC8 File Offset: 0x0067F0C8
	[NullableContext(1)]
	public void SetActorRotation(global::Rotator value)
	{
		if (float.IsNaN(value.Pitch) || float.IsNaN(value.Yaw) || float.IsNaN(value.Roll))
		{
			BulletController.Instance.DestroyBullet(this.BulletEntityId, false, EBulletDestroyReason.Normal, false);
			return;
		}
		this.RotationCache.FromUeRotator(value);
		this.IsCacheRotation = true;
	}

	// Token: 0x06016580 RID: 91520 RVA: 0x00680F23 File Offset: 0x0067F123
	[NullableContext(1)]
	public global::Vector GetActorLocation()
	{
		if (this.IsCacheLocation)
		{
			return this.LocationCache;
		}
		return this.ActorComponent.ActorLocationProxy;
	}

	// Token: 0x06016581 RID: 91521 RVA: 0x00680F3F File Offset: 0x0067F13F
	[NullableContext(1)]
	public global::Rotator GetActorRotation()
	{
		if (this.IsCacheRotation)
		{
			return this.RotationCache;
		}
		return this.ActorComponent.ActorRotationProxy;
	}

	// Token: 0x06016582 RID: 91522 RVA: 0x00680F5B File Offset: 0x0067F15B
	[NullableContext(1)]
	public void GetActorForward(global::Vector outVector)
	{
		if (this.IsCacheRotation)
		{
			this.RotationCache.Vector(outVector);
			return;
		}
		outVector.FromUeVector(this.ActorComponent.ActorForwardProxy);
	}

	// Token: 0x06016583 RID: 91523 RVA: 0x00680F83 File Offset: 0x0067F183
	[NullableContext(1)]
	public void ActorRotateVector(global::Vector inVector, global::Vector outVector)
	{
		if (this.IsCacheRotation)
		{
			this.RotationCache.Quaternion(null).RotateVector(inVector, outVector);
			return;
		}
		this.ActorComponent.ActorRotationProxy.Quaternion(null).RotateVector(inVector, outVector);
	}

	// Token: 0x06016584 RID: 91524 RVA: 0x00680FB9 File Offset: 0x0067F1B9
	public void AddBulletLocalRotator(FRotator newRotator)
	{
		this.ApplyCacheLocationAndRotation();
		this.ActorComponent.AddBulletLocalRotator(newRotator);
	}

	// Token: 0x06016585 RID: 91525 RVA: 0x00680FD0 File Offset: 0x0067F1D0
	public void ApplyCacheLocationAndRotation()
	{
		if (!this.IsCacheLocation)
		{
			if (this.IsCacheRotation)
			{
				this.ActorComponent.SetActorRotation(this.RotationCache.ToUeRotator(), base.GetType().Name, false);
				this.IsCacheRotation = false;
				this.GetCollisionLocationFrame = 0;
			}
			return;
		}
		if (this.IsCacheRotation)
		{
			this.ActorComponent.SetActorLocationAndRotation(this.LocationCache.ToUeVector(false), this.RotationCache.ToUeRotator(), base.GetType().Name, false, null);
			this.IsCacheLocation = false;
			this.IsCacheRotation = false;
			this.GetCollisionLocationFrame = 0;
			return;
		}
		this.ActorComponent.SetActorLocation(this.LocationCache.ToUeVector(false), base.GetType().Name, false);
		this.IsCacheLocation = false;
		this.GetCollisionLocationFrame = 0;
	}

	// Token: 0x06016586 RID: 91526 RVA: 0x006810AA File Offset: 0x0067F2AA
	public void ClearCacheLocationAndRotation()
	{
		this.IsCacheLocation = false;
		this.IsCacheRotation = false;
	}

	// Token: 0x170022C1 RID: 8897
	// (get) Token: 0x06016587 RID: 91527 RVA: 0x006810BA File Offset: 0x0067F2BA
	[Nullable(1)]
	public IReadOnlyList<int> Tags
	{
		[NullableContext(1)]
		get
		{
			return this.TagInternal;
		}
	}

	// Token: 0x06016588 RID: 91528 RVA: 0x006810C2 File Offset: 0x0067F2C2
	public void AddTag(FGameplayTag tag)
	{
		this.TagInternal.Add(tag.TagId());
	}

	// Token: 0x06016589 RID: 91529 RVA: 0x006810D5 File Offset: 0x0067F2D5
	public void AddTagId(int tagId)
	{
		this.TagInternal.Add(tagId);
	}

	// Token: 0x0601658A RID: 91530 RVA: 0x006810E4 File Offset: 0x0067F2E4
	public bool HasTag(FGameplayTag newTag)
	{
		if (this.TagInternal.Count > 0)
		{
			using (List<int>.Enumerator enumerator = this.TagInternal.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current == newTag.TagId())
					{
						return true;
					}
				}
			}
			return false;
		}
		return false;
	}

	// Token: 0x0601658B RID: 91531 RVA: 0x0068114C File Offset: 0x0067F34C
	public bool HasTagId(int newTagId)
	{
		List<int> tagInternal = this.TagInternal;
		return tagInternal != null && tagInternal.Contains(newTagId);
	}

	// Token: 0x170022C2 RID: 8898
	// (get) Token: 0x0601658C RID: 91532 RVA: 0x00681160 File Offset: 0x0067F360
	[Nullable(1)]
	public global::Vector CenterLocation
	{
		[NullableContext(1)]
		get
		{
			this.ActorComponent.ActorQuatProxy.RotateVector(this.CollisionInfo.CenterLocalLocation, this.CenterLocationInternal);
			this.CenterLocationInternal.AdditionEqual(this.ActorComponent.ActorLocationProxy);
			return this.CenterLocationInternal;
		}
	}

	// Token: 0x170022C3 RID: 8899
	// (get) Token: 0x0601658D RID: 91533 RVA: 0x006811A0 File Offset: 0x0067F3A0
	[Nullable(1)]
	public BulletRayInfo RayInfo
	{
		[NullableContext(1)]
		get
		{
			if (this.RayInfoInternal == null)
			{
				this.RayInfoInternal = new BulletRayInfo();
			}
			return this.RayInfoInternal;
		}
	}

	// Token: 0x170022C4 RID: 8900
	// (get) Token: 0x0601658E RID: 91534 RVA: 0x006811BB File Offset: 0x0067F3BB
	public FRotator CollisionRotator
	{
		get
		{
			UPrimitiveComponent collisionComponent = this.CollisionInfo.CollisionComponent;
			if (collisionComponent == null)
			{
				return this.ActorComponent.ActorRotation;
			}
			return collisionComponent.K2_GetComponentRotation();
		}
	}

	// Token: 0x0601658F RID: 91535 RVA: 0x006811E0 File Offset: 0x0067F3E0
	[NullableContext(1)]
	public unsafe global::Vector GetCollisionLocation(bool checkInAfterTick = true)
	{
		if (checkInAfterTick && !BulletInfo.InAfterTick)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "GetCollisionLocation只能在AfterTick中使用";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletEntityId", this.BulletEntityId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BulletRowName", this.BulletRowName);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return this.CollisionLocationInternal;
		}
		if (this.GetCollisionLocationFrame < Time.Instance.Frame)
		{
			this.GetCollisionLocationFrame = Time.Instance.Frame;
			if (!this.IsCollisionRelativeLocationZero && this.CollisionInfo.CollisionComponent != null)
			{
				global::Vector collisionLocationInternal = this.CollisionLocationInternal;
				FVectorDouble fvectorDouble = this.CollisionInfo.CollisionComponent.D_K2_GetComponentLocation();
				collisionLocationInternal.FromUeVector(fvectorDouble);
			}
			else
			{
				this.CollisionLocationInternal.FromUeVector(this.ActorComponent.ActorLocationProxy);
			}
		}
		return this.CollisionLocationInternal;
	}

	// Token: 0x170022C5 RID: 8901
	// (get) Token: 0x06016590 RID: 91536 RVA: 0x006812D3 File Offset: 0x0067F4D3
	public int AttackerId
	{
		get
		{
			return this.AttackerIdInternal;
		}
	}

	// Token: 0x170022C6 RID: 8902
	// (get) Token: 0x06016591 RID: 91537 RVA: 0x006812DB File Offset: 0x0067F4DB
	public EntityHandle AttackerHandle
	{
		get
		{
			return this.AttackerInternal;
		}
	}

	// Token: 0x170022C7 RID: 8903
	// (get) Token: 0x06016592 RID: 91538 RVA: 0x006812E3 File Offset: 0x0067F4E3
	public Entity Attacker
	{
		get
		{
			EntityHandle attackerInternal = this.AttackerInternal;
			if (attackerInternal == null)
			{
				return null;
			}
			return attackerInternal.Entity;
		}
	}

	// Token: 0x06016593 RID: 91539 RVA: 0x006812F6 File Offset: 0x0067F4F6
	private void ClearAttacker()
	{
		this.AttackerInternal = null;
		this.AttackerCreatureDataCompInternal = null;
		this.AttackerActorCompInternal = null;
		this.AttackerSkillCompInternal = null;
		this.AttackerBuffCompInternal = null;
		this.AttackerMoveCompInternal = null;
		this.AttackerAudioCompInternal = null;
		this.AttackerTagCompInternal = null;
	}

	// Token: 0x170022C8 RID: 8904
	// (get) Token: 0x06016594 RID: 91540 RVA: 0x00681330 File Offset: 0x0067F530
	public CreatureDataComponent AttackerCreatureDataComp
	{
		get
		{
			if (this.AttackerCreatureDataCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerCreatureDataCompInternal = ((attacker != null) ? attacker.GetComponent<CreatureDataComponent>() : null);
			}
			return this.AttackerCreatureDataCompInternal;
		}
	}

	// Token: 0x170022C9 RID: 8905
	// (get) Token: 0x06016595 RID: 91541 RVA: 0x00681358 File Offset: 0x0067F558
	public BaseActorComponent AttackerActorComp
	{
		get
		{
			if (this.AttackerActorCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerActorCompInternal = ((attacker != null) ? attacker.GetComponent<BaseActorComponent>() : null);
			}
			return this.AttackerActorCompInternal;
		}
	}

	// Token: 0x170022CA RID: 8906
	// (get) Token: 0x06016596 RID: 91542 RVA: 0x00681380 File Offset: 0x0067F580
	public BaseSkillComponent AttackerSkillComp
	{
		get
		{
			if (this.AttackerSkillCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerSkillCompInternal = ((attacker != null) ? attacker.GetComponent<BaseSkillComponent>() : null);
			}
			return this.AttackerSkillCompInternal;
		}
	}

	// Token: 0x170022CB RID: 8907
	// (get) Token: 0x06016597 RID: 91543 RVA: 0x006813A8 File Offset: 0x0067F5A8
	public BaseBuffComponent AttackerBuffComp
	{
		get
		{
			if (this.AttackerBuffCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerBuffCompInternal = ((attacker != null) ? attacker.GetComponent<BaseBuffComponent>() : null);
			}
			return this.AttackerBuffCompInternal;
		}
	}

	// Token: 0x170022CC RID: 8908
	// (get) Token: 0x06016598 RID: 91544 RVA: 0x006813D0 File Offset: 0x0067F5D0
	public CharacterMoveComponent AttackerMoveComp
	{
		get
		{
			if (this.AttackerMoveCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerMoveCompInternal = ((attacker != null) ? attacker.GetComponent<CharacterMoveComponent>() : null);
			}
			return this.AttackerMoveCompInternal;
		}
	}

	// Token: 0x170022CD RID: 8909
	// (get) Token: 0x06016599 RID: 91545 RVA: 0x006813F8 File Offset: 0x0067F5F8
	public CharacterAudioComponent AttackerAudioComponent
	{
		get
		{
			if (this.AttackerAudioCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerAudioCompInternal = ((attacker != null) ? attacker.GetComponent<CharacterAudioComponent>() : null);
			}
			return this.AttackerAudioCompInternal;
		}
	}

	// Token: 0x170022CE RID: 8910
	// (get) Token: 0x0601659A RID: 91546 RVA: 0x00681420 File Offset: 0x0067F620
	public BaseTagComponent AttackerTagComponent
	{
		get
		{
			if (this.AttackerTagCompInternal == null)
			{
				Entity attacker = this.Attacker;
				this.AttackerTagCompInternal = ((attacker != null) ? attacker.GetComponent<BaseTagComponent>() : null);
			}
			return this.AttackerTagCompInternal;
		}
	}

	// Token: 0x170022CF RID: 8911
	// (get) Token: 0x0601659B RID: 91547 RVA: 0x00681448 File Offset: 0x0067F648
	public Entity Target
	{
		get
		{
			if (this.TargetIsEntityInternal)
			{
				return EntitySystem.Instance.Get(this.TargetId);
			}
			if (this.TargetInternal == null)
			{
				return null;
			}
			EntityHandle targetInternal = this.TargetInternal;
			if (targetInternal == null)
			{
				return null;
			}
			return targetInternal.Entity;
		}
	}

	// Token: 0x0601659C RID: 91548 RVA: 0x00681480 File Offset: 0x0067F680
	public void SetTargetById(int entityId)
	{
		EntityHandle handle = CharacterModel.Instance.GetHandle(entityId);
		if (handle != null && handle.Valid)
		{
			this.RemoveTargetRemoveEvent();
			this.TargetId = entityId;
			this.TargetInternal = handle;
			this.TargetIsEntityInternal = false;
			this.TargetActorCompInternal = null;
			this.AddTargetRemoveEvent();
			return;
		}
		this.ClearTarget();
		Entity entity = EntitySystem.Instance.Get(entityId);
		if (entity != null && entity.Valid)
		{
			this.TargetId = entityId;
			this.TargetIsEntityInternal = true;
		}
	}

	// Token: 0x0601659D RID: 91549 RVA: 0x006814FA File Offset: 0x0067F6FA
	public void ClearTarget()
	{
		this.RemoveTargetRemoveEvent();
		this.TargetInternal = null;
		this.TargetId = 0;
		this.TargetActorCompInternal = null;
		this.TargetIsEntityInternal = false;
	}

	// Token: 0x170022D0 RID: 8912
	// (get) Token: 0x0601659E RID: 91550 RVA: 0x00681520 File Offset: 0x0067F720
	public BaseActorComponent TargetActorComp
	{
		get
		{
			if (this.TargetIsEntityInternal)
			{
				return EntitySystem.Instance.GetComponent<BaseActorComponent>(this.TargetId);
			}
			if (this.TargetActorCompInternal == null)
			{
				Entity target = this.Target;
				this.TargetActorCompInternal = ((target != null) ? target.GetComponent<BaseActorComponent>() : null);
			}
			return this.TargetActorCompInternal;
		}
	}

	// Token: 0x0601659F RID: 91551 RVA: 0x0068156C File Offset: 0x0067F76C
	public BaseActorComponent GetLockOnTargetDynamic()
	{
		EntityHandle attackerInternal = this.AttackerInternal;
		object obj;
		if (attackerInternal == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = attackerInternal.Entity;
			if (entity == null)
			{
				obj = null;
			}
			else
			{
				CharacterLockOnComponent component = entity.GetComponent<CharacterLockOnComponent>();
				obj = ((component != null) ? component.GetCurrentTarget() : null);
			}
		}
		object obj2 = obj;
		if (obj2 == null)
		{
			return null;
		}
		WorldEntity entity2 = obj2.Entity;
		if (entity2 == null)
		{
			return null;
		}
		return entity2.GetComponent<BaseActorComponent>();
	}

	// Token: 0x170022D1 RID: 8913
	// (get) Token: 0x060165A0 RID: 91552 RVA: 0x006815B9 File Offset: 0x0067F7B9
	public int ParentEntityId
	{
		get
		{
			return this.InitParams.ParentId;
		}
	}

	// Token: 0x170022D2 RID: 8914
	// (get) Token: 0x060165A1 RID: 91553 RVA: 0x006815C6 File Offset: 0x0067F7C6
	// (set) Token: 0x060165A2 RID: 91554 RVA: 0x006815DC File Offset: 0x0067F7DC
	public long? ContextId
	{
		get
		{
			if (!this.ContextIdSubmitted)
			{
				this.ReportContextIdNotSubmitted();
			}
			return this.ContextIdInternal;
		}
		set
		{
			this.ContextIdInternal = value;
		}
	}

	// Token: 0x170022D3 RID: 8915
	// (get) Token: 0x060165A3 RID: 91555 RVA: 0x006815E5 File Offset: 0x0067F7E5
	public long? ContextIdRaw
	{
		get
		{
			return this.ContextIdInternal;
		}
	}

	// Token: 0x060165A4 RID: 91556 RVA: 0x006815F0 File Offset: 0x0067F7F0
	private void ReportContextIdNotSubmitted()
	{
	}

	// Token: 0x060165A5 RID: 91557 RVA: 0x00681600 File Offset: 0x0067F800
	[NullableContext(1)]
	public void Init(BulletInitParams initParams, BulletDataMain config)
	{
		this.InitParams = initParams;
		this.Config = config;
		this.ActionInfoList.Clear();
		this.NextActionInfoList.Clear();
		this.PersistentActionList.Clear();
		Entity owner = this.InitParams.Owner;
		this.AttackerIdInternal = ((owner != null) ? owner.Id : 0);
		this.AttackerInternal = CharacterModel.Instance.GetHandle(this.AttackerIdInternal);
		this.IsInit = false;
		this.NeedDestroy = false;
		this.ShakeNumbers = 0;
		this.HitNumberAll = 0;
		this.GetCollisionLocationFrame = 0;
		this.SkillBoneName = new FName?(BulletConstant.Instance.HitCase);
		this.PreContextId = null;
		this.ContextId = null;
		this.ContextIdSubmitted = false;
		if (initParams.LocationOffset != null)
		{
			global::Vector bornLocationOffset = this.BornLocationOffset;
			FVector value = initParams.LocationOffset.Value;
			bornLocationOffset.FromUeVector(value);
			this.BornLocationOffset.AdditionEqual(config.Base.BornPosition);
		}
		else
		{
			this.BornLocationOffset.FromUeVector(config.Base.BornPosition);
		}
		if (PerformanceController.Instance.IsEntityTickPerformanceTest)
		{
			this.BornFrameCount = new long?(UKismetSystemLibrary.GetFrameCount());
		}
	}

	// Token: 0x060165A6 RID: 91558 RVA: 0x0068173A File Offset: 0x0067F93A
	[NullableContext(1)]
	public void InitEntity(BulletEntity entity)
	{
		this.Entity = entity;
		this.Id = entity.Id;
	}

	// Token: 0x060165A7 RID: 91559 RVA: 0x00681750 File Offset: 0x0067F950
	public void Clear()
	{
		this.Id = 0;
		this.Entity = null;
		this.InitParams = null;
		this.Config = null;
		BulletActionCenter bulletActionCenter = this.ActionCenter ?? BulletController.Instance.GetActionCenter();
		foreach (BulletActionInfoBase actionInfo in this.ActionInfoList)
		{
			bulletActionCenter.RecycleBulletActionInfo(actionInfo);
		}
		foreach (BulletActionInfoBase actionInfo2 in this.NextActionInfoList)
		{
			bulletActionCenter.RecycleBulletActionInfo(actionInfo2);
		}
		foreach (BulletActionBase action in this.PersistentActionList)
		{
			bulletActionCenter.RecycleBulletAction(action);
		}
		this.ActionInfoList.Clear();
		this.NextActionInfoList.Clear();
		this.PersistentActionList.Clear();
		this.ActionCenter = null;
		this.Actor = null;
		this.ActorComponent = null;
		this.ActionLogicComponent = null;
		this.IsInit = false;
		this.HasCheckedPositionInternal = false;
		this.NeedDestroy = false;
		this.IsDestroyByCharSkillEnd = false;
		this.GenerateTime = 0f;
		this.BulletCamp = 0;
		this.BaseTransformEntityInternal = null;
		this.IsCacheLocation = false;
		this.IsCacheRotation = false;
		this.LocationCache.Reset();
		this.RotationCache.Reset();
		this.RandomInitSpeedOffset.Reset();
		this.RandomPosOffset.Reset();
		this.ShakeNumbers = 0;
		this.IsFrozen = false;
		this.FrozenTime = null;
		this.IsShield = false;
		this.InitPosition.Reset();
		this.TagInternal.Clear();
		this.CreateFrame = 0;
		this.LiveTimeAddDelta = 0f;
		this.LiveTime = 0f;
		this.IsTimeNotEnough = false;
		this.BaseSize.Reset();
		this.Size.Reset();
		this.CenterLocationInternal.Reset();
		this.CloseCollision = false;
		this.CollisionLocationInternal.Reset();
		this.GetCollisionLocationFrame = 0;
		this.IsCollisionRelativeLocationZero = false;
		this.IsCollisionRelativeRotationModify = false;
		this.AttackerIdInternal = 0;
		this.ClearAttacker();
		this.IsAutonomousProxy = false;
		this.AttackerCamp = ECamp.Player;
		this.AttackerPlayerId = 0;
		this.SkillBoneName = null;
		this.SkillLevel = 0;
		this.ClearTarget();
		this.TargetIdLast = 0;
		this.TargetIsEntityInternal = false;
		this.ParentBulletInfo = null;
		this.ChildEntityIds = null;
		this.ParentEffect = 0;
		this.NeedNotifyChildrenWhenDestroy = false;
		this.HitNumberAll = 0;
		this.EntityHitSet.Clear();
		this.EntityHitCount.Clear();
		this.CountByParent = false;
		this.TimeScaleList = null;
		this.TimeScaleMap = null;
		this.TimeScaleId = 0;
		this.SummonSkillId = 0;
		this.SummonAttackerId = 0;
		this.SummonServerEntityId = 0L;
		this.CollisionInfo.Clear();
		BulletKuroFastCollisionInfo kuroFastCollisionInfo = this.KuroFastCollisionInfo;
		if (kuroFastCollisionInfo != null)
		{
			kuroFastCollisionInfo.Clear();
		}
		this.KuroFastCollisionInfo = null;
		this.MoveInfo.Clear();
		BulletStaticFunction.DestroyEffect(this, true);
		this.EffectInfo.Clear();
		BulletAdditionInfo additionInfo = this.AdditionInfo;
		if (additionInfo != null)
		{
			additionInfo.Clear();
		}
		this.ChildInfo = null;
		this.RayInfoInternal = null;
		this.BornLocationOffset.Reset();
		this.ParentBulletLastLocation.Reset();
		this.HasParentBulletLastLocation = false;
		this.DeferredConcurrentUpdateTransform = false;
		this.ContextId = null;
		this.PreContextId = null;
		this.BaseTransformEntityHasInit = false;
		this.ParentIds = null;
		this.ContextIdSubmitted = false;
	}

	// Token: 0x060165A8 RID: 91560 RVA: 0x00681B14 File Offset: 0x0067FD14
	public void SwapActionInfoList()
	{
		this.ActionInfoList.Clear();
		if (this.NextActionInfoList.Count > 0)
		{
			List<BulletActionInfoBase> actionInfoList = this.ActionInfoList;
			this.ActionInfoList = this.NextActionInfoList;
			this.NextActionInfoList = actionInfoList;
		}
	}

	// Token: 0x060165A9 RID: 91561 RVA: 0x00681B54 File Offset: 0x0067FD54
	private void AddTargetRemoveEvent()
	{
		if (this.TargetInternal == null)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.TargetInternal, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnTargetRemove));
	}

	// Token: 0x060165AA RID: 91562 RVA: 0x00681B81 File Offset: 0x0067FD81
	private void RemoveTargetRemoveEvent()
	{
		if (this.TargetInternal == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget(this.TargetInternal, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnTargetRemove));
	}

	// Token: 0x060165AB RID: 91563 RVA: 0x00681BAE File Offset: 0x0067FDAE
	[NullableContext(1)]
	private void OnTargetRemove(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
	{
		this.ClearTarget();
	}

	// Token: 0x060165AC RID: 91564 RVA: 0x00681BB8 File Offset: 0x0067FDB8
	[NullableContext(1)]
	private unsafe static void CheckClear(object obj)
	{
		foreach (PropertyInfo propertyInfo in obj.GetType().GetProperties())
		{
			if (!(propertyInfo.Name == "ContextId") && !(propertyInfo.Name == "ContextIdRaw"))
			{
				object value = propertyInfo.GetValue(obj);
				if (value != null)
				{
					Type type = value.GetType();
					if ((!(type == typeof(int)) || (int)value != 0) && (!(type == typeof(bool)) || (bool)value))
					{
						if (value is BulletCollisionInfo || value is BulletMoveInfo || value is BulletEffectInfo)
						{
							BulletInfo.CheckClear(value);
						}
						else
						{
							global::Vector vector = value as global::Vector;
							if (vector != null)
							{
								if (!vector.IsZero())
								{
									Log instance = Log.Instance;
									ELogModule module = ELogModule.Bullet;
									ELogAuthor author = ELogAuthor.CFT;
									string message = "BulletInfo回收时，Vector没重置";
									ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("key", propertyInfo.Name);
									instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
								}
							}
							else
							{
								global::Rotator rotator = value as global::Rotator;
								if (rotator != null)
								{
									if (!rotator.IsNearlyZero())
									{
										Log instance2 = Log.Instance;
										ELogModule module2 = ELogModule.Bullet;
										ELogAuthor author2 = ELogAuthor.CFT;
										string message2 = "BulletInfo回收时，Rotator没重置";
										ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("key", propertyInfo.Name);
										instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
									}
								}
								else
								{
									global::Transform transform = value as global::Transform;
									if (transform != null)
									{
										if (!transform.GetLocation().IsZero() || !transform.GetScale3D().IsZero() || transform.GetRotation().X != 0.0 || transform.GetRotation().Y != 0.0 || transform.GetRotation().Z != 0.0 || transform.GetRotation().W != 1.0)
										{
											Log instance3 = Log.Instance;
											ELogModule module3 = ELogModule.Bullet;
											ELogAuthor author3 = ELogAuthor.CFT;
											string message3 = "BulletInfo回收时，Transform没重置";
											ValueTuple<string, object> valueTuple3 = new ValueTuple<string, object>("key", propertyInfo.Name);
											instance3.Error(module3, author3, message3, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple3));
										}
									}
									else
									{
										IList list = value as IList;
										if (list != null)
										{
											if (list.Count != 0)
											{
												Log instance4 = Log.Instance;
												ELogModule module4 = ELogModule.Bullet;
												ELogAuthor author4 = ELogAuthor.CFT;
												string message4 = "BulletInfo回收时，Array没清空";
												ValueTuple<string, object> valueTuple4 = new ValueTuple<string, object>("key", propertyInfo.Name);
												instance4.Error(module4, author4, message4, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple4));
											}
										}
										else
										{
											IDictionary dictionary = value as IDictionary;
											if (dictionary != null)
											{
												if (dictionary.Count != 0)
												{
													Log instance5 = Log.Instance;
													ELogModule module5 = ELogModule.Bullet;
													ELogAuthor author5 = ELogAuthor.CFT;
													string message5 = "BulletInfo回收时，Map没清空";
													ValueTuple<string, object> valueTuple5 = new ValueTuple<string, object>("key", propertyInfo.Name);
													instance5.Error(module5, author5, message5, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple5));
												}
											}
											else
											{
												ICollection collection = value as ICollection;
												if (collection != null)
												{
													if (collection.Count != 0)
													{
														Log instance6 = Log.Instance;
														ELogModule module6 = ELogModule.Bullet;
														ELogAuthor author6 = ELogAuthor.CFT;
														string message6 = "BulletInfo回收时，Set没清空";
														ValueTuple<string, object> valueTuple6 = new ValueTuple<string, object>("key", propertyInfo.Name);
														instance6.Error(module6, author6, message6, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple6));
													}
												}
												else
												{
													Log instance7 = Log.Instance;
													ELogModule module7 = ELogModule.Bullet;
													ELogAuthor author7 = ELogAuthor.CFT;
													string message7 = "BulletInfo回收时，该变量不为undefined";
													<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
													*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("type", type.Name);
													*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("key", propertyInfo.Name);
													instance7.Error(module7, author7, message7, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
												}
											}
										}
									}
								}
							}
						}
					}
				}
			}
		}
	}

	// Token: 0x060165AD RID: 91565 RVA: 0x00681F30 File Offset: 0x00680130
	public void OnTargetInValid()
	{
		switch (this.BulletDataMain.Move.TrackTarget)
		{
		case EBulletTarget.队伍角色:
		case EBulletTarget.攻击者锁定目标动态:
		case EBulletTarget.外部传入坐标:
			break;
		case EBulletTarget.技能目标:
		case EBulletTarget.攻击者锁定目标静态:
		case EBulletTarget.自定义目标:
		case EBulletTarget.子弹发射者:
		case EBulletTarget.父子弹受击者:
		case EBulletTarget.父子弹目标:
		case EBulletTarget.前台角色锁定目标:
		case EBulletTarget.技能目标前台:
		case EBulletTarget.父子弹位置:
			this.SetTargetById(0);
			break;
		default:
			return;
		}
	}

	// Token: 0x170022D4 RID: 8916
	// (get) Token: 0x060165AE RID: 91566 RVA: 0x00681F8E File Offset: 0x0068018E
	// (set) Token: 0x060165AF RID: 91567 RVA: 0x00681F96 File Offset: 0x00680196
	public float Duration
	{
		get
		{
			return this.DurationInternal;
		}
		set
		{
			this.DurationInternal = value;
		}
	}

	// Token: 0x060165B0 RID: 91568 RVA: 0x00681F9F File Offset: 0x0068019F
	public static void CreateStaticDefaultValue()
	{
		BulletInfo.InAfterTick = false;
	}

	// Token: 0x060165B1 RID: 91569 RVA: 0x00681FA7 File Offset: 0x006801A7
	public static void ResetStaticDefaultValue()
	{
		BulletInfo.InAfterTick = false;
	}

	// Token: 0x0400BD11 RID: 48401
	private int Id;

	// Token: 0x0400BD12 RID: 48402
	public BulletEntity Entity;

	// Token: 0x0400BD13 RID: 48403
	private bool HasCheckedPositionInternal;

	// Token: 0x0400BD14 RID: 48404
	private BulletInitParams InitParams;

	// Token: 0x0400BD15 RID: 48405
	private BulletDataMain Config;

	// Token: 0x0400BD16 RID: 48406
	[Nullable(1)]
	public List<BulletActionInfoBase> ActionInfoList = new List<BulletActionInfoBase>();

	// Token: 0x0400BD17 RID: 48407
	[Nullable(1)]
	public List<BulletActionInfoBase> NextActionInfoList = new List<BulletActionInfoBase>();

	// Token: 0x0400BD18 RID: 48408
	[Nullable(1)]
	public List<BulletActionBase> PersistentActionList = new List<BulletActionBase>();

	// Token: 0x0400BD19 RID: 48409
	public BulletActionCenter ActionCenter;

	// Token: 0x0400BD1A RID: 48410
	public AActor Actor;

	// Token: 0x0400BD1B RID: 48411
	public BulletActorComponent ActorComponent;

	// Token: 0x0400BD1C RID: 48412
	public BulletActionLogicComponent ActionLogicComponent;

	// Token: 0x0400BD1D RID: 48413
	public bool IsInit;

	// Token: 0x0400BD1E RID: 48414
	public bool NeedDestroy;

	// Token: 0x0400BD1F RID: 48415
	public bool IsDestroyByCharSkillEnd;

	// Token: 0x0400BD20 RID: 48416
	public float GenerateTime;

	// Token: 0x0400BD21 RID: 48417
	public int BulletCamp;

	// Token: 0x0400BD22 RID: 48418
	public int ShakeNumbers;

	// Token: 0x0400BD23 RID: 48419
	public bool IsFrozen;

	// Token: 0x0400BD24 RID: 48420
	public float? FrozenTime;

	// Token: 0x0400BD25 RID: 48421
	public bool IsShield;

	// Token: 0x0400BD26 RID: 48422
	private EntityHandle BaseTransformEntityInternal;

	// Token: 0x0400BD27 RID: 48423
	private bool BaseTransformEntityHasInit;

	// Token: 0x0400BD28 RID: 48424
	[Nullable(1)]
	public readonly global::Vector RandomPosOffset = global::Vector.Create();

	// Token: 0x0400BD29 RID: 48425
	[Nullable(1)]
	public readonly global::Vector RandomInitSpeedOffset = global::Vector.Create();

	// Token: 0x0400BD2A RID: 48426
	private bool IsCacheLocation;

	// Token: 0x0400BD2B RID: 48427
	private bool IsCacheRotation;

	// Token: 0x0400BD2C RID: 48428
	[Nullable(1)]
	private readonly global::Vector LocationCache = global::Vector.Create();

	// Token: 0x0400BD2D RID: 48429
	[Nullable(1)]
	private readonly global::Rotator RotationCache = global::Rotator.Create();

	// Token: 0x0400BD2E RID: 48430
	[Nullable(1)]
	public readonly global::Vector InitPosition = global::Vector.Create();

	// Token: 0x0400BD2F RID: 48431
	[Nullable(1)]
	private readonly List<int> TagInternal = new List<int>();

	// Token: 0x0400BD30 RID: 48432
	public int CreateFrame;

	// Token: 0x0400BD31 RID: 48433
	public float LiveTimeRatio = 1f;

	// Token: 0x0400BD32 RID: 48434
	public float LiveTimeAddDelta;

	// Token: 0x0400BD33 RID: 48435
	public float LiveTime;

	// Token: 0x0400BD34 RID: 48436
	public float LiveTimeCurHit;

	// Token: 0x0400BD35 RID: 48437
	public bool IsTimeNotEnough;

	// Token: 0x0400BD36 RID: 48438
	[Nullable(1)]
	public readonly global::Vector BaseSize = global::Vector.Create();

	// Token: 0x0400BD37 RID: 48439
	[Nullable(1)]
	public readonly global::Vector Size = global::Vector.Create();

	// Token: 0x0400BD38 RID: 48440
	[Nullable(1)]
	private readonly global::Vector CenterLocationInternal = global::Vector.Create();

	// Token: 0x0400BD39 RID: 48441
	private BulletRayInfo RayInfoInternal;

	// Token: 0x0400BD3A RID: 48442
	public bool CloseCollision;

	// Token: 0x0400BD3B RID: 48443
	[Nullable(1)]
	public BulletCollisionInfo CollisionInfo = new BulletCollisionInfo();

	// Token: 0x0400BD3C RID: 48444
	public BulletKuroFastCollisionInfo KuroFastCollisionInfo;

	// Token: 0x0400BD3D RID: 48445
	[Nullable(1)]
	private readonly global::Vector CollisionLocationInternal = global::Vector.Create();

	// Token: 0x0400BD3E RID: 48446
	public int GetCollisionLocationFrame;

	// Token: 0x0400BD3F RID: 48447
	public bool IsCollisionRelativeLocationZero;

	// Token: 0x0400BD40 RID: 48448
	public bool IsCollisionRelativeRotationModify;

	// Token: 0x0400BD41 RID: 48449
	public bool DeferredConcurrentUpdateTransform;

	// Token: 0x0400BD42 RID: 48450
	public static bool InAfterTick;

	// Token: 0x0400BD43 RID: 48451
	[Nullable(1)]
	public BulletMoveInfo MoveInfo = new BulletMoveInfo();

	// Token: 0x0400BD44 RID: 48452
	[Nullable(1)]
	public BulletEffectInfo EffectInfo = new BulletEffectInfo();

	// Token: 0x0400BD45 RID: 48453
	private int AttackerIdInternal;

	// Token: 0x0400BD46 RID: 48454
	private EntityHandle AttackerInternal;

	// Token: 0x0400BD47 RID: 48455
	private CreatureDataComponent AttackerCreatureDataCompInternal;

	// Token: 0x0400BD48 RID: 48456
	private BaseActorComponent AttackerActorCompInternal;

	// Token: 0x0400BD49 RID: 48457
	private BaseSkillComponent AttackerSkillCompInternal;

	// Token: 0x0400BD4A RID: 48458
	private BaseBuffComponent AttackerBuffCompInternal;

	// Token: 0x0400BD4B RID: 48459
	private CharacterMoveComponent AttackerMoveCompInternal;

	// Token: 0x0400BD4C RID: 48460
	private CharacterAudioComponent AttackerAudioCompInternal;

	// Token: 0x0400BD4D RID: 48461
	private BaseTagComponent AttackerTagCompInternal;

	// Token: 0x0400BD4E RID: 48462
	public bool IsAutonomousProxy;

	// Token: 0x0400BD4F RID: 48463
	public ECamp AttackerCamp;

	// Token: 0x0400BD50 RID: 48464
	public int AttackerPlayerId;

	// Token: 0x0400BD51 RID: 48465
	public FName? SkillBoneName;

	// Token: 0x0400BD52 RID: 48466
	public int SkillLevel;

	// Token: 0x0400BD53 RID: 48467
	public int TargetId;

	// Token: 0x0400BD54 RID: 48468
	public int TargetIdLast;

	// Token: 0x0400BD55 RID: 48469
	private EntityHandle TargetInternal;

	// Token: 0x0400BD56 RID: 48470
	private bool TargetIsEntityInternal;

	// Token: 0x0400BD57 RID: 48471
	private BaseActorComponent TargetActorCompInternal;

	// Token: 0x0400BD58 RID: 48472
	public BulletInfo ParentBulletInfo;

	// Token: 0x0400BD59 RID: 48473
	[Nullable(1)]
	public readonly global::Vector ParentBulletLastLocation = global::Vector.Create();

	// Token: 0x0400BD5A RID: 48474
	public bool HasParentBulletLastLocation;

	// Token: 0x0400BD5B RID: 48475
	public List<int> ChildEntityIds;

	// Token: 0x0400BD5C RID: 48476
	public BulletChildInfo ChildInfo;

	// Token: 0x0400BD5D RID: 48477
	public int ParentEffect;

	// Token: 0x0400BD5E RID: 48478
	public bool NeedNotifyChildrenWhenDestroy;

	// Token: 0x0400BD5F RID: 48479
	public int HitNumberAll;

	// Token: 0x0400BD60 RID: 48480
	[Nullable(1)]
	public readonly HashSet<int> EntityHitSet = new HashSet<int>();

	// Token: 0x0400BD61 RID: 48481
	[Nullable(1)]
	public readonly Dictionary<int, int> EntityHitCount = new Dictionary<int, int>();

	// Token: 0x0400BD62 RID: 48482
	public bool CountByParent;

	// Token: 0x0400BD63 RID: 48483
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public PriorityQueue<TimeScale> TimeScaleList;

	// Token: 0x0400BD64 RID: 48484
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TimeScale> TimeScaleMap;

	// Token: 0x0400BD65 RID: 48485
	public int TimeScaleId;

	// Token: 0x0400BD66 RID: 48486
	public int SummonSkillId;

	// Token: 0x0400BD67 RID: 48487
	public int SummonAttackerId;

	// Token: 0x0400BD68 RID: 48488
	public long SummonServerEntityId;

	// Token: 0x0400BD69 RID: 48489
	public long? BornFrameCount;

	// Token: 0x0400BD6A RID: 48490
	public long? PreContextId;

	// Token: 0x0400BD6B RID: 48491
	private long? ContextIdInternal;

	// Token: 0x0400BD6C RID: 48492
	public bool ContextIdSubmitted;

	// Token: 0x0400BD6D RID: 48493
	[Nullable(1)]
	public readonly global::Vector BornLocationOffset = global::Vector.Create();

	// Token: 0x0400BD6E RID: 48494
	public BulletAdditionInfo AdditionInfo;

	// Token: 0x0400BD6F RID: 48495
	private float DurationInternal;

	// Token: 0x0400BD70 RID: 48496
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<string> ParentIds;
}
