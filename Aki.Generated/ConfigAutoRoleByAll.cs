using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000BB RID: 187
	public class ConfigAutoRoleByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000463 RID: 1123 RVA: 0x00072920 File Offset: 0x00070B20
		static ConfigAutoRoleByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAutoRoleByAll.CreateStaticDefaultValue), new Action(ConfigAutoRoleByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000464 RID: 1124 RVA: 0x00072940 File Offset: 0x00070B40
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

		// Token: 0x06000465 RID: 1125 RVA: 0x000729BF File Offset: 0x00070BBF
		public static void ResetStaticDefaultValue()
		{
			ConfigAutoRoleByAll.LogPair = null;
			ConfigAutoRoleByAll.HandleId = 0;
		}

		// Token: 0x06000466 RID: 1126 RVA: 0x000729CD File Offset: 0x00070BCD
		public static void Init()
		{
			ConfigAutoRoleByAll.HandleId = ConfigCommon.InitDataStatement(ConfigAutoRoleByAll.HandleId, "db_role.db", "select BinData from `AutoRole`");
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x000729E8 File Offset: 0x00070BE8
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

		// Token: 0x04000501 RID: 1281
		private const string DB = "db_role.db";

		// Token: 0x04000502 RID: 1282
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04000503 RID: 1283
		private const string TABLE = "AutoRole";

		// Token: 0x04000504 RID: 1284
		private const string COMMAND = "select BinData from `AutoRole`";

		// Token: 0x04000505 RID: 1285
		private const string KEY_PREFIX = "AutoRoleByAll";

		// Token: 0x04000506 RID: 1286
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000507 RID: 1287
		private static int HandleId;
	}
}
