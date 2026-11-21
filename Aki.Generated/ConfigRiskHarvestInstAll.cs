using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000825 RID: 2085
	public class ConfigRiskHarvestInstAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060030F0 RID: 12528 RVA: 0x001715BC File Offset: 0x0016F7BC
		static ConfigRiskHarvestInstAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstAll.ResetStaticDefaultValue));
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x001715DC File Offset: 0x0016F7DC
		public static void CreateStaticDefaultValue()
		{
			ConfigRiskHarvestInstAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRiskHarvestInstAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_riskharvest.db"),
				new ValueTuple<string, object>("文件", "g.割草冒险活动.xlsx"),
				new ValueTuple<string, object>("表名", "RiskHarvestInst"),
				new ValueTuple<string, object>("语句", "select BinData from `RiskHarvestInst`")
			});
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x0017165B File Offset: 0x0016F85B
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstAll.LogPair = null;
			ConfigRiskHarvestInstAll.HandleId = 0;
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x00171669 File Offset: 0x0016F869
		public static void Init()
		{
			ConfigRiskHarvestInstAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst`");
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x00171684 File Offset: 0x0016F884
		[NullableContext(2)]
		public static IReadOnlyList<RiskHarvestInst> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRiskHarvestInstAll.HandleId, ConfigRiskHarvestInstAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RiskHarvestInst> readOnlyList = (IReadOnlyList<RiskHarvestInst>)ConfigCommon.GetConfig("RiskHarvestInstAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RiskHarvestInst> list = new List<RiskHarvestInst>();
			while (ConfigCommon.Step(ConfigRiskHarvestInstAll.HandleId, false, ConfigRiskHarvestInstAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRiskHarvestInstAll.HandleId, 0, ConfigRiskHarvestInstAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRiskHarvestInstAll.HandleId, ConfigRiskHarvestInstAll.LogPair);
					return null;
				}
				RiskHarvestInst rootAsRiskHarvestInst = RiskHarvestInst.GetRootAsRiskHarvestInst(new ByteBuffer(item2));
				list.Add(rootAsRiskHarvestInst);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RiskHarvestInstAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRiskHarvestInstAll.HandleId, ConfigRiskHarvestInstAll.LogPair);
			return list;
		}

		// Token: 0x040038E9 RID: 14569
		private const string DB = "db_riskharvest.db";

		// Token: 0x040038EA RID: 14570
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040038EB RID: 14571
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x040038EC RID: 14572
		private const string COMMAND = "select BinData from `RiskHarvestInst`";

		// Token: 0x040038ED RID: 14573
		private const string KEY_PREFIX = "RiskHarvestInstAll";

		// Token: 0x040038EE RID: 14574
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040038EF RID: 14575
		private static int HandleId;
	}
}
