using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020007A7 RID: 1959
	public class ConfigRacingBetsRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06002DFC RID: 11772 RVA: 0x0015D2F4 File Offset: 0x0015B4F4
		static ConfigRacingBetsRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigRacingBetsRewardById.CreateStaticDefaultValue), new Action(ConfigRacingBetsRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06002DFD RID: 11773 RVA: 0x0015D314 File Offset: 0x0015B514
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

		// Token: 0x06002DFE RID: 11774 RVA: 0x0015D393 File Offset: 0x0015B593
		public static void ResetStaticDefaultValue()
		{
			ConfigRacingBetsRewardById.LogPair = null;
			ConfigRacingBetsRewardById.HandleId = 0;
		}

		// Token: 0x06002DFF RID: 11775 RVA: 0x0015D3A1 File Offset: 0x0015B5A1
		public static void Init()
		{
			ConfigRacingBetsRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigRacingBetsRewardById.HandleId, "db_racingbets.db", "select BinData from `RacingBetsReward` where Id=?");
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x0015D3BC File Offset: 0x0015B5BC
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

		// Token: 0x04003577 RID: 13687
		private const string DB = "db_racingbets.db";

		// Token: 0x04003578 RID: 13688
		private const string FILE = "q.全服赌马.xlsx";

		// Token: 0x04003579 RID: 13689
		private const string TABLE = "RacingBetsReward";

		// Token: 0x0400357A RID: 13690
		private const string COMMAND = "select BinData from `RacingBetsReward` where Id=?";

		// Token: 0x0400357B RID: 13691
		private const string KEY_PREFIX = "RacingBetsRewardById";

		// Token: 0x0400357C RID: 13692
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400357D RID: 13693
		private static int HandleId;
	}
}
