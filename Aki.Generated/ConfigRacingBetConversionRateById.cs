using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000799 RID: 1945
	public class ConfigRacingBetConversionRateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DA8 RID: 11688 RVA: 0x0015B364 File Offset: 0x00159564
		static ConfigRacingBetConversionRateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetConversionRateById.CreateStaticDefaultValue), new Action(ConfigRacingBetConversionRateById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DA9 RID: 11689 RVA: 0x0015B384 File Offset: 0x00159584
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetConversionRateById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetConversionRateById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetConversionRate"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetConversionRate` where Id=?")
			});
		}

		// Token: 0x06002DAA RID: 11690 RVA: 0x0015B403 File Offset: 0x00159603
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetConversionRateById.LogPair = null;
			ConfigRacingBetConversionRateById.HandleId = 0;
		}

		// Token: 0x06002DAB RID: 11691 RVA: 0x0015B411 File Offset: 0x00159611
		public static void Init()
		{
			ConfigRacingBetConversionRateById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetConversionRateById.HandleId, "db_racingbets.db", "select BinData from `RacingBetConversionRate` where Id=?");
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x0015B42C File Offset: 0x0015962C
		public static RacingBetConversionRate? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetConversionRateById.HandleId, ConfigRacingBetConversionRateById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetConversionRateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetConversionRate?(RacingBetConversionRate.GetRootAsRacingBetConversionRate(configBuffer));
				}
			}
			ConfigRacingBetConversionRateById.LogPair.Clear();
			ConfigRacingBetConversionRateById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetConversionRateById.HandleId, 1, p0Id, ConfigRacingBetConversionRateById.LogPair) || ConfigCommon.Step(ConfigRacingBetConversionRateById.HandleId, true, ConfigRacingBetConversionRateById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetConversionRateById.HandleId, ConfigRacingBetConversionRateById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetConversionRateById.HandleId, 0, ConfigRacingBetConversionRateById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetConversionRateById.HandleId, ConfigRacingBetConversionRateById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetConversionRate rootAsRacingBetConversionRate = RacingBetConversionRate.GetRootAsRacingBetConversionRate(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetConversionRateById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetConversionRateById.HandleId, ConfigRacingBetConversionRateById.LogPair);
			return new RacingBetConversionRate?(rootAsRacingBetConversionRate);
		}

		// Token: 0x04003515 RID: 13589
		private const string DB = "db_racingbets.db";

		// Token: 0x04003516 RID: 13590
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003517 RID: 13591
		private const string TABLE = "RacingBetConversionRate";

		// Token: 0x04003518 RID: 13592
		private const string COMMAND = "select BinData from `RacingBetConversionRate` where Id=?";

		// Token: 0x04003519 RID: 13593
		private const string KEY_PREFIX = "RacingBetConversionRateById";

		// Token: 0x0400351A RID: 13594
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400351B RID: 13595
		private static int HandleId;
	}
}
