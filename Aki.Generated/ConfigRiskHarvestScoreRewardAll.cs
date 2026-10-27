using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080D RID: 2061
	public class ConfigRiskHarvestScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003060 RID: 12384 RVA: 0x0016AB30 File Offset: 0x00168D30
		static ConfigRiskHarvestScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003061 RID: 12385 RVA: 0x0016AB50 File Offset: 0x00168D50
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

		// Token: 0x06003062 RID: 12386 RVA: 0x0016ABCF File Offset: 0x00168DCF
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardAll.LogPair = null;
			ConfigRiskHarvestScoreRewardAll.HandleId = 0;
		}

		// Token: 0x06003063 RID: 12387 RVA: 0x0016ABDD File Offset: 0x00168DDD
		public static void Init()
		{
			ConfigRiskHarvestScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestScoreRewardAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestScoreReward`");
		}

		// Token: 0x06003064 RID: 12388 RVA: 0x0016ABF8 File Offset: 0x00168DF8
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

		// Token: 0x04003841 RID: 14401
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003842 RID: 14402
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003843 RID: 14403
		private const string TABLE = "RiskHarvestScoreReward";

		// Token: 0x04003844 RID: 14404
		private const string COMMAND = "select BinData from `RiskHarvestScoreReward`";

		// Token: 0x04003845 RID: 14405
		private const string KEY_PREFIX = "RiskHarvestScoreRewardAll";

		// Token: 0x04003846 RID: 14406
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003847 RID: 14407
		private static int HandleId;
	}
}
