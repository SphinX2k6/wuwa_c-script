using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C1 RID: 2497
	public class ConfigSolarSchoolCalendarAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003A9A RID: 15002 RVA: 0x001A8040 File Offset: 0x001A6240
		static ConfigSolarSchoolCalendarAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolCalendarAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolCalendarAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003A9B RID: 15003 RVA: 0x001A8060 File Offset: 0x001A6260
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolCalendarAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolCalendar"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolCalendar`")
			});
		}

		// Token: 0x06003A9C RID: 15004 RVA: 0x001A80DF File Offset: 0x001A62DF
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarAll.LogPair = null;
			ConfigSolarSchoolCalendarAll.HandleId = 0;
		}

		// Token: 0x06003A9D RID: 15005 RVA: 0x001A80ED File Offset: 0x001A62ED
		public static void Init()
		{
			ConfigSolarSchoolCalendarAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolCalendarAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolCalendar`");
		}

		// Token: 0x06003A9E RID: 15006 RVA: 0x001A8108 File Offset: 0x001A6308
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolCalendar> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolCalendarAll.HandleId, ConfigSolarSchoolCalendarAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolCalendar> readOnlyList = (IReadOnlyList<SolarSchoolCalendar>)ConfigCommon.GetConfig("SolarSchoolCalendarAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolCalendar> list = new List<SolarSchoolCalendar>();
			while (ConfigCommon.Step(ConfigSolarSchoolCalendarAll.HandleId, false, ConfigSolarSchoolCalendarAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolCalendarAll.HandleId, 0, ConfigSolarSchoolCalendarAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolCalendarAll.HandleId, ConfigSolarSchoolCalendarAll.LogPair);
					return null;
				}
				SolarSchoolCalendar rootAsSolarSchoolCalendar = SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolCalendar);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolCalendarAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolCalendarAll.HandleId, ConfigSolarSchoolCalendarAll.LogPair);
			return list;
		}

		// Token: 0x0400442D RID: 17453
		private const string DB = "db_solarschool.db";

		// Token: 0x0400442E RID: 17454
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400442F RID: 17455
		private const string TABLE = "SolarSchoolCalendar";

		// Token: 0x04004430 RID: 17456
		private const string COMMAND = "select BinData from `SolarSchoolCalendar`";

		// Token: 0x04004431 RID: 17457
		private const string KEY_PREFIX = "SolarSchoolCalendarAll";

		// Token: 0x04004432 RID: 17458
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004433 RID: 17459
		private static int HandleId;
	}
}
