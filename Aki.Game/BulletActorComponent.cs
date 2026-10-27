using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DEE RID: 11758
[NullableContext(1)]
[Nullable(0)]
public class BulletActorComponent : BaseActorComponent
{
	// Token: 0x06018B0C RID: 101132 RVA: 0x006574AC File Offset: 0x006556AC
	protected override bool OnStart()
	{
		BulletEntity bulletEntity = base.Entity as BulletEntity;
		BulletInfo bulletInfo = (bulletEntity != null) ? bulletEntity.GetBulletInfo() : null;
		BulletDataMain bulletDataMain = bulletInfo.BulletDataMain;
		this.Shape = new EBulletShape?(bulletDataMain.Base.Shape);
		this.IsLockScale = bulletDataMain.Move.IsLockScale;
		AKuroEntityActor akuroEntityActor = BulletActorPool.Get(this.Shape.Value);
		akuroEntityActor.EntityId = base.Entity.Id;
		bulletInfo.Actor = akuroEntityActor;
		this.ActorInternal = bulletInfo.Actor;
		bulletInfo.ActorComponent = this;
		return base.OnStart();
	}

	// Token: 0x06018B0D RID: 101133 RVA: 0x00657541 File Offset: 0x00655741
	protected override void OnActivate()
	{
		this.ActorInternal.Kuro_SetRole(EKuroNetRole.KURO_ROLE_AutonomousProxy);
		this.LastActorLocation.DeepCopy(this.ActorLocationProxy);
	}

	// Token: 0x06018B0E RID: 101134 RVA: 0x00657560 File Offset: 0x00655760
	protected unsafe override bool OnClear()
	{
		if (this.ActorInternal != null)
		{
			if (this.IsLockScale)
			{
				this.ActorInternal.RootComponent.SetAbsolute(false, false, false);
			}
			if (this.ChildrenAttached.Count > 0)
			{
				foreach (AActor aactor in this.ChildrenAttached)
				{
					if (aactor != null && aactor.IsValid() && aactor.GetParentActor() == this.ActorInternal)
					{
						aactor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
					}
				}
			}
			BulletEntity bulletEntity = base.Entity as BulletEntity;
			BulletInfo bulletInfo = (bulletEntity != null) ? bulletEntity.GetBulletInfo() : null;
			if (bulletInfo != null && bulletInfo.DeferredConcurrentUpdateTransform)
			{
				this.ActorInternal.K2_SetDeferedConcurrentUpdateTransform(false);
			}
			UPrimitiveComponent uprimitiveComponent;
			if (bulletInfo == null)
			{
				uprimitiveComponent = null;
			}
			else
			{
				BulletCollisionInfo collisionInfo = bulletInfo.CollisionInfo;
				uprimitiveComponent = ((collisionInfo != null) ? collisionInfo.CollisionComponent : null);
			}
			UPrimitiveComponent uprimitiveComponent2 = uprimitiveComponent;
			if (uprimitiveComponent2 != null)
			{
				if (!bulletInfo.IsCollisionRelativeLocationZero)
				{
					uprimitiveComponent2.D_K2_SetRelativeLocation(Vector.ZeroVectorDouble, false, ref WorldGlobal.SweepHitResult, true);
				}
				if (bulletInfo.IsCollisionRelativeRotationModify)
				{
					uprimitiveComponent2.K2_SetRelativeRotation(Rotator.ZeroRotator, false, ref WorldGlobal.SweepHitResult, true);
				}
				if (!uprimitiveComponent2.bHiddenInGame)
				{
					uprimitiveComponent2.SetHiddenInGame(true, false);
					Log instance = Log.Instance;
					ELogModule module = ELogModule.Bullet;
					ELogAuthor author = ELogAuthor.HCW;
					string message = "子弹碰撞盒显隐被修改";
					ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Bullet", bulletInfo.BulletRowName);
					instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
				}
			}
			UKuroRegionShapeComponent ukuroRegionShapeComponent;
			if (bulletInfo == null)
			{
				ukuroRegionShapeComponent = null;
			}
			else
			{
				BulletCollisionInfo collisionInfo2 = bulletInfo.CollisionInfo;
				ukuroRegionShapeComponent = ((collisionInfo2 != null) ? collisionInfo2.RegionComponent : null);
			}
			UKuroRegionShapeComponent ukuroRegionShapeComponent2 = ukuroRegionShapeComponent;
			if (ukuroRegionShapeComponent2 != null)
			{
				if (!bulletInfo.IsCollisionRelativeLocationZero)
				{
					ukuroRegionShapeComponent2.D_K2_SetRelativeLocation(Vector.ZeroVectorDouble, false, ref WorldGlobal.SweepHitResult, true);
				}
				if (bulletInfo.IsCollisionRelativeRotationModify)
				{
					ukuroRegionShapeComponent2.K2_SetRelativeRotation(Rotator.ZeroRotator, false, ref WorldGlobal.SweepHitResult, true);
				}
			}
			if (GlobalData.IsPlayInEditor)
			{
				if (!this.NeedDetach)
				{
					FVectorDouble fvectorDouble = this.ActorInternal.D_GetActorScale3D();
					if (!Vector.OneVectorDouble.Equals(fvectorDouble, 9.999999747378752E-05))
					{
						Log instance2 = Log.Instance;
						ELogModule module2 = ELogModule.Bullet;
						ELogAuthor author2 = ELogAuthor.CFT;
						string message2 = "子弹回收时发现子弹缩放值异常";
						<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
						ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
						string item = "EntityId";
						Entity entity = base.Entity;
						ptr = new ValueTuple<string, object>(item, (entity != null) ? new int?(entity.Id) : null);
						*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("BulletRowName", (bulletInfo != null) ? bulletInfo.BulletRowName : null);
						instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
					}
				}
				if (!this.NeedDetach && this.ActorInternal.GetAttachParentActor() != null)
				{
					Log instance3 = Log.Instance;
					ELogModule module3 = ELogModule.Bullet;
					ELogAuthor author3 = ELogAuthor.CFT;
					string message3 = "子弹回收时发现子弹仍Attach在别的实体上";
					<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
					ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0);
					string item2 = "EntityId";
					Entity entity2 = base.Entity;
					ptr2 = new ValueTuple<string, object>(item2, (entity2 != null) ? new int?(entity2.Id) : null);
					*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("BulletRowName", (bulletInfo != null) ? bulletInfo.BulletRowName : null);
					instance3.Error(module3, author3, message3, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				}
			}
			BulletActorPool.Recycle(this.ActorInternal as AKuroEntityActor, this.Shape.Value, this.NeedDetach);
		}
		this.Shape = null;
		this.ChildrenAttached.Clear();
		this.NeedDetach = false;
		this.NeedDetachForBaseMovement = false;
		return base.OnClear();
	}

