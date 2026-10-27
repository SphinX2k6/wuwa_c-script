using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000623 RID: 1571
	public class ConfigOccupationConfigLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060024E2 RID: 9442 RVA: 0x0012A341 File Offset: 0x00128541
		static ConfigOccupationConfigLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigOccupationConfigLang.CreateStaticDefaultValue), new Action(ConfigOccupationConfigLang.ResetStaticDefaultValue));
		}

		// Token: 0x060024E3 RID: 9443 RVA: 0x0012A360 File Offset: 0x00128560
		public static void CreateStaticDefaultValue()
		{
			ConfigOccupationConfigLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigOccupationConfigLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_occupation.db"),
				new ValueTuple<string, object>("表名", "OccupationConfig"),
				new ValueTuple<string, object>("语句", "select content from `OccupationConfig` where id = ?")
			});
			ConfigOccupationConfigLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x060024E4 RID: 9444 RVA: 0x0012A3D3 File Offset: 0x001285D3
		public static void ResetStaticDefaultValue()
		{
			ConfigOccupationConfigLang.LogPair = null;
			ConfigOccupationConfigLang.LangCache = null;
			ConfigOccupationConfigLang.HandleId = 0;
		}

		// Token: 0x060024E5 RID: 9445 RVA: 0x0012A3E7 File Offset: 0x001285E7
		public static void Init()
		{
			ConfigOccupationConfigLang.HandleId = ConfigCommon.GetLangStatementId("OccupationConfig", "lang_occupation.db", "select content from `OccupationConfig` where id = ?", "");
		}

		// Token: 0x060024E6 RID: 9446 RVA: 0x0012A408 File Offset: 0x00128608
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("OccupationConfig");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigOccupationConfigLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigOccupationConfigLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigOccupationConfigLang.LogPair.Clear();
			ConfigOccupationConfigLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigOccupationConfigLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigOccupationConfigLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("OccupationConfig", "lang_occupation.db", "select content from `OccupationConfig` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigOccupationConfigLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigOccupationConfigLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigOccupationConfigLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigOccupationConfigLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigOccupationConfigLang.GetLocalText(id, "zh-Hans")))
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

		// Token: 0x04002ADB RID: 10971
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x04002ADC RID: 10972
		private const string DB = "lang_occupation.db";

		// Token: 0x04002ADD RID: 10973
		private const string TABLE = "OccupationConfig";

		// Token: 0x04002ADE RID: 10974
		private const string COMMAND = "select content from `OccupationConfig` where id = ?";

		// Token: 0x04002ADF RID: 10975
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04002AE0 RID: 10976
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x04002AE1 RID: 10977
		private static int HandleId;
	}
}
