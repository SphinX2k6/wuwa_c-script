using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200080F RID: 2063
	public class ConfigRiskHarvestScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600306C RID: 12396 RVA: 0x0016AEFB File Offset: 0x001690FB
		static ConfigRiskHarvestScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestScoreRewardById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x0016AF1C File Offset: 0x0016911C
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestScoreReward` where Id = ?")
			});
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x0016AF9B File Offset: 0x0016919B
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardById.LogPair = null;
			ConfigRiskHarvestScoreRewardById.HandleId = 0;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x0016AFA9 File Offset: 0x001691A9
		public static void Init()
		{
			ConfigRiskHarvestScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestScoreRewardById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestScoreReward` where Id = ?");
		}

		// Token: 0x06003070 RID: 12400 RVA: 0x0016AFC4 File Offset: 0x001691C4
		public static RiskHarvestScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestScoreRewardById.HandleId, ConfigRiskHarvestScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestScoreReward?(RiskHarvestScoreReward.GetRootAsRiskHarvestScoreReward(configBuffer));
				}
			}
			ConfigRiskHarvestScoreRewardById.LogPair.Clear();
			ConfigRiskHarvestScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestScoreRewardById.HandleId, 1, p0Id, ConfigRiskHarvestScoreRewardById.LogPair) || ConfigCommon.Step(ConfigRiskHarvestScoreRewardById.HandleId, true, ConfigRiskHarvestScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestScoreRewardById.HandleId, ConfigRiskHarvestScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestScoreRewardById.HandleId, 0, ConfigRiskHarvestScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestScoreRewardById.HandleId, ConfigRiskHarvestScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestScoreReward rootAsRiskHarvestScoreReward = RiskHarvestScoreReward.GetRootAsRiskHarvestScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestScoreRewardById.HandleId, ConfigRiskHarvestScoreRewardById.LogPair);
			return new RiskHarvestScoreReward?(rootAsRiskHarvestScoreReward);
		}

		// Token: 0x0400384F RID: 14415
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003850 RID: 14416
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003851 RID: 14417
		private const string TABLE = "RiskHarvestScoreReward";

		// Token: 0x04003852 RID: 14418
		private const string COMMAND = "select BinData from `RiskHarvestScoreReward` where Id = ?";

		// Token: 0x04003853 RID: 14419
		private const string KEY_PREFIX = "RiskHarvestScoreRewardById";

		// Token: 0x04003854 RID: 14420
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003855 RID: 14421
		private static int HandleId;
	}
}
