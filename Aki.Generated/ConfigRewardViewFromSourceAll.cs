using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007EA RID: 2026
	public class ConfigRewardViewFromSourceAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F8E RID: 12174 RVA: 0x0016616C File Offset: 0x0016436C
		static ConfigRewardViewFromSourceAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRewardViewFromSourceAll.CreateStaticDefaultValue), new Action(ConfigRewardViewFromSourceAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F8F RID: 12175 RVA: 0x0016618C File Offset: 0x0016438C
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

		// Token: 0x06002F90 RID: 12176 RVA: 0x0016620B File Offset: 0x0016440B
		public static void ResetStaticDefaultValue()
		{
			ConfigRewardViewFromSourceAll.LogPair = null;
			ConfigRewardViewFromSourceAll.HandleId = 0;
		}

		// Token: 0x06002F91 RID: 12177 RVA: 0x00166219 File Offset: 0x00164419
		public static void Init()
		{
			ConfigRewardViewFromSourceAll.HandleId = ConfigCommon.InitDataStatement(ConfigRewardViewFromSourceAll.HandleId, "db_rewardui.db", "select BinData from `RewardViewFromSource`");
		}

		// Token: 0x06002F92 RID: 12178 RVA: 0x00166234 File Offset: 0x00164434
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

		// Token: 0x0400374C RID: 14156
		private const string DB = "db_rewardui.db";

		// Token: 0x0400374D RID: 14157
		private const string FILE = "j.奖励界面表现.xlsx";

		// Token: 0x0400374E RID: 14158
		private const string TABLE = "RewardViewFromSource";

		// Token: 0x0400374F RID: 14159
		private const string COMMAND = "select BinData from `RewardViewFromSource`";

		// Token: 0x04003750 RID: 14160
		private const string KEY_PREFIX = "RewardViewFromSourceAll";

		// Token: 0x04003751 RID: 14161
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003752 RID: 14162
		private static int HandleId;
	}
}
