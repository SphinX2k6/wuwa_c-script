using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AD RID: 1965
	public class ConfigRacingBettingGearBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E20 RID: 11808 RVA: 0x0015E084 File Offset: 0x0015C284
		static ConfigRacingBettingGearBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBettingGearBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBettingGearBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E21 RID: 11809 RVA: 0x0015E0A4 File Offset: 0x0015C2A4
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBettingGearBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBettingGearBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBettingGear"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBettingGear` where SeasonId=?")
			});
		}

		// Token: 0x06002E22 RID: 11810 RVA: 0x0015E123 File Offset: 0x0015C323
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBettingGearBySeasonId.LogPair = null;
			ConfigRacingBettingGearBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E23 RID: 11811 RVA: 0x0015E131 File Offset: 0x0015C331
		public static void Init()
		{
			ConfigRacingBettingGearBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBettingGearBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBettingGear` where SeasonId=?");
		}

		// Token: 0x06002E24 RID: 11812 RVA: 0x0015E14C File Offset: 0x0015C34C
		[NullableContext(2)]
		public static IReadOnlyList<RacingBettingGear> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBettingGearBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBettingGear> readOnlyList = (IReadOnlyList<RacingBettingGear>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBettingGearBySeasonId.LogPair.Clear();
			ConfigRacingBettingGearBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBettingGearBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBettingGearBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair);
				return null;
			}
			List<RacingBettingGear> list = new List<RacingBettingGear>();
			while (ConfigCommon.Step(ConfigRacingBettingGearBySeasonId.HandleId, false, ConfigRacingBettingGearBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBettingGearBySeasonId.HandleId, 0, ConfigRacingBettingGearBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair);
					return null;
				}
				RacingBettingGear rootAsRacingBettingGear = RacingBettingGear.GetRootAsRacingBettingGear(new ByteBuffer(item2));
				list.Add(rootAsRacingBettingGear);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBettingGearBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBettingGearBySeasonId.HandleId, ConfigRacingBettingGearBySeasonId.LogPair);
			return list;
		}

		// Token: 0x040035A1 RID: 13729
		private const string DB = "db_racingbets.db";

		// Token: 0x040035A2 RID: 13730
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035A3 RID: 13731
		private const string TABLE = "RacingBettingGear";

		// Token: 0x040035A4 RID: 13732
		private const string COMMAND = "select BinData from `RacingBettingGear` where SeasonId=?";

		// Token: 0x040035A5 RID: 13733
		private const string KEY_PREFIX = "RacingBettingGearBySeasonId";

		// Token: 0x040035A6 RID: 13734
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035A7 RID: 13735
		private static int HandleId;
	}
}
