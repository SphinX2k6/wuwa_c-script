using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A0 RID: 1952
	public class ConfigRacingBetsGroupMatchById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DD2 RID: 11730 RVA: 0x0015C32B File Offset: 0x0015A52B
		static ConfigRacingBetsGroupMatchById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsGroupMatchById.CreateStaticDefaultValue), new Action(ConfigRacingBetsGroupMatchById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DD3 RID: 11731 RVA: 0x0015C34C File Offset: 0x0015A54C
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

		// Token: 0x06002DD4 RID: 11732 RVA: 0x0015C3CB File Offset: 0x0015A5CB
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsGroupMatchById.LogPair = null;
			ConfigRacingBetsGroupMatchById.HandleId = 0;
		}

		// Token: 0x06002DD5 RID: 11733 RVA: 0x0015C3D9 File Offset: 0x0015A5D9
		public static void Init()
		{
			ConfigRacingBetsGroupMatchById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsGroupMatchById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsGroupMatch` where Id=?");
		}

		// Token: 0x06002DD6 RID: 11734 RVA: 0x0015C3F4 File Offset: 0x0015A5F4
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

		// Token: 0x04003546 RID: 13638
		private const string DB = "db_racingbets.db";

		// Token: 0x04003547 RID: 13639
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003548 RID: 13640
		private const string TABLE = "RacingBetsGroupMatch";

		// Token: 0x04003549 RID: 13641
		private const string COMMAND = "select BinData from `RacingBetsGroupMatch` where Id=?";

		// Token: 0x0400354A RID: 13642
		private const string KEY_PREFIX = "RacingBetsGroupMatchById";

		// Token: 0x0400354B RID: 13643
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400354C RID: 13644
		private static int HandleId;
	}
}
