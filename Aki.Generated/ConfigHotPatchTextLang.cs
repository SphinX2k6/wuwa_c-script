using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000415 RID: 1045
	public class ConfigHotPatchTextLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter, IQueryLocalTextNew
	{
		// Token: 0x06001885 RID: 6277 RVA: 0x000E47A4 File Offset: 0x000E29A4
		static ConfigHotPatchTextLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotPatchTextLang.CreateStaticDefaultValue), new Action(ConfigHotPatchTextLang.ResetStaticDefaultValue));
		}

		// Token: 0x06001886 RID: 6278 RVA: 0x000E47C4 File Offset: 0x000E29C4
		public static void CreateStaticDefaultValue()
		{
			ConfigHotPatchTextLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigHotPatchTextLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_hot_patch.db"),
				new ValueTuple<string, object>("表名", "HotPatchText"),
				new ValueTuple<string, object>("语句", "select content from `HotPatchText` where id = ?")
			});
			ConfigHotPatchTextLang.LangCache = new Dictionary<string, Dictionary<string, string>>();
		}

		// Token: 0x06001887 RID: 6279 RVA: 0x000E4837 File Offset: 0x000E2A37
		public static void ResetStaticDefaultValue()
		{
			ConfigHotPatchTextLang.LogPair = null;
			ConfigHotPatchTextLang.LangCache = null;
			ConfigHotPatchTextLang.HandleId = 0;
		}

		// Token: 0x06001888 RID: 6280 RVA: 0x000E484B File Offset: 0x000E2A4B
		public static void Init()
		{
			ConfigHotPatchTextLang.HandleId = ConfigCommon.GetLangStatementId("HotPatchText", "lang_hot_patch.db", "select content from `HotPatchText` where id = ?", "");
		}

		// Token: 0x06001889 RID: 6281 RVA: 0x000E486B File Offset: 0x000E2A6B
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			return null;
		}

		// Token: 0x0600188A RID: 6282 RVA: 0x000E4870 File Offset: 0x000E2A70
		[NullableContext(2)]
		public static string GetLocalTextNew([Nullable(0)] string id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("HotPatchText");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigHotPatchTextLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigHotPatchTextLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigHotPatchTextLang.LogPair.Clear();
			ConfigHotPatchTextLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigHotPatchTextLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigHotPatchTextLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("HotPatchText", "lang_hot_patch.db", "select content from `HotPatchText` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindString(langStatementId, 1, id, ConfigHotPatchTextLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigHotPatchTextLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigHotPatchTextLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigHotPatchTextLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigHotPatchTextLang.GetLocalTextNew(id, "zh-Hans")))
			{
				string str = (culture == null) ? "" : ("|" + culture);
				text = "text not found|" + id + str;
			}
			dictionary[cultureOrDefault2] = text;
			return text;
		}

		// Token: 0x0600188B RID: 6283 RVA: 0x000E4A70 File Offset: 0x000E2C70
		public static void ClearHotPatchTextLangStatementIdsAndCache()
		{
			ConfigCommon.ClearLangAllStatementId("HotPatchText", "lang_hot_patch.db");
			Dictionary<string, Dictionary<string, string>> langCache = ConfigHotPatchTextLang.LangCache;
			if (langCache == null)
			{
				return;
			}
			langCache.Clear();
		}

		// Token: 0x04001C77 RID: 7287
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x04001C78 RID: 7288
		private const string DB = "lang_hot_patch.db";

		// Token: 0x04001C79 RID: 7289
		private const string TABLE = "HotPatchText";

		// Token: 0x04001C7A RID: 7290
		private const string COMMAND = "select content from `HotPatchText` where id = ?";

		// Token: 0x04001C7B RID: 7291
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001C7C RID: 7292
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0,
			0
		})]
		private static Dictionary<string, Dictionary<string, string>> LangCache;

		// Token: 0x04001C7D RID: 7293
		private static int HandleId;
	}
}
