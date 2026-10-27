using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B1 RID: 945
	public class ConfigGuessJokerAiConfigByNpcId : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600162D RID: 5677 RVA: 0x000D6F14 File Offset: 0x000D5114
		static ConfigGuessJokerAiConfigByNpcId()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAiConfigByNpcId.CreateStaticDefaultValue), new Action(ConfigGuessJokerAiConfigByNpcId.ResetStaticDefaultValue));
		}

		// Token: 0x0600162E RID: 5678 RVA: 0x000D6F34 File Offset: 0x000D5134
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigByNpcId.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerAiConfigByNpcId.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerAiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerAiConfig` where NpcId=?")
			});
		}

		// Token: 0x0600162F RID: 5679 RVA: 0x000D6FB3 File Offset: 0x000D51B3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigByNpcId.LogPair = null;
			ConfigGuessJokerAiConfigByNpcId.HandleId = 0;
		}

		// Token: 0x06001630 RID: 5680 RVA: 0x000D6FC1 File Offset: 0x000D51C1
		public static void Init()
		{
			ConfigGuessJokerAiConfigByNpcId.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAiConfigByNpcId.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAiConfig` where NpcId=?");
		}

		// Token: 0x06001631 RID: 5681 RVA: 0x000D6FDC File Offset: 0x000D51DC
		public static GuessJokerAiConfig? GetConfig(int p0NpcId, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAiConfigByNpcId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NpcId);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuessJokerAiConfig?(GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(configBuffer));
				}
			}
			ConfigGuessJokerAiConfigByNpcId.LogPair.Clear();
			ConfigGuessJokerAiConfigByNpcId.LogPair.Add(new ValueTuple<string, object>("NpcId", p0NpcId));
			if (!ConfigCommon.BindInt(ConfigGuessJokerAiConfigByNpcId.HandleId, 1, p0NpcId, ConfigGuessJokerAiConfigByNpcId.LogPair) || ConfigCommon.Step(ConfigGuessJokerAiConfigByNpcId.HandleId, true, ConfigGuessJokerAiConfigByNpcId.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerAiConfigByNpcId.HandleId, 0, ConfigGuessJokerAiConfigByNpcId.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerAiConfig rootAsGuessJokerAiConfig = GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAiConfigByNpcId");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0NpcId);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerAiConfigByNpcId.HandleId, ConfigGuessJokerAiConfigByNpcId.LogPair);
			return new GuessJokerAiConfig?(rootAsGuessJokerAiConfig);
		}

		// Token: 0x040019BB RID: 6587
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019BC RID: 6588
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019BD RID: 6589
		private const string TABLE = "GuessJokerAiConfig";

		// Token: 0x040019BE RID: 6590
		private const string COMMAND = "select BinData from `GuessJokerAiConfig` where NpcId=?";

		// Token: 0x040019BF RID: 6591
		private const string KEY_PREFIX = "GuessJokerAiConfigByNpcId";

		// Token: 0x040019C0 RID: 6592
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019C1 RID: 6593
		private static int HandleId;
	}
}
