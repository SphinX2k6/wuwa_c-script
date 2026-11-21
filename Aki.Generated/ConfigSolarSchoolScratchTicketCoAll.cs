using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1D RID: 2589
	public class ConfigSolarSchoolScratchTicketCoAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CC2 RID: 15554 RVA: 0x001B42E4 File Offset: 0x001B24E4
		static ConfigSolarSchoolScratchTicketCoAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolScratchTicketCoAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolScratchTicketCoAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CC3 RID: 15555 RVA: 0x001B4304 File Offset: 0x001B2504
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketCoAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolScratchTicketCoAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolScratchTicketCo"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolScratchTicketCo`")
			});
		}

		// Token: 0x06003CC4 RID: 15556 RVA: 0x001B4383 File Offset: 0x001B2583
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketCoAll.LogPair = null;
			ConfigSolarSchoolScratchTicketCoAll.HandleId = 0;
		}

		// Token: 0x06003CC5 RID: 15557 RVA: 0x001B4391 File Offset: 0x001B2591
		public static void Init()
		{
			ConfigSolarSchoolScratchTicketCoAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolScratchTicketCoAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolScratchTicketCo`");
		}

		// Token: 0x06003CC6 RID: 15558 RVA: 0x001B43AC File Offset: 0x001B25AC
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolScratchTicketCo> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolScratchTicketCoAll.HandleId, ConfigSolarSchoolScratchTicketCoAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolScratchTicketCo> readOnlyList = (IReadOnlyList<SolarSchoolScratchTicketCo>)ConfigCommon.GetConfig("SolarSchoolScratchTicketCoAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolScratchTicketCo> list = new List<SolarSchoolScratchTicketCo>();
			while (ConfigCommon.Step(ConfigSolarSchoolScratchTicketCoAll.HandleId, false, ConfigSolarSchoolScratchTicketCoAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolScratchTicketCoAll.HandleId, 0, ConfigSolarSchoolScratchTicketCoAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolScratchTicketCoAll.HandleId, ConfigSolarSchoolScratchTicketCoAll.LogPair);
					return null;
				}
				SolarSchoolScratchTicketCo rootAsSolarSchoolScratchTicketCo = SolarSchoolScratchTicketCo.GetRootAsSolarSchoolScratchTicketCo(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolScratchTicketCo);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolScratchTicketCoAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolScratchTicketCoAll.HandleId, ConfigSolarSchoolScratchTicketCoAll.LogPair);
			return list;
		}

		// Token: 0x040046B1 RID: 18097
		private const string DB = "db_solarschool.db";

		// Token: 0x040046B2 RID: 18098
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040046B3 RID: 18099
		private const string TABLE = "SolarSchoolScratchTicketCo";

		// Token: 0x040046B4 RID: 18100
		private const string COMMAND = "select BinData from `SolarSchoolScratchTicketCo`";

		// Token: 0x040046B5 RID: 18101
		private const string KEY_PREFIX = "SolarSchoolScratchTicketCoAll";

		// Token: 0x040046B6 RID: 18102
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046B7 RID: 18103
		private static int HandleId;
	}
}
