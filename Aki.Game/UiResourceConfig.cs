using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;

// Token: 0x02000CBD RID: 3261
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class UiResourceConfig : ConfigBase
{
	// Token: 0x06008832 RID: 34866 RVA: 0x00295DEC File Offset: 0x00293FEC
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

	// Token: 0x06008833 RID: 34867 RVA: 0x00295E44 File Offset: 0x00294044
	public string GetResourcePathNormal(UiResource resource)
	{
		if (Info.Instance.IsInTouch() || string.IsNullOrEmpty(resource.PcPath))
		{
			return resource.Path;
		}
		return resource.PcPath;
	}

	// Token: 0x06008834 RID: 34868 RVA: 0x00295E6F File Offset: 0x0029406F
	public UiResource? GetResourceConfig(string resourceId)
	{
		return ConfigUiResourceById.GetConfig(resourceId, true);
	}

	// Token: 0x06008835 RID: 34869 RVA: 0x00295E78 File Offset: 0x00294078
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

	// Token: 0x06008836 RID: 34870 RVA: 0x00295F4C File Offset: 0x0029414C
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

	// Token: 0x06008837 RID: 34871 RVA: 0x00295FB8 File Offset: 0x002941B8
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

	// Token: 0x06008838 RID: 34872 RVA: 0x00296024 File Offset: 0x00294224
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

	// Token: 0x06008839 RID: 34873 RVA: 0x00296080 File Offset: 0x00294280
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

	// Token: 0x17000F47 RID: 3911
	// (get) Token: 0x0600883A RID: 34874 RVA: 0x002960CD File Offset: 0x002942CD
	public static UiResourceConfig Instance
	{
		get
		{
			return UiResourceConfig._Instance;
		}
	}

	// Token: 0x0600883B RID: 34875 RVA: 0x002960D4 File Offset: 0x002942D4
	public static UiResourceConfig GetOrCreateInstance()
	{
		if (UiResourceConfig._Instance == null)
		{
			UiResourceConfig.CreateInstance();
		}
		return UiResourceConfig._Instance;
	}

	// Token: 0x0600883C RID: 34876 RVA: 0x002960E8 File Offset: 0x002942E8
	public static bool CreateInstance()
	{
		if (UiResourceConfig._Instance != null)
		{
			return true;
		}
		UiResourceConfig._Instance = new UiResourceConfig();
		return true;
	}

	// Token: 0x0600883D RID: 34877 RVA: 0x002960FE File Offset: 0x002942FE
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600883E RID: 34878 RVA: 0x00296100 File Offset: 0x00294300
	public static void ResetStaticDefaultValue()
	{
		UiResourceConfig._Instance = null;
	}

	// Token: 0x0600883F RID: 34879 RVA: 0x00296108 File Offset: 0x00294308
	static UiResourceConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiResourceConfig.CreateStaticDefaultValue), new Action(UiResourceConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005216 RID: 21014
	public bool IsPcPlatform;

	// Token: 0x04005217 RID: 21015
	[Nullable(2)]
	private static UiResourceConfig _Instance;
}
