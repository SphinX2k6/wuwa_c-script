using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;

// Token: 0x02002716 RID: 10006
public class GameplayAbilityVisionBossRush : GameplayAbilityVisionMorph
{
	// Token: 0x0601917F RID: 102783 RVA: 0x007A5540 File Offset: 0x007A3740
	[NullableContext(1)]
	public GameplayAbilityVisionBossRush(CharacterVisionComponent visionComponent) : base(visionComponent)
	{
	}

	// Token: 0x06019180 RID: 102784 RVA: 0x007A554C File Offset: 0x007A374C
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

	// Token: 0x06019181 RID: 102785 RVA: 0x007A561C File Offset: 0x007A381C
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
