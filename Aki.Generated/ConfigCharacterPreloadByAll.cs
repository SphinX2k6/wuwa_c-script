using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000144 RID: 324
	public class ConfigCharacterPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000799 RID: 1945 RVA: 0x00084AE0 File Offset: 0x00082CE0
		static ConfigCharacterPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterPreloadByAll.CreateStaticDefaultValue), new Action(ConfigCharacterPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x0600079A RID: 1946 RVA: 0x00084B00 File Offset: 0x00082D00
		public static void CreateStaticDefaultValue()
		{
			ConfigCharacterPreloadByAll.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCharacterPreloadByAll.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "db_character_preload.db"),
				new ValueTuple<string, object>("文件", "Preload/CharacterPreload.csv"),
				new ValueTuple<string, object>("表名", "CharacterPreload"),
				new ValueTuple<string, object>("语句", "select BinData from `CharacterPreload`")
			});
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x00084B7F File Offset: 0x00082D7F
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterPreloadByAll.LogPair = null;
			ConfigCharacterPreloadByAll.HandleId = 0;
		}

		// Token: 0x0600079C RID: 1948 RVA: 0x00084B8D File Offset: 0x00082D8D
		public static void Init()
		{
			ConfigCharacterPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterPreloadByAll.HandleId, "db_character_preload.db", "select BinData from `CharacterPreload`");
		}

		// Token: 0x0600079D RID: 1949 RVA: 0x00084BA8 File Offset: 0x00082DA8
		[NullableContext(2)]
		public static IReadOnlyList<CharacterPreload> GetConfigList(bool useCache = true)
		{
			if (!ConfigCommon.CheckStatement(ConfigCharacterPreloadByAll.HandleId, ConfigCharacterPreloadByAll.LogPair))
			{
				return null;
			}
			if (useCache)
			{
				IReadOnlyList<CharacterPreload> readOnlyList = (IReadOnlyList<CharacterPreload>)ConfigCommon.GetConfig("CharacterPreloadByAll");
				if (readOnlyList != null)
				{
					return readOnlyList;
				}
			}
			List<CharacterPreload> list = new List<CharacterPreload>();
			while (ConfigCommon.Step(ConfigCharacterPreloadByAll.HandleId, false, ConfigCharacterPreloadByAll.LogPair) == 1)
			{
				ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(ConfigCharacterPreloadByAll.HandleId, 0, ConfigCharacterPreloadByAll.LogPair);
				bool item = value.Item1;
				byte[] item2 = value.Item2;
				if (!item)
				{
					ConfigCommon.Reset(ConfigCharacterPreloadByAll.HandleId, ConfigCharacterPreloadByAll.LogPair);
					return null;
				}
				CharacterPreload rootAsCharacterPreload = CharacterPreload.GetRootAsCharacterPreload(new ByteBuffer(item2));
				list.Add(rootAsCharacterPreload);
			}
			if (useCache)
			{
				ConfigCommon.SaveConfig("CharacterPreloadByAll", list, list.Count);
			}
			ConfigCommon.Reset(ConfigCharacterPreloadByAll.HandleId, ConfigCharacterPreloadByAll.LogPair);
			return list;
		}

		// Token: 0x040008C0 RID: 2240
		private const string DB = "db_character_preload.db";

		// Token: 0x040008C1 RID: 2241
		private const string FILE = "Preload/CharacterPreload.csv";

		// Token: 0x040008C2 RID: 2242
		private const string TABLE = "CharacterPreload";

		// Token: 0x040008C3 RID: 2243
		private const string COMMAND = "select BinData from `CharacterPreload`";

		// Token: 0x040008C4 RID: 2244
		private const string KEY_PREFIX = "CharacterPreloadByAll";

		// Token: 0x040008C5 RID: 2245
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040008C6 RID: 2246
		private static int HandleId;
	}
}
