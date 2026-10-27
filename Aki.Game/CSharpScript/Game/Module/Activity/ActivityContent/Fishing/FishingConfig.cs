using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x020065D5 RID: 26069
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class FishingConfig : ConfigBase
	{
		// Token: 0x06041611 RID: 267793 RVA: 0x00FD7C42 File Offset: 0x00FD5E42
		public FishingItem? GetFishingItemConfig(int itemId)
		{
			return ConfigFishingItemById.GetConfig(itemId, true);
		}

		// Token: 0x06041612 RID: 267794 RVA: 0x00FD7C4B File Offset: 0x00FD5E4B
		public IReadOnlyList<FishingItem> GetAllFishingItemConfig()
		{
			return ConfigFishingItemAll.GetConfigList(true);
		}

		// Token: 0x06041613 RID: 267795 RVA: 0x00FD7C53 File Offset: 0x00FD5E53
		public FishingTag? GetFishingTagConfig(int id)
		{
			return ConfigFishingTagById.GetConfig(id, true);
		}

		// Token: 0x06041614 RID: 267796 RVA: 0x00FD7C5C File Offset: 0x00FD5E5C
		public FishingQteConfig? GetFishingQteConfig(int gameplayId)
		{
			return ConfigFishingQteConfigById.GetConfig(gameplayId, true);
		}

		// Token: 0x06041615 RID: 267797 RVA: 0x00FD7C65 File Offset: 0x00FD5E65
		public FishingPoint? GetFishingPointConfigById(int id)
		{
			return ConfigFishingPointById.GetConfig(id, true);
		}

		// Token: 0x06041616 RID: 267798 RVA: 0x00FD7C6E File Offset: 0x00FD5E6E
		public FishingPoint? GetFishingPointConfigByEntityId(int entityId)
		{
			return ConfigFishingPointByEntityConfigId.GetConfig(entityId, true);
		}

		// Token: 0x06041617 RID: 267799 RVA: 0x00FD7C78 File Offset: 0x00FD5E78
		public FishingGridItemShape GetFishingShapeConfig(int shapeId)
		{
			return ConfigFishingGridItemShapeById.GetConfig(shapeId, true).Value;
		}

		// Token: 0x06041618 RID: 267800 RVA: 0x00FD7C94 File Offset: 0x00FD5E94
		public FishingPort GetFishingPortConfig(int portId)
		{
			return ConfigFishingPortById.GetConfig(portId, true).Value;
		}

		// Token: 0x06041619 RID: 267801 RVA: 0x00FD7CB0 File Offset: 0x00FD5EB0
		public FishingShipSkin GetFishingShipSkinConfig(int skinId)
		{
			return ConfigFishingShipSkinById.GetConfig(skinId, true).Value;
		}

		// Token: 0x0604161A RID: 267802 RVA: 0x00FD7CCC File Offset: 0x00FD5ECC
		public IReadOnlyList<FishingShipSkin> GetAllFishingSkinConfig()
		{
			return ConfigFishingShipSkinAll.GetConfigList(true);
		}

		// Token: 0x0604161B RID: 267803 RVA: 0x00FD7CD4 File Offset: 0x00FD5ED4
		public int GetFishingQualityRatioByQualityId(int id)
		{
			return ConfigCommonParamById.GetIntArrayConfig("FishingPriceQualityRatioNew")[id - 1];
		}

		// Token: 0x0604161C RID: 267804 RVA: 0x00FD7CE8 File Offset: 0x00FD5EE8
		public IReadOnlyList<FishingReputation> GetAllFishingReputation()
		{
			return ConfigFishingReputationAll.GetConfigList(true);
		}

		// Token: 0x0604161D RID: 267805 RVA: 0x00FD7CF0 File Offset: 0x00FD5EF0
		public FishingReputation GetFishingReputationByLevel(int level)
		{
			return ConfigFishingReputationByLevel.GetConfig(level, true).Value;
		}

		// Token: 0x0604161E RID: 267806 RVA: 0x00FD7D0C File Offset: 0x00FD5F0C
		public FishingQuality GetFishingQualityConfig(int qualityId)
		{
			return ConfigFishingQualityById.GetConfig(qualityId, true).Value;
		}

		// Token: 0x0604161F RID: 267807 RVA: 0x00FD7D28 File Offset: 0x00FD5F28
		public FishingEntrust? GetFishingEntrust(int id)
		{
			return ConfigFishingEntrustById.GetConfig(id, true);
		}

		// Token: 0x06041620 RID: 267808 RVA: 0x00FD7D34 File Offset: 0x00FD5F34
		public FishingPosition GetFishingPortPosition(int id)
		{
			return ConfigFishingPositionById.GetConfig(id, true).Value;
		}

		// Token: 0x06041621 RID: 267809 RVA: 0x00FD7D50 File Offset: 0x00FD5F50
		public FishingDelivery GetFishingDelivery(int id)
		{
			return ConfigFishingDeliveryById.GetConfig(id, true).Value;
		}

		// Token: 0x06041622 RID: 267810 RVA: 0x00FD7D6C File Offset: 0x00FD5F6C
		public FishingTech GetFishingTechById(int techId)
		{
			return ConfigFishingTechById.GetConfig(techId, true).Value;
		}

		// Token: 0x06041623 RID: 267811 RVA: 0x00FD7D88 File Offset: 0x00FD5F88
		public FishingTechEffect GetFishingTechEffectById(int techEffectId)
		{
			return ConfigFishingTechEffectById.GetConfig(techEffectId, true).Value;
		}

		// Token: 0x06041624 RID: 267812 RVA: 0x00FD7DA4 File Offset: 0x00FD5FA4
		public IReadOnlyList<FishingTechEffect> GetFishingTechEffectByType(int techEffectType)
		{
			return ConfigFishingTechEffectByType.GetConfigList(techEffectType, true);
		}

		// Token: 0x06041625 RID: 267813 RVA: 0x00FD7DAD File Offset: 0x00FD5FAD
		public IReadOnlyList<FishingTech> GetFishingTechList()
		{
			return ConfigFishingTechAll.GetConfigList(true);
		}

		// Token: 0x06041626 RID: 267814 RVA: 0x00FD7DB8 File Offset: 0x00FD5FB8
		public FishingNpcPerform GetFishingNpcPerform(string id)
		{
			return ConfigFishingNpcPerformById.GetConfig(id, true).Value;
		}

		// Token: 0x06041627 RID: 267815 RVA: 0x00FD7DD4 File Offset: 0x00FD5FD4
		public FishingEntrustPool GetFishingEntrustPoolById(int poolId)
		{
			return ConfigFishingEntrustPoolById.GetConfig(poolId, true).Value;
		}

		// Token: 0x06041628 RID: 267816 RVA: 0x00FD7DF0 File Offset: 0x00FD5FF0
		public IReadOnlyList<FishingEntrustPool> GetAllFishingEntrustPool()
		{
			return ConfigFishingEntrustPoolAll.GetConfigList(true);
		}

		// Token: 0x06041629 RID: 267817 RVA: 0x00FD7DF8 File Offset: 0x00FD5FF8
		public FishingEntrustType GetFishingEntrustType(int type)
		{
			return ConfigFishingEntrustTypeById.GetConfig(type, true).Value;
		}

		// Token: 0x0604162A RID: 267818 RVA: 0x00FD7E14 File Offset: 0x00FD6014
		public FishingManualRefresh GetFishingManualRefreshById(int refreshId)
		{
			return ConfigFishingManualRefreshById.GetConfig(refreshId, true).Value;
		}

		// Token: 0x0604162B RID: 267819 RVA: 0x00FD7E30 File Offset: 0x00FD6030
		public IReadOnlyList<FishingManualRefresh> GetFishingManualRefreshByEntrustPoolTypeAndStar(int poolType, int star)
		{
			return ConfigFishingManualRefreshByEntrustPoolTypeAndStar.GetConfigList(poolType, star, true);
		}

		// Token: 0x0604162C RID: 267820 RVA: 0x00FD7E3A File Offset: 0x00FD603A
		public IReadOnlyList<FishingPoint> GetFishingPointByShowItem(int itemId)
		{
			return ConfigFishingPointByShowItem.GetConfigList(itemId, true);
		}

		// Token: 0x0604162D RID: 267821 RVA: 0x00FD7E43 File Offset: 0x00FD6043
		public FishingActivity? GetFishingActivityConfig(int activityId)
		{
			return ConfigFishingActivityByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x0604162E RID: 267822 RVA: 0x00FD7E4C File Offset: 0x00FD604C
		public FishingActivityGroup? GetFishingActivityGroupConfig(int groupId)
		{
			return ConfigFishingActivityGroupById.GetConfig(groupId, true);
		}

		// Token: 0x0604162F RID: 267823 RVA: 0x00FD7E55 File Offset: 0x00FD6055
		public IReadOnlyList<FishingActivityGroup> GetAllFishingActivityGroupConfig()
		{
			return ConfigFishingActivityGroupAll.GetConfigList(true) ?? Array.Empty<FishingActivityGroup>();
		}

		// Token: 0x06041630 RID: 267824 RVA: 0x00FD7E66 File Offset: 0x00FD6066
		public FishingActivityLimitTask? GetFishingActivityLimitTask(int taskId)
		{
			return ConfigFishingActivityLimitTaskByTaskId.GetConfig(taskId, true);
		}

		// Token: 0x06041631 RID: 267825 RVA: 0x00FD7E6F File Offset: 0x00FD606F
		public FishingActivityMilestone? GetFishingActivityMilestone(int id)
		{
			return ConfigFishingActivityMilestoneById.GetConfig(id, true);
		}

		// Token: 0x06041632 RID: 267826 RVA: 0x00FD7E78 File Offset: 0x00FD6078
		public IReadOnlyList<FishingActivityMilestone> GetAllFishingActivityMilestone()
		{
			return ConfigFishingActivityMilestoneAll.GetConfigList(true) ?? Array.Empty<FishingActivityMilestone>();
		}

		// Token: 0x06041633 RID: 267827 RVA: 0x00FD7E8C File Offset: 0x00FD608C
		public FishingIllustratedReward GetFishingIllustratedRewardById(int id)
		{
			return ConfigFishingIllustratedRewardById.GetConfig(id, true).Value;
		}

		// Token: 0x06041634 RID: 267828 RVA: 0x00FD7EA8 File Offset: 0x00FD60A8
		public FishingNotice GetFishingNotice(int id)
		{
			return ConfigFishingNoticeById.GetConfig(id, true).Value;
		}

		// Token: 0x17009598 RID: 38296
		// (get) Token: 0x06041635 RID: 267829 RVA: 0x00FD7EC4 File Offset: 0x00FD60C4
		public static FishingConfig Instance
		{
			get
			{
				return FishingConfig._Instance;
			}
		}

		// Token: 0x06041636 RID: 267830 RVA: 0x00FD7ECB File Offset: 0x00FD60CB
		public static FishingConfig GetOrCreateInstance()
		{
			if (FishingConfig._Instance == null)
			{
				FishingConfig.CreateInstance();
			}
			return FishingConfig._Instance;
		}

		// Token: 0x06041637 RID: 267831 RVA: 0x00FD7EDF File Offset: 0x00FD60DF
		public static bool CreateInstance()
		{
			if (FishingConfig._Instance != null)
			{
				return true;
			}
			FishingConfig._Instance = new FishingConfig();
			return true;
		}

		// Token: 0x06041638 RID: 267832 RVA: 0x00FD7EF5 File Offset: 0x00FD60F5
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x06041639 RID: 267833 RVA: 0x00FD7EF7 File Offset: 0x00FD60F7
		public static void ResetStaticDefaultValue()
		{
			FishingConfig._Instance = null;
		}

		// Token: 0x0604163A RID: 267834 RVA: 0x00FD7EFF File Offset: 0x00FD60FF
		static FishingConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingConfig.CreateStaticDefaultValue), new Action(FishingConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04022033 RID: 139315
		[Nullable(2)]
		private static FishingConfig _Instance;
	}
}
