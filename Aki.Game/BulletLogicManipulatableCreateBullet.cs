using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Common.Component;
using CSharpScript.Game.NewWorld.SceneItem;
using UnrealEngine;

// Token: 0x02002DD3 RID: 11731
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1,
	1
})]
public class BulletLogicManipulatableCreateBullet : BulletLogicController<LogicDataManipulatableCreateBullet, object>
{
	// Token: 0x06018A2A RID: 100906 RVA: 0x0064D719 File Offset: 0x0064B919
	public BulletLogicManipulatableCreateBullet(LogicDataManipulatableCreateBullet bulletLogicBase, Entity bullet) : base(bulletLogicBase, bullet)
	{
		this.Parameter = bulletLogicBase;
	}

	// Token: 0x06018A2B RID: 100907 RVA: 0x0064D72C File Offset: 0x0064B92C
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
				if (((entity2 != null) ? entity2.GetComponent<SceneItemManipulatableComponent>() : null) == null || !this.CheckCondition(entity2))
				{
					return;
				}
				BulletInfo bulletInfo = this.Bullet.GetBulletInfo();
				Entity attacker = bulletInfo.Attacker;
				BaseActorComponent component = entity2.GetComponent<BaseActorComponent>();
				FTransformDouble value = ((component != null) ? new FTransformDouble?(component.ActorTransform) : null) ?? MathUtils.Instance.DefaultTransformDouble;
				int num = this.Parameter.CreateBulletRowName.Num();
				long? contextId = bulletInfo.ContextId;
				for (int i = 0; i < num; i++)
				{
					string text = this.Parameter.CreateBulletRowName.Get(i);
					HashSet<string> parentIds = BulletUtil.CollectParentsId(bulletInfo);
					BulletController instance = BulletController.Instance;
					Entity owner = attacker;
					string bulletRowName = text;
					FTransformDouble? initialTransform = new FTransformDouble?(value);
					BulletController.BulletCreateParams bulletCreateParams = new BulletController.BulletCreateParams();
					bulletCreateParams.SkillId = bulletInfo.BulletInitParams.SkillId;
					bulletCreateParams.SkillContextId = bulletInfo.BulletInitParams.SkillContextId;
					bulletCreateParams.ParentVictimId = ((entity2 != null) ? new int?(entity2.Id) : null);
					Entity target = bulletInfo.Target;
					bulletCreateParams.ParentTargetId = ((target != null) ? new int?(target.Id) : null);
					bulletCreateParams.ParentId = this.Bullet.Id;
					bulletCreateParams.BattleContext = bulletInfo.BulletInitParams.BattleContext;
					bulletCreateParams.ParentIds = parentIds;
					instance.CreateBulletCustomTarget(owner, bulletRowName, initialTransform, bulletCreateParams, contextId, EBulletCreateSource.Others);
				}
			}
		}
	}

	// Token: 0x06018A2C RID: 100908 RVA: 0x0064D8D0 File Offset: 0x0064BAD0
	public bool CheckCondition(Entity victim)
	{
		LogicDataManipulatableCreateBullet parameter = this.Parameter;
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

	// Token: 0x0400B775 RID: 46965
	private readonly LogicDataManipulatableCreateBullet Parameter;
}
