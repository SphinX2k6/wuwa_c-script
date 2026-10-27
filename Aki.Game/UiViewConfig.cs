using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Ui;

// Token: 0x02001805 RID: 6149
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class UiViewConfig : ConfigBase
{
	// Token: 0x0600B456 RID: 46166 RVA: 0x0028BA0F File Offset: 0x00289C0F
	public UiShow? GetUiShowConfig(string name)
	{
		return ConfigUiShowByViewName.GetConfig(name, true);
	}

	// Token: 0x0600B457 RID: 46167 RVA: 0x0028BA18 File Offset: 0x00289C18
	public UiShow? GetUiShowConfig(EUiViewName name)
	{
		return ConfigUiShowByViewName.GetConfig(name, true);
	}

	// Token: 0x0600B458 RID: 46168 RVA: 0x0028BA26 File Offset: 0x00289C26
	public UiFloatConfig? GetUiFloatConfig(EUiViewName name)
	{
		return ConfigUiFloatConfigByViewNameIfNull.GetConfig(name, name, name, true);
	}

	// Token: 0x0600B459 RID: 46169 RVA: 0x0028BA40 File Offset: 0x00289C40
	public UiNormalConfig? GetUiNormalConfig(EUiViewName name)
	{
		return ConfigUiNormalConfigByViewNameIfNull.GetConfig(name.ToString(), name.ToString(), name.ToString(), true);
	}

	// Token: 0x0600B45A RID: 46170 RVA: 0x0028BA6F File Offset: 0x00289C6F
	public UiSceneCsv? GetSceneConfig(string sceneId)
	{
		return ConfigUiSceneCsvById.GetConfig(sceneId, true);
	}

	// Token: 0x0600B45B RID: 46171 RVA: 0x0028BA78 File Offset: 0x00289C78
	public string[] GetScenePathList(string sceneId)
	{
		UiSceneCsv? config = ConfigUiSceneCsvById.GetConfig(sceneId, true);
		if (config == null)
		{
			return Array.Empty<string>();
		}
		return config.Value.SceneList();
	}

	// Token: 0x17000F25 RID: 3877
	// (get) Token: 0x0600B45C RID: 46172 RVA: 0x0028BAAB File Offset: 0x00289CAB
	public static UiViewConfig Instance
	{
		get
		{
			return UiViewConfig._Instance;
		}
	}

	// Token: 0x0600B45D RID: 46173 RVA: 0x0028BAB2 File Offset: 0x00289CB2
	public static UiViewConfig GetOrCreateInstance()
	{
		if (UiViewConfig._Instance == null)
		{
			UiViewConfig.CreateInstance();
		}
		return UiViewConfig._Instance;
	}

	// Token: 0x0600B45E RID: 46174 RVA: 0x0028BAC6 File Offset: 0x00289CC6
	public static bool CreateInstance()
	{
		if (UiViewConfig._Instance != null)
		{
			return true;
		}
		UiViewConfig._Instance = new UiViewConfig();
		return true;
	}

	// Token: 0x0600B45F RID: 46175 RVA: 0x0028BADC File Offset: 0x00289CDC
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B460 RID: 46176 RVA: 0x0028BADE File Offset: 0x00289CDE
	public static void ResetStaticDefaultValue()
	{
		UiViewConfig._Instance = null;
	}

	// Token: 0x0600B461 RID: 46177 RVA: 0x0028BAE6 File Offset: 0x00289CE6
	static UiViewConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiViewConfig.CreateStaticDefaultValue), new Action(UiViewConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400516D RID: 20845
	[Nullable(2)]
	private static UiViewConfig _Instance;
}
