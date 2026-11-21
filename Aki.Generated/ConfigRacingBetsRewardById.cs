using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007C1 RID: 1985
	public class ConfigRacingBetsRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002E98 RID: 11928 RVA: 0x00164200 File Offset: 0x00162400
		static ConfigRacingBetsRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRewardById.CreateStaticDefaultValue), new Action(ConfigRacingBetsRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00164220 File Offset: 0x00162420
		public static void CreateStaticDefaultValue()
		{
			ConfigRacingBetsRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigRacingBetsRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_racingbets.db"),
				new ValueTuple<string, object>("文件", "q.全服赌马.xlsx"),
				new ValueTuple<string, object>("表名", "RacingBetsReward"),
				new ValueTuple<string, object>("语句", "select BinData from `RacingBetsReward` where Id=?")
			});
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x0016429F File Offset: 0x0016249F
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRewardById.LogPair = null;
			ConfigRacingBetsRewardById.HandleId = 0;
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x001642AD File Offset: 0x001624AD
		public static void Init()
		{
			ConfigRacingBetsRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRewardById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsReward` where Id=?");
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x001642C8 File Offset: 0x001624C8
		public static RacingBetsReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigRacingBetsRewardById.HandleId, ConfigRacingBetsRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new RacingBetsReward?(RacingBetsReward.GetRootAsRacingBetsReward(configBuffer));
				}
			}
			ConfigRacingBetsRewardById.LogPair.Clear();
			ConfigRacingBetsRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigRacingBetsRewardById.HandleId, 1, p0Id, ConfigRacingBetsRewardById.LogPair) || ConfigCommon.Step(ConfigRacingBetsRewardById.HandleId, true, ConfigRacingBetsRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigRacingBetsRewardById.HandleId, ConfigRacingBetsRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigRacingBetsRewardById.HandleId, 0, ConfigRacingBetsRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigRacingBetsRewardById.HandleId, ConfigRacingBetsRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			RacingBetsReward rootAsRacingBetsReward = RacingBetsReward.GetRootAsRacingBetsReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("RacingBetsRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigRacingBetsRewardById.HandleId, ConfigRacingBetsRewardById.LogPair);
			return new RacingBetsReward?(rootAsRacingBetsReward);
		}

		// Token: 0x0400362D RID: 13869
		private const string DB = "db_racingbets.db";

		// Token: 0x0400362E RID: 13870
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x0400362F RID: 13871
		private const string TABLE = "RacingBetsReward";

		// Token: 0x04003630 RID: 13872
		private const string COMMAND = "select BinData from `RacingBetsReward` where Id=?";

		// Token: 0x04003631 RID: 13873
		private const string KEY_PREFIX = "RacingBetsRewardById";

		// Token: 0x04003632 RID: 13874
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003633 RID: 13875
		private static int HandleId;
	}
}
