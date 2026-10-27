using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000890 RID: 2192
	public class ConfigRoleDevCulProjectConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003372 RID: 13170 RVA: 0x0017C3CC File Offset: 0x0017A5CC
		static ConfigRoleDevCulProjectConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCulProjectConfigAll.CreateStaticDefaultValue), new Action(ConfigRoleDevCulProjectConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003373 RID: 13171 RVA: 0x0017C3EC File Offset: 0x0017A5EC
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevCulProjectConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevCulProjectConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevCulProjectConfig`")
			});
		}

		// Token: 0x06003374 RID: 13172 RVA: 0x0017C46B File Offset: 0x0017A66B
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigAll.LogPair = null;
			ConfigRoleDevCulProjectConfigAll.HandleId = 0;
		}

		// Token: 0x06003375 RID: 13173 RVA: 0x0017C479 File Offset: 0x0017A679
		public static void Init()
		{
			ConfigRoleDevCulProjectConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCulProjectConfigAll.HandleId, "db_roledev.db", "select BinData from `RoleDevCulProjectConfig`");
		}

		// Token: 0x06003376 RID: 13174 RVA: 0x0017C494 File Offset: 0x0017A694
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevCulProjectConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevCulProjectConfigAll.HandleId, ConfigRoleDevCulProjectConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevCulProjectConfig> readOnlyList = (IReadOnlyList<RoleDevCulProjectConfig>)ConfigCommon.GetConfig("RoleDevCulProjectConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevCulProjectConfig> list = new List<RoleDevCulProjectConfig>();
			while (ConfigCommon.Step(ConfigRoleDevCulProjectConfigAll.HandleId, false, ConfigRoleDevCulProjectConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevCulProjectConfigAll.HandleId, 0, ConfigRoleDevCulProjectConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevCulProjectConfigAll.HandleId, ConfigRoleDevCulProjectConfigAll.LogPair);
					return null;
				}
				RoleDevCulProjectConfig rootAsRoleDevCulProjectConfig = RoleDevCulProjectConfig.GetRootAsRoleDevCulProjectConfig(new ByteBuffer(item2));
				list.Add(rootAsRoleDevCulProjectConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevCulProjectConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevCulProjectConfigAll.HandleId, ConfigRoleDevCulProjectConfigAll.LogPair);
			return list;
		}

		// Token: 0x04003BD6 RID: 15318
		private const string DB = "db_roledev.db";

		// Token: 0x04003BD7 RID: 15319
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003BD8 RID: 15320
		private const string TABLE = "RoleDevCulProjectConfig";

		// Token: 0x04003BD9 RID: 15321
		private const string COMMAND = "select BinData from `RoleDevCulProjectConfig`";

		// Token: 0x04003BDA RID: 15322
		private const string KEY_PREFIX = "RoleDevCulProjectConfigAll";

		// Token: 0x04003BDB RID: 15323
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003BDC RID: 15324
		private static int HandleId;
	}
}
