using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000298 RID: 664
	public class ConfigExploreProgressRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000F95 RID: 3989 RVA: 0x000B1A20 File Offset: 0x000AFC20
		static ConfigExploreProgressRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigExploreProgressRewardAll.CreateStaticDefaultValue), new Action(ConfigExploreProgressRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000B1A40 File Offset: 0x000AFC40
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

		// Token: 0x06000F97 RID: 3991 RVA: 0x000B1ABF File Offset: 0x000AFCBF
		public static void ResetStaticDefaultValue()
		{
			ConfigExploreProgressRewardAll.LogPair = null;
			ConfigExploreProgressRewardAll.HandleId = 0;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x000B1ACD File Offset: 0x000AFCCD
		public static void Init()
		{
			ConfigExploreProgressRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigExploreProgressRewardAll.HandleId, "db_explore_progress.db", "select BinData from `ExploreProgressReward`");
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000B1AE8 File Offset: 0x000AFCE8
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

		// Token: 0x0400120C RID: 4620
		private const string DB = "db_explore_progress.db";

		// Token: 0x0400120D RID: 4621
		private const string FILE = "t.探索度.xlsx";

		// Token: 0x0400120E RID: 4622
		private const string TABLE = "ExploreProgressReward";

		// Token: 0x0400120F RID: 4623
		private const string COMMAND = "select BinData from `ExploreProgressReward`";

		// Token: 0x04001210 RID: 4624
		private const string KEY_PREFIX = "ExploreProgressRewardAll";

		// Token: 0x04001211 RID: 4625
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001212 RID: 4626
		private static int HandleId;
	}
}
