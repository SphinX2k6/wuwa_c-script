using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020003CA RID: 970
	public class ConfigGuessJokerLevelAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060016C3 RID: 5827 RVA: 0x000DDC8C File Offset: 0x000DBE8C
		static ConfigGuessJokerLevelAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigGuessJokerLevelAll.CreateStaticDefaultValue), new Action(ConfigGuessJokerLevelAll.ResetStaticDefaultValue));
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000DDCAC File Offset: 0x000DBEAC
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

		// Token: 0x060016C5 RID: 5829 RVA: 0x000DDD2B File Offset: 0x000DBF2B
		public static void ResetStaticDefaultValue()
		{
			ConfigGuessJokerLevelAll.LogPair = null;
			ConfigGuessJokerLevelAll.HandleId = 0;
		}

		// Token: 0x060016C6 RID: 5830 RVA: 0x000DDD39 File Offset: 0x000DBF39
		public static void Init()
		{
			ConfigGuessJokerLevelAll.HandleId = ConfigCommon.InitDataStatement(ConfigGuessJokerLevelAll.HandleId, "db_guessjokercard.db", "select BinData from `GuessJokerLevel`");
		}

		// Token: 0x060016C7 RID: 5831 RVA: 0x000DDD54 File Offset: 0x000DBF54
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

		// Token: 0x04001A6A RID: 6762
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001A6B RID: 6763
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001A6C RID: 6764
		private const string TABLE = "GuessJokerLevel";

		// Token: 0x04001A6D RID: 6765
		private const string COMMAND = "select BinData from `GuessJokerLevel`";

		// Token: 0x04001A6E RID: 6766
		private const string KEY_PREFIX = "GuessJokerLevelAll";

		// Token: 0x04001A6F RID: 6767
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001A70 RID: 6768
		private static int HandleId;
	}
}
