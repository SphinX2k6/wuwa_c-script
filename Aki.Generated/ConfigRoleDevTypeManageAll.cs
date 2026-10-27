using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008A0 RID: 2208
	public class ConfigRoleDevTypeManageAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033D2 RID: 13266 RVA: 0x0017E350 File Offset: 0x0017C550
		static ConfigRoleDevTypeManageAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevTypeManageAll.CreateStaticDefaultValue), new Action(ConfigRoleDevTypeManageAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033D3 RID: 13267 RVA: 0x0017E370 File Offset: 0x0017C570
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevTypeManageAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevTypeManageAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevTypeManage"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevTypeManage`")
			});
		}

		// Token: 0x060033D4 RID: 13268 RVA: 0x0017E3EF File Offset: 0x0017C5EF
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevTypeManageAll.LogPair = null;
			ConfigRoleDevTypeManageAll.HandleId = 0;
		}

		// Token: 0x060033D5 RID: 13269 RVA: 0x0017E3FD File Offset: 0x0017C5FD
		public static void Init()
		{
			ConfigRoleDevTypeManageAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevTypeManageAll.HandleId, "db_roledev.db", "select BinData from `RoleDevTypeManage`");
		}

		// Token: 0x060033D6 RID: 13270 RVA: 0x0017E418 File Offset: 0x0017C618
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevTypeManage> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevTypeManageAll.HandleId, ConfigRoleDevTypeManageAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevTypeManage> readOnlyList = (IReadOnlyList<RoleDevTypeManage>)ConfigCommon.GetConfig("RoleDevTypeManageAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevTypeManage> list = new List<RoleDevTypeManage>();
			while (ConfigCommon.Step(ConfigRoleDevTypeManageAll.HandleId, false, ConfigRoleDevTypeManageAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevTypeManageAll.HandleId, 0, ConfigRoleDevTypeManageAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevTypeManageAll.HandleId, ConfigRoleDevTypeManageAll.LogPair);
					return null;
				}
				RoleDevTypeManage rootAsRoleDevTypeManage = RoleDevTypeManage.GetRootAsRoleDevTypeManage(new ByteBuffer(item2));
				list.Add(rootAsRoleDevTypeManage);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevTypeManageAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevTypeManageAll.HandleId, ConfigRoleDevTypeManageAll.LogPair);
			return list;
		}

		// Token: 0x04003C46 RID: 15430
		private const string DB = "db_roledev.db";

		// Token: 0x04003C47 RID: 15431
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C48 RID: 15432
		private const string TABLE = "RoleDevTypeManage";

		// Token: 0x04003C49 RID: 15433
		private const string COMMAND = "select BinData from `RoleDevTypeManage`";

		// Token: 0x04003C4A RID: 15434
		private const string KEY_PREFIX = "RoleDevTypeManageAll";

		// Token: 0x04003C4B RID: 15435
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C4C RID: 15436
		private static int HandleId;
	}
}
