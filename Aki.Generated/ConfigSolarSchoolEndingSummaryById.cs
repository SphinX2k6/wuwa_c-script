using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D0 RID: 2512
	public class ConfigSolarSchoolEndingSummaryById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AF4 RID: 15092 RVA: 0x001A9F48 File Offset: 0x001A8148
		static ConfigSolarSchoolEndingSummaryById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingSummaryById.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingSummaryById.ResetStaticDefaultValue));
		}

		// Token: 0x06003AF5 RID: 15093 RVA: 0x001A9F68 File Offset: 0x001A8168
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingSummaryById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingSummaryById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEndingSummary"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEndingSummary` where Id=?")
			});
		}

		// Token: 0x06003AF6 RID: 15094 RVA: 0x001A9FE7 File Offset: 0x001A81E7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingSummaryById.LogPair = null;
			ConfigSolarSchoolEndingSummaryById.HandleId = 0;
		}

		// Token: 0x06003AF7 RID: 15095 RVA: 0x001A9FF5 File Offset: 0x001A81F5
		public static void Init()
		{
			ConfigSolarSchoolEndingSummaryById.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingSummaryById.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEndingSummary` where Id=?");
		}

		// Token: 0x06003AF8 RID: 15096 RVA: 0x001AA010 File Offset: 0x001A8210
		public static SolarSchoolEndingSummary? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingSummaryById.HandleId, ConfigSolarSchoolEndingSummaryById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingSummaryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEndingSummary?(SolarSchoolEndingSummary.GetRootAsSolarSchoolEndingSummary(configBuffer));
				}
			}
			ConfigSolarSchoolEndingSummaryById.LogPair.Clear();
			ConfigSolarSchoolEndingSummaryById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEndingSummaryById.HandleId, 1, p0Id, ConfigSolarSchoolEndingSummaryById.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEndingSummaryById.HandleId, true, ConfigSolarSchoolEndingSummaryById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingSummaryById.HandleId, ConfigSolarSchoolEndingSummaryById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingSummaryById.HandleId, 0, ConfigSolarSchoolEndingSummaryById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingSummaryById.HandleId, ConfigSolarSchoolEndingSummaryById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEndingSummary rootAsSolarSchoolEndingSummary = SolarSchoolEndingSummary.GetRootAsSolarSchoolEndingSummary(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingSummaryById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingSummaryById.HandleId, ConfigSolarSchoolEndingSummaryById.LogPair);
			return new SolarSchoolEndingSummary?(rootAsSolarSchoolEndingSummary);
		}

		// Token: 0x04004496 RID: 17558
		private const string DB = "db_solarschool.db";

		// Token: 0x04004497 RID: 17559
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004498 RID: 17560
		private const string TABLE = "SolarSchoolEndingSummary";

		// Token: 0x04004499 RID: 17561
		private const string COMMAND = "select BinData from `SolarSchoolEndingSummary` where Id=?";

		// Token: 0x0400449A RID: 17562
		private const string KEY_PREFIX = "SolarSchoolEndingSummaryById";

		// Token: 0x0400449B RID: 17563
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400449C RID: 17564
		private static int HandleId;
	}
}
