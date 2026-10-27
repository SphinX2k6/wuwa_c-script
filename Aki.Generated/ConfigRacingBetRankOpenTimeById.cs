using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079D RID: 1949
	public class ConfigRacingBetRankOpenTimeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DC0 RID: 11712 RVA: 0x0015BC63 File Offset: 0x00159E63
		static ConfigRacingBetRankOpenTimeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetRankOpenTimeById.CreateStaticDefaultValue), new Action(ConfigRacingBetRankOpenTimeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DC1 RID: 11713 RVA: 0x0015BC84 File Offset: 0x00159E84
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetRankOpenTimeById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetRankOpenTimeById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetRankOpenTime"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetRankOpenTime` where Id=?")
			});
		}

		// Token: 0x06002DC2 RID: 11714 RVA: 0x0015BD03 File Offset: 0x00159F03
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetRankOpenTimeById.LogPair = null;
			ConfigRacingBetRankOpenTimeById.HandleId = 0;
		}

		// Token: 0x06002DC3 RID: 11715 RVA: 0x0015BD11 File Offset: 0x00159F11
		public static void Init()
		{
			ConfigRacingBetRankOpenTimeById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetRankOpenTimeById.HandleId, "db_racingbets.db", "select BinData from `RacingBetRankOpenTime` where Id=?");
		}

		// Token: 0x06002DC4 RID: 11716 RVA: 0x0015BD2C File Offset: 0x00159F2C
		public static RacingBetRankOpenTime? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetRankOpenTimeById.HandleId, ConfigRacingBetRankOpenTimeById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetRankOpenTimeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetRankOpenTime?(RacingBetRankOpenTime.GetRootAsRacingBetRankOpenTime(configBuffer));
				}
			}
			ConfigRacingBetRankOpenTimeById.LogPair.Clear();
			ConfigRacingBetRankOpenTimeById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetRankOpenTimeById.HandleId, 1, p0Id, ConfigRacingBetRankOpenTimeById.LogPair) || ConfigCommon.Step(ConfigRacingBetRankOpenTimeById.HandleId, true, ConfigRacingBetRankOpenTimeById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetRankOpenTimeById.HandleId, ConfigRacingBetRankOpenTimeById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetRankOpenTimeById.HandleId, 0, ConfigRacingBetRankOpenTimeById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetRankOpenTimeById.HandleId, ConfigRacingBetRankOpenTimeById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetRankOpenTime rootAsRacingBetRankOpenTime = RacingBetRankOpenTime.GetRootAsRacingBetRankOpenTime(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetRankOpenTimeById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetRankOpenTimeById.HandleId, ConfigRacingBetRankOpenTimeById.LogPair);
			return new RacingBetRankOpenTime?(rootAsRacingBetRankOpenTime);
		}

		// Token: 0x04003531 RID: 13617
		private const string DB = "db_racingbets.db";

		// Token: 0x04003532 RID: 13618
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003533 RID: 13619
		private const string TABLE = "RacingBetRankOpenTime";

		// Token: 0x04003534 RID: 13620
		private const string COMMAND = "select BinData from `RacingBetRankOpenTime` where Id=?";

		// Token: 0x04003535 RID: 13621
		private const string KEY_PREFIX = "RacingBetRankOpenTimeById";

		// Token: 0x04003536 RID: 13622
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003537 RID: 13623
		private static int HandleId;
	}
}
