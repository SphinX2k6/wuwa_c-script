using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F46 RID: 16198
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMonsterOnScreenTargetSelector : QuickHackBaseOnScreenTargetSelector
	{
		// Token: 0x0602903F RID: 167999 RVA: 0x00B84A5D File Offset: 0x00B82C5D
		protected override void OnInit()
		{
			this.EntityTypeQuery = (EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss);
			this.TargetHackType = EQuickHackTargetType.EnemyMonster;
		}

		// Token: 0x06029040 RID: 168000 RVA: 0x00B84A74 File Offset: 0x00B82C74
		protected override bool CheckEntityValid(EntityHandle entityHandle)
		{
			if (!entityHandle.IsInit)
			{
				return false;
			}
			WorldEntity entity = entityHandle.Entity;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component.GetRemoveState())
			{
				return false;
			}
			if (!entity.Active)
			{
				return false;
			}
			BaseTagComponent component2 = entity.GetComponent<BaseTagComponent>();
			if (component2 != null && component2.HasTag(GameplayTagDefine.EGameplayTagId["行为状态.逻辑状态.隐身"]))
			{
				return false;
			}
			if (CampUtils.GetCampRelationship(component.GetEntityCamp(), ECamp.Player) != ERelation.Enemy)
			{
				return false;
			}
			BaseDeathComponent component3 = entity.GetComponent<BaseDeathComponent>();
			return (component3 == null || !component3.IsDead()) && entity.GetComponent<BaseActorComponent>() != null;
		}

		// Token: 0x06029041 RID: 168001 RVA: 0x00B84B04 File Offset: 0x00B82D04
		protected override bool CheckEntityRendered(EntityHandle entityHandle)
		{
			AActor owner = entityHandle.Entity.GetComponent<BaseActorComponent>().Owner;
			return owner != null && owner.WasRecentlyRenderedOnScreen(0.2f);
		}

		// Token: 0x06029042 RID: 168002 RVA: 0x00B84B26 File Offset: 0x00B82D26
		protected override FVectorDouble GetEntityLocation(EntityHandle entityHandle)
		{
			return entityHandle.Entity.GetComponent<BaseActorComponent>().ActorLocation;
		}
	}
}
