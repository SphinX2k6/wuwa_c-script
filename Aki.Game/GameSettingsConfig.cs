using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000DC7 RID: 3527
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GameSettingsConfig : ConfigBase
{
	// Token: 0x06005376 RID: 21366 RVA: 0x000E5015 File Offset: 0x000E3215
	[NullableContext(2)]
	public IReadOnlyList<DeviceRenderFeature> GetDeviceRenderFeatureConfigListByDeviceId(int deviceId)
	{
		return ConfigDeviceRenderFeatureByDeviceId.GetConfigList(deviceId, true);
	}

	// Token: 0x170005CF RID: 1487
	// (get) Token: 0x06005377 RID: 21367 RVA: 0x000E501E File Offset: 0x000E321E
	public static GameSettingsConfig Instance
	{
		get
		{
			return GameSettingsConfig._Instance;
		}
	}

	// Token: 0x06005378 RID: 21368 RVA: 0x000E5025 File Offset: 0x000E3225
	public static GameSettingsConfig GetOrCreateInstance()
	{
		if (GameSettingsConfig._Instance == null)
		{
			GameSettingsConfig.CreateInstance();
		}
		return GameSettingsConfig._Instance;
	}

	// Token: 0x06005379 RID: 21369 RVA: 0x000E5039 File Offset: 0x000E3239
	public static bool CreateInstance()
	{
		if (GameSettingsConfig._Instance != null)
		{
			return true;
		}
		GameSettingsConfig._Instance = new GameSettingsConfig();
		return true;
	}

	// Token: 0x0600537A RID: 21370 RVA: 0x000E504F File Offset: 0x000E324F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600537B RID: 21371 RVA: 0x000E5051 File Offset: 0x000E3251
	public static void ResetStaticDefaultValue()
	{
		GameSettingsConfig._Instance = null;
	}

	// Token: 0x0600537C RID: 21372 RVA: 0x000E5059 File Offset: 0x000E3259
	static GameSettingsConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsConfig.CreateStaticDefaultValue), new Action(GameSettingsConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040024CD RID: 9421
	[Nullable(2)]
	private static GameSettingsConfig _Instance;
}
