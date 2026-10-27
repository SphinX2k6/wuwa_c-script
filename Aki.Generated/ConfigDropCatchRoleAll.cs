using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200023B RID: 571
	public class ConfigDropCatchRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000D66 RID: 3430 RVA: 0x000A5534 File Offset: 0x000A3734
		static ConfigDropCatchRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDropCatchRoleAll.CreateStaticDefaultValue), new Action(ConfigDropCatchRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x000A5554 File Offset: 0x000A3754
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

		// Token: 0x06000D68 RID: 3432 RVA: 0x000A55D3 File Offset: 0x000A37D3
		public static void ResetStaticDefaultValue()
		{
			ConfigDropCatchRoleAll.LogPair = null;
			ConfigDropCatchRoleAll.HandleId = 0;
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x000A55E1 File Offset: 0x000A37E1
		public static void Init()
		{
			ConfigDropCatchRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigDropCatchRoleAll.HandleId, "db_dropcatch.db", "select BinData from `DropCatchRole`");
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x000A55FC File Offset: 0x000A37FC
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

		// Token: 0x04000F81 RID: 3969
		private const string DB = "db_dropcatch.db";

		// Token: 0x04000F82 RID: 3970
		private const string FILE = "j.接金币活动.xlsx";

		// Token: 0x04000F83 RID: 3971
		private const string TABLE = "DropCatchRole";

		// Token: 0x04000F84 RID: 3972
		private const string COMMAND = "select BinData from `DropCatchRole`";

		// Token: 0x04000F85 RID: 3973
		private const string KEY_PREFIX = "DropCatchRoleAll";

		// Token: 0x04000F86 RID: 3974
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000F87 RID: 3975
		private static int HandleId;
	}
}
