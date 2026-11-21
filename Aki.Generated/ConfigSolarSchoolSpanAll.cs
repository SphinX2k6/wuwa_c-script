using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A29 RID: 2601
	public class ConfigSolarSchoolSpanAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D0A RID: 15626 RVA: 0x001B5AD5 File Offset: 0x001B3CD5
		static ConfigSolarSchoolSpanAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolSpanAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolSpanAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003D0B RID: 15627 RVA: 0x001B5AF4 File Offset: 0x001B3CF4
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolSpanAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolSpanAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_主表.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolSpan"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolSpan`")
			});
		}

		// Token: 0x06003D0C RID: 15628 RVA: 0x001B5B73 File Offset: 0x001B3D73
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolSpanAll.LogPair = null;
			ConfigSolarSchoolSpanAll.HandleId = 0;
		}

		// Token: 0x06003D0D RID: 15629 RVA: 0x001B5B81 File Offset: 0x001B3D81
		public static void Init()
		{
			ConfigSolarSchoolSpanAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolSpanAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolSpan`");
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x001B5B9C File Offset: 0x001B3D9C
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolSpan> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolSpanAll.HandleId, ConfigSolarSchoolSpanAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolSpan> readOnlyList = (IReadOnlyList<SolarSchoolSpan>)ConfigCommon.GetConfig("SolarSchoolSpanAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolSpan> list = new List<SolarSchoolSpan>();
			while (ConfigCommon.Step(ConfigSolarSchoolSpanAll.HandleId, false, ConfigSolarSchoolSpanAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolSpanAll.HandleId, 0, ConfigSolarSchoolSpanAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolSpanAll.HandleId, ConfigSolarSchoolSpanAll.LogPair);
					return null;
				}
				SolarSchoolSpan rootAsSolarSchoolSpan = SolarSchoolSpan.GetRootAsSolarSchoolSpan(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolSpan);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolSpanAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolSpanAll.HandleId, ConfigSolarSchoolSpanAll.LogPair);
			return list;
		}

		// Token: 0x04004705 RID: 18181
		private const string DB = "db_solarschool.db";

		// Token: 0x04004706 RID: 18182
		private const string FILE = "d.第二索拉_主表.xlsx";

		// Token: 0x04004707 RID: 18183
		private const string TABLE = "SolarSchoolSpan";

		// Token: 0x04004708 RID: 18184
		private const string COMMAND = "select BinData from `SolarSchoolSpan`";

		// Token: 0x04004709 RID: 18185
		private const string KEY_PREFIX = "SolarSchoolSpanAll";

		// Token: 0x0400470A RID: 18186
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400470B RID: 18187
		private static int HandleId;
	}
}
