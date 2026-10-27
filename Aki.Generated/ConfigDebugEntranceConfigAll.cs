using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020001FB RID: 507
	public class ConfigDebugEntranceConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000BE5 RID: 3045 RVA: 0x0009CEC0 File Offset: 0x0009B0C0
		static ConfigDebugEntranceConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceConfigAll.CreateStaticDefaultValue), new Action(ConfigDebugEntranceConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x0009CEE0 File Offset: 0x0009B0E0
		public static void CreateStaticDefaultValue()
		{
			ConfigDebugEntranceConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigDebugEntranceConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_debugview.db"),
				new ValueTuple<string, object>("文件", "t.调试界面.xlsx"),
				new ValueTuple<string, object>("表名", "DebugEntranceConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `DebugEntranceConfig`")
			});
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x0009CF5F File Offset: 0x0009B15F
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceConfigAll.LogPair = null;
			ConfigDebugEntranceConfigAll.HandleId = 0;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x0009CF6D File Offset: 0x0009B16D
		public static void Init()
		{
			ConfigDebugEntranceConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceConfigAll.HandleId, "db_debugview.db", "select BinData from `DebugEntranceConfig`");
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x0009CF88 File Offset: 0x0009B188
		[NullableContext(2)]
		public static IReadOnlyList<DebugEntranceConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigDebugEntranceConfigAll.HandleId, ConfigDebugEntranceConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<DebugEntranceConfig> readOnlyList = (IReadOnlyList<DebugEntranceConfig>)ConfigCommon.GetConfig("DebugEntranceConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<DebugEntranceConfig> list = new List<DebugEntranceConfig>();
			while (ConfigCommon.Step(ConfigDebugEntranceConfigAll.HandleId, false, ConfigDebugEntranceConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigDebugEntranceConfigAll.HandleId, 0, ConfigDebugEntranceConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigDebugEntranceConfigAll.HandleId, ConfigDebugEntranceConfigAll.LogPair);
					return null;
				}
				DebugEntranceConfig rootAsDebugEntranceConfig = DebugEntranceConfig.GetRootAsDebugEntranceConfig(new ByteBuffer(item2));
				list.Add(rootAsDebugEntranceConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("DebugEntranceConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigDebugEntranceConfigAll.HandleId, ConfigDebugEntranceConfigAll.LogPair);
			return list;
		}

		// Token: 0x04000DC1 RID: 3521
		private const string DB = "db_debugview.db";

		// Token: 0x04000DC2 RID: 3522
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000DC3 RID: 3523
		private const string TABLE = "DebugEntranceConfig";

		// Token: 0x04000DC4 RID: 3524
		private const string COMMAND = "select BinData from `DebugEntranceConfig`";

		// Token: 0x04000DC5 RID: 3525
		private const string KEY_PREFIX = "DebugEntranceConfigAll";

		// Token: 0x04000DC6 RID: 3526
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000DC7 RID: 3527
		private static int HandleId;
	}
}
