using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.ItemReward
{
	// Token: 0x020057AD RID: 22445
	[NullableContext(1)]
	[Nullable(0)]
	[Config(0)]
	public class ItemRewardConfig : ConfigBase
	{
		// Token: 0x06039072 RID: 233586 RVA: 0x00D8DD8F File Offset: 0x00D8BF8F
		public RewardViewFromSource? GetRewardViewFromSourceConfig(int sourceId)
		{
			return ConfigRewardViewFromSourceBySourceId.GetConfig(sourceId, true);
		}

		// Token: 0x06039073 RID: 233587 RVA: 0x00D8DD98 File Offset: 0x00D8BF98
		public CommonRewardViewDisplay? GetCommonRewardViewDisplayConfig(int configId)
		{
			return ConfigCommonRewardViewDisplayById.GetConfig(configId, true);
		}

		// Token: 0x06039074 RID: 233588 RVA: 0x00D8DDA1 File Offset: 0x00D8BFA1
		public CompositeRewardDisplay? GetCompositeRewardViewDisplayConfig(int configId)
		{
			return ConfigCompositeRewardDisplayById.GetConfig(configId, true);
		}

		// Token: 0x06039075 RID: 233589 RVA: 0x00D8DDAA File Offset: 0x00D8BFAA
		public ExploreRewardDisplay? GetExploreRewardDisplayConfig(int configId)
		{
			return ConfigExploreRewardDisplayById.GetConfig(configId, true);
		}

		// Token: 0x06039076 RID: 233590 RVA: 0x00D8DDB3 File Offset: 0x00D8BFB3
		[NullableContext(2)]
		public IReadOnlyList<RewardViewFromSource> GetAllRewardViewFromSourceConfig()
		{
			return ConfigRewardViewFromSourceAll.GetConfigList(true);
		}

		// Token: 0x170088D8 RID: 35032
		// (get) Token: 0x06039077 RID: 233591 RVA: 0x00D8DDBB File Offset: 0x00D8BFBB
		public static ItemRewardConfig Instance
		{
			get
			{
				return ItemRewardConfig._Instance;
			}
		}

		// Token: 0x06039078 RID: 233592 RVA: 0x00D8DDC2 File Offset: 0x00D8BFC2
		public static ItemRewardConfig GetOrCreateInstance()
		{
			if (ItemRewardConfig._Instance == null)
			{
				ItemRewardConfig.CreateInstance();
			}
			return ItemRewardConfig._Instance;
		}

		// Token: 0x06039079 RID: 233593 RVA: 0x00D8DDD6 File Offset: 0x00D8BFD6
		public static bool CreateInstance()
		{
			if (ItemRewardConfig._Instance != null)
			{
				return true;
			}
			ItemRewardConfig._Instance = new ItemRewardConfig();
			return true;
		}

		// Token: 0x0603907A RID: 233594 RVA: 0x00D8DDEC File Offset: 0x00D8BFEC
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603907B RID: 233595 RVA: 0x00D8DDEE File Offset: 0x00D8BFEE
		public static void ResetStaticDefaultValue()
		{
			ItemRewardConfig._Instance = null;
		}

		// Token: 0x0603907C RID: 233596 RVA: 0x00D8DDF6 File Offset: 0x00D8BFF6
		static ItemRewardConfig()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(ItemRewardConfig.CreateStaticDefaultValue), new Action(ItemRewardConfig.ResetStaticDefaultValue));
		}

		// Token: 0x0401DDFB RID: 122363
		[Nullable(2)]
		private static ItemRewardConfig _Instance;
	}
}
