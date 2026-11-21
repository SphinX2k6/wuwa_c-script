using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020002AC RID: 684
	public class ConfigExploreProgressRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600100D RID: 4109 RVA: 0x000B7CE4 File Offset: 0x000B5EE4
		static ConfigExploreProgressRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressRewardAll.CreateStaticDefaultValue), new Action(ConfigExploreProgressRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x000B7D04 File Offset: 0x000B5F04
		public static void CreateStaticDefaultValue()
		{
			ConfigExploreProgressRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigExploreProgressRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_explore_progress.db"),
				new ValueTuple<string, object>("文件", "t.探索度.xlsx"),
				new ValueTuple<string, object>("表名", "ExploreProgressReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ExploreProgressReward`")
			});
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x000B7D83 File Offset: 0x000B5F83
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressRewardAll.LogPair = null;
			ConfigExploreProgressRewardAll.HandleId = 0;
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x000B7D91 File Offset: 0x000B5F91
		public static void Init()
		{
			ConfigExploreProgressRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressRewardAll.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgressReward`");
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x000B7DAC File Offset: 0x000B5FAC
		[NullableContext(2)]
		public static IReadOnlyList<ExploreProgressReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigExploreProgressRewardAll.HandleId, ConfigExploreProgressRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<ExploreProgressReward> readOnlyList = (IReadOnlyList<ExploreProgressReward>)ConfigCommon.GetConfig("ExploreProgressRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<ExploreProgressReward> list = new List<ExploreProgressReward>();
			while (ConfigCommon.Step(ConfigExploreProgressRewardAll.HandleId, false, ConfigExploreProgressRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigExploreProgressRewardAll.HandleId, 0, ConfigExploreProgressRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigExploreProgressRewardAll.HandleId, ConfigExploreProgressRewardAll.LogPair);
					return null;
				}
				ExploreProgressReward rootAsExploreProgressReward = ExploreProgressReward.GetRootAsExploreProgressReward(new ByteBuffer(item2));
				list.Add(rootAsExploreProgressReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("ExploreProgressRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigExploreProgressRewardAll.HandleId, ConfigExploreProgressRewardAll.LogPair);
			return list;
		}

		// Token: 0x04001298 RID: 4760
		private const string DB = "db_explore_progress.db";

		// Token: 0x04001299 RID: 4761
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x0400129A RID: 4762
		private const string TABLE = "ExploreProgressReward";

		// Token: 0x0400129B RID: 4763
		private const string COMMAND = "select BinData from `ExploreProgressReward`";

		// Token: 0x0400129C RID: 4764
		private const string KEY_PREFIX = "ExploreProgressRewardAll";

		// Token: 0x0400129D RID: 4765
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400129E RID: 4766
		private static int HandleId;
	}
}
