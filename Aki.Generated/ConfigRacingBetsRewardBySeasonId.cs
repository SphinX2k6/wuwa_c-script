using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A8 RID: 1960
	public class ConfigRacingBetsRewardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E02 RID: 11778 RVA: 0x0015D53C File Offset: 0x0015B73C
		static ConfigRacingBetsRewardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRewardBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsRewardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E03 RID: 11779 RVA: 0x0015D55C File Offset: 0x0015B75C
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsRewardBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsRewardBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsReward` where SeasonId=?")
			});
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x0015D5DB File Offset: 0x0015B7DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRewardBySeasonId.LogPair = null;
			ConfigRacingBetsRewardBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E05 RID: 11781 RVA: 0x0015D5E9 File Offset: 0x0015B7E9
		public static void Init()
		{
			ConfigRacingBetsRewardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRewardBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsReward` where SeasonId=?");
		}

		// Token: 0x06002E06 RID: 11782 RVA: 0x0015D604 File Offset: 0x0015B804
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetsReward> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsRewardBySeasonId.HandleId, ConfigRacingBetsRewardBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRewardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetsReward> readOnlyList = (IReadOnlyList<RacingBetsReward>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetsRewardBySeasonId.LogPair.Clear();
			ConfigRacingBetsRewardBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetsRewardBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetsRewardBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetsRewardBySeasonId.HandleId, ConfigRacingBetsRewardBySeasonId.LogPair);
				return null;
			}
			List<RacingBetsReward> list = new List<RacingBetsReward>();
			while (ConfigCommon.Step(ConfigRacingBetsRewardBySeasonId.HandleId, false, ConfigRacingBetsRewardBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsRewardBySeasonId.HandleId, 0, ConfigRacingBetsRewardBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetsRewardBySeasonId.HandleId, ConfigRacingBetsRewardBySeasonId.LogPair);
					return null;
				}
				RacingBetsReward rootAsRacingBetsReward = RacingBetsReward.GetRootAsRacingBetsReward(new ByteBuffer(item2));
				list.Add(rootAsRacingBetsReward);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRewardBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetsRewardBySeasonId.HandleId, ConfigRacingBetsRewardBySeasonId.LogPair);
			return list;
		}

		// Token: 0x0400357E RID: 13694
		private const string DB = "db_racingbets.db";

		// Token: 0x0400357F RID: 13695
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003580 RID: 13696
		private const string TABLE = "RacingBetsReward";

		// Token: 0x04003581 RID: 13697
		private const string COMMAND = "select BinData from `RacingBetsReward` where SeasonId=?";

		// Token: 0x04003582 RID: 13698
		private const string KEY_PREFIX = "RacingBetsRewardBySeasonId";

		// Token: 0x04003583 RID: 13699
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003584 RID: 13700
		private static int HandleId;
	}
}
