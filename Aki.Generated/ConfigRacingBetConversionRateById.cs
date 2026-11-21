using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007B3 RID: 1971
	public class ConfigRacingBetConversionRateById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E44 RID: 11844 RVA: 0x00162270 File Offset: 0x00160470
		static ConfigRacingBetConversionRateById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetConversionRateById.CreateStaticDefaultValue), new Action(ConfigRacingBetConversionRateById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E45 RID: 11845 RVA: 0x00162290 File Offset: 0x00160490
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

		// Token: 0x06002E46 RID: 11846 RVA: 0x0016230F File Offset: 0x0016050F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetConversionRateById.LogPair = null;
			ConfigRacingBetConversionRateById.HandleId = 0;
		}

		// Token: 0x06002E47 RID: 11847 RVA: 0x0016231D File Offset: 0x0016051D
		public static void Init()
		{
			ConfigRacingBetConversionRateById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetConversionRateById.HandleId, "db_racingbets.db", "select BinData from `RacingBetConversionRate` where Id=?");
		}

		// Token: 0x06002E48 RID: 11848 RVA: 0x00162338 File Offset: 0x00160538
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

		// Token: 0x040035CB RID: 13771
		private const string DB = "db_racingbets.db";

		// Token: 0x040035CC RID: 13772
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x040035CD RID: 13773
		private const string TABLE = "RacingBetConversionRate";

		// Token: 0x040035CE RID: 13774
		private const string COMMAND = "select BinData from `RacingBetConversionRate` where Id=?";

		// Token: 0x040035CF RID: 13775
		private const string KEY_PREFIX = "RacingBetConversionRateById";

		// Token: 0x040035D0 RID: 13776
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040035D1 RID: 13777
		private static int HandleId;
	}
}
