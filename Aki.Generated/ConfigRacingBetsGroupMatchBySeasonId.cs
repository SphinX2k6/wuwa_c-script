using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A1 RID: 1953
	public class ConfigRacingBetsGroupMatchBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DD8 RID: 11736 RVA: 0x0015C574 File Offset: 0x0015A774
		static ConfigRacingBetsGroupMatchBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsGroupMatchBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsGroupMatchBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002DD9 RID: 11737 RVA: 0x0015C594 File Offset: 0x0015A794
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsGroupMatchBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsGroupMatchBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsGroupMatch"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsGroupMatch` where SeasonId=?")
			});
		}

		// Token: 0x06002DDA RID: 11738 RVA: 0x0015C613 File Offset: 0x0015A813
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsGroupMatchBySeasonId.LogPair = null;
			ConfigRacingBetsGroupMatchBySeasonId.HandleId = 0;
		}

		// Token: 0x06002DDB RID: 11739 RVA: 0x0015C621 File Offset: 0x0015A821
		public static void Init()
		{
			ConfigRacingBetsGroupMatchBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsGroupMatchBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsGroupMatch` where SeasonId=?");
		}

		// Token: 0x06002DDC RID: 11740 RVA: 0x0015C63C File Offset: 0x0015A83C
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetsGroupMatch> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsGroupMatchBySeasonId.HandleId, ConfigRacingBetsGroupMatchBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsGroupMatchBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetsGroupMatch> readOnlyList = (IReadOnlyList<RacingBetsGroupMatch>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetsGroupMatchBySeasonId.LogPair.Clear();
			ConfigRacingBetsGroupMatchBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetsGroupMatchBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetsGroupMatchBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetsGroupMatchBySeasonId.HandleId, ConfigRacingBetsGroupMatchBySeasonId.LogPair);
				return null;
			}
			List<RacingBetsGroupMatch> list = new List<RacingBetsGroupMatch>();
			while (ConfigCommon.Step(ConfigRacingBetsGroupMatchBySeasonId.HandleId, false, ConfigRacingBetsGroupMatchBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsGroupMatchBySeasonId.HandleId, 0, ConfigRacingBetsGroupMatchBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetsGroupMatchBySeasonId.HandleId, ConfigRacingBetsGroupMatchBySeasonId.LogPair);
					return null;
				}
				RacingBetsGroupMatch rootAsRacingBetsGroupMatch = RacingBetsGroupMatch.GetRootAsRacingBetsGroupMatch(new ByteBuffer(item2));
				list.Add(rootAsRacingBetsGroupMatch);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsGroupMatchBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetsGroupMatchBySeasonId.HandleId, ConfigRacingBetsGroupMatchBySeasonId.LogPair);
			return list;
		}

		// Token: 0x0400354D RID: 13645
		private const string DB = "db_racingbets.db";

		// Token: 0x0400354E RID: 13646
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400354F RID: 13647
		private const string TABLE = "RacingBetsGroupMatch";

		// Token: 0x04003550 RID: 13648
		private const string COMMAND = "select BinData from `RacingBetsGroupMatch` where SeasonId=?";

		// Token: 0x04003551 RID: 13649
		private const string KEY_PREFIX = "RacingBetsGroupMatchBySeasonId";

		// Token: 0x04003552 RID: 13650
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003553 RID: 13651
		private static int HandleId;
	}
}
