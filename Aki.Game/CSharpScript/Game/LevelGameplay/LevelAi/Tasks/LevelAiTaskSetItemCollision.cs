using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.LevelAi.Tasks
{
	// Token: 0x02006DC2 RID: 28098
	public class LevelAiTaskSetItemCollision : LevelAiTask
	{
		// Token: 0x060448C9 RID: 280777 RVA: 0x010E7BDA File Offset: 0x010E5DDA
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

		// Token: 0x060448CA RID: 280778 RVA: 0x010E7BF4 File Offset: 0x010E5DF4
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

		// Token: 0x060448CB RID: 280779 RVA: 0x010E7CE8 File Offset: 0x010E5EE8
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

		// Token: 0x060448CC RID: 280780 RVA: 0x010E7D34 File Offset: 0x010E5F34
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

		// Token: 0x04023A5E RID: 146014
		[Nullable(2)]
		public EntityHandle ItemEntity;

		// Token: 0x04023A5F RID: 146015
		public bool IsIgnore;
	}
}
