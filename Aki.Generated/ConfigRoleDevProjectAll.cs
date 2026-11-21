using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B8 RID: 2232
	public class ConfigRoleDevProjectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003462 RID: 13410 RVA: 0x00184E80 File Offset: 0x00183080
		static ConfigRoleDevProjectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevProjectAll.CreateStaticDefaultValue), new Action(ConfigRoleDevProjectAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003463 RID: 13411 RVA: 0x00184EA0 File Offset: 0x001830A0
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

		// Token: 0x06003464 RID: 13412 RVA: 0x00184F1F File Offset: 0x0018311F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevProjectAll.LogPair = null;
			ConfigRoleDevProjectAll.HandleId = 0;
		}

		// Token: 0x06003465 RID: 13413 RVA: 0x00184F2D File Offset: 0x0018312D
		public static void Init()
		{
			ConfigRoleDevProjectAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevProjectAll.HandleId, "db_roledev.db", "select BinData from `RoleDevProject`");
		}

		// Token: 0x06003466 RID: 13414 RVA: 0x00184F48 File Offset: 0x00183148
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

		// Token: 0x04003CEE RID: 15598
		private const string DB = "db_roledev.db";

		// Token: 0x04003CEF RID: 15599
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CF0 RID: 15600
		private const string TABLE = "RoleDevProject";

		// Token: 0x04003CF1 RID: 15601
		private const string COMMAND = "select BinData from `RoleDevProject`";

		// Token: 0x04003CF2 RID: 15602
		private const string KEY_PREFIX = "RoleDevProjectAll";

		// Token: 0x04003CF3 RID: 15603
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CF4 RID: 15604
		private static int HandleId;
	}
}
