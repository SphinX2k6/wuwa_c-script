using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using Aki.Protocol.Summon;

// Token: 0x0200196E RID: 6510
public static class SummonedEntityUtil
{
	// Token: 0x06010118 RID: 65816 RVA: 0x004AECA8 File Offset: 0x004ACEA8
	[NullableContext(1)]
	[return: Nullable(2)]
	public unsafe static EntityHandle GetSummonedEntity(Entity owner, ESummonType summonType, int position = 1)
	{
		CreatureDataComponent component = owner.GetComponent<CreatureDataComponent>();
		long creatureDataId = 0L;
		switch (summonType)
		{
		case ESummonType.ConcomitantVision:
		{
			CharacterVisionComponent component2 = owner.GetComponent<CharacterVisionComponent>();
			int num = (component2 != null) ? component2.GetCurrentPosition() : 0;
			if (num < 0 || num >= component.VisionServerEntityIds.Count)
			{
				return null;
			}
			creatureDataId = component.VisionServerEntityIds[num];
			break;
		}
		case ESummonType.ConcomitantCustom:
		{
			IList<long> customServerEntityIds = component.CustomServerEntityIds;
			if (customServerEntityIds.Count == 0)
			{
				return null;
			}
			if (position < 1 || position > customServerEntityIds.Count)
			{
				CombatLog instance = CombatLog.Instance;
				CombatLog.EDebugModule flag = CombatLog.EDebugModule.Skill;
				string message = "获取伴生物实体失败，位置参数错误";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("position", position);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("serverEntityIds", customServerEntityIds);
				instance.Error(flag, owner, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
				return null;
			}
			creatureDataId = customServerEntityIds[position - 1];
			break;
		}
		case ESummonType.ConcomitantPhantomRole:
			creatureDataId = component.VisionControlCreatureDataId.GetValueOrDefault();
			break;
		case ESummonType.ConcomitantWeakVision:
			creatureDataId = component.BossRushCreatureDataId;
			break;
		case ESummonType.ConcomitantMotorcycle:
		{
			MathUtils instance2 = MathUtils.Instance;
			FollowEntityComponentPb followerInfo = component.FollowerInfo;
			creatureDataId = instance2.LongToNumber((followerInfo != null) ? followerInfo.EntityId : 0L);
			break;
		}
		}
		return CreatureModel.Instance.GetEntity(creatureDataId);
	}

	// Token: 0x06010119 RID: 65817 RVA: 0x004AEDE4 File Offset: 0x004ACFE4
	[NullableContext(2)]
	public static EntityHandle GetSummonedEntityByOwnerId(int ownerEntityId, ESummonType summonType, int position = 1)
	{
		CharacterModel instance = CharacterModel.Instance;
		EntityHandle entityHandle = (instance != null) ? instance.GetHandle(ownerEntityId) : null;
		if (entityHandle == null || !entityHandle.Valid)
		{
			return null;
		}
		EntityHandle summonedEntity = SummonedEntityUtil.GetSummonedEntity(entityHandle.Entity, summonType, position);
		if (summonedEntity == null || !summonedEntity.Valid)
		{
			return null;
		}
		return summonedEntity;
	}
}
