using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000017 RID: 23
	public class ConfigAbyssLittleRoleAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600008A RID: 138 RVA: 0x0005D074 File Offset: 0x0005B274
		static ConfigAbyssLittleRoleAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssLittleRoleAll.CreateStaticDefaultValue), new Action(ConfigAbyssLittleRoleAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0005D094 File Offset: 0x0005B294
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssLittleRoleAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssLittleRoleAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssLittleRole"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssLittleRole`")
			});
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0005D113 File Offset: 0x0005B313
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssLittleRoleAll.LogPair = null;
			ConfigAbyssLittleRoleAll.HandleId = 0;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0005D121 File Offset: 0x0005B321
		public static void Init()
		{
			ConfigAbyssLittleRoleAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssLittleRoleAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssLittleRole`");
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0005D13C File Offset: 0x0005B33C
		[NullableContext(2)]
		public static IReadOnlyList<AbyssLittleRole> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssLittleRoleAll.HandleId, ConfigAbyssLittleRoleAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssLittleRole> readOnlyList = (IReadOnlyList<AbyssLittleRole>)ConfigCommon.GetConfig("AbyssLittleRoleAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssLittleRole> list = new List<AbyssLittleRole>();
			while (ConfigCommon.Step(ConfigAbyssLittleRoleAll.HandleId, false, ConfigAbyssLittleRoleAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssLittleRoleAll.HandleId, 0, ConfigAbyssLittleRoleAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssLittleRoleAll.HandleId, ConfigAbyssLittleRoleAll.LogPair);
					return null;
				}
				AbyssLittleRole rootAsAbyssLittleRole = AbyssLittleRole.GetRootAsAbyssLittleRole(new ByteBuffer(item2));
				list.Add(rootAsAbyssLittleRole);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssLittleRoleAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssLittleRoleAll.HandleId, ConfigAbyssLittleRoleAll.LogPair);
			return list;
		}

		// Token: 0x04000085 RID: 133
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x04000086 RID: 134
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x04000087 RID: 135
		private const string TABLE = "AbyssLittleRole";

		// Token: 0x04000088 RID: 136
		private const string COMMAND = "select BinData from `AbyssLittleRole`";

		// Token: 0x04000089 RID: 137
		private const string KEY_PREFIX = "AbyssLittleRoleAll";

		// Token: 0x0400008A RID: 138
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400008B RID: 139
		private static int HandleId;
	}
}
