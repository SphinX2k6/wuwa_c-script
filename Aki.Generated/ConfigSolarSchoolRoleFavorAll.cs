using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0E RID: 2574
	public class ConfigSolarSchoolRoleFavorAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C68 RID: 15464 RVA: 0x001B22EC File Offset: 0x001B04EC
		static ConfigSolarSchoolRoleFavorAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleFavorAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleFavorAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C69 RID: 15465 RVA: 0x001B230C File Offset: 0x001B050C
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleFavorAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRoleFavor"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRoleFavor`")
			});
		}

		// Token: 0x06003C6A RID: 15466 RVA: 0x001B238B File Offset: 0x001B058B
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleFavorAll.LogPair = null;
			ConfigSolarSchoolRoleFavorAll.HandleId = 0;
		}

		// Token: 0x06003C6B RID: 15467 RVA: 0x001B2399 File Offset: 0x001B0599
		public static void Init()
		{
			ConfigSolarSchoolRoleFavorAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleFavorAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRoleFavor`");
		}

		// Token: 0x06003C6C RID: 15468 RVA: 0x001B23B4 File Offset: 0x001B05B4
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRoleFavor> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleFavorAll.HandleId, ConfigSolarSchoolRoleFavorAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolRoleFavor> readOnlyList = (IReadOnlyList<SolarSchoolRoleFavor>)ConfigCommon.GetConfig("SolarSchoolRoleFavorAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolRoleFavor> list = new List<SolarSchoolRoleFavor>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleFavorAll.HandleId, false, ConfigSolarSchoolRoleFavorAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleFavorAll.HandleId, 0, ConfigSolarSchoolRoleFavorAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleFavorAll.HandleId, ConfigSolarSchoolRoleFavorAll.LogPair);
					return null;
				}
				SolarSchoolRoleFavor rootAsSolarSchoolRoleFavor = SolarSchoolRoleFavor.GetRootAsSolarSchoolRoleFavor(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRoleFavor);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRoleFavorAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleFavorAll.HandleId, ConfigSolarSchoolRoleFavorAll.LogPair);
			return list;
		}

		// Token: 0x04004648 RID: 17992
		private const string DB = "db_solarschool.db";

		// Token: 0x04004649 RID: 17993
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x0400464A RID: 17994
		private const string TABLE = "SolarSchoolRoleFavor";

		// Token: 0x0400464B RID: 17995
		private const string COMMAND = "select BinData from `SolarSchoolRoleFavor`";

		// Token: 0x0400464C RID: 17996
		private const string KEY_PREFIX = "SolarSchoolRoleFavorAll";

		// Token: 0x0400464D RID: 17997
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400464E RID: 17998
		private static int HandleId;
	}
}
