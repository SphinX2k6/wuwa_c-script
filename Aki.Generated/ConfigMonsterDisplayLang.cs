using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000563 RID: 1379
	public class ConfigMonsterDisplayLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x00113DFC File Offset: 0x00111FFC
		static ConfigMonsterDisplayLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMonsterDisplayLang.CreateStaticDefaultValue), new Action(ConfigMonsterDisplayLang.ResetStaticDefaultValue));
		}

		// Token: 0x06002060 RID: 8288 RVA: 0x00113E1C File Offset: 0x0011201C
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

		// Token: 0x06002061 RID: 8289 RVA: 0x00113E8F File Offset: 0x0011208F
		public static void ResetStaticDefaultValue()
		{
			ConfigMonsterDisplayLang.LogPair = null;
			ConfigMonsterDisplayLang.LangCache = null;
			ConfigMonsterDisplayLang.HandleId = 0;
		}

		// Token: 0x06002062 RID: 8290 RVA: 0x00113EA3 File Offset: 0x001120A3
		public static void Init()
		{
			ConfigMonsterDisplayLang.HandleId = ConfigCommon.GetLangStatementId("MonsterDisplay", "lang_monsterdisplay.db", "select content from `MonsterDisplay` where id = ?", "");
		}

		// Token: 0x06002063 RID: 8291 RVA: 0x00113EC4 File Offset: 0x001120C4
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

		// Token: 0x04002599 RID: 9625
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x0400259A RID: 9626
		private const string DB = "lang_monsterdisplay.db";

		// Token: 0x0400259B RID: 9627
		private const string TABLE = "MonsterDisplay";

		// Token: 0x0400259C RID: 9628
		private const string COMMAND = "select content from `MonsterDisplay` where id = ?";

		// Token: 0x0400259D RID: 9629
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x0400259E RID: 9630
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x0400259F RID: 9631
		private static int HandleId;
	}
}
