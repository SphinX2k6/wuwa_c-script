using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AB RID: 1963
	public class ConfigRacingBetsSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E14 RID: 11796 RVA: 0x0015DBF3 File Offset: 0x0015BDF3
		static ConfigRacingBetsSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsSeasonById.CreateStaticDefaultValue), new Action(ConfigRacingBetsSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E15 RID: 11797 RVA: 0x0015DC14 File Offset: 0x0015BE14
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsSeason` where Id=?")
			});
		}

		// Token: 0x06002E16 RID: 11798 RVA: 0x0015DC93 File Offset: 0x0015BE93
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsSeasonById.LogPair = null;
			ConfigRacingBetsSeasonById.HandleId = 0;
		}

		// Token: 0x06002E17 RID: 11799 RVA: 0x0015DCA1 File Offset: 0x0015BEA1
		public static void Init()
		{
			ConfigRacingBetsSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsSeasonById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsSeason` where Id=?");
		}

		// Token: 0x06002E18 RID: 11800 RVA: 0x0015DCBC File Offset: 0x0015BEBC
		public static RacingBetsSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsSeason?(RacingBetsSeason.GetRootAsRacingBetsSeason(configBuffer));
				}
			}
			ConfigRacingBetsSeasonById.LogPair.Clear();
			ConfigRacingBetsSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsSeasonById.HandleId, 1, p0Id, ConfigRacingBetsSeasonById.LogPair) || ConfigCommon.Step(ConfigRacingBetsSeasonById.HandleId, true, ConfigRacingBetsSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsSeasonById.HandleId, 0, ConfigRacingBetsSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsSeason rootAsRacingBetsSeason = RacingBetsSeason.GetRootAsRacingBetsSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair);
			return new RacingBetsSeason?(rootAsRacingBetsSeason);
		}

		// Token: 0x04003593 RID: 13715
		private const string DB = "db_racingbets.db";

		// Token: 0x04003594 RID: 13716
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003595 RID: 13717
		private const string TABLE = "RacingBetsSeason";

		// Token: 0x04003596 RID: 13718
		private const string COMMAND = "select BinData from `RacingBetsSeason` where Id=?";

		// Token: 0x04003597 RID: 13719
		private const string KEY_PREFIX = "RacingBetsSeasonById";

		// Token: 0x04003598 RID: 13720
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003599 RID: 13721
		private static int HandleId;
	}
}
