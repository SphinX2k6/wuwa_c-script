using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02005F41 RID: 24385
	public class LevelAiTaskSetItemCollision : LevelAiTask
	{
		// Token: 0x0603AA2D RID: 240173 RVA: 0x01091E1A File Offset: 0x0109001A
		protected override ELevelAiNodeResult ExecuteTask()
		{
			if (this.IsIgnore)
			{
				this.IgnoreCollision();
			}
			else
			{
				this.ResetCollision();
			}
			return ELevelAiNodeResult.Succeeded;
		}

		// Token: 0x0603AA2E RID: 240174 RVA: 0x01091E34 File Offset: 0x01090034
		[NullableContext(1)]
		private void IgnoreActorsCollision(SceneItemActorComponent actorComp, bool bCollision)
		{
			CreatureDataComponent component = actorComp.Entity.GetComponent<CreatureDataComponent>();
			BaseCharacterComponent component2 = base.CreatureDataComponent.Entity.GetComponent<BaseCharacterComponent>();
			int pbDataId = component.GetPbDataId();
			int? ownerEntity = CreatureModel.Instance.GetOwnerEntity(pbDataId);
			SceneItemActorComponent sceneItemActorComponent;
			if (ownerEntity != null)
			{
				EntityHandle entityByPbDataId = CreatureModel.Instance.GetEntityByPbDataId(ownerEntity.Value);
				if (entityByPbDataId != null)
				{
					sceneItemActorComponent = entityByPbDataId.Entity.GetComponent<SceneItemActorComponent>();
				}
				else
				{
					sceneItemActorComponent = actorComp;
				}
			}
			else
			{
				sceneItemActorComponent = actorComp;
			}
			if (sceneItemActorComponent == null)
			{
				return;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			sceneItemActorComponent.Owner.GetAttachedActors(ref tarray, true);
			int num = tarray.Num();
			for (int i = 0; i < num; i++)
			{
				AActor aactor = tarray.Get(i);
				TArray<AActor> tarray2 = new TArray<AActor>();
				aactor.GetAttachedActors(ref tarray2, true);
				int num2 = tarray2.Num();
				for (int j = 0; j < num2; j++)
				{
					component2.Actor.CapsuleComponent.IgnoreActorWhenMoving(tarray2.Get(j), bCollision);
				}
			}
		}

		// Token: 0x0603AA2F RID: 240175 RVA: 0x01091F28 File Offset: 0x01090128
		private void ResetCollision()
		{
			SceneItemActorComponent component = this.ItemEntity.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null)
			{
				return;
			}
			BaseCharacterComponent component2 = base.CreatureDataComponent.Entity.GetComponent<BaseCharacterComponent>();
			this.IgnoreActorsCollision(component, false);
			component2.Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Block);
		}

		// Token: 0x0603AA30 RID: 240176 RVA: 0x01091F74 File Offset: 0x01090174
		private void IgnoreCollision()
		{
			SceneItemActorComponent component = this.ItemEntity.Entity.GetComponent<SceneItemActorComponent>();
			if (component == null)
			{
				return;
			}
			this.IgnoreActorsCollision(component, true);
			base.CreatureDataComponent.Entity.GetComponent<BaseCharacterComponent>().Actor.CapsuleComponent.SetCollisionResponseToChannel(ECollisionChannel.ECC_Pawn, ECollisionResponse.ECR_Ignore);
		}

		// Token: 0x0401ED00 RID: 126208
		[Nullable(2)]
		public EntityHandle ItemEntity;

		// Token: 0x0401ED01 RID: 126209
		public bool IsIgnore;
	}
}
