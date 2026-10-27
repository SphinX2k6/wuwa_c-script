using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000802 RID: 2050
	public class ConfigRiskHarvestArtifactById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600301E RID: 12318 RVA: 0x00169453 File Offset: 0x00167653
		static ConfigRiskHarvestArtifactById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestArtifactById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestArtifactById.ResetStaticDefaultValue));
		}

		// Token: 0x0600301F RID: 12319 RVA: 0x00169474 File Offset: 0x00167674
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestArtifactById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestArtifactById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestArtifact"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestArtifact` where Id = ?")
			});
		}

		// Token: 0x06003020 RID: 12320 RVA: 0x001694F3 File Offset: 0x001676F3
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestArtifactById.LogPair = null;
			ConfigRiskHarvestArtifactById.HandleId = 0;
		}

		// Token: 0x06003021 RID: 12321 RVA: 0x00169501 File Offset: 0x00167701
		public static void Init()
		{
			ConfigRiskHarvestArtifactById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestArtifactById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestArtifact` where Id = ?");
		}

		// Token: 0x06003022 RID: 12322 RVA: 0x0016951C File Offset: 0x0016771C
		public static RiskHarvestArtifact? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestArtifactById.HandleId, ConfigRiskHarvestArtifactById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestArtifactById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RiskHarvestArtifact?(RiskHarvestArtifact.GetRootAsRiskHarvestArtifact(configBuffer));
				}
			}
			ConfigRiskHarvestArtifactById.LogPair.Clear();
			ConfigRiskHarvestArtifactById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRiskHarvestArtifactById.HandleId, 1, p0Id, ConfigRiskHarvestArtifactById.LogPair) || ConfigCommon.Step(ConfigRiskHarvestArtifactById.HandleId, true, ConfigRiskHarvestArtifactById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRiskHarvestArtifactById.HandleId, ConfigRiskHarvestArtifactById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestArtifactById.HandleId, 0, ConfigRiskHarvestArtifactById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRiskHarvestArtifactById.HandleId, ConfigRiskHarvestArtifactById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RiskHarvestArtifact rootAsRiskHarvestArtifact = RiskHarvestArtifact.GetRootAsRiskHarvestArtifact(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RiskHarvestArtifactById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRiskHarvestArtifactById.HandleId, ConfigRiskHarvestArtifactById.LogPair);
			return new RiskHarvestArtifact?(rootAsRiskHarvestArtifact);
		}

		// Token: 0x040037F4 RID: 14324
		private const string DB = "db_riskharvest.db";

		// Token: 0x040037F5 RID: 14325
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040037F6 RID: 14326
		private const string TABLE = "RiskHarvestArtifact";

		// Token: 0x040037F7 RID: 14327
		private const string COMMAND = "select BinData from `RiskHarvestArtifact` where Id = ?";

		// Token: 0x040037F8 RID: 14328
		private const string KEY_PREFIX = "RiskHarvestArtifactById";

		// Token: 0x040037F9 RID: 14329
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037FA RID: 14330
		private static int HandleId;
	}
}
