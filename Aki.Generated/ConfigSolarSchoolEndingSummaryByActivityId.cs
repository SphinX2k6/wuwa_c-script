using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009CF RID: 2511
	public class ConfigSolarSchoolEndingSummaryByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AEE RID: 15086 RVA: 0x001A9D00 File Offset: 0x001A7F00
		static ConfigSolarSchoolEndingSummaryByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEndingSummaryByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEndingSummaryByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003AEF RID: 15087 RVA: 0x001A9D20 File Offset: 0x001A7F20
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEndingSummaryByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEndingSummaryByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_局外结局.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEndingSummary"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEndingSummary` where ActivityId=?")
			});
		}

		// Token: 0x06003AF0 RID: 15088 RVA: 0x001A9D9F File Offset: 0x001A7F9F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEndingSummaryByActivityId.LogPair = null;
			ConfigSolarSchoolEndingSummaryByActivityId.HandleId = 0;
		}

		// Token: 0x06003AF1 RID: 15089 RVA: 0x001A9DAD File Offset: 0x001A7FAD
		public static void Init()
		{
			ConfigSolarSchoolEndingSummaryByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEndingSummary` where ActivityId=?");
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x001A9DC8 File Offset: 0x001A7FC8
		public static SolarSchoolEndingSummary? GetConfig(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, ConfigSolarSchoolEndingSummaryByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingSummaryByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new SolarSchoolEndingSummary?(SolarSchoolEndingSummary.GetRootAsSolarSchoolEndingSummary(configBuffer));
				}
			}
			ConfigSolarSchoolEndingSummaryByActivityId.LogPair.Clear();
			ConfigSolarSchoolEndingSummaryByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolEndingSummaryByActivityId.LogPair) || ConfigCommon.Step(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, true, ConfigSolarSchoolEndingSummaryByActivityId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, ConfigSolarSchoolEndingSummaryByActivityId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, 0, ConfigSolarSchoolEndingSummaryByActivityId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, ConfigSolarSchoolEndingSummaryByActivityId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			SolarSchoolEndingSummary rootAsSolarSchoolEndingSummary = SolarSchoolEndingSummary.GetRootAsSolarSchoolEndingSummary(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolEndingSummaryByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEndingSummaryByActivityId.HandleId, ConfigSolarSchoolEndingSummaryByActivityId.LogPair);
			return new SolarSchoolEndingSummary?(rootAsSolarSchoolEndingSummary);
		}

		// Token: 0x0400448F RID: 17551
		private const string DB = "db_solarschool.db";

		// Token: 0x04004490 RID: 17552
		private const string FILE = "d.第二索拉_局外结局.xlsx";

		// Token: 0x04004491 RID: 17553
		private const string TABLE = "SolarSchoolEndingSummary";

		// Token: 0x04004492 RID: 17554
		private const string COMMAND = "select BinData from `SolarSchoolEndingSummary` where ActivityId=?";

		// Token: 0x04004493 RID: 17555
		private const string KEY_PREFIX = "SolarSchoolEndingSummaryByActivityId";

		// Token: 0x04004494 RID: 17556
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004495 RID: 17557
		private static int HandleId;
	}
}
