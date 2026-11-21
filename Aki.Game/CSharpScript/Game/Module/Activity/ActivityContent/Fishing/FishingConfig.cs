using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x02005553 RID: 21843
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class FishingConfig : ConfigBase
	{
		// Token: 0x060362D6 RID: 221910 RVA: 0x00F1EC82 File Offset: 0x00F1CE82
		public FishingItem? GetFishingItemConfig(int itemId)
		{
			return ConfigFishingItemById.GetConfig(itemId, true);
		}

		// Token: 0x060362D7 RID: 221911 RVA: 0x00F1EC8B File Offset: 0x00F1CE8B
		public IReadOnlyList<FishingItem> GetAllFishingItemConfig()
		{
			return ConfigFishingItemAll.GetConfigList(true);
		}

		// Token: 0x060362D8 RID: 221912 RVA: 0x00F1EC93 File Offset: 0x00F1CE93
		public FishingTag? GetFishingTagConfig(int id)
		{
			return ConfigFishingTagById.GetConfig(id, true);
		}

		// Token: 0x060362D9 RID: 221913 RVA: 0x00F1EC9C File Offset: 0x00F1CE9C
		public FishingQteConfig? GetFishingQteConfig(int gameplayId)
		{
			return ConfigFishingQteConfigById.GetConfig(gameplayId, true);
		}

		// Token: 0x060362DA RID: 221914 RVA: 0x00F1ECA5 File Offset: 0x00F1CEA5
		public FishingPoint? GetFishingPointConfigById(int id)
		{
			return ConfigFishingPointById.GetConfig(id, true);
		}

		// Token: 0x060362DB RID: 221915 RVA: 0x00F1ECAE File Offset: 0x00F1CEAE
		public FishingPoint? GetFishingPointConfigByEntityId(int entityId)
		{
			return ConfigFishingPointByEntityConfigId.GetConfig(entityId, true);
		}

		// Token: 0x060362DC RID: 221916 RVA: 0x00F1ECB8 File Offset: 0x00F1CEB8
		public FishingGridItemShape GetFishingShapeConfig(int shapeId)
		{
			return ConfigFishingGridItemShapeById.GetConfig(shapeId, true).Value;
		}

		// Token: 0x060362DD RID: 221917 RVA: 0x00F1ECD4 File Offset: 0x00F1CED4
		public FishingPort GetFishingPortConfig(int portId)
		{
			return ConfigFishingPortById.GetConfig(portId, true).Value;
		}

		// Token: 0x060362DE RID: 221918 RVA: 0x00F1ECF0 File Offset: 0x00F1CEF0
		public FishingShipSkin GetFishingShipSkinConfig(int skinId)
		{
			return ConfigFishingShipSkinById.GetConfig(skinId, true).Value;
		}

		// Token: 0x060362DF RID: 221919 RVA: 0x00F1ED0C File Offset: 0x00F1CF0C
		public IReadOnlyList<FishingShipSkin> GetAllFishingSkinConfig()
		{
			return ConfigFishingShipSkinAll.GetConfigList(true);
		}

		// Token: 0x060362E0 RID: 221920 RVA: 0x00F1ED14 File Offset: 0x00F1CF14
		public int GetFishingQualityRatioByQualityId(int id)
		{
			return ConfigCommonParamById.GetIntArrayConfig("FishingPriceQualityRatioNew")[id - 1];
		}

		// Token: 0x060362E1 RID: 221921 RVA: 0x00F1ED28 File Offset: 0x00F1CF28
		public IReadOnlyList<FishingReputation> GetAllFishingReputation()
		{
			return ConfigFishingReputationAll.GetConfigList(true);
		}

		// Token: 0x060362E2 RID: 221922 RVA: 0x00F1ED30 File Offset: 0x00F1CF30
		public FishingReputation GetFishingReputationByLevel(int level)
		{
			return ConfigFishingReputationByLevel.GetConfig(level, true).Value;
		}

		// Token: 0x060362E3 RID: 221923 RVA: 0x00F1ED4C File Offset: 0x00F1CF4C
		public FishingQuality GetFishingQualityConfig(int qualityId)
		{
			return ConfigFishingQualityById.GetConfig(qualityId, true).Value;
		}

		// Token: 0x060362E4 RID: 221924 RVA: 0x00F1ED68 File Offset: 0x00F1CF68
		public FishingEntrust? GetFishingEntrust(int id)
		{
			return ConfigFishingEntrustById.GetConfig(id, true);
		}

		// Token: 0x060362E5 RID: 221925 RVA: 0x00F1ED74 File Offset: 0x00F1CF74
		public FishingPosition GetFishingPortPosition(int id)
		{
			return ConfigFishingPositionById.GetConfig(id, true).Value;
		}

		// Token: 0x060362E6 RID: 221926 RVA: 0x00F1ED90 File Offset: 0x00F1CF90
		public FishingDelivery GetFishingDelivery(int id)
		{
			return ConfigFishingDeliveryById.GetConfig(id, true).Value;
		}

		// Token: 0x060362E7 RID: 221927 RVA: 0x00F1EDAC File Offset: 0x00F1CFAC
		public FishingTech GetFishingTechById(int techId)
		{
			return ConfigFishingTechById.GetConfig(techId, true).Value;
		}

		// Token: 0x060362E8 RID: 221928 RVA: 0x00F1EDC8 File Offset: 0x00F1CFC8
		public FishingTechEffect GetFishingTechEffectById(int techEffectId)
		{
			return ConfigFishingTechEffectById.GetConfig(techEffectId, true).Value;
		}

		// Token: 0x060362E9 RID: 221929 RVA: 0x00F1EDE4 File Offset: 0x00F1CFE4
		public IReadOnlyList<FishingTechEffect> GetFishingTechEffectByType(int techEffectType)
		{
			return ConfigFishingTechEffectByType.GetConfigList(techEffectType, true);
		}

		// Token: 0x060362EA RID: 221930 RVA: 0x00F1EDED File Offset: 0x00F1CFED
		public IReadOnlyList<FishingTech> GetFishingTechList()
		{
			return ConfigFishingTechAll.GetConfigList(true);
		}

		// Token: 0x060362EB RID: 221931 RVA: 0x00F1EDF8 File Offset: 0x00F1CFF8
		public FishingNpcPerform GetFishingNpcPerform(string id)
		{
			return ConfigFishingNpcPerformById.GetConfig(id, true).Value;
		}

		// Token: 0x060362EC RID: 221932 RVA: 0x00F1EE14 File Offset: 0x00F1D014
		public FishingEntrustPool GetFishingEntrustPoolById(int poolId)
		{
			return ConfigFishingEntrustPoolById.GetConfig(poolId, true).Value;
		}

		// Token: 0x060362ED RID: 221933 RVA: 0x00F1EE30 File Offset: 0x00F1D030
		public IReadOnlyList<FishingEntrustPool> GetAllFishingEntrustPool()
		{
			return ConfigFishingEntrustPoolAll.GetConfigList(true);
		}

		// Token: 0x060362EE RID: 221934 RVA: 0x00F1EE38 File Offset: 0x00F1D038
		public FishingEntrustType GetFishingEntrustType(int type)
		{
			return ConfigFishingEntrustTypeById.GetConfig(type, true).Value;
		}

		// Token: 0x060362EF RID: 221935 RVA: 0x00F1EE54 File Offset: 0x00F1D054
		public FishingManualRefresh GetFishingManualRefreshById(int refreshId)
		{
			return ConfigFishingManualRefreshById.GetConfig(refreshId, true).Value;
		}

		// Token: 0x060362F0 RID: 221936 RVA: 0x00F1EE70 File Offset: 0x00F1D070
		public IReadOnlyList<FishingManualRefresh> GetFishingManualRefreshByEntrustPoolTypeAndStar(int poolType, int star)
		{
			return ConfigFishingManualRefreshByEntrustPoolTypeAndStar.GetConfigList(poolType, star, true);
		}

		// Token: 0x060362F1 RID: 221937 RVA: 0x00F1EE7A File Offset: 0x00F1D07A
		public IReadOnlyList<FishingPoint> GetFishingPointByShowItem(int itemId)
		{
			return ConfigFishingPointByShowItem.GetConfigList(itemId, true);
		}

		// Token: 0x060362F2 RID: 221938 RVA: 0x00F1EE83 File Offset: 0x00F1D083
		public FishingActivity? GetFishingActivityConfig(int activityId)
		{
			return ConfigFishingActivityByActivityId.GetConfig(activityId, true);
		}

		// Token: 0x060362F3 RID: 221939 RVA: 0x00F1EE8C File Offset: 0x00F1D08C
		public FishingActivityGroup? GetFishingActivityGroupConfig(int groupId)
		{
			return ConfigFishingActivityGroupById.GetConfig(groupId, true);
		}

		// Token: 0x060362F4 RID: 221940 RVA: 0x00F1EE95 File Offset: 0x00F1D095
		public IReadOnlyList<FishingActivityGroup> GetAllFishingActivityGroupConfig()
		{
			return ConfigFishingActivityGroupAll.GetConfigList(true) ?? Array.Empty<FishingActivityGroup>();
		}

		// Token: 0x060362F5 RID: 221941 RVA: 0x00F1EEA6 File Offset: 0x00F1D0A6
		public FishingActivityLimitTask? GetFishingActivityLimitTask(int taskId)
		{
			return ConfigFishingActivityLimitTaskByTaskId.GetConfig(taskId, true);
		}

		// Token: 0x060362F6 RID: 221942 RVA: 0x00F1EEAF File Offset: 0x00F1D0AF
		public FishingActivityMilestone? GetFishingActivityMilestone(int id)
		{
			return ConfigFishingActivityMilestoneById.GetConfig(id, true);
		}

		// Token: 0x060362F7 RID: 221943 RVA: 0x00F1EEB8 File Offset: 0x00F1D0B8
		public IReadOnlyList<FishingActivityMilestone> GetAllFishingActivityMilestone()
		{
			return ConfigFishingActivityMilestoneAll.GetConfigList(true) ?? Array.Empty<FishingActivityMilestone>();
		}

		// Token: 0x060362F8 RID: 221944 RVA: 0x00F1EECC File Offset: 0x00F1D0CC
		public FishingIllustratedReward GetFishingIllustratedRewardById(int id)
		{
			return ConfigFishingIllustratedRewardById.GetConfig(id, true).Value;
		}

		// Token: 0x060362F9 RID: 221945 RVA: 0x00F1EEE8 File Offset: 0x00F1D0E8
		public FishingNotice GetFishingNotice(int id)
		{
			return ConfigFishingNoticeById.GetConfig(id, true).Value;
		}

		// Token: 0x170068FA RID: 26874
		// (get) Token: 0x060362FA RID: 221946 RVA: 0x00F1EF04 File Offset: 0x00F1D104
		public static FishingConfig Instance
		{
			get
			{
				return FishingConfig._Instance;
			}
		}

		// Token: 0x060362FB RID: 221947 RVA: 0x00F1EF0B File Offset: 0x00F1D10B
		public static FishingConfig GetOrCreateInstance()
		{
			if (FishingConfig._Instance == null)
			{
				FishingConfig.CreateInstance();
			}
			return FishingConfig._Instance;
		}

		// Token: 0x060362FC RID: 221948 RVA: 0x00F1EF1F File Offset: 0x00F1D11F
		public static bool CreateInstance()
		{
			if (FishingConfig._Instance != null)
			{
				return true;
			}
			FishingConfig._Instance = new FishingConfig();
			return true;
		}

		// Token: 0x060362FD RID: 221949 RVA: 0x00F1EF35 File Offset: 0x00F1D135
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x060362FE RID: 221950 RVA: 0x00F1EF37 File Offset: 0x00F1D137
		public static void ResetStaticDefaultValue()
		{
			FishingConfig._Instance = null;
		}

		// Token: 0x060362FF RID: 221951 RVA: 0x00F1EF3F File Offset: 0x00F1D13F
		static FishingConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(FishingConfig.CreateStaticDefaultValue), new Action(FishingConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401C964 RID: 117092
		[Nullable(2)]
		private static FishingConfig _Instance;
	}
}
