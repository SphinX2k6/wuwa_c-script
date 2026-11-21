using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BD RID: 1981
	public class ConfigRacingBetsLegMatchesByMatchId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E80 RID: 11904 RVA: 0x00163900 File Offset: 0x00161B00
		static ConfigRacingBetsLegMatchesByMatchId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsLegMatchesByMatchId.CreateStaticDefaultValue), new Action(ConfigRacingBetsLegMatchesByMatchId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00163920 File Offset: 0x00161B20
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

		// Token: 0x06002E82 RID: 11906 RVA: 0x0016399F File Offset: 0x00161B9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsLegMatchesByMatchId.LogPair = null;
			ConfigRacingBetsLegMatchesByMatchId.HandleId = 0;
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x001639AD File Offset: 0x00161BAD
		public static void Init()
		{
			ConfigRacingBetsLegMatchesByMatchId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsLegMatchesByMatchId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsLegMatches` where MatchId=?");
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x001639C8 File Offset: 0x00161BC8
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

		// Token: 0x04003611 RID: 13841
		private const string DB = "db_racingbets.db";

		// Token: 0x04003612 RID: 13842
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003613 RID: 13843
		private const string TABLE = "RacingBetsLegMatches";

		// Token: 0x04003614 RID: 13844
		private const string COMMAND = "select BinData from `RacingBetsLegMatches` where MatchId=?";

		// Token: 0x04003615 RID: 13845
		private const string KEY_PREFIX = "RacingBetsLegMatchesByMatchId";

		// Token: 0x04003616 RID: 13846
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003617 RID: 13847
		private static int HandleId;
	}
}
