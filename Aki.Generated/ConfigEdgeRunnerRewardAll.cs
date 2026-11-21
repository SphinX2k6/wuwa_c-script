using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000260 RID: 608
	public class ConfigEdgeRunnerRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000E44 RID: 3652 RVA: 0x000ADB1C File Offset: 0x000ABD1C
		static ConfigEdgeRunnerRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigEdgeRunnerRewardAll.CreateStaticDefaultValue), new Action(ConfigEdgeRunnerRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x000ADB3C File Offset: 0x000ABD3C
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

		// Token: 0x06000E46 RID: 3654 RVA: 0x000ADBBB File Offset: 0x000ABDBB
		public static void ResetStaticDefaultValue()
		{
			ConfigEdgeRunnerRewardAll.LogPair = null;
			ConfigEdgeRunnerRewardAll.HandleId = 0;
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x000ADBC9 File Offset: 0x000ABDC9
		public static void Init()
		{
			ConfigEdgeRunnerRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigEdgeRunnerRewardAll.HandleId, "db_edgerunner.db", "select BinData from `EdgeRunnerReward`");
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x000ADBE4 File Offset: 0x000ABDE4
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

		// Token: 0x04001084 RID: 4228
		private const string DB = "db_edgerunner.db";

		// Token: 0x04001085 RID: 4229
		private const string FILE = "b.边缘行者联动.xlsx";

		// Token: 0x04001086 RID: 4230
		private const string TABLE = "EdgeRunnerReward";

		// Token: 0x04001087 RID: 4231
		private const string COMMAND = "select BinData from `EdgeRunnerReward`";

		// Token: 0x04001088 RID: 4232
		private const string KEY_PREFIX = "EdgeRunnerRewardAll";

		// Token: 0x04001089 RID: 4233
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400108A RID: 4234
		private static int HandleId;
	}
}
