using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Common.Proxy;

namespace Aki.Config
{
	// Token: 0x020000C8 RID: 200
	public class ConfigAvgLocationChangeLang : IQueryLocalText, IConfigQuery, IStaticVariableResetter
	{
		// Token: 0x060004B1 RID: 1201 RVA: 0x00077C88 File Offset: 0x00075E88
		static ConfigAvgLocationChangeLang()
		{
			global::StaticVariableRegister.RegisterAndExecute(new Action(ConfigAvgLocationChangeLang.CreateStaticDefaultValue), new Action(ConfigAvgLocationChangeLang.ResetStaticDefaultValue));
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00077CA8 File Offset: 0x00075EA8
		public static void CreateStaticDefaultValue()
		{
			ConfigAvgLocationChangeLang.LogPair = new ConfigLogList<ValueTuple<string, object>>();
			ConfigAvgLocationChangeLang.LogPair.SetHeaders(new ValueTuple<string, object>[]
			{
				new ValueTuple<string, object>("数据库", "lang_avglocationchange.db"),
				new ValueTuple<string, object>("表名", "AvgLocationChange"),
				new ValueTuple<string, object>("语句", "select content from `AvgLocationChange` where id = ?")
			});
			ConfigAvgLocationChangeLang.LangCache = new Dictionary<int, Dictionary<string, string>>();
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x00077D1B File Offset: 0x00075F1B
		public static void ResetStaticDefaultValue()
		{
			ConfigAvgLocationChangeLang.LogPair = null;
			ConfigAvgLocationChangeLang.LangCache = null;
			ConfigAvgLocationChangeLang.HandleId = 0;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00077D2F File Offset: 0x00075F2F
		public static void Init()
		{
			ConfigAvgLocationChangeLang.HandleId = ConfigCommon.GetLangStatementId("AvgLocationChange", "lang_avglocationchange.db", "select content from `AvgLocationChange` where id = ?", "");
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00077D50 File Offset: 0x00075F50
		[NullableContext(2)]
		public static string GetLocalText(int id, string culture = null)
		{
			if (LanguageSystem.Instance.GmShowLanguageKey)
			{
				string cultureOrDefault = LanguageSystem.Instance.GetCultureOrDefault(culture);
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(2, 3);
				defaultInterpolatedStringHandler.AppendFormatted("AvgLocationChange");
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted<int>(id);
				defaultInterpolatedStringHandler.AppendLiteral("|");
				defaultInterpolatedStringHandler.AppendFormatted(cultureOrDefault);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
			Dictionary<string, string> dictionary;
			if (!ConfigAvgLocationChangeLang.LangCache.TryGetValue(id, out dictionary))
			{
				dictionary = new Dictionary<string, string>();
				ConfigAvgLocationChangeLang.LangCache[id] = dictionary;
			}
			string cultureOrDefault2 = LanguageSystem.Instance.GetCultureOrDefault(culture);
			string text;
			if (dictionary.TryGetValue(cultureOrDefault2, out text))
			{
				return text;
			}
			ConfigAvgLocationChangeLang.LogPair.Clear();
			ConfigAvgLocationChangeLang.LogPair.Add(new ValueTuple<string, object>("传入语言", culture));
			ConfigAvgLocationChangeLang.LogPair.Add(new ValueTuple<string, object>("查询语言", cultureOrDefault2));
			ConfigAvgLocationChangeLang.LogPair.Add(new ValueTuple<string, object>("文本Id", id));
			int langStatementId = ConfigCommon.GetLangStatementId("AvgLocationChange", "lang_avglocationchange.db", "select content from `AvgLocationChange` where id = ?", cultureOrDefault2);
			if (!ConfigCommon.CheckStatement(langStatementId, new LogList<ValueTuple<string, object>>()) || !ConfigCommon.BindInt(langStatementId, 1, id, ConfigAvgLocationChangeLang.LogPair) || ConfigCommon.Step(langStatementId, true, ConfigAvgLocationChangeLang.LogPair) <= 0)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			ValueTuple<bool, byte[]> value = ConfigCommon.GetValue(langStatementId, 0, ConfigAvgLocationChangeLang.LogPair);
			bool item = value.Item1;
			byte[] item2 = value.Item2;
			if (!item || item2 == null)
			{
				ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
				return null;
			}
			DeserializeConfigResult<string> deserializeConfigResult = DeserializeConfig.Instance.ParseStringRange(item2, 0, item2.Length, ConfigAvgLocationChangeLang.LogPair);
			ConfigCommon.Reset(langStatementId, new LogList<ValueTuple<string, object>>());
			if (!deserializeConfigResult.Success)
			{
				return null;
			}
			text = deserializeConfigResult.Value;
			if (string.IsNullOrEmpty(text) && culture != "zh-Hans" && !string.IsNullOrEmpty(ConfigAvgLocationChangeLang.GetLocalText(id, "zh-Hans")))
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

		// Token: 0x0400055C RID: 1372
		private const string TEXT_NOT_FOUND = "text not found";

		// Token: 0x0400055D RID: 1373
		private const string DB = "lang_avglocationchange.db";

		// Token: 0x0400055E RID: 1374
		private const string TABLE = "AvgLocationChange";

		// Token: 0x0400055F RID: 1375
		private const string COMMAND = "select content from `AvgLocationChange` where id = ?";

		// Token: 0x04000560 RID: 1376
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			2
		})]
		private static ConfigLogList<ValueTuple<string, object>> LogPair;

		// Token: 0x04000561 RID: 1377
		[Nullable(new byte[]
		{
			2,
			0,
			0,
			0
		})]
		private static Dictionary<int, Dictionary<string, string>> LangCache;

		// Token: 0x04000562 RID: 1378
		private static int HandleId;
	}
}
