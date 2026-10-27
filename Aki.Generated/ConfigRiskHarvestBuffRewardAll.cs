using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000806 RID: 2054
	public class ConfigRiskHarvestBuffRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003036 RID: 12342 RVA: 0x00169CB0 File Offset: 0x00167EB0
		static ConfigRiskHarvestBuffRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffRewardAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003037 RID: 12343 RVA: 0x00169CD0 File Offset: 0x00167ED0
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestBuffRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestBuffRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestBuffReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestBuffReward`")
			});
		}

		// Token: 0x06003038 RID: 12344 RVA: 0x00169D4F File Offset: 0x00167F4F
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffRewardAll.LogPair = null;
			ConfigRiskHarvestBuffRewardAll.HandleId = 0;
		}

		// Token: 0x06003039 RID: 12345 RVA: 0x00169D5D File Offset: 0x00167F5D
		public static void Init()
		{
			ConfigRiskHarvestBuffRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffRewardAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffReward`");
		}

		// Token: 0x0600303A RID: 12346 RVA: 0x00169D78 File Offset: 0x00167F78
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestBuffReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestBuffRewardAll.HandleId, ConfigRiskHarvestBuffRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RiskHarvestBuffReward> readOnlyList = (IReadOnlyList<RiskHarvestBuffReward>)ConfigCommon.GetConfig("RiskHarvestBuffRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RiskHarvestBuffReward> list = new List<RiskHarvestBuffReward>();
			while (ConfigCommon.Step(ConfigRiskHarvestBuffRewardAll.HandleId, false, ConfigRiskHarvestBuffRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestBuffRewardAll.HandleId, 0, ConfigRiskHarvestBuffRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestBuffRewardAll.HandleId, ConfigRiskHarvestBuffRewardAll.LogPair);
					return null;
				}
				RiskHarvestBuffReward rootAsRiskHarvestBuffReward = RiskHarvestBuffReward.GetRootAsRiskHarvestBuffReward(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestBuffReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RiskHarvestBuffRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestBuffRewardAll.HandleId, ConfigRiskHarvestBuffRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003810 RID: 14352
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003811 RID: 14353
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003812 RID: 14354
		private const string TABLE = "RiskHarvestBuffReward";

		// Token: 0x04003813 RID: 14355
		private const string COMMAND = "select BinData from `RiskHarvestBuffReward`";

		// Token: 0x04003814 RID: 14356
		private const string KEY_PREFIX = "RiskHarvestBuffRewardAll";

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
