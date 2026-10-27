using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079C RID: 1948
	public class ConfigRacingBetMapPointBySeasonId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DBA RID: 11706 RVA: 0x0015BA2C File Offset: 0x00159C2C
		static ConfigRacingBetMapPointBySeasonId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetMapPointBySeasonId.CreateStaticDefaultValue), new Action(ConfigRacingBetMapPointBySeasonId.ResetStaticDefaultValue));
		}

		// Token: 0x06002DBB RID: 11707 RVA: 0x0015BA4C File Offset: 0x00159C4C
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

		// Token: 0x06002DBC RID: 11708 RVA: 0x0015BACB File Offset: 0x00159CCB
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetMapPointBySeasonId.LogPair = null;
			ConfigRacingBetMapPointBySeasonId.HandleId = 0;
		}

		// Token: 0x06002DBD RID: 11709 RVA: 0x0015BAD9 File Offset: 0x00159CD9
		public static void Init()
		{
			ConfigRacingBetMapPointBySeasonId.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetMapPointBySeasonId.HandleId, "db_racingbets.db", "select BinData from `RacingBetMapPoint` where SeasonId=?");
		}

		// Token: 0x06002DBE RID: 11710 RVA: 0x0015BAF4 File Offset: 0x00159CF4
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

		// Token: 0x0400352A RID: 13610
		private const string DB = "db_racingbets.db";

		// Token: 0x0400352B RID: 13611
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400352C RID: 13612
		private const string TABLE = "RacingBetMapPoint";

		// Token: 0x0400352D RID: 13613
		private const string COMMAND = "select BinData from `RacingBetMapPoint` where SeasonId=?";

		// Token: 0x0400352E RID: 13614
		private const string KEY_PREFIX = "RacingBetMapPointBySeasonId";

		// Token: 0x0400352F RID: 13615
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003530 RID: 13616
		private static int HandleId;
	}
}
