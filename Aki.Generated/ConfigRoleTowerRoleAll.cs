using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000903 RID: 2307
	public class ConfigRoleTowerRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003625 RID: 13861 RVA: 0x0018EC18 File Offset: 0x0018CE18
		static ConfigRoleTowerRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleTowerRoleAll.CreateStaticDefaultValue), new Action(ConfigRoleTowerRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003626 RID: 13862 RVA: 0x0018EC38 File Offset: 0x0018CE38
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleTowerRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleTowerRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roletower.db"),
				new ValueTuple<string, object>("文件", "j.角色爬塔_局内.xlsx"),
				new ValueTuple<string, object>("表名", "RoleTowerRole"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleTowerRole`")
			});
		}

		// Token: 0x06003627 RID: 13863 RVA: 0x0018ECB7 File Offset: 0x0018CEB7
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleTowerRoleAll.LogPair = null;
			ConfigRoleTowerRoleAll.HandleId = 0;
		}

		// Token: 0x06003628 RID: 13864 RVA: 0x0018ECC5 File Offset: 0x0018CEC5
		public static void Init()
		{
			ConfigRoleTowerRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleTowerRoleAll.HandleId, "db_roletower.db", "select BinData from `RoleTowerRole`");
		}

		// Token: 0x06003629 RID: 13865 RVA: 0x0018ECE0 File Offset: 0x0018CEE0
		[NullableContext(2)]
		public static IReadOnlyList<RoleTowerRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleTowerRoleAll.HandleId, ConfigRoleTowerRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleTowerRole> readOnlyList = (IReadOnlyList<RoleTowerRole>)ConfigCommon.GetConfig("RoleTowerRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleTowerRole> list = new List<RoleTowerRole>();
			while (ConfigCommon.Step(ConfigRoleTowerRoleAll.HandleId, false, ConfigRoleTowerRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleTowerRoleAll.HandleId, 0, ConfigRoleTowerRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleTowerRoleAll.HandleId, ConfigRoleTowerRoleAll.LogPair);
					return null;
				}
				RoleTowerRole rootAsRoleTowerRole = RoleTowerRole.GetRootAsRoleTowerRole(new ByteBuffer(item2));
				list.Add(rootAsRoleTowerRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleTowerRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleTowerRoleAll.HandleId, ConfigRoleTowerRoleAll.LogPair);
			return list;
		}

		// Token: 0x04003EFB RID: 16123
		private const string DB = "db_roletower.db";

		// Token: 0x04003EFC RID: 16124
		private const string FILE = "j.角色爬塔_局内.xlsx";

		// Token: 0x04003EFD RID: 16125
		private const string TABLE = "RoleTowerRole";

		// Token: 0x04003EFE RID: 16126
		private const string COMMAND = "select BinData from `RoleTowerRole`";

		// Token: 0x04003EFF RID: 16127
		private const string KEY_PREFIX = "RoleTowerRoleAll";

		// Token: 0x04003F00 RID: 16128
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003F01 RID: 16129
		private static int HandleId;
	}
}
