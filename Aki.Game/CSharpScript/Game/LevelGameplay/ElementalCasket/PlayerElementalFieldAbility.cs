using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.LevelEntityAbility;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket
{
	// Token: 0x02006E73 RID: 28275
	[NullableContext(1)]
	[Nullable(0)]
	public class PlayerElementalFieldAbility : LevelEntityAbilityBase
	{
		// Token: 0x06044E8C RID: 282252 RVA: 0x01104FAF File Offset: 0x011031AF
		public PlayerElementalFieldAbility(ELevelEntityAbilityType Type, EAbilityTickPhase TickPhase, int TickOrder, bool NeedTickActivate) : base(Type, TickPhase, TickOrder, NeedTickActivate)
		{
		}

		// Token: 0x06044E8D RID: 282253 RVA: 0x01104FBC File Offset: 0x011031BC
		public override bool OnAddAbility(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>() != null;
		}

		// Token: 0x06044E8E RID: 282254 RVA: 0x01104FC7 File Offset: 0x011031C7
		public override bool ShouldActivate(Entity entity)
		{
			return entity.GetComponent<PlayerElementalCasketComponent>().FieldOpened && GameModeModel.Instance.WorldDone;
		}

		// Token: 0x06044E8F RID: 282255 RVA: 0x01104FE2 File Offset: 0x011031E2
		public override bool ShouldDeactivate(Entity entity)
		{
			return !entity.GetComponent<PlayerElementalCasketComponent>().FieldOpened;
		}

		// Token: 0x06044E90 RID: 282256 RVA: 0x01104FF4 File Offset: 0x011031F4
		public override void OnActivated(Entity entity)
		{
			UKuroFastCollisionShapeComponent fieldShapeComp = entity.GetComponent<PlayerElementalCasketComponent>().FieldShapeComp;
			if (fieldShapeComp != null && fieldShapeComp.IsValid())
			{
				ElementalCasketController.Instance.RegisterField(entity.Id, fieldShapeComp);
			}
		}

		// Token: 0x06044E91 RID: 282257 RVA: 0x01105029 File Offset: 0x01103229
		public override void OnDeactivated(Entity entity)
		{
			this.LastEntityId = 0;
			ElementalCasketController.Instance.UnregisterField(entity.Id);
		}

		// Token: 0x06044E92 RID: 282258 RVA: 0x01105044 File Offset: 0x01103244
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

		// Token: 0x04023E16 RID: 146966
		private int LastEntityId;
	}
}
