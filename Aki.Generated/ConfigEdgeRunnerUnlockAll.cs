using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000254 RID: 596
	public class ConfigEdgeRunnerUnlockAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DFC RID: 3580 RVA: 0x000A8910 File Offset: 0x000A6B10
		static ConfigEdgeRunnerUnlockAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerUnlockAll.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerUnlockAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x000A8930 File Offset: 0x000A6B30
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerUnlockAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerUnlockAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerUnlock"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerUnlock`")
			});
		}

		// Token: 0x06000DFE RID: 3582 RVA: 0x000A89AF File Offset: 0x000A6BAF
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerUnlockAll.LogPair = null;
			ConfigEdgeRunnerUnlockAll.HandleId = 0;
		}

		// Token: 0x06000DFF RID: 3583 RVA: 0x000A89BD File Offset: 0x000A6BBD
		public static void Init()
		{
			ConfigEdgeRunnerUnlockAll.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerUnlockAll.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerUnlock`");
		}

		// Token: 0x06000E00 RID: 3584 RVA: 0x000A89D8 File Offset: 0x000A6BD8
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerUnlock> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerUnlockAll.HandleId, ConfigEdgeRunnerUnlockAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EdgeRunnerUnlock> readOnlyList = (IReadOnlyList<EdgeRunnerUnlock>)ConfigCommon.GetConfig("EdgeRunnerUnlockAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EdgeRunnerUnlock> list = new List<EdgeRunnerUnlock>();
			while (ConfigCommon.Step(ConfigEdgeRunnerUnlockAll.HandleId, false, ConfigEdgeRunnerUnlockAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerUnlockAll.HandleId, 0, ConfigEdgeRunnerUnlockAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerUnlockAll.HandleId, ConfigEdgeRunnerUnlockAll.LogPair);
					return null;
				}
				EdgeRunnerUnlock rootAsEdgeRunnerUnlock = EdgeRunnerUnlock.GetRootAsEdgeRunnerUnlock(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerUnlock);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EdgeRunnerUnlockAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerUnlockAll.HandleId, ConfigEdgeRunnerUnlockAll.LogPair);
			return list;
		}

		// Token: 0x04001030 RID: 4144
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001031 RID: 4145
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001032 RID: 4146
		private const string TABLE = "EdgeRunnerUnlock";

		// Token: 0x04001033 RID: 4147
		private const string COMMAND = "select BinData from `EdgeRunnerUnlock`";

		// Token: 0x04001034 RID: 4148
		private const string KEY_PREFIX = "EdgeRunnerUnlockAll";

		// Token: 0x04001035 RID: 4149
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001036 RID: 4150
		private static int HandleId;
	}
}
