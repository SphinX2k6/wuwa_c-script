using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x0200054D RID: 1357
	public class ConfigMonsterDisplayLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001FDB RID: 8155 RVA: 0x0010D6A8 File Offset: 0x0010B8A8
		static ConfigMonsterDisplayLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDisplayLang.CreateStaticDefaultValue), new Action(ConfigMonsterDisplayLang.ResetStaticDefaultValue));
		}

		// Token: 0x06001FDC RID: 8156 RVA: 0x0010D6C8 File Offset: 0x0010B8C8
		public static void CreateStaticDefaultValue()
		{
			ConfigMonsterDisplayLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMonsterDisplayLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_monsterdisplay.db"),
				new ValueTuple<string, object>("表名", "MonsterDisplay"),
				new ValueTuple<string, object>("语句", "select content from `MonsterDisplay` where id = ?")
			});
			ConfigMonsterDisplayLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x06001FDD RID: 8157 RVA: 0x0010D73B File Offset: 0x0010B93B
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDisplayLang.LogPair = null;
			ConfigMonsterDisplayLang.LangCache = null;
			ConfigMonsterDisplayLang.HandleId = 0;
		}

		// Token: 0x06001FDE RID: 8158 RVA: 0x0010D74F File Offset: 0x0010B94F
		public static void Init()
		{
			ConfigMonsterDisplayLang.HandleId = ConfigCommon.GetLangStatementId("MonsterDisplay", "lang_monsterdisplay.db", "select content from `MonsterDisplay` where id = ?", "");
		}

		// Token: 0x06001FDF RID: 8159 RVA: 0x0010D770 File Offset: 0x0010B970
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MonsterDisplay");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigMonsterDisplayLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigMonsterDisplayLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigMonsterDisplayLang.LogPair.Clear();
			ConfigMonsterDisplayLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigMonsterDisplayLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigMonsterDisplayLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("MonsterDisplay", "lang_monsterdisplay.db", "select content from `MonsterDisplay` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigMonsterDisplayLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigMonsterDisplayLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigMonsterDisplayLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigMonsterDisplayLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigMonsterDisplayLang.GetLocalText(id, "zh-Hans")))
			{
				string value2 = (culture == null) ? "" : ("|" + culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(1, 3);
				defaultInterpolatedStringHandler.AppendFormatted("text not found");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendFormatted(value2);
				text = defaultInterpolatedStringHandler.ToStringAndClear();
			}
			dictionary[cultureOrDefault2] = text;
			return text;
		}

		// Token: 0x040024FF RID: 9471
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x04002500 RID: 9472
		private const string DB = "lang_monsterdisplay.db";

		// Token: 0x04002501 RID: 9473
		private const string TABLE = "MonsterDisplay";

		// Token: 0x04002502 RID: 9474
		private const string COMMAND = "select content from `MonsterDisplay` where id = ?";

		// Token: 0x04002503 RID: 9475
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002504 RID: 9476
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x04002505 RID: 9477
		private static int HandleId;
	}
}
