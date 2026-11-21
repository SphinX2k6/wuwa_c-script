using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C8 RID: 2504
	public class ConfigSolarSchoolDatePeriodById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AC4 RID: 15044 RVA: 0x001A8E8F File Offset: 0x001A708F
		static ConfigSolarSchoolDatePeriodById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolDatePeriodById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolDatePeriodById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AC5 RID: 15045 RVA: 0x001A8EB0 File Offset: 0x001A70B0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolDatePeriodById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolDatePeriodById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolDatePeriod"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolDatePeriod` where Id=?")
			});
		}

		// Token: 0x06003AC6 RID: 15046 RVA: 0x001A8F2F File Offset: 0x001A712F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolDatePeriodById.LogPair = null;
			ConfigSolarSchoolDatePeriodById.HandleId = 0;
		}

		// Token: 0x06003AC7 RID: 15047 RVA: 0x001A8F3D File Offset: 0x001A713D
		public static void Init()
		{
			ConfigSolarSchoolDatePeriodById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolDatePeriodById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolDatePeriod` where Id=?");
		}

		// Token: 0x06003AC8 RID: 15048 RVA: 0x001A8F58 File Offset: 0x001A7158
		public static SolarSchoolDatePeriod? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolDatePeriodById.HandleId, ConfigSolarSchoolDatePeriodById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolDatePeriodById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolDatePeriod?(SolarSchoolDatePeriod.GetRootAsSolarSchoolDatePeriod(configBuffer));
				}
			}
			ConfigSolarSchoolDatePeriodById.LogPair.Clear();
			ConfigSolarSchoolDatePeriodById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolDatePeriodById.HandleId, 1, p0Id, ConfigSolarSchoolDatePeriodById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolDatePeriodById.HandleId, true, ConfigSolarSchoolDatePeriodById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolDatePeriodById.HandleId, ConfigSolarSchoolDatePeriodById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolDatePeriodById.HandleId, 0, ConfigSolarSchoolDatePeriodById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolDatePeriodById.HandleId, ConfigSolarSchoolDatePeriodById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolDatePeriod rootAsSolarSchoolDatePeriod = SolarSchoolDatePeriod.GetRootAsSolarSchoolDatePeriod(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolDatePeriodById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolDatePeriodById.HandleId, ConfigSolarSchoolDatePeriodById.LogPair);
			return new SolarSchoolDatePeriod?(rootAsSolarSchoolDatePeriod);
		}

		// Token: 0x0400445E RID: 17502
		private const string DB = "db_solarschool.db";

		// Token: 0x0400445F RID: 17503
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004460 RID: 17504
		private const string TABLE = "SolarSchoolDatePeriod";

		// Token: 0x04004461 RID: 17505
		private const string COMMAND = "select BinData from `SolarSchoolDatePeriod` where Id=?";

		// Token: 0x04004462 RID: 17506
		private const string KEY_PREFIX = "SolarSchoolDatePeriodById";

		// Token: 0x04004463 RID: 17507
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004464 RID: 17508
		private static int HandleId;
	}
}
