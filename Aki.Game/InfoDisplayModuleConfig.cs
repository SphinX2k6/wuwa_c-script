using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001F93 RID: 8083
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class InfoDisplayModuleConfig : ConfigBase
{
	// Token: 0x0600FB03 RID: 64259 RVA: 0x003CD010 File Offset: 0x003CB210
	private InfoDisplay? GetInfoDisplayConfig(int id)
	{
		InfoDisplay? config = ConfigInfoDisplayById.GetConfig(id, true);
		if (config != null)
		{
			return config;
		}
		return null;
	}

	// Token: 0x0600FB04 RID: 64260 RVA: 0x003CD03C File Offset: 0x003CB23C
	public int GetInfoDisplayType(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.Type;
		}
		return 0;
	}

	// Token: 0x0600FB05 RID: 64261 RVA: 0x003CD06C File Offset: 0x003CB26C
	public string GetInfoDisplayTitle(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(infoDisplayConfig.Value.Title, null) ?? "";
		}
		return "";
	}

	// Token: 0x0600FB06 RID: 64262 RVA: 0x003CD0B0 File Offset: 0x003CB2B0
	public string GetInfoDisplayDesc(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(infoDisplayConfig.Value.Text, null) ?? "";
		}
		return "";
	}

	// Token: 0x0600FB07 RID: 64263 RVA: 0x003CD0F4 File Offset: 0x003CB2F4
	public string GetInfoDisplayAudio(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.Audio;
		}
		return "";
	}

	// Token: 0x0600FB08 RID: 64264 RVA: 0x003CD128 File Offset: 0x003CB328
	public string GetInfoDisplayBgStamp(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.Background;
		}
		return "";
	}

	// Token: 0x0600FB09 RID: 64265 RVA: 0x003CD15C File Offset: 0x003CB35C
	public string[] GetInfoDisplayPictures(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		string[] result = new string[0];
		if (infoDisplayConfig != null && infoDisplayConfig.Value.Picture != "")
		{
			return infoDisplayConfig.Value.Picture.Split(',', StringSplitOptions.None);
		}
		return result;
	}

	// Token: 0x0600FB0A RID: 64266 RVA: 0x003CD1B8 File Offset: 0x003CB3B8
	public string GetInfoDisplayEntryAudio(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.EntryAudio;
		}
		return "";
	}

	// Token: 0x0600FB0B RID: 64267 RVA: 0x003CD1EC File Offset: 0x003CB3EC
	public string GetInfoDisplayExitAudio(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.ExitAudio;
		}
		return "";
	}

	// Token: 0x17001347 RID: 4935
	// (get) Token: 0x0600FB0C RID: 64268 RVA: 0x003CD21F File Offset: 0x003CB41F
	public static InfoDisplayModuleConfig Instance
	{
		get
		{
			return InfoDisplayModuleConfig._Instance;
		}
	}

	// Token: 0x0600FB0D RID: 64269 RVA: 0x003CD226 File Offset: 0x003CB426
	public static InfoDisplayModuleConfig GetOrCreateInstance()
	{
		if (InfoDisplayModuleConfig._Instance == null)
		{
			InfoDisplayModuleConfig.CreateInstance();
		}
		return InfoDisplayModuleConfig._Instance;
	}

	// Token: 0x0600FB0E RID: 64270 RVA: 0x003CD23A File Offset: 0x003CB43A
	public static bool CreateInstance()
	{
		if (InfoDisplayModuleConfig._Instance != null)
		{
			return true;
		}
		InfoDisplayModuleConfig._Instance = new InfoDisplayModuleConfig();
		return true;
	}

	// Token: 0x0600FB0F RID: 64271 RVA: 0x003CD250 File Offset: 0x003CB450
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600FB10 RID: 64272 RVA: 0x003CD252 File Offset: 0x003CB452
	public static void ResetStaticDefaultValue()
	{
		InfoDisplayModuleConfig._Instance = null;
	}

	// Token: 0x0600FB11 RID: 64273 RVA: 0x003CD25A File Offset: 0x003CB45A
	static InfoDisplayModuleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfoDisplayModuleConfig.CreateStaticDefaultValue), new Action(InfoDisplayModuleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040074D5 RID: 29909
	[Nullable(2)]
	private static InfoDisplayModuleConfig _Instance;
}
