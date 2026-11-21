using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A0B RID: 2571
	public class ConfigSolarSchoolRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003C56 RID: 15446 RVA: 0x001B1CD8 File Offset: 0x001AFED8
		static ConfigSolarSchoolRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSolarSchoolRoleAll.CreateStaticDefaultValue), new Action(ConfigSolarSchoolRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003C57 RID: 15447 RVA: 0x001B1CF8 File Offset: 0x001AFEF8
		public static void CreateStaticDefaultValue()
		{
			ConfigSolarSchoolRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSolarSchoolRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_solarschool.db"),
				new ValueTuple<string, object>("文件", "d.第二索拉_角色.xlsx"),
				new ValueTuple<string, object>("表名", "SolarSchoolRole"),
				new ValueTuple<string, object>("语句", "select BinData from `SolarSchoolRole`")
			});
		}

		// Token: 0x06003C58 RID: 15448 RVA: 0x001B1D77 File Offset: 0x001AFF77
		public static void ResetStaticDefaultValue()
		{
			ConfigSolarSchoolRoleAll.LogPair = null;
			ConfigSolarSchoolRoleAll.HandleId = 0;
		}

		// Token: 0x06003C59 RID: 15449 RVA: 0x001B1D85 File Offset: 0x001AFF85
		public static void Init()
		{
			ConfigSolarSchoolRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigSolarSchoolRoleAll.HandleId, "db_solarschool.db", "select BinData from `SolarSchoolRole`");
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x001B1DA0 File Offset: 0x001AFFA0
		[NullableContext(2)]
		public static IReadOnlyList<SolarSchoolRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigSolarSchoolRoleAll.HandleId, ConfigSolarSchoolRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<SolarSchoolRole> readOnlyList = (IReadOnlyList<SolarSchoolRole>)ConfigCommon.GetConfig("SolarSchoolRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<SolarSchoolRole> list = new List<SolarSchoolRole>();
			while (ConfigCommon.Step(ConfigSolarSchoolRoleAll.HandleId, false, ConfigSolarSchoolRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigSolarSchoolRoleAll.HandleId, 0, ConfigSolarSchoolRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigSolarSchoolRoleAll.HandleId, ConfigSolarSchoolRoleAll.LogPair);
					return null;
				}
				SolarSchoolRole rootAsSolarSchoolRole = SolarSchoolRole.GetRootAsSolarSchoolRole(new ByteBuffer(item2));
				list.Add(rootAsSolarSchoolRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("SolarSchoolRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigSolarSchoolRoleAll.HandleId, ConfigSolarSchoolRoleAll.LogPair);
			return list;
		}

		// Token: 0x04004633 RID: 17971
		private const string DB = "db_solarschool.db";

		// Token: 0x04004634 RID: 17972
		private const string FILE = "d.第二索拉_角色.xlsx";

		// Token: 0x04004635 RID: 17973
		private const string TABLE = "SolarSchoolRole";

		// Token: 0x04004636 RID: 17974
		private const string COMMAND = "select BinData from `SolarSchoolRole`";

		// Token: 0x04004637 RID: 17975
		private const string KEY_PREFIX = "SolarSchoolRoleAll";

		// Token: 0x04004638 RID: 17976
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04004639 RID: 17977
		private static int HandleId;
	}
}
