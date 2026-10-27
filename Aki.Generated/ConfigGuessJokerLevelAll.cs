using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003B4 RID: 948
	public class ConfigGuessJokerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600163F RID: 5695 RVA: 0x000D7538 File Offset: 0x000D5738
		static ConfigGuessJokerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerLevelAll.CreateStaticDefaultValue), new Action(ConfigGuessJokerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001640 RID: 5696 RVA: 0x000D7558 File Offset: 0x000D5758
		public static void CreateStaticDefaultValue()
		{
			ConfigGuessJokerLevelAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigGuessJokerLevelAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "GuessJokerLevel"),
				new ValueTuple<string, object>("语句", "select BinData from `GuessJokerLevel`")
			});
		}

		// Token: 0x06001641 RID: 5697 RVA: 0x000D75D7 File Offset: 0x000D57D7
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerLevelAll.LogPair = null;
			ConfigGuessJokerLevelAll.HandleId = 0;
		}

		// Token: 0x06001642 RID: 5698 RVA: 0x000D75E5 File Offset: 0x000D57E5
		public static void Init()
		{
			ConfigGuessJokerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerLevelAll.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerLevel`");
		}

		// Token: 0x06001643 RID: 5699 RVA: 0x000D7600 File Offset: 0x000D5800
		[NullableContext(2)]
		public static IReadOnlyList<GuessJokerLevel> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigGuessJokerLevelAll.HandleId, ConfigGuessJokerLevelAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<GuessJokerLevel> readOnlyList = (IReadOnlyList<GuessJokerLevel>)ConfigCommon.GetConfig("GuessJokerLevelAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<GuessJokerLevel> list = new List<GuessJokerLevel>();
			while (ConfigCommon.Step(ConfigGuessJokerLevelAll.HandleId, false, ConfigGuessJokerLevelAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigGuessJokerLevelAll.HandleId, 0, ConfigGuessJokerLevelAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigGuessJokerLevelAll.HandleId, ConfigGuessJokerLevelAll.LogPair);
					return null;
				}
				GuessJokerLevel rootAsGuessJokerLevel = GuessJokerLevel.GetRootAsGuessJokerLevel(new ByteBuffer(item2));
				list.Add(rootAsGuessJokerLevel);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("GuessJokerLevelAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigGuessJokerLevelAll.HandleId, ConfigGuessJokerLevelAll.LogPair);
			return list;
		}

		// Token: 0x040019D0 RID: 6608
		private const string DB = "db_guessjokercard.db";

		// Token: 0x040019D1 RID: 6609
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x040019D2 RID: 6610
		private const string TABLE = "GuessJokerLevel";

		// Token: 0x040019D3 RID: 6611
		private const string COMMAND = "select BinData from `GuessJokerLevel`";

		// Token: 0x040019D4 RID: 6612
		private const string KEY_PREFIX = "GuessJokerLevelAll";

		// Token: 0x040019D5 RID: 6613
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040019D6 RID: 6614
		private static int HandleId;
	}
}
