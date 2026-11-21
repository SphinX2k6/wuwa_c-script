using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BC RID: 1980
	public class ConfigRacingBetsLegMatchesById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E7A RID: 11898 RVA: 0x001636B7 File Offset: 0x001618B7
		static ConfigRacingBetsLegMatchesById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsLegMatchesById.CreateStaticDefaultValue), new Action(ConfigRacingBetsLegMatchesById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x001636D8 File Offset: 0x001618D8
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

		// Token: 0x06002E7C RID: 11900 RVA: 0x00163757 File Offset: 0x00161957
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsLegMatchesById.LogPair = null;
			ConfigRacingBetsLegMatchesById.HandleId = 0;
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x00163765 File Offset: 0x00161965
		public static void Init()
		{
			ConfigRacingBetsLegMatchesById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsLegMatchesById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsLegMatches` where Id=?");
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00163780 File Offset: 0x00161980
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

		// Token: 0x0400360A RID: 13834
		private const string DB = "db_racingbets.db";

		// Token: 0x0400360B RID: 13835
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400360C RID: 13836
		private const string TABLE = "RacingBetsLegMatches";

		// Token: 0x0400360D RID: 13837
		private const string COMMAND = "select BinData from `RacingBetsLegMatches` where Id=?";

		// Token: 0x0400360E RID: 13838
		private const string KEY_PREFIX = "RacingBetsLegMatchesById";

		// Token: 0x0400360F RID: 13839
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003610 RID: 13840
		private static int HandleId;
	}
}
