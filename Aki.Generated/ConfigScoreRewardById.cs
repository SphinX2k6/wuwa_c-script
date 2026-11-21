using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000945 RID: 2373
	public class ConfigScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060037B1 RID: 14257 RVA: 0x001974CC File Offset: 0x001956CC
		static ConfigScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigScoreRewardById.CreateStaticDefaultValue), new Action(ConfigScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x060037B2 RID: 14258 RVA: 0x001974EC File Offset: 0x001956EC
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

		// Token: 0x060037B3 RID: 14259 RVA: 0x0019756B File Offset: 0x0019576B
		public static void ResetStaticDefaultValue()
		{
			ConfigScoreRewardById.LogPair = null;
			ConfigScoreRewardById.HandleId = 0;
		}

		// Token: 0x060037B4 RID: 14260 RVA: 0x00197579 File Offset: 0x00195779
		public static void Init()
		{
			ConfigScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigScoreRewardById.HandleId, "db_takeweeds.db", "select BinData from `ScoreReward` where Id=?");
		}

		// Token: 0x060037B5 RID: 14261 RVA: 0x00197594 File Offset: 0x00195794
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

		// Token: 0x040040C9 RID: 16585
		private const string DB = "db_takeweeds.db";

		// Token: 0x040040CA RID: 16586
		private const string FILE = "g.割草活动.xlsx";

		// Token: 0x040040CB RID: 16587
		private const string TABLE = "ScoreReward";

		// Token: 0x040040CC RID: 16588
		private const string COMMAND = "select BinData from `ScoreReward` where Id=?";

		// Token: 0x040040CD RID: 16589
		private const string KEY_PREFIX = "ScoreRewardById";

		// Token: 0x040040CE RID: 16590
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040040CF RID: 16591
		private static int HandleId;
	}
}
