using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000898 RID: 2200
	public class ConfigRoleDevLevelLimitAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033A2 RID: 13218 RVA: 0x0017D3E0 File Offset: 0x0017B5E0
		static ConfigRoleDevLevelLimitAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevLevelLimitAll.CreateStaticDefaultValue), new Action(ConfigRoleDevLevelLimitAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033A3 RID: 13219 RVA: 0x0017D400 File Offset: 0x0017B600
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevLevelLimitAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevLevelLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevLevelLimit`")
			});
		}

		// Token: 0x060033A4 RID: 13220 RVA: 0x0017D47F File Offset: 0x0017B67F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitAll.LogPair = null;
			ConfigRoleDevLevelLimitAll.HandleId = 0;
		}

		// Token: 0x060033A5 RID: 13221 RVA: 0x0017D48D File Offset: 0x0017B68D
		public static void Init()
		{
			ConfigRoleDevLevelLimitAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevLevelLimitAll.HandleId, "db_roledev.db", "select BinData from `RoleDevLevelLimit`");
		}

		// Token: 0x060033A6 RID: 13222 RVA: 0x0017D4A8 File Offset: 0x0017B6A8
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevLevelLimit> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevLevelLimitAll.HandleId, ConfigRoleDevLevelLimitAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevLevelLimit> readOnlyList = (IReadOnlyList<RoleDevLevelLimit>)ConfigCommon.GetConfig("RoleDevLevelLimitAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevLevelLimit> list = new List<RoleDevLevelLimit>();
			while (ConfigCommon.Step(ConfigRoleDevLevelLimitAll.HandleId, false, ConfigRoleDevLevelLimitAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevLevelLimitAll.HandleId, 0, ConfigRoleDevLevelLimitAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevLevelLimitAll.HandleId, ConfigRoleDevLevelLimitAll.LogPair);
					return null;
				}
				RoleDevLevelLimit rootAsRoleDevLevelLimit = RoleDevLevelLimit.GetRootAsRoleDevLevelLimit(new ByteBuffer(item2));
				list.Add(rootAsRoleDevLevelLimit);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevLevelLimitAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevLevelLimitAll.HandleId, ConfigRoleDevLevelLimitAll.LogPair);
			return list;
		}

		// Token: 0x04003C0E RID: 15374
		private const string DB = "db_roledev.db";

		// Token: 0x04003C0F RID: 15375
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C10 RID: 15376
		private const string TABLE = "RoleDevLevelLimit";

		// Token: 0x04003C11 RID: 15377
		private const string COMMAND = "select BinData from `RoleDevLevelLimit`";

		// Token: 0x04003C12 RID: 15378
		private const string KEY_PREFIX = "RoleDevLevelLimitAll";

		// Token: 0x04003C13 RID: 15379
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C14 RID: 15380
		private static int HandleId;
	}
}
