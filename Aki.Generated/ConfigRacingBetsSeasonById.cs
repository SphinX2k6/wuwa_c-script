using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C5 RID: 1989
	public class ConfigRacingBetsSeasonById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EB0 RID: 11952 RVA: 0x00164AFF File Offset: 0x00162CFF
		static ConfigRacingBetsSeasonById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsSeasonById.CreateStaticDefaultValue), new Action(ConfigRacingBetsSeasonById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00164B20 File Offset: 0x00162D20
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsSeasonById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsSeasonById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsSeason"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsSeason` where Id=?")
			});
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00164B9F File Offset: 0x00162D9F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsSeasonById.LogPair = null;
			ConfigRacingBetsSeasonById.HandleId = 0;
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00164BAD File Offset: 0x00162DAD
		public static void Init()
		{
			ConfigRacingBetsSeasonById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsSeasonById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsSeason` where Id=?");
		}

		// Token: 0x06002EB4 RID: 11956 RVA: 0x00164BC8 File Offset: 0x00162DC8
		public static RacingBetsSeason? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsSeason?(RacingBetsSeason.GetRootAsRacingBetsSeason(configBuffer));
				}
			}
			ConfigRacingBetsSeasonById.LogPair.Clear();
			ConfigRacingBetsSeasonById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsSeasonById.HandleId, 1, p0Id, ConfigRacingBetsSeasonById.LogPair) || ConfigCommon.Step(ConfigRacingBetsSeasonById.HandleId, true, ConfigRacingBetsSeasonById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsSeasonById.HandleId, 0, ConfigRacingBetsSeasonById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsSeason rootAsRacingBetsSeason = RacingBetsSeason.GetRootAsRacingBetsSeason(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsSeasonById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsSeasonById.HandleId, ConfigRacingBetsSeasonById.LogPair);
			return new RacingBetsSeason?(rootAsRacingBetsSeason);
		}

		// Token: 0x04003649 RID: 13897
		private const string DB = "db_racingbets.db";

		// Token: 0x0400364A RID: 13898
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400364B RID: 13899
		private const string TABLE = "RacingBetsSeason";

		// Token: 0x0400364C RID: 13900
		private const string COMMAND = "select BinData from `RacingBetsSeason` where Id=?";

		// Token: 0x0400364D RID: 13901
		private const string KEY_PREFIX = "RacingBetsSeasonById";

		// Token: 0x0400364E RID: 13902
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400364F RID: 13903
		private static int HandleId;
	}
}
