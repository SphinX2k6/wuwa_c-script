using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game;
using CSharpScript.Game.Camera;
using UnrealEngine;

// Token: 0x02002DC8 RID: 11720
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicBulletCollisionController : BulletLogicController<LogicDataBulletCollision, BulletInfo>
{
	// Token: 0x060189F1 RID: 100849 RVA: 0x0064B601 File Offset: 0x00649801
	public BulletLogicBulletCollisionController(LogicDataBulletCollision logicConfig, Entity bullet) : base(logicConfig, bullet)
	{
		this.ActorComponent = bullet.GetComponent<BulletActorComponent>();
		this.BulletInfo = this.Bullet.GetBulletInfo();
	}

	// Token: 0x060189F2 RID: 100850 RVA: 0x0064B634 File Offset: 0x00649834
	[NullableContext(2)]
	public override void BulletLogicAction(BulletInfo otherBulletInfo = null)
	{
		if (this.BulletInfo.AttackerId != otherBulletInfo.AttackerId)
		{
			return;
		}
		TArray<string> triggerBulletIds = this.LogicController.TriggerBulletIds;
		if (triggerBulletIds != null && triggerBulletIds.Num() > 0)
		{
			string bulletRowName = otherBulletInfo.BulletRowName;
			bool flag = false;
			for (int i = 0; i < triggerBulletIds.Num(); i++)
			{
				if (triggerBulletIds.Get(i) == bulletRowName)
				{
					flag = true;
					break;
				}
			}
			if (!flag)
			{
				return;
			}
		}
		int bulletEntityId = otherBulletInfo.BulletEntityId;
		if (this.TriggeredBulletIds.Contains(bulletEntityId))
		{
			return;
		}
		global::Vector actorLocationProxy = this.ActorComponent.ActorLocationProxy;
		global::Vector vector = BulletPool.CreateVector(false);
		switch (this.LogicController.BulletPosition)
		{
		case 1:
			vector.FromUeVector(actorLocationProxy);
			goto IL_F8;
		case 2:
			if (!this.ComputeSelfRadiusPoint(otherBulletInfo, vector))
			{
				BulletPool.RecycleVector(vector);
				return;
			}
			goto IL_F8;
		}
		BulletActorComponent component = otherBulletInfo.Entity.GetComponent<BulletActorComponent>();
		actorLocationProxy.Addition(component.ActorLocationProxy, vector);
		vector.MultiplyEqual(0.5);
		IL_F8:
		this.TriggeredBulletIds.Add(bulletEntityId);
		EBulletCollisionDestroyType destroyType = (EBulletCollisionDestroyType)this.LogicController.DestroyType;
		if (destroyType == EBulletCollisionDestroyType.DestroySelf || destroyType == EBulletCollisionDestroyType.DestroyBoth)
		{
			BulletController.Instance.DestroyBullet(this.BulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
		}
		if (destroyType == EBulletCollisionDestroyType.DestroyOther || destroyType == EBulletCollisionDestroyType.DestroyBoth)
		{
			BulletController.Instance.DestroyBullet(otherBulletInfo.BulletEntityId, false, EBulletDestroyReason.Normal, false);
		}
		FVector b;
		FVectorDouble fvectorDouble;
		if (this.LogicController.EffectCollision != null)
		{
			TSoftObjectPtr<UObject> tsoftObjectPtr = this.LogicController.EffectCollision.As<UObject>();
			if (UKismetSystemLibrary.IsValidSoftObjectReference(tsoftObjectPtr))
			{
				global::Vector vector2 = BulletPool.CreateVector(false);
				FVector positionOffset = this.LogicController.PositionOffset;
				b = default(FVector);
				if (positionOffset != b)
				{
					vector2.Set(vector.X + (double)this.LogicController.PositionOffset.X, vector.Y + (double)this.LogicController.PositionOffset.Y, vector.Z + (double)this.LogicController.PositionOffset.Z);
				}
				else
				{
					vector2.Set(vector.X, vector.Y, vector.Z);
				}
				FRotator rotationOffset = this.LogicController.RotationOffset;
				fvectorDouble = vector2.ToUeVector(false);
				b = global::Vector.OneVectorDouble;
				FTransformDouble transform = new FTransformDouble(ref rotationOffset, ref fvectorDouble, ref b);
				BulletStaticFunction.PlayBulletEffect(this.BulletInfo.Actor, this.LogicController.EffectCollision.ToAssetPathName(), transform, this.BulletInfo, "BulletCollision");
				BulletPool.RecycleVector(vector2);
			}
		}
		if (this.LogicController.ScreenShake != null)
		{
			TSoftClassPtr<UObject> tsoftClassPtr = this.LogicController.ScreenShake.As<UObject>();
			if (UKismetSystemLibrary.IsValidSoftClassReference(tsoftClassPtr) && CharacterUtils.CanCharacterMonsterOrSummonedDisplayEffect(this.BulletInfo.AttackerHandle))
			{
				ResourceSystem.Instance.LoadAsync<UClass>(this.LogicController.ScreenShake.ToAssetPathName(), delegate([Nullable(2)] UClass shakeType, string path)
				{
					FVectorDouble value2 = Global.CharacterCameraManager.D_GetCameraLocation();
					CameraController.Instance.PlayWorldCameraShake(shakeType, new FVectorDouble?(value2), 0f, 100f, 1f, false, "MainCamera");
				}, 100, "js_undefined");
			}
		}
		if (this.LogicController.CameraModified != null)
		{
			CameraController.Instance.MainModel.FightCamera.GetComponent<FightCameraLogicComponent>().ApplyCameraModify(null, this.LogicController.CameraModified.持续时间, this.LogicController.CameraModified.淡入时间, this.LogicController.CameraModified.淡出时间, this.LogicController.CameraModified.摄像机配置, null, 0.2f, null, null, default(OneOf<TsBaseCharacter, TsBaseVehicle>), "", default(OneOf<TsBaseCharacter, TsBaseVehicle>));
		}
		TArray<string> bulletRowName2 = this.LogicController.BulletRowName;
		int num = (bulletRowName2 != null) ? bulletRowName2.Num() : 0;
		long? contextId = this.BulletInfo.ContextId;
		FRotator rotationOffset2 = this.LogicController.RotationOffset;
		fvectorDouble = vector.ToUeVector(false);
		b = global::Vector.OneVectorDouble;
		FTransformDouble value = new FTransformDouble(ref rotationOffset2, ref fvectorDouble, ref b);
		for (int j = 0; j < num; j++)
		{
			string bulletRowName3 = this.LogicController.BulletRowName.Get(j);
			HashSet<string> parentIds = BulletUtil.CollectParentsId(this.BulletInfo);
			BulletEntity bulletEntity = BulletController.Instance.CreateBulletCustomTarget(this.BulletInfo.Attacker, bulletRowName3, new FTransformDouble?(value), new BulletController.BulletCreateParams
			{
				SyncType = EBulletSyncType.SyncCreate,
				ParentId = this.Bullet.Id,
				SkillId = this.BulletInfo.BulletInitParams.SkillId,
				SkillContextId = this.BulletInfo.BulletInitParams.SkillContextId,
				Source = Aki.Protocol.EBulletCreateSource.CollisionSpawnSource,
				BattleContext = this.BulletInfo.BulletInitParams.BattleContext,
				ParentIds = parentIds
			}, contextId, global::EBulletCreateSource.Others);
			if (bulletEntity != null && bulletEntity.Valid)
			{
				BulletInfo bulletInfo = bulletEntity.GetBulletInfo();
				if (bulletInfo.BulletDataMain.Render.HandOverParentEffect)
				{
					BulletStaticFunction.HandOverEffects(this.BulletInfo, bulletInfo);
				}
			}
		}
		BulletPool.RecycleVector(vector);
	}

	// Token: 0x060189F3 RID: 100851 RVA: 0x0064BB2F File Offset: 0x00649D2F
	public override void OnBulletDestroy()
	{
		this.TriggeredBulletIds.Clear();
	}

	// Token: 0x060189F4 RID: 100852 RVA: 0x0064BB3C File Offset: 0x00649D3C
	private unsafe bool ComputeSelfRadiusPoint(BulletInfo otherBulletInfo, global::Vector outLocation)
	{
		EBulletShape shape = this.BulletInfo.BulletDataMain.Base.Shape;
		if (shape != EBulletShape.Sphere && shape != EBulletShape.Cylinder)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Bullet;
			ELogAuthor author = ELogAuthor.HCW;
			string message = "子弹互撞：生成位置配置为“GB外径上朝向引信方向的点”时，子弹形状必须为球形或圆柱";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("BulletId", this.BulletInfo.BulletRowName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Shape", shape);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		double x = this.BulletInfo.Size.X;
		global::Vector vector = BulletPool.CreateVector(false);
		global::Vector centerLocation = this.BulletInfo.CenterLocation;
		vector.Set(centerLocation.X, centerLocation.Y, centerLocation.Z);
		global::Vector vector2 = BulletPool.CreateVector(false);
		otherBulletInfo.CenterLocation.Subtraction(vector, vector2);
		bool result = false;
		if (shape == EBulletShape.Cylinder)
		{
			double num = vector2.Size2D();
			if (num >= x)
			{
				double num2 = x / num;
				double z = this.BulletInfo.Size.Z;
				double num3 = Math.Max(-z, Math.Min(z, vector2.Z));
				outLocation.Set(vector.X + vector2.X * num2, vector.Y + vector2.Y * num2, vector.Z + num3);
				result = true;
			}
		}
		else if (vector2.Size() >= x && vector2.Normalize(9.99999993922529E-09))
		{
			vector2.MultiplyEqual(x);
			outLocation.Set(vector.X + vector2.X, vector.Y + vector2.Y, vector.Z + vector2.Z);
			result = true;
		}
		BulletPool.RecycleVector(vector);
		BulletPool.RecycleVector(vector2);
		return result;
	}

	// Token: 0x0400B748 RID: 46920
	private const float OUTER_RADIUS = 100f;

	// Token: 0x0400B749 RID: 46921
	[Nullable(2)]
	private readonly BulletActorComponent ActorComponent;

	// Token: 0x0400B74A RID: 46922
	[Nullable(2)]
	private readonly BulletInfo BulletInfo;

	// Token: 0x0400B74B RID: 46923
	private readonly HashSet<int> TriggeredBulletIds = new HashSet<int>();
}
