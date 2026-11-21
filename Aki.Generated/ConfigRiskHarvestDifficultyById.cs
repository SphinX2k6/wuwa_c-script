using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000824 RID: 2084
	public class ConfigRiskHarvestDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030EA RID: 12522 RVA: 0x00171374 File Offset: 0x0016F574
		static ConfigRiskHarvestDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestDifficultyById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x00171394 File Offset: 0x0016F594
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestDifficultyById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestDifficultyById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestDifficulty"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestDifficulty` where Id=?")
			});
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x00171413 File Offset: 0x0016F613
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestDifficultyById.LogPair = null;
			ConfigRiskHarvestDifficultyById.HandleId = 0;
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x00171421 File Offset: 0x0016F621
		public static void Init()
		{
			ConfigRiskHarvestDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestDifficultyById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestDifficulty` where Id=?");
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x0017143C File Offset: 0x0016F63C
		public static RiskHarvestDifficulty? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestDifficultyById.HandleId, ConfigRiskHarvestDifficultyById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestDifficulty?(RiskHarvestDifficulty.GetRootAsRiskHarvestDifficulty(configBuffer));
				}
			}
			ConfigRiskHarvestDifficultyById.LogPair.Clear();
			ConfigRiskHarvestDifficultyById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestDifficultyById.HandleId, 1, p0Id, ConfigRiskHarvestDifficultyById.LogPair) || ConfigCommon.Step(ConfigRiskHarvestDifficultyById.HandleId, true, ConfigRiskHarvestDifficultyById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestDifficultyById.HandleId, ConfigRiskHarvestDifficultyById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestDifficultyById.HandleId, 0, ConfigRiskHarvestDifficultyById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestDifficultyById.HandleId, ConfigRiskHarvestDifficultyById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestDifficulty rootAsRiskHarvestDifficulty = RiskHarvestDifficulty.GetRootAsRiskHarvestDifficulty(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestDifficultyById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestDifficultyById.HandleId, ConfigRiskHarvestDifficultyById.LogPair);
			return new RiskHarvestDifficulty?(rootAsRiskHarvestDifficulty);
		}

		// Token: 0x040038E2 RID: 14562
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038E3 RID: 14563
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038E4 RID: 14564
		private const string TABLE = "RiskHarvestDifficulty";

		// Token: 0x040038E5 RID: 14565
		private const string COMMAND = "select BinData from `RiskHarvestDifficulty` where Id=?";

		// Token: 0x040038E6 RID: 14566
		private const string KEY_PREFIX = "RiskHarvestDifficultyById";

		// Token: 0x040038E7 RID: 14567
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038E8 RID: 14568
		private static int HandleId;
	}
}
