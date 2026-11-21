using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A1F RID: 2591
	public class ConfigSolarSchoolScratchTicketReAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CCE RID: 15566 RVA: 0x001B46C0 File Offset: 0x001B28C0
		static ConfigSolarSchoolScratchTicketReAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolScratchTicketReAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolScratchTicketReAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CCF RID: 15567 RVA: 0x001B46E0 File Offset: 0x001B28E0
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketReAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolScratchTicketReAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_玩法.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolScratchTicketRe"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolScratchTicketRe`")
			});
		}

		// Token: 0x06003CD0 RID: 15568 RVA: 0x001B475F File Offset: 0x001B295F
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolScratchTicketReAll.LogPair = null;
			ConfigSolarSchoolScratchTicketReAll.HandleId = 0;
		}

		// Token: 0x06003CD1 RID: 15569 RVA: 0x001B476D File Offset: 0x001B296D
		public static void Init()
		{
			ConfigSolarSchoolScratchTicketReAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolScratchTicketReAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolScratchTicketRe`");
		}

		// Token: 0x06003CD2 RID: 15570 RVA: 0x001B4788 File Offset: 0x001B2988
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolScratchTicketRe> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolScratchTicketReAll.HandleId, ConfigSolarSchoolScratchTicketReAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolScratchTicketRe> readOnlyList = (IReadOnlyList<SolarSchoolScratchTicketRe>)ConfigCommon.GetConfig("SolarSchoolScratchTicketReAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolScratchTicketRe> list = new List<SolarSchoolScratchTicketRe>();
			while (ConfigCommon.Step(ConfigSolarSchoolScratchTicketReAll.HandleId, false, ConfigSolarSchoolScratchTicketReAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolScratchTicketReAll.HandleId, 0, ConfigSolarSchoolScratchTicketReAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolScratchTicketReAll.HandleId, ConfigSolarSchoolScratchTicketReAll.LogPair);
					return null;
				}
				SolarSchoolScratchTicketRe rootAsSolarSchoolScratchTicketRe = SolarSchoolScratchTicketRe.GetRootAsSolarSchoolScratchTicketRe(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolScratchTicketRe);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolScratchTicketReAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolScratchTicketReAll.HandleId, ConfigSolarSchoolScratchTicketReAll.LogPair);
			return list;
		}

		// Token: 0x040046BF RID: 18111
		private const string DB = "db_solarschool.db";

		// Token: 0x040046C0 RID: 18112
		private const string FILE = "d.第二索拉_玩法.xlsx";

		// Token: 0x040046C1 RID: 18113
		private const string TABLE = "SolarSchoolScratchTicketRe";

		// Token: 0x040046C2 RID: 18114
		private const string COMMAND = "select BinData from `SolarSchoolScratchTicketRe`";

		// Token: 0x040046C3 RID: 18115
		private const string KEY_PREFIX = "SolarSchoolScratchTicketReAll";

		// Token: 0x040046C4 RID: 18116
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040046C5 RID: 18117
		private static int HandleId;
	}
}
