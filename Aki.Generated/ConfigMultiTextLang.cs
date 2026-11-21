using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x020005F3 RID: 1523
	public class ConfigMultiTextLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter, IQueryLocalTextNew
	{
		// Token: 0x060023BF RID: 9151 RVA: 0x00127098 File Offset: 0x00125298
		static ConfigMultiTextLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiTextLang.CreateStaticDefaultValue), new Action(ConfigMultiTextLang.ResetStaticDefaultValue));
		}

		// Token: 0x060023C0 RID: 9152 RVA: 0x001270CC File Offset: 0x001252CC
		public static void CreateStaticDefaultValue()
		{
			ConfigMultiTextLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigMultiTextLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_multi_text.db"),
				new ValueTuple<string, object>("表名", "MultiText"),
				new ValueTuple<string, object>("语句", "select content from `MultiText` where id = ?")
			});
			ConfigMultiTextLang.LangCache = new Dictionary<string, Dictionary<string, string>>();
		}

		// Token: 0x060023C1 RID: 9153 RVA: 0x0012713F File Offset: 0x0012533F
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiTextLang.LogPair = null;
			ConfigMultiTextLang.LangCache = null;
			ConfigMultiTextLang.HandleId = 0;
		}

		// Token: 0x060023C2 RID: 9154 RVA: 0x00127153 File Offset: 0x00125353
		public static void Init()
		{
			ConfigMultiTextLang.HandleId = ConfigCommon.GetLangStatementId("MultiText", "lang_multi_text.db", "select content,redirectdbindex from `MultiText` where id = ?", "");
		}

		// Token: 0x060023C3 RID: 9155 RVA: 0x00127173 File Offset: 0x00125373
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			return null;
		}

		// Token: 0x060023C4 RID: 9156 RVA: 0x00127178 File Offset: 0x00125378
		[NullableContext(2)]
		public static string GetLocalTextNew([Nullable(0)] string id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("MultiText");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigMultiTextLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigMultiTextLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigMultiTextLang.LogPair.Clear();
			ConfigMultiTextLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigMultiTextLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigMultiTextLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int handleId = ConfigCommon.GetLangStatementId("MultiText", "lang_multi_text.db", "select content,redirectdbindex from `MultiText` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(handleId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindString(handleId, 1, id, ConfigMultiTextLang.LogPair) || ConfigCommon.Step(handleId, true, ConfigMultiTextLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(handleId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, int?> valueInt = ConfigCommon.GetValueInt(handleId, 1, ConfigMultiTextLang.LogPair);
			bool item = valueInt.Item1;
			int? item2 = valueInt.Item2;
			if (!item)
			{
				ConfigCommon.Reset(handleId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			int? num = item2;
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				int langStatementId = ConfigCommon.GetLangStatementId("MultiText", ConfigMultiTextLang.SUB_DB_NAMES[item2.Value - 1], "select content from `MultiText` where id = ?", cultureOrDefault2);
				ConfigMultiTextLang.LogPair.Add(new ValueTuple<string, object>("子数据库", ConfigMultiTextLang.SUB_DB_NAMES[item2.Value - 1]));
				if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindString(langStatementId, 1, id, ConfigMultiTextLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigMultiTextLang.LogPair) <= 0)
				{
					ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				}
				else
				{
					ConfigCommon.Reset(handleId, new LogList<ValueTuple<string, object>>());
					handleId = langStatementId;
				}
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(handleId, 0, ConfigMultiTextLang.LogPair);
			bool item3 = value.Item1;
			byte[] item4 = value.Item2;
			if (!item3 || item4 == null)
			{
				ConfigCommon.Reset(handleId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item4, 0, item4.Length, ConfigMultiTextLang.LogPair);
			ConfigCommon.Reset(handleId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigMultiTextLang.GetLocalTextNew(id, "zh-Hans")))
			{
				string str = (culture == null) ? "" : ("|" + culture);
				text = "text not found|" + id + str;
			}
			dictionary[cultureOrDefault2] = text;
			return text;
		}

		// Token: 0x060023C5 RID: 9157 RVA: 0x0012745C File Offset: 0x0012565C
		public static void ClearMultiTextLangStatementIdsAndCache()
		{
			ConfigCommon.ClearLangAllStatementId("MultiText", "lang_multi_text.db");
			foreach (string dbName in ConfigMultiTextLang.SUB_DB_NAMES)
			{
				ConfigCommon.ClearLangAllStatementId("MultiText", dbName);
			}
			Dictionary<string, Dictionary<string, string>> langCache = ConfigMultiTextLang.LangCache;
			if (langCache == null)
			{
				return;
			}
			langCache.Clear();
		}

		// Token: 0x04002989 RID: 10633
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x0400298A RID: 10634
		private const string DB = "lang_multi_text.db";

		// Token: 0x0400298B RID: 10635
		private const string TABLE = "MultiText";

		// Token: 0x0400298C RID: 10636
		private const string COMMAND = "select content from `MultiText` where id = ?";

		// Token: 0x0400298D RID: 10637
		private static readonly string[] SUB_DB_NAMES = new string[]
		{
			"lang_multi_text_1sthalf.db"
		};

		// Token: 0x0400298E RID: 10638
		private const string COMMAND_WITH_REDIRECT_DB = "select content,redirectdbindex from `MultiText` where id = ?";

		// Token: 0x0400298F RID: 10639
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002990 RID: 10640
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0,
			0
		})]
		private static Dictionary<string, Dictionary<string, string>> LangCache;

		// Token: 0x04002991 RID: 10641
		private static int HandleId;
	}
}
