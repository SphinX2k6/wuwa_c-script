using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009C6 RID: 2502
	public class ConfigSolarSchoolDatePeriodAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003AB8 RID: 15032 RVA: 0x001A8AC3 File Offset: 0x001A6CC3
		static ConfigSolarSchoolDatePeriodAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolDatePeriodAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolDatePeriodAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003AB9 RID: 15033 RVA: 0x001A8AE4 File Offset: 0x001A6CE4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolDatePeriodAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolDatePeriodAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolDatePeriod"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolDatePeriod`")
			});
		}

		// Token: 0x06003ABA RID: 15034 RVA: 0x001A8B63 File Offset: 0x001A6D63
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolDatePeriodAll.LogPair = null;
			ConfigSolarSchoolDatePeriodAll.HandleId = 0;
		}

		// Token: 0x06003ABB RID: 15035 RVA: 0x001A8B71 File Offset: 0x001A6D71
		public static void Init()
		{
			ConfigSolarSchoolDatePeriodAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolDatePeriodAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolDatePeriod`");
		}

		// Token: 0x06003ABC RID: 15036 RVA: 0x001A8B8C File Offset: 0x001A6D8C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolDatePeriod> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolDatePeriodAll.HandleId, ConfigSolarSchoolDatePeriodAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolDatePeriod> readOnlyList = (IReadOnlyList<SolarSchoolDatePeriod>)ConfigCommon.GetConfig("SolarSchoolDatePeriodAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolDatePeriod> list = new List<SolarSchoolDatePeriod>();
			while (ConfigCommon.Step(ConfigSolarSchoolDatePeriodAll.HandleId, false, ConfigSolarSchoolDatePeriodAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolDatePeriodAll.HandleId, 0, ConfigSolarSchoolDatePeriodAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolDatePeriodAll.HandleId, ConfigSolarSchoolDatePeriodAll.LogPair);
					return null;
				}
				SolarSchoolDatePeriod rootAsSolarSchoolDatePeriod = SolarSchoolDatePeriod.GetRootAsSolarSchoolDatePeriod(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolDatePeriod);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolDatePeriodAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolDatePeriodAll.HandleId, ConfigSolarSchoolDatePeriodAll.LogPair);
			return list;
		}

		// Token: 0x04004450 RID: 17488
		private const string DB = "db_solarschool.db";

		// Token: 0x04004451 RID: 17489
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004452 RID: 17490
		private const string TABLE = "SolarSchoolDatePeriod";

		// Token: 0x04004453 RID: 17491
		private const string COMMAND = "select BinData from `SolarSchoolDatePeriod`";

		// Token: 0x04004454 RID: 17492
		private const string KEY_PREFIX = "SolarSchoolDatePeriodAll";

		// Token: 0x04004455 RID: 17493
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004456 RID: 17494
		private static int HandleId;
	}
}
