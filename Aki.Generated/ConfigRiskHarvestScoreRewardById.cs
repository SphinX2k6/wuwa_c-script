using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200082B RID: 2091
	public class ConfigRiskHarvestScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003114 RID: 12564 RVA: 0x001721E3 File Offset: 0x001703E3
		static ConfigRiskHarvestScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestScoreRewardById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x00172204 File Offset: 0x00170404
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

		// Token: 0x06003116 RID: 12566 RVA: 0x00172283 File Offset: 0x00170483
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestScoreRewardById.LogPair = null;
			ConfigRiskHarvestScoreRewardById.HandleId = 0;
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x00172291 File Offset: 0x00170491
		public static void Init()
		{
			ConfigRiskHarvestScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestScoreRewardById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestScoreReward` where Id = ?");
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x001722AC File Offset: 0x001704AC
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

		// Token: 0x04003913 RID: 14611
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003914 RID: 14612
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003915 RID: 14613
		private const string TABLE = "RiskHarvestScoreReward";

		// Token: 0x04003916 RID: 14614
		private const string COMMAND = "select BinData from `RiskHarvestScoreReward` where Id = ?";

		// Token: 0x04003917 RID: 14615
		private const string KEY_PREFIX = "RiskHarvestScoreRewardById";

		// Token: 0x04003918 RID: 14616
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003919 RID: 14617
		private static int HandleId;
	}
}
