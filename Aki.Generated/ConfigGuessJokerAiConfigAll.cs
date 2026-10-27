using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003AF RID: 943
	public class ConfigGuessJokerAiConfigAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001621 RID: 5665 RVA: 0x000D6B38 File Offset: 0x000D4D38
		static ConfigGuessJokerAiConfigAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerAiConfigAll.CreateStaticDefaultValue), new Action(ConfigGuessJokerAiConfigAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001622 RID: 5666 RVA: 0x000D6B58 File Offset: 0x000D4D58
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

		// Token: 0x06001623 RID: 5667 RVA: 0x000D6BD7 File Offset: 0x000D4DD7
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerAiConfigAll.LogPair = null;
			ConfigGuessJokerAiConfigAll.HandleId = 0;
		}

		// Token: 0x06001624 RID: 5668 RVA: 0x000D6BE5 File Offset: 0x000D4DE5
		public static void Init()
		{
			ConfigGuessJokerAiConfigAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerAiConfigAll.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerAiConfig`");
		}

		// Token: 0x06001625 RID: 5669 RVA: 0x000D6C00 File Offset: 0x000D4E00
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

		// Token: 0x040019AD RID: 6573
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019AE RID: 6574
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019AF RID: 6575
		private const string TABLE = "GuessJokerAiConfig";

		// Token: 0x040019B0 RID: 6576
		private const string COMMAND = "select BinData from `GuessJokerAiConfig`";

		// Token: 0x040019B1 RID: 6577
		private const string KEY_PREFIX = "GuessJokerAiConfigAll";

		// Token: 0x040019B2 RID: 6578
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019B3 RID: 6579
		private static int HandleId;
	}
}
