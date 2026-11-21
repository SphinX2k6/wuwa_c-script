using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BE RID: 1982
	public class ConfigRacingBetsMatchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E86 RID: 11910 RVA: 0x00163B37 File Offset: 0x00161D37
		static ConfigRacingBetsMatchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsMatchById.CreateStaticDefaultValue), new Action(ConfigRacingBetsMatchById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00163B58 File Offset: 0x00161D58
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

		// Token: 0x06002E88 RID: 11912 RVA: 0x00163BD7 File Offset: 0x00161DD7
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsMatchById.LogPair = null;
			ConfigRacingBetsMatchById.HandleId = 0;
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00163BE5 File Offset: 0x00161DE5
		public static void Init()
		{
			ConfigRacingBetsMatchById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsMatchById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsMatch` where Id=?");
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00163C00 File Offset: 0x00161E00
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

		// Token: 0x04003618 RID: 13848
		private const string DB = "db_racingbets.db";

		// Token: 0x04003619 RID: 13849
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400361A RID: 13850
		private const string TABLE = "RacingBetsMatch";

		// Token: 0x0400361B RID: 13851
		private const string COMMAND = "select BinData from `RacingBetsMatch` where Id=?";

		// Token: 0x0400361C RID: 13852
		private const string KEY_PREFIX = "RacingBetsMatchById";

		// Token: 0x0400361D RID: 13853
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400361E RID: 13854
		private static int HandleId;
	}
}
