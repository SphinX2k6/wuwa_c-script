using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x02002DA2 RID: 11682
[NullableContext(1)]
[Nullable(0)]
public static class BulletActorPool
{
	// Token: 0x0601887F RID: 100479 RVA: 0x006446C0 File Offset: 0x006428C0
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

	// Token: 0x06018880 RID: 100480 RVA: 0x00644794 File Offset: 0x00642994
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

	// Token: 0x06018881 RID: 100481 RVA: 0x0064488C File Offset: 0x00642A8C
	public static void Preload()
	{
		BulletActorPool.PreloadByShape(EBulletShape.Cube, UBoxComponent.StaticClass());
		BulletActorPool.PreloadByShape(EBulletShape.Sphere, USphereComponent.StaticClass());
		BulletActorPool.PreloadByShape(EBulletShape.Cylinder, UBoxComponent.StaticClass());
		BulletActorPool.PreloadByShape(EBulletShape.Ray, default(UClassStackOnlyPtr));
	}

	// Token: 0x06018882 RID: 100482 RVA: 0x006448CC File Offset: 0x00642ACC
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

	// Token: 0x06018883 RID: 100483 RVA: 0x00644A0C File Offset: 0x00642C0C
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

	// Token: 0x0400B5ED RID: 46573
	private const int SIZE_POOL = 30;

	// Token: 0x0400B5EE RID: 46574
	private const int PRE_ADD_COUNT = 5;

	// Token: 0x0400B5EF RID: 46575
	[StaticVariableRuleIgnore]
	private static readonly Dictionary<EBulletShape, List<AKuroEntityActor>> ActorPool = new Dictionary<EBulletShape, List<AKuroEntityActor>>();
}
