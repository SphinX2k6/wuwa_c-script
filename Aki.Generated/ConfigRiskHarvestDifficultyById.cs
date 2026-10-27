using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000808 RID: 2056
	public class ConfigRiskHarvestDifficultyById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003042 RID: 12354 RVA: 0x0016A08C File Offset: 0x0016828C
		static ConfigRiskHarvestDifficultyById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestDifficultyById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestDifficultyById.ResetStaticDefaultValue));
		}

		// Token: 0x06003043 RID: 12355 RVA: 0x0016A0AC File Offset: 0x001682AC
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

		// Token: 0x06003044 RID: 12356 RVA: 0x0016A12B File Offset: 0x0016832B
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestDifficultyById.LogPair = null;
			ConfigRiskHarvestDifficultyById.HandleId = 0;
		}

		// Token: 0x06003045 RID: 12357 RVA: 0x0016A139 File Offset: 0x00168339
		public static void Init()
		{
			ConfigRiskHarvestDifficultyById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestDifficultyById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestDifficulty` where Id=?");
		}

		// Token: 0x06003046 RID: 12358 RVA: 0x0016A154 File Offset: 0x00168354
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

		// Token: 0x0400381E RID: 14366
		private const string DB = "db_riskharvest.db";

		// Token: 0x0400381F RID: 14367
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003820 RID: 14368
		private const string TABLE = "RiskHarvestDifficulty";

		// Token: 0x04003821 RID: 14369
		private const string COMMAND = "select BinData from `RiskHarvestDifficulty` where Id=?";

		// Token: 0x04003822 RID: 14370
		private const string KEY_PREFIX = "RiskHarvestDifficultyById";

		// Token: 0x04003823 RID: 14371
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003824 RID: 14372
		private static int HandleId;
	}
}
