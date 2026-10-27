using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200089C RID: 2204
	public class ConfigRoleDevProjectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060033BA RID: 13242 RVA: 0x0017DB98 File Offset: 0x0017BD98
		static ConfigRoleDevProjectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProjectAll.CreateStaticDefaultValue), new Action(ConfigRoleDevProjectAll.ResetStaticDefaultValue));
		}

		// Token: 0x060033BB RID: 13243 RVA: 0x0017DBB8 File Offset: 0x0017BDB8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevProjectAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevProjectAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevProject"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevProject`")
			});
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x0017DC37 File Offset: 0x0017BE37
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProjectAll.LogPair = null;
			ConfigRoleDevProjectAll.HandleId = 0;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x0017DC45 File Offset: 0x0017BE45
		public static void Init()
		{
			ConfigRoleDevProjectAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProjectAll.HandleId, "db_roledev.db", "select BinData from `RoleDevProject`");
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x0017DC60 File Offset: 0x0017BE60
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevProject> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevProjectAll.HandleId, ConfigRoleDevProjectAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevProject> readOnlyList = (IReadOnlyList<RoleDevProject>)ConfigCommon.GetConfig("RoleDevProjectAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevProject> list = new List<RoleDevProject>();
			while (ConfigCommon.Step(ConfigRoleDevProjectAll.HandleId, false, ConfigRoleDevProjectAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevProjectAll.HandleId, 0, ConfigRoleDevProjectAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevProjectAll.HandleId, ConfigRoleDevProjectAll.LogPair);
					return null;
				}
				RoleDevProject rootAsRoleDevProject = RoleDevProject.GetRootAsRoleDevProject(new ByteBuffer(item2));
				list.Add(rootAsRoleDevProject);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevProjectAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevProjectAll.HandleId, ConfigRoleDevProjectAll.LogPair);
			return list;
		}

		// Token: 0x04003C2A RID: 15402
		private const string DB = "db_roledev.db";

		// Token: 0x04003C2B RID: 15403
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C2C RID: 15404
		private const string TABLE = "RoleDevProject";

		// Token: 0x04003C2D RID: 15405
		private const string COMMAND = "select BinData from `RoleDevProject`";

		// Token: 0x04003C2E RID: 15406
		private const string KEY_PREFIX = "RoleDevProjectAll";

		// Token: 0x04003C2F RID: 15407
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003C30 RID: 15408
		private static int HandleId;
	}
}
