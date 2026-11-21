using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BF RID: 1983
	public class ConfigRacingBetsMatchBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E8C RID: 11916 RVA: 0x00163D80 File Offset: 0x00161F80
		static ConfigRacingBetsMatchBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsMatchBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsMatchBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00163DA0 File Offset: 0x00161FA0
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

		// Token: 0x06002E8E RID: 11918 RVA: 0x00163E1F File Offset: 0x0016201F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsMatchBySeasonId.LogPair = null;
			ConfigRacingBetsMatchBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00163E2D File Offset: 0x0016202D
		public static void Init()
		{
			ConfigRacingBetsMatchBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsMatchBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsMatch` where SeasonId=?");
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00163E48 File Offset: 0x00162048
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

		// Token: 0x0400361F RID: 13855
		private const string DB = "db_racingbets.db";

		// Token: 0x04003620 RID: 13856
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003621 RID: 13857
		private const string TABLE = "RacingBetsMatch";

		// Token: 0x04003622 RID: 13858
		private const string COMMAND = "select BinData from `RacingBetsMatch` where SeasonId=?";

		// Token: 0x04003623 RID: 13859
		private const string KEY_PREFIX = "RacingBetsMatchBySeasonId";

		// Token: 0x04003624 RID: 13860
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003625 RID: 13861
		private static int HandleId;
	}
}
