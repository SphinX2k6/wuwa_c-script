using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A3 RID: 1955
	public class ConfigRacingBetsLegMatchesByMatchId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DE4 RID: 11748 RVA: 0x0015C9F4 File Offset: 0x0015ABF4
		static ConfigRacingBetsLegMatchesByMatchId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsLegMatchesByMatchId.CreateStaticDefaultValue), new Action(ConfigRacingBetsLegMatchesByMatchId.ResetStaticDefaultValue));
		}

		// Token: 0x06002DE5 RID: 11749 RVA: 0x0015CA14 File Offset: 0x0015AC14
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsLegMatchesByMatchId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsLegMatchesByMatchId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsLegMatches"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsLegMatches` where MatchId=?")
			});
		}

		// Token: 0x06002DE6 RID: 11750 RVA: 0x0015CA93 File Offset: 0x0015AC93
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsLegMatchesByMatchId.LogPair = null;
			ConfigRacingBetsLegMatchesByMatchId.HandleId = 0;
		}

		// Token: 0x06002DE7 RID: 11751 RVA: 0x0015CAA1 File Offset: 0x0015ACA1
		public static void Init()
		{
			ConfigRacingBetsLegMatchesByMatchId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsLegMatchesByMatchId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsLegMatches` where MatchId=?");
		}

		// Token: 0x06002DE8 RID: 11752 RVA: 0x0015CABC File Offset: 0x0015ACBC
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetsLegMatches> GetConfigList(int p0MatchId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsLegMatchesByMatchId.HandleId, ConfigRacingBetsLegMatchesByMatchId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsLegMatchesByMatchId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MatchId);
				IReadOnlyList<RacingBetsLegMatches> readOnlyList = (IReadOnlyList<RacingBetsLegMatches>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetsLegMatchesByMatchId.LogPair.Clear();
			ConfigRacingBetsLegMatchesByMatchId.LogPair.Add(new ValueTuple<string, object>("MatchId", p0MatchId));
			if (!ConfigCommon.BindInt(ConfigRacingBetsLegMatchesByMatchId.HandleId, 1, p0MatchId, ConfigRacingBetsLegMatchesByMatchId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetsLegMatchesByMatchId.HandleId, ConfigRacingBetsLegMatchesByMatchId.LogPair);
				return null;
			}
			List<RacingBetsLegMatches> list = new List<RacingBetsLegMatches>();
			while (ConfigCommon.Step(ConfigRacingBetsLegMatchesByMatchId.HandleId, false, ConfigRacingBetsLegMatchesByMatchId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsLegMatchesByMatchId.HandleId, 0, ConfigRacingBetsLegMatchesByMatchId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetsLegMatchesByMatchId.HandleId, ConfigRacingBetsLegMatchesByMatchId.LogPair);
					return null;
				}
				RacingBetsLegMatches rootAsRacingBetsLegMatches = RacingBetsLegMatches.GetRootAsRacingBetsLegMatches(new ByteBuffer(item2));
				list.Add(rootAsRacingBetsLegMatches);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsLegMatchesByMatchId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0MatchId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetsLegMatchesByMatchId.HandleId, ConfigRacingBetsLegMatchesByMatchId.LogPair);
			return list;
		}

		// Token: 0x0400355B RID: 13659
		private const string DB = "db_racingbets.db";

		// Token: 0x0400355C RID: 13660
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400355D RID: 13661
		private const string TABLE = "RacingBetsLegMatches";

		// Token: 0x0400355E RID: 13662
		private const string COMMAND = "select BinData from `RacingBetsLegMatches` where MatchId=?";

		// Token: 0x0400355F RID: 13663
		private const string KEY_PREFIX = "RacingBetsLegMatchesByMatchId";

		// Token: 0x04003560 RID: 13664
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003561 RID: 13665
		private static int HandleId;
	}
}
