using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using AkiClient.Game.Aki.Character.BaseCharacter;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Core.Common;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.NewWorld.Pawn.Component;
using UnrealEngine;

// Token: 0x02002E11 RID: 11793
[NullableContext(2)]
[Nullable(0)]
public class BulletInfo : IStaticVariableResetter
{
	// Token: 0x06018CB1 RID: 101553 RVA: 0x0065AB98 File Offset: 0x00658D98
	static BulletInfo()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(BulletInfo.CreateStaticDefaultValue), new Action(BulletInfo.ResetStaticDefaultValue));
	}

	// Token: 0x17002250 RID: 8784
	// (get) Token: 0x06018CB2 RID: 101554 RVA: 0x0065ABB7 File Offset: 0x00658DB7
	public int BulletEntityId
	{
		get
		{
			return this.Id;
		}
	}

	// Token: 0x17002251 RID: 8785
	// (get) Token: 0x06018CB3 RID: 101555 RVA: 0x0065ABBF File Offset: 0x00658DBF
	public bool HasCheckedPosition
	{
		get
		{
			return this.HasCheckedPositionInternal;
		}
	}

	// Token: 0x06018CB4 RID: 101556 RVA: 0x0065ABC7 File Offset: 0x00658DC7
	public void CheckedPosition()
	{
		this.HasCheckedPositionInternal = true;
	}

	// Token: 0x17002252 RID: 8786
	// (get) Token: 0x06018CB5 RID: 101557 RVA: 0x0065ABD0 File Offset: 0x00658DD0
	[Nullable(1)]
	public BulletInitParams BulletInitParams
	{
		[NullableContext(1)]
		get
		{
			return this.InitParams;
		}
	}

	// Token: 0x17002253 RID: 8787
	// (get) Token: 0x06018CB6 RID: 101558 RVA: 0x0065ABD8 File Offset: 0x00658DD8
	public FTransformDouble? TransformCreate
	{
		get
		{
			return this.InitParams.InitialTransform;
		}
	}

	// Token: 0x17002254 RID: 8788
	// (get) Token: 0x06018CB7 RID: 101559 RVA: 0x0065ABE5 File Offset: 0x00658DE5
	public int BaseVelocityEntityId
	{
		get
		{
			return this.InitParams.BaseVelocityId;
		}
	}

	// Token: 0x17002255 RID: 8789
	// (get) Token: 0x06018CB8 RID: 101560 RVA: 0x0065ABF2 File Offset: 0x00658DF2
	[Nullable(1)]
	public string BulletRowName
	{
		[NullableContext(1)]
		get
		{
			return this.InitParams.BulletRowName;
		}
	}

	// Token: 0x06018CB9 RID: 101561 RVA: 0x0065ABFF File Offset: 0x00658DFF
	public BaseActorComponent GetBaseVelocityTarget()
	{
		Entity entity = EntitySystem.Instance.Get(this.InitParams.BaseVelocityId);
		if (entity == null)
		{
			return null;
		}
		return entity.GetComponent<BaseActorComponent>();
	}

	// Token: 0x17002256 RID: 8790
	// (get) Token: 0x06018CBA RID: 101562 RVA: 0x0065AC21 File Offset: 0x00658E21
	public BulletDataMain BulletDataMain
	{
		get
		{
			return this.Config;
		}
	}

	// Token: 0x17002257 RID: 8791
	// (get) Token: 0x06018CBB RID: 101563 RVA: 0x0065AC29 File Offset: 0x00658E29
	public bool IsTensile
	{
		get
		{
			BulletDataMain bulletDataMain = this.BulletDataMain;
			return bulletDataMain != null && bulletDataMain.Move.FollowType == EBulletFollowType.攻击者锁定拉伸;
		}
	}

	// Token: 0x17002258 RID: 8792
	// (get) Token: 0x06018CBC RID: 101564 RVA: 0x0065AC44 File Offset: 0x00658E44
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

	// Token: 0x06018CBD RID: 101565 RVA: 0x0065AC98 File Offset: 0x00658E98
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

	// Token: 0x06018CBE RID: 101566 RVA: 0x0065ACF4 File Offset: 0x00658EF4
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

	// Token: 0x06018CBF RID: 101567 RVA: 0x0065AD4F File Offset: 0x00658F4F
	[NullableContext(1)]
	public global::Vector GetActorLocation()
	{
		if (this.IsCacheLocation)
		{
			return this.LocationCache;
		}
		return this.ActorComponent.ActorLocationProxy;
	}

	// Token: 0x06018CC0 RID: 101568 RVA: 0x0065AD6B File Offset: 0x00658F6B
	[NullableContext(1)]
	public global::Rotator GetActorRotation()
	{
		if (this.IsCacheRotation)
		{
			return this.RotationCache;
		}
		return this.ActorComponent.ActorRotationProxy;
	}

	// Token: 0x06018CC1 RID: 101569 RVA: 0x0065AD87 File Offset: 0x00658F87
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

	// Token: 0x06018CC2 RID: 101570 RVA: 0x0065ADAF File Offset: 0x00658FAF
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

	// Token: 0x06018CC3 RID: 101571 RVA: 0x0065ADE5 File Offset: 0x00658FE5
	public void AddBulletLocalRotator(FRotator newRotator)
	{
		this.ApplyCacheLocationAndRotation();
		this.ActorComponent.AddBulletLocalRotator(newRotator);
	}

	// Token: 0x06018CC4 RID: 101572 RVA: 0x0065ADFC File Offset: 0x00658FFC
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

	// Token: 0x06018CC5 RID: 101573 RVA: 0x0065AED6 File Offset: 0x006590D6
	public void ClearCacheLocationAndRotation()
	{
		this.IsCacheLocation = false;
		this.IsCacheRotation = false;
	}

	// Token: 0x17002259 RID: 8793
	// (get) Token: 0x06018CC6 RID: 101574 RVA: 0x0065AEE6 File Offset: 0x006590E6
	[Nullable(1)]
	public IReadOnlyList<int> Tags
	{
		[NullableContext(1)]
		get
		{
			return this.TagInternal;
		}
	}

	// Token: 0x06018CC7 RID: 101575 RVA: 0x0065AEEE File Offset: 0x006590EE
	public void AddTag(FGameplayTag tag)
	{
		this.TagInternal.Add(tag.TagId());
	}

	// Token: 0x06018CC8 RID: 101576 RVA: 0x0065AF01 File Offset: 0x00659101
	public void AddTagId(int tagId)
	{
		this.TagInternal.Add(tagId);
	}

	// Token: 0x06018CC9 RID: 101577 RVA: 0x0065AF10 File Offset: 0x00659110
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

	// Token: 0x06018CCA RID: 101578 RVA: 0x0065AF78 File Offset: 0x00659178
	public bool HasTagId(int newTagId)
	{
		List<int> tagInternal = this.TagInternal;
		return tagInternal != null && tagInternal.Contains(newTagId);
	}

	// Token: 0x1700225A RID: 8794
	// (get) Token: 0x06018CCB RID: 101579 RVA: 0x0065AF8C File Offset: 0x0065918C
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

	// Token: 0x1700225B RID: 8795
	// (get) Token: 0x06018CCC RID: 101580 RVA: 0x0065AFCC File Offset: 0x006591CC
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

	// Token: 0x1700225C RID: 8796
	// (get) Token: 0x06018CCD RID: 101581 RVA: 0x0065AFE7 File Offset: 0x006591E7
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

	// Token: 0x06018CCE RID: 101582 RVA: 0x0065B00C File Offset: 0x0065920C
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

	// Token: 0x1700225D RID: 8797
	// (get) Token: 0x06018CCF RID: 101583 RVA: 0x0065B0FF File Offset: 0x006592FF
	public int AttackerId
	{
		get
		{
			return this.AttackerIdInternal;
		}
	}

	// Token: 0x1700225E RID: 8798
	// (get) Token: 0x06018CD0 RID: 101584 RVA: 0x0065B107 File Offset: 0x00659307
	public EntityHandle AttackerHandle
	{
		get
		{
			return this.AttackerInternal;
		}
	}

	// Token: 0x1700225F RID: 8799
	// (get) Token: 0x06018CD1 RID: 101585 RVA: 0x0065B10F File Offset: 0x0065930F
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

	// Token: 0x06018CD2 RID: 101586 RVA: 0x0065B122 File Offset: 0x00659322
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

	// Token: 0x17002260 RID: 8800
	// (get) Token: 0x06018CD3 RID: 101587 RVA: 0x0065B15C File Offset: 0x0065935C
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

	// Token: 0x17002261 RID: 8801
	// (get) Token: 0x06018CD4 RID: 101588 RVA: 0x0065B184 File Offset: 0x00659384
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

	// Token: 0x17002262 RID: 8802
	// (get) Token: 0x06018CD5 RID: 101589 RVA: 0x0065B1AC File Offset: 0x006593AC
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

	// Token: 0x17002263 RID: 8803
	// (get) Token: 0x06018CD6 RID: 101590 RVA: 0x0065B1D4 File Offset: 0x006593D4
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

	// Token: 0x17002264 RID: 8804
	// (get) Token: 0x06018CD7 RID: 101591 RVA: 0x0065B1FC File Offset: 0x006593FC
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

	// Token: 0x17002265 RID: 8805
	// (get) Token: 0x06018CD8 RID: 101592 RVA: 0x0065B224 File Offset: 0x00659424
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

	// Token: 0x17002266 RID: 8806
	// (get) Token: 0x06018CD9 RID: 101593 RVA: 0x0065B24C File Offset: 0x0065944C
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

	// Token: 0x17002267 RID: 8807
	// (get) Token: 0x06018CDA RID: 101594 RVA: 0x0065B274 File Offset: 0x00659474
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

	// Token: 0x06018CDB RID: 101595 RVA: 0x0065B2AC File Offset: 0x006594AC
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

	// Token: 0x06018CDC RID: 101596 RVA: 0x0065B326 File Offset: 0x00659526
	public void ClearTarget()
	{
		this.RemoveTargetRemoveEvent();
		this.TargetInternal = null;
		this.TargetId = 0;
		this.TargetActorCompInternal = null;
		this.TargetIsEntityInternal = false;
	}

	// Token: 0x17002268 RID: 8808
	// (get) Token: 0x06018CDD RID: 101597 RVA: 0x0065B34C File Offset: 0x0065954C
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

	// Token: 0x06018CDE RID: 101598 RVA: 0x0065B398 File Offset: 0x00659598
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

	// Token: 0x17002269 RID: 8809
	// (get) Token: 0x06018CDF RID: 101599 RVA: 0x0065B3E5 File Offset: 0x006595E5
	public int ParentEntityId
	{
		get
		{
			return this.InitParams.ParentId;
		}
	}

	// Token: 0x1700226A RID: 8810
	// (get) Token: 0x06018CE0 RID: 101600 RVA: 0x0065B3F2 File Offset: 0x006595F2
	// (set) Token: 0x06018CE1 RID: 101601 RVA: 0x0065B408 File Offset: 0x00659608
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

	// Token: 0x1700226B RID: 8811
	// (get) Token: 0x06018CE2 RID: 101602 RVA: 0x0065B411 File Offset: 0x00659611
	public long? ContextIdRaw
	{
		get
		{
			return this.ContextIdInternal;
		}
	}

	// Token: 0x06018CE3 RID: 101603 RVA: 0x0065B41C File Offset: 0x0065961C
	private void ReportContextIdNotSubmitted()
	{
		if (!Info.Instance.IsBuildDevelopmentOrDebug)
		{
			return;
		}
		BulletLog.Error(true, ELogAuthor.HCW, this.Attacker, "[子弹协议时序错误] 引用 ContextId 早于 CreateBulletPush，应在 OnAfterInit 之后执行", this, default(ReadOnlySpan<ValueTuple<string, object>>));
		UWorld world = GlobalData.World;
		if (world != null)
		{
			UKismetSystemLibrary.PrintString(world, this.BulletRowName, true, false, new FLinearColor?(new FLinearColor(1f, 0f, 0f, 1f)), 20f);
		}
	}

	// Token: 0x06018CE4 RID: 101604 RVA: 0x0065B490 File Offset: 0x00659690
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

	// Token: 0x06018CE5 RID: 101605 RVA: 0x0065B5CA File Offset: 0x006597CA
	[NullableContext(1)]
	public void InitEntity(BulletEntity entity)
	{
		this.Entity = entity;
		this.Id = entity.Id;
	}

	// Token: 0x06018CE6 RID: 101606 RVA: 0x0065B5E0 File Offset: 0x006597E0
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
		if (BulletConstant.Instance.OpenClearCheck)
		{
			BulletInfo.CheckClear(this);
		}
		this.ContextIdSubmitted = false;
	}

	// Token: 0x06018CE7 RID: 101607 RVA: 0x0065B9B4 File Offset: 0x00659BB4
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

	// Token: 0x06018CE8 RID: 101608 RVA: 0x0065B9F4 File Offset: 0x00659BF4
	private void AddTargetRemoveEvent()
	{
		if (this.TargetInternal == null)
		{
			return;
		}
		EventSystem.Instance.AddWithTarget<ERemoveEntityType, EntityHandle>(this.TargetInternal, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnTargetRemove));
	}

	// Token: 0x06018CE9 RID: 101609 RVA: 0x0065BA21 File Offset: 0x00659C21
	private void RemoveTargetRemoveEvent()
	{
		if (this.TargetInternal == null)
		{
			return;
		}
		EventSystem.Instance.RemoveWithTarget(this.TargetInternal, EEventName.RemoveEntity, new Action<ERemoveEntityType, EntityHandle>(this.OnTargetRemove));
	}

	// Token: 0x06018CEA RID: 101610 RVA: 0x0065BA4E File Offset: 0x00659C4E
	[NullableContext(1)]
	private void OnTargetRemove(ERemoveEntityType eRemoveEntityType, EntityHandle entityHandle)
	{
		this.ClearTarget();
	}

	// Token: 0x06018CEB RID: 101611 RVA: 0x0065BA58 File Offset: 0x00659C58
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

	// Token: 0x06018CEC RID: 101612 RVA: 0x0065BDD0 File Offset: 0x00659FD0
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

	// Token: 0x1700226C RID: 8812
	// (get) Token: 0x06018CED RID: 101613 RVA: 0x0065BE2E File Offset: 0x0065A02E
	// (set) Token: 0x06018CEE RID: 101614 RVA: 0x0065BE36 File Offset: 0x0065A036
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

	// Token: 0x06018CEF RID: 101615 RVA: 0x0065BE3F File Offset: 0x0065A03F
	public static void CreateStaticDefaultValue()
	{
		BulletInfo.InAfterTick = false;
	}

	// Token: 0x06018CF0 RID: 101616 RVA: 0x0065BE47 File Offset: 0x0065A047
	public static void ResetStaticDefaultValue()
	{
		BulletInfo.InAfterTick = false;
	}

	// Token: 0x0400B983 RID: 47491
	private int Id;

	// Token: 0x0400B984 RID: 47492
	public BulletEntity Entity;

	// Token: 0x0400B985 RID: 47493
	private bool HasCheckedPositionInternal;

	// Token: 0x0400B986 RID: 47494
	private BulletInitParams InitParams;

	// Token: 0x0400B987 RID: 47495
	private BulletDataMain Config;

	// Token: 0x0400B988 RID: 47496
	[Nullable(1)]
	public List<BulletActionInfoBase> ActionInfoList = new List<BulletActionInfoBase>();

	// Token: 0x0400B989 RID: 47497
	[Nullable(1)]
	public List<BulletActionInfoBase> NextActionInfoList = new List<BulletActionInfoBase>();

	// Token: 0x0400B98A RID: 47498
	[Nullable(1)]
	public List<BulletActionBase> PersistentActionList = new List<BulletActionBase>();

	// Token: 0x0400B98B RID: 47499
	public BulletActionCenter ActionCenter;

	// Token: 0x0400B98C RID: 47500
	public AActor Actor;

	// Token: 0x0400B98D RID: 47501
	public BulletActorComponent ActorComponent;

	// Token: 0x0400B98E RID: 47502
	public BulletActionLogicComponent ActionLogicComponent;

	// Token: 0x0400B98F RID: 47503
	public bool IsInit;

	// Token: 0x0400B990 RID: 47504
	public bool NeedDestroy;

	// Token: 0x0400B991 RID: 47505
	public bool IsDestroyByCharSkillEnd;

	// Token: 0x0400B992 RID: 47506
	public float GenerateTime;

	// Token: 0x0400B993 RID: 47507
	public int BulletCamp;

	// Token: 0x0400B994 RID: 47508
	public int ShakeNumbers;

	// Token: 0x0400B995 RID: 47509
	public bool IsFrozen;

	// Token: 0x0400B996 RID: 47510
	public float? FrozenTime;

	// Token: 0x0400B997 RID: 47511
	public bool IsShield;

	// Token: 0x0400B998 RID: 47512
	private EntityHandle BaseTransformEntityInternal;

	// Token: 0x0400B999 RID: 47513
	private bool BaseTransformEntityHasInit;

	// Token: 0x0400B99A RID: 47514
	[Nullable(1)]
	public readonly global::Vector RandomPosOffset = global::Vector.Create();

	// Token: 0x0400B99B RID: 47515
	[Nullable(1)]
	public readonly global::Vector RandomInitSpeedOffset = global::Vector.Create();

	// Token: 0x0400B99C RID: 47516
	private bool IsCacheLocation;

	// Token: 0x0400B99D RID: 47517
	private bool IsCacheRotation;

	// Token: 0x0400B99E RID: 47518
	[Nullable(1)]
	private readonly global::Vector LocationCache = global::Vector.Create();

	// Token: 0x0400B99F RID: 47519
	[Nullable(1)]
	private readonly global::Rotator RotationCache = global::Rotator.Create();

	// Token: 0x0400B9A0 RID: 47520
	[Nullable(1)]
	public readonly global::Vector InitPosition = global::Vector.Create();

	// Token: 0x0400B9A1 RID: 47521
	[Nullable(1)]
	private readonly List<int> TagInternal = new List<int>();

	// Token: 0x0400B9A2 RID: 47522
	public int CreateFrame;

	// Token: 0x0400B9A3 RID: 47523
	public float LiveTimeRatio = 1f;

	// Token: 0x0400B9A4 RID: 47524
	public float LiveTimeAddDelta;

	// Token: 0x0400B9A5 RID: 47525
	public float LiveTime;

	// Token: 0x0400B9A6 RID: 47526
	public float LiveTimeCurHit;

	// Token: 0x0400B9A7 RID: 47527
	public bool IsTimeNotEnough;

	// Token: 0x0400B9A8 RID: 47528
	[Nullable(1)]
	public readonly global::Vector BaseSize = global::Vector.Create();

	// Token: 0x0400B9A9 RID: 47529
	[Nullable(1)]
	public readonly global::Vector Size = global::Vector.Create();

	// Token: 0x0400B9AA RID: 47530
	[Nullable(1)]
	private readonly global::Vector CenterLocationInternal = global::Vector.Create();

	// Token: 0x0400B9AB RID: 47531
	private BulletRayInfo RayInfoInternal;

	// Token: 0x0400B9AC RID: 47532
	public bool CloseCollision;

	// Token: 0x0400B9AD RID: 47533
	[Nullable(1)]
	public BulletCollisionInfo CollisionInfo = new BulletCollisionInfo();

	// Token: 0x0400B9AE RID: 47534
	public BulletKuroFastCollisionInfo KuroFastCollisionInfo;

	// Token: 0x0400B9AF RID: 47535
	[Nullable(1)]
	private readonly global::Vector CollisionLocationInternal = global::Vector.Create();

	// Token: 0x0400B9B0 RID: 47536
	public int GetCollisionLocationFrame;

	// Token: 0x0400B9B1 RID: 47537
	public bool IsCollisionRelativeLocationZero;

	// Token: 0x0400B9B2 RID: 47538
	public bool IsCollisionRelativeRotationModify;

	// Token: 0x0400B9B3 RID: 47539
	public bool DeferredConcurrentUpdateTransform;

	// Token: 0x0400B9B4 RID: 47540
	public static bool InAfterTick;

	// Token: 0x0400B9B5 RID: 47541
	[Nullable(1)]
	public BulletMoveInfo MoveInfo = new BulletMoveInfo();

	// Token: 0x0400B9B6 RID: 47542
	[Nullable(1)]
	public BulletEffectInfo EffectInfo = new BulletEffectInfo();

	// Token: 0x0400B9B7 RID: 47543
	private int AttackerIdInternal;

	// Token: 0x0400B9B8 RID: 47544
	private EntityHandle AttackerInternal;

	// Token: 0x0400B9B9 RID: 47545
	private CreatureDataComponent AttackerCreatureDataCompInternal;

	// Token: 0x0400B9BA RID: 47546
	private BaseActorComponent AttackerActorCompInternal;

	// Token: 0x0400B9BB RID: 47547
	private BaseSkillComponent AttackerSkillCompInternal;

	// Token: 0x0400B9BC RID: 47548
	private BaseBuffComponent AttackerBuffCompInternal;

	// Token: 0x0400B9BD RID: 47549
	private CharacterMoveComponent AttackerMoveCompInternal;

	// Token: 0x0400B9BE RID: 47550
	private CharacterAudioComponent AttackerAudioCompInternal;

	// Token: 0x0400B9BF RID: 47551
	private BaseTagComponent AttackerTagCompInternal;

	// Token: 0x0400B9C0 RID: 47552
	public bool IsAutonomousProxy;

	// Token: 0x0400B9C1 RID: 47553
	public ECamp AttackerCamp;

	// Token: 0x0400B9C2 RID: 47554
	public int AttackerPlayerId;

	// Token: 0x0400B9C3 RID: 47555
	public FName? SkillBoneName;

	// Token: 0x0400B9C4 RID: 47556
	public int SkillLevel;

	// Token: 0x0400B9C5 RID: 47557
	public int TargetId;

	// Token: 0x0400B9C6 RID: 47558
	public int TargetIdLast;

	// Token: 0x0400B9C7 RID: 47559
	private EntityHandle TargetInternal;

	// Token: 0x0400B9C8 RID: 47560
	private bool TargetIsEntityInternal;

	// Token: 0x0400B9C9 RID: 47561
	private BaseActorComponent TargetActorCompInternal;

	// Token: 0x0400B9CA RID: 47562
	public BulletInfo ParentBulletInfo;

	// Token: 0x0400B9CB RID: 47563
	[Nullable(1)]
	public readonly global::Vector ParentBulletLastLocation = global::Vector.Create();

	// Token: 0x0400B9CC RID: 47564
	public bool HasParentBulletLastLocation;

	// Token: 0x0400B9CD RID: 47565
	public List<int> ChildEntityIds;

	// Token: 0x0400B9CE RID: 47566
	public BulletChildInfo ChildInfo;

	// Token: 0x0400B9CF RID: 47567
	public int ParentEffect;

	// Token: 0x0400B9D0 RID: 47568
	public bool NeedNotifyChildrenWhenDestroy;

	// Token: 0x0400B9D1 RID: 47569
	public int HitNumberAll;

	// Token: 0x0400B9D2 RID: 47570
	[Nullable(1)]
	public readonly HashSet<int> EntityHitSet = new HashSet<int>();

	// Token: 0x0400B9D3 RID: 47571
	[Nullable(1)]
	public readonly Dictionary<int, int> EntityHitCount = new Dictionary<int, int>();

	// Token: 0x0400B9D4 RID: 47572
	public bool CountByParent;

	// Token: 0x0400B9D5 RID: 47573
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public PriorityQueue<TimeScale> TimeScaleList;

	// Token: 0x0400B9D6 RID: 47574
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, TimeScale> TimeScaleMap;

	// Token: 0x0400B9D7 RID: 47575
	public int TimeScaleId;

	// Token: 0x0400B9D8 RID: 47576
	public int SummonSkillId;

	// Token: 0x0400B9D9 RID: 47577
	public int SummonAttackerId;

	// Token: 0x0400B9DA RID: 47578
	public long SummonServerEntityId;

	// Token: 0x0400B9DB RID: 47579
	public long? BornFrameCount;

	// Token: 0x0400B9DC RID: 47580
	public long? PreContextId;

	// Token: 0x0400B9DD RID: 47581
	private long? ContextIdInternal;

	// Token: 0x0400B9DE RID: 47582
	public bool ContextIdSubmitted;

	// Token: 0x0400B9DF RID: 47583
	[Nullable(1)]
	public readonly global::Vector BornLocationOffset = global::Vector.Create();

	// Token: 0x0400B9E0 RID: 47584
	public BulletAdditionInfo AdditionInfo;

	// Token: 0x0400B9E1 RID: 47585
	private float DurationInternal;

	// Token: 0x0400B9E2 RID: 47586
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public HashSet<string> ParentIds;
}
