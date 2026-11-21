using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001AD0 RID: 6864
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PlatformConfig : ConfigBase
{
	// Token: 0x0601107B RID: 69755 RVA: 0x0050136F File Offset: 0x004FF56F
	public DevicePlatform? GetDeviceConfigByProductIdAndVendorId(string productIdAndVendorId)
	{
		return ConfigDevicePlatformByPidAndVid.GetConfig(productIdAndVendorId, true);
	}

	// Token: 0x17001983 RID: 6531
	// (get) Token: 0x0601107C RID: 69756 RVA: 0x00501378 File Offset: 0x004FF578
	public static PlatformConfig Instance
	{
		get
		{
			return PlatformConfig._Instance;
		}
	}

	// Token: 0x0601107D RID: 69757 RVA: 0x0050137F File Offset: 0x004FF57F
	public static PlatformConfig GetOrCreateInstance()
	{
		if (PlatformConfig._Instance == null)
		{
			PlatformConfig.CreateInstance();
		}
		return PlatformConfig._Instance;
	}

	// Token: 0x0601107E RID: 69758 RVA: 0x00501393 File Offset: 0x004FF593
	public static bool CreateInstance()
	{
		if (PlatformConfig._Instance != null)
		{
			return true;
		}
		PlatformConfig._Instance = new PlatformConfig();
		return true;
	}

	// Token: 0x0601107F RID: 69759 RVA: 0x005013A9 File Offset: 0x004FF5A9
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06011080 RID: 69760 RVA: 0x005013AB File Offset: 0x004FF5AB
	public static void ResetStaticDefaultValue()
	{
		PlatformConfig._Instance = null;
	}

	// Token: 0x06011081 RID: 69761 RVA: 0x005013B3 File Offset: 0x004FF5B3
	static PlatformConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PlatformConfig.CreateStaticDefaultValue), new Action(PlatformConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040095F5 RID: 38389
	[Nullable(2)]
	private static PlatformConfig _Instance;
}
