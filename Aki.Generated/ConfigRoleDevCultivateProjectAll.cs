using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AE RID: 2222
	public class ConfigRoleDevCultivateProjectAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003426 RID: 13350 RVA: 0x00183A90 File Offset: 0x00181C90
		static ConfigRoleDevCultivateProjectAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCultivateProjectAll.CreateStaticDefaultValue), new Action(ConfigRoleDevCultivateProjectAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003427 RID: 13351 RVA: 0x00183AB0 File Offset: 0x00181CB0
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

		// Token: 0x06003428 RID: 13352 RVA: 0x00183B2F File Offset: 0x00181D2F
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCultivateProjectAll.LogPair = null;
			ConfigRoleDevCultivateProjectAll.HandleId = 0;
		}

		// Token: 0x06003429 RID: 13353 RVA: 0x00183B3D File Offset: 0x00181D3D
		public static void Init()
		{
			ConfigRoleDevCultivateProjectAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCultivateProjectAll.HandleId, "db_roledev.db", "select BinData from `RoleDevCultivateProject`");
		}

		// Token: 0x0600342A RID: 13354 RVA: 0x00183B58 File Offset: 0x00181D58
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

		// Token: 0x04003CA8 RID: 15528
		private const string DB = "db_roledev.db";

		// Token: 0x04003CA9 RID: 15529
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CAA RID: 15530
		private const string TABLE = "RoleDevCultivateProject";

		// Token: 0x04003CAB RID: 15531
		private const string COMMAND = "select BinData from `RoleDevCultivateProject`";

		// Token: 0x04003CAC RID: 15532
		private const string KEY_PREFIX = "RoleDevCultivateProjectAll";

		// Token: 0x04003CAD RID: 15533
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CAE RID: 15534
		private static int HandleId;
	}
}
