using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x0200042B RID: 1067
	public class ConfigHotPatchTextLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter, IQueryLocalTextNew
	{
		// Token: 0x06001909 RID: 6409 RVA: 0x000EAEF8 File Offset: 0x000E90F8
		static ConfigHotPatchTextLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigHotPatchTextLang.CreateStaticDefaultValue), new Action(ConfigHotPatchTextLang.ResetStaticDefaultValue));
		}

		// Token: 0x0600190A RID: 6410 RVA: 0x000EAF18 File Offset: 0x000E9118
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

		// Token: 0x0600190B RID: 6411 RVA: 0x000EAF8B File Offset: 0x000E918B
		public static void ResetStaticDefaultValue()
		{
			ConfigHotPatchTextLang.LogPair = null;
			ConfigHotPatchTextLang.LangCache = null;
			ConfigHotPatchTextLang.HandleId = 0;
		}

		// Token: 0x0600190C RID: 6412 RVA: 0x000EAF9F File Offset: 0x000E919F
		public static void Init()
		{
			ConfigHotPatchTextLang.HandleId = ConfigCommon.GetLangStatementId("HotPatchText", "lang_hot_patch.db", "select content from `HotPatchText` where id = ?", "");
		}

		// Token: 0x0600190D RID: 6413 RVA: 0x000EAFBF File Offset: 0x000E91BF
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			return null;
		}

		// Token: 0x0600190E RID: 6414 RVA: 0x000EAFC4 File Offset: 0x000E91C4
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

		// Token: 0x0600190F RID: 6415 RVA: 0x000EB1C4 File Offset: 0x000E93C4
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

		// Token: 0x04001D11 RID: 7441
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x04001D12 RID: 7442
		private const string DB = "lang_hot_patch.db";

		// Token: 0x04001D13 RID: 7443
		private const string TABLE = "HotPatchText";

		// Token: 0x04001D14 RID: 7444
		private const string COMMAND = "select content from `HotPatchText` where id = ?";

		// Token: 0x04001D15 RID: 7445
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001D16 RID: 7446
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0,
			0
		})]
		private static Dictionary<string, Dictionary<string, string>> LangCache;

		// Token: 0x04001D17 RID: 7447
		private static int HandleId;
	}
}
