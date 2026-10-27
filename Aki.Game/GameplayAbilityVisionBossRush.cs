using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;

// Token: 0x020031A7 RID: 12711
public class GameplayAbilityVisionBossRush : GameplayAbilityVisionMorph
{
	// Token: 0x0601B651 RID: 112209 RVA: 0x0077D262 File Offset: 0x0077B462
	[NullableContext(1)]
	public GameplayAbilityVisionBossRush(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x0601B652 RID: 112210 RVA: 0x0077D26C File Offset: 0x0077B46C
	protected override void PreInit()
	{
		int playerId = base.CreatureDataComponent.GetPlayerId();
		WorldEntity playerEntity = FormationDataController.Instance.GetPlayerEntity(playerId);
		this.VisionEntity = ((playerEntity != null) ? PhantomUtil.GetSummonedEntity(playerEntity, ESummonType.ConcomitantWeakVision, 1) : null);
		EntityHandle visionEntity = this.VisionEntity;
		object obj;
		if (visionEntity == null)
		{
			obj = null;
		}
		else
		{
			WorldEntity entity = visionEntity.Entity;
			obj = ((entity != null) ? entity.GetComponent<CreatureDataComponent>() : null);
		}
		object obj2 = obj;
		if (obj2 != null)
		{
			obj2.SetSummonerId(base.CreatureDataComponent.GetCreatureDataId());
		}
		EntityComponentPb entityComponentPb = (obj2 != null) ? obj2.ComponentDataMap.GetValueOrDefault("SummonerComponent") : null;
		int? num;
		if (entityComponentPb == null)
		{
			num = null;
		}
		else
		{
			SummonerComponentPb summonerComponent = entityComponentPb.SummonerComponent;
			num = ((summonerComponent != null) ? new int?(summonerComponent.SummonSkillId) : null);
		}
		int? num2 = num;
		if (num2 != null)
		{
			this.VisionData = PhantomUtil.GetVisionData(num2.Value);
		}
	}

	// Token: 0x0601B653 RID: 112211 RVA: 0x0077D33C File Offset: 0x0077B53C
	[NullableContext(2)]
	protected override void SetVisionEnable(bool enable, EntityHandle visionEntity = null)
	{
		if (visionEntity == null)
		{
			visionEntity = this.VisionEntity;
		}
		CreatureController.Instance.SetEntityEnable(visionEntity.Entity, enable, "GameplayAbilityVisionBossRush.SetVisionEnable", true);
		EntityHandle visionEntity2 = this.VisionEntity;
		CharacterFollowComponent characterFollowComponent;
		if (visionEntity2 == null)
		{
			characterFollowComponent = null;
		}
		else
		{
			WorldEntity entity = visionEntity2.Entity;
			characterFollowComponent = ((entity != null) ? entity.GetComponent<CharacterFollowComponent>() : null);
		}
		CharacterFollowComponent characterFollowComponent2 = characterFollowComponent;
		if (enable)
		{
			if (characterFollowComponent2 != null)
			{
				characterFollowComponent2.SetRelationship(base.EntityHandle);
				return;
			}
		}
		else if (characterFollowComponent2 != null)
		{
			characterFollowComponent2.RemoveFromAttributeHolder();
		}
	}
}
