using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B9 RID: 1977
	public class ConfigRacingBetsBulletScreenBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E68 RID: 11880 RVA: 0x00163000 File Offset: 0x00161200
		static ConfigRacingBetsBulletScreenBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsBulletScreenBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetsBulletScreenBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00163020 File Offset: 0x00161220
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

		// Token: 0x06002E6A RID: 11882 RVA: 0x0016309F File Offset: 0x0016129F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsBulletScreenBySeasonId.LogPair = null;
			ConfigRacingBetsBulletScreenBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x001630AD File Offset: 0x001612AD
		public static void Init()
		{
			ConfigRacingBetsBulletScreenBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsBulletScreenBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetsBulletScreen` where SeasonId=?");
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x001630C8 File Offset: 0x001612C8
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

		// Token: 0x040035F5 RID: 13813
		private const string DB = "db_racingbets.db";

		// Token: 0x040035F6 RID: 13814
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035F7 RID: 13815
		private const string TABLE = "RacingBetsBulletScreen";

		// Token: 0x040035F8 RID: 13816
		private const string COMMAND = "select BinData from `RacingBetsBulletScreen` where SeasonId=?";

		// Token: 0x040035F9 RID: 13817
		private const string KEY_PREFIX = "RacingBetsBulletScreenBySeasonId";

		// Token: 0x040035FA RID: 13818
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035FB RID: 13819
		private static int HandleId;
	}
}
