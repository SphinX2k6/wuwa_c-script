using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A2 RID: 2210
	public class ConfigRoleDevWeaponItemAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033DE RID: 13278 RVA: 0x0017E72C File Offset: 0x0017C92C
		static ConfigRoleDevWeaponItemAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponItemAll.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponItemAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033DF RID: 13279 RVA: 0x0017E74C File Offset: 0x0017C94C
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevWeaponItemAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevWeaponItem"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevWeaponItem`")
			});
		}

		// Token: 0x060033E0 RID: 13280 RVA: 0x0017E7CB File Offset: 0x0017C9CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponItemAll.LogPair = null;
			ConfigRoleDevWeaponItemAll.HandleId = 0;
		}

		// Token: 0x060033E1 RID: 13281 RVA: 0x0017E7D9 File Offset: 0x0017C9D9
		public static void Init()
		{
			ConfigRoleDevWeaponItemAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponItemAll.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponItem`");
		}

		// Token: 0x060033E2 RID: 13282 RVA: 0x0017E7F4 File Offset: 0x0017C9F4
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevWeaponItem> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevWeaponItemAll.HandleId, ConfigRoleDevWeaponItemAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevWeaponItem> readOnlyList = (IReadOnlyList<RoleDevWeaponItem>)ConfigCommon.GetConfig("RoleDevWeaponItemAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevWeaponItem> list = new List<RoleDevWeaponItem>();
			while (ConfigCommon.Step(ConfigRoleDevWeaponItemAll.HandleId, false, ConfigRoleDevWeaponItemAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevWeaponItemAll.HandleId, 0, ConfigRoleDevWeaponItemAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevWeaponItemAll.HandleId, ConfigRoleDevWeaponItemAll.LogPair);
					return null;
				}
				RoleDevWeaponItem rootAsRoleDevWeaponItem = RoleDevWeaponItem.GetRootAsRoleDevWeaponItem(new ByteBuffer(item2));
				list.Add(rootAsRoleDevWeaponItem);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevWeaponItemAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevWeaponItemAll.HandleId, ConfigRoleDevWeaponItemAll.LogPair);
			return list;
		}

		// Token: 0x04003C54 RID: 15444
		private const string DB = "db_roledev.db";

		// Token: 0x04003C55 RID: 15445
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C56 RID: 15446
		private const string TABLE = "RoleDevWeaponItem";

		// Token: 0x04003C57 RID: 15447
		private const string COMMAND = "select BinData from `RoleDevWeaponItem`";

		// Token: 0x04003C58 RID: 15448
		private const string KEY_PREFIX = "RoleDevWeaponItemAll";

		// Token: 0x04003C59 RID: 15449
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C5A RID: 15450
		private static int HandleId;
	}
}
