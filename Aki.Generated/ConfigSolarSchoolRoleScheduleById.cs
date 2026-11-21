using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A16 RID: 2582
	public class ConfigSolarSchoolRoleScheduleById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C98 RID: 15512 RVA: 0x001B3323 File Offset: 0x001B1523
		static ConfigSolarSchoolRoleScheduleById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleScheduleById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleScheduleById.ResetStaticDefaultValue));
		}

		// Token: 0x06003C99 RID: 15513 RVA: 0x001B3344 File Offset: 0x001B1544
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleScheduleById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleSchedule"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleSchedule` where Id=?")
			});
		}

		// Token: 0x06003C9A RID: 15514 RVA: 0x001B33C3 File Offset: 0x001B15C3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleScheduleById.LogPair = null;
			ConfigSolarSchoolRoleScheduleById.HandleId = 0;
		}

		// Token: 0x06003C9B RID: 15515 RVA: 0x001B33D1 File Offset: 0x001B15D1
		public static void Init()
		{
			ConfigSolarSchoolRoleScheduleById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleScheduleById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleSchedule` where Id=?");
		}

		// Token: 0x06003C9C RID: 15516 RVA: 0x001B33EC File Offset: 0x001B15EC
		public static SolarSchoolRoleSchedule? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleScheduleById.HandleId, ConfigSolarSchoolRoleScheduleById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleScheduleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolRoleSchedule?(SolarSchoolRoleSchedule.GetRootAsSolarSchoolRoleSchedule(configBuffer));
				}
			}
			ConfigSolarSchoolRoleScheduleById.LogPair.Clear();
			ConfigSolarSchoolRoleScheduleById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolRoleScheduleById.HandleId, 1, p0Id, ConfigSolarSchoolRoleScheduleById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolRoleScheduleById.HandleId, true, ConfigSolarSchoolRoleScheduleById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleById.HandleId, ConfigSolarSchoolRoleScheduleById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleScheduleById.HandleId, 0, ConfigSolarSchoolRoleScheduleById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleById.HandleId, ConfigSolarSchoolRoleScheduleById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolRoleSchedule rootAsSolarSchoolRoleSchedule = SolarSchoolRoleSchedule.GetRootAsSolarSchoolRoleSchedule(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolRoleScheduleById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleScheduleById.HandleId, ConfigSolarSchoolRoleScheduleById.LogPair);
			return new SolarSchoolRoleSchedule?(rootAsSolarSchoolRoleSchedule);
		}

		// Token: 0x04004680 RID: 18048
		private const string DB = "db_solarschool.db";

		// Token: 0x04004681 RID: 18049
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004682 RID: 18050
		private const string TABLE = "SolarSchoolRoleSchedule";

		// Token: 0x04004683 RID: 18051
		private const string COMMAND = "select BinData from `SolarSchoolRoleSchedule` where Id=?";

		// Token: 0x04004684 RID: 18052
		private const string KEY_PREFIX = "SolarSchoolRoleScheduleById";

		// Token: 0x04004685 RID: 18053
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004686 RID: 18054
		private static int HandleId;
	}
}
