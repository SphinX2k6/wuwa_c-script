using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009AD RID: 2477
	public class ConfigSolarSchoolActivityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A22 RID: 14882 RVA: 0x001A5684 File Offset: 0x001A3884
		static ConfigSolarSchoolActivityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolActivityAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolActivityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A23 RID: 14883 RVA: 0x001A56A4 File Offset: 0x001A38A4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolActivityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolActivityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolActivity"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolActivity`")
			});
		}

		// Token: 0x06003A24 RID: 14884 RVA: 0x001A5723 File Offset: 0x001A3923
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolActivityAll.LogPair = null;
			ConfigSolarSchoolActivityAll.HandleId = 0;
		}

		// Token: 0x06003A25 RID: 14885 RVA: 0x001A5731 File Offset: 0x001A3931
		public static void Init()
		{
			ConfigSolarSchoolActivityAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolActivityAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolActivity`");
		}

		// Token: 0x06003A26 RID: 14886 RVA: 0x001A574C File Offset: 0x001A394C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolActivity> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolActivityAll.HandleId, ConfigSolarSchoolActivityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolActivity> readOnlyList = (IReadOnlyList<SolarSchoolActivity>)ConfigCommon.GetConfig("SolarSchoolActivityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolActivity> list = new List<SolarSchoolActivity>();
			while (ConfigCommon.Step(ConfigSolarSchoolActivityAll.HandleId, false, ConfigSolarSchoolActivityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolActivityAll.HandleId, 0, ConfigSolarSchoolActivityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolActivityAll.HandleId, ConfigSolarSchoolActivityAll.LogPair);
					return null;
				}
				SolarSchoolActivity rootAsSolarSchoolActivity = SolarSchoolActivity.GetRootAsSolarSchoolActivity(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolActivity);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolActivityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolActivityAll.HandleId, ConfigSolarSchoolActivityAll.LogPair);
			return list;
		}

		// Token: 0x040043A1 RID: 17313
		private const string DB = "db_solarschool.db";

		// Token: 0x040043A2 RID: 17314
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x040043A3 RID: 17315
		private const string TABLE = "SolarSchoolActivity";

		// Token: 0x040043A4 RID: 17316
		private const string COMMAND = "select BinData from `SolarSchoolActivity`";

		// Token: 0x040043A5 RID: 17317
		private const string KEY_PREFIX = "SolarSchoolActivityAll";

		// Token: 0x040043A6 RID: 17318
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040043A7 RID: 17319
		private static int HandleId;
	}
}
