using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000990 RID: 2448
	public class ConfigStateMachinePreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003974 RID: 14708 RVA: 0x0019E634 File Offset: 0x0019C834
		static ConfigStateMachinePreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateMachinePreloadByAll.CreateStaticDefaultValue), new Action(ConfigStateMachinePreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x0019E654 File Offset: 0x0019C854
		public static void CreateStaticDefaultValue()
		{
			ConfigStateMachinePreloadByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigStateMachinePreloadByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_state_machine_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/StateMachinePreload.csv"),
				new ValueTuple<string, object>("表名", "StateMachinePreload"),
				new ValueTuple<string, object>("语句", "select BinData from `StateMachinePreload`")
			});
		}

		// Token: 0x06003976 RID: 14710 RVA: 0x0019E6D3 File Offset: 0x0019C8D3
		public static void ResetStaticDefaultValue()
		{
			ConfigStateMachinePreloadByAll.LogPair = null;
			ConfigStateMachinePreloadByAll.HandleId = 0;
		}

		// Token: 0x06003977 RID: 14711 RVA: 0x0019E6E1 File Offset: 0x0019C8E1
		public static void Init()
		{
			ConfigStateMachinePreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigStateMachinePreloadByAll.HandleId, "db_state_machine_preload.db", "select BinData from `StateMachinePreload`");
		}

		// Token: 0x06003978 RID: 14712 RVA: 0x0019E6FC File Offset: 0x0019C8FC
		[NullableContext(2)]
		public static IReadOnlyList<StateMachinePreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigStateMachinePreloadByAll.HandleId, ConfigStateMachinePreloadByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<StateMachinePreload> readOnlyList = (IReadOnlyList<StateMachinePreload>)ConfigCommon.GetConfig("StateMachinePreloadByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<StateMachinePreload> list = new List<StateMachinePreload>();
			while (ConfigCommon.Step(ConfigStateMachinePreloadByAll.HandleId, false, ConfigStateMachinePreloadByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigStateMachinePreloadByAll.HandleId, 0, ConfigStateMachinePreloadByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigStateMachinePreloadByAll.HandleId, ConfigStateMachinePreloadByAll.LogPair);
					return null;
				}
				StateMachinePreload rootAsStateMachinePreload = StateMachinePreload.GetRootAsStateMachinePreload(new ByteBuffer(item2));
				list.Add(rootAsStateMachinePreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("StateMachinePreloadByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigStateMachinePreloadByAll.HandleId, ConfigStateMachinePreloadByAll.LogPair);
			return list;
		}

		// Token: 0x040042D6 RID: 17110
		private const string DB = "db_state_machine_preload.db";

		// Token: 0x040042D7 RID: 17111
		private const string FILE = "Preload/StateMachinePreload.csv";

		// Token: 0x040042D8 RID: 17112
		private const string TABLE = "StateMachinePreload";

		// Token: 0x040042D9 RID: 17113
		private const string COMMAND = "select BinData from `StateMachinePreload`";

		// Token: 0x040042DA RID: 17114
		private const string KEY_PREFIX = "StateMachinePreloadByAll";

		// Token: 0x040042DB RID: 17115
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042DC RID: 17116
		private static int HandleId;
	}
}
