using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008C0 RID: 2240
	public class ConfigRoleDevWeaponJumpGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003492 RID: 13458 RVA: 0x00185DF0 File Offset: 0x00183FF0
		static ConfigRoleDevWeaponJumpGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevWeaponJumpGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleDevWeaponJumpGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x00185E10 File Offset: 0x00184010
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

		// Token: 0x06003494 RID: 13460 RVA: 0x00185E8F File Offset: 0x0018408F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevWeaponJumpGroupAll.LogPair = null;
			ConfigRoleDevWeaponJumpGroupAll.HandleId = 0;
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x00185E9D File Offset: 0x0018409D
		public static void Init()
		{
			ConfigRoleDevWeaponJumpGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevWeaponJumpGroupAll.HandleId, "db_roledev.db", "select BinData from `RoleDevWeaponJumpGroup`");
		}

		// Token: 0x06003496 RID: 13462 RVA: 0x00185EB8 File Offset: 0x001840B8
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

		// Token: 0x04003D26 RID: 15654
		private const string DB = "db_roledev.db";

		// Token: 0x04003D27 RID: 15655
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003D28 RID: 15656
		private const string TABLE = "RoleDevWeaponJumpGroup";

		// Token: 0x04003D29 RID: 15657
		private const string COMMAND = "select BinData from `RoleDevWeaponJumpGroup`";

		// Token: 0x04003D2A RID: 15658
		private const string KEY_PREFIX = "RoleDevWeaponJumpGroupAll";

		// Token: 0x04003D2B RID: 15659
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003D2C RID: 15660
		private static int HandleId;
	}
}
