using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x020001B5 RID: 437
	public class ConfigCustomSequenceLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x000938A0 File Offset: 0x00091AA0
		static ConfigCustomSequenceLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCustomSequenceLang.CreateStaticDefaultValue), new Action(ConfigCustomSequenceLang.ResetStaticDefaultValue));
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000938C0 File Offset: 0x00091AC0
		public static void CreateStaticDefaultValue()
		{
			ConfigCustomSequenceLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCustomSequenceLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_custom_sequence.db"),
				new ValueTuple<string, object>("表名", "CustomSequence"),
				new ValueTuple<string, object>("语句", "select content from `CustomSequence` where id = ?")
			});
			ConfigCustomSequenceLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00093933 File Offset: 0x00091B33
		public static void ResetStaticDefaultValue()
		{
			ConfigCustomSequenceLang.LogPair = null;
			ConfigCustomSequenceLang.LangCache = null;
			ConfigCustomSequenceLang.HandleId = 0;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00093947 File Offset: 0x00091B47
		public static void Init()
		{
			ConfigCustomSequenceLang.HandleId = ConfigCommon.GetLangStatementId("CustomSequence", "lang_custom_sequence.db", "select content from `CustomSequence` where id = ?", "");
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00093968 File Offset: 0x00091B68
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("CustomSequence");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigCustomSequenceLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigCustomSequenceLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigCustomSequenceLang.LogPair.Clear();
			ConfigCustomSequenceLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigCustomSequenceLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigCustomSequenceLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("CustomSequence", "lang_custom_sequence.db", "select content from `CustomSequence` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigCustomSequenceLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigCustomSequenceLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigCustomSequenceLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigCustomSequenceLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigCustomSequenceLang.GetLocalText(id, "zh-Hans")))
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

		// Token: 0x04000BD7 RID: 3031
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x04000BD8 RID: 3032
		private const string DB = "lang_custom_sequence.db";

		// Token: 0x04000BD9 RID: 3033
		private const string TABLE = "CustomSequence";

		// Token: 0x04000BDA RID: 3034
		private const string COMMAND = "select content from `CustomSequence` where id = ?";

		// Token: 0x04000BDB RID: 3035
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000BDC RID: 3036
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x04000BDD RID: 3037
		private static int HandleId;
	}
}
