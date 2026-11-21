using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CC RID: 2508
	public class ConfigSolarSchoolEndingFlowAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ADC RID: 15068 RVA: 0x001A96EC File Offset: 0x001A78EC
		static ConfigSolarSchoolEndingFlowAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingFlowAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingFlowAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003ADD RID: 15069 RVA: 0x001A970C File Offset: 0x001A790C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingFlowAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingFlowAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEndingFlow"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEndingFlow`")
			});
		}

		// Token: 0x06003ADE RID: 15070 RVA: 0x001A978B File Offset: 0x001A798B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingFlowAll.LogPair = null;
			ConfigSolarSchoolEndingFlowAll.HandleId = 0;
		}

		// Token: 0x06003ADF RID: 15071 RVA: 0x001A9799 File Offset: 0x001A7999
		public static void Init()
		{
			ConfigSolarSchoolEndingFlowAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingFlowAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEndingFlow`");
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x001A97B4 File Offset: 0x001A79B4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolEndingFlow> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingFlowAll.HandleId, ConfigSolarSchoolEndingFlowAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolEndingFlow> readOnlyList = (IReadOnlyList<SolarSchoolEndingFlow>)ConfigCommon.GetConfig("SolarSchoolEndingFlowAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolEndingFlow> list = new List<SolarSchoolEndingFlow>();
			while (ConfigCommon.Step(ConfigSolarSchoolEndingFlowAll.HandleId, false, ConfigSolarSchoolEndingFlowAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingFlowAll.HandleId, 0, ConfigSolarSchoolEndingFlowAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolEndingFlowAll.HandleId, ConfigSolarSchoolEndingFlowAll.LogPair);
					return null;
				}
				SolarSchoolEndingFlow rootAsSolarSchoolEndingFlow = SolarSchoolEndingFlow.GetRootAsSolarSchoolEndingFlow(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolEndingFlow);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolEndingFlowAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingFlowAll.HandleId, ConfigSolarSchoolEndingFlowAll.LogPair);
			return list;
		}

		// Token: 0x0400447A RID: 17530
		private const string DB = "db_solarschool.db";

		// Token: 0x0400447B RID: 17531
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x0400447C RID: 17532
		private const string TABLE = "SolarSchoolEndingFlow";

		// Token: 0x0400447D RID: 17533
		private const string COMMAND = "select BinData from `SolarSchoolEndingFlow`";

		// Token: 0x0400447E RID: 17534
		private const string KEY_PREFIX = "SolarSchoolEndingFlowAll";

		// Token: 0x0400447F RID: 17535
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004480 RID: 17536
		private static int HandleId;
	}
}
