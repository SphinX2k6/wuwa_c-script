using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020009D4 RID: 2516
	public class ConfigSolarSchoolEventProbabilityAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003B0C RID: 15116 RVA: 0x001AA858 File Offset: 0x001A8A58
		static ConfigSolarSchoolEventProbabilityAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolEventProbabilityAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolEventProbabilityAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003B0D RID: 15117 RVA: 0x001AA878 File Offset: 0x001A8A78
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolEventProbabilityAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolEventProbabilityAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolEventProbability"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolEventProbability`")
			});
		}

		// Token: 0x06003B0E RID: 15118 RVA: 0x001AA8F7 File Offset: 0x001A8AF7
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolEventProbabilityAll.LogPair = null;
			ConfigSolarSchoolEventProbabilityAll.HandleId = 0;
		}

		// Token: 0x06003B0F RID: 15119 RVA: 0x001AA905 File Offset: 0x001A8B05
		public static void Init()
		{
			ConfigSolarSchoolEventProbabilityAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolEventProbabilityAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolEventProbability`");
		}

		// Token: 0x06003B10 RID: 15120 RVA: 0x001AA920 File Offset: 0x001A8B20
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolEventProbability> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolEventProbabilityAll.HandleId, ConfigSolarSchoolEventProbabilityAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolEventProbability> readOnlyList = (IReadOnlyList<SolarSchoolEventProbability>)ConfigCommon.GetConfig("SolarSchoolEventProbabilityAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolEventProbability> list = new List<SolarSchoolEventProbability>();
			while (ConfigCommon.Step(ConfigSolarSchoolEventProbabilityAll.HandleId, false, ConfigSolarSchoolEventProbabilityAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolEventProbabilityAll.HandleId, 0, ConfigSolarSchoolEventProbabilityAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolEventProbabilityAll.HandleId, ConfigSolarSchoolEventProbabilityAll.LogPair);
					return null;
				}
				SolarSchoolEventProbability rootAsSolarSchoolEventProbability = SolarSchoolEventProbability.GetRootAsSolarSchoolEventProbability(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolEventProbability);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolEventProbabilityAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolEventProbabilityAll.HandleId, ConfigSolarSchoolEventProbabilityAll.LogPair);
			return list;
		}

		// Token: 0x040044B2 RID: 17586
		private const string DB = "db_solarschool.db";

		// Token: 0x040044B3 RID: 17587
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040044B4 RID: 17588
		private const string TABLE = "SolarSchoolEventProbability";

		// Token: 0x040044B5 RID: 17589
		private const string COMMAND = "select BinData from `SolarSchoolEventProbability`";

		// Token: 0x040044B6 RID: 17590
		private const string KEY_PREFIX = "SolarSchoolEventProbabilityAll";

		// Token: 0x040044B7 RID: 17591
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040044B8 RID: 17592
		private static int HandleId;
	}
}
