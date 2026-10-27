using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E72 RID: 28274
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalDetectableAbility : LevelEntityAbilityBase
	{
		// Token: 0x06044E86 RID: 282246 RVA: 0x01104E2B File Offset: 0x0110302B
		public PlayerElementalDetectableAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E87 RID: 282247 RVA: 0x01104E38 File Offset: 0x01103038
		public override bool OnAddAbility(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>() != null;
		}

		// Token: 0x06044E88 RID: 282248 RVA: 0x01104E43 File Offset: 0x01103043
		public override bool ShouldActivate(Entity entity)
		{
			return GameModeModel.Instance.WorldDone;
		}

		// Token: 0x06044E89 RID: 282249 RVA: 0x01104E50 File Offset: 0x01103050
		public override void OnActivated(Entity entity)
		{
			UKuroFastCollisionShapeComponent detectableShapeComp = entity.GetComponent<PlayerElementalCasketComponent>().DetectableShapeComp;
			if (detectableShapeComp != null && detectableShapeComp.IsValid())
			{
				ElementalCasketController.Instance.RegisterDetectable(entity.Id, new List<UObject>
				{
					detectableShapeComp
				});
			}
		}

		// Token: 0x06044E8A RID: 282250 RVA: 0x01104E90 File Offset: 0x01103090
		public override void OnDeactivated(Entity entity)
		{
			this.LastEntityId = 0;
			ElementalCasketController.Instance.UnregisterDetectable(entity.Id);
		}

		// Token: 0x06044E8B RID: 282251 RVA: 0x01104EAC File Offset: 0x011030AC
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.IsInit || getCurrentEntity.Id == this.LastEntityId)
			{
				return;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			UCapsuleComponent ucapsuleComponent;
			if (component == null)
			{
				ucapsuleComponent = null;
			}
			else
			{
				TsBaseCharacter actor = component.Actor;
				ucapsuleComponent = ((actor != null) ? actor.CapsuleComponent : null);
			}
			UCapsuleComponent ucapsuleComponent2 = ucapsuleComponent;
			if (ucapsuleComponent2 == null || !ucapsuleComponent2.IsValid())
			{
				return;
			}
			PlayerElementalCasketComponent component2 = entity.GetComponent<PlayerElementalCasketComponent>();
			UKuroFastCollisionShapeComponent ukuroFastCollisionShapeComponent = component2.DetectableShapeComp;
			if (ukuroFastCollisionShapeComponent == null || !ukuroFastCollisionShapeComponent.IsValid())
			{
				ukuroFastCollisionShapeComponent = component2.CreateShape();
				if (ukuroFastCollisionShapeComponent == null)
				{
					return;
				}
				ukuroFastCollisionShapeComponent.Kind = ECollisionShapeKind.Capsule;
				ukuroFastCollisionShapeComponent.Channel = ElementalCasketDefine.playerDetectableChannel;
				ukuroFastCollisionShapeComponent.QueryMask = ElementalCasketDefine.PLAYER_DETECTABLE_QUERY_MASK;
				ukuroFastCollisionShapeComponent.CenterSource = EKuroFastCollisionCenterSource.SceneComponent;
				ukuroFastCollisionShapeComponent.RotationSource = EKuroFastCollisionRotationSource.SceneComponent;
				component2.DetectableShapeComp = ukuroFastCollisionShapeComponent;
				ElementalCasketController.Instance.RegisterDetectable(entity.Id, new List<UObject>
				{
					ukuroFastCollisionShapeComponent
				});
			}
			ukuroFastCollisionShapeComponent.SceneComponent = new TWeakObjectPtr<USceneComponent>(ucapsuleComponent2);
			this.LastEntityId = getCurrentEntity.Id;
		}

		// Token: 0x04023E15 RID: 146965
		private int LastEntityId;
	}
}
