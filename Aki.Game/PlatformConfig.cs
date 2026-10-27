using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020025E5 RID: 9701
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PlatformConfig : ConfigBase
{
	// Token: 0x06013B99 RID: 80793 RVA: 0x004F263F File Offset: 0x004F083F
	public DevicePlatform? GetDeviceConfigByProductIdAndVendorId(string productIdAndVendorId)
	{
		return ConfigDevicePlatformByPidAndVid.GetConfig(productIdAndVendorId, true);
	}

	// Token: 0x1700194B RID: 6475
	// (get) Token: 0x06013B9A RID: 80794 RVA: 0x004F2648 File Offset: 0x004F0848
	public static PlatformConfig Instance
	{
		get
		{
			return PlatformConfig._Instance;
		}
	}

	// Token: 0x06013B9B RID: 80795 RVA: 0x004F264F File Offset: 0x004F084F
	public static PlatformConfig GetOrCreateInstance()
	{
		if (PlatformConfig._Instance == null)
		{
			PlatformConfig.CreateInstance();
		}
		return PlatformConfig._Instance;
	}

	// Token: 0x06013B9C RID: 80796 RVA: 0x004F2663 File Offset: 0x004F0863
	public static bool CreateInstance()
	{
		if (PlatformConfig._Instance != null)
		{
			return true;
		}
		PlatformConfig._Instance = new PlatformConfig();
		return true;
	}

	// Token: 0x06013B9D RID: 80797 RVA: 0x004F2679 File Offset: 0x004F0879
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013B9E RID: 80798 RVA: 0x004F267B File Offset: 0x004F087B
	public static void ResetStaticDefaultValue()
	{
		PlatformConfig._Instance = null;
	}

	// Token: 0x06013B9F RID: 80799 RVA: 0x004F2683 File Offset: 0x004F0883
	static PlatformConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlatformConfig.CreateStaticDefaultValue), new Action(PlatformConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400949E RID: 38046
	[Nullable(2)]
	private static PlatformConfig _Instance;
}
