using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C4 RID: 2500
	public class ConfigSolarSchoolCalendarById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AAC RID: 15020 RVA: 0x001A8643 File Offset: 0x001A6843
		static ConfigSolarSchoolCalendarById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolCalendarById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolCalendarById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AAD RID: 15021 RVA: 0x001A8664 File Offset: 0x001A6864
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolCalendarById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolCalendar"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolCalendar` where Id=?")
			});
		}

		// Token: 0x06003AAE RID: 15022 RVA: 0x001A86E3 File Offset: 0x001A68E3
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolCalendarById.LogPair = null;
			ConfigSolarSchoolCalendarById.HandleId = 0;
		}

		// Token: 0x06003AAF RID: 15023 RVA: 0x001A86F1 File Offset: 0x001A68F1
		public static void Init()
		{
			ConfigSolarSchoolCalendarById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolCalendarById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolCalendar` where Id=?");
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x001A870C File Offset: 0x001A690C
		public static SolarSchoolCalendar? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolCalendarById.HandleId, ConfigSolarSchoolCalendarById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolCalendar?(SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(configBuffer));
				}
			}
			ConfigSolarSchoolCalendarById.LogPair.Clear();
			ConfigSolarSchoolCalendarById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolCalendarById.HandleId, 1, p0Id, ConfigSolarSchoolCalendarById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolCalendarById.HandleId, true, ConfigSolarSchoolCalendarById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolCalendarById.HandleId, ConfigSolarSchoolCalendarById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolCalendarById.HandleId, 0, ConfigSolarSchoolCalendarById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolCalendarById.HandleId, ConfigSolarSchoolCalendarById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolCalendar rootAsSolarSchoolCalendar = SolarSchoolCalendar.GetRootAsSolarSchoolCalendar(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolCalendarById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolCalendarById.HandleId, ConfigSolarSchoolCalendarById.LogPair);
			return new SolarSchoolCalendar?(rootAsSolarSchoolCalendar);
		}

		// Token: 0x04004442 RID: 17474
		private const string DB = "db_solarschool.db";

		// Token: 0x04004443 RID: 17475
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004444 RID: 17476
		private const string TABLE = "SolarSchoolCalendar";

		// Token: 0x04004445 RID: 17477
		private const string COMMAND = "select BinData from `SolarSchoolCalendar` where Id=?";

		// Token: 0x04004446 RID: 17478
		private const string KEY_PREFIX = "SolarSchoolCalendarById";

		// Token: 0x04004447 RID: 17479
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004448 RID: 17480
		private static int HandleId;
	}
}
