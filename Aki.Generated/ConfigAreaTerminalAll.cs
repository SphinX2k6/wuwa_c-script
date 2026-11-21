using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000B5 RID: 181
	public class ConfigAreaTerminalAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600043F RID: 1087 RVA: 0x00075324 File Offset: 0x00073524
		static ConfigAreaTerminalAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalAll.CreateStaticDefaultValue), new Action(ConfigAreaTerminalAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00075344 File Offset: 0x00073544
		public static void CreateStaticDefaultValue()
		{
			ConfigAreaTerminalAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAreaTerminalAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_areaterminal.db"),
				new ValueTuple<string, object>("文件", "q.区域终端.xlsx"),
				new ValueTuple<string, object>("表名", "AreaTerminal"),
				new ValueTuple<string, object>("语句", "select BinData from `AreaTerminal`")
			});
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x000753C3 File Offset: 0x000735C3
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalAll.LogPair = null;
			ConfigAreaTerminalAll.HandleId = 0;
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x000753D1 File Offset: 0x000735D1
		public static void Init()
		{
			ConfigAreaTerminalAll.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalAll.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminal`");
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x000753EC File Offset: 0x000735EC
		[NullableContext(2)]
		public static IReadOnlyList<AreaTerminal> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigAreaTerminalAll.HandleId, ConfigAreaTerminalAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<AreaTerminal> readOnlyList = (IReadOnlyList<AreaTerminal>)ConfigCommon.GetConfig("AreaTerminalAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<AreaTerminal> list = new List<AreaTerminal>();
			while (ConfigCommon.Step(ConfigAreaTerminalAll.HandleId, false, ConfigAreaTerminalAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigAreaTerminalAll.HandleId, 0, ConfigAreaTerminalAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigAreaTerminalAll.HandleId, ConfigAreaTerminalAll.LogPair);
					return null;
				}
				AreaTerminal rootAsAreaTerminal = AreaTerminal.GetRootAsAreaTerminal(new ByteBuffer(item2));
				list.Add(rootAsAreaTerminal);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("AreaTerminalAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigAreaTerminalAll.HandleId, ConfigAreaTerminalAll.LogPair);
			return list;
		}

		// Token: 0x040004D7 RID: 1239
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004D8 RID: 1240
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004D9 RID: 1241
		private const string TABLE = "AreaTerminal";

		// Token: 0x040004DA RID: 1242
		private const string COMMAND = "select BinData from `AreaTerminal`";

		// Token: 0x040004DB RID: 1243
		private const string KEY_PREFIX = "AreaTerminalAll";

		// Token: 0x040004DC RID: 1244
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004DD RID: 1245
		private static int HandleId;
	}
}
