using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039C RID: 924
	public class ConfigGivebackScoreRewardAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015AF RID: 5551 RVA: 0x000D4388 File Offset: 0x000D2588
		static ConfigGivebackScoreRewardAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackScoreRewardAll.CreateStaticDefaultValue), new Action(ConfigGivebackScoreRewardAll.ResetStaticDefaultValue));
		}

		// Token: 0x060015B0 RID: 5552 RVA: 0x000D43A8 File Offset: 0x000D25A8
		public static void CreateStaticDefaultValue()
		{
			ConfigGivebackScoreRewardAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGivebackScoreRewardAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedbackreward.db"),
				new ValueTuple<string, object>("文件", "l.老玩家回馈.xlsx"),
				new ValueTuple<string, object>("表名", "GivebackScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `GivebackScoreReward`")
			});
		}

		// Token: 0x060015B1 RID: 5553 RVA: 0x000D4427 File Offset: 0x000D2627
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackScoreRewardAll.LogPair = null;
			ConfigGivebackScoreRewardAll.HandleId = 0;
		}

		// Token: 0x060015B2 RID: 5554 RVA: 0x000D4435 File Offset: 0x000D2635
		public static void Init()
		{
			ConfigGivebackScoreRewardAll.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackScoreRewardAll.HandleId, "db_feedbackreward.db", "select BinData from `GivebackScoreReward`");
		}

		// Token: 0x060015B3 RID: 5555 RVA: 0x000D4450 File Offset: 0x000D2650
		[NullableContext(2)]
		public static IReadOnlyList<GivebackScoreReward> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGivebackScoreRewardAll.HandleId, ConfigGivebackScoreRewardAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GivebackScoreReward> readOnlyList = (IReadOnlyList<GivebackScoreReward>)ConfigCommon.GetConfig("GivebackScoreRewardAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GivebackScoreReward> list = new List<GivebackScoreReward>();
			while (ConfigCommon.Step(ConfigGivebackScoreRewardAll.HandleId, false, ConfigGivebackScoreRewardAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGivebackScoreRewardAll.HandleId, 0, ConfigGivebackScoreRewardAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGivebackScoreRewardAll.HandleId, ConfigGivebackScoreRewardAll.LogPair);
					return null;
				}
				GivebackScoreReward rootAsGivebackScoreReward = GivebackScoreReward.GetRootAsGivebackScoreReward(new ByteBuffer(item2));
				list.Add(rootAsGivebackScoreReward);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GivebackScoreRewardAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGivebackScoreRewardAll.HandleId, ConfigGivebackScoreRewardAll.LogPair);
			return list;
		}

		// Token: 0x04001928 RID: 6440
		private const string DB = "db_feedbackreward.db";

		// Token: 0x04001929 RID: 6441
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x0400192A RID: 6442
		private const string TABLE = "GivebackScoreReward";

		// Token: 0x0400192B RID: 6443
		private const string COMMAND = "select BinData from `GivebackScoreReward`";

		// Token: 0x0400192C RID: 6444
		private const string KEY_PREFIX = "GivebackScoreRewardAll";

		// Token: 0x0400192D RID: 6445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400192E RID: 6446
		private static int HandleId;
	}
}
