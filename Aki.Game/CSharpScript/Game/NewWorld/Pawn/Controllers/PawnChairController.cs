using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x02007064 RID: 28772
	[NullableContext(1)]
	[Nullable(0)]
	public class PawnChairController : SubEntityInteractLogicController
	{
		// Token: 0x0604606B RID: 286827 RVA: 0x0117493F File Offset: 0x01172B3F
		public PawnChairController(CreatureDataComponent creatureDataComp) : base(creatureDataComp)
		{
		}

		// Token: 0x0604606C RID: 286828 RVA: 0x01174950 File Offset: 0x01172B50
		public override bool Possess(Entity masterEntity, bool force = false)
		{
			this.MasterEntity = masterEntity;
			return true;
		}

		// Token: 0x0604606D RID: 286829 RVA: 0x0117495A File Offset: 0x01172B5A
		public override bool UnPossess(Entity masterEntity)
		{
			this.MasterEntity = null;
			return true;
		}

		// Token: 0x0604606E RID: 286830 RVA: 0x01174964 File Offset: 0x01172B64
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

		// Token: 0x0604606F RID: 286831 RVA: 0x01174A10 File Offset: 0x01172C10
		public Vector GetForwardDirection()
		{
			return this.Entity.GetComponent<BaseActorComponent>().ActorRightProxy;
		}

		// Token: 0x06046070 RID: 286832 RVA: 0x01174A24 File Offset: 0x01172C24
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

		// Token: 0x06046071 RID: 286833 RVA: 0x01174BAD File Offset: 0x01172DAD
		public void ResetCollision()
		{
			if (this.Entity.GetComponent<SceneItemActorComponent>() == null)
			{
				return;
			}
			this.IgnoreChairActorsCollision(false);
		}

		// Token: 0x06046072 RID: 286834 RVA: 0x01174BC4 File Offset: 0x01172DC4
		public void IgnoreCollision()
		{
			if (this.Entity.GetComponent<SceneItemActorComponent>() == null)
			{
				return;
			}
			this.IgnoreChairActorsCollision(true);
		}

		// Token: 0x06046073 RID: 286835 RVA: 0x01174BDC File Offset: 0x01172DDC
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

		// Token: 0x04024A90 RID: 150160
		private readonly int SitPointOffset = 40;

		// Token: 0x04024A91 RID: 150161
		[Nullable(2)]
		private SceneItemActorComponent RealSceneItemActorComp;
	}
}
