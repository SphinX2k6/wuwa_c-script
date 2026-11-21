using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C6 RID: 1990
	public class ConfigRacingBettingGearById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002EB6 RID: 11958 RVA: 0x00164D48 File Offset: 0x00162F48
		static ConfigRacingBettingGearById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBettingGearById.CreateStaticDefaultValue), new Action(ConfigRacingBettingGearById.ResetStaticDefaultValue));
		}

		// Token: 0x06002EB7 RID: 11959 RVA: 0x00164D68 File Offset: 0x00162F68
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

		// Token: 0x06002EB8 RID: 11960 RVA: 0x00164DE7 File Offset: 0x00162FE7
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBettingGearById.LogPair = null;
			ConfigRacingBettingGearById.HandleId = 0;
		}

		// Token: 0x06002EB9 RID: 11961 RVA: 0x00164DF5 File Offset: 0x00162FF5
		public static void Init()
		{
			ConfigRacingBettingGearById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBettingGearById.HandleId, "db_racingbets.db", "select BinData from `RacingBettingGear` where Id=?");
		}

		// Token: 0x06002EBA RID: 11962 RVA: 0x00164E10 File Offset: 0x00163010
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

		// Token: 0x04003650 RID: 13904
		private const string DB = "db_racingbets.db";

		// Token: 0x04003651 RID: 13905
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003652 RID: 13906
		private const string TABLE = "RacingBettingGear";

		// Token: 0x04003653 RID: 13907
		private const string COMMAND = "select BinData from `RacingBettingGear` where Id=?";

		// Token: 0x04003654 RID: 13908
		private const string KEY_PREFIX = "RacingBettingGearById";

		// Token: 0x04003655 RID: 13909
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003656 RID: 13910
		private static int HandleId;
	}
}
