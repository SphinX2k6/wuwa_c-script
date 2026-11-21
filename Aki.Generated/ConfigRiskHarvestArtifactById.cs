using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081E RID: 2078
	public class ConfigRiskHarvestArtifactById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030C6 RID: 12486 RVA: 0x0017073B File Offset: 0x0016E93B
		static ConfigRiskHarvestArtifactById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestArtifactById.CreateStaticDefaultValue), new Action(ConfigRiskHarvestArtifactById.ResetStaticDefaultValue));
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x0017075C File Offset: 0x0016E95C
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

		// Token: 0x060030C8 RID: 12488 RVA: 0x001707DB File Offset: 0x0016E9DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestArtifactById.LogPair = null;
			ConfigRiskHarvestArtifactById.HandleId = 0;
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x001707E9 File Offset: 0x0016E9E9
		public static void Init()
		{
			ConfigRiskHarvestArtifactById.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestArtifactById.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestArtifact` where Id = ?");
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x00170804 File Offset: 0x0016EA04
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

		// Token: 0x040038B8 RID: 14520
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038B9 RID: 14521
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038BA RID: 14522
		private const string TABLE = "RiskHarvestArtifact";

		// Token: 0x040038BB RID: 14523
		private const string COMMAND = "select BinData from `RiskHarvestArtifact` where Id = ?";

		// Token: 0x040038BC RID: 14524
		private const string KEY_PREFIX = "RiskHarvestArtifactById";

		// Token: 0x040038BD RID: 14525
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038BE RID: 14526
		private static int HandleId;
	}
}
