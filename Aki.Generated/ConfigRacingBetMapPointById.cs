using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200079B RID: 1947
	public class ConfigRacingBetMapPointById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DB4 RID: 11700 RVA: 0x0015B7E3 File Offset: 0x001599E3
		static ConfigRacingBetMapPointById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetMapPointById.CreateStaticDefaultValue), new Action(ConfigRacingBetMapPointById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DB5 RID: 11701 RVA: 0x0015B804 File Offset: 0x00159A04
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetMapPointById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetMapPointById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetMapPoint"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetMapPoint` where Id=?")
			});
		}

		// Token: 0x06002DB6 RID: 11702 RVA: 0x0015B883 File Offset: 0x00159A83
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetMapPointById.LogPair = null;
			ConfigRacingBetMapPointById.HandleId = 0;
		}

		// Token: 0x06002DB7 RID: 11703 RVA: 0x0015B891 File Offset: 0x00159A91
		public static void Init()
		{
			ConfigRacingBetMapPointById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetMapPointById.HandleId, "db_racingbets.db", "select BinData from `RacingBetMapPoint` where Id=?");
		}

		// Token: 0x06002DB8 RID: 11704 RVA: 0x0015B8AC File Offset: 0x00159AAC
		public static RacingBetMapPoint? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetMapPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetMapPoint?(RacingBetMapPoint.GetRootAsRacingBetMapPoint(configBuffer));
				}
			}
			ConfigRacingBetMapPointById.LogPair.Clear();
			ConfigRacingBetMapPointById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetMapPointById.HandleId, 1, p0Id, ConfigRacingBetMapPointById.LogPair) || ConfigCommon.Step(ConfigRacingBetMapPointById.HandleId, true, ConfigRacingBetMapPointById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetMapPointById.HandleId, 0, ConfigRacingBetMapPointById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetMapPoint rootAsRacingBetMapPoint = RacingBetMapPoint.GetRootAsRacingBetMapPoint(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetMapPointById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetMapPointById.HandleId, ConfigRacingBetMapPointById.LogPair);
			return new RacingBetMapPoint?(rootAsRacingBetMapPoint);
		}

		// Token: 0x04003523 RID: 13603
		private const string DB = "db_racingbets.db";

		// Token: 0x04003524 RID: 13604
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003525 RID: 13605
		private const string TABLE = "RacingBetMapPoint";

		// Token: 0x04003526 RID: 13606
		private const string COMMAND = "select BinData from `RacingBetMapPoint` where Id=?";

		// Token: 0x04003527 RID: 13607
		private const string KEY_PREFIX = "RacingBetMapPointById";

		// Token: 0x04003528 RID: 13608
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003529 RID: 13609
		private static int HandleId;
	}
}
