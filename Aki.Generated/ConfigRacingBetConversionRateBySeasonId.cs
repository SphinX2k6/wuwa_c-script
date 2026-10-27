using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079A RID: 1946
	public class ConfigRacingBetConversionRateBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DAE RID: 11694 RVA: 0x0015B5AC File Offset: 0x001597AC
		static ConfigRacingBetConversionRateBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetConversionRateBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetConversionRateBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x0015B5CC File Offset: 0x001597CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetConversionRateBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetConversionRateBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetConversionRate"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetConversionRate` where SeasonId=?")
			});
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x0015B64B File Offset: 0x0015984B
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetConversionRateBySeasonId.LogPair = null;
			ConfigRacingBetConversionRateBySeasonId.HandleId = 0;
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x0015B659 File Offset: 0x00159859
		public static void Init()
		{
			ConfigRacingBetConversionRateBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetConversionRateBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetConversionRate` where SeasonId=?");
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x0015B674 File Offset: 0x00159874
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetConversionRate> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetConversionRateBySeasonId.HandleId, ConfigRacingBetConversionRateBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetConversionRateBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetConversionRate> readOnlyList = (IReadOnlyList<RacingBetConversionRate>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetConversionRateBySeasonId.LogPair.Clear();
			ConfigRacingBetConversionRateBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetConversionRateBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetConversionRateBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetConversionRateBySeasonId.HandleId, ConfigRacingBetConversionRateBySeasonId.LogPair);
				return null;
			}
			List<RacingBetConversionRate> list = new List<RacingBetConversionRate>();
			while (ConfigCommon.Step(ConfigRacingBetConversionRateBySeasonId.HandleId, false, ConfigRacingBetConversionRateBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetConversionRateBySeasonId.HandleId, 0, ConfigRacingBetConversionRateBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetConversionRateBySeasonId.HandleId, ConfigRacingBetConversionRateBySeasonId.LogPair);
					return null;
				}
				RacingBetConversionRate rootAsRacingBetConversionRate = RacingBetConversionRate.GetRootAsRacingBetConversionRate(new ByteBuffer(item2));
				list.Add(rootAsRacingBetConversionRate);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetConversionRateBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetConversionRateBySeasonId.HandleId, ConfigRacingBetConversionRateBySeasonId.LogPair);
			return list;
		}

		// Token: 0x0400351C RID: 13596
		private const string DB = "db_racingbets.db";

		// Token: 0x0400351D RID: 13597
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400351E RID: 13598
		private const string TABLE = "RacingBetConversionRate";

		// Token: 0x0400351F RID: 13599
		private const string COMMAND = "select BinData from `RacingBetConversionRate` where SeasonId=?";

		// Token: 0x04003520 RID: 13600
		private const string KEY_PREFIX = "RacingBetConversionRateBySeasonId";

		// Token: 0x04003521 RID: 13601
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003522 RID: 13602
		private static int HandleId;
	}
}
