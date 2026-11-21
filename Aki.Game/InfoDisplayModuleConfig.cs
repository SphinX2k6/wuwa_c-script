using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001455 RID: 5205
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class InfoDisplayModuleConfig : ConfigBase
{
	// Token: 0x0600CF25 RID: 53029 RVA: 0x003D8BD0 File Offset: 0x003D6DD0
	private InfoDisplay? GetInfoDisplayConfig(int id)
	{
		InfoDisplay? config = ConfigInfoDisplayById.GetConfig(id, true);
		if (config != null)
		{
			return config;
		}
		return null;
	}

	// Token: 0x0600CF26 RID: 53030 RVA: 0x003D8BFC File Offset: 0x003D6DFC
	public int GetInfoDisplayType(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.Type;
		}
		return 0;
	}

	// Token: 0x0600CF27 RID: 53031 RVA: 0x003D8C2C File Offset: 0x003D6E2C
	public string GetInfoDisplayTitle(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(infoDisplayConfig.Value.Title, null) ?? "";
		}
		return "";
	}

	// Token: 0x0600CF28 RID: 53032 RVA: 0x003D8C70 File Offset: 0x003D6E70
	public string GetInfoDisplayDesc(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(infoDisplayConfig.Value.Text, null) ?? "";
		}
		return "";
	}

	// Token: 0x0600CF29 RID: 53033 RVA: 0x003D8CB4 File Offset: 0x003D6EB4
	public string GetInfoDisplayAudio(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.Audio;
		}
		return "";
	}

	// Token: 0x0600CF2A RID: 53034 RVA: 0x003D8CE8 File Offset: 0x003D6EE8
	public string GetInfoDisplayBgStamp(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.Background;
		}
		return "";
	}

	// Token: 0x0600CF2B RID: 53035 RVA: 0x003D8D1C File Offset: 0x003D6F1C
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

	// Token: 0x0600CF2C RID: 53036 RVA: 0x003D8D78 File Offset: 0x003D6F78
	public string GetInfoDisplayEntryAudio(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.EntryAudio;
		}
		return "";
	}

	// Token: 0x0600CF2D RID: 53037 RVA: 0x003D8DAC File Offset: 0x003D6FAC
	public string GetInfoDisplayExitAudio(int id)
	{
		InfoDisplay? infoDisplayConfig = this.GetInfoDisplayConfig(id);
		if (infoDisplayConfig != null)
		{
			return infoDisplayConfig.Value.ExitAudio;
		}
		return "";
	}

	// Token: 0x17001371 RID: 4977
	// (get) Token: 0x0600CF2E RID: 53038 RVA: 0x003D8DDF File Offset: 0x003D6FDF
	public static InfoDisplayModuleConfig Instance
	{
		get
		{
			return InfoDisplayModuleConfig._Instance;
		}
	}

	// Token: 0x0600CF2F RID: 53039 RVA: 0x003D8DE6 File Offset: 0x003D6FE6
	public static InfoDisplayModuleConfig GetOrCreateInstance()
	{
		if (InfoDisplayModuleConfig._Instance == null)
		{
			InfoDisplayModuleConfig.CreateInstance();
		}
		return InfoDisplayModuleConfig._Instance;
	}

	// Token: 0x0600CF30 RID: 53040 RVA: 0x003D8DFA File Offset: 0x003D6FFA
	public static bool CreateInstance()
	{
		if (InfoDisplayModuleConfig._Instance != null)
		{
			return true;
		}
		InfoDisplayModuleConfig._Instance = new InfoDisplayModuleConfig();
		return true;
	}

	// Token: 0x0600CF31 RID: 53041 RVA: 0x003D8E10 File Offset: 0x003D7010
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600CF32 RID: 53042 RVA: 0x003D8E12 File Offset: 0x003D7012
	public static void ResetStaticDefaultValue()
	{
		InfoDisplayModuleConfig._Instance = null;
	}

	// Token: 0x0600CF33 RID: 53043 RVA: 0x003D8E1A File Offset: 0x003D701A
	static InfoDisplayModuleConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(InfoDisplayModuleConfig.CreateStaticDefaultValue), new Action(InfoDisplayModuleConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040075B7 RID: 30135
	[Nullable(2)]
	private static InfoDisplayModuleConfig _Instance;
}
