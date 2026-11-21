using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024D RID: 589
	public class ConfigDropCatchRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DD2 RID: 3538 RVA: 0x000AB46C File Offset: 0x000A966C
		static ConfigDropCatchRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleAll.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x000AB48C File Offset: 0x000A968C
		public static void CreateStaticDefaultValue()
		{
			ConfigDropCatchRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDropCatchRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dropcatch.db"),
				new ValueTuple<string, object>("文件", "j.接金币活动.xlsx"),
				new ValueTuple<string, object>("表名", "DropCatchRole"),
				new ValueTuple<string, object>("语句", "select BinData from `DropCatchRole`")
			});
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x000AB50B File Offset: 0x000A970B
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleAll.LogPair = null;
			ConfigDropCatchRoleAll.HandleId = 0;
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x000AB519 File Offset: 0x000A9719
		public static void Init()
		{
			ConfigDropCatchRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleAll.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRole`");
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x000AB534 File Offset: 0x000A9734
		[NullableContext(2)]
		public static IReadOnlyList<DropCatchRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDropCatchRoleAll.HandleId, ConfigDropCatchRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DropCatchRole> readOnlyList = (IReadOnlyList<DropCatchRole>)ConfigCommon.GetConfig("DropCatchRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DropCatchRole> list = new List<DropCatchRole>();
			while (ConfigCommon.Step(ConfigDropCatchRoleAll.HandleId, false, ConfigDropCatchRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDropCatchRoleAll.HandleId, 0, ConfigDropCatchRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDropCatchRoleAll.HandleId, ConfigDropCatchRoleAll.LogPair);
					return null;
				}
				DropCatchRole rootAsDropCatchRole = DropCatchRole.GetRootAsDropCatchRole(new ByteBuffer(item2));
				list.Add(rootAsDropCatchRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DropCatchRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDropCatchRoleAll.HandleId, ConfigDropCatchRoleAll.LogPair);
			return list;
		}

		// Token: 0x04000FFF RID: 4095
		private const string DB = "db_dropcatch.db";

		// Token: 0x04001000 RID: 4096
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04001001 RID: 4097
		private const string TABLE = "DropCatchRole";

		// Token: 0x04001002 RID: 4098
		private const string COMMAND = "select BinData from `DropCatchRole`";

		// Token: 0x04001003 RID: 4099
		private const string KEY_PREFIX = "DropCatchRoleAll";

		// Token: 0x04001004 RID: 4100
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001005 RID: 4101
		private static int HandleId;
	}
}
