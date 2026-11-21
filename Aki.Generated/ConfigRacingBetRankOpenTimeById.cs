using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B7 RID: 1975
	public class ConfigRacingBetRankOpenTimeById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E5C RID: 11868 RVA: 0x00162B6F File Offset: 0x00160D6F
		static ConfigRacingBetRankOpenTimeById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetRankOpenTimeById.CreateStaticDefaultValue), new Action(ConfigRacingBetRankOpenTimeById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E5D RID: 11869 RVA: 0x00162B90 File Offset: 0x00160D90
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

		// Token: 0x06002E5E RID: 11870 RVA: 0x00162C0F File Offset: 0x00160E0F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetRankOpenTimeById.LogPair = null;
			ConfigRacingBetRankOpenTimeById.HandleId = 0;
		}

		// Token: 0x06002E5F RID: 11871 RVA: 0x00162C1D File Offset: 0x00160E1D
		public static void Init()
		{
			ConfigRacingBetRankOpenTimeById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetRankOpenTimeById.HandleId, "db_racingbets.db", "select BinData from `RacingBetRankOpenTime` where Id=?");
		}

		// Token: 0x06002E60 RID: 11872 RVA: 0x00162C38 File Offset: 0x00160E38
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

		// Token: 0x040035E7 RID: 13799
		private const string DB = "db_racingbets.db";

		// Token: 0x040035E8 RID: 13800
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035E9 RID: 13801
		private const string TABLE = "RacingBetRankOpenTime";

		// Token: 0x040035EA RID: 13802
		private const string COMMAND = "select BinData from `RacingBetRankOpenTime` where Id=?";

		// Token: 0x040035EB RID: 13803
		private const string KEY_PREFIX = "RacingBetRankOpenTimeById";

		// Token: 0x040035EC RID: 13804
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035ED RID: 13805
		private static int HandleId;
	}
}
