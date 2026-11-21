using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020014E4 RID: 5348
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GetWayConfig : ConfigBase
{
	// Token: 0x0600D603 RID: 54787 RVA: 0x003F83DC File Offset: 0x003F65DC
	[NullableContext(2)]
	public string GetWayName(int getWayId)
	{
		AccessPath? config = ConfigAccessPathById.GetConfig(getWayId, true);
		if (config != null)
		{
			return ConfigMultiTextLang.GetLocalTextNew(config.Value.Description, null);
		}
		return null;
	}

	// Token: 0x0600D604 RID: 54788 RVA: 0x003F8411 File Offset: 0x003F6611
	public AccessPath? GetConfigById(int getWayId)
	{
		return ConfigAccessPathById.GetConfig(getWayId, true);
	}

	// Token: 0x170013D1 RID: 5073
	// (get) Token: 0x0600D605 RID: 54789 RVA: 0x003F841A File Offset: 0x003F661A
	public static GetWayConfig Instance
	{
		get
		{
			return GetWayConfig._Instance;
		}
	}

	// Token: 0x0600D606 RID: 54790 RVA: 0x003F8421 File Offset: 0x003F6621
	public static GetWayConfig GetOrCreateInstance()
	{
		if (GetWayConfig._Instance == null)
		{
			GetWayConfig.CreateInstance();
		}
		return GetWayConfig._Instance;
	}

	// Token: 0x0600D607 RID: 54791 RVA: 0x003F8435 File Offset: 0x003F6635
	public static bool CreateInstance()
	{
		if (GetWayConfig._Instance != null)
		{
			return true;
		}
		GetWayConfig._Instance = new GetWayConfig();
		return true;
	}

	// Token: 0x0600D608 RID: 54792 RVA: 0x003F844B File Offset: 0x003F664B
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D609 RID: 54793 RVA: 0x003F844D File Offset: 0x003F664D
	public static void ResetStaticDefaultValue()
	{
		GetWayConfig._Instance = null;
	}

	// Token: 0x0600D60A RID: 54794 RVA: 0x003F8455 File Offset: 0x003F6655
	static GetWayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GetWayConfig.CreateStaticDefaultValue), new Action(GetWayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007810 RID: 30736
	[Nullable(2)]
	private static GetWayConfig _Instance;
}
