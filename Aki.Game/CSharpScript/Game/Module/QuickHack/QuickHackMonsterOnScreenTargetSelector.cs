using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F7D RID: 20349
	[NullableContext(1)]
	[Nullable(0)]
	public class QuickHackMonsterOnScreenTargetSelector : QuickHackBaseOnScreenTargetSelector
	{
		// Token: 0x060341D1 RID: 213457 RVA: 0x00C3B2B1 File Offset: 0x00C394B1
		protected override void OnInit()
		{
			this.EntityTypeQuery = (EEntityTypeQuery.PasserbyNPC | EEntityTypeQuery.Boss);
			this.TargetHackType = EQuickHackTargetType.EnemyMonster;
		}

		// Token: 0x060341D2 RID: 213458 RVA: 0x00C3B2C8 File Offset: 0x00C394C8
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

		// Token: 0x060341D3 RID: 213459 RVA: 0x00C3B358 File Offset: 0x00C39558
		protected override bool CheckEntityRendered(EntityHandle entityHandle)
		{
			AActor owner = entityHandle.Entity.GetComponent<BaseActorComponent>().Owner;
			return owner != null && owner.WasRecentlyRenderedOnScreen(0.2f);
		}

		// Token: 0x060341D4 RID: 213460 RVA: 0x00C3B37A File Offset: 0x00C3957A
		protected override FVectorDouble GetEntityLocation(EntityHandle entityHandle)
		{
			return entityHandle.Entity.GetComponent<BaseActorComponent>().ActorLocation;
		}
	}
}
