using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C2 RID: 2242
	public class ConfigRoleExpItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600349E RID: 13470 RVA: 0x001861CC File Offset: 0x001843CC
		static ConfigRoleExpItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleExpItemAll.CreateStaticDefaultValue), new Action(ConfigRoleExpItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x001861EC File Offset: 0x001843EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleExpItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleExpItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_role.db"),
				new ValueTuple<string, object>("文件", "j.角色.xlsx"),
				new ValueTuple<string, object>("表名", "RoleExpItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleExpItem`")
			});
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x0018626B File Offset: 0x0018446B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleExpItemAll.LogPair = null;
			ConfigRoleExpItemAll.HandleId = 0;
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x00186279 File Offset: 0x00184479
		public static void Init()
		{
			ConfigRoleExpItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleExpItemAll.HandleId, "db_role.db", "select BinData from `RoleExpItem`");
		}

		// Token: 0x060034A2 RID: 13474 RVA: 0x00186294 File Offset: 0x00184494
		[NullableContext(2)]
		public static IReadOnlyList<RoleExpItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleExpItemAll.HandleId, ConfigRoleExpItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleExpItem> readOnlyList = (IReadOnlyList<RoleExpItem>)ConfigCommon.GetConfig("RoleExpItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleExpItem> list = new List<RoleExpItem>();
			while (ConfigCommon.Step(ConfigRoleExpItemAll.HandleId, false, ConfigRoleExpItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleExpItemAll.HandleId, 0, ConfigRoleExpItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleExpItemAll.HandleId, ConfigRoleExpItemAll.LogPair);
					return null;
				}
				RoleExpItem rootAsRoleExpItem = RoleExpItem.GetRootAsRoleExpItem(new ByteBuffer(item2));
				list.Add(rootAsRoleExpItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleExpItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleExpItemAll.HandleId, ConfigRoleExpItemAll.LogPair);
			return list;
		}

		// Token: 0x04003D34 RID: 15668
		private const string DB = "db_role.db";

		// Token: 0x04003D35 RID: 15669
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003D36 RID: 15670
		private const string TABLE = "RoleExpItem";

		// Token: 0x04003D37 RID: 15671
		private const string COMMAND = "select BinData from `RoleExpItem`";

		// Token: 0x04003D38 RID: 15672
		private const string KEY_PREFIX = "RoleExpItemAll";

		// Token: 0x04003D39 RID: 15673
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D3A RID: 15674
		private static int HandleId;
	}
}
