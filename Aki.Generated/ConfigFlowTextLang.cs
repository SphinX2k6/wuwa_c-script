using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x0200033B RID: 827
	public class ConfigFlowTextLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x06001367 RID: 4967 RVA: 0x000C6FF0 File Offset: 0x000C51F0
		static ConfigFlowTextLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigFlowTextLang.CreateStaticDefaultValue), new Action(ConfigFlowTextLang.ResetStaticDefaultValue));
		}

		// Token: 0x06001368 RID: 4968 RVA: 0x000C7010 File Offset: 0x000C5210
		public static void CreateStaticDefaultValue()
		{
			ConfigFlowTextLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigFlowTextLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_flow_text.db"),
				new ValueTuple<string, object>("表名", "FlowText"),
				new ValueTuple<string, object>("语句", "select content from `FlowText` where id = ?")
			});
			ConfigFlowTextLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x06001369 RID: 4969 RVA: 0x000C7083 File Offset: 0x000C5283
		public static void ResetStaticDefaultValue()
		{
			ConfigFlowTextLang.LogPair = null;
			ConfigFlowTextLang.LangCache = null;
			ConfigFlowTextLang.HandleId = 0;
		}

		// Token: 0x0600136A RID: 4970 RVA: 0x000C7097 File Offset: 0x000C5297
		public static void Init()
		{
			ConfigFlowTextLang.HandleId = ConfigCommon.GetLangStatementId("FlowText", "lang_flow_text.db", "select content from `FlowText` where id = ?", "");
		}

		// Token: 0x0600136B RID: 4971 RVA: 0x000C70B8 File Offset: 0x000C52B8
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("FlowText");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigFlowTextLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigFlowTextLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigFlowTextLang.LogPair.Clear();
			ConfigFlowTextLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigFlowTextLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigFlowTextLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("FlowText", "lang_flow_text.db", "select content from `FlowText` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigFlowTextLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigFlowTextLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigFlowTextLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigFlowTextLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigFlowTextLang.GetLocalText(id, "zh-Hans")))
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

		// Token: 0x04001681 RID: 5761
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x04001682 RID: 5762
		private const string DB = "lang_flow_text.db";

		// Token: 0x04001683 RID: 5763
		private const string TABLE = "FlowText";

		// Token: 0x04001684 RID: 5764
		private const string COMMAND = "select content from `FlowText` where id = ?";

		// Token: 0x04001685 RID: 5765
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04001686 RID: 5766
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x04001687 RID: 5767
		private static int HandleId;
	}
}
