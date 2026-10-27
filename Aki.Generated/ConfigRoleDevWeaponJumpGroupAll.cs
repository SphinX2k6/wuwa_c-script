using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A4 RID: 2212
	public class ConfigRoleDevWeaponJumpGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033EA RID: 13290 RVA: 0x0017EB08 File Offset: 0x0017CD08
		static ConfigRoleDevWeaponJumpGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponJumpGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponJumpGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033EB RID: 13291 RVA: 0x0017EB28 File Offset: 0x0017CD28
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevWeaponJumpGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevWeaponJumpGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevWeaponJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevWeaponJumpGroup`")
			});
		}

		// Token: 0x060033EC RID: 13292 RVA: 0x0017EBA7 File Offset: 0x0017CDA7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponJumpGroupAll.LogPair = null;
			ConfigRoleDevWeaponJumpGroupAll.HandleId = 0;
		}

		// Token: 0x060033ED RID: 13293 RVA: 0x0017EBB5 File Offset: 0x0017CDB5
		public static void Init()
		{
			ConfigRoleDevWeaponJumpGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponJumpGroupAll.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponJumpGroup`");
		}

		// Token: 0x060033EE RID: 13294 RVA: 0x0017EBD0 File Offset: 0x0017CDD0
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevWeaponJumpGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevWeaponJumpGroupAll.HandleId, ConfigRoleDevWeaponJumpGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevWeaponJumpGroup> readOnlyList = (IReadOnlyList<RoleDevWeaponJumpGroup>)ConfigCommon.GetConfig("RoleDevWeaponJumpGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevWeaponJumpGroup> list = new List<RoleDevWeaponJumpGroup>();
			while (ConfigCommon.Step(ConfigRoleDevWeaponJumpGroupAll.HandleId, false, ConfigRoleDevWeaponJumpGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevWeaponJumpGroupAll.HandleId, 0, ConfigRoleDevWeaponJumpGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevWeaponJumpGroupAll.HandleId, ConfigRoleDevWeaponJumpGroupAll.LogPair);
					return null;
				}
				RoleDevWeaponJumpGroup rootAsRoleDevWeaponJumpGroup = RoleDevWeaponJumpGroup.GetRootAsRoleDevWeaponJumpGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleDevWeaponJumpGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevWeaponJumpGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevWeaponJumpGroupAll.HandleId, ConfigRoleDevWeaponJumpGroupAll.LogPair);
			return list;
		}

		// Token: 0x04003C62 RID: 15458
		private const string DB = "db_roledev.db";

		// Token: 0x04003C63 RID: 15459
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C64 RID: 15460
		private const string TABLE = "RoleDevWeaponJumpGroup";

		// Token: 0x04003C65 RID: 15461
		private const string COMMAND = "select BinData from `RoleDevWeaponJumpGroup`";

		// Token: 0x04003C66 RID: 15462
		private const string KEY_PREFIX = "RoleDevWeaponJumpGroupAll";

		// Token: 0x04003C67 RID: 15463
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C68 RID: 15464
		private static int HandleId;
	}
}
