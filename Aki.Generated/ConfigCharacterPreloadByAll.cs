using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000153 RID: 339
	public class ConfigCharacterPreloadByAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007F3 RID: 2035 RVA: 0x0008A444 File Offset: 0x00088644
		static ConfigCharacterPreloadByAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterPreloadByAll.CreateStaticDefaultValue), new Action(ConfigCharacterPreloadByAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0008A464 File Offset: 0x00088664
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

		// Token: 0x060007F5 RID: 2037 RVA: 0x0008A4E3 File Offset: 0x000886E3
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterPreloadByAll.LogPair = null;
			ConfigCharacterPreloadByAll.HandleId = 0;
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0008A4F1 File Offset: 0x000886F1
		public static void Init()
		{
			ConfigCharacterPreloadByAll.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterPreloadByAll.HandleId, "db_character_preload.db", "select BinData from `CharacterPreload`");
		}

		// Token: 0x060007F7 RID: 2039 RVA: 0x0008A50C File Offset: 0x0008870C
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

		// Token: 0x04000929 RID: 2345
		private const string DB = "db_character_preload.db";

		// Token: 0x0400092A RID: 2346
		private const string FILE = "Preload/CharacterPreload.csv";

		// Token: 0x0400092B RID: 2347
		private const string TABLE = "CharacterPreload";

		// Token: 0x0400092C RID: 2348
		private const string COMMAND = "select BinData from `CharacterPreload`";

		// Token: 0x0400092D RID: 2349
		private const string KEY_PREFIX = "CharacterPreloadByAll";

		// Token: 0x0400092E RID: 2350
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400092F RID: 2351
		private static int HandleId;
	}
}
