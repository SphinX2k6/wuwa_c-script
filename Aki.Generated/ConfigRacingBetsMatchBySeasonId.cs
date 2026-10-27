using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A5 RID: 1957
	public class ConfigRacingBetsMatchBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DF0 RID: 11760 RVA: 0x0015CE74 File Offset: 0x0015B074
		static ConfigRacingBetsMatchBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsMatchBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsMatchBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002DF1 RID: 11761 RVA: 0x0015CE94 File Offset: 0x0015B094
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsMatchBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsMatchBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsMatch"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsMatch` where SeasonId=?")
			});
		}

		// Token: 0x06002DF2 RID: 11762 RVA: 0x0015CF13 File Offset: 0x0015B113
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsMatchBySeasonId.LogPair = null;
			ConfigRacingBetsMatchBySeasonId.HandleId = 0;
		}

		// Token: 0x06002DF3 RID: 11763 RVA: 0x0015CF21 File Offset: 0x0015B121
		public static void Init()
		{
			ConfigRacingBetsMatchBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsMatchBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsMatch` where SeasonId=?");
		}

		// Token: 0x06002DF4 RID: 11764 RVA: 0x0015CF3C File Offset: 0x0015B13C
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetsMatch> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsMatchBySeasonId.HandleId, ConfigRacingBetsMatchBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsMatchBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetsMatch> readOnlyList = (IReadOnlyList<RacingBetsMatch>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetsMatchBySeasonId.LogPair.Clear();
			ConfigRacingBetsMatchBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetsMatchBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetsMatchBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetsMatchBySeasonId.HandleId, ConfigRacingBetsMatchBySeasonId.LogPair);
				return null;
			}
			List<RacingBetsMatch> list = new List<RacingBetsMatch>();
			while (ConfigCommon.Step(ConfigRacingBetsMatchBySeasonId.HandleId, false, ConfigRacingBetsMatchBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsMatchBySeasonId.HandleId, 0, ConfigRacingBetsMatchBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetsMatchBySeasonId.HandleId, ConfigRacingBetsMatchBySeasonId.LogPair);
					return null;
				}
				RacingBetsMatch rootAsRacingBetsMatch = RacingBetsMatch.GetRootAsRacingBetsMatch(new ByteBuffer(item2));
				list.Add(rootAsRacingBetsMatch);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsMatchBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetsMatchBySeasonId.HandleId, ConfigRacingBetsMatchBySeasonId.LogPair);
			return list;
		}

		// Token: 0x04003569 RID: 13673
		private const string DB = "db_racingbets.db";

		// Token: 0x0400356A RID: 13674
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400356B RID: 13675
		private const string TABLE = "RacingBetsMatch";

		// Token: 0x0400356C RID: 13676
		private const string COMMAND = "select BinData from `RacingBetsMatch` where SeasonId=?";

		// Token: 0x0400356D RID: 13677
		private const string KEY_PREFIX = "RacingBetsMatchBySeasonId";

		// Token: 0x0400356E RID: 13678
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400356F RID: 13679
		private static int HandleId;
	}
}
