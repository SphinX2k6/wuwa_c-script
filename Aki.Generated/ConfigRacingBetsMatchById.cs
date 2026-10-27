using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A4 RID: 1956
	public class ConfigRacingBetsMatchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DEA RID: 11754 RVA: 0x0015CC2B File Offset: 0x0015AE2B
		static ConfigRacingBetsMatchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsMatchById.CreateStaticDefaultValue), new Action(ConfigRacingBetsMatchById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DEB RID: 11755 RVA: 0x0015CC4C File Offset: 0x0015AE4C
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsMatchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsMatchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsMatch"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsMatch` where Id=?")
			});
		}

		// Token: 0x06002DEC RID: 11756 RVA: 0x0015CCCB File Offset: 0x0015AECB
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsMatchById.LogPair = null;
			ConfigRacingBetsMatchById.HandleId = 0;
		}

		// Token: 0x06002DED RID: 11757 RVA: 0x0015CCD9 File Offset: 0x0015AED9
		public static void Init()
		{
			ConfigRacingBetsMatchById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsMatchById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsMatch` where Id=?");
		}

		// Token: 0x06002DEE RID: 11758 RVA: 0x0015CCF4 File Offset: 0x0015AEF4
		public static RacingBetsMatch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsMatchById.HandleId, ConfigRacingBetsMatchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsMatchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsMatch?(RacingBetsMatch.GetRootAsRacingBetsMatch(configBuffer));
				}
			}
			ConfigRacingBetsMatchById.LogPair.Clear();
			ConfigRacingBetsMatchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsMatchById.HandleId, 1, p0Id, ConfigRacingBetsMatchById.LogPair) || ConfigCommon.Step(ConfigRacingBetsMatchById.HandleId, true, ConfigRacingBetsMatchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsMatchById.HandleId, ConfigRacingBetsMatchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsMatchById.HandleId, 0, ConfigRacingBetsMatchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsMatchById.HandleId, ConfigRacingBetsMatchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsMatch rootAsRacingBetsMatch = RacingBetsMatch.GetRootAsRacingBetsMatch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsMatchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsMatchById.HandleId, ConfigRacingBetsMatchById.LogPair);
			return new RacingBetsMatch?(rootAsRacingBetsMatch);
		}

		// Token: 0x04003562 RID: 13666
		private const string DB = "db_racingbets.db";

		// Token: 0x04003563 RID: 13667
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003564 RID: 13668
		private const string TABLE = "RacingBetsMatch";

		// Token: 0x04003565 RID: 13669
		private const string COMMAND = "select BinData from `RacingBetsMatch` where Id=?";

		// Token: 0x04003566 RID: 13670
		private const string KEY_PREFIX = "RacingBetsMatchById";

		// Token: 0x04003567 RID: 13671
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003568 RID: 13672
		private static int HandleId;
	}
}
