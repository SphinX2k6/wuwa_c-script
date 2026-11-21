using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003C5 RID: 965
	public class ConfigGuessJokerAiConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016A5 RID: 5797 RVA: 0x000DD28C File Offset: 0x000DB48C
		static ConfigGuessJokerAiConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAiConfigAll.CreateStaticDefaultValue), new Action(ConfigGuessJokerAiConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016A6 RID: 5798 RVA: 0x000DD2AC File Offset: 0x000DB4AC
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerAiConfigAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerAiConfig"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerAiConfig`")
			});
		}

		// Token: 0x060016A7 RID: 5799 RVA: 0x000DD32B File Offset: 0x000DB52B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigAll.LogPair = null;
			ConfigGuessJokerAiConfigAll.HandleId = 0;
		}

		// Token: 0x060016A8 RID: 5800 RVA: 0x000DD339 File Offset: 0x000DB539
		public static void Init()
		{
			ConfigGuessJokerAiConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAiConfigAll.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAiConfig`");
		}

		// Token: 0x060016A9 RID: 5801 RVA: 0x000DD354 File Offset: 0x000DB554
		[NullableContext(2)]
		public static IReadOnlyList<GuessJokerAiConfig> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerAiConfigAll.HandleId, ConfigGuessJokerAiConfigAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuessJokerAiConfig> readOnlyList = (IReadOnlyList<GuessJokerAiConfig>)ConfigCommon.GetConfig("GuessJokerAiConfigAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuessJokerAiConfig> list = new List<GuessJokerAiConfig>();
			while (ConfigCommon.Step(ConfigGuessJokerAiConfigAll.HandleId, false, ConfigGuessJokerAiConfigAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerAiConfigAll.HandleId, 0, ConfigGuessJokerAiConfigAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuessJokerAiConfigAll.HandleId, ConfigGuessJokerAiConfigAll.LogPair);
					return null;
				}
				GuessJokerAiConfig rootAsGuessJokerAiConfig = GuessJokerAiConfig.GetRootAsGuessJokerAiConfig(new ByteBuffer(item2));
				list.Add(rootAsGuessJokerAiConfig);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuessJokerAiConfigAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuessJokerAiConfigAll.HandleId, ConfigGuessJokerAiConfigAll.LogPair);
			return list;
		}

		// Token: 0x04001A47 RID: 6727
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A48 RID: 6728
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A49 RID: 6729
		private const string TABLE = "GuessJokerAiConfig";

		// Token: 0x04001A4A RID: 6730
		private const string COMMAND = "select BinData from `GuessJokerAiConfig`";

		// Token: 0x04001A4B RID: 6731
		private const string KEY_PREFIX = "GuessJokerAiConfigAll";

		// Token: 0x04001A4C RID: 6732
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A4D RID: 6733
		private static int HandleId;
	}
}
