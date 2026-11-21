using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200047A RID: 1146
	public class ConfigJokerDeckAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001AE6 RID: 6886 RVA: 0x000F503C File Offset: 0x000F323C
		static ConfigJokerDeckAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigJokerDeckAll.CreateStaticDefaultValue), new Action(ConfigJokerDeckAll.ResetStaticDefaultValue));
		}

		// Token: 0x06001AE7 RID: 6887 RVA: 0x000F505C File Offset: 0x000F325C
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

		// Token: 0x06001AE8 RID: 6888 RVA: 0x000F50DB File Offset: 0x000F32DB
		public static void ResetStaticDefaultValue()
		{
			ConfigJokerDeckAll.LogPair = null;
			ConfigJokerDeckAll.HandleId = 0;
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x000F50E9 File Offset: 0x000F32E9
		public static void Init()
		{
			ConfigJokerDeckAll.HandleId = ConfigCommon.InitDataStatement(ConfigJokerDeckAll.HandleId, "db_guessjokercard.db", "select BinData from `JokerDeck`");
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x000F5104 File Offset: 0x000F3304
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

		// Token: 0x04001F3A RID: 7994
		private const string DB = "db_guessjokercard.db";

		// Token: 0x04001F3B RID: 7995
		private const string FILE = "c.猜鬼牌玩法.xlsx";

		// Token: 0x04001F3C RID: 7996
		private const string TABLE = "JokerDeck";

		// Token: 0x04001F3D RID: 7997
		private const string COMMAND = "select BinData from `JokerDeck`";

		// Token: 0x04001F3E RID: 7998
		private const string KEY_PREFIX = "JokerDeckAll";

		// Token: 0x04001F3F RID: 7999
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001F40 RID: 8000
		private static int HandleId;
	}
}
