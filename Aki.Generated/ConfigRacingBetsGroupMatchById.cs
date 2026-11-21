using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007BA RID: 1978
	public class ConfigRacingBetsGroupMatchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E6E RID: 11886 RVA: 0x00163237 File Offset: 0x00161437
		static ConfigRacingBetsGroupMatchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsGroupMatchById.CreateStaticDefaultValue), new Action(ConfigRacingBetsGroupMatchById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x00163258 File Offset: 0x00161458
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsGroupMatchById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsGroupMatchById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsGroupMatch"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsGroupMatch` where Id=?")
			});
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x001632D7 File Offset: 0x001614D7
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsGroupMatchById.LogPair = null;
			ConfigRacingBetsGroupMatchById.HandleId = 0;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x001632E5 File Offset: 0x001614E5
		public static void Init()
		{
			ConfigRacingBetsGroupMatchById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsGroupMatchById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsGroupMatch` where Id=?");
		}

		// Token: 0x06002E72 RID: 11890 RVA: 0x00163300 File Offset: 0x00161500
		public static RacingBetsGroupMatch? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsGroupMatchById.HandleId, ConfigRacingBetsGroupMatchById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsGroupMatchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsGroupMatch?(RacingBetsGroupMatch.GetRootAsRacingBetsGroupMatch(configBuffer));
				}
			}
			ConfigRacingBetsGroupMatchById.LogPair.Clear();
			ConfigRacingBetsGroupMatchById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsGroupMatchById.HandleId, 1, p0Id, ConfigRacingBetsGroupMatchById.LogPair) || ConfigCommon.Step(ConfigRacingBetsGroupMatchById.HandleId, true, ConfigRacingBetsGroupMatchById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsGroupMatchById.HandleId, ConfigRacingBetsGroupMatchById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsGroupMatchById.HandleId, 0, ConfigRacingBetsGroupMatchById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsGroupMatchById.HandleId, ConfigRacingBetsGroupMatchById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsGroupMatch rootAsRacingBetsGroupMatch = RacingBetsGroupMatch.GetRootAsRacingBetsGroupMatch(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsGroupMatchById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsGroupMatchById.HandleId, ConfigRacingBetsGroupMatchById.LogPair);
			return new RacingBetsGroupMatch?(rootAsRacingBetsGroupMatch);
		}

		// Token: 0x040035FC RID: 13820
		private const string DB = "db_racingbets.db";

		// Token: 0x040035FD RID: 13821
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035FE RID: 13822
		private const string TABLE = "RacingBetsGroupMatch";

		// Token: 0x040035FF RID: 13823
		private const string COMMAND = "select BinData from `RacingBetsGroupMatch` where Id=?";

		// Token: 0x04003600 RID: 13824
		private const string KEY_PREFIX = "RacingBetsGroupMatchById";

		// Token: 0x04003601 RID: 13825
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003602 RID: 13826
		private static int HandleId;
	}
}
