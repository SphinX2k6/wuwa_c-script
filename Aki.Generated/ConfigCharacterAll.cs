using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200013F RID: 319
	public class ConfigCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600077B RID: 1915 RVA: 0x00083F29 File Offset: 0x00082129
		static ConfigCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterAll.CreateStaticDefaultValue), new Action(ConfigCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600077C RID: 1916 RVA: 0x00083F48 File Offset: 0x00082148
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_moonchasing.db"),
				new ValueTuple<string, object>("文件", "z.追月节.xlsx"),
				new ValueTuple<string, object>("表名", "Character"),
				new ValueTuple<string, object>("语句", "select BinData from `Character`")
			});
		}

		// Token: 0x0600077D RID: 1917 RVA: 0x00083FC7 File Offset: 0x000821C7
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterAll.LogPair = null;
			ConfigCharacterAll.HandleId = 0;
		}

		// Token: 0x0600077E RID: 1918 RVA: 0x00083FD5 File Offset: 0x000821D5
		public static void Init()
		{
			ConfigCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterAll.HandleId, "db_moonchasing.db", "select BinData from `Character`");
		}

		// Token: 0x0600077F RID: 1919 RVA: 0x00083FF0 File Offset: 0x000821F0
		[NullableContext(2)]
		public static IReadOnlyList<Character> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterAll.HandleId, ConfigCharacterAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<Character> readOnlyList = (IReadOnlyList<Character>)ConfigCommon.GetConfig("CharacterAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<Character> list = new List<Character>();
			while (ConfigCommon.Step(ConfigCharacterAll.HandleId, false, ConfigCharacterAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterAll.HandleId, 0, ConfigCharacterAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCharacterAll.HandleId, ConfigCharacterAll.LogPair);
					return null;
				}
				Character rootAsCharacter = Character.GetRootAsCharacter(new ByteBuffer(item2));
				list.Add(rootAsCharacter);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CharacterAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCharacterAll.HandleId, ConfigCharacterAll.LogPair);
			return list;
		}

		// Token: 0x0400089D RID: 2205
		private const string DB = "db_moonchasing.db";

		// Token: 0x0400089E RID: 2206
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x0400089F RID: 2207
		private const string TABLE = "Character";

		// Token: 0x040008A0 RID: 2208
		private const string COMMAND = "select BinData from `Character`";

		// Token: 0x040008A1 RID: 2209
		private const string KEY_PREFIX = "CharacterAll";

		// Token: 0x040008A2 RID: 2210
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008A3 RID: 2211
		private static int HandleId;
	}
}
