using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200020D RID: 525
	public class ConfigDebugEntranceConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000C51 RID: 3153 RVA: 0x000A2DF8 File Offset: 0x000A0FF8
		static ConfigDebugEntranceConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigDebugEntranceConfigAll.CreateStaticDefaultValue), new Action(ConfigDebugEntranceConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000C52 RID: 3154 RVA: 0x000A2E18 File Offset: 0x000A1018
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

		// Token: 0x06000C53 RID: 3155 RVA: 0x000A2E97 File Offset: 0x000A1097
		public static void ResetStaticDefaultValue()
		{
			ConfigDebugEntranceConfigAll.LogPair = null;
			ConfigDebugEntranceConfigAll.HandleId = 0;
		}

		// Token: 0x06000C54 RID: 3156 RVA: 0x000A2EA5 File Offset: 0x000A10A5
		public static void Init()
		{
			ConfigDebugEntranceConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigDebugEntranceConfigAll.HandleId, "db_debugview.db", "select BinData from `DebugEntranceConfig`");
		}

		// Token: 0x06000C55 RID: 3157 RVA: 0x000A2EC0 File Offset: 0x000A10C0
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

		// Token: 0x04000E3F RID: 3647
		private const string DB = "db_debugview.db";

		// Token: 0x04000E40 RID: 3648
		private const string FILE = "t.调试界面.xlsx";

		// Token: 0x04000E41 RID: 3649
		private const string TABLE = "DebugEntranceConfig";

		// Token: 0x04000E42 RID: 3650
		private const string COMMAND = "select BinData from `DebugEntranceConfig`";

		// Token: 0x04000E43 RID: 3651
		private const string KEY_PREFIX = "DebugEntranceConfigAll";

		// Token: 0x04000E44 RID: 3652
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000E45 RID: 3653
		private static int HandleId;
	}
}
