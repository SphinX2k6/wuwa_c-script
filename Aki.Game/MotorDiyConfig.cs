using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200177E RID: 6014
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorDiyConfig : ConfigBase
{
	// Token: 0x0600E96D RID: 59757 RVA: 0x004462F0 File Offset: 0x004444F0
	public IReadOnlyList<MotorSkin> GetAllMotorSkinList()
	{
		IReadOnlyList<MotorSkin> configList = ConfigMotorSkinAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorSkin表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorSkin>();
		}
		return configList;
	}

	// Token: 0x0600E96E RID: 59758 RVA: 0x0044632D File Offset: 0x0044452D
	public MotorSkin? GetMotorSkinConfig(int skinId)
	{
		return ConfigMotorSkinById.GetConfig(skinId, true);
	}

	// Token: 0x0600E96F RID: 59759 RVA: 0x00446338 File Offset: 0x00444538
	public IReadOnlyList<MotorScene> GetAllMotorSceneList()
	{
		IReadOnlyList<MotorScene> configList = ConfigMotorSceneAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorScene表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorScene>();
		}
		return configList;
	}

	// Token: 0x0600E970 RID: 59760 RVA: 0x00446375 File Offset: 0x00444575
	public MotorScene? GetMotorSceneConfig(int sceneId)
	{
		return ConfigMotorSceneById.GetConfig(sceneId, true);
	}

	// Token: 0x0600E971 RID: 59761 RVA: 0x0044637E File Offset: 0x0044457E
	public MotorStickerPart? GetMotorStickerPartConfig(int id)
	{
		return ConfigMotorStickerPartById.GetConfig(id, true);
	}

	// Token: 0x0600E972 RID: 59762 RVA: 0x00446387 File Offset: 0x00444587
	public MotorDecorationsPart? GetMotorDecorationPartConfig(int id)
	{
		return ConfigMotorDecorationsPartById.GetConfig(id, true);
	}

	// Token: 0x0600E973 RID: 59763 RVA: 0x00446390 File Offset: 0x00444590
	public MotorFramePart? GetMotorFramePartConfig()
	{
		return ConfigMotorFramePartById.GetConfig(1, true);
	}

	// Token: 0x0600E974 RID: 59764 RVA: 0x00446399 File Offset: 0x00444599
	public MotorQuality? GetMotorQualityConfig(int qualityId)
	{
		return ConfigMotorQualityByQualityId.GetConfig(qualityId, true);
	}

	// Token: 0x0600E975 RID: 59765 RVA: 0x004463A2 File Offset: 0x004445A2
	public MotorSticker? GetMotorStickerConfig(int id)
	{
		return ConfigMotorStickerById.GetConfig(id, true);
	}

	// Token: 0x0600E976 RID: 59766 RVA: 0x004463AB File Offset: 0x004445AB
	public MotorFrame? GetMotorFrameConfig(int id)
	{
		return ConfigMotorFrameById.GetConfig(id, true);
	}

	// Token: 0x0600E977 RID: 59767 RVA: 0x004463B4 File Offset: 0x004445B4
	public MotorDecorations? GetMotorDecorationConfig(int id)
	{
		return ConfigMotorDecorationsById.GetConfig(id, true);
	}

	// Token: 0x0600E978 RID: 59768 RVA: 0x004463BD File Offset: 0x004445BD
	public MotorComponentGroup? GetMotorComponentGroupConfig(int id)
	{
		return ConfigMotorComponentGroupById.GetConfig(id, true);
	}

	// Token: 0x0600E979 RID: 59769 RVA: 0x004463C8 File Offset: 0x004445C8
	public IReadOnlyList<MotorLoadProject> GetAllMotorPresetList()
	{
		IReadOnlyList<MotorLoadProject> configList = ConfigMotorLoadProjectAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorLoadProject表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorLoadProject>();
		}
		return configList;
	}

	// Token: 0x0600E97A RID: 59770 RVA: 0x00446405 File Offset: 0x00444605
	public MotorLoadProject? GetMotorPresetConfig(int id)
	{
		return ConfigMotorLoadProjectById.GetConfig(id, true);
	}

	// Token: 0x0600E97B RID: 59771 RVA: 0x0044640E File Offset: 0x0044460E
	public MotorGeneralPreview? GetMotorGeneralPreviewConfig(int id)
	{
		return ConfigMotorGeneralPreviewById.GetConfig(id, true);
	}

	// Token: 0x17001649 RID: 5705
	// (get) Token: 0x0600E97C RID: 59772 RVA: 0x00446417 File Offset: 0x00444617
	public static MotorDiyConfig Instance
	{
		get
		{
			return MotorDiyConfig._Instance;
		}
	}

	// Token: 0x0600E97D RID: 59773 RVA: 0x0044641E File Offset: 0x0044461E
	public static MotorDiyConfig GetOrCreateInstance()
	{
		if (MotorDiyConfig._Instance == null)
		{
			MotorDiyConfig.CreateInstance();
		}
		return MotorDiyConfig._Instance;
	}

	// Token: 0x0600E97E RID: 59774 RVA: 0x00446432 File Offset: 0x00444632
	public static bool CreateInstance()
	{
		if (MotorDiyConfig._Instance != null)
		{
			return true;
		}
		MotorDiyConfig._Instance = new MotorDiyConfig();
		return true;
	}

	// Token: 0x0600E97F RID: 59775 RVA: 0x00446448 File Offset: 0x00444648
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600E980 RID: 59776 RVA: 0x0044644A File Offset: 0x0044464A
	public static void ResetStaticDefaultValue()
	{
		MotorDiyConfig._Instance = null;
	}

	// Token: 0x0600E981 RID: 59777 RVA: 0x00446452 File Offset: 0x00444652
	static MotorDiyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorDiyConfig.CreateStaticDefaultValue), new Action(MotorDiyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040084D6 RID: 34006
	[Nullable(2)]
	private static MotorDiyConfig _Instance;
}
