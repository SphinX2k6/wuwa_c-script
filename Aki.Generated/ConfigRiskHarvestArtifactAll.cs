using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081D RID: 2077
	public class ConfigRiskHarvestArtifactAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030C0 RID: 12480 RVA: 0x001705A8 File Offset: 0x0016E7A8
		static ConfigRiskHarvestArtifactAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestArtifactAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestArtifactAll.ResetStaticDefaultValue));
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x001705C8 File Offset: 0x0016E7C8
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

		// Token: 0x060030C2 RID: 12482 RVA: 0x00170647 File Offset: 0x0016E847
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestArtifactAll.LogPair = null;
			ConfigRiskHarvestArtifactAll.HandleId = 0;
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x00170655 File Offset: 0x0016E855
		public static void Init()
		{
			ConfigRiskHarvestArtifactAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestArtifactAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestArtifact`");
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x00170670 File Offset: 0x0016E870
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

		// Token: 0x040038B1 RID: 14513
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038B2 RID: 14514
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038B3 RID: 14515
		private const string TABLE = "RiskHarvestArtifact";

		// Token: 0x040038B4 RID: 14516
		private const string COMMAND = "select BinData from `RiskHarvestArtifact`";

		// Token: 0x040038B5 RID: 14517
		private const string KEY_PREFIX = "RiskHarvestArtifactAll";

		// Token: 0x040038B6 RID: 14518
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038B7 RID: 14519
		private static int HandleId;
	}
}
