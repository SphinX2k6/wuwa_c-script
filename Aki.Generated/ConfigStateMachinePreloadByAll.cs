using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000A65 RID: 2661
	public class ConfigStateMachinePreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003E72 RID: 15986 RVA: 0x001BD9C8 File Offset: 0x001BBBC8
		static ConfigStateMachinePreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigStateMachinePreloadByAll.CreateStaticDefaultValue), new Action(ConfigStateMachinePreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x06003E73 RID: 15987 RVA: 0x001BD9E8 File Offset: 0x001BBBE8
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

		// Token: 0x06003E74 RID: 15988 RVA: 0x001BDA67 File Offset: 0x001BBC67
		public static void ResetStaticDefaultValue()
		{
			ConfigStateMachinePreloadByAll.LogPair = null;
			ConfigStateMachinePreloadByAll.HandleId = 0;
		}

		// Token: 0x06003E75 RID: 15989 RVA: 0x001BDA75 File Offset: 0x001BBC75
		public static void Init()
		{
			ConfigStateMachinePreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigStateMachinePreloadByAll.HandleId, "db_state_machine_preload.db", "select BinData from `StateMachinePreload`");
		}

		// Token: 0x06003E76 RID: 15990 RVA: 0x001BDA90 File Offset: 0x001BBC90
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

		// Token: 0x040048A9 RID: 18601
		private const string DB = "db_state_machine_preload.db";

		// Token: 0x040048AA RID: 18602
		private const string FILE = "Preload/StateMachinePreload.csv";

		// Token: 0x040048AB RID: 18603
		private const string TABLE = "StateMachinePreload";

		// Token: 0x040048AC RID: 18604
		private const string COMMAND = "select BinData from `StateMachinePreload`";

		// Token: 0x040048AD RID: 18605
		private const string KEY_PREFIX = "StateMachinePreloadByAll";

		// Token: 0x040048AE RID: 18606
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040048AF RID: 18607
		private static int HandleId;
	}
}
