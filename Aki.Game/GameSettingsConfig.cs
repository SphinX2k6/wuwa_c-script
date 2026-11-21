using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000279 RID: 633
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GameSettingsConfig : ConfigBase
{
	// Token: 0x060026EA RID: 9962 RVA: 0x000EB5B5 File Offset: 0x000E97B5
	[NullableContext(2)]
	public IReadOnlyList<DeviceRenderFeature> GetDeviceRenderFeatureConfigListByDeviceId(int deviceId)
	{
		return ConfigDeviceRenderFeatureByDeviceId.GetConfigList(deviceId, true);
	}

	// Token: 0x170005F5 RID: 1525
	// (get) Token: 0x060026EB RID: 9963 RVA: 0x000EB5BE File Offset: 0x000E97BE
	public static GameSettingsConfig Instance
	{
		get
		{
			return GameSettingsConfig._Instance;
		}
	}

	// Token: 0x060026EC RID: 9964 RVA: 0x000EB5C5 File Offset: 0x000E97C5
	public static GameSettingsConfig GetOrCreateInstance()
	{
		if (GameSettingsConfig._Instance == null)
		{
			GameSettingsConfig.CreateInstance();
		}
		return GameSettingsConfig._Instance;
	}

	// Token: 0x060026ED RID: 9965 RVA: 0x000EB5D9 File Offset: 0x000E97D9
	public static bool CreateInstance()
	{
		if (GameSettingsConfig._Instance != null)
		{
			return true;
		}
		GameSettingsConfig._Instance = new GameSettingsConfig();
		return true;
	}

	// Token: 0x060026EE RID: 9966 RVA: 0x000EB5EF File Offset: 0x000E97EF
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060026EF RID: 9967 RVA: 0x000EB5F1 File Offset: 0x000E97F1
	public static void ResetStaticDefaultValue()
	{
		GameSettingsConfig._Instance = null;
	}

	// Token: 0x060026F0 RID: 9968 RVA: 0x000EB5F9 File Offset: 0x000E97F9
	static GameSettingsConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GameSettingsConfig.CreateStaticDefaultValue), new Action(GameSettingsConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400254D RID: 9549
	[Nullable(2)]
	private static GameSettingsConfig _Instance;
}
