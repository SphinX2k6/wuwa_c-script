using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A17 RID: 2583
	public class ConfigSolarSchoolRoleScheduleByRoleId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C9E RID: 15518 RVA: 0x001B356C File Offset: 0x001B176C
		static ConfigSolarSchoolRoleScheduleByRoleId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleScheduleByRoleId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleScheduleByRoleId.ResetStaticDefaultValue));
		}

		// Token: 0x06003C9F RID: 15519 RVA: 0x001B358C File Offset: 0x001B178C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleByRoleId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleScheduleByRoleId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleSchedule"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleSchedule` where RoleId=?")
			});
		}

		// Token: 0x06003CA0 RID: 15520 RVA: 0x001B360B File Offset: 0x001B180B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleByRoleId.LogPair = null;
			ConfigSolarSchoolRoleScheduleByRoleId.HandleId = 0;
		}

		// Token: 0x06003CA1 RID: 15521 RVA: 0x001B3619 File Offset: 0x001B1819
		public static void Init()
		{
			ConfigSolarSchoolRoleScheduleByRoleId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleSchedule` where RoleId=?");
		}

		// Token: 0x06003CA2 RID: 15522 RVA: 0x001B3634 File Offset: 0x001B1834
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleSchedule> GetConfigList(int p0RoleId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, ConfigSolarSchoolRoleScheduleByRoleId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleScheduleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				IReadOnlyList<SolarSchoolRoleSchedule> readOnlyList = (IReadOnlyList<SolarSchoolRoleSchedule>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolRoleScheduleByRoleId.LogPair.Clear();
			ConfigSolarSchoolRoleScheduleByRoleId.LogPair.Add(new ValueTuple<string, object>("RoleId", p0RoleId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, 1, p0RoleId, ConfigSolarSchoolRoleScheduleByRoleId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, ConfigSolarSchoolRoleScheduleByRoleId.LogPair);
				return null;
			}
			List<SolarSchoolRoleSchedule> list = new List<SolarSchoolRoleSchedule>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, false, ConfigSolarSchoolRoleScheduleByRoleId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, 0, ConfigSolarSchoolRoleScheduleByRoleId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, ConfigSolarSchoolRoleScheduleByRoleId.LogPair);
					return null;
				}
				SolarSchoolRoleSchedule rootAsSolarSchoolRoleSchedule = SolarSchoolRoleSchedule.GetRootAsSolarSchoolRoleSchedule(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleSchedule);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleScheduleByRoleId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0RoleId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleByRoleId.HandleId, ConfigSolarSchoolRoleScheduleByRoleId.LogPair);
			return list;
		}

		// Token: 0x04004687 RID: 18055
		private const string DB = "db_solarschool.db";

		// Token: 0x04004688 RID: 18056
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004689 RID: 18057
		private const string TABLE = "SolarSchoolRoleSchedule";

		// Token: 0x0400468A RID: 18058
		private const string COMMAND = "select BinData from `SolarSchoolRoleSchedule` where RoleId=?";

		// Token: 0x0400468B RID: 18059
		private const string KEY_PREFIX = "SolarSchoolRoleScheduleByRoleId";

		// Token: 0x0400468C RID: 18060
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400468D RID: 18061
		private static int HandleId;
	}
}
