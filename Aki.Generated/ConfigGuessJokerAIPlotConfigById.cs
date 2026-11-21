using System;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C9 RID: 969
	public class ConfigGuessJokerAIPlotConfigById : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x000DDA43 File Offset: 0x000DBC43
		static ConfigGuessJokerAIPlotConfigById()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAIPlotConfigById.CreateStaticDefaultValue), new Action(ConfigGuessJokerAIPlotConfigById.ResetStaticDefaultValue));
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x000DDA64 File Offset: 0x000DBC64
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

		// Token: 0x060016BF RID: 5823 RVA: 0x000DDAE3 File Offset: 0x000DBCE3
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAIPlotConfigById.LogPair = null;
			ConfigGuessJokerAIPlotConfigById.HandleId = 0;
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x000DDAF1 File Offset: 0x000DBCF1
		public static void Init()
		{
			ConfigGuessJokerAIPlotConfigById.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAIPlotConfigById.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAIPlotConfig` where Id=?");
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000DDB0C File Offset: 0x000DBD0C
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

		// Token: 0x04001A63 RID: 6755
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A64 RID: 6756
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A65 RID: 6757
		private const string TABLE = "GuessJokerAIPlotConfig";

		// Token: 0x04001A66 RID: 6758
		private const string COMMAND = "select BinData from `GuessJokerAIPlotConfig` where Id=?";

		// Token: 0x04001A67 RID: 6759
		private const string KEY_PREFIX = "GuessJokerAIPlotConfigById";

		// Token: 0x04001A68 RID: 6760
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A69 RID: 6761
		private static int HandleId;
	}
}
