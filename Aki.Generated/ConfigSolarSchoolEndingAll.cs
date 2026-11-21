using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C9 RID: 2505
	public class ConfigSolarSchoolEndingAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ACA RID: 15050 RVA: 0x001A90D8 File Offset: 0x001A72D8
		static ConfigSolarSchoolEndingAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003ACB RID: 15051 RVA: 0x001A90F8 File Offset: 0x001A72F8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEnding"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEnding`")
			});
		}

		// Token: 0x06003ACC RID: 15052 RVA: 0x001A9177 File Offset: 0x001A7377
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingAll.LogPair = null;
			ConfigSolarSchoolEndingAll.HandleId = 0;
		}

		// Token: 0x06003ACD RID: 15053 RVA: 0x001A9185 File Offset: 0x001A7385
		public static void Init()
		{
			ConfigSolarSchoolEndingAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEnding`");
		}

		// Token: 0x06003ACE RID: 15054 RVA: 0x001A91A0 File Offset: 0x001A73A0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolEnding> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingAll.HandleId, ConfigSolarSchoolEndingAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolEnding> readOnlyList = (IReadOnlyList<SolarSchoolEnding>)ConfigCommon.GetConfig("SolarSchoolEndingAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolEnding> list = new List<SolarSchoolEnding>();
			while (ConfigCommon.Step(ConfigSolarSchoolEndingAll.HandleId, false, ConfigSolarSchoolEndingAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingAll.HandleId, 0, ConfigSolarSchoolEndingAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolEndingAll.HandleId, ConfigSolarSchoolEndingAll.LogPair);
					return null;
				}
				SolarSchoolEnding rootAsSolarSchoolEnding = SolarSchoolEnding.GetRootAsSolarSchoolEnding(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolEnding);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolEndingAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingAll.HandleId, ConfigSolarSchoolEndingAll.LogPair);
			return list;
		}

		// Token: 0x04004465 RID: 17509
		private const string DB = "db_solarschool.db";

		// Token: 0x04004466 RID: 17510
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004467 RID: 17511
		private const string TABLE = "SolarSchoolEnding";

		// Token: 0x04004468 RID: 17512
		private const string COMMAND = "select BinData from `SolarSchoolEnding`";

		// Token: 0x04004469 RID: 17513
		private const string KEY_PREFIX = "SolarSchoolEndingAll";

		// Token: 0x0400446A RID: 17514
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400446B RID: 17515
		private static int HandleId;
	}
}
