using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000994 RID: 2452
	public class ConfigSubtitleTextLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600398C RID: 14732 RVA: 0x0019EEA0 File Offset: 0x0019D0A0
		static ConfigSubtitleTextLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSubtitleTextLang.CreateStaticDefaultValue), new Action(ConfigSubtitleTextLang.ResetStaticDefaultValue));
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x0019EEC0 File Offset: 0x0019D0C0
		public static void CreateStaticDefaultValue()
		{
			ConfigSubtitleTextLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSubtitleTextLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_subtitle_text.db"),
				new ValueTuple<string, object>("表名", "SubtitleText"),
				new ValueTuple<string, object>("语句", "select content from `SubtitleText` where id = ?")
			});
			ConfigSubtitleTextLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x0019EF33 File Offset: 0x0019D133
		public static void ResetStaticDefaultValue()
		{
			ConfigSubtitleTextLang.LogPair = null;
			ConfigSubtitleTextLang.LangCache = null;
			ConfigSubtitleTextLang.HandleId = 0;
		}

		// Token: 0x0600398F RID: 14735 RVA: 0x0019EF47 File Offset: 0x0019D147
		public static void Init()
		{
			ConfigSubtitleTextLang.HandleId = ConfigCommon.GetLangStatementId("SubtitleText", "lang_subtitle_text.db", "select content from `SubtitleText` where id = ?", "");
		}

		// Token: 0x06003990 RID: 14736 RVA: 0x0019EF68 File Offset: 0x0019D168
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("SubtitleText");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigSubtitleTextLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigSubtitleTextLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigSubtitleTextLang.LogPair.Clear();
			ConfigSubtitleTextLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigSubtitleTextLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigSubtitleTextLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("SubtitleText", "lang_subtitle_text.db", "select content from `SubtitleText` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigSubtitleTextLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigSubtitleTextLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigSubtitleTextLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigSubtitleTextLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigSubtitleTextLang.GetLocalText(id, "zh-Hans")))
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

		// Token: 0x040042F2 RID: 17138
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x040042F3 RID: 17139
		private const string DB = "lang_subtitle_text.db";

		// Token: 0x040042F4 RID: 17140
		private const string TABLE = "SubtitleText";

		// Token: 0x040042F5 RID: 17141
		private const string COMMAND = "select content from `SubtitleText` where id = ?";

		// Token: 0x040042F6 RID: 17142
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040042F7 RID: 17143
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x040042F8 RID: 17144
		private static int HandleId;
	}
}
