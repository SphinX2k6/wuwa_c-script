using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200229A RID: 8858
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class MotorDiyConfig : ConfigBase
{
	// Token: 0x060114D5 RID: 70869 RVA: 0x004396EC File Offset: 0x004378EC
	public IReadOnlyList<MotorSkin> GetAllMotorSkinList()
	{
		IReadOnlyList<MotorSkin> configList = ConfigMotorSkinAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorSkin表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorSkin>();
		}
		return configList.ToList<MotorSkin>();
	}

	// Token: 0x060114D6 RID: 70870 RVA: 0x0043972E File Offset: 0x0043792E
	public MotorSkin? GetMotorSkinConfig(int skinId)
	{
		return ConfigMotorSkinById.GetConfig(skinId, true);
	}

	// Token: 0x060114D7 RID: 70871 RVA: 0x00439738 File Offset: 0x00437938
	public IReadOnlyList<MotorScene> GetAllMotorSceneList()
	{
		IReadOnlyList<MotorScene> configList = ConfigMotorSceneAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorScene表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorScene>();
		}
		return configList.ToList<MotorScene>();
	}

	// Token: 0x060114D8 RID: 70872 RVA: 0x0043977A File Offset: 0x0043797A
	public MotorScene? GetMotorSceneConfig(int sceneId)
	{
		return ConfigMotorSceneById.GetConfig(sceneId, true);
	}

	// Token: 0x060114D9 RID: 70873 RVA: 0x00439783 File Offset: 0x00437983
	public MotorStickerPart? GetMotorStickerPartConfig(int id)
	{
		return ConfigMotorStickerPartById.GetConfig(id, true);
	}

	// Token: 0x060114DA RID: 70874 RVA: 0x0043978C File Offset: 0x0043798C
	public MotorDecorationsPart? GetMotorDecorationPartConfig(int id)
	{
		return ConfigMotorDecorationsPartById.GetConfig(id, true);
	}

	// Token: 0x060114DB RID: 70875 RVA: 0x00439795 File Offset: 0x00437995
	public MotorFramePart? GetMotorFramePartConfig()
	{
		return ConfigMotorFramePartById.GetConfig(1, true);
	}

	// Token: 0x060114DC RID: 70876 RVA: 0x0043979E File Offset: 0x0043799E
	public MotorQuality? GetMotorQualityConfig(int qualityId)
	{
		return ConfigMotorQualityByQualityId.GetConfig(qualityId, true);
	}

	// Token: 0x060114DD RID: 70877 RVA: 0x004397A7 File Offset: 0x004379A7
	public MotorSticker? GetMotorStickerConfig(int id)
	{
		return ConfigMotorStickerById.GetConfig(id, true);
	}

	// Token: 0x060114DE RID: 70878 RVA: 0x004397B0 File Offset: 0x004379B0
	public MotorFrame? GetMotorFrameConfig(int id)
	{
		return ConfigMotorFrameById.GetConfig(id, true);
	}

	// Token: 0x060114DF RID: 70879 RVA: 0x004397B9 File Offset: 0x004379B9
	public MotorDecorations? GetMotorDecorationConfig(int id)
	{
		return ConfigMotorDecorationsById.GetConfig(id, true);
	}

	// Token: 0x060114E0 RID: 70880 RVA: 0x004397C2 File Offset: 0x004379C2
	public MotorComponentGroup? GetMotorComponentGroupConfig(int id)
	{
		return ConfigMotorComponentGroupById.GetConfig(id, true);
	}

	// Token: 0x060114E1 RID: 70881 RVA: 0x004397CC File Offset: 0x004379CC
	public IReadOnlyList<MotorLoadProject> GetAllMotorPresetList()
	{
		IReadOnlyList<MotorLoadProject> configList = ConfigMotorLoadProjectAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Motor, ELogAuthor.LZK, "MotorLoadProject表无效All", default(ReadOnlySpan<ValueTuple<string, object>>));
			return new List<MotorLoadProject>();
		}
		return configList.ToList<MotorLoadProject>();
	}

	// Token: 0x060114E2 RID: 70882 RVA: 0x0043980E File Offset: 0x00437A0E
	public MotorLoadProject? GetMotorPresetConfig(int id)
	{
		return ConfigMotorLoadProjectById.GetConfig(id, true);
	}

	// Token: 0x060114E3 RID: 70883 RVA: 0x00439817 File Offset: 0x00437A17
	public MotorGeneralPreview? GetMotorGeneralPreviewConfig(int id)
	{
		return ConfigMotorGeneralPreviewById.GetConfig(id, true);
	}

	// Token: 0x17001612 RID: 5650
	// (get) Token: 0x060114E4 RID: 70884 RVA: 0x00439820 File Offset: 0x00437A20
	public static MotorDiyConfig Instance
	{
		get
		{
			return MotorDiyConfig._Instance;
		}
	}

	// Token: 0x060114E5 RID: 70885 RVA: 0x00439827 File Offset: 0x00437A27
	public static MotorDiyConfig GetOrCreateInstance()
	{
		if (MotorDiyConfig._Instance == null)
		{
			MotorDiyConfig.CreateInstance();
		}
		return MotorDiyConfig._Instance;
	}

	// Token: 0x060114E6 RID: 70886 RVA: 0x0043983B File Offset: 0x00437A3B
	public static bool CreateInstance()
	{
		if (MotorDiyConfig._Instance != null)
		{
			return true;
		}
		MotorDiyConfig._Instance = new MotorDiyConfig();
		return true;
	}

	// Token: 0x060114E7 RID: 70887 RVA: 0x00439851 File Offset: 0x00437A51
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060114E8 RID: 70888 RVA: 0x00439853 File Offset: 0x00437A53
	public static void ResetStaticDefaultValue()
	{
		MotorDiyConfig._Instance = null;
	}

	// Token: 0x060114E9 RID: 70889 RVA: 0x0043985B File Offset: 0x00437A5B
	static MotorDiyConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(MotorDiyConfig.CreateStaticDefaultValue), new Action(MotorDiyConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04008398 RID: 33688
	[Nullable(2)]
	private static MotorDiyConfig _Instance;
}
