using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A6 RID: 1958
	public class ConfigRacingBetsOrganById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DF6 RID: 11766 RVA: 0x0015D0AB File Offset: 0x0015B2AB
		static ConfigRacingBetsOrganById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsOrganById.CreateStaticDefaultValue), new Action(ConfigRacingBetsOrganById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0015D0CC File Offset: 0x0015B2CC
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsOrganById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsOrganById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsOrgan"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsOrgan` where Id=?")
			});
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0015D14B File Offset: 0x0015B34B
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsOrganById.LogPair = null;
			ConfigRacingBetsOrganById.HandleId = 0;
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x0015D159 File Offset: 0x0015B359
		public static void Init()
		{
			ConfigRacingBetsOrganById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsOrganById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsOrgan` where Id=?");
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x0015D174 File Offset: 0x0015B374
		public static RacingBetsOrgan? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsOrganById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsOrgan?(RacingBetsOrgan.GetRootAsRacingBetsOrgan(configBuffer));
				}
			}
			ConfigRacingBetsOrganById.LogPair.Clear();
			ConfigRacingBetsOrganById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsOrganById.HandleId, 1, p0Id, ConfigRacingBetsOrganById.LogPair) || ConfigCommon.Step(ConfigRacingBetsOrganById.HandleId, true, ConfigRacingBetsOrganById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsOrganById.HandleId, 0, ConfigRacingBetsOrganById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsOrgan rootAsRacingBetsOrgan = RacingBetsOrgan.GetRootAsRacingBetsOrgan(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsOrganById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsOrganById.HandleId, ConfigRacingBetsOrganById.LogPair);
			return new RacingBetsOrgan?(rootAsRacingBetsOrgan);
		}

		// Token: 0x04003570 RID: 13680
		private const string DB = "db_racingbets.db";

		// Token: 0x04003571 RID: 13681
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003572 RID: 13682
		private const string TABLE = "RacingBetsOrgan";

		// Token: 0x04003573 RID: 13683
		private const string COMMAND = "select BinData from `RacingBetsOrgan` where Id=?";

		// Token: 0x04003574 RID: 13684
		private const string KEY_PREFIX = "RacingBetsOrganById";

		// Token: 0x04003575 RID: 13685
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003576 RID: 13686
		private static int HandleId;
	}
}
