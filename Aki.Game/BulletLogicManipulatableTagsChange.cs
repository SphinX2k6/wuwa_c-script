using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x02002DD4 RID: 11732
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicManipulatableTagsChange : BulletLogicController<LogicDataManipulatableTagsChange, object>
{
	// Token: 0x06018A2D RID: 100909 RVA: 0x0064D978 File Offset: 0x0064BB78
	public BulletLogicManipulatableTagsChange(LogicDataManipulatableTagsChange bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x06018A2E RID: 100910 RVA: 0x0064D98C File Offset: 0x0064BB8C
	[NullableContext(2)]
	public override void BulletLogicActionOnHitObstacles(object param = null)
	{
		BulletHitActorData bulletHitActorData = param as BulletHitActorData;
		if (bulletHitActorData != null)
		{
			Entity entity = bulletHitActorData.Entity;
			if (entity != null && entity.GetComponent<CreatureDataComponent>().IsSceneItem())
			{
				Entity entity2 = bulletHitActorData.Entity;
				bool flag = ((entity2 != null) ? entity2.GetComponent<SceneItemManipulatableComponent>() : null) != null;
				LogicDataManipulatableTagsChange parameter = this.Parameter;
				LevelTagComponent levelTagComponent = (entity2 != null) ? entity2.GetComponent<LevelTagComponent>() : null;
				if (!flag || !this.CheckCondition(entity2) || levelTagComponent == null)
				{
					return;
				}
				TArray<FGameplayTag> gameplayTags = parameter.AddTags.GameplayTags;
				int num = gameplayTags.Num();
				for (int i = 0; i < num; i++)
				{
					int tagId = gameplayTags.Get(i).TagId();
					levelTagComponent.AddServerTagByIdLocal(tagId, "特定子弹命中可控物添加标签");
				}
				TArray<FGameplayTag> gameplayTags2 = parameter.RemoveTags.GameplayTags;
				int num2 = gameplayTags2.Num();
				for (int j = 0; j < num2; j++)
				{
					int tagId2 = gameplayTags2.Get(j).TagId();
					levelTagComponent.RemoveServerTagByIdLocal(tagId2, "特定子弹命中可控物移除标签");
				}
			}
		}
	}

	// Token: 0x06018A2F RID: 100911 RVA: 0x0064DA80 File Offset: 0x0064BC80
	public bool CheckCondition(Entity victim)
	{
		LogicDataManipulatableTagsChange parameter = this.Parameter;
		LevelTagComponent levelTagComponent = (victim != null) ? victim.GetComponent<LevelTagComponent>() : null;
		if (levelTagComponent == null)
		{
			return false;
		}
		TArray<FGameplayTag> gameplayTags = parameter.ExistTagsCondition.GameplayTags;
		int num = gameplayTags.Num();
		for (int i = 0; i < num; i++)
		{
			int tagId = gameplayTags.Get(i).TagId();
			if (!levelTagComponent.HasTag(tagId))
			{
				return false;
			}
		}
		TArray<FGameplayTag> gameplayTags2 = parameter.UnExistTagsCondition.GameplayTags;
		int num2 = gameplayTags2.Num();
		for (int j = 0; j < num2; j++)
		{
			int tagId2 = gameplayTags2.Get(j).TagId();
			if (levelTagComponent.HasTag(tagId2))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x0400B776 RID: 46966
	public readonly LogicDataManipulatableTagsChange Parameter;
}
