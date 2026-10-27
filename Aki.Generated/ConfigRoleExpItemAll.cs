using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A6 RID: 2214
	public class ConfigRoleExpItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033F6 RID: 13302 RVA: 0x0017EEE4 File Offset: 0x0017D0E4
		static ConfigRoleExpItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleExpItemAll.CreateStaticDefaultValue), new Action(ConfigRoleExpItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033F7 RID: 13303 RVA: 0x0017EF04 File Offset: 0x0017D104
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

		// Token: 0x060033F8 RID: 13304 RVA: 0x0017EF83 File Offset: 0x0017D183
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleExpItemAll.LogPair = null;
			ConfigRoleExpItemAll.HandleId = 0;
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x0017EF91 File Offset: 0x0017D191
		public static void Init()
		{
			ConfigRoleExpItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleExpItemAll.HandleId, "db_role.db", "select BinData from `RoleExpItem`");
		}

		// Token: 0x060033FA RID: 13306 RVA: 0x0017EFAC File Offset: 0x0017D1AC
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

		// Token: 0x04003C70 RID: 15472
		private const string DB = "db_role.db";

		// Token: 0x04003C71 RID: 15473
		private const string FILE = "j.角色.xlsx";

		// Token: 0x04003C72 RID: 15474
		private const string TABLE = "RoleExpItem";

		// Token: 0x04003C73 RID: 15475
		private const string COMMAND = "select BinData from `RoleExpItem`";

		// Token: 0x04003C74 RID: 15476
		private const string KEY_PREFIX = "RoleExpItemAll";

		// Token: 0x04003C75 RID: 15477
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C76 RID: 15478
		private static int HandleId;
	}
}
