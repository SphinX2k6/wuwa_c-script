using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A14 RID: 2580
	public class ConfigSolarSchoolRoleScheduleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C8C RID: 15500 RVA: 0x001B2F59 File Offset: 0x001B1159
		static ConfigSolarSchoolRoleScheduleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleScheduleAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleScheduleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x001B2F78 File Offset: 0x001B1178
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleScheduleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleSchedule"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleSchedule`")
			});
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x001B2FF7 File Offset: 0x001B11F7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleAll.LogPair = null;
			ConfigSolarSchoolRoleScheduleAll.HandleId = 0;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x001B3005 File Offset: 0x001B1205
		public static void Init()
		{
			ConfigSolarSchoolRoleScheduleAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleScheduleAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleSchedule`");
		}

		// Token: 0x06003C90 RID: 15504 RVA: 0x001B3020 File Offset: 0x001B1220
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleSchedule> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleScheduleAll.HandleId, ConfigSolarSchoolRoleScheduleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolRoleSchedule> readOnlyList = (IReadOnlyList<SolarSchoolRoleSchedule>)ConfigCommon.GetConfig("SolarSchoolRoleScheduleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolRoleSchedule> list = new List<SolarSchoolRoleSchedule>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleScheduleAll.HandleId, false, ConfigSolarSchoolRoleScheduleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleScheduleAll.HandleId, 0, ConfigSolarSchoolRoleScheduleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleAll.HandleId, ConfigSolarSchoolRoleScheduleAll.LogPair);
					return null;
				}
				SolarSchoolRoleSchedule rootAsSolarSchoolRoleSchedule = SolarSchoolRoleSchedule.GetRootAsSolarSchoolRoleSchedule(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleSchedule);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRoleScheduleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleAll.HandleId, ConfigSolarSchoolRoleScheduleAll.LogPair);
			return list;
		}

		// Token: 0x04004672 RID: 18034
		private const string DB = "db_solarschool.db";

		// Token: 0x04004673 RID: 18035
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004674 RID: 18036
		private const string TABLE = "SolarSchoolRoleSchedule";

		// Token: 0x04004675 RID: 18037
		private const string COMMAND = "select BinData from `SolarSchoolRoleSchedule`";

		// Token: 0x04004676 RID: 18038
		private const string KEY_PREFIX = "SolarSchoolRoleScheduleAll";

		// Token: 0x04004677 RID: 18039
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004678 RID: 18040
		private static int HandleId;
	}
}
