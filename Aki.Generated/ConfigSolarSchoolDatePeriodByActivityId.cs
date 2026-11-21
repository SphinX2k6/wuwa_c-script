using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C7 RID: 2503
	public class ConfigSolarSchoolDatePeriodByActivityId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003ABE RID: 15038 RVA: 0x001A8C57 File Offset: 0x001A6E57
		static ConfigSolarSchoolDatePeriodByActivityId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolDatePeriodByActivityId.CreateStaticDefaultValue), new Action(ConfigSolarSchoolDatePeriodByActivityId.ResetStaticDefaultValue));
		}

		// Token: 0x06003ABF RID: 15039 RVA: 0x001A8C78 File Offset: 0x001A6E78
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolDatePeriodByActivityId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolDatePeriodByActivityId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolDatePeriod"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolDatePeriod` where ActivityId=?")
			});
		}

		// Token: 0x06003AC0 RID: 15040 RVA: 0x001A8CF7 File Offset: 0x001A6EF7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolDatePeriodByActivityId.LogPair = null;
			ConfigSolarSchoolDatePeriodByActivityId.HandleId = 0;
		}

		// Token: 0x06003AC1 RID: 15041 RVA: 0x001A8D05 File Offset: 0x001A6F05
		public static void Init()
		{
			ConfigSolarSchoolDatePeriodByActivityId.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolDatePeriodByActivityId.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolDatePeriod` where ActivityId=?");
		}

		// Token: 0x06003AC2 RID: 15042 RVA: 0x001A8D20 File Offset: 0x001A6F20
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolDatePeriod> GetConfigList(int p0ActivityId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolDatePeriodByActivityId.HandleId, ConfigSolarSchoolDatePeriodByActivityId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolDatePeriodByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				IReadOnlyList<SolarSchoolDatePeriod> readOnlyList = (IReadOnlyList<SolarSchoolDatePeriod>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigSolarSchoolDatePeriodByActivityId.LogPair.Clear();
			ConfigSolarSchoolDatePeriodByActivityId.LogPair.Add(new ValueTuple<string, object>("ActivityId", p0ActivityId));
			if (!ConfigCommon.BindInt(ConfigSolarSchoolDatePeriodByActivityId.HandleId, 1, p0ActivityId, ConfigSolarSchoolDatePeriodByActivityId.LogPair))
			{
				ConfigCommon.Reset(ConfigSolarSchoolDatePeriodByActivityId.HandleId, ConfigSolarSchoolDatePeriodByActivityId.LogPair);
				return null;
			}
			List<SolarSchoolDatePeriod> list = new List<SolarSchoolDatePeriod>();
			while (ConfigCommon.Step(ConfigSolarSchoolDatePeriodByActivityId.HandleId, false, ConfigSolarSchoolDatePeriodByActivityId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolDatePeriodByActivityId.HandleId, 0, ConfigSolarSchoolDatePeriodByActivityId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolDatePeriodByActivityId.HandleId, ConfigSolarSchoolDatePeriodByActivityId.LogPair);
					return null;
				}
				SolarSchoolDatePeriod rootAsSolarSchoolDatePeriod = SolarSchoolDatePeriod.GetRootAsSolarSchoolDatePeriod(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolDatePeriod);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("SolarSchoolDatePeriodByActivityId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0ActivityId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolDatePeriodByActivityId.HandleId, ConfigSolarSchoolDatePeriodByActivityId.LogPair);
			return list;
		}

		// Token: 0x04004457 RID: 17495
		private const string DB = "db_solarschool.db";

		// Token: 0x04004458 RID: 17496
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004459 RID: 17497
		private const string TABLE = "SolarSchoolDatePeriod";

		// Token: 0x0400445A RID: 17498
		private const string COMMAND = "select BinData from `SolarSchoolDatePeriod` where ActivityId=?";

		// Token: 0x0400445B RID: 17499
		private const string KEY_PREFIX = "SolarSchoolDatePeriodByActivityId";

		// Token: 0x0400445C RID: 17500
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400445D RID: 17501
		private static int HandleId;
	}
}
