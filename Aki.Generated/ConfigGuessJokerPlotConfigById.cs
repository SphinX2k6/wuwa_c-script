using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CD RID: 973
	public class ConfigGuessJokerPlotConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016D5 RID: 5845 RVA: 0x000DE261 File Offset: 0x000DC461
		static ConfigGuessJokerPlotConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerPlotConfigById.CreateStaticDefaultValue), new Action(ConfigGuessJokerPlotConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x000DE280 File Offset: 0x000DC480
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerPlotConfigById.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerPlotConfigById.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerPlotConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerPlotConfig` where Id=?")
			});
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x000DE2FF File Offset: 0x000DC4FF
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerPlotConfigById.LogPair = null;
			ConfigGuessJokerPlotConfigById.HandleId = 0;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x000DE30D File Offset: 0x000DC50D
		public static void Init()
		{
			ConfigGuessJokerPlotConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerPlotConfigById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerPlotConfig` where Id=?");
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x000DE328 File Offset: 0x000DC528
		public static GuessJokerPlotConfig? GetConfig(int p0Id, bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerPlotConfigById.HandleId, ConfigGuessJokerPlotConfigById.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerPlotConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ByteBuffer configBuffer = ConfigCommon.GetConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear());
				if (configBuffer != null)
				{
					return new GuessJokerPlotConfig?(GuessJokerPlotConfig.GetRootAsGuessJokerPlotConfig(configBuffer));
				}
			}
			ConfigGuessJokerPlotConfigById.LogPair.Clear();
			ConfigGuessJokerPlotConfigById.LogPair.Add(new ValueTuple<string, object>("Id", p0Id));
			if (!ConfigCommon.BindInt(ConfigGuessJokerPlotConfigById.HandleId, 1, p0Id, ConfigGuessJokerPlotConfigById.LogPair) || ConfigCommon.Step(ConfigGuessJokerPlotConfigById.HandleId, true, ConfigGuessJokerPlotConfigById.LogPair) <= 0)
			{
				ConfigCommon.Reset(ConfigGuessJokerPlotConfigById.HandleId, ConfigGuessJokerPlotConfigById.LogPair);
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerPlotConfigById.HandleId, 0, ConfigGuessJokerPlotConfigById.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item)
			{
				ConfigCommon.Reset(ConfigGuessJokerPlotConfigById.HandleId, ConfigGuessJokerPlotConfigById.LogPair);
				return null;
			}
			ByteBuffer byteBuffer = new ByteBuffer(item2);
			GuessJokerPlotConfig rootAsGuessJokerPlotConfig = GuessJokerPlotConfig.GetRootAsGuessJokerPlotConfig(byteBuffer);
			if (useCache)
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 2);
				defaultInterpolatedStringHandler.AppendFormatted("GuessJokerPlotConfigById");
				defaultInterpolatedStringHandler.AppendLiteral("#");
				defaultInterpolatedStringHandler.AppendFormatted<int>(p0Id);
				ConfigCommon.SaveConfigBuffer(defaultInterpolatedStringHandler.ToStringAndClear(), byteBuffer, 1);
			}
			ConfigCommon.Reset(ConfigGuessJokerPlotConfigById.HandleId, ConfigGuessJokerPlotConfigById.LogPair);
			return new GuessJokerPlotConfig?(rootAsGuessJokerPlotConfig);
		}

		// Token: 0x04001A7F RID: 6783
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A80 RID: 6784
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A81 RID: 6785
		private const string TABLE = "GuessJokerPlotConfig";

		// Token: 0x04001A82 RID: 6786
		private const string COMMAND = "select BinData from `GuessJokerPlotConfig` where Id=?";

		// Token: 0x04001A83 RID: 6787
		private const string KEY_PREFIX = "GuessJokerPlotConfigById";

		// Token: 0x04001A84 RID: 6788
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A85 RID: 6789
		private static int HandleId;
	}
}
