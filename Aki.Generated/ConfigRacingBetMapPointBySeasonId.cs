using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B6 RID: 1974
	public class ConfigRacingBetMapPointBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E56 RID: 11862 RVA: 0x00162938 File Offset: 0x00160B38
		static ConfigRacingBetMapPointBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetMapPointBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetMapPointBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x00162958 File Offset: 0x00160B58
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetMapPointBySeasonId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetMapPointBySeasonId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetMapPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetMapPoint` where SeasonId=?")
			});
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x001629D7 File Offset: 0x00160BD7
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetMapPointBySeasonId.LogPair = null;
			ConfigRacingBetMapPointBySeasonId.HandleId = 0;
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x001629E5 File Offset: 0x00160BE5
		public static void Init()
		{
			ConfigRacingBetMapPointBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetMapPointBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetMapPoint` where SeasonId=?");
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x00162A00 File Offset: 0x00160C00
		[NullableContext(2)]
		public static IReadOnlyList<RacingBetMapPoint> GetConfigList(int p0SeasonId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetMapPointBySeasonId.HandleId, ConfigRacingBetMapPointBySeasonId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetMapPointBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				IReadOnlyList<RacingBetMapPoint> readOnlyList = (IReadOnlyList<RacingBetMapPoint>)ConfigCommon.GetConfig(defaultInterpolatedStringHandler.ToStringAndClear());
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			ConfigRacingBetMapPointBySeasonId.LogPair.Clear();
			ConfigRacingBetMapPointBySeasonId.LogPair.Add(new ValueTuple<string, object>("SeasonId", p0SeasonId));
			if (!ConfigCommon.BindInt(ConfigRacingBetMapPointBySeasonId.HandleId, 1, p0SeasonId, ConfigRacingBetMapPointBySeasonId.LogPair))
			{
				ConfigCommon.Reset(ConfigRacingBetMapPointBySeasonId.HandleId, ConfigRacingBetMapPointBySeasonId.LogPair);
				return null;
			}
			List<RacingBetMapPoint> list = new List<RacingBetMapPoint>();
			while (ConfigCommon.Step(ConfigRacingBetMapPointBySeasonId.HandleId, false, ConfigRacingBetMapPointBySeasonId.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetMapPointBySeasonId.HandleId, 0, ConfigRacingBetMapPointBySeasonId.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigRacingBetMapPointBySeasonId.HandleId, ConfigRacingBetMapPointBySeasonId.LogPair);
					return null;
				}
				RacingBetMapPoint rootAsRacingBetMapPoint = RacingBetMapPoint.GetRootAsRacingBetMapPoint(new ByteBuffer(item2));
				list.Add(rootAsRacingBetMapPoint);
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetMapPointBySeasonId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0SeasonId);
				ConfigCommon.SaveConfig(defaultInterpolatedStringHandler.ToStringAndClear(), list, list.Count);
			}
			ConfigCommon.Reset(ConfigRacingBetMapPointBySeasonId.HandleId, ConfigRacingBetMapPointBySeasonId.LogPair);
			return list;
		}

		// Token: 0x040035E0 RID: 13792
		private const string DB = "db_racingbets.db";

		// Token: 0x040035E1 RID: 13793
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035E2 RID: 13794
		private const string TABLE = "RacingBetMapPoint";

		// Token: 0x040035E3 RID: 13795
		private const string COMMAND = "select BinData from `RacingBetMapPoint` where SeasonId=?";

		// Token: 0x040035E4 RID: 13796
		private const string KEY_PREFIX = "RacingBetMapPointBySeasonId";

		// Token: 0x040035E5 RID: 13797
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035E6 RID: 13798
		private static int HandleId;
	}
}
