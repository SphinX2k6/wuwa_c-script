using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000464 RID: 1124
	public class ConfigJokerDeckAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001A62 RID: 6754 RVA: 0x000EE8E8 File Offset: 0x000ECAE8
		static ConfigJokerDeckAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigJokerDeckAll.CreateStaticDefaultValue), new Action(ConfigJokerDeckAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001A63 RID: 6755 RVA: 0x000EE908 File Offset: 0x000ECB08
		public static void CreateStaticDefaultValue()
		{
			ConfigJokerDeckAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigJokerDeckAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_guessjokercard.db"),
				new ValueTuple<string, object>("文件", "c.猜鬼牌玩法.xlsx"),
				new ValueTuple<string, object>("表名", "JokerDeck"),
				new ValueTuple<string, object>("语句", "select BinData from `JokerDeck`")
			});
		}

		// Token: 0x06001A64 RID: 6756 RVA: 0x000EE987 File Offset: 0x000ECB87
		public static void ResetStaticDefaultValue()
		{
			ConfigJokerDeckAll.LogPair = null;
			ConfigJokerDeckAll.HandleId = 0;
		}

		// Token: 0x06001A65 RID: 6757 RVA: 0x000EE995 File Offset: 0x000ECB95
		public static void Init()
		{
			ConfigJokerDeckAll.HandleId = ConfigCommon.InitDataStatement(ConfigJokerDeckAll.HandleId, "db_guessjokercard.db", "select BinData from `JokerDeck`");
		}

		// Token: 0x06001A66 RID: 6758 RVA: 0x000EE9B0 File Offset: 0x000ECBB0
		[NullableContext(2)]
		public static IReadOnlyList<JokerDeck> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigJokerDeckAll.HandleId, ConfigJokerDeckAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<JokerDeck> readOnlyList = (IReadOnlyList<JokerDeck>)ConfigCommon.GetConfig("JokerDeckAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<JokerDeck> list = new List<JokerDeck>();
			while (ConfigCommon.Step(ConfigJokerDeckAll.HandleId, false, ConfigJokerDeckAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigJokerDeckAll.HandleId, 0, ConfigJokerDeckAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigJokerDeckAll.HandleId, ConfigJokerDeckAll.LogPair);
					return null;
				}
				JokerDeck rootAsJokerDeck = JokerDeck.GetRootAsJokerDeck(new ByteBuffer(item2));
				list.Add(rootAsJokerDeck);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("JokerDeckAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigJokerDeckAll.HandleId, ConfigJokerDeckAll.LogPair);
			return list;
		}

		// Token: 0x04001EA0 RID: 7840
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001EA1 RID: 7841
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001EA2 RID: 7842
		private const string TABLE = "JokerDeck";

		// Token: 0x04001EA3 RID: 7843
		private const string COMMAND = "select BinData from `JokerDeck`";

		// Token: 0x04001EA4 RID: 7844
		private const string KEY_PREFIX = "JokerDeckAll";

		// Token: 0x04001EA5 RID: 7845
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001EA6 RID: 7846
		private static int HandleId;
	}
}
