using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007E5 RID: 2021
	public class ConfigRegressBonusRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002F70 RID: 12144 RVA: 0x00168E33 File Offset: 0x00167033
		static ConfigRegressBonusRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBonusRewardAll.CreateStaticDefaultValue), new Action(ConfigRegressBonusRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x00168E54 File Offset: 0x00167054
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressBonusRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressBonusRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressBonusReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressBonusReward`")
			});
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x00168ED3 File Offset: 0x001670D3
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBonusRewardAll.LogPair = null;
			ConfigRegressBonusRewardAll.HandleId = 0;
		}

		// Token: 0x06002F73 RID: 12147 RVA: 0x00168EE1 File Offset: 0x001670E1
		public static void Init()
		{
			ConfigRegressBonusRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBonusRewardAll.HandleId, "db_regressactivity.db", "select BinData from `RegressBonusReward`");
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x00168EFC File Offset: 0x001670FC
		[NullableContext(2)]
		public static IReadOnlyList<RegressBonusReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressBonusRewardAll.HandleId, ConfigRegressBonusRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressBonusReward> readOnlyList = (IReadOnlyList<RegressBonusReward>)ConfigCommon.GetConfig("RegressBonusRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressBonusReward> list = new List<RegressBonusReward>();
			while (ConfigCommon.Step(ConfigRegressBonusRewardAll.HandleId, false, ConfigRegressBonusRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressBonusRewardAll.HandleId, 0, ConfigRegressBonusRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressBonusRewardAll.HandleId, ConfigRegressBonusRewardAll.LogPair);
					return null;
				}
				RegressBonusReward rootAsRegressBonusReward = RegressBonusReward.GetRootAsRegressBonusReward(new ByteBuffer(item2));
				list.Add(rootAsRegressBonusReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressBonusRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressBonusRewardAll.HandleId, ConfigRegressBonusRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003729 RID: 14121
		private const string DB = "db_regressactivity.db";

		// Token: 0x0400372A RID: 14122
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x0400372B RID: 14123
		private const string TABLE = "RegressBonusReward";

		// Token: 0x0400372C RID: 14124
		private const string COMMAND = "select BinData from `RegressBonusReward`";

		// Token: 0x0400372D RID: 14125
		private const string KEY_PREFIX = "RegressBonusRewardAll";

		// Token: 0x0400372E RID: 14126
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400372F RID: 14127
		private static int HandleId;
	}
}
