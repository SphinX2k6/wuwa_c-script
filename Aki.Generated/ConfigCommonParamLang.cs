using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x02000007 RID: 7
	public class ConfigCommonParamLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x0600002F RID: 47 RVA: 0x0005AFC2 File Offset: 0x000591C2
		static ConfigCommonParamLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigCommonParamLang.CreateStaticDefaultValue), new Action(ConfigCommonParamLang.ResetStaticDefaultValue));
		}

		// Token: 0x06000030 RID: 48 RVA: 0x0005AFE4 File Offset: 0x000591E4
		public static void CreateStaticDefaultValue()
		{
			ConfigCommonParamLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigCommonParamLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_common_param.db"),
				new ValueTuple<string, object>("表名", "CommonParam"),
				new ValueTuple<string, object>("语句", "select content from `CommonParam` where id = ?")
			});
			ConfigCommonParamLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x0005B057 File Offset: 0x00059257
		public static void ResetStaticDefaultValue()
		{
			ConfigCommonParamLang.LogPair = null;
			ConfigCommonParamLang.LangCache = null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x0005B065 File Offset: 0x00059265
		public static void Init()
		{
			ConfigCommon.GetLangStatementId("CommonParam", "lang_common_param.db", "select content from `CommonParam` where id = ?", "");
		}

		// Token: 0x06000033 RID: 51 RVA: 0x0005B084 File Offset: 0x00059284
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(13, 2);
				defaultInterpolatedStringHandler.AppendLiteral("CommonParam|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigCommonParamLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigCommonParamLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string value;
			if (dictionary.TryGetValue(cultureOrDefault2, out value))
			{
				return value;
			}
			int langStatementId = ConfigCommon.GetLangStatementId("CommonParam", "lang_common_param.db", "select content from `CommonParam` where id = ?", culture);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()))
			{
				return null;
			}
			ConfigCommonParamLang.LogPair.Clear();
			ConfigCommonParamLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigCommonParamLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigCommonParamLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			if (!ConfigCommon.BindInt(langStatementId, 1, id, ConfigCommonParamLang.LogPair))
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			if (ConfigCommon.Step(langStatementId, true, ConfigCommonParamLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value2 = ConfigCommon.GetValue(langStatementId, 0, ConfigCommonParamLang.LogPair);
			bool item = value2.Item1;
			byte[] item2 = value2.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseString(item2, 0, ConfigCommonParamLang.LogPair);
			if (!deserializeConfigResult.Success)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			value = deserializeConfigResult.Value;
			dictionary[cultureOrDefault2] = value;
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			return value;
		}

		// Token: 0x0400001E RID: 30
		[Nullable(1)]
		private const string DB = "lang_common_param.db";

		// Token: 0x0400001F RID: 31
		[Nullable(1)]
		private const string TABLE = "CommonParam";

		// Token: 0x04000020 RID: 32
		[Nullable(1)]
		private const string COMMAND = "select content from `CommonParam` where id = ?";

		// Token: 0x04000021 RID: 33
		[Nullable(new byte[]
		{
			2,
			0,
			1,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000022 RID: 34
		[Nullable(new byte[]
		{
			2,
			1,
			1,
			1
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;
	}
}
