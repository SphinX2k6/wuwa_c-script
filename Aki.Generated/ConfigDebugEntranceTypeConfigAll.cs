using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FD RID: 509
	public class ConfigDebugEntranceTypeConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BF1 RID: 3057 RVA: 0x0009D29C File Offset: 0x0009B49C
		static ConfigDebugEntranceTypeConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceTypeConfigAll.CreateStaticDefaultValue), new Action(ConfigDebugEntranceTypeConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x0009D2BC File Offset: 0x0009B4BC
		public static void CreateStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDebugEntranceTypeConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_debugview.db"),
				new ValueTuple<string, object>("文件", "t.调试界面.xlsx"),
				new ValueTuple<string, object>("表名", "DebugEntranceTypeConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DebugEntranceTypeConfig`")
			});
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x0009D33B File Offset: 0x0009B53B
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceTypeConfigAll.LogPair = null;
			ConfigDebugEntranceTypeConfigAll.HandleId = 0;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x0009D349 File Offset: 0x0009B549
		public static void Init()
		{
			ConfigDebugEntranceTypeConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceTypeConfigAll.HandleId, "db_debugview.db", "select BinData from `DebugEntranceTypeConfig`");
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x0009D364 File Offset: 0x0009B564
		[NullableContext(2)]
		public static IReadOnlyList<DebugEntranceTypeConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDebugEntranceTypeConfigAll.HandleId, ConfigDebugEntranceTypeConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DebugEntranceTypeConfig> readOnlyList = (IReadOnlyList<DebugEntranceTypeConfig>)ConfigCommon.GetConfig("DebugEntranceTypeConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DebugEntranceTypeConfig> list = new List<DebugEntranceTypeConfig>();
			while (ConfigCommon.Step(ConfigDebugEntranceTypeConfigAll.HandleId, false, ConfigDebugEntranceTypeConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDebugEntranceTypeConfigAll.HandleId, 0, ConfigDebugEntranceTypeConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDebugEntranceTypeConfigAll.HandleId, ConfigDebugEntranceTypeConfigAll.LogPair);
					return null;
				}
				DebugEntranceTypeConfig rootAsDebugEntranceTypeConfig = DebugEntranceTypeConfig.GetRootAsDebugEntranceTypeConfig(new ByteBuffer(item2));
				list.Add(rootAsDebugEntranceTypeConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DebugEntranceTypeConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDebugEntranceTypeConfigAll.HandleId, ConfigDebugEntranceTypeConfigAll.LogPair);
			return list;
		}

		// Token: 0x04000DCF RID: 3535
		private const string DB = "db_debugview.db";

		// Token: 0x04000DD0 RID: 3536
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000DD1 RID: 3537
		private const string TABLE = "DebugEntranceTypeConfig";

		// Token: 0x04000DD2 RID: 3538
		private const string COMMAND = "select BinData from `DebugEntranceTypeConfig`";

		// Token: 0x04000DD3 RID: 3539
		private const string KEY_PREFIX = "DebugEntranceTypeConfigAll";

		// Token: 0x04000DD4 RID: 3540
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DD5 RID: 3541
		private static int HandleId;
	}
}
