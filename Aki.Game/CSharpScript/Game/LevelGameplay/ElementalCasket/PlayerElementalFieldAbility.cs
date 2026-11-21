using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02005FF4 RID: 24564
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalFieldAbility : LevelEntityAbilityBase
	{
		// Token: 0x0603B029 RID: 241705 RVA: 0x010AF5CA File Offset: 0x010AD7CA
		public PlayerElementalFieldAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x0603B02A RID: 241706 RVA: 0x010AF5D7 File Offset: 0x010AD7D7
		public override bool OnAddAbility(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>() != null;
		}

		// Token: 0x0603B02B RID: 241707 RVA: 0x010AF5E2 File Offset: 0x010AD7E2
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().FieldOpened && GameModeModel.Instance.WorldDone;
		}

		// Token: 0x0603B02C RID: 241708 RVA: 0x010AF5FD File Offset: 0x010AD7FD
		public override bool ShouldDeactivate(Entity entity)
		{
			return !entity.GetComponent<PlayerElementalCasketComponent>().FieldOpened;
		}

		// Token: 0x0603B02D RID: 241709 RVA: 0x010AF610 File Offset: 0x010AD810
		public override void OnActivated(Entity entity)
		{
			UKuroFastCollisionShapeComponent fieldShapeComp = entity.GetComponent<PlayerElementalCasketComponent>().FieldShapeComp;
			if (fieldShapeComp != null && fieldShapeComp.IsValid())
			{
				ElementalCasketController.Instance.RegisterField(entity.Id, fieldShapeComp);
			}
		}

		// Token: 0x0603B02E RID: 241710 RVA: 0x010AF645 File Offset: 0x010AD845
		public override void OnDeactivated(Entity entity)
		{
			this.LastEntityId = 0;
			ElementalCasketController.Instance.UnregisterField(entity.Id);
		}

		// Token: 0x0603B02F RID: 241711 RVA: 0x010AF660 File Offset: 0x010AD860
		public override void OnTick(Entity entity, float deltaMilliseconds)
		{
			EntityHandle getCurrentEntity = SceneTeamModel.Instance.GetCurrentEntity;
			if (getCurrentEntity == null || !getCurrentEntity.IsInit || getCurrentEntity.Id == this.LastEntityId)
			{
				return;
			}
			CharacterActorComponent component = getCurrentEntity.Entity.GetComponent<CharacterActorComponent>();
			USkeletalMeshComponent uskeletalMeshComponent = (component != null) ? component.SkeletalMesh : null;
			if (uskeletalMeshComponent == null || !uskeletalMeshComponent.IsValid())
			{
				return;
			}
			PlayerElementalCasketComponent component2 = entity.GetComponent<PlayerElementalCasketComponent>();
			UKuroFastCollisionShapeComponent ukuroFastCollisionShapeComponent = component2.FieldShapeComp;
			if (ukuroFastCollisionShapeComponent == null || !ukuroFastCollisionShapeComponent.IsValid())
			{
				ukuroFastCollisionShapeComponent = component2.CreateShape();
				if (ukuroFastCollisionShapeComponent == null)
				{
					return;
				}
				ukuroFastCollisionShapeComponent.Kind = ECollisionShapeKind.Sphere;
				ukuroFastCollisionShapeComponent.Channel = ElementalCasketDefine.playerFieldChannel;
				ukuroFastCollisionShapeComponent.QueryMask = ElementalCasketDefine.PLAYER_FIELD_QUERY_MASK;
				ukuroFastCollisionShapeComponent.Radius = component2.Config.FieldRadius;
				ukuroFastCollisionShapeComponent.CenterSource = EKuroFastCollisionCenterSource.SceneComponent;
				ukuroFastCollisionShapeComponent.RotationSource = EKuroFastCollisionRotationSource.SceneComponent;
				component2.FieldShapeComp = ukuroFastCollisionShapeComponent;
				ElementalCasketController.Instance.RegisterField(entity.Id, ukuroFastCollisionShapeComponent);
			}
			ukuroFastCollisionShapeComponent.SceneComponent = new TWeakObjectPtr<USceneComponent>(uskeletalMeshComponent);
			this.LastEntityId = getCurrentEntity.Id;
		}

		// Token: 0x17006F73 RID: 28531
		// (get) Token: 0x0603B030 RID: 241712 RVA: 0x010AF75D File Offset: 0x010AD95D
		public override bool NeedTickInternal
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0401F0CE RID: 127182
		private int LastEntityId;
	}
}
