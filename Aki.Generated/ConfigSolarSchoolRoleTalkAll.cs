using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A19 RID: 2585
	public class ConfigSolarSchoolRoleTalkAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003CAA RID: 15530 RVA: 0x001B39EC File Offset: 0x001B1BEC
		static ConfigSolarSchoolRoleTalkAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleTalkAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleTalkAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003CAB RID: 15531 RVA: 0x001B3A0C File Offset: 0x001B1C0C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleTalkAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleTalk"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleTalk`")
			});
		}

		// Token: 0x06003CAC RID: 15532 RVA: 0x001B3A8B File Offset: 0x001B1C8B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleTalkAll.LogPair = null;
			ConfigSolarSchoolRoleTalkAll.HandleId = 0;
		}

		// Token: 0x06003CAD RID: 15533 RVA: 0x001B3A99 File Offset: 0x001B1C99
		public static void Init()
		{
			ConfigSolarSchoolRoleTalkAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleTalkAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleTalk`");
		}

		// Token: 0x06003CAE RID: 15534 RVA: 0x001B3AB4 File Offset: 0x001B1CB4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleTalk> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleTalkAll.HandleId, ConfigSolarSchoolRoleTalkAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolRoleTalk> readOnlyList = (IReadOnlyList<SolarSchoolRoleTalk>)ConfigCommon.GetConfig("SolarSchoolRoleTalkAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolRoleTalk> list = new List<SolarSchoolRoleTalk>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleTalkAll.HandleId, false, ConfigSolarSchoolRoleTalkAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleTalkAll.HandleId, 0, ConfigSolarSchoolRoleTalkAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleTalkAll.HandleId, ConfigSolarSchoolRoleTalkAll.LogPair);
					return null;
				}
				SolarSchoolRoleTalk rootAsSolarSchoolRoleTalk = SolarSchoolRoleTalk.GetRootAsSolarSchoolRoleTalk(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleTalk);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRoleTalkAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleTalkAll.HandleId, ConfigSolarSchoolRoleTalkAll.LogPair);
			return list;
		}

		// Token: 0x04004695 RID: 18069
		private const string DB = "db_solarschool.db";

		// Token: 0x04004696 RID: 18070
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004697 RID: 18071
		private const string TABLE = "SolarSchoolRoleTalk";

		// Token: 0x04004698 RID: 18072
		private const string COMMAND = "select BinData from `SolarSchoolRoleTalk`";

		// Token: 0x04004699 RID: 18073
		private const string KEY_PREFIX = "SolarSchoolRoleTalkAll";

		// Token: 0x0400469A RID: 18074
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400469B RID: 18075
		private static int HandleId;
	}
}
