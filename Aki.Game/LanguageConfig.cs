using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002052 RID: 8274
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LanguageConfig : ConfigBase
{
	// Token: 0x06010425 RID: 66597 RVA: 0x003F7047 File Offset: 0x003F5247
	public Aki.Config.LanguageDefine? GetLanguageDefineByLanguageCode(string code)
	{
		return ConfigLanguageDefineByLanguageCode.GetConfig(code, true);
	}

	// Token: 0x06010426 RID: 66598 RVA: 0x003F7050 File Offset: 0x003F5250
	public Aki.Config.LanguageDefine? GetLanguageDefineById(int id)
	{
		return ConfigLanguageDefineByLanguageType.GetConfig(id, true);
	}

	// Token: 0x170013F4 RID: 5108
	// (get) Token: 0x06010427 RID: 66599 RVA: 0x003F7059 File Offset: 0x003F5259
	public static LanguageConfig Instance
	{
		get
		{
			return LanguageConfig._Instance;
		}
	}

	// Token: 0x06010428 RID: 66600 RVA: 0x003F7060 File Offset: 0x003F5260
	public static LanguageConfig GetOrCreateInstance()
	{
		if (LanguageConfig._Instance == null)
		{
			LanguageConfig.CreateInstance();
		}
		return LanguageConfig._Instance;
	}

	// Token: 0x06010429 RID: 66601 RVA: 0x003F7074 File Offset: 0x003F5274
	public static bool CreateInstance()
	{
		if (LanguageConfig._Instance != null)
		{
			return true;
		}
		LanguageConfig._Instance = new LanguageConfig();
		return true;
	}

	// Token: 0x0601042A RID: 66602 RVA: 0x003F708A File Offset: 0x003F528A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601042B RID: 66603 RVA: 0x003F708C File Offset: 0x003F528C
	public static void ResetStaticDefaultValue()
	{
		LanguageConfig._Instance = null;
	}

	// Token: 0x0601042C RID: 66604 RVA: 0x003F7094 File Offset: 0x003F5294
	static LanguageConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LanguageConfig.CreateStaticDefaultValue), new Action(LanguageConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400783F RID: 30783
	[Nullable(2)]
	private static LanguageConfig _Instance;
}
