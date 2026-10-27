using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C9 RID: 1993
	public class ConfigRegressBonusRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EC8 RID: 11976 RVA: 0x00161B4B File Offset: 0x0015FD4B
		static ConfigRegressBonusRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRegressBonusRewardAll.CreateStaticDefaultValue), new Action(ConfigRegressBonusRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x06002EC9 RID: 11977 RVA: 0x00161B6C File Offset: 0x0015FD6C
		public static void CreateStaticDefaultValue()
		{
			ConfigRegressBonusRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRegressBonusRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_regressactivity.db"),
				new ValueTuple<string, object>("文件", "h.回流活动(新).xlsx"),
				new ValueTuple<string, object>("表名", "RegressBonusReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RegressBonusReward`")
			});
		}

		// Token: 0x06002ECA RID: 11978 RVA: 0x00161BEB File Offset: 0x0015FDEB
		public static void ResetStaticDefaultValue()
		{
			ConfigRegressBonusRewardAll.LogPair = null;
			ConfigRegressBonusRewardAll.HandleId = 0;
		}

		// Token: 0x06002ECB RID: 11979 RVA: 0x00161BF9 File Offset: 0x0015FDF9
		public static void Init()
		{
			ConfigRegressBonusRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigRegressBonusRewardAll.HandleId, "db_regressactivity.db", "select BinData from `RegressBonusReward`");
		}

		// Token: 0x06002ECC RID: 11980 RVA: 0x00161C14 File Offset: 0x0015FE14
		[NullableContext(2)]
		public static IReadOnlyList<RegressBonusReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRegressBonusRewardAll.HandleId, ConfigRegressBonusRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<RegressBonusReward> readOnlyList = (IReadOnlyList<RegressBonusReward>)ConfigCommon.GetConfig("RegressBonusRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<RegressBonusReward> list = new List<RegressBonusReward>();
			while (ConfigCommon.Step(ConfigRegressBonusRewardAll.HandleId, false, ConfigRegressBonusRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRegressBonusRewardAll.HandleId, 0, ConfigRegressBonusRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRegressBonusRewardAll.HandleId, ConfigRegressBonusRewardAll.LogPair);
					return null;
				}
				RegressBonusReward rootAsRegressBonusReward = RegressBonusReward.GetRootAsRegressBonusReward(new ByteBuffer(item2));
				list.Add(rootAsRegressBonusReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("RegressBonusRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigRegressBonusRewardAll.HandleId, ConfigRegressBonusRewardAll.LogPair);
			return list;
		}

		// Token: 0x04003665 RID: 13925
		private const string DB = "db_regressactivity.db";

		// Token: 0x04003666 RID: 13926
		private const string FILE = "h.回流活动(新).xlsx";

		// Token: 0x04003667 RID: 13927
		private const string TABLE = "RegressBonusReward";

		// Token: 0x04003668 RID: 13928
		private const string COMMAND = "select BinData from `RegressBonusReward`";

		// Token: 0x04003669 RID: 13929
		private const string KEY_PREFIX = "RegressBonusRewardAll";

		// Token: 0x0400366A RID: 13930
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400366B RID: 13931
		private static int HandleId;
	}
}
