using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020022FC RID: 8956
[NullableContext(1)]
[Nullable(0)]
public static class BulletActorPool
{
	// Token: 0x06016124 RID: 90404 RVA: 0x0066A4FC File Offset: 0x006686FC
	public static AKuroEntityActor Get(EBulletShape shape)
	{
		AKuroEntityActor akuroEntityActor = null;
		if (BulletActorPool.ActorPool.ContainsKey(shape))
		{
			List<AKuroEntityActor> list = BulletActorPool.ActorPool[shape];
			while (akuroEntityActor == null && list.Count > 0)
			{
				akuroEntityActor = list[list.Count - 1];
				list.RemoveAt(list.Count - 1);
				if (akuroEntityActor == null || !akuroEntityActor.IsValid())
				{
					akuroEntityActor = null;
				}
			}
		}
		if (akuroEntityActor == null)
		{
			akuroEntityActor = (ActorSystem.Instance.Get(AKuroEntityActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as AKuroEntityActor);
			if (((akuroEntityActor != null) ? akuroEntityActor.GetComponentByClass(USceneComponent.StaticClass()) : null) == null)
			{
				akuroEntityActor.AddComponentByClass(USceneComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
			}
			akuroEntityActor.bAutoDestroyWhenFinished = false;
			akuroEntityActor.SetActorEnableCollision(false);
		}
		return akuroEntityActor;
	}

	// Token: 0x06016125 RID: 90405 RVA: 0x0066A5D0 File Offset: 0x006687D0
	public static void Recycle(AKuroEntityActor actor, EBulletShape shape, bool needDetach = false)
	{
		actor.SetActorHiddenInGame(true);
		actor.SetActorEnableCollision(false);
		if (needDetach)
		{
			actor.K2_DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			actor.D_SetActorScale3D(Vector.OneVectorDouble);
		}
		if (BulletConstant.Instance.OpenActorRecycleCheck)
		{
			if (actor.D_GetActorScale3D() != Vector.OneVectorDouble)
			{
				Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "bullet actor scale invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
			UShapeComponent ushapeComponent = actor.GetComponentByClass(UShapeComponent.StaticClass()) as UShapeComponent;
			if (ushapeComponent != null && ushapeComponent.RelativeScale3D != Vector.OneVector)
			{
				Log.Instance.Error(ELogModule.Bullet, ELogAuthor.CFT, "bullet collisionComp scale invalid", default(ReadOnlySpan<ValueTuple<string, object>>));
			}
		}
		List<AKuroEntityActor> list;
		if (!BulletActorPool.ActorPool.TryGetValue(shape, out list))
		{
			list = new List<AKuroEntityActor>();
			BulletActorPool.ActorPool.Add(shape, list);
		}
		if (list.Count > 30)
		{
			ActorSystem.Instance.Put("BulletActorPool.Recycle", actor, null);
			return;
		}
		list.Add(actor);
	}

	// Token: 0x06016126 RID: 90406 RVA: 0x0066A6C8 File Offset: 0x006688C8
	public static void Preload()
	{
		BulletActorPool.PreloadByShape(EBulletShape.Cube, UBoxComponent.StaticClass());
		BulletActorPool.PreloadByShape(EBulletShape.Sphere, USphereComponent.StaticClass());
		BulletActorPool.PreloadByShape(EBulletShape.Cylinder, UBoxComponent.StaticClass());
		BulletActorPool.PreloadByShape(EBulletShape.Ray, default(UClassStackOnlyPtr));
	}

	// Token: 0x06016127 RID: 90407 RVA: 0x0066A708 File Offset: 0x00668908
	private static void PreloadByShape(EBulletShape shape, UClassStackOnlyPtr compClass)
	{
		List<AKuroEntityActor> list;
		if (!BulletActorPool.ActorPool.TryGetValue(shape, out list))
		{
			list = new List<AKuroEntityActor>();
			BulletActorPool.ActorPool.Add(shape, list);
		}
		for (int i = list.Count; i < 5; i++)
		{
			AKuroEntityActor akuroEntityActor = ActorSystem.Instance.Get(AKuroEntityActor.StaticClass(), MathUtils.Instance.DefaultTransformDouble, null, true) as AKuroEntityActor;
			if (((akuroEntityActor != null) ? akuroEntityActor.GetComponentByClass(USceneComponent.StaticClass()) : null) == null)
			{
				akuroEntityActor.AddComponentByClass(USceneComponent.StaticClass(), false, MathUtils.Instance.DefaultTransform, false, default(FName));
			}
			akuroEntityActor.bAutoDestroyWhenFinished = false;
			akuroEntityActor.SetActorHiddenInGame(true);
			akuroEntityActor.SetActorEnableCollision(false);
			if (compClass.IsValid())
			{
				if (GlobalData.IsPlayInEditor && BulletConstant.Instance.CollisionCompVisibleInEditor)
				{
					UActorComponent uactorComponent = akuroEntityActor.AddComponentByClass(compClass, false, MathUtils.Instance.DefaultTransform, true, default(FName));
					uactorComponent.CreationMethod = EComponentCreationMethod.Instance;
					akuroEntityActor.FinishAddComponent(uactorComponent, false, MathUtils.Instance.DefaultTransform);
				}
				else
				{
					akuroEntityActor.AddComponentByClass(compClass, false, MathUtils.Instance.DefaultTransform, false, default(FName));
				}
			}
			list.Add(akuroEntityActor);
		}
	}

	// Token: 0x06016128 RID: 90408 RVA: 0x0066A848 File Offset: 0x00668A48
	public static void Clear()
	{
		foreach (List<AKuroEntityActor> list in BulletActorPool.ActorPool.Values)
		{
			foreach (AKuroEntityActor actor in list)
			{
				ActorSystem.Instance.Put("BulletActorPool.Clear", actor, null);
			}
		}
		BulletActorPool.ActorPool.Clear();
	}

	// Token: 0x0400B963 RID: 47459
	private const int SIZE_POOL = 30;

	// Token: 0x0400B964 RID: 47460
	private const int PRE_ADD_COUNT = 5;

	// Token: 0x0400B965 RID: 47461
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EBulletShape, List<AKuroEntityActor>> ActorPool = new Dictionary<EBulletShape, List<AKuroEntityActor>>();
}
