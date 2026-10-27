using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000801 RID: 2049
	public class ConfigRiskHarvestArtifactAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003018 RID: 12312 RVA: 0x001692C0 File Offset: 0x001674C0
		static ConfigRiskHarvestArtifactAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestArtifactAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestArtifactAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003019 RID: 12313 RVA: 0x001692E0 File Offset: 0x001674E0
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestArtifactAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestArtifactAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestArtifact"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestArtifact`")
			});
		}

		// Token: 0x0600301A RID: 12314 RVA: 0x0016935F File Offset: 0x0016755F
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestArtifactAll.LogPair = null;
			ConfigRiskHarvestArtifactAll.HandleId = 0;
		}

		// Token: 0x0600301B RID: 12315 RVA: 0x0016936D File Offset: 0x0016756D
		public static void Init()
		{
			ConfigRiskHarvestArtifactAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestArtifactAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestArtifact`");
		}

		// Token: 0x0600301C RID: 12316 RVA: 0x00169388 File Offset: 0x00167588
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestArtifact> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestArtifactAll.HandleId, ConfigRiskHarvestArtifactAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RiskHarvestArtifact> readOnlyList = (IReadOnlyList<RiskHarvestArtifact>)ConfigCommon.GetConfig("RiskHarvestArtifactAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RiskHarvestArtifact> list = new List<RiskHarvestArtifact>();
			while (ConfigCommon.Step(ConfigRiskHarvestArtifactAll.HandleId, false, ConfigRiskHarvestArtifactAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestArtifactAll.HandleId, 0, ConfigRiskHarvestArtifactAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestArtifactAll.HandleId, ConfigRiskHarvestArtifactAll.LogPair);
					return null;
				}
				RiskHarvestArtifact rootAsRiskHarvestArtifact = RiskHarvestArtifact.GetRootAsRiskHarvestArtifact(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestArtifact);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RiskHarvestArtifactAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestArtifactAll.HandleId, ConfigRiskHarvestArtifactAll.LogPair);
			return list;
		}

		// Token: 0x040037ED RID: 14317
		private const string DB = "db_riskharvest.db";

		// Token: 0x040037EE RID: 14318
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040037EF RID: 14319
		private const string TABLE = "RiskHarvestArtifact";

		// Token: 0x040037F0 RID: 14320
		private const string COMMAND = "select BinData from `RiskHarvestArtifact`";

		// Token: 0x040037F1 RID: 14321
		private const string KEY_PREFIX = "RiskHarvestArtifactAll";

		// Token: 0x040037F2 RID: 14322
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040037F3 RID: 14323
		private static int HandleId;
	}
}
