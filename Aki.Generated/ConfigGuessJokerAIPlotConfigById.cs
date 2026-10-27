using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B3 RID: 947
	public class ConfigGuessJokerAIPlotConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001639 RID: 5689 RVA: 0x000D72EF File Offset: 0x000D54EF
		static ConfigGuessJokerAIPlotConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAIPlotConfigById.CreateStaticDefaultValue), new Action(ConfigGuessJokerAIPlotConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x0600163A RID: 5690 RVA: 0x000D7310 File Offset: 0x000D5510
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerAIPlotConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerAIPlotConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerAIPlotConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerAIPlotConfig` where Id=?")
			});
		}

		// Token: 0x0600163B RID: 5691 RVA: 0x000D738F File Offset: 0x000D558F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAIPlotConfigById.LogPair = null;
			ConfigGuessJokerAIPlotConfigById.HandleId = 0;
		}

		// Token: 0x0600163C RID: 5692 RVA: 0x000D739D File Offset: 0x000D559D
		public static void Init()
		{
			ConfigGuessJokerAIPlotConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAIPlotConfigById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAIPlotConfig` where Id=?");
		}

		// Token: 0x0600163D RID: 5693 RVA: 0x000D73B8 File Offset: 0x000D55B8
		public static GuessJokerAIPlotConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerAIPlotConfigById.HandleId, ConfigGuessJokerAIPlotConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAIPlotConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuessJokerAIPlotConfig?(GuessJokerAIPlotConfig.GetRootAsGuessJokerAIPlotConfig(configBuffer));
				}
			}
			ConfigGuessJokerAIPlotConfigById.LogPair.Clear();
			ConfigGuessJokerAIPlotConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuessJokerAIPlotConfigById.HandleId, 1, p0Id, ConfigGuessJokerAIPlotConfigById.LogPair) || ConfigCommon.Step(ConfigGuessJokerAIPlotConfigById.HandleId, true, ConfigGuessJokerAIPlotConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerAIPlotConfigById.HandleId, ConfigGuessJokerAIPlotConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerAIPlotConfigById.HandleId, 0, ConfigGuessJokerAIPlotConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerAIPlotConfigById.HandleId, ConfigGuessJokerAIPlotConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerAIPlotConfig rootAsGuessJokerAIPlotConfig = GuessJokerAIPlotConfig.GetRootAsGuessJokerAIPlotConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerAIPlotConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerAIPlotConfigById.HandleId, ConfigGuessJokerAIPlotConfigById.LogPair);
			return new GuessJokerAIPlotConfig?(rootAsGuessJokerAIPlotConfig);
		}

		// Token: 0x040019C9 RID: 6601
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019CA RID: 6602
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019CB RID: 6603
		private const string TABLE = "GuessJokerAIPlotConfig";

		// Token: 0x040019CC RID: 6604
		private const string COMMAND = "select BinData from `GuessJokerAIPlotConfig` where Id=?";

		// Token: 0x040019CD RID: 6605
		private const string KEY_PREFIX = "GuessJokerAIPlotConfigById";

		// Token: 0x040019CE RID: 6606
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019CF RID: 6607
		private static int HandleId;
	}
}
