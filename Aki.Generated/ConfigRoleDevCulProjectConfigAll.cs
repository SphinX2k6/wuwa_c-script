using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008AC RID: 2220
	public class ConfigRoleDevCulProjectConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600341A RID: 13338 RVA: 0x001836B4 File Offset: 0x001818B4
		static ConfigRoleDevCulProjectConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevCulProjectConfigAll.CreateStaticDefaultValue), new Action(ConfigRoleDevCulProjectConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600341B RID: 13339 RVA: 0x001836D4 File Offset: 0x001818D4
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

		// Token: 0x0600341C RID: 13340 RVA: 0x00183753 File Offset: 0x00181953
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevCulProjectConfigAll.LogPair = null;
			ConfigRoleDevCulProjectConfigAll.HandleId = 0;
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00183761 File Offset: 0x00181961
		public static void Init()
		{
			ConfigRoleDevCulProjectConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevCulProjectConfigAll.HandleId, "db_roledev.db", "select BinData from `RoleDevCulProjectConfig`");
		}

		// Token: 0x0600341E RID: 13342 RVA: 0x0018377C File Offset: 0x0018197C
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

		// Token: 0x04003C9A RID: 15514
		private const string DB = "db_roledev.db";

		// Token: 0x04003C9B RID: 15515
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003C9C RID: 15516
		private const string TABLE = "RoleDevCulProjectConfig";

		// Token: 0x04003C9D RID: 15517
		private const string COMMAND = "select BinData from `RoleDevCulProjectConfig`";

		// Token: 0x04003C9E RID: 15518
		private const string KEY_PREFIX = "RoleDevCulProjectConfigAll";

		// Token: 0x04003C9F RID: 15519
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CA0 RID: 15520
		private static int HandleId;
	}
}
