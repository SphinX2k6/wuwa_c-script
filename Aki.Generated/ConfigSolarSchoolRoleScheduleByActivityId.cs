using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A15 RID: 2581
	public class ConfigSolarSchoolRoleScheduleByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C92 RID: 15506 RVA: 0x001B30EB File Offset: 0x001B12EB
		static ConfigSolarSchoolRoleScheduleByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleScheduleByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleScheduleByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C93 RID: 15507 RVA: 0x001B310C File Offset: 0x001B130C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleScheduleByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleSchedule"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleSchedule` where ActivityId=?")
			});
		}

		// Token: 0x06003C94 RID: 15508 RVA: 0x001B318B File Offset: 0x001B138B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleByActivityId.LogPair = null;
			ConfigSolarSchoolRoleScheduleByActivityId.HandleId = 0;
		}

		// Token: 0x06003C95 RID: 15509 RVA: 0x001B3199 File Offset: 0x001B1399
		public static void Init()
		{
			ConfigSolarSchoolRoleScheduleByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleSchedule` where ActivityId=?");
		}

		// Token: 0x06003C96 RID: 15510 RVA: 0x001B31B4 File Offset: 0x001B13B4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleSchedule> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, ConfigSolarSchoolRoleScheduleByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleScheduleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolRoleSchedule> readOnlyList = (IReadOnlyList<SolarSchoolRoleSchedule>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleScheduleByActivityId.LogPair.Clear();
			ConfigSolarSchoolRoleScheduleByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolRoleScheduleByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, ConfigSolarSchoolRoleScheduleByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolRoleSchedule> list = new List<SolarSchoolRoleSchedule>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, false, ConfigSolarSchoolRoleScheduleByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, 0, ConfigSolarSchoolRoleScheduleByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, ConfigSolarSchoolRoleScheduleByActivityId.LogPair);
					return null;
				}
				SolarSchoolRoleSchedule rootAsSolarSchoolRoleSchedule = SolarSchoolRoleSchedule.GetRootAsSolarSchoolRoleSchedule(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleSchedule);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleScheduleByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleByActivityId.HandleId, ConfigSolarSchoolRoleScheduleByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004679 RID: 18041
		private const string DB = "db_solarschool.db";

		// Token: 0x0400467A RID: 18042
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x0400467B RID: 18043
		private const string TABLE = "SolarSchoolRoleSchedule";

		// Token: 0x0400467C RID: 18044
		private const string COMMAND = "select BinData from `SolarSchoolRoleSchedule` where ActivityId=?";

		// Token: 0x0400467D RID: 18045
		private const string KEY_PREFIX = "SolarSchoolRoleScheduleByActivityId";

		// Token: 0x0400467E RID: 18046
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400467F RID: 18047
		private static int HandleId;
	}
}
