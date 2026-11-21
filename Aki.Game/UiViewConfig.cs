using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02000CBE RID: 3262
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class UiViewConfig : ConfigBase
{
	// Token: 0x06008841 RID: 34881 RVA: 0x0029612F File Offset: 0x0029432F
	public UiShow? GetUiShowConfig(string name)
	{
		return ConfigUiShowByViewName.GetConfig(name, true);
	}

	// Token: 0x06008842 RID: 34882 RVA: 0x00296138 File Offset: 0x00294338
	public UiShow? GetUiShowConfig(EUiViewName name)
	{
		return ConfigUiShowByViewName.GetConfig(name, true);
	}

	// Token: 0x06008843 RID: 34883 RVA: 0x00296146 File Offset: 0x00294346
	public UiFloatConfig? GetUiFloatConfig(EUiViewName name)
	{
		return ConfigUiFloatConfigByViewNameIfNull.GetConfig(name, name, name, true);
	}

	// Token: 0x06008844 RID: 34884 RVA: 0x00296160 File Offset: 0x00294360
	public UiNormalConfig? GetUiNormalConfig(EUiViewName name)
	{
		return ConfigUiNormalConfigByViewNameIfNull.GetConfig(name.ToString(), name.ToString(), name.ToString(), true);
	}

	// Token: 0x06008845 RID: 34885 RVA: 0x0029618F File Offset: 0x0029438F
	public UiSceneCsv? GetSceneConfig(string sceneId)
	{
		return ConfigUiSceneCsvById.GetConfig(sceneId, true);
	}

	// Token: 0x06008846 RID: 34886 RVA: 0x00296198 File Offset: 0x00294398
	public string[] GetScenePathList(string sceneId)
	{
		UiSceneCsv? config = ConfigUiSceneCsvById.GetConfig(sceneId, true);
		if (config == null)
		{
			return Array.Empty<string>();
		}
		return config.Value.SceneList();
	}

	// Token: 0x17000F48 RID: 3912
	// (get) Token: 0x06008847 RID: 34887 RVA: 0x002961CB File Offset: 0x002943CB
	public static UiViewConfig Instance
	{
		get
		{
			return UiViewConfig._Instance;
		}
	}

	// Token: 0x06008848 RID: 34888 RVA: 0x002961D2 File Offset: 0x002943D2
	public static UiViewConfig GetOrCreateInstance()
	{
		if (UiViewConfig._Instance == null)
		{
			UiViewConfig.CreateInstance();
		}
		return UiViewConfig._Instance;
	}

	// Token: 0x06008849 RID: 34889 RVA: 0x002961E6 File Offset: 0x002943E6
	public static bool CreateInstance()
	{
		if (UiViewConfig._Instance != null)
		{
			return true;
		}
		UiViewConfig._Instance = new UiViewConfig();
		return true;
	}

	// Token: 0x0600884A RID: 34890 RVA: 0x002961FC File Offset: 0x002943FC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600884B RID: 34891 RVA: 0x002961FE File Offset: 0x002943FE
	public static void ResetStaticDefaultValue()
	{
		UiViewConfig._Instance = null;
	}

	// Token: 0x0600884C RID: 34892 RVA: 0x00296206 File Offset: 0x00294406
	static UiViewConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiViewConfig.CreateStaticDefaultValue), new Action(UiViewConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005218 RID: 21016
	[Nullable(2)]
	private static UiViewConfig _Instance;
}
