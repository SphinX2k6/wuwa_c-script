using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000896 RID: 2198
	public class ConfigRoleDevItemJumpGroupAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003396 RID: 13206 RVA: 0x0017D004 File Offset: 0x0017B204
		static ConfigRoleDevItemJumpGroupAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevItemJumpGroupAll.CreateStaticDefaultValue), new Action(ConfigRoleDevItemJumpGroupAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003397 RID: 13207 RVA: 0x0017D024 File Offset: 0x0017B224
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevItemJumpGroupAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevItemJumpGroup"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevItemJumpGroup`")
			});
		}

		// Token: 0x06003398 RID: 13208 RVA: 0x0017D0A3 File Offset: 0x0017B2A3
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevItemJumpGroupAll.LogPair = null;
			ConfigRoleDevItemJumpGroupAll.HandleId = 0;
		}

		// Token: 0x06003399 RID: 13209 RVA: 0x0017D0B1 File Offset: 0x0017B2B1
		public static void Init()
		{
			ConfigRoleDevItemJumpGroupAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevItemJumpGroupAll.HandleId, "db_roledev.db", "select BinData from `RoleDevItemJumpGroup`");
		}

		// Token: 0x0600339A RID: 13210 RVA: 0x0017D0CC File Offset: 0x0017B2CC
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevItemJumpGroup> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevItemJumpGroupAll.HandleId, ConfigRoleDevItemJumpGroupAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevItemJumpGroup> readOnlyList = (IReadOnlyList<RoleDevItemJumpGroup>)ConfigCommon.GetConfig("RoleDevItemJumpGroupAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevItemJumpGroup> list = new List<RoleDevItemJumpGroup>();
			while (ConfigCommon.Step(ConfigRoleDevItemJumpGroupAll.HandleId, false, ConfigRoleDevItemJumpGroupAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevItemJumpGroupAll.HandleId, 0, ConfigRoleDevItemJumpGroupAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevItemJumpGroupAll.HandleId, ConfigRoleDevItemJumpGroupAll.LogPair);
					return null;
				}
				RoleDevItemJumpGroup rootAsRoleDevItemJumpGroup = RoleDevItemJumpGroup.GetRootAsRoleDevItemJumpGroup(new ByteBuffer(item2));
				list.Add(rootAsRoleDevItemJumpGroup);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevItemJumpGroupAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevItemJumpGroupAll.HandleId, ConfigRoleDevItemJumpGroupAll.LogPair);
			return list;
		}

		// Token: 0x04003C00 RID: 15360
		private const string DB = "db_roledev.db";

		// Token: 0x04003C01 RID: 15361
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C02 RID: 15362
		private const string TABLE = "RoleDevItemJumpGroup";

		// Token: 0x04003C03 RID: 15363
		private const string COMMAND = "select BinData from `RoleDevItemJumpGroup`";

		// Token: 0x04003C04 RID: 15364
		private const string KEY_PREFIX = "RoleDevItemJumpGroupAll";

		// Token: 0x04003C05 RID: 15365
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C06 RID: 15366
		private static int HandleId;
	}
}
