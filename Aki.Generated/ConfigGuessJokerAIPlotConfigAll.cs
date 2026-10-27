using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B2 RID: 946
	public class ConfigGuessJokerAIPlotConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001633 RID: 5683 RVA: 0x000D715C File Offset: 0x000D535C
		static ConfigGuessJokerAIPlotConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAIPlotConfigAll.CreateStaticDefaultValue), new Action(ConfigGuessJokerAIPlotConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001634 RID: 5684 RVA: 0x000D717C File Offset: 0x000D537C
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerAIPlotConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerAIPlotConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerAIPlotConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerAIPlotConfig`")
			});
		}

		// Token: 0x06001635 RID: 5685 RVA: 0x000D71FB File Offset: 0x000D53FB
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAIPlotConfigAll.LogPair = null;
			ConfigGuessJokerAIPlotConfigAll.HandleId = 0;
		}

		// Token: 0x06001636 RID: 5686 RVA: 0x000D7209 File Offset: 0x000D5409
		public static void Init()
		{
			ConfigGuessJokerAIPlotConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAIPlotConfigAll.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAIPlotConfig`");
		}

		// Token: 0x06001637 RID: 5687 RVA: 0x000D7224 File Offset: 0x000D5424
		[NullableContext(2)]
		public static IReadOnlyList<GuessJokerAIPlotConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerAIPlotConfigAll.HandleId, ConfigGuessJokerAIPlotConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuessJokerAIPlotConfig> readOnlyList = (IReadOnlyList<GuessJokerAIPlotConfig>)ConfigCommon.GetConfig("GuessJokerAIPlotConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuessJokerAIPlotConfig> list = new List<GuessJokerAIPlotConfig>();
			while (ConfigCommon.Step(ConfigGuessJokerAIPlotConfigAll.HandleId, false, ConfigGuessJokerAIPlotConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerAIPlotConfigAll.HandleId, 0, ConfigGuessJokerAIPlotConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuessJokerAIPlotConfigAll.HandleId, ConfigGuessJokerAIPlotConfigAll.LogPair);
					return null;
				}
				GuessJokerAIPlotConfig rootAsGuessJokerAIPlotConfig = GuessJokerAIPlotConfig.GetRootAsGuessJokerAIPlotConfig(new ByteBuffer(item2));
				list.Add(rootAsGuessJokerAIPlotConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuessJokerAIPlotConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuessJokerAIPlotConfigAll.HandleId, ConfigGuessJokerAIPlotConfigAll.LogPair);
			return list;
		}

		// Token: 0x040019C2 RID: 6594
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019C3 RID: 6595
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019C4 RID: 6596
		private const string TABLE = "GuessJokerAIPlotConfig";

		// Token: 0x040019C5 RID: 6597
		private const string COMMAND = "select BinData from `GuessJokerAIPlotConfig`";

		// Token: 0x040019C6 RID: 6598
		private const string KEY_PREFIX = "GuessJokerAIPlotConfigAll";

		// Token: 0x040019C7 RID: 6599
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019C8 RID: 6600
		private static int HandleId;
	}
}
