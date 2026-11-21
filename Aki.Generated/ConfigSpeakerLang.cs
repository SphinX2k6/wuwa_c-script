using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000A41 RID: 2625
	public class ConfigSpeakerLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06003D9A RID: 15770 RVA: 0x001B8D00 File Offset: 0x001B6F00
		static ConfigSpeakerLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigSpeakerLang.CreateStaticDefaultValue), new Action(ConfigSpeakerLang.ResetStaticDefaultValue));
		}

		// Token: 0x06003D9B RID: 15771 RVA: 0x001B8D20 File Offset: 0x001B6F20
		public static void CreateStaticDefaultValue()
		{
			ConfigSpeakerLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigSpeakerLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_speaker.db"),
				new ValueTuple<string, object>("表名", "Speaker"),
				new ValueTuple<string, object>("语句", "select content from `Speaker` where id = ?")
			});
			ConfigSpeakerLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x06003D9C RID: 15772 RVA: 0x001B8D93 File Offset: 0x001B6F93
		public static void ResetStaticDefaultValue()
		{
			ConfigSpeakerLang.LogPair = null;
			ConfigSpeakerLang.LangCache = null;
			ConfigSpeakerLang.HandleId = 0;
		}

		// Token: 0x06003D9D RID: 15773 RVA: 0x001B8DA7 File Offset: 0x001B6FA7
		public static void Init()
		{
			ConfigSpeakerLang.HandleId = ConfigCommon.GetLangStatementId("Speaker", "lang_speaker.db", "select content from `Speaker` where id = ?", "");
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x001B8DC8 File Offset: 0x001B6FC8
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("Speaker");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigSpeakerLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigSpeakerLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigSpeakerLang.LogPair.Clear();
			ConfigSpeakerLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigSpeakerLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigSpeakerLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("Speaker", "lang_speaker.db", "select content from `Speaker` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigSpeakerLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigSpeakerLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigSpeakerLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigSpeakerLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigSpeakerLang.GetLocalText(id, "zh-Hans")))
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

		// Token: 0x040047AD RID: 18349
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x040047AE RID: 18350
		private const string DB = "lang_speaker.db";

		// Token: 0x040047AF RID: 18351
		private const string TABLE = "Speaker";

		// Token: 0x040047B0 RID: 18352
		private const string COMMAND = "select content from `Speaker` where id = ?";

		// Token: 0x040047B1 RID: 18353
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040047B2 RID: 18354
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x040047B3 RID: 18355
		private static int HandleId;
	}
}
