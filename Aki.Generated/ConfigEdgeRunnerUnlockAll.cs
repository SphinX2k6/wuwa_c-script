using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000268 RID: 616
	public class ConfigEdgeRunnerUnlockAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E74 RID: 3700 RVA: 0x000AEBD4 File Offset: 0x000ACDD4
		static ConfigEdgeRunnerUnlockAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerUnlockAll.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerUnlockAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x000AEBF4 File Offset: 0x000ACDF4
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

		// Token: 0x06000E76 RID: 3702 RVA: 0x000AEC73 File Offset: 0x000ACE73
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerUnlockAll.LogPair = null;
			ConfigEdgeRunnerUnlockAll.HandleId = 0;
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x000AEC81 File Offset: 0x000ACE81
		public static void Init()
		{
			ConfigEdgeRunnerUnlockAll.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerUnlockAll.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerUnlock`");
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x000AEC9C File Offset: 0x000ACE9C
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

		// Token: 0x040010BC RID: 4284
		private const string DB = "db_edgerunner.db";

		// Token: 0x040010BD RID: 4285
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x040010BE RID: 4286
		private const string TABLE = "EdgeRunnerUnlock";

		// Token: 0x040010BF RID: 4287
		private const string COMMAND = "select BinData from `EdgeRunnerUnlock`";

		// Token: 0x040010C0 RID: 4288
		private const string KEY_PREFIX = "EdgeRunnerUnlockAll";

		// Token: 0x040010C1 RID: 4289
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040010C2 RID: 4290
		private static int HandleId;
	}
}
