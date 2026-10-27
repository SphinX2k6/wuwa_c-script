using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000505 RID: 1285
	public class ConfigMainRoleConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001E29 RID: 7721 RVA: 0x00103AE4 File Offset: 0x00101CE4
		static ConfigMainRoleConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMainRoleConfigAll.CreateStaticDefaultValue), new Action(ConfigMainRoleConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x00103B04 File Offset: 0x00101D04
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

		// Token: 0x06001E2B RID: 7723 RVA: 0x00103B83 File Offset: 0x00101D83
		public static void ResetStaticDefaultValue()
		{
			ConfigMainRoleConfigAll.LogPair = null;
			ConfigMainRoleConfigAll.HandleId = 0;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x00103B91 File Offset: 0x00101D91
		public static void Init()
		{
			ConfigMainRoleConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigMainRoleConfigAll.HandleId, "db_main_role_change.db", "select BinData from `MainRoleConfig`");
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x00103BAC File Offset: 0x00101DAC
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

		// Token: 0x04002307 RID: 8967
		private const string DB = "db_main_role_change.db";

		// Token: 0x04002308 RID: 8968
		private const string FILE = "z.主角切换.xlsx";

		// Token: 0x04002309 RID: 8969
		private const string TABLE = "MainRoleConfig";

		// Token: 0x0400230A RID: 8970
		private const string COMMAND = "select BinData from `MainRoleConfig`";

		// Token: 0x0400230B RID: 8971
		private const string KEY_PREFIX = "MainRoleConfigAll";

		// Token: 0x0400230C RID: 8972
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400230D RID: 8973
		private static int HandleId;
	}
}
