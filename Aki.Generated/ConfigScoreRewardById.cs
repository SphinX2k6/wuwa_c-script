using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020008FA RID: 2298
	public class ConfigScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060035EF RID: 13807 RVA: 0x0018A2AC File Offset: 0x001884AC
		static ConfigScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScoreRewardById.CreateStaticDefaultValue), new Action(ConfigScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060035F0 RID: 13808 RVA: 0x0018A2CC File Offset: 0x001884CC
		public static void CreateStaticDefaultValue()
		{
			ConfigScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_takeweeds.db"),
				new ValueTuple<string, object>("文件", "g.割草活动.xlsx"),
				new ValueTuple<string, object>("表名", "ScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `ScoreReward` where Id=?")
			});
		}

		// Token: 0x060035F1 RID: 13809 RVA: 0x0018A34B File Offset: 0x0018854B
		public static void ResetStaticDefaultValue()
		{
			ConfigScoreRewardById.LogPair = null;
			ConfigScoreRewardById.HandleId = 0;
		}

		// Token: 0x060035F2 RID: 13810 RVA: 0x0018A359 File Offset: 0x00188559
		public static void Init()
		{
			ConfigScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigScoreRewardById.HandleId, "db_takeweeds.db", "select BinData from `ScoreReward` where Id=?");
		}

		// Token: 0x060035F3 RID: 13811 RVA: 0x0018A374 File Offset: 0x00188574
		public static ScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigScoreRewardById.HandleId, ConfigScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new ScoreReward?(ScoreReward.GetRootAsScoreReward(configBuffer));
				}
			}
			ConfigScoreRewardById.LogPair.Clear();
			ConfigScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigScoreRewardById.HandleId, 1, p0Id, ConfigScoreRewardById.LogPair) || ConfigCommon.Step(ConfigScoreRewardById.HandleId, true, ConfigScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigScoreRewardById.HandleId, ConfigScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigScoreRewardById.HandleId, 0, ConfigScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigScoreRewardById.HandleId, ConfigScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			ScoreReward rootAsScoreReward = ScoreReward.GetRootAsScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("ScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigScoreRewardById.HandleId, ConfigScoreRewardById.LogPair);
			return new ScoreReward?(rootAsScoreReward);
		}

		// Token: 0x04003EBC RID: 16060
		private const string DB = "db_takeweeds.db";

		// Token: 0x04003EBD RID: 16061
		private const string FILE = "g.割草活动.xlsx";

		// Token: 0x04003EBE RID: 16062
		private const string TABLE = "ScoreReward";

		// Token: 0x04003EBF RID: 16063
		private const string COMMAND = "select BinData from `ScoreReward` where Id=?";

		// Token: 0x04003EC0 RID: 16064
		private const string KEY_PREFIX = "ScoreRewardById";

		// Token: 0x04003EC1 RID: 16065
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04003EC2 RID: 16066
		private static int HandleId;
	}
}
