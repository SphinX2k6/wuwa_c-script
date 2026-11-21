using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A10 RID: 2576
	public class ConfigSolarSchoolRoleFavorLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C74 RID: 15476 RVA: 0x001B26B7 File Offset: 0x001B08B7
		static ConfigSolarSchoolRoleFavorLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleFavorLevelAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleFavorLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C75 RID: 15477 RVA: 0x001B26D8 File Offset: 0x001B08D8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleFavorLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleFavorLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleFavorLevel`")
			});
		}

		// Token: 0x06003C76 RID: 15478 RVA: 0x001B2757 File Offset: 0x001B0957
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorLevelAll.LogPair = null;
			ConfigSolarSchoolRoleFavorLevelAll.HandleId = 0;
		}

		// Token: 0x06003C77 RID: 15479 RVA: 0x001B2765 File Offset: 0x001B0965
		public static void Init()
		{
			ConfigSolarSchoolRoleFavorLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleFavorLevelAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleFavorLevel`");
		}

		// Token: 0x06003C78 RID: 15480 RVA: 0x001B2780 File Offset: 0x001B0980
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleFavorLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleFavorLevelAll.HandleId, ConfigSolarSchoolRoleFavorLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolRoleFavorLevel> readOnlyList = (IReadOnlyList<SolarSchoolRoleFavorLevel>)ConfigCommon.GetConfig("SolarSchoolRoleFavorLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolRoleFavorLevel> list = new List<SolarSchoolRoleFavorLevel>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleFavorLevelAll.HandleId, false, ConfigSolarSchoolRoleFavorLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleFavorLevelAll.HandleId, 0, ConfigSolarSchoolRoleFavorLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelAll.HandleId, ConfigSolarSchoolRoleFavorLevelAll.LogPair);
					return null;
				}
				SolarSchoolRoleFavorLevel rootAsSolarSchoolRoleFavorLevel = SolarSchoolRoleFavorLevel.GetRootAsSolarSchoolRoleFavorLevel(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleFavorLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRoleFavorLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleFavorLevelAll.HandleId, ConfigSolarSchoolRoleFavorLevelAll.LogPair);
			return list;
		}

		// Token: 0x04004656 RID: 18006
		private const string DB = "db_solarschool.db";

		// Token: 0x04004657 RID: 18007
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004658 RID: 18008
		private const string TABLE = "SolarSchoolRoleFavorLevel";

		// Token: 0x04004659 RID: 18009
		private const string COMMAND = "select BinData from `SolarSchoolRoleFavorLevel`";

		// Token: 0x0400465A RID: 18010
		private const string KEY_PREFIX = "SolarSchoolRoleFavorLevelAll";

		// Token: 0x0400465B RID: 18011
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400465C RID: 18012
		private static int HandleId;
	}
}
