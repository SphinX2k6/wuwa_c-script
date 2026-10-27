using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B7 RID: 951
	public class ConfigGuessJokerPlotConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001651 RID: 5713 RVA: 0x000D7B0D File Offset: 0x000D5D0D
		static ConfigGuessJokerPlotConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerPlotConfigById.CreateStaticDefaultValue), new Action(ConfigGuessJokerPlotConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x000D7B2C File Offset: 0x000D5D2C
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

		// Token: 0x06001653 RID: 5715 RVA: 0x000D7BAB File Offset: 0x000D5DAB
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerPlotConfigById.LogPair = null;
			ConfigGuessJokerPlotConfigById.HandleId = 0;
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x000D7BB9 File Offset: 0x000D5DB9
		public static void Init()
		{
			ConfigGuessJokerPlotConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerPlotConfigById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerPlotConfig` where Id=?");
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x000D7BD4 File Offset: 0x000D5DD4
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

		// Token: 0x040019E5 RID: 6629
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019E6 RID: 6630
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019E7 RID: 6631
		private const string TABLE = "GuessJokerPlotConfig";

		// Token: 0x040019E8 RID: 6632
		private const string COMMAND = "select BinData from `GuessJokerPlotConfig` where Id=?";

		// Token: 0x040019E9 RID: 6633
		private const string KEY_PREFIX = "GuessJokerPlotConfigById";

		// Token: 0x040019EA RID: 6634
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019EB RID: 6635
		private static int HandleId;
	}
}
