using System;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using Aki.Config;
using CSharpScript.Game.Module.Plot;
using UnrealEngine;

// Token: 0x02002A38 RID: 10808
[NullableContext(1)]
[Nullable(0)]
public class I18nUtils
{
	// Token: 0x0601B3D2 RID: 111570 RVA: 0x0085D474 File Offset: 0x0085B674
	[return: Nullable(2)]
	public static string GetI18nPathAtCurrentLanguage(string key)
	{
		I18nResources? config = ConfigI18nResourcesById.GetConfig(key, true);
		if (config == null)
		{
			return null;
		}
		I18nTextures? config2 = ConfigI18nTexturesById.GetConfig(config.Value.TextureRef, true);
		if (config2 == null)
		{
			return null;
		}
		string text = null;
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		if (packageLanguage == "zh-Hans")
		{
			text = config2.Value.ZhHans;
		}
		else if (packageLanguage == "zh-Hant")
		{
			text = config2.Value.ZhHant;
		}
		else if (packageLanguage == "en")
		{
			text = config2.Value.En;
		}
		else if (packageLanguage == "ja")
		{
			text = config2.Value.Ja;
		}
		else if (packageLanguage == "ko")
		{
			text = config2.Value.Ko;
		}
		else if (packageLanguage == "ru")
		{
			text = config2.Value.Ru;
		}
		else if (packageLanguage == "de")
		{
			text = config2.Value.De;
		}
		else if (packageLanguage == "es")
		{
			text = config2.Value.Es;
		}
		else if (packageLanguage == "pt")
		{
			text = config2.Value.Pt;
		}
		else if (packageLanguage == "id")
		{
			text = config2.Value.Idn;
		}
		else if (packageLanguage == "fr")
		{
			text = config2.Value.Fr;
		}
		else if (packageLanguage == "vi")
		{
			text = config2.Value.Vi;
		}
		else if (packageLanguage == "th")
		{
			text = config2.Value.Th;
		}
		if (string.IsNullOrEmpty(text))
		{
			return null;
		}
		if (!StringUtils.IsEmpty(config2.Value.HandleType))
		{
			if (config2.Value.HandleType == "main_player")
			{
				return I18nUtils.ParseGenderContent(text, PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male);
			}
			if (config2.Value.HandleType == "main_player_new")
			{
				return I18nUtils.ParseGenderContentNew(text, PlayerInfoModel.Instance.GetPlayerGender() == EPlayerGender.Male);
			}
		}
		return text;
	}

	// Token: 0x0601B3D3 RID: 111571 RVA: 0x0085D6FC File Offset: 0x0085B8FC
	[return: Nullable(2)]
	public static string GetI18nPlotAudioMediaName(string key)
	{
		I18nResources? config = ConfigI18nResourcesById.GetConfig(key, true);
		if (config == null)
		{
			return null;
		}
		PlotAudio? config2 = ConfigPlotAudioById.GetConfig(config.Value.PlotAudioRef, true);
		if (config2 == null)
		{
			return null;
		}
		return PlotAudioModel.Instance.GetExternalSourcesMediaName(config2.Value);
	}

	// Token: 0x0601B3D4 RID: 111572 RVA: 0x0085D750 File Offset: 0x0085B950
	private static string ParseGenderContent(string content, bool isMale)
	{
		if (StringUtils.IsEmpty(content))
		{
			return "";
		}
		return new Regex("\\{Male:(.*?),Female:(.*?)\\}").Replace(content, delegate(Match match)
		{
			string value = match.Groups[1].Value;
			string value2 = match.Groups[2].Value;
			if (!isMale)
			{
				return value2;
			}
			return value;
		});
	}

	// Token: 0x0601B3D5 RID: 111573 RVA: 0x0085D794 File Offset: 0x0085B994
	private static string ParseGenderContentNew(string content, bool isMale)
	{
		if (StringUtils.IsEmpty(content))
		{
			return "";
		}
		Match match = new Regex("\\{Male:(?<quote1>['\"])(?<maleText>.*?)\\1,Female:(?<quote2>['\"])(?<femaleText>.*?)\\3\\}").Match(content);
		return (isMale ? match.Groups["maleText"].Value : match.Groups["femaleText"].Value) ?? "";
	}

	// Token: 0x0601B3D6 RID: 111574 RVA: 0x0085D7F8 File Offset: 0x0085B9F8
	public static void SetRenderComponentTextByTextId(UTextRenderComponent textRenderComponent, string textId)
	{
		if (textRenderComponent != null && textRenderComponent.IsValid())
		{
			textRenderComponent.SetText(ConfigMultiTextLang.GetLocalTextNew(textId, null) ?? "");
		}
	}

	// Token: 0x0601B3D7 RID: 111575 RVA: 0x0085D81C File Offset: 0x0085BA1C
	public static void SetI18nBillboardComponentSpriteById(UBillboardComponent spriteComponent, string id)
	{
		string i18nPathAtCurrentLanguage = I18nUtils.GetI18nPathAtCurrentLanguage(id);
		if (i18nPathAtCurrentLanguage != null)
		{
			UTexture2D sprite = ResourceSystem.Instance.Load<UTexture2D>(i18nPathAtCurrentLanguage, "Ui.PlotUi");
			spriteComponent.SetSprite(sprite);
		}
	}
}
