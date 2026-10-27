using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000809 RID: 2057
	public class ConfigRiskHarvestInstAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003048 RID: 12360 RVA: 0x0016A2D4 File Offset: 0x001684D4
		static ConfigRiskHarvestInstAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestInstAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestInstAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003049 RID: 12361 RVA: 0x0016A2F4 File Offset: 0x001684F4
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

		// Token: 0x0600304A RID: 12362 RVA: 0x0016A373 File Offset: 0x00168573
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestInstAll.LogPair = null;
			ConfigRiskHarvestInstAll.HandleId = 0;
		}

		// Token: 0x0600304B RID: 12363 RVA: 0x0016A381 File Offset: 0x00168581
		public static void Init()
		{
			ConfigRiskHarvestInstAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestInstAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestInst`");
		}

		// Token: 0x0600304C RID: 12364 RVA: 0x0016A39C File Offset: 0x0016859C
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

		// Token: 0x04003825 RID: 14373
		private const string DB = "db_riskharvest.db";

		// Token: 0x04003826 RID: 14374
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x04003827 RID: 14375
		private const string TABLE = "RiskHarvestInst";

		// Token: 0x04003828 RID: 14376
		private const string COMMAND = "select BinData from `RiskHarvestInst`";

		// Token: 0x04003829 RID: 14377
		private const string KEY_PREFIX = "RiskHarvestInstAll";

		// Token: 0x0400382A RID: 14378
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400382B RID: 14379
		private static int HandleId;
	}
}
