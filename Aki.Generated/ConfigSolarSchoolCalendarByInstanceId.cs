using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C5 RID: 2501
	public class ConfigSolarSchoolCalendarByInstanceId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AB2 RID: 15026 RVA: 0x001A888C File Offset: 0x001A6A8C
		static ConfigSolarSchoolCalendarByInstanceId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolCalendarByInstanceId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolCalendarByInstanceId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AB3 RID: 15027 RVA: 0x001A88AC File Offset: 0x001A6AAC
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarByInstanceId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolCalendarByInstanceId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolCalendar"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolCalendar` where InstanceId=?")
			});
		}

		// Token: 0x06003AB4 RID: 15028 RVA: 0x001A892B File Offset: 0x001A6B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarByInstanceId.LogPair = null;
			ConfigSolarSchoolCalendarByInstanceId.HandleId = 0;
		}

		// Token: 0x06003AB5 RID: 15029 RVA: 0x001A8939 File Offset: 0x001A6B39
		public static void Init()
		{
			ConfigSolarSchoolCalendarByInstanceId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolCalendarByInstanceId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolCalendar` where InstanceId=?");
		}

		// Token: 0x06003AB6 RID: 15030 RVA: 0x001A8954 File Offset: 0x001A6B54
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolCalendar> GetConfigList(int p0InstanceId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolCalendarByInstanceId.HandleId, ConfigSolarSchoolCalendarByInstanceId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarByInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceId);
				IReadOnlyList<SolarSchoolCalendar> readOnlyList = (IReadOnlyList<SolarSchoolCalendar>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolCalendarByInstanceId.LogPair.Clear();
			ConfigSolarSchoolCalendarByInstanceId.LogPair.Add(new ValueTuple<string, object>("InstanceId", p0InstanceId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolCalendarByInstanceId.HandleId, 1, p0InstanceId, ConfigSolarSchoolCalendarByInstanceId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolCalendarByInstanceId.HandleId, ConfigSolarSchoolCalendarByInstanceId.LogPair);
				return null;
			}
			List<SolarSchoolCalendar> list = new List<SolarSchoolCalendar>();
			while (ConfigCommon.Step(ConfigSolarSchoolCalendarByInstanceId.HandleId, false, ConfigSolarSchoolCalendarByInstanceId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolCalendarByInstanceId.HandleId, 0, ConfigSolarSchoolCalendarByInstanceId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolCalendarByInstanceId.HandleId, ConfigSolarSchoolCalendarByInstanceId.LogPair);
					return null;
				}
				SolarSchoolCalendar rootAsSolarSchoolCalendar = SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolCalendar);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarByInstanceId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0InstanceId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolCalendarByInstanceId.HandleId, ConfigSolarSchoolCalendarByInstanceId.LogPair);
			return list;
		}

		// Token: 0x04004449 RID: 17481
		private const string DB = "db_solarschool.db";

		// Token: 0x0400444A RID: 17482
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x0400444B RID: 17483
		private const string TABLE = "SolarSchoolCalendar";

		// Token: 0x0400444C RID: 17484
		private const string COMMAND = "select BinData from `SolarSchoolCalendar` where InstanceId=?";

		// Token: 0x0400444D RID: 17485
		private const string KEY_PREFIX = "SolarSchoolCalendarByInstanceId";

		// Token: 0x0400444E RID: 17486
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400444F RID: 17487
		private static int HandleId;
	}
}
