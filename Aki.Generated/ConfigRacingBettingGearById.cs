using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007AC RID: 1964
	public class ConfigRacingBettingGearById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E1A RID: 11802 RVA: 0x0015DE3C File Offset: 0x0015C03C
		static ConfigRacingBettingGearById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBettingGearById.CreateStaticDefaultValue), new Action(ConfigRacingBettingGearById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E1B RID: 11803 RVA: 0x0015DE5C File Offset: 0x0015C05C
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBettingGearById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBettingGearById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBettingGear"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBettingGear` where Id=?")
			});
		}

		// Token: 0x06002E1C RID: 11804 RVA: 0x0015DEDB File Offset: 0x0015C0DB
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBettingGearById.LogPair = null;
			ConfigRacingBettingGearById.HandleId = 0;
		}

		// Token: 0x06002E1D RID: 11805 RVA: 0x0015DEE9 File Offset: 0x0015C0E9
		public static void Init()
		{
			ConfigRacingBettingGearById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBettingGearById.HandleId, "db_racingbets.db", "select BinData from `RacingBettingGear` where Id=?");
		}

		// Token: 0x06002E1E RID: 11806 RVA: 0x0015DF04 File Offset: 0x0015C104
		public static RacingBettingGear? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBettingGearById.HandleId, ConfigRacingBettingGearById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBettingGearById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBettingGear?(RacingBettingGear.GetRootAsRacingBettingGear(configBuffer));
				}
			}
			ConfigRacingBettingGearById.LogPair.Clear();
			ConfigRacingBettingGearById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBettingGearById.HandleId, 1, p0Id, ConfigRacingBettingGearById.LogPair) || ConfigCommon.Step(ConfigRacingBettingGearById.HandleId, true, ConfigRacingBettingGearById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBettingGearById.HandleId, ConfigRacingBettingGearById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBettingGearById.HandleId, 0, ConfigRacingBettingGearById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBettingGearById.HandleId, ConfigRacingBettingGearById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBettingGear rootAsRacingBettingGear = RacingBettingGear.GetRootAsRacingBettingGear(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBettingGearById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBettingGearById.HandleId, ConfigRacingBettingGearById.LogPair);
			return new RacingBettingGear?(rootAsRacingBettingGear);
		}

		// Token: 0x0400359A RID: 13722
		private const string DB = "db_racingbets.db";

		// Token: 0x0400359B RID: 13723
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400359C RID: 13724
		private const string TABLE = "RacingBettingGear";

		// Token: 0x0400359D RID: 13725
		private const string COMMAND = "select BinData from `RacingBettingGear` where Id=?";

		// Token: 0x0400359E RID: 13726
		private const string KEY_PREFIX = "RacingBettingGearById";

		// Token: 0x0400359F RID: 13727
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035A0 RID: 13728
		private static int HandleId;
	}
}
