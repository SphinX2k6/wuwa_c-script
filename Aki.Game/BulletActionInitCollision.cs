using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Core.Fight;
using CSharpScript.Game.Utils;
using UnrealEngine;

// Token: 0x020022EA RID: 8938
[NullableContext(1)]
[Nullable(0)]
public class BulletActionInitCollision : BulletActionBase
{
	// Token: 0x060160A0 RID: 90272 RVA: 0x00662C51 File Offset: 0x00660E51
	public BulletActionInitCollision(EBulletAction type) : base(type)
	{
	}

	// Token: 0x060160A1 RID: 90273 RVA: 0x00662C5A File Offset: 0x00660E5A
	public override void Clear()
	{
		base.Clear();
		this.CollisionInfo = null;
	}

	// Token: 0x060160A2 RID: 90274 RVA: 0x00662C6C File Offset: 0x00660E6C
	protected unsafe override void OnExecute()
	{
		this.CollisionInfo = this.BulletInfo.CollisionInfo;
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		this.CollisionInfo.StageInterval = 1;
		this.CollisionInfo.AllowedEnergy = true;
		this.CollisionInfo.AllowedAddEnergyBuff = true;
		float num = bulletDataMain.Base.CollisionActiveDelay * (float)TimeUtil.Instance.InverseMillisecond;
		this.CollisionInfo.ActiveDelayMs = ((num > 0f) ? num : 0f);
		this.CollisionInfo.ActiveLengthMs = bulletDataMain.Base.CollisionActiveDuration * (float)TimeUtil.Instance.InverseMillisecond;
		this.CollisionInfo.IsPassDelay = (this.CollisionInfo.ActiveDelayMs <= 0f);
		this.CollisionInfo.IntervalMs = bulletDataMain.Base.Interval * (float)TimeUtil.Instance.InverseMillisecond;
		BulletAdditionInfo additionInfo = this.BulletInfo.AdditionInfo;
		if (additionInfo != null && additionInfo.Valid)
		{
			this.CollisionInfo.IntervalMs *= additionInfo.IntervalScale;
		}
		this.CollisionInfo.IsProcessOpen = this.CollisionInfo.IsPassDelay;
		this.CollisionInfo.FinalScale.FromUeVector(bulletDataMain.Scale.SizeScale);
		this.InitPreResolvedDamageIds(bulletDataMain.Base.DamageId, bulletDataMain.Base.MultiDamageId);
		this.CollisionInfo.SetDamageIdByOriginal(bulletDataMain.Base.DamageId);
		this.CollisionInfo.BeHitEffect = bulletDataMain.Base.BeHitEffect;
		this.CollisionInfo.WeaknessBeHitEffect = bulletDataMain.Base.HitEffectWeakness;
		BulletCollisionInfo collisionInfo = this.CollisionInfo;
		bool needHitObstacles;
		if (!bulletDataMain.Logic.DestroyOnHitObstacle)
		{
			BulletChildInfo childInfo = this.BulletInfo.ChildInfo;
			if ((childInfo == null || !childInfo.HaveSpecialChildrenBullet) && !bulletDataMain.Render.EffectOnHit.ContainsKey(EBulletHitEffect.碰撞障碍物触发))
			{
				needHitObstacles = this.BulletInfo.ActionLogicComponent.ObstaclesDetect;
				goto IL_1E8;
			}
		}
		needHitObstacles = true;
		IL_1E8:
		collisionInfo.NeedHitObstacles = needHitObstacles;
		this.InitCollisionByShape(bulletDataMain.Base.Shape, this.BulletInfo.BaseSize);
		if (!this.BulletInfo.CloseCollision && bulletDataMain.Base.Shape != EBulletShape.Ray)
		{
			this.UpdateCollisionLocationAndExtend();
			if (this.BulletInfo.IsCollisionRelativeRotationModify)
			{
				FHitResult fhitResult = new FHitResult();
				if (this.CollisionInfo.CollisionComponent != null)
				{
					this.CollisionInfo.CollisionComponent.K2_SetRelativeRotation(bulletDataMain.Base.Rotator.ToUeRotator(), false, ref fhitResult, true);
				}
				else if (this.CollisionInfo.RegionComponent != null)
				{
					this.CollisionInfo.RegionComponent.K2_SetRelativeRotation(bulletDataMain.Base.Rotator.ToUeRotator(), false, ref fhitResult, true);
				}
			}
			this.CollisionInfo.HasObstaclesCollision = (bulletDataMain.Obstacle.Radius > 0f);
			this.EnableCollision();
		}
		else
		{
			this.BulletInfo.IsCollisionRelativeLocationZero = true;
		}
		this.CollisionInfo.LastFramePosition.FromUeVector(this.BulletInfo.GetCollisionLocation(false));
		if (BulletConstant.Instance.OpenMoveLog)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "BulletActionInitCollision";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0);
			string item = "Bullet";
			BulletInfo bulletInfo = this.BulletInfo;
			ptr = new ValueTuple<string, object>(item, (bulletInfo != null) ? bulletInfo.BulletRowName : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Location", this.CollisionInfo.LastFramePosition);
			instance.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
		}
		if (this.CollisionInfo.ActiveDelayMs <= 0f)
		{
			this.CollisionInfo.IsStartup = true;
		}
	}

	// Token: 0x060160A3 RID: 90275 RVA: 0x00663008 File Offset: 0x00661208
	[NullableContext(2)]
	private void InitPreResolvedDamageIds(long damageId, long[] multiDamageId)
	{
		Entity attacker = this.BulletInfo.Attacker;
		this.TryRecordPreResolvedDamageId(damageId, attacker);
		if (multiDamageId == null)
		{
			return;
		}
		foreach (long damageId2 in multiDamageId)
		{
			this.TryRecordPreResolvedDamageId(damageId2, attacker);
		}
	}

	// Token: 0x060160A4 RID: 90276 RVA: 0x0066304C File Offset: 0x0066124C
	private void TryRecordPreResolvedDamageId(long damageId, Entity attacker)
	{
		if (damageId <= 0L || !ExpressionTreeController.Instance.ShouldPreResolveDamageIdByExecutionTiming(damageId))
		{
			return;
		}
		long effectDamageId = ExpressionTreeController.Instance.GetEffectDamageId(damageId, attacker);
		this.CollisionInfo.RecordPreResolvedDamageId(damageId, effectDamageId);
	}

	// Token: 0x060160A5 RID: 90277 RVA: 0x00663088 File Offset: 0x00661288
	private void InitCollisionByShape(EBulletShape shape, Vector size)
	{
		switch (shape)
		{
		case EBulletShape.Cube:
			this.InitCollisionCube();
			return;
		case EBulletShape.Sphere:
			this.InitCollisionSphere();
			return;
		case EBulletShape.Sector:
			this.InitCollisionSector();
			return;
		case EBulletShape.Cylinder:
			this.InitCollisionCylinder();
			return;
		case EBulletShape.Ray:
			this.InitCollisionRay();
			return;
		case EBulletShape.Other:
			break;
		case EBulletShape.BigCube:
			this.InitCollisionBigShape(UKuroRegionBoxComponent.StaticClass());
			this.BulletInfo.CloseCollision = (size.X <= 0.0 || size.Y <= 0.0 || size.Z <= 0.0);
			return;
		case EBulletShape.BigSphere:
			this.BulletInfo.CloseCollision = (size.X <= 0.0);
			return;
		case EBulletShape.BigSector:
			this.InitCollisionBigShape(UKuroRegionSectorComponent.StaticClass());
			this.BulletInfo.CloseCollision = (size.X <= 0.0 || size.Z <= 0.0);
			return;
		case EBulletShape.BigCylinder:
			this.InitCollisionBigShape(UKuroRegionCylinderComponent.StaticClass());
			this.BulletInfo.CloseCollision = (size.X <= 0.0 || size.Z <= 0.0);
			break;
		default:
			return;
		}
	}

	// Token: 0x060160A6 RID: 90278 RVA: 0x006631D4 File Offset: 0x006613D4
	private void InitCollisionCube()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		AActor actor = this.BulletInfo.Actor;
		Vector baseSize = this.BulletInfo.BaseSize;
		UActorComponent uactorComponent2;
		UActorComponent uactorComponent = uactorComponent2 = actor.GetComponentByClass(UBoxComponent.StaticClass());
		if (uactorComponent == null)
		{
			uactorComponent2 = actor.AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, true, default(FName));
		}
		this.BulletInfo.CloseCollision = (baseSize.X <= 0.0 || baseSize.Y <= 0.0 || baseSize.Z <= 0.0);
		UBoxComponent uboxComponent = uactorComponent2 as UBoxComponent;
		this.CollisionInfo.CollisionComponent = uboxComponent;
		if (BulletModel.Instance.ShowBulletCollision(this.BulletInfo.Attacker.Id))
		{
			uboxComponent.LineThickness = 5f;
			uboxComponent.ShapeColor = ColorUtils.ColorYellow;
		}
		uboxComponent.SetCollisionProfileName(bulletDataMain.Logic.ProfileName, true);
		this.SetCollisionIgnoreChannels(uboxComponent);
		if (uactorComponent == null)
		{
			if (GlobalData.IsPlayInEditor && BulletConstant.Instance.CollisionCompVisibleInEditor)
			{
				this.CollisionInfo.CollisionComponent.CreationMethod = EComponentCreationMethod.Instance;
			}
			actor.FinishAddComponent(uboxComponent, false, MathUtils.Instance.DefaultTransform);
		}
	}

	// Token: 0x060160A7 RID: 90279 RVA: 0x0066331C File Offset: 0x0066151C
	private void InitCollisionSphere()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		AActor actor = this.BulletInfo.Actor;
		Vector baseSize = this.BulletInfo.BaseSize;
		UActorComponent uactorComponent2;
		UActorComponent uactorComponent = uactorComponent2 = actor.GetComponentByClass(USphereComponent.StaticClass());
		if (uactorComponent == null)
		{
			uactorComponent2 = actor.AddComponentByClass(USphereComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, true, default(FName));
		}
		this.BulletInfo.CloseCollision = (baseSize.X <= 0.0);
		USphereComponent usphereComponent = uactorComponent2 as USphereComponent;
		this.CollisionInfo.CollisionComponent = usphereComponent;
		usphereComponent.SetCollisionProfileName(bulletDataMain.Logic.ProfileName, true);
		this.SetCollisionIgnoreChannels(usphereComponent);
		if (uactorComponent == null)
		{
			if (GlobalData.IsPlayInEditor && BulletConstant.Instance.CollisionCompVisibleInEditor)
			{
				this.CollisionInfo.CollisionComponent.CreationMethod = EComponentCreationMethod.Instance;
			}
			actor.FinishAddComponent(usphereComponent, false, MathUtils.Instance.DefaultTransform);
		}
	}

	// Token: 0x060160A8 RID: 90280 RVA: 0x0066340C File Offset: 0x0066160C
	private void InitCollisionSector()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		AActor actor = this.BulletInfo.Actor;
		Vector baseSize = this.BulletInfo.BaseSize;
		this.BulletInfo.CloseCollision = (baseSize.X <= 0.0 || baseSize.Z <= 0.0);
		UActorComponent uactorComponent2;
		UActorComponent uactorComponent = uactorComponent2 = actor.GetComponentByClass(UBoxComponent.StaticClass());
		if (uactorComponent == null)
		{
			uactorComponent2 = actor.AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, true, default(FName));
		}
		UBoxComponent uboxComponent = uactorComponent2 as UBoxComponent;
		this.CollisionInfo.CollisionComponent = uboxComponent;
		if (BulletModel.Instance.ShowBulletCollision(this.BulletInfo.Attacker.Id))
		{
			uboxComponent.LineThickness = 2f;
			uboxComponent.ShapeColor = ColorUtils.ColorYellow;
		}
		uboxComponent.SetCollisionProfileName(bulletDataMain.Logic.ProfileName, true);
		this.SetCollisionIgnoreChannels(uboxComponent);
		if (uactorComponent == null)
		{
			if (GlobalData.IsPlayInEditor && BulletConstant.Instance.CollisionCompVisibleInEditor)
			{
				this.CollisionInfo.CollisionComponent.CreationMethod = EComponentCreationMethod.Instance;
			}
			actor.FinishAddComponent(uboxComponent, false, MathUtils.Instance.DefaultTransform);
		}
	}

	// Token: 0x060160A9 RID: 90281 RVA: 0x00663540 File Offset: 0x00661740
	private void InitCollisionCylinder()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		AActor actor = this.BulletInfo.Actor;
		Vector baseSize = this.BulletInfo.BaseSize;
		this.BulletInfo.CloseCollision = (baseSize.X <= 0.0 || baseSize.Z <= 0.0);
		UActorComponent uactorComponent2;
		UActorComponent uactorComponent = uactorComponent2 = actor.GetComponentByClass(UBoxComponent.StaticClass());
		if (uactorComponent == null)
		{
			uactorComponent2 = actor.AddComponentByClass(UBoxComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, true, default(FName));
		}
		UBoxComponent uboxComponent = uactorComponent2 as UBoxComponent;
		this.CollisionInfo.CollisionComponent = uboxComponent;
		if (BulletModel.Instance.ShowBulletCollision(this.BulletInfo.Attacker.Id))
		{
			uboxComponent.LineThickness = 2f;
			uboxComponent.ShapeColor = ColorUtils.ColorYellow;
		}
		uboxComponent.SetCollisionProfileName(bulletDataMain.Logic.ProfileName, true);
		this.SetCollisionIgnoreChannels(uboxComponent);
		if (uactorComponent == null)
		{
			if (GlobalData.IsPlayInEditor && BulletConstant.Instance.CollisionCompVisibleInEditor)
			{
				this.CollisionInfo.CollisionComponent.CreationMethod = EComponentCreationMethod.Instance;
			}
			actor.FinishAddComponent(uboxComponent, false, MathUtils.Instance.DefaultTransform);
		}
	}

	// Token: 0x060160AA RID: 90282 RVA: 0x00663674 File Offset: 0x00661874
	private void InitCollisionRay()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		BulletRayInfo rayInfo = this.BulletInfo.RayInfo;
		rayInfo.Speed = (double)((float)(this.BulletInfo.Size.X / (double)TimeUtil.Instance.InverseMillisecond));
		rayInfo.BlockByCharacter = (bulletDataMain.Base.SpecialParams.GetValueOrDefault(EBulletBaseSpecificParam.角色阻挡激光) != "f");
	}

	// Token: 0x060160AB RID: 90283 RVA: 0x006636DC File Offset: 0x006618DC
	private void InitCollisionBigShape(UClassStackOnlyPtr regionShapeComponentClass)
	{
		AActor actor = this.BulletInfo.Actor;
		bool flag = GlobalData.IsPlayInEditor && BulletConstant.Instance.CollisionCompVisibleInEditor;
		UKuroRegionDetectComponent ukuroRegionDetectComponent = actor.GetComponentByClass(UKuroRegionDetectComponent.StaticClass()) as UKuroRegionDetectComponent;
		UKuroRegionDetectComponent ukuroRegionDetectComponent2;
		if ((ukuroRegionDetectComponent2 = ukuroRegionDetectComponent) == null)
		{
			ukuroRegionDetectComponent2 = (actor.AddComponentByClass(UKuroRegionDetectComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, flag, default(FName)) as UKuroRegionDetectComponent);
		}
		UKuroRegionDetectComponent ukuroRegionDetectComponent3 = ukuroRegionDetectComponent2;
		this.CollisionInfo.RegionDetectComponent = ukuroRegionDetectComponent3;
		UKuroRegionShapeComponent ukuroRegionShapeComponent = actor.GetComponentByClass(regionShapeComponentClass) as UKuroRegionShapeComponent;
		UKuroRegionShapeComponent ukuroRegionShapeComponent2;
		if ((ukuroRegionShapeComponent2 = ukuroRegionShapeComponent) == null)
		{
			ukuroRegionShapeComponent2 = (actor.AddComponentByClass(regionShapeComponentClass, false, MathUtils.Instance.DefaultTransform, flag, default(FName)) as UKuroRegionShapeComponent);
		}
		UKuroRegionShapeComponent ukuroRegionShapeComponent3 = ukuroRegionShapeComponent2;
		this.CollisionInfo.RegionComponent = ukuroRegionShapeComponent3;
		ukuroRegionDetectComponent3.RegionMap.Add(BulletConstant.Instance.RegionKey, ukuroRegionShapeComponent3);
		if (flag)
		{
			if (ukuroRegionDetectComponent == null)
			{
				ukuroRegionDetectComponent3.CreationMethod = EComponentCreationMethod.Instance;
				actor.FinishAddComponent(ukuroRegionDetectComponent3, false, MathUtils.Instance.DefaultTransform);
			}
			if (ukuroRegionShapeComponent == null)
			{
				ukuroRegionShapeComponent3.CreationMethod = EComponentCreationMethod.Instance;
				actor.FinishAddComponent(ukuroRegionShapeComponent3, false, MathUtils.Instance.DefaultTransform);
			}
		}
	}

	// Token: 0x060160AC RID: 90284 RVA: 0x00663804 File Offset: 0x00661A04
	private void UpdateCollisionLocationAndExtend()
	{
		BulletDataMain bulletDataMain = this.BulletInfo.BulletDataMain;
		UPrimitiveComponent collisionComponent = this.CollisionInfo.CollisionComponent;
		UKuroRegionShapeComponent regionComponent = this.CollisionInfo.RegionComponent;
		Vector centerLocalLocation = this.CollisionInfo.CenterLocalLocation;
		centerLocalLocation.FromUeVector(bulletDataMain.Base.CenterOffset);
		if (bulletDataMain.Base.Shape == EBulletShape.BigSphere)
		{
			if (!centerLocalLocation.IsZero())
			{
				Log.Instance.Warn(ELogModule.Bullet, ELogAuthor.CFT, "出于性能考虑，大球体的中心位置偏移不会生效", default(ReadOnlySpan<ValueTuple<string, object>>));
				centerLocalLocation.Reset();
			}
			this.BulletInfo.IsCollisionRelativeLocationZero = true;
			return;
		}
		Vector size = this.BulletInfo.Size;
		if (bulletDataMain.Base.Shape != EBulletShape.Sector)
		{
			if (!centerLocalLocation.IsZero())
			{
				FHitResult fhitResult = new FHitResult();
				if (collisionComponent != null)
				{
					collisionComponent.D_K2_SetRelativeLocation(centerLocalLocation.ToUeVector(false), false, ref fhitResult, true);
				}
				else if (regionComponent != null)
				{
					regionComponent.D_K2_SetRelativeLocation(centerLocalLocation.ToUeVector(false), false, ref fhitResult, true);
				}
			}
			else
			{
				this.BulletInfo.IsCollisionRelativeLocationZero = true;
			}
		}
		else if (size.Y >= 360.0)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.CFT;
			string message = "扇形子弹的角度超过360！请使用柱形";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ID", this.BulletInfo.BulletRowName);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			size.Y = 360.0;
		}
		else if (size.Y <= 0.0)
		{
			Log instance2 = Log.Instance;
			ELogModule module2 = ELogModule.Bullet;
			ELogAuthor author2 = ELogAuthor.CFT;
			string message2 = "扇形子弹的角度小于0！请检查";
			ValueTuple<string, object> valueTuple2 = new ValueTuple<string, object>("ID", this.BulletInfo.BulletRowName);
			instance2.Error(module2, author2, message2, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple2));
			size.Y = 90.0;
		}
		if (collisionComponent != null)
		{
			BulletCollisionUtil.UpdateCollisionExtend(bulletDataMain.Base.Shape, collisionComponent, size, centerLocalLocation, bulletDataMain.Base.Rotator);
			return;
		}
		if (regionComponent != null)
		{
			BulletCollisionUtil.UpdateRegionExtend(bulletDataMain.Base.Shape, regionComponent, size);
		}
	}

	// Token: 0x060160AD RID: 90285 RVA: 0x006639EC File Offset: 0x00661BEC
	private void EnableCollision()
	{
		this.BulletInfo.Actor.SetActorHiddenInGame(false);
		BulletCollisionInfo collisionInfo = this.CollisionInfo;
		UPrimitiveComponent uprimitiveComponent = (collisionInfo != null) ? collisionInfo.CollisionComponent : null;
		if (uprimitiveComponent == null)
		{
			return;
		}
		uprimitiveComponent.bAsyncOverlap = true;
		uprimitiveComponent.bKuroOverlapNotify = false;
		uprimitiveComponent.bReceivedAsyncOverlapResult = false;
		bool needHitObstacles = this.CollisionInfo.NeedHitObstacles;
		bool isOversizeForTrace = this.BulletInfo.BulletDataMain.Base.IsOversizeForTrace;
		bool flag;
		if (this.CollisionInfo.HasObstaclesCollision)
		{
			flag = (!isOversizeForTrace && this.BulletInfo.ActorComponent.NeedDetach && !this.BulletInfo.ActorComponent.NeedDetachForBaseMovement);
		}
		else if (needHitObstacles)
		{
			flag = !isOversizeForTrace;
		}
		else
		{
			flag = (!isOversizeForTrace && this.BulletInfo.ActorComponent.NeedDetach && !this.BulletInfo.ActorComponent.NeedDetachForBaseMovement);
		}
		if (flag)
		{
			uprimitiveComponent.SetCollisionProfileName(BulletConstant.Instance.ProfileNameOnlyBullet, true);
		}
		this.BulletInfo.Actor.SetActorEnableCollision(true);
		this.CheckNeedKuroFastCollision();
	}

	// Token: 0x060160AE RID: 90286 RVA: 0x00663AF8 File Offset: 0x00661CF8
	private void CheckNeedKuroFastCollision()
	{
		UKuroFastCollisionAlgorithm kuroFastCollisionAlgorithm = BulletPatternComponent.GetKuroFastCollisionAlgorithm();
		if (kuroFastCollisionAlgorithm == null)
		{
			return;
		}
		EntityHandle attackerHandle = this.BulletInfo.AttackerHandle;
		int? num = (attackerHandle != null) ? new int?(attackerHandle.EntityType) : null;
		int num2 = 0;
		if (!(num.GetValueOrDefault() == num2 & num != null))
		{
			return;
		}
		if (!this.BulletInfo.BulletDataMain.Logic.CanCounterAttack)
		{
			return;
		}
		BulletKuroFastCollisionInfo bulletKuroFastCollisionInfo = new BulletKuroFastCollisionInfo();
		bulletKuroFastCollisionInfo.RegisterCollision(this.BulletInfo, kuroFastCollisionAlgorithm);
		this.BulletInfo.KuroFastCollisionInfo = bulletKuroFastCollisionInfo;
		if (bulletKuroFastCollisionInfo.WorldBulletComponent != null)
		{
			BulletCollisionInfo collisionInfo = this.BulletInfo.CollisionInfo;
			if (collisionInfo.ActiveDelayMs <= 0f && collisionInfo.ActiveLengthMs <= 0f)
			{
				bulletKuroFastCollisionInfo.SetWorldBulletComponentEnable(true);
				return;
			}
			BulletController.Instance.AddSimpleAction(this.BulletInfo, EBulletAction.UpdateKfc);
		}
	}

	// Token: 0x060160AF RID: 90287 RVA: 0x00663BD0 File Offset: 0x00661DD0
	protected void SetCollisionIgnoreChannels(UPrimitiveComponent primitiveComponent)
	{
		foreach (ECollisionChannel channel in this.CollisionInfo.IgnoreChannels)
		{
			primitiveComponent.SetCollisionResponseToChannel(channel, ECollisionResponse.ECR_Ignore);
		}
	}

	// Token: 0x0400B932 RID: 47410
	[Nullable(2)]
	protected BulletCollisionInfo CollisionInfo;
}
