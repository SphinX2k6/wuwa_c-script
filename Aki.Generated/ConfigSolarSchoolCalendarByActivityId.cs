using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C2 RID: 2498
	public class ConfigSolarSchoolCalendarByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AA0 RID: 15008 RVA: 0x001A81D3 File Offset: 0x001A63D3
		static ConfigSolarSchoolCalendarByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolCalendarByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolCalendarByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AA1 RID: 15009 RVA: 0x001A81F4 File Offset: 0x001A63F4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolCalendarByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolCalendar"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolCalendar` where ActivityId=?")
			});
		}

		// Token: 0x06003AA2 RID: 15010 RVA: 0x001A8273 File Offset: 0x001A6473
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarByActivityId.LogPair = null;
			ConfigSolarSchoolCalendarByActivityId.HandleId = 0;
		}

		// Token: 0x06003AA3 RID: 15011 RVA: 0x001A8281 File Offset: 0x001A6481
		public static void Init()
		{
			ConfigSolarSchoolCalendarByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolCalendarByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolCalendar` where ActivityId=?");
		}

		// Token: 0x06003AA4 RID: 15012 RVA: 0x001A829C File Offset: 0x001A649C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolCalendar> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolCalendarByActivityId.HandleId, ConfigSolarSchoolCalendarByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolCalendar> readOnlyList = (IReadOnlyList<SolarSchoolCalendar>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolCalendarByActivityId.LogPair.Clear();
			ConfigSolarSchoolCalendarByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolCalendarByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolCalendarByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolCalendarByActivityId.HandleId, ConfigSolarSchoolCalendarByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolCalendar> list = new List<SolarSchoolCalendar>();
			while (ConfigCommon.Step(ConfigSolarSchoolCalendarByActivityId.HandleId, false, ConfigSolarSchoolCalendarByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolCalendarByActivityId.HandleId, 0, ConfigSolarSchoolCalendarByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolCalendarByActivityId.HandleId, ConfigSolarSchoolCalendarByActivityId.LogPair);
					return null;
				}
				SolarSchoolCalendar rootAsSolarSchoolCalendar = SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolCalendar);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolCalendarByActivityId.HandleId, ConfigSolarSchoolCalendarByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004434 RID: 17460
		private const string DB = "db_solarschool.db";

		// Token: 0x04004435 RID: 17461
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004436 RID: 17462
		private const string TABLE = "SolarSchoolCalendar";

		// Token: 0x04004437 RID: 17463
		private const string COMMAND = "select BinData from `SolarSchoolCalendar` where ActivityId=?";

		// Token: 0x04004438 RID: 17464
		private const string KEY_PREFIX = "SolarSchoolCalendarByActivityId";

		// Token: 0x04004439 RID: 17465
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400443A RID: 17466
		private static int HandleId;
	}
}
