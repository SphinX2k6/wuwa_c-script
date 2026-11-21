using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FF3 RID: 24563
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalDetectableAbility : LevelEntityAbilityBase
	{
		// Token: 0x0603B022 RID: 241698 RVA: 0x010AF443 File Offset: 0x010AD643
		public PlayerElementalDetectableAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603B023 RID: 241699 RVA: 0x010AF450 File Offset: 0x010AD650
		public override bool OnAddAbility(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>() != null;
		}

		// Token: 0x0603B024 RID: 241700 RVA: 0x010AF45B File Offset: 0x010AD65B
		public override bool ShouldActivate(Entity entity)
		{
			return GameModeModel.Instance.WorldDone;
		}

		// Token: 0x0603B025 RID: 241701 RVA: 0x010AF468 File Offset: 0x010AD668
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

		// Token: 0x0603B026 RID: 241702 RVA: 0x010AF4A8 File Offset: 0x010AD6A8
		public override void OnDeactivated(Entity entity)
		{
			this.LastEntityId = 0;
			ElementalCasketController.Instance.UnregisterDetectable(entity.Id);
		}

		// Token: 0x0603B027 RID: 241703 RVA: 0x010AF4C4 File Offset: 0x010AD6C4
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

		// Token: 0x17006F72 RID: 28530
		// (get) Token: 0x0603B028 RID: 241704 RVA: 0x010AF5C7 File Offset: 0x010AD7C7
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F0CD RID: 127181
		private int LastEntityId;
	}
}
