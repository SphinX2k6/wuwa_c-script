using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using UnrealEngine;

// Token: 0x02000253 RID: 595
[NullableContext(1)]
[Nullable(0)]
public class MultiTextCsvModule : Singleton
{
	// Token: 0x0600249D RID: 9373 RVA: 0x000E17BC File Offset: 0x000DF9BC
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

	// Token: 0x0600249E RID: 9374 RVA: 0x000E17E8 File Offset: 0x000DF9E8
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

	// Token: 0x0600249F RID: 9375 RVA: 0x000E18AC File Offset: 0x000DFAAC
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

	// Token: 0x060024A0 RID: 9376 RVA: 0x000E1974 File Offset: 0x000DFB74
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

	// Token: 0x060024A1 RID: 9377 RVA: 0x000E19B8 File Offset: 0x000DFBB8
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

	// Token: 0x060024A2 RID: 9378 RVA: 0x000E1A00 File Offset: 0x000DFC00
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

	// Token: 0x170005B7 RID: 1463
	// (get) Token: 0x060024A3 RID: 9379 RVA: 0x000E1A3F File Offset: 0x000DFC3F
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

	// Token: 0x060024A4 RID: 9380 RVA: 0x000E1A62 File Offset: 0x000DFC62
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060024A5 RID: 9381 RVA: 0x000E1A64 File Offset: 0x000DFC64
	public static void ResetStaticDefaultValue()
	{
		MultiTextCsvModule instance = MultiTextCsvModule._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		MultiTextCsvModule._instance = null;
	}

	// Token: 0x060024A6 RID: 9382 RVA: 0x000E1A7D File Offset: 0x000DFC7D
	static MultiTextCsvModule()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MultiTextCsvModule.CreateStaticDefaultValue), new Action(MultiTextCsvModule.ResetStaticDefaultValue));
	}

	// Token: 0x04002426 RID: 9254
	private readonly HashSet<string> CacheCsvNameSet = new HashSet<string>();

	// Token: 0x04002427 RID: 9255
	private readonly Dictionary<string, Dictionary<string, string>> MultiTextMap = new Dictionary<string, Dictionary<string, string>>();

	// Token: 0x04002428 RID: 9256
	[StaticVariableRuleIgnore]
	private static readonly Regex TermHyperlinkRegex = new Regex("<a href=(?<Term>[^>]+)></a>", RegexOptions.None);

	// Token: 0x04002429 RID: 9257
	[Nullable(2)]
	private static MultiTextCsvModule _instance;
}
