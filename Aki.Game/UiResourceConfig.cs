using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

// Token: 0x02001804 RID: 6148
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class UiResourceConfig : ConfigBase
{
	// Token: 0x0600B447 RID: 46151 RVA: 0x0028B6CC File Offset: 0x002898CC
	public string GetResourcePath(string resourceId)
	{
		UiResource? config = ConfigUiResourceById.GetConfig(resourceId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Resource;
			ELogAuthor author = ELogAuthor.XXJ;
			string message = "查找资源配置失败";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("ResourceId", resourceId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return "";
		}
		return this.GetResourcePathNormal(config.Value);
	}

	// Token: 0x0600B448 RID: 46152 RVA: 0x0028B724 File Offset: 0x00289924
	public string GetResourcePathNormal(UiResource resource)
	{
		if (Info.Instance.IsInTouch() || string.IsNullOrEmpty(resource.PcPath))
		{
			return resource.Path;
		}
		return resource.PcPath;
	}

	// Token: 0x0600B449 RID: 46153 RVA: 0x0028B74F File Offset: 0x0028994F
	public UiResource? GetResourceConfig(string resourceId)
	{
		return ConfigUiResourceById.GetConfig(resourceId, true);
	}

	// Token: 0x0600B44A RID: 46154 RVA: 0x0028B758 File Offset: 0x00289958
	public string GetLogoPathByLanguage(string logoName)
	{
		LangOfLogo? config = ConfigLangOfLogoByName.GetConfig(logoName, true);
		if (config == null)
		{
			return "";
		}
		string packageLanguage = LanguageSystem.Instance.PackageLanguage;
		if (packageLanguage == "en")
		{
			return config.Value.EnLogo;
		}
		if (packageLanguage == "zh-Hans")
		{
			return config.Value.ZhHansLogo;
		}
		if (packageLanguage == "ja")
		{
			return config.Value.JpLogo;
		}
		if (packageLanguage == "zh-Hant")
		{
			return config.Value.ZhHantLogo;
		}
		if (!(packageLanguage == "ko"))
		{
			return config.Value.EnLogo;
		}
		return config.Value.KrLogo;
	}

	// Token: 0x0600B44B RID: 46155 RVA: 0x0028B82C File Offset: 0x00289A2C
	public string GetThirdPartyLogoTexturePath(ELogoSize size)
	{
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			return "";
		}
		string p0Id;
		if (Info.Instance.IsPs5Platform())
		{
			p0Id = "T_PlatformPs" + size.ToValue();
		}
		else
		{
			p0Id = "T_PlatformXbox" + size.ToValue();
		}
		return ConfigUiResourceById.GetConfig(p0Id, true).Value.Path;
	}

	// Token: 0x0600B44C RID: 46156 RVA: 0x0028B898 File Offset: 0x00289A98
	public string GetThirdPartyWhiteLogoTexturePath(ELogoSize size)
	{
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			return "";
		}
		string p0Id;
		if (Info.Instance.IsPs5Platform())
		{
			p0Id = "T_PlatformPs" + size.ToValue();
		}
		else
		{
			p0Id = "T_PlatformXboxW" + size.ToValue();
		}
		return ConfigUiResourceById.GetConfig(p0Id, true).Value.Path;
	}

	// Token: 0x0600B44D RID: 46157 RVA: 0x0028B904 File Offset: 0x00289B04
	public string GetThirdPartyTextColor(EConsoleColorSet set)
	{
		string result = "ffffffff";
		if (!Info.Instance.IsHomeConsolePlatform())
		{
			return result;
		}
		if (set == EConsoleColorSet.Set1)
		{
			if (Info.Instance.IsPs5Platform())
			{
				result = "0092D4FF";
			}
			else
			{
				result = "379337FF";
			}
		}
		else if (Info.Instance.IsPs5Platform())
		{
			result = "0049A8FF";
		}
		else
		{
			result = "107C10ff";
		}
		return result;
	}

	// Token: 0x0600B44E RID: 46158 RVA: 0x0028B960 File Offset: 0x00289B60
	public string GetThirdPartySearchColor(EThirdPartySearchColorSet set)
	{
		string result;
		if (set == EThirdPartySearchColorSet.Set1)
		{
			if (Info.Instance.IsPs5Platform())
			{
				result = "1E7EC5FF";
			}
			else
			{
				result = "137E12FF";
			}
		}
		else if (Info.Instance.IsPs5Platform())
		{
			result = "1E7EC5FF";
		}
		else
		{
			result = "137E12FF";
		}
		return result;
	}

	// Token: 0x17000F24 RID: 3876
	// (get) Token: 0x0600B44F RID: 46159 RVA: 0x0028B9AD File Offset: 0x00289BAD
	public static UiResourceConfig Instance
	{
		get
		{
			return UiResourceConfig._Instance;
		}
	}

	// Token: 0x0600B450 RID: 46160 RVA: 0x0028B9B4 File Offset: 0x00289BB4
	public static UiResourceConfig GetOrCreateInstance()
	{
		if (UiResourceConfig._Instance == null)
		{
			UiResourceConfig.CreateInstance();
		}
		return UiResourceConfig._Instance;
	}

	// Token: 0x0600B451 RID: 46161 RVA: 0x0028B9C8 File Offset: 0x00289BC8
	public static bool CreateInstance()
	{
		if (UiResourceConfig._Instance != null)
		{
			return true;
		}
		UiResourceConfig._Instance = new UiResourceConfig();
		return true;
	}

	// Token: 0x0600B452 RID: 46162 RVA: 0x0028B9DE File Offset: 0x00289BDE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B453 RID: 46163 RVA: 0x0028B9E0 File Offset: 0x00289BE0
	public static void ResetStaticDefaultValue()
	{
		UiResourceConfig._Instance = null;
	}

	// Token: 0x0600B454 RID: 46164 RVA: 0x0028B9E8 File Offset: 0x00289BE8
	static UiResourceConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiResourceConfig.CreateStaticDefaultValue), new Action(UiResourceConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400516B RID: 20843
	public bool IsPcPlatform;

	// Token: 0x0400516C RID: 20844
	[Nullable(2)]
	private static UiResourceConfig _Instance;
}
