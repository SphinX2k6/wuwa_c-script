using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200051B RID: 1307
	public class ConfigMainRoleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001EAD RID: 7853 RVA: 0x0010A238 File Offset: 0x00108438
		static ConfigMainRoleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainRoleConfigAll.CreateStaticDefaultValue), new Action(ConfigMainRoleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001EAE RID: 7854 RVA: 0x0010A258 File Offset: 0x00108458
		public static void CreateStaticDefaultValue()
		{
			ConfigMainRoleConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMainRoleConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_main_role_change.db"),
				new ValueTuple<string, object>("文件", "z.主角切换.xlsx"),
				new ValueTuple<string, object>("表名", "MainRoleConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `MainRoleConfig`")
			});
		}

		// Token: 0x06001EAF RID: 7855 RVA: 0x0010A2D7 File Offset: 0x001084D7
		public static void ResetStaticDefaultValue()
		{
			ConfigMainRoleConfigAll.LogPair = null;
			ConfigMainRoleConfigAll.HandleId = 0;
		}

		// Token: 0x06001EB0 RID: 7856 RVA: 0x0010A2E5 File Offset: 0x001084E5
		public static void Init()
		{
			ConfigMainRoleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigMainRoleConfigAll.HandleId, "db_main_role_change.db", "select BinData from `MainRoleConfig`");
		}

		// Token: 0x06001EB1 RID: 7857 RVA: 0x0010A300 File Offset: 0x00108500
		[NullableContext(2)]
		public static IReadOnlyList<MainRoleConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigMainRoleConfigAll.HandleId, ConfigMainRoleConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<MainRoleConfig> readOnlyList = (IReadOnlyList<MainRoleConfig>)ConfigCommon.GetConfig("MainRoleConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<MainRoleConfig> list = new List<MainRoleConfig>();
			while (ConfigCommon.Step(ConfigMainRoleConfigAll.HandleId, false, ConfigMainRoleConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigMainRoleConfigAll.HandleId, 0, ConfigMainRoleConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigMainRoleConfigAll.HandleId, ConfigMainRoleConfigAll.LogPair);
					return null;
				}
				MainRoleConfig rootAsMainRoleConfig = MainRoleConfig.GetRootAsMainRoleConfig(new ByteBuffer(item2));
				list.Add(rootAsMainRoleConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("MainRoleConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigMainRoleConfigAll.HandleId, ConfigMainRoleConfigAll.LogPair);
			return list;
		}

		// Token: 0x040023A1 RID: 9121
		private const string DB = "db_main_role_change.db";

		// Token: 0x040023A2 RID: 9122
		private const string FILE = "z.主角切换.xlsx";

		// Token: 0x040023A3 RID: 9123
		private const string TABLE = "MainRoleConfig";

		// Token: 0x040023A4 RID: 9124
		private const string COMMAND = "select BinData from `MainRoleConfig`";

		// Token: 0x040023A5 RID: 9125
		private const string KEY_PREFIX = "MainRoleConfigAll";

		// Token: 0x040023A6 RID: 9126
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040023A7 RID: 9127
		private static int HandleId;
	}
}
