using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000892 RID: 2194
	public class ConfigRoleDevCultivateProjectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600337E RID: 13182 RVA: 0x0017C7A8 File Offset: 0x0017A9A8
		static ConfigRoleDevCultivateProjectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCultivateProjectAll.CreateStaticDefaultValue), new Action(ConfigRoleDevCultivateProjectAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600337F RID: 13183 RVA: 0x0017C7C8 File Offset: 0x0017A9C8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevCultivateProjectAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevCultivateProjectAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevCultivateProject"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevCultivateProject`")
			});
		}

		// Token: 0x06003380 RID: 13184 RVA: 0x0017C847 File Offset: 0x0017AA47
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCultivateProjectAll.LogPair = null;
			ConfigRoleDevCultivateProjectAll.HandleId = 0;
		}

		// Token: 0x06003381 RID: 13185 RVA: 0x0017C855 File Offset: 0x0017AA55
		public static void Init()
		{
			ConfigRoleDevCultivateProjectAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCultivateProjectAll.HandleId, "db_roledev.db", "select BinData from `RoleDevCultivateProject`");
		}

		// Token: 0x06003382 RID: 13186 RVA: 0x0017C870 File Offset: 0x0017AA70
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevCultivateProject> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevCultivateProjectAll.HandleId, ConfigRoleDevCultivateProjectAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevCultivateProject> readOnlyList = (IReadOnlyList<RoleDevCultivateProject>)ConfigCommon.GetConfig("RoleDevCultivateProjectAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevCultivateProject> list = new List<RoleDevCultivateProject>();
			while (ConfigCommon.Step(ConfigRoleDevCultivateProjectAll.HandleId, false, ConfigRoleDevCultivateProjectAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevCultivateProjectAll.HandleId, 0, ConfigRoleDevCultivateProjectAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevCultivateProjectAll.HandleId, ConfigRoleDevCultivateProjectAll.LogPair);
					return null;
				}
				RoleDevCultivateProject rootAsRoleDevCultivateProject = RoleDevCultivateProject.GetRootAsRoleDevCultivateProject(new ByteBuffer(item2));
				list.Add(rootAsRoleDevCultivateProject);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevCultivateProjectAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevCultivateProjectAll.HandleId, ConfigRoleDevCultivateProjectAll.LogPair);
			return list;
		}

		// Token: 0x04003BE4 RID: 15332
		private const string DB = "db_roledev.db";

		// Token: 0x04003BE5 RID: 15333
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003BE6 RID: 15334
		private const string TABLE = "RoleDevCultivateProject";

		// Token: 0x04003BE7 RID: 15335
		private const string COMMAND = "select BinData from `RoleDevCultivateProject`";

		// Token: 0x04003BE8 RID: 15336
		private const string KEY_PREFIX = "RoleDevCultivateProjectAll";

		// Token: 0x04003BE9 RID: 15337
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BEA RID: 15338
		private static int HandleId;
	}
}
