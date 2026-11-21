using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000822 RID: 2082
	public class ConfigRiskHarvestBuffRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030DE RID: 12510 RVA: 0x00170F98 File Offset: 0x0016F198
		static ConfigRiskHarvestBuffRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffRewardAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x00170FB8 File Offset: 0x0016F1B8
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

		// Token: 0x060030E0 RID: 12512 RVA: 0x00171037 File Offset: 0x0016F237
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffRewardAll.LogPair = null;
			ConfigRiskHarvestBuffRewardAll.HandleId = 0;
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x00171045 File Offset: 0x0016F245
		public static void Init()
		{
			ConfigRiskHarvestBuffRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffRewardAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffReward`");
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x00171060 File Offset: 0x0016F260
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

		// Token: 0x040038D4 RID: 14548
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038D5 RID: 14549
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038D6 RID: 14550
		private const string TABLE = "RiskHarvestBuffReward";

		// Token: 0x040038D7 RID: 14551
		private const string COMMAND = "select BinData from `RiskHarvestBuffReward`";

		// Token: 0x040038D8 RID: 14552
		private const string KEY_PREFIX = "RiskHarvestBuffRewardAll";

		// Token: 0x040038D9 RID: 14553
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038DA RID: 14554
		private static int HandleId;
	}
}
