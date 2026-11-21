using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200081F RID: 2079
	public class ConfigRiskHarvestBuffGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030CC RID: 12492 RVA: 0x00170984 File Offset: 0x0016EB84
		static ConfigRiskHarvestBuffGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffGroupAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x001709A4 File Offset: 0x0016EBA4
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestBuffGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestBuffGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestBuffGroup`")
			});
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x00170A23 File Offset: 0x0016EC23
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupAll.LogPair = null;
			ConfigRiskHarvestBuffGroupAll.HandleId = 0;
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x00170A31 File Offset: 0x0016EC31
		public static void Init()
		{
			ConfigRiskHarvestBuffGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffGroupAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffGroup`");
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x00170A4C File Offset: 0x0016EC4C
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestBuffGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestBuffGroupAll.HandleId, ConfigRiskHarvestBuffGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RiskHarvestBuffGroup> readOnlyList = (IReadOnlyList<RiskHarvestBuffGroup>)ConfigCommon.GetConfig("RiskHarvestBuffGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RiskHarvestBuffGroup> list = new List<RiskHarvestBuffGroup>();
			while (ConfigCommon.Step(ConfigRiskHarvestBuffGroupAll.HandleId, false, ConfigRiskHarvestBuffGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestBuffGroupAll.HandleId, 0, ConfigRiskHarvestBuffGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestBuffGroupAll.HandleId, ConfigRiskHarvestBuffGroupAll.LogPair);
					return null;
				}
				RiskHarvestBuffGroup rootAsRiskHarvestBuffGroup = RiskHarvestBuffGroup.GetRootAsRiskHarvestBuffGroup(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestBuffGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RiskHarvestBuffGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestBuffGroupAll.HandleId, ConfigRiskHarvestBuffGroupAll.LogPair);
			return list;
		}

		// Token: 0x040038BF RID: 14527
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038C0 RID: 14528
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038C1 RID: 14529
		private const string TABLE = "RiskHarvestBuffGroup";

		// Token: 0x040038C2 RID: 14530
		private const string COMMAND = "select BinData from `RiskHarvestBuffGroup`";

		// Token: 0x040038C3 RID: 14531
		private const string KEY_PREFIX = "RiskHarvestBuffGroupAll";

		// Token: 0x040038C4 RID: 14532
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038C5 RID: 14533
		private static int HandleId;
	}
}
