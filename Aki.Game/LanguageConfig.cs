using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001525 RID: 5413
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class LanguageConfig : ConfigBase
{
	// Token: 0x0600D88C RID: 55436 RVA: 0x0040353F File Offset: 0x0040173F
	public Aki.Config.LanguageDefine? GetLanguageDefineByLanguageCode(string code)
	{
		return ConfigLanguageDefineByLanguageCode.GetConfig(code, true);
	}

	// Token: 0x0600D88D RID: 55437 RVA: 0x00403548 File Offset: 0x00401748
	public Aki.Config.LanguageDefine? GetLanguageDefineById(int id)
	{
		return ConfigLanguageDefineByLanguageType.GetConfig(id, true);
	}

	// Token: 0x17001421 RID: 5153
	// (get) Token: 0x0600D88E RID: 55438 RVA: 0x00403551 File Offset: 0x00401751
	public static LanguageConfig Instance
	{
		get
		{
			return LanguageConfig._Instance;
		}
	}

	// Token: 0x0600D88F RID: 55439 RVA: 0x00403558 File Offset: 0x00401758
	public static LanguageConfig GetOrCreateInstance()
	{
		if (LanguageConfig._Instance == null)
		{
			LanguageConfig.CreateInstance();
		}
		return LanguageConfig._Instance;
	}

	// Token: 0x0600D890 RID: 55440 RVA: 0x0040356C File Offset: 0x0040176C
	public static bool CreateInstance()
	{
		if (LanguageConfig._Instance != null)
		{
			return true;
		}
		LanguageConfig._Instance = new LanguageConfig();
		return true;
	}

	// Token: 0x0600D891 RID: 55441 RVA: 0x00403582 File Offset: 0x00401782
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D892 RID: 55442 RVA: 0x00403584 File Offset: 0x00401784
	public static void ResetStaticDefaultValue()
	{
		LanguageConfig._Instance = null;
	}

	// Token: 0x0600D893 RID: 55443 RVA: 0x0040358C File Offset: 0x0040178C
	static LanguageConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(LanguageConfig.CreateStaticDefaultValue), new Action(LanguageConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04007928 RID: 31016
	[Nullable(2)]
	private static LanguageConfig _Instance;
}
