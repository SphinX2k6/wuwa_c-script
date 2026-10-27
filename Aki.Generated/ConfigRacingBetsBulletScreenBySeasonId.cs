using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079F RID: 1951
	public class ConfigRacingBetsBulletScreenBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DCC RID: 11724 RVA: 0x0015C0F4 File Offset: 0x0015A2F4
		static ConfigRacingBetsBulletScreenBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsBulletScreenBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsBulletScreenBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002DCD RID: 11725 RVA: 0x0015C114 File Offset: 0x0015A314
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsBulletScreenBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsBulletScreenBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsBulletScreen"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsBulletScreen` where SeasonId=?")
			});
		}

		// Token: 0x06002DCE RID: 11726 RVA: 0x0015C193 File Offset: 0x0015A393
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsBulletScreenBySeasonId.LogPair = null;
			ConfigRacingBetsBulletScreenBySeasonId.HandleId = 0;
		}

		// Token: 0x06002DCF RID: 11727 RVA: 0x0015C1A1 File Offset: 0x0015A3A1
		public static void Init()
		{
			ConfigRacingBetsBulletScreenBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsBulletScreenBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsBulletScreen` where SeasonId=?");
		}

		// Token: 0x06002DD0 RID: 11728 RVA: 0x0015C1BC File Offset: 0x0015A3BC
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetsBulletScreen> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsBulletScreenBySeasonId.HandleId, ConfigRacingBetsBulletScreenBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsBulletScreenBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetsBulletScreen> readOnlyList = (IReadOnlyList<RacingBetsBulletScreen>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetsBulletScreenBySeasonId.LogPair.Clear();
			ConfigRacingBetsBulletScreenBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetsBulletScreenBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetsBulletScreenBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetsBulletScreenBySeasonId.HandleId, ConfigRacingBetsBulletScreenBySeasonId.LogPair);
				return null;
			}
			List<RacingBetsBulletScreen> list = new List<RacingBetsBulletScreen>();
			while (ConfigCommon.Step(ConfigRacingBetsBulletScreenBySeasonId.HandleId, false, ConfigRacingBetsBulletScreenBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsBulletScreenBySeasonId.HandleId, 0, ConfigRacingBetsBulletScreenBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetsBulletScreenBySeasonId.HandleId, ConfigRacingBetsBulletScreenBySeasonId.LogPair);
					return null;
				}
				RacingBetsBulletScreen rootAsRacingBetsBulletScreen = RacingBetsBulletScreen.GetRootAsRacingBetsBulletScreen(new ByteBuffer(item2));
				list.Add(rootAsRacingBetsBulletScreen);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsBulletScreenBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetsBulletScreenBySeasonId.HandleId, ConfigRacingBetsBulletScreenBySeasonId.LogPair);
			return list;
		}

		// Token: 0x0400353F RID: 13631
		private const string DB = "db_racingbets.db";

		// Token: 0x04003540 RID: 13632
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003541 RID: 13633
		private const string TABLE = "RacingBetsBulletScreen";

		// Token: 0x04003542 RID: 13634
		private const string COMMAND = "select BinData from `RacingBetsBulletScreen` where SeasonId=?";

		// Token: 0x04003543 RID: 13635
		private const string KEY_PREFIX = "RacingBetsBulletScreenBySeasonId";

		// Token: 0x04003544 RID: 13636
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003545 RID: 13637
		private static int HandleId;
	}
}
