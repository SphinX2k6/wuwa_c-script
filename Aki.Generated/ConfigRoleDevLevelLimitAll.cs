using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008B4 RID: 2228
	public class ConfigRoleDevLevelLimitAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600344A RID: 13386 RVA: 0x001846C8 File Offset: 0x001828C8
		static ConfigRoleDevLevelLimitAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRoleDevLevelLimitAll.CreateStaticDefaultValue), new Action(ConfigRoleDevLevelLimitAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600344B RID: 13387 RVA: 0x001846E8 File Offset: 0x001828E8
		public static void CreateStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRoleDevLevelLimitAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_roledev.db"),
				new ValueTuple<string, object>("文件", "g.共鸣者培养计划.xlsx"),
				new ValueTuple<string, object>("表名", "RoleDevLevelLimit"),
				new ValueTuple<string, object>("语句", "select BinData from `RoleDevLevelLimit`")
			});
		}

		// Token: 0x0600344C RID: 13388 RVA: 0x00184767 File Offset: 0x00182967
		public static void ResetStaticDefaultValue()
		{
			ConfigRoleDevLevelLimitAll.LogPair = null;
			ConfigRoleDevLevelLimitAll.HandleId = 0;
		}

		// Token: 0x0600344D RID: 13389 RVA: 0x00184775 File Offset: 0x00182975
		public static void Init()
		{
			ConfigRoleDevLevelLimitAll.HandleId = ConfigCommon.InitDataStatement(ConfigRoleDevLevelLimitAll.HandleId, "db_roledev.db", "select BinData from `RoleDevLevelLimit`");
		}

		// Token: 0x0600344E RID: 13390 RVA: 0x00184790 File Offset: 0x00182990
		[NullableContext(2)]
		public static IReadOnlyList<RoleDevLevelLimit> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRoleDevLevelLimitAll.HandleId, ConfigRoleDevLevelLimitAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RoleDevLevelLimit> readOnlyList = (IReadOnlyList<RoleDevLevelLimit>)ConfigCommon.GetConfig("RoleDevLevelLimitAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RoleDevLevelLimit> list = new List<RoleDevLevelLimit>();
			while (ConfigCommon.Step(ConfigRoleDevLevelLimitAll.HandleId, false, ConfigRoleDevLevelLimitAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRoleDevLevelLimitAll.HandleId, 0, ConfigRoleDevLevelLimitAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRoleDevLevelLimitAll.HandleId, ConfigRoleDevLevelLimitAll.LogPair);
					return null;
				}
				RoleDevLevelLimit rootAsRoleDevLevelLimit = RoleDevLevelLimit.GetRootAsRoleDevLevelLimit(new ByteBuffer(item2));
				list.Add(rootAsRoleDevLevelLimit);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RoleDevLevelLimitAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRoleDevLevelLimitAll.HandleId, ConfigRoleDevLevelLimitAll.LogPair);
			return list;
		}

		// Token: 0x04003CD2 RID: 15570
		private const string DB = "db_roledev.db";

		// Token: 0x04003CD3 RID: 15571
		private const string FILE = "g.共鸣者培养计划.xlsx";

		// Token: 0x04003CD4 RID: 15572
		private const string TABLE = "RoleDevLevelLimit";

		// Token: 0x04003CD5 RID: 15573
		private const string COMMAND = "select BinData from `RoleDevLevelLimit`";

		// Token: 0x04003CD6 RID: 15574
		private const string KEY_PREFIX = "RoleDevLevelLimitAll";

		// Token: 0x04003CD7 RID: 15575
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003CD8 RID: 15576
		private static int HandleId;
	}
}
