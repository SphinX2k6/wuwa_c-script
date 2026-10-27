using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200024C RID: 588
	public class ConfigEdgeRunnerRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000DCC RID: 3532 RVA: 0x000A7858 File Offset: 0x000A5A58
		static ConfigEdgeRunnerRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerRewardAll.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x000A7878 File Offset: 0x000A5A78
		public static void CreateStaticDefaultValue()
		{
			ConfigEdgeRunnerRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigEdgeRunnerRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_edgerunner.db"),
				new ValueTuple<string, object>("文件", "b.边缘行者联动.xlsx"),
				new ValueTuple<string, object>("表名", "EdgeRunnerReward"),
				new ValueTuple<string, object>("语句", "select BinData from `EdgeRunnerReward`")
			});
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x000A78F7 File Offset: 0x000A5AF7
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerRewardAll.LogPair = null;
			ConfigEdgeRunnerRewardAll.HandleId = 0;
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x000A7905 File Offset: 0x000A5B05
		public static void Init()
		{
			ConfigEdgeRunnerRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerRewardAll.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerReward`");
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000A7920 File Offset: 0x000A5B20
		[NullableContext(2)]
		public static IReadOnlyList<EdgeRunnerReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigEdgeRunnerRewardAll.HandleId, ConfigEdgeRunnerRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<EdgeRunnerReward> readOnlyList = (IReadOnlyList<EdgeRunnerReward>)ConfigCommon.GetConfig("EdgeRunnerRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<EdgeRunnerReward> list = new List<EdgeRunnerReward>();
			while (ConfigCommon.Step(ConfigEdgeRunnerRewardAll.HandleId, false, ConfigEdgeRunnerRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigEdgeRunnerRewardAll.HandleId, 0, ConfigEdgeRunnerRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigEdgeRunnerRewardAll.HandleId, ConfigEdgeRunnerRewardAll.LogPair);
					return null;
				}
				EdgeRunnerReward rootAsEdgeRunnerReward = EdgeRunnerReward.GetRootAsEdgeRunnerReward(new ByteBuffer(item2));
				list.Add(rootAsEdgeRunnerReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("EdgeRunnerRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigEdgeRunnerRewardAll.HandleId, ConfigEdgeRunnerRewardAll.LogPair);
			return list;
		}

		// Token: 0x04000FF8 RID: 4088
		private const string DB = "db_edgerunner.db";

		// Token: 0x04000FF9 RID: 4089
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04000FFA RID: 4090
		private const string TABLE = "EdgeRunnerReward";

		// Token: 0x04000FFB RID: 4091
		private const string COMMAND = "select BinData from `EdgeRunnerReward`";

		// Token: 0x04000FFC RID: 4092
		private const string KEY_PREFIX = "EdgeRunnerRewardAll";

		// Token: 0x04000FFD RID: 4093
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000FFE RID: 4094
		private static int HandleId;
	}
}
