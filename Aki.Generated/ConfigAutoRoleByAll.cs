using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000C3 RID: 195
	public class ConfigAutoRoleByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000493 RID: 1171 RVA: 0x000771D4 File Offset: 0x000753D4
		static ConfigAutoRoleByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAutoRoleByAll.CreateStaticDefaultValue), new Action(ConfigAutoRoleByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x000771F4 File Offset: 0x000753F4
		public static void CreateStaticDefaultValue()
		{
			ConfigAutoRoleByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAutoRoleByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "AutoRole"),
				new ValueTuple<string, object>("语句", "select BinData from `AutoRole`")
			});
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x00077273 File Offset: 0x00075473
		public static void ResetStaticDefaultValue()
		{
			ConfigAutoRoleByAll.LogPair = null;
			ConfigAutoRoleByAll.HandleId = 0;
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x00077281 File Offset: 0x00075481
		public static void Init()
		{
			ConfigAutoRoleByAll.HandleId = ConfigCommon.InitDataStatement(ConfigAutoRoleByAll.HandleId, "db_role.db", "select BinData from `AutoRole`");
		}

		// Token: 0x06000497 RID: 1175 RVA: 0x0007729C File Offset: 0x0007549C
		[NullableContext(2)]
		public static IReadOnlyList<AutoRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAutoRoleByAll.HandleId, ConfigAutoRoleByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AutoRole> readOnlyList = (IReadOnlyList<AutoRole>)ConfigCommon.GetConfig("AutoRoleByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AutoRole> list = new List<AutoRole>();
			while (ConfigCommon.Step(ConfigAutoRoleByAll.HandleId, false, ConfigAutoRoleByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAutoRoleByAll.HandleId, 0, ConfigAutoRoleByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAutoRoleByAll.HandleId, ConfigAutoRoleByAll.LogPair);
					return null;
				}
				AutoRole rootAsAutoRole = AutoRole.GetRootAsAutoRole(new ByteBuffer(item2));
				list.Add(rootAsAutoRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AutoRoleByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAutoRoleByAll.HandleId, ConfigAutoRoleByAll.LogPair);
			return list;
		}

		// Token: 0x04000539 RID: 1337
		private const string DB = "db_role.db";

		// Token: 0x0400053A RID: 1338
		private const string FILE = "j.角色.xlsx";

		// Token: 0x0400053B RID: 1339
		private const string TABLE = "AutoRole";

		// Token: 0x0400053C RID: 1340
		private const string COMMAND = "select BinData from `AutoRole`";

		// Token: 0x0400053D RID: 1341
		private const string KEY_PREFIX = "AutoRoleByAll";

		// Token: 0x0400053E RID: 1342
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400053F RID: 1343
		private static int HandleId;
	}
}
