using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200014E RID: 334
	public class ConfigCharacterAll : IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060007D5 RID: 2005 RVA: 0x0008988D File Offset: 0x00087A8D
		static ConfigCharacterAll()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCharacterAll.CreateStaticDefaultValue), new Action(ConfigCharacterAll.ResetStaticDefaultValue));
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x000898AC File Offset: 0x00087AAC
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

		// Token: 0x060007D7 RID: 2007 RVA: 0x0008992B File Offset: 0x00087B2B
		public static void ResetStaticDefaultValue()
		{
			ConfigCharacterAll.LogPair = null;
			ConfigCharacterAll.HandleId = 0;
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00089939 File Offset: 0x00087B39
		public static void Init()
		{
			ConfigCharacterAll.HandleId = ConfigCommon.InitDataStatement(ConfigCharacterAll.HandleId, "db_moonchasing.db", "select BinData from `Character`");
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x00089954 File Offset: 0x00087B54
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

		// Token: 0x04000906 RID: 2310
		private const string DB = "db_moonchasing.db";

		// Token: 0x04000907 RID: 2311
		private const string FILE = "z.追月节.xlsx";

		// Token: 0x04000908 RID: 2312
		private const string TABLE = "Character";

		// Token: 0x04000909 RID: 2313
		private const string COMMAND = "select BinData from `Character`";

		// Token: 0x0400090A RID: 2314
		private const string KEY_PREFIX = "CharacterAll";

		// Token: 0x0400090B RID: 2315
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400090C RID: 2316
		private static int HandleId;
	}
}