	// Token: 0x06018B0F RID: 101135 RVA: 0x006578C4 File Offset: 0x00655AC4
	[NullableContext(2)]
	public void SetAttachToComponent(USceneComponent parent, FName socketName, EAttachmentRule locationRule, EAttachmentRule rotationRule, EAttachmentRule scaleRule, bool bWeldSimulatedBodies)
	{
		this.ActorInternal.K2_AttachToComponent(parent, socketName, locationRule, rotationRule, scaleRule, bWeldSimulatedBodies, true);
		this.NeedDetach = true;
		base.ResetAllCachedTime();
	}

	// Token: 0x06018B10 RID: 101136 RVA: 0x006578E8 File Offset: 0x00655AE8
	public void AddBulletLocalRotator(FRotator newRotator)
	{
		this.ActorInternal.K2_AddActorLocalRotation(newRotator, true, ref WorldGlobal.SweepHitResult, false);
		base.ResetAllCachedTime();
	}

	// Token: 0x06018B11 RID: 101137 RVA: 0x00657903 File Offset: 0x00655B03
	public void SetBulletCustomTimeDilation(float timeSize)
	{
		this.ActorInternal.CustomTimeDilation = timeSize;
	}

	// Token: 0x06018B12 RID: 101138 RVA: 0x00657914 File Offset: 0x00655B14
	public override bool ClearComponent(EntityComponent componentTemplate)
	{
		if (!base.ClearComponent(componentTemplate))
		{
			return false;
		}
		BulletActorComponent bulletActorComponent = (BulletActorComponent)componentTemplate;
		if (base.CanResetComponentProperty("Shape"))
		{
			this.Shape = bulletActorComponent.Shape;
		}
		if (base.CanResetComponentProperty("NeedDetach"))
		{
			this.NeedDetach = bulletActorComponent.NeedDetach;
		}
		if (base.CanResetComponentProperty("NeedDetachForBaseMovement"))
		{
			this.NeedDetachForBaseMovement = bulletActorComponent.NeedDetachForBaseMovement;
		}
		if (base.CanResetComponentProperty("ChildrenAttached"))
		{
			if (bulletActorComponent.ChildrenAttached == null)
			{
				this.ChildrenAttached = null;
			}
			else if (!base.CheckClearObject(EntityComponentSystem.ClearObject<List<AActor>>(this.ChildrenAttached), "ChildrenAttached"))
			{
				return false;
			}
		}
		if (base.CanResetComponentProperty("IsLockScale"))
		{
			this.IsLockScale = bulletActorComponent.IsLockScale;
		}
		return true;
	}

	// Token: 0x0400B81C RID: 47132
	private EBulletShape? Shape;

	// Token: 0x0400B81D RID: 47133
	public bool NeedDetach;

	// Token: 0x0400B81E RID: 47134
	public bool NeedDetachForBaseMovement;

	// Token: 0x0400B81F RID: 47135
	public List<AActor> ChildrenAttached = new List<AActor>();

	// Token: 0x0400B820 RID: 47136
	private bool IsLockScale;
}
