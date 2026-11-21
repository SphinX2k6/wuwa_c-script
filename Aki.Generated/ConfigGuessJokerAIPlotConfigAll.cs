using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C8 RID: 968
	public class ConfigGuessJokerAIPlotConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x000DD8B0 File Offset: 0x000DBAB0
		static ConfigGuessJokerAIPlotConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAIPlotConfigAll.CreateStaticDefaultValue), new Action(ConfigGuessJokerAIPlotConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000DD8D0 File Offset: 0x000DBAD0
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

		// Token: 0x060016B9 RID: 5817 RVA: 0x000DD94F File Offset: 0x000DBB4F
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAIPlotConfigAll.LogPair = null;
			ConfigGuessJokerAIPlotConfigAll.HandleId = 0;
		}

		// Token: 0x060016BA RID: 5818 RVA: 0x000DD95D File Offset: 0x000DBB5D
		public static void Init()
		{
			ConfigGuessJokerAIPlotConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAIPlotConfigAll.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAIPlotConfig`");
		}

		// Token: 0x060016BB RID: 5819 RVA: 0x000DD978 File Offset: 0x000DBB78
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

		// Token: 0x04001A5C RID: 6748
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A5D RID: 6749
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A5E RID: 6750
		private const string TABLE = "GuessJokerAIPlotConfig";

		// Token: 0x04001A5F RID: 6751
		private const string COMMAND = "select BinData from `GuessJokerAIPlotConfig`";

		// Token: 0x04001A60 RID: 6752
		private const string KEY_PREFIX = "GuessJokerAIPlotConfigAll";

		// Token: 0x04001A61 RID: 6753
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A62 RID: 6754
		private static int HandleId;
	}
}
