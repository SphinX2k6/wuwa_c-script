using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009B5 RID: 2485
	public class ConfigSolarSchoolAvgParamAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A52 RID: 14930 RVA: 0x001A673C File Offset: 0x001A493C
		static ConfigSolarSchoolAvgParamAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolAvgParamAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolAvgParamAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A53 RID: 14931 RVA: 0x001A675C File Offset: 0x001A495C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolAvgParamAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolAvgParamAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_剧情.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolAvgParam"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolAvgParam`")
			});
		}

		// Token: 0x06003A54 RID: 14932 RVA: 0x001A67DB File Offset: 0x001A49DB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolAvgParamAll.LogPair = null;
			ConfigSolarSchoolAvgParamAll.HandleId = 0;
		}

		// Token: 0x06003A55 RID: 14933 RVA: 0x001A67E9 File Offset: 0x001A49E9
		public static void Init()
		{
			ConfigSolarSchoolAvgParamAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolAvgParamAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolAvgParam`");
		}

		// Token: 0x06003A56 RID: 14934 RVA: 0x001A6804 File Offset: 0x001A4A04
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolAvgParam> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolAvgParamAll.HandleId, ConfigSolarSchoolAvgParamAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolAvgParam> readOnlyList = (IReadOnlyList<SolarSchoolAvgParam>)ConfigCommon.GetConfig("SolarSchoolAvgParamAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolAvgParam> list = new List<SolarSchoolAvgParam>();
			while (ConfigCommon.Step(ConfigSolarSchoolAvgParamAll.HandleId, false, ConfigSolarSchoolAvgParamAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolAvgParamAll.HandleId, 0, ConfigSolarSchoolAvgParamAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolAvgParamAll.HandleId, ConfigSolarSchoolAvgParamAll.LogPair);
					return null;
				}
				SolarSchoolAvgParam rootAsSolarSchoolAvgParam = SolarSchoolAvgParam.GetRootAsSolarSchoolAvgParam(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolAvgParam);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolAvgParamAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolAvgParamAll.HandleId, ConfigSolarSchoolAvgParamAll.LogPair);
			return list;
		}

		// Token: 0x040043D9 RID: 17369
		private const string DB = "db_solarschool.db";

		// Token: 0x040043DA RID: 17370
		private const string FILE = "d.第二索拉_剧情.xlsx";

		// Token: 0x040043DB RID: 17371
		private const string TABLE = "SolarSchoolAvgParam";

		// Token: 0x040043DC RID: 17372
		private const string COMMAND = "select BinData from `SolarSchoolAvgParam`";

		// Token: 0x040043DD RID: 17373
		private const string KEY_PREFIX = "SolarSchoolAvgParamAll";

		// Token: 0x040043DE RID: 17374
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043DF RID: 17375
		private static int HandleId;
	}
}
