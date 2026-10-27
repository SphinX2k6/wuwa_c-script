using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x020005DB RID: 1499
	public class ConfigMultiTextLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter, IQueryLocalTextNew
	{
		// Token: 0x0600232F RID: 9007 RVA: 0x0012061C File Offset: 0x0011E81C
		static ConfigMultiTextLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigMultiTextLang.CreateStaticDefaultValue), new Action(ConfigMultiTextLang.ResetStaticDefaultValue));
		}

		// Token: 0x06002330 RID: 9008 RVA: 0x00120650 File Offset: 0x0011E850
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

		// Token: 0x06002331 RID: 9009 RVA: 0x001206C3 File Offset: 0x0011E8C3
		public static void ResetStaticDefaultValue()
		{
			ConfigMultiTextLang.LogPair = null;
			ConfigMultiTextLang.LangCache = null;
			ConfigMultiTextLang.HandleId = 0;
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x001206D7 File Offset: 0x0011E8D7
		public static void Init()
		{
			ConfigMultiTextLang.HandleId = ConfigCommon.GetLangStatementId("MultiText", "lang_multi_text.db", "select content,redirectdbindex from `MultiText` where id = ?", "");
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x001206F7 File Offset: 0x0011E8F7
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			return null;
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x001206FC File Offset: 0x0011E8FC
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

		// Token: 0x06002335 RID: 9013 RVA: 0x001209E0 File Offset: 0x0011EBE0
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

		// Token: 0x040028E1 RID: 10465
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x040028E2 RID: 10466
		private const string DB = "lang_multi_text.db";

		// Token: 0x040028E3 RID: 10467
		private const string TABLE = "MultiText";

		// Token: 0x040028E4 RID: 10468
		private const string COMMAND = "select content from `MultiText` where id = ?";

		// Token: 0x040028E5 RID: 10469
		private static readonly string[] SUB_DB_NAMES = new string[]
		{
			"lang_multi_text_1sthalf.db"
		};

		// Token: 0x040028E6 RID: 10470
		private const string COMMAND_WITH_REDIRECT_DB = "select content,redirectdbindex from `MultiText` where id = ?";

		// Token: 0x040028E7 RID: 10471
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x040028E8 RID: 10472
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0,
			0
		})]
		private static Dictionary<string, Dictionary<string, string>> LangCache;

		// Token: 0x040028E9 RID: 10473
		private static int HandleId;
	}
}
