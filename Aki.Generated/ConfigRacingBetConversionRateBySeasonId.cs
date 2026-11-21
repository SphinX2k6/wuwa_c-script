using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B4 RID: 1972
	public class ConfigRacingBetConversionRateBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E4A RID: 11850 RVA: 0x001624B8 File Offset: 0x001606B8
		static ConfigRacingBetConversionRateBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetConversionRateBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetConversionRateBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x001624D8 File Offset: 0x001606D8
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

		// Token: 0x06002E4C RID: 11852 RVA: 0x00162557 File Offset: 0x00160757
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetConversionRateBySeasonId.LogPair = null;
			ConfigRacingBetConversionRateBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x00162565 File Offset: 0x00160765
		public static void Init()
		{
			ConfigRacingBetConversionRateBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetConversionRateBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetConversionRate` where SeasonId=?");
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x00162580 File Offset: 0x00160780
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

		// Token: 0x040035D2 RID: 13778
		private const string DB = "db_racingbets.db";

		// Token: 0x040035D3 RID: 13779
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035D4 RID: 13780
		private const string TABLE = "RacingBetConversionRate";

		// Token: 0x040035D5 RID: 13781
		private const string COMMAND = "select BinData from `RacingBetConversionRate` where SeasonId=?";

		// Token: 0x040035D6 RID: 13782
		private const string KEY_PREFIX = "RacingBetConversionRateBySeasonId";

		// Token: 0x040035D7 RID: 13783
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035D8 RID: 13784
		private static int HandleId;
	}
}
