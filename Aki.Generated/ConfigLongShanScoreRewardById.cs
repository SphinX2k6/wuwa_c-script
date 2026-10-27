using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020004ED RID: 1261
	public class ConfigLongShanScoreRewardById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001D99 RID: 7577 RVA: 0x0010089B File Offset: 0x000FEA9B
		static ConfigLongShanScoreRewardById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigLongShanScoreRewardById.CreateStaticDefaultValue), new Action(ConfigLongShanScoreRewardById.ResetStaticDefaultValue));
		}

		// Token: 0x06001D9A RID: 7578 RVA: 0x001008BC File Offset: 0x000FEABC
		public static void CreateStaticDefaultValue()
		{
			ConfigLongShanScoreRewardById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigLongShanScoreRewardById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_longshanactivity.db"),
				new ValueTuple<string, object>("文件", "l.龙山主题活动.xlsx"),
				new ValueTuple<string, object>("表名", "LongShanScoreReward"),
				new ValueTuple<string, object>("语句", "select BinData from `LongShanScoreReward` where Id=?")
			});
		}

		// Token: 0x06001D9B RID: 7579 RVA: 0x0010093B File Offset: 0x000FEB3B
		public static void ResetStaticDefaultValue()
		{
			ConfigLongShanScoreRewardById.LogPair = null;
			ConfigLongShanScoreRewardById.HandleId = 0;
		}

		// Token: 0x06001D9C RID: 7580 RVA: 0x00100949 File Offset: 0x000FEB49
		public static void Init()
		{
			ConfigLongShanScoreRewardById.HandleId = ConfigCommon.InitDataStatement(ConfigLongShanScoreRewardById.HandleId, "db_longshanactivity.db", "select BinData from `LongShanScoreReward` where Id=?");
		}

		// Token: 0x06001D9D RID: 7581 RVA: 0x00100964 File Offset: 0x000FEB64
		public static LongShanScoreReward? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new LongShanScoreReward?(LongShanScoreReward.GetRootAsLongShanScoreReward(configBuffer));
				}
			}
			ConfigLongShanScoreRewardById.LogPair.Clear();
			ConfigLongShanScoreRewardById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigLongShanScoreRewardById.HandleId, 1, p0Id, ConfigLongShanScoreRewardById.LogPair) || ConfigCommon.Step(ConfigLongShanScoreRewardById.HandleId, true, ConfigLongShanScoreRewardById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigLongShanScoreRewardById.HandleId, 0, ConfigLongShanScoreRewardById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			LongShanScoreReward rootAsLongShanScoreReward = LongShanScoreReward.GetRootAsLongShanScoreReward(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("LongShanScoreRewardById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigLongShanScoreRewardById.HandleId, ConfigLongShanScoreRewardById.LogPair);
			return new LongShanScoreReward?(rootAsLongShanScoreReward);
		}

		// Token: 0x0400225F RID: 8799
		private const string DB = "db_longshanactivity.db";

		// Token: 0x04002260 RID: 8800
		private const string FILE = "l.龙山主题活动.xlsx";

		// Token: 0x04002261 RID: 8801
		private const string TABLE = "LongShanScoreReward";

		// Token: 0x04002262 RID: 8802
		private const string COMMAND = "select BinData from `LongShanScoreReward` where Id=?";

		// Token: 0x04002263 RID: 8803
		private const string KEY_PREFIX = "LongShanScoreRewardById";

		// Token: 0x04002264 RID: 8804
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002265 RID: 8805
		private static int HandleId;
	}
}
