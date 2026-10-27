using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000011 RID: 17
	public class ConfigAbyssInstAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000066 RID: 102 RVA: 0x0005C43C File Offset: 0x0005A63C
		static ConfigAbyssInstAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAbyssInstAll.CreateStaticDefaultValue), new Action(ConfigAbyssInstAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0005C45C File Offset: 0x0005A65C
		public static void CreateStaticDefaultValue()
		{
			ConfigAbyssInstAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAbyssInstAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_dangoabyss.db"),
				new ValueTuple<string, object>("文件", "s.深渊爬塔副本.xlsx"),
				new ValueTuple<string, object>("表名", "AbyssInst"),
				new ValueTuple<string, object>("语句", "select BinData from `AbyssInst`")
			});
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0005C4DB File Offset: 0x0005A6DB
		public static void ResetStaticDefaultValue()
		{
			ConfigAbyssInstAll.LogPair = null;
			ConfigAbyssInstAll.HandleId = 0;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0005C4E9 File Offset: 0x0005A6E9
		public static void Init()
		{
			ConfigAbyssInstAll.HandleId = ConfigCommon.InitDataStatement(ConfigAbyssInstAll.HandleId, "db_dangoabyss.db", "select BinData from `AbyssInst`");
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0005C504 File Offset: 0x0005A704
		[NullableContext(2)]
		public static IReadOnlyList<AbyssInst> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAbyssInstAll.HandleId, ConfigAbyssInstAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AbyssInst> readOnlyList = (IReadOnlyList<AbyssInst>)ConfigCommon.GetConfig("AbyssInstAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AbyssInst> list = new List<AbyssInst>();
			while (ConfigCommon.Step(ConfigAbyssInstAll.HandleId, false, ConfigAbyssInstAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAbyssInstAll.HandleId, 0, ConfigAbyssInstAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAbyssInstAll.HandleId, ConfigAbyssInstAll.LogPair);
					return null;
				}
				AbyssInst rootAsAbyssInst = AbyssInst.GetRootAsAbyssInst(new ByteBuffer(item2));
				list.Add(rootAsAbyssInst);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AbyssInstAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAbyssInstAll.HandleId, ConfigAbyssInstAll.LogPair);
			return list;
		}

		// Token: 0x0400005B RID: 91
		private const string DB = "db_dangoabyss.db";

		// Token: 0x0400005C RID: 92
		private const string FILE = "s.深渊爬塔副本.xlsx";

		// Token: 0x0400005D RID: 93
		private const string TABLE = "AbyssInst";

		// Token: 0x0400005E RID: 94
		private const string COMMAND = "select BinData from `AbyssInst`";

		// Token: 0x0400005F RID: 95
		private const string KEY_PREFIX = "AbyssInstAll";

		// Token: 0x04000060 RID: 96
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000061 RID: 97
		private static int HandleId;
	}
}
