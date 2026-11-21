using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x020061E5 RID: 25061
	[NullableContext(1)]
	[Nullable(0)]
	public class PawnChairController : SubEntityInteractLogicController
	{
		// Token: 0x0603C266 RID: 246374 RVA: 0x0111E501 File Offset: 0x0111C701
		public PawnChairController(CreatureDataComponent creatureDataComp) : base(creatureDataComp)
		{
		}

		// Token: 0x0603C267 RID: 246375 RVA: 0x0111E512 File Offset: 0x0111C712
		public override bool Possess(Entity masterEntity, bool force = false)
		{
			this.MasterEntity = masterEntity;
			return true;
		}

		// Token: 0x0603C268 RID: 246376 RVA: 0x0111E51C File Offset: 0x0111C71C
		public override bool UnPossess(Entity masterEntity)
		{
			this.MasterEntity = null;
			return true;
		}

		// Token: 0x0603C269 RID: 246377 RVA: 0x0111E528 File Offset: 0x0111C728
		public Vector GetSitLocation()
		{
			Vector tmpVector = SubEntityInteractLogicController.TmpVector;
			tmpVector.Reset();
			Vector tmpVector2 = SubEntityInteractLogicController.TmpVector2;
			BaseActorComponent component = this.Entity.GetComponent<BaseActorComponent>();
			tmpVector2.DeepCopy(component.ActorLocationProxy);
			BaseCharacterComponent component2 = this.MasterEntity.GetComponent<BaseCharacterComponent>();
			float scaledHalfHeight = component2.ScaledHalfHeight;
			Vector actorLocationProxy = component2.ActorLocationProxy;
			((this.RealSceneItemActorComp != null) ? this.RealSceneItemActorComp.ActorRightProxy : component.ActorRightProxy).Multiply((double)this.SitPointOffset, tmpVector);
			tmpVector2.Z = ((this.RealSceneItemActorComp != null) ? (this.RealSceneItemActorComp.ActorLocationProxy.Z + (double)scaledHalfHeight) : actorLocationProxy.Z);
			tmpVector.AdditionEqual(tmpVector2);
			return tmpVector;
		}

		// Token: 0x0603C26A RID: 246378 RVA: 0x0111E5D4 File Offset: 0x0111C7D4
		public Vector GetForwardDirection()
		{
			return this.Entity.GetComponent<BaseActorComponent>().ActorRightProxy;
		}

		// Token: 0x0603C26B RID: 246379 RVA: 0x0111E5E8 File Offset: 0x0111C7E8
		private unsafe void IgnoreChairActorsCollision(bool bCollision)
		{
			if (this.RealSceneItemActorComp == null || this.MasterEntity == null)
			{
				return;
			}
			if (!this.RealSceneItemActorComp.GetIsSceneInteractionLoadCompleted())
			{
				return;
			}
			ECollisionResponse newResponse = bCollision ? ECollisionResponse.ECR_Ignore : ECollisionResponse.ECR_Block;
			BaseCharacterComponent component = this.MasterEntity.GetComponent<BaseCharacterComponent>();
			TArray<AActor> tarray = new TArray<AActor>();
			this.RealSceneItemActorComp.Owner.GetAttachedActors(ref tarray, true);
			int num = tarray.Num();
			if (num == 0)
			{
				Log instance = Log.Instance;
				ELogModule module = ELogModule.AI;
				ELogAuthor author = ELogAuthor.YJX;
				string message = "[PawnChairController.IgnoreChairActorsCollision] 场景交互物体未加载完全";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("itemPbDataId", this.CreatureDataComp.GetPbDataId());
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("OwnerPbDataId", this.RealSceneItemActorComp.CreatureData.GetPbDataId());
				instance.Warn(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			}
			for (int i = 0; i < num; i++)
			{
				AActor aactor = tarray.Get(i);
				TArray<AActor> tarray2 = new TArray<AActor>();
				aactor.GetAttachedActors(ref tarray2, true);
				int num2 = tarray2.Num();
				for (int j = 0; j < num2; j++)
				{
					AActor aactor2 = tarray2.Get(j);
					if (aactor2.IsValid())
					{
						component.Actor.IgnoreActorWhenMoving(tarray2.Get(j), bCollision, true);
						AStaticMeshActor astaticMeshActor = aactor2 as AStaticMeshActor;
						if (astaticMeshActor != null && astaticMeshActor.IsValid())
						{
							UStaticMeshComponent ustaticMeshComponent = astaticMeshActor.GetComponentByClass(UStaticMeshComponent.StaticClass()) as UStaticMeshComponent;
							if (ustaticMeshComponent != null)
							{
								ustaticMeshComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, newResponse);
							}
						}
					}
				}
			}
		}

		// Token: 0x0603C26C RID: 246380 RVA: 0x0111E771 File Offset: 0x0111C971
		public void ResetCollision()
		{
			if (this.Entity.GetComponent<SceneItemActorComponent>() == null)
			{
				return;
			}
			this.IgnoreChairActorsCollision(false);
		}

		// Token: 0x0603C26D RID: 246381 RVA: 0x0111E788 File Offset: 0x0111C988
		public void IgnoreCollision()
		{
			if (this.Entity.GetComponent<SceneItemActorComponent>() == null)
			{
				return;
			}
			this.IgnoreChairActorsCollision(true);
		}

		// Token: 0x0603C26E RID: 246382 RVA: 0x0111E7A0 File Offset: 0x0111C9A0
		public bool IsSceneInteractionLoadCompleted()
		{
			SceneItemActorComponent component = this.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null || !component.GetIsSceneInteractionLoadCompleted())
			{
				return false;
			}
			int pbDataId = this.CreatureDataComp.GetPbDataId();
			int? ownerEntity = CreatureModel.Instance.GetOwnerEntity(pbDataId);
			if (ownerEntity == null)
			{
				this.RealSceneItemActorComp = component;
				return true;
			}
			EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(ownerEntity.Value);
			if (entityByPbDataId == null || !entityByPbDataId.Valid)
			{
				return false;
			}
			this.RealSceneItemActorComp = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
			return this.RealSceneItemActorComp != null && this.RealSceneItemActorComp.GetIsSceneInteractionLoadCompleted();
		}

		// Token: 0x0401FD46 RID: 130374
		private readonly int SitPointOffset = 40;

		// Token: 0x0401FD47 RID: 130375
		[Nullable(2)]
		private SceneItemActorComponent RealSceneItemActorComp;
	}
}
