using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080E RID: 2062
	public class ConfigRiskHarvestScoreRewardByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003066 RID: 12390 RVA: 0x0016ACC3 File Offset: 0x00168EC3
		static ConfigRiskHarvestScoreRewardByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestScoreRewardByActivityId.CreateStaticDefaultValue), new Action(ConfigRiskHarvestScoreRewardByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003067 RID: 12391 RVA: 0x0016ACE4 File Offset: 0x00168EE4
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestScoreRewardByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestScoreReward` where ActivityId = ?")
			});
		}

		// Token: 0x06003068 RID: 12392 RVA: 0x0016AD63 File Offset: 0x00168F63
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardByActivityId.LogPair = null;
			ConfigRiskHarvestScoreRewardByActivityId.HandleId = 0;
		}

		// Token: 0x06003069 RID: 12393 RVA: 0x0016AD71 File Offset: 0x00168F71
		public static void Init()
		{
			ConfigRiskHarvestScoreRewardByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestScoreRewardByActivityId.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestScoreReward` where ActivityId = ?");
		}

		// Token: 0x0600306A RID: 12394 RVA: 0x0016AD8C File Offset: 0x00168F8C
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestScoreReward> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestScoreRewardByActivityId.HandleId, ConfigRiskHarvestScoreRewardByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<RiskHarvestScoreReward> readOnlyList = (IReadOnlyList<RiskHarvestScoreReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRiskHarvestScoreRewardByActivityId.LogPair.Clear();
			ConfigRiskHarvestScoreRewardByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestScoreRewardByActivityId.HandleId, 1, p0ActivityId, ConfigRiskHarvestScoreRewardByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigRiskHarvestScoreRewardByActivityId.HandleId, ConfigRiskHarvestScoreRewardByActivityId.LogPair);
				return null;
			}
			List<RiskHarvestScoreReward> list = new List<RiskHarvestScoreReward>();
			while (ConfigCommon.Step(ConfigRiskHarvestScoreRewardByActivityId.HandleId, false, ConfigRiskHarvestScoreRewardByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestScoreRewardByActivityId.HandleId, 0, ConfigRiskHarvestScoreRewardByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestScoreRewardByActivityId.HandleId, ConfigRiskHarvestScoreRewardByActivityId.LogPair);
					return null;
				}
				RiskHarvestScoreReward rootAsRiskHarvestScoreReward = RiskHarvestScoreReward.GetRootAsRiskHarvestScoreReward(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestScoreReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestScoreRewardByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestScoreRewardByActivityId.HandleId, ConfigRiskHarvestScoreRewardByActivityId.LogPair);
			return list;
		}

		// Token: 0x04003848 RID: 14408
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003849 RID: 14409
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x0400384A RID: 14410
		private const string TABLE = "RiskHarvestScoreReward";

		// Token: 0x0400384B RID: 14411
		private const string COMMAND = "select BinData from `RiskHarvestScoreReward` where ActivityId = ?";

		// Token: 0x0400384C RID: 14412
		private const string KEY_PREFIX = "RiskHarvestScoreRewardByActivityId";

		// Token: 0x0400384D RID: 14413
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400384E RID: 14414
		private static int HandleId;
	}
}
