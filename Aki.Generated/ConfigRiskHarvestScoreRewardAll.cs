using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000829 RID: 2089
	public class ConfigRiskHarvestScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003108 RID: 12552 RVA: 0x00171E18 File Offset: 0x00170018
		static ConfigRiskHarvestScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x00171E38 File Offset: 0x00170038
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestScoreReward`")
			});
		}

		// Token: 0x0600310A RID: 12554 RVA: 0x00171EB7 File Offset: 0x001700B7
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardAll.LogPair = null;
			ConfigRiskHarvestScoreRewardAll.HandleId = 0;
		}

		// Token: 0x0600310B RID: 12555 RVA: 0x00171EC5 File Offset: 0x001700C5
		public static void Init()
		{
			ConfigRiskHarvestScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestScoreRewardAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestScoreReward`");
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x00171EE0 File Offset: 0x001700E0
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestScoreRewardAll.HandleId, ConfigRiskHarvestScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RiskHarvestScoreReward> readOnlyList = (IReadOnlyList<RiskHarvestScoreReward>)ConfigCommon.GetConfig("RiskHarvestScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RiskHarvestScoreReward> list = new List<RiskHarvestScoreReward>();
			while (ConfigCommon.Step(ConfigRiskHarvestScoreRewardAll.HandleId, false, ConfigRiskHarvestScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestScoreRewardAll.HandleId, 0, ConfigRiskHarvestScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestScoreRewardAll.HandleId, ConfigRiskHarvestScoreRewardAll.LogPair);
					return null;
				}
				RiskHarvestScoreReward rootAsRiskHarvestScoreReward = RiskHarvestScoreReward.GetRootAsRiskHarvestScoreReward(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RiskHarvestScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestScoreRewardAll.HandleId, ConfigRiskHarvestScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003905 RID: 14597
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003906 RID: 14598
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003907 RID: 14599
		private const string TABLE = "RiskHarvestScoreReward";

		// Token: 0x04003908 RID: 14600
		private const string COMMAND = "select BinData from `RiskHarvestScoreReward`";

		// Token: 0x04003909 RID: 14601
		private const string KEY_PREFIX = "RiskHarvestScoreRewardAll";

		// Token: 0x0400390A RID: 14602
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400390B RID: 14603
		private static int HandleId;
	}
}
