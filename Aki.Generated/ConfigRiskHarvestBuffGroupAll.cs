using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000803 RID: 2051
	public class ConfigRiskHarvestBuffGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003024 RID: 12324 RVA: 0x0016969C File Offset: 0x0016789C
		static ConfigRiskHarvestBuffGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRiskHarvestBuffGroupAll.CreateStaticDefaultValue), new Action(ConfigRiskHarvestBuffGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003025 RID: 12325 RVA: 0x001696BC File Offset: 0x001678BC
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

		// Token: 0x06003026 RID: 12326 RVA: 0x0016973B File Offset: 0x0016793B
		public static void ResetStaticDefaultValue()
		{
			ConfigRiskHarvestBuffGroupAll.LogPair = null;
			ConfigRiskHarvestBuffGroupAll.HandleId = 0;
		}

		// Token: 0x06003027 RID: 12327 RVA: 0x00169749 File Offset: 0x00167949
		public static void Init()
		{
			ConfigRiskHarvestBuffGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRiskHarvestBuffGroupAll.HandleId, "db_riskharvest.db", "select BinData from `RiskHarvestBuffGroup`");
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x00169764 File Offset: 0x00167964
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

		// Token: 0x040037FB RID: 14331
		private const string DB = "db_riskharvest.db";

		// Token: 0x040037FC RID: 14332
		private const string FILE = "g.割草冒险活动.xlsx";

		// Token: 0x040037FD RID: 14333
		private const string TABLE = "RiskHarvestBuffGroup";

		// Token: 0x040037FE RID: 14334
		private const string COMMAND = "select BinData from `RiskHarvestBuffGroup`";

		// Token: 0x040037FF RID: 14335
		private const string KEY_PREFIX = "RiskHarvestBuffGroupAll";

		// Token: 0x04003800 RID: 14336
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003801 RID: 14337
		private static int HandleId;
	}
}
