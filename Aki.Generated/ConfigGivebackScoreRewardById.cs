using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200039D RID: 925
	public class ConfigGivebackScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060015B5 RID: 5557 RVA: 0x000D451B File Offset: 0x000D271B
		static ConfigGivebackScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGivebackScoreRewardById.CreateStaticDefaultValue), new Action(ConfigGivebackScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060015B6 RID: 5558 RVA: 0x000D453C File Offset: 0x000D273C
		public static void CreateStaticDefaultValue()
		{
			ConfigGivebackScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGivebackScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_feedbackreward.db"),
				new ValueTuple<string, object>("文件", "l.老玩家回馈.xlsx"),
				new ValueTuple<string, object>("表名", "GivebackScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `GivebackScoreReward` where Id=?")
			});
		}

		// Token: 0x060015B7 RID: 5559 RVA: 0x000D45BB File Offset: 0x000D27BB
		public static void ResetStaticDefaultValue()
		{
			ConfigGivebackScoreRewardById.LogPair = null;
			ConfigGivebackScoreRewardById.HandleId = 0;
		}

		// Token: 0x060015B8 RID: 5560 RVA: 0x000D45C9 File Offset: 0x000D27C9
		public static void Init()
		{
			ConfigGivebackScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigGivebackScoreRewardById.HandleId, "db_feedbackreward.db", "select BinData from `GivebackScoreReward` where Id=?");
		}

		// Token: 0x060015B9 RID: 5561 RVA: 0x000D45E4 File Offset: 0x000D27E4
		public static GivebackScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GivebackScoreReward?(GivebackScoreReward.GetRootAsGivebackScoreReward(configBuffer));
				}
			}
			ConfigGivebackScoreRewardById.LogPair.Clear();
			ConfigGivebackScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGivebackScoreRewardById.HandleId, 1, p0Id, ConfigGivebackScoreRewardById.LogPair) || ConfigCommon.Step(ConfigGivebackScoreRewardById.HandleId, true, ConfigGivebackScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGivebackScoreRewardById.HandleId, 0, ConfigGivebackScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GivebackScoreReward rootAsGivebackScoreReward = GivebackScoreReward.GetRootAsGivebackScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GivebackScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGivebackScoreRewardById.HandleId, ConfigGivebackScoreRewardById.LogPair);
			return new GivebackScoreReward?(rootAsGivebackScoreReward);
		}

		// Token: 0x0400192F RID: 6447
		private const string DB = "db_feedbackreward.db";

		// Token: 0x04001930 RID: 6448
		private const string FILE = "l.老玩家回馈.xlsx";

		// Token: 0x04001931 RID: 6449
		private const string TABLE = "GivebackScoreReward";

		// Token: 0x04001932 RID: 6450
		private const string COMMAND = "select BinData from `GivebackScoreReward` where Id=?";

		// Token: 0x04001933 RID: 6451
		private const string KEY_PREFIX = "GivebackScoreRewardById";

		// Token: 0x04001934 RID: 6452
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001935 RID: 6453
		private static int HandleId;
	}
}
