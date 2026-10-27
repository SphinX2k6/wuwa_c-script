using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using UnrealEngine;

// Token: 0x0200024F RID: 591
[NullableContext(1)]
[Nullable(0)]
public class MultiTextCsvModule : Singleton
{
	// Token: 0x060023E5 RID: 9189 RVA: 0x000DB274 File Offset: 0x000D9474
	private string ReplaceTermHyperlink(string text)
	{
		return MultiTextCsvModule.TermHyperlinkRegex.Replace(text, delegate(Match m)
		{
			string value = m.Groups["Term"].Value;
			TermConfig? config = ConfigTermConfigByKey.GetConfig(value, true);
			if (config == null)
			{
				return m.Value;
			}
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(15, 2);
			defaultInterpolatedStringHandler.AppendLiteral("<te href=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(config.Value.Id);
			defaultInterpolatedStringHandler.AppendLiteral(">");
			defaultInterpolatedStringHandler.AppendFormatted(value);
			defaultInterpolatedStringHandler.AppendLiteral("</te>");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		});
	}

	// Token: 0x060023E6 RID: 9190 RVA: 0x000DB2A0 File Offset: 0x000D94A0
	private void AnalyzeCsvContent(string csvContent)
	{
		List<List<string>> list = StringUtils.ParseCsvContent(csvContent);
		List<string> list2 = list[1];
		for (int i = 8; i < list.Count; i++)
		{
			List<string> list3 = list[i];
			if (list3.Count >= 2)
			{
				string text = list3[1];
				if (!StringUtils.IsBlank(text))
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					for (int j = 0; j < list3.Count; j++)
					{
						string text2 = list3[j];
						if (j > 1)
						{
							string text3 = this.ReplaceTermHyperlink(text2.Replace("\\n", "\n"));
							dictionary[list2[j]] = (text3 ?? "test/NoLocalTextNoLocalTextNoLocalText");
						}
					}
					this.MultiTextMap[text] = dictionary;
				}
			}
		}
	}

	// Token: 0x060023E7 RID: 9191 RVA: 0x000DB364 File Offset: 0x000D9564
	private void AnalyzeCsvContentWithParam(string csvContent, int csvLangIndex, int csvStartIndex, int csvStartIdIndex)
	{
		List<List<string>> list = StringUtils.ParseCsvContent(csvContent);
		List<string> list2 = list[csvLangIndex];
		for (int i = csvStartIndex; i < list.Count; i++)
		{
			List<string> list3 = list[i];
			if (list3.Count >= 2)
			{
				string text = list3[csvStartIdIndex];
				if (!StringUtils.IsBlank(text))
				{
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					for (int j = 0; j < list3.Count; j++)
					{
						string text2 = list3[j];
						if (j > csvStartIdIndex)
						{
							string text3 = this.ReplaceTermHyperlink(text2.Replace("\\n", "\n"));
							dictionary[list2[j]] = (text3 ?? "test/NoLocalTextNoLocalTextNoLocalText");
						}
					}
					this.MultiTextMap[text] = dictionary;
				}
			}
		}
	}

	// Token: 0x060023E8 RID: 9192 RVA: 0x000DB42C File Offset: 0x000D962C
	public void RegisterTextLocalConfig(string csvPath, bool isReload = false)
	{
		if (!isReload && this.CacheCsvNameSet.Contains(csvPath))
		{
			return;
		}
		this.CacheCsvNameSet.Add(csvPath);
		string csvContent = "";
		UKuroStaticLibrary.LoadFileToString(ref csvContent, csvPath);
		this.AnalyzeCsvContent(csvContent);
	}

	// Token: 0x060023E9 RID: 9193 RVA: 0x000DB470 File Offset: 0x000D9670
	public void RegisterTextLocalConfigWithParam(string csvPath, bool isReload = false, int csvLangIndex = 1, int csvStartIndex = 8, int csvStartIdIndex = 2)
	{
		if (!isReload && this.CacheCsvNameSet.Contains(csvPath))
		{
			return;
		}
		this.CacheCsvNameSet.Add(csvPath);
		string csvContent = "";
		UKuroStaticLibrary.LoadFileToString(ref csvContent, csvPath);
		this.AnalyzeCsvContentWithParam(csvContent, csvLangIndex, csvStartIndex, csvStartIdIndex);
	}

	// Token: 0x060023EA RID: 9194 RVA: 0x000DB4B8 File Offset: 0x000D96B8
	public string GetLocalText(string stringKey)
	{
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		Dictionary<string, string> dictionary;
		string result;
		if (this.MultiTextMap.TryGetValue(stringKey, out dictionary) && dictionary.Count > 0 && dictionary.TryGetValue(packageLanguage, out result))
		{
			return result;
		}
		return stringKey;
	}

	// Token: 0x17000590 RID: 1424
	// (get) Token: 0x060023EB RID: 9195 RVA: 0x000DB4F7 File Offset: 0x000D96F7
	public static MultiTextCsvModule Instance
	{
		get
		{
			if (MultiTextCsvModule._instance == null)
			{
				MultiTextCsvModule._instance = new MultiTextCsvModule();
				MultiTextCsvModule._instance.OnInit();
			}
			return MultiTextCsvModule._instance;
		}
	}

	// Token: 0x060023EC RID: 9196 RVA: 0x000DB51A File Offset: 0x000D971A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060023ED RID: 9197 RVA: 0x000DB51C File Offset: 0x000D971C
	public static void ResetStaticDefaultValue()
	{
		MultiTextCsvModule instance = MultiTextCsvModule._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		MultiTextCsvModule._instance = null;
	}

	// Token: 0x060023EE RID: 9198 RVA: 0x000DB535 File Offset: 0x000D9735
	static MultiTextCsvModule()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MultiTextCsvModule.CreateStaticDefaultValue), new Action(MultiTextCsvModule.ResetStaticDefaultValue));
	}

	// Token: 0x040023A9 RID: 9129
	private readonly HashSet<string> CacheCsvNameSet = new HashSet<string>();

	// Token: 0x040023AA RID: 9130
	private readonly Dictionary<string, Dictionary<string, string>> MultiTextMap = new Dictionary<string, Dictionary<string, string>>();

	// Token: 0x040023AB RID: 9131
	[StaticVariableRuleIgnore]
	private static readonly Regex TermHyperlinkRegex = new Regex("<a href=(?<Term>[^>]+)></a>", RegexOptions.None);

	// Token: 0x040023AC RID: 9132
	[Nullable(2)]
	private static MultiTextCsvModule _instance;
}
