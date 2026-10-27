using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000023 RID: 35
	public class ConfigAbyssRoleLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060000D2 RID: 210 RVA: 0x0005E79C File Offset: 0x0005C99C
		static ConfigAbyssRoleLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssRoleLevelAll.CreateStaticDefaultValue), new Action(ConfigAbyssRoleLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0005E7BC File Offset: 0x0005C9BC
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssRoleLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssRoleLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabysssuit.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssRoleLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssRoleLevel`")
			});
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0005E83B File Offset: 0x0005CA3B
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssRoleLevelAll.LogPair = null;
			ConfigAbyssRoleLevelAll.HandleId = 0;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0005E849 File Offset: 0x0005CA49
		public static void Init()
		{
			ConfigAbyssRoleLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssRoleLevelAll.HandleId, "db_dangoabysssuit.db", "select BinData from `AbyssRoleLevel`");
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0005E864 File Offset: 0x0005CA64
		[NullableContext(2)]
		public static IReadOnlyList<AbyssRoleLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssRoleLevelAll.HandleId, ConfigAbyssRoleLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssRoleLevel> readOnlyList = (IReadOnlyList<AbyssRoleLevel>)ConfigCommon.GetConfig("AbyssRoleLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssRoleLevel> list = new List<AbyssRoleLevel>();
			while (ConfigCommon.Step(ConfigAbyssRoleLevelAll.HandleId, false, ConfigAbyssRoleLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssRoleLevelAll.HandleId, 0, ConfigAbyssRoleLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssRoleLevelAll.HandleId, ConfigAbyssRoleLevelAll.LogPair);
					return null;
				}
				AbyssRoleLevel rootAsAbyssRoleLevel = AbyssRoleLevel.GetRootAsAbyssRoleLevel(new ByteBuffer(item2));
				list.Add(rootAsAbyssRoleLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssRoleLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssRoleLevelAll.HandleId, ConfigAbyssRoleLevelAll.LogPair);
			return list;
		}

		// Token: 0x040000D9 RID: 217
		private const string DB = "db_dangoabysssuit.db";

		// Token: 0x040000DA RID: 218
		private const string FILE = "s.深渊爬塔.xlsx";

		// Token: 0x040000DB RID: 219
		private const string TABLE = "AbyssRoleLevel";

		// Token: 0x040000DC RID: 220
		private const string COMMAND = "select BinData from `AbyssRoleLevel`";

		// Token: 0x040000DD RID: 221
		private const string KEY_PREFIX = "AbyssRoleLevelAll";

		// Token: 0x040000DE RID: 222
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040000DF RID: 223
		private static int HandleId;
	}
}
