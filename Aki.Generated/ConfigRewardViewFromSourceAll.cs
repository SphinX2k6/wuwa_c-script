using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000806 RID: 2054
	public class ConfigRewardViewFromSourceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x0016D454 File Offset: 0x0016B654
		static ConfigRewardViewFromSourceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRewardViewFromSourceAll.CreateStaticDefaultValue), new Action(ConfigRewardViewFromSourceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x0016D474 File Offset: 0x0016B674
		public static void CreateStaticDefaultValue()
		{
			ConfigRewardViewFromSourceAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRewardViewFromSourceAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_rewardui.db"),
				new ValueTuple<string, object>("文件", "j.奖励界面表现.xlsx"),
				new ValueTuple<string, object>("表名", "RewardViewFromSource"),
				new ValueTuple<string, object>("语句", "select BinData from `RewardViewFromSource`")
			});
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x0016D4F3 File Offset: 0x0016B6F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRewardViewFromSourceAll.LogPair = null;
			ConfigRewardViewFromSourceAll.HandleId = 0;
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x0016D501 File Offset: 0x0016B701
		public static void Init()
		{
			ConfigRewardViewFromSourceAll.HandleId = ConfigCommon.InitDataStatement(ConfigRewardViewFromSourceAll.HandleId, "db_rewardui.db", "select BinData from `RewardViewFromSource`");
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x0016D51C File Offset: 0x0016B71C
		[NullableContext(2)]
		public static IReadOnlyList<RewardViewFromSource> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRewardViewFromSourceAll.HandleId, ConfigRewardViewFromSourceAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RewardViewFromSource> readOnlyList = (IReadOnlyList<RewardViewFromSource>)ConfigCommon.GetConfig("RewardViewFromSourceAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RewardViewFromSource> list = new List<RewardViewFromSource>();
			while (ConfigCommon.Step(ConfigRewardViewFromSourceAll.HandleId, false, ConfigRewardViewFromSourceAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRewardViewFromSourceAll.HandleId, 0, ConfigRewardViewFromSourceAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRewardViewFromSourceAll.HandleId, ConfigRewardViewFromSourceAll.LogPair);
					return null;
				}
				RewardViewFromSource rootAsRewardViewFromSource = RewardViewFromSource.GetRootAsRewardViewFromSource(new ByteBuffer(item2));
				list.Add(rootAsRewardViewFromSource);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RewardViewFromSourceAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRewardViewFromSourceAll.HandleId, ConfigRewardViewFromSourceAll.LogPair);
			return list;
		}

		// Token: 0x04003810 RID: 14352
		private const string DB = "db_rewardui.db";

		// Token: 0x04003811 RID: 14353
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x04003812 RID: 14354
		private const string TABLE = "RewardViewFromSource";

		// Token: 0x04003813 RID: 14355
		private const string COMMAND = "select BinData from `RewardViewFromSource`";

		// Token: 0x04003814 RID: 14356
		private const string KEY_PREFIX = "RewardViewFromSourceAll";

		// Token: 0x04003815 RID: 14357
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003816 RID: 14358
		private static int HandleId;
	}
}
