using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C3 RID: 2499
	public class ConfigSolarSchoolCalendarByDayIndex : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AA6 RID: 15014 RVA: 0x001A840B File Offset: 0x001A660B
		static ConfigSolarSchoolCalendarByDayIndex()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolCalendarByDayIndex.CreateStaticDefaultValue), new Action(ConfigSolarSchoolCalendarByDayIndex.ResetStaticDefaultValue));
		}

		// Token: 0x06003AA7 RID: 15015 RVA: 0x001A842C File Offset: 0x001A662C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarByDayIndex.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolCalendarByDayIndex.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolCalendar"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolCalendar` where DayIndex=?")
			});
		}

		// Token: 0x06003AA8 RID: 15016 RVA: 0x001A84AB File Offset: 0x001A66AB
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarByDayIndex.LogPair = null;
			ConfigSolarSchoolCalendarByDayIndex.HandleId = 0;
		}

		// Token: 0x06003AA9 RID: 15017 RVA: 0x001A84B9 File Offset: 0x001A66B9
		public static void Init()
		{
			ConfigSolarSchoolCalendarByDayIndex.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolCalendarByDayIndex.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolCalendar` where DayIndex=?");
		}

		// Token: 0x06003AAA RID: 15018 RVA: 0x001A84D4 File Offset: 0x001A66D4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolCalendar> GetConfigList(int p0DayIndex, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolCalendarByDayIndex.HandleId, ConfigSolarSchoolCalendarByDayIndex.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarByDayIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DayIndex);
				IReadOnlyList<SolarSchoolCalendar> readOnlyList = (IReadOnlyList<SolarSchoolCalendar>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolCalendarByDayIndex.LogPair.Clear();
			ConfigSolarSchoolCalendarByDayIndex.LogPair.Add(new ValueTuple<string, object>("DayIndex", p0DayIndex));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolCalendarByDayIndex.HandleId, 1, p0DayIndex, ConfigSolarSchoolCalendarByDayIndex.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolCalendarByDayIndex.HandleId, ConfigSolarSchoolCalendarByDayIndex.LogPair);
				return null;
			}
			List<SolarSchoolCalendar> list = new List<SolarSchoolCalendar>();
			while (ConfigCommon.Step(ConfigSolarSchoolCalendarByDayIndex.HandleId, false, ConfigSolarSchoolCalendarByDayIndex.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolCalendarByDayIndex.HandleId, 0, ConfigSolarSchoolCalendarByDayIndex.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolCalendarByDayIndex.HandleId, ConfigSolarSchoolCalendarByDayIndex.LogPair);
					return null;
				}
				SolarSchoolCalendar rootAsSolarSchoolCalendar = SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolCalendar);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarByDayIndex");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0DayIndex);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolCalendarByDayIndex.HandleId, ConfigSolarSchoolCalendarByDayIndex.LogPair);
			return list;
		}

		// Token: 0x0400443B RID: 17467
		private const string DB = "db_solarschool.db";

		// Token: 0x0400443C RID: 17468
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400443D RID: 17469
		private const string TABLE = "SolarSchoolCalendar";

		// Token: 0x0400443E RID: 17470
		private const string COMMAND = "select BinData from `SolarSchoolCalendar` where DayIndex=?";

		// Token: 0x0400443F RID: 17471
		private const string KEY_PREFIX = "SolarSchoolCalendarByDayIndex";

		// Token: 0x04004440 RID: 17472
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004441 RID: 17473
		private static int HandleId;
	}
}
