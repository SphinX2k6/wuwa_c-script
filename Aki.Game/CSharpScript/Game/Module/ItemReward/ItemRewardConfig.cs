using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x02004784 RID: 18308
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ItemRewardConfig : ConfigBase
	{
		// Token: 0x0602DF82 RID: 188290 RVA: 0x00CDCB4B File Offset: 0x00CDAD4B
		public RewardViewFromSource? GetRewardViewFromSourceConfig(int sourceId)
		{
			return ConfigRewardViewFromSourceBySourceId.GetConfig(sourceId, true);
		}

		// Token: 0x0602DF83 RID: 188291 RVA: 0x00CDCB54 File Offset: 0x00CDAD54
		public CommonRewardViewDisplay? GetCommonRewardViewDisplayConfig(int configId)
		{
			return ConfigCommonRewardViewDisplayById.GetConfig(configId, true);
		}

		// Token: 0x0602DF84 RID: 188292 RVA: 0x00CDCB5D File Offset: 0x00CDAD5D
		public CompositeRewardDisplay? GetCompositeRewardViewDisplayConfig(int configId)
		{
			return ConfigCompositeRewardDisplayById.GetConfig(configId, true);
		}

		// Token: 0x0602DF85 RID: 188293 RVA: 0x00CDCB66 File Offset: 0x00CDAD66
		public ExploreRewardDisplay? GetExploreRewardDisplayConfig(int configId)
		{
			return ConfigExploreRewardDisplayById.GetConfig(configId, true);
		}

		// Token: 0x0602DF86 RID: 188294 RVA: 0x00CDCB6F File Offset: 0x00CDAD6F
		[NullableContext(2)]
		public IReadOnlyList<RewardViewFromSource> GetAllRewardViewFromSourceConfig()
		{
			return ConfigRewardViewFromSourceAll.GetConfigList(true);
		}

		// Token: 0x17005CA0 RID: 23712
		// (get) Token: 0x0602DF87 RID: 188295 RVA: 0x00CDCB77 File Offset: 0x00CDAD77
		public static ItemRewardConfig Instance
		{
			get
			{
				return ItemRewardConfig._Instance;
			}
		}

		// Token: 0x0602DF88 RID: 188296 RVA: 0x00CDCB7E File Offset: 0x00CDAD7E
		public static ItemRewardConfig GetOrCreateInstance()
		{
			if (ItemRewardConfig._Instance == null)
			{
				ItemRewardConfig.CreateInstance();
			}
			return ItemRewardConfig._Instance;
		}

		// Token: 0x0602DF89 RID: 188297 RVA: 0x00CDCB92 File Offset: 0x00CDAD92
		public static bool CreateInstance()
		{
			if (ItemRewardConfig._Instance != null)
			{
				return true;
			}
			ItemRewardConfig._Instance = new ItemRewardConfig();
			return true;
		}

		// Token: 0x0602DF8A RID: 188298 RVA: 0x00CDCBA8 File Offset: 0x00CDADA8
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602DF8B RID: 188299 RVA: 0x00CDCBAA File Offset: 0x00CDADAA
		public static void ResetStaticDefaultValue()
		{
			ItemRewardConfig._Instance = null;
		}

		// Token: 0x0602DF8C RID: 188300 RVA: 0x00CDCBB2 File Offset: 0x00CDADB2
		static ItemRewardConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardConfig.CreateStaticDefaultValue), new Action(ItemRewardConfig.ResetStaticDefaultValue));
		}

		// Token: 0x04018891 RID: 100497
		[Nullable(2)]
		private static ItemRewardConfig _Instance;
	}
}
