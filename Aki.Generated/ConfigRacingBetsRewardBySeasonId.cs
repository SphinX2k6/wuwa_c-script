using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C2 RID: 1986
	public class ConfigRacingBetsRewardBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E9E RID: 11934 RVA: 0x00164448 File Offset: 0x00162648
		static ConfigRacingBetsRewardBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRewardBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsRewardBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00164468 File Offset: 0x00162668
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

		// Token: 0x06002EA0 RID: 11936 RVA: 0x001644E7 File Offset: 0x001626E7
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRewardBySeasonId.LogPair = null;
			ConfigRacingBetsRewardBySeasonId.HandleId = 0;
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x001644F5 File Offset: 0x001626F5
		public static void Init()
		{
			ConfigRacingBetsRewardBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRewardBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsReward` where SeasonId=?");
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00164510 File Offset: 0x00162710
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

		// Token: 0x04003634 RID: 13876
		private const string DB = "db_racingbets.db";

		// Token: 0x04003635 RID: 13877
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003636 RID: 13878
		private const string TABLE = "RacingBetsReward";

		// Token: 0x04003637 RID: 13879
		private const string COMMAND = "select BinData from `RacingBetsReward` where SeasonId=?";

		// Token: 0x04003638 RID: 13880
		private const string KEY_PREFIX = "RacingBetsRewardBySeasonId";

		// Token: 0x04003639 RID: 13881
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400363A RID: 13882
		private static int HandleId;
	}
}
