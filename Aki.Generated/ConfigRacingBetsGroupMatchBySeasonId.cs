using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BB RID: 1979
	public class ConfigRacingBetsGroupMatchBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E74 RID: 11892 RVA: 0x00163480 File Offset: 0x00161680
		static ConfigRacingBetsGroupMatchBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsGroupMatchBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsGroupMatchBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x001634A0 File Offset: 0x001616A0
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

		// Token: 0x06002E76 RID: 11894 RVA: 0x0016351F File Offset: 0x0016171F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsGroupMatchBySeasonId.LogPair = null;
			ConfigRacingBetsGroupMatchBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x0016352D File Offset: 0x0016172D
		public static void Init()
		{
			ConfigRacingBetsGroupMatchBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsGroupMatchBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsGroupMatch` where SeasonId=?");
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x00163548 File Offset: 0x00161748
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

		// Token: 0x04003603 RID: 13827
		private const string DB = "db_racingbets.db";

		// Token: 0x04003604 RID: 13828
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003605 RID: 13829
		private const string TABLE = "RacingBetsGroupMatch";

		// Token: 0x04003606 RID: 13830
		private const string COMMAND = "select BinData from `RacingBetsGroupMatch` where SeasonId=?";

		// Token: 0x04003607 RID: 13831
		private const string KEY_PREFIX = "RacingBetsGroupMatchBySeasonId";

		// Token: 0x04003608 RID: 13832
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003609 RID: 13833
		private static int HandleId;
	}
}
