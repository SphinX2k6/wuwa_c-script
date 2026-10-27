using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200043C RID: 1084
	public class ConfigInfrV2ScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001972 RID: 6514 RVA: 0x000E9670 File Offset: 0x000E7870
		static ConfigInfrV2ScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigInfrV2ScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigInfrV2ScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x000E9690 File Offset: 0x000E7890
		public static void CreateStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigInfrV2ScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_villageinfr.db"),
				new ValueTuple<string, object>("文件", "j.基建V2.xlsx"),
				new ValueTuple<string, object>("表名", "InfrV2ScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `InfrV2ScoreReward`")
			});
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x000E970F File Offset: 0x000E790F
		public static void ResetStaticDefaultValue()
		{
			ConfigInfrV2ScoreRewardAll.LogPair = null;
			ConfigInfrV2ScoreRewardAll.HandleId = 0;
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x000E971D File Offset: 0x000E791D
		public static void Init()
		{
			ConfigInfrV2ScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigInfrV2ScoreRewardAll.HandleId, "db_villageinfr.db", "select BinData from `InfrV2ScoreReward`");
		}

		// Token: 0x06001976 RID: 6518 RVA: 0x000E9738 File Offset: 0x000E7938
		[NullableContext(2)]
		public static IReadOnlyList<InfrV2ScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigInfrV2ScoreRewardAll.HandleId, ConfigInfrV2ScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<InfrV2ScoreReward> readOnlyList = (IReadOnlyList<InfrV2ScoreReward>)ConfigCommon.GetConfig("InfrV2ScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<InfrV2ScoreReward> list = new List<InfrV2ScoreReward>();
			while (ConfigCommon.Step(ConfigInfrV2ScoreRewardAll.HandleId, false, ConfigInfrV2ScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigInfrV2ScoreRewardAll.HandleId, 0, ConfigInfrV2ScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigInfrV2ScoreRewardAll.HandleId, ConfigInfrV2ScoreRewardAll.LogPair);
					return null;
				}
				InfrV2ScoreReward rootAsInfrV2ScoreReward = InfrV2ScoreReward.GetRootAsInfrV2ScoreReward(new ByteBuffer(item2));
				list.Add(rootAsInfrV2ScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("InfrV2ScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigInfrV2ScoreRewardAll.HandleId, ConfigInfrV2ScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04001D88 RID: 7560
		private const string DB = "db_villageinfr.db";

		// Token: 0x04001D89 RID: 7561
		private const string FILE = "j.基建V2.xlsx";

		// Token: 0x04001D8A RID: 7562
		private const string TABLE = "InfrV2ScoreReward";

		// Token: 0x04001D8B RID: 7563
		private const string COMMAND = "select BinData from `InfrV2ScoreReward`";

		// Token: 0x04001D8C RID: 7564
		private const string KEY_PREFIX = "InfrV2ScoreRewardAll";

		// Token: 0x04001D8D RID: 7565
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D8E RID: 7566
		private static int HandleId;
	}
}
