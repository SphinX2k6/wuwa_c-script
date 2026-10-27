using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A2 RID: 1954
	public class ConfigRacingBetsLegMatchesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DDE RID: 11742 RVA: 0x0015C7AB File Offset: 0x0015A9AB
		static ConfigRacingBetsLegMatchesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsLegMatchesById.CreateStaticDefaultValue), new Action(ConfigRacingBetsLegMatchesById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DDF RID: 11743 RVA: 0x0015C7CC File Offset: 0x0015A9CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsLegMatchesById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsLegMatchesById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsLegMatches"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsLegMatches` where Id=?")
			});
		}

		// Token: 0x06002DE0 RID: 11744 RVA: 0x0015C84B File Offset: 0x0015AA4B
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsLegMatchesById.LogPair = null;
			ConfigRacingBetsLegMatchesById.HandleId = 0;
		}

		// Token: 0x06002DE1 RID: 11745 RVA: 0x0015C859 File Offset: 0x0015AA59
		public static void Init()
		{
			ConfigRacingBetsLegMatchesById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsLegMatchesById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsLegMatches` where Id=?");
		}

		// Token: 0x06002DE2 RID: 11746 RVA: 0x0015C874 File Offset: 0x0015AA74
		public static RacingBetsLegMatches? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsLegMatchesById.HandleId, ConfigRacingBetsLegMatchesById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsLegMatchesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsLegMatches?(RacingBetsLegMatches.GetRootAsRacingBetsLegMatches(configBuffer));
				}
			}
			ConfigRacingBetsLegMatchesById.LogPair.Clear();
			ConfigRacingBetsLegMatchesById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsLegMatchesById.HandleId, 1, p0Id, ConfigRacingBetsLegMatchesById.LogPair) || ConfigCommon.Step(ConfigRacingBetsLegMatchesById.HandleId, true, ConfigRacingBetsLegMatchesById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsLegMatchesById.HandleId, ConfigRacingBetsLegMatchesById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsLegMatchesById.HandleId, 0, ConfigRacingBetsLegMatchesById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsLegMatchesById.HandleId, ConfigRacingBetsLegMatchesById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsLegMatches rootAsRacingBetsLegMatches = RacingBetsLegMatches.GetRootAsRacingBetsLegMatches(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsLegMatchesById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsLegMatchesById.HandleId, ConfigRacingBetsLegMatchesById.LogPair);
			return new RacingBetsLegMatches?(rootAsRacingBetsLegMatches);
		}

		// Token: 0x04003554 RID: 13652
		private const string DB = "db_racingbets.db";

		// Token: 0x04003555 RID: 13653
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003556 RID: 13654
		private const string TABLE = "RacingBetsLegMatches";

		// Token: 0x04003557 RID: 13655
		private const string COMMAND = "select BinData from `RacingBetsLegMatches` where Id=?";

		// Token: 0x04003558 RID: 13656
		private const string KEY_PREFIX = "RacingBetsLegMatchesById";

		// Token: 0x04003559 RID: 13657
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400355A RID: 13658
		private static int HandleId;
	}
}
