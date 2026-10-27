using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020000AD RID: 173
	public class ConfigAreaTerminalAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600040F RID: 1039 RVA: 0x00070A70 File Offset: 0x0006EC70
		static ConfigAreaTerminalAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAreaTerminalAll.CreateStaticDefaultValue), new Action(ConfigAreaTerminalAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00070A90 File Offset: 0x0006EC90
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

		// Token: 0x06000411 RID: 1041 RVA: 0x00070B0F File Offset: 0x0006ED0F
		public static void ResetStaticDefaultValue()
		{
			ConfigAreaTerminalAll.LogPair = null;
			ConfigAreaTerminalAll.HandleId = 0;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00070B1D File Offset: 0x0006ED1D
		public static void Init()
		{
			ConfigAreaTerminalAll.HandleId = ConfigCommon.InitDataStatement(ConfigAreaTerminalAll.HandleId, "db_areaterminal.db", "select BinData from `AreaTerminal`");
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00070B38 File Offset: 0x0006ED38
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

		// Token: 0x0400049F RID: 1183
		private const string DB = "db_areaterminal.db";

		// Token: 0x040004A0 RID: 1184
		private const string FILE = "q.区域终端.xlsx";

		// Token: 0x040004A1 RID: 1185
		private const string TABLE = "AreaTerminal";

		// Token: 0x040004A2 RID: 1186
		private const string COMMAND = "select BinData from `AreaTerminal`";

		// Token: 0x040004A3 RID: 1187
		private const string KEY_PREFIX = "AreaTerminalAll";

		// Token: 0x040004A4 RID: 1188
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040004A5 RID: 1189
		private static int HandleId;
	}
}
