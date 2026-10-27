using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002011 RID: 8209
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class GetWayConfig : ConfigBase
{
	// Token: 0x0601019B RID: 65947 RVA: 0x003EBDE4 File Offset: 0x003E9FE4
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

	// Token: 0x0601019C RID: 65948 RVA: 0x003EBE19 File Offset: 0x003EA019
	public AccessPath? GetConfigById(int getWayId)
	{
		return ConfigAccessPathById.GetConfig(getWayId, true);
	}

	// Token: 0x170013A4 RID: 5028
	// (get) Token: 0x0601019D RID: 65949 RVA: 0x003EBE22 File Offset: 0x003EA022
	public static GetWayConfig Instance
	{
		get
		{
			return GetWayConfig._Instance;
		}
	}

	// Token: 0x0601019E RID: 65950 RVA: 0x003EBE29 File Offset: 0x003EA029
	public static GetWayConfig GetOrCreateInstance()
	{
		if (GetWayConfig._Instance == null)
		{
			GetWayConfig.CreateInstance();
		}
		return GetWayConfig._Instance;
	}

	// Token: 0x0601019F RID: 65951 RVA: 0x003EBE3D File Offset: 0x003EA03D
	public static bool CreateInstance()
	{
		if (GetWayConfig._Instance != null)
		{
			return true;
		}
		GetWayConfig._Instance = new GetWayConfig();
		return true;
	}

	// Token: 0x060101A0 RID: 65952 RVA: 0x003EBE53 File Offset: 0x003EA053
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060101A1 RID: 65953 RVA: 0x003EBE55 File Offset: 0x003EA055
	public static void ResetStaticDefaultValue()
	{
		GetWayConfig._Instance = null;
	}

	// Token: 0x060101A2 RID: 65954 RVA: 0x003EBE5D File Offset: 0x003EA05D
	static GetWayConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(GetWayConfig.CreateStaticDefaultValue), new Action(GetWayConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007727 RID: 30503
	[Nullable(2)]
	private static GetWayConfig _Instance;
}
