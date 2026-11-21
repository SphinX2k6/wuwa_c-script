using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000EC3 RID: 3779
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DamageUiConfig : ConfigBase
{
	// Token: 0x060096F7 RID: 38647 RVA: 0x002CBE39 File Offset: 0x002CA039
	[NullableContext(2)]
	public IReadOnlyList<DamageText> GetAllDamageTextConfig()
	{
		return ConfigDamageTextAll.GetConfigList(true);
	}

	// Token: 0x060096F8 RID: 38648 RVA: 0x002CBE41 File Offset: 0x002CA041
	[NullableContext(2)]
	public IReadOnlyList<DamageTextArea> GetAllDamageTextArea()
	{
		return ConfigDamageTextAreaAll.GetConfigList(true);
	}

	// Token: 0x1700106D RID: 4205
	// (get) Token: 0x060096F9 RID: 38649 RVA: 0x002CBE49 File Offset: 0x002CA049
	public static DamageUiConfig Instance
	{
		get
		{
			return DamageUiConfig._Instance;
		}
	}

	// Token: 0x060096FA RID: 38650 RVA: 0x002CBE50 File Offset: 0x002CA050
	public static DamageUiConfig GetOrCreateInstance()
	{
		if (DamageUiConfig._Instance == null)
		{
			DamageUiConfig.CreateInstance();
		}
		return DamageUiConfig._Instance;
	}

	// Token: 0x060096FB RID: 38651 RVA: 0x002CBE64 File Offset: 0x002CA064
	public static bool CreateInstance()
	{
		if (DamageUiConfig._Instance != null)
		{
			return true;
		}
		DamageUiConfig._Instance = new DamageUiConfig();
		return true;
	}

	// Token: 0x060096FC RID: 38652 RVA: 0x002CBE7A File Offset: 0x002CA07A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060096FD RID: 38653 RVA: 0x002CBE7C File Offset: 0x002CA07C
	public static void ResetStaticDefaultValue()
	{
		DamageUiConfig._Instance = null;
	}

	// Token: 0x060096FE RID: 38654 RVA: 0x002CBE84 File Offset: 0x002CA084
	static DamageUiConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DamageUiConfig.CreateStaticDefaultValue), new Action(DamageUiConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005AB7 RID: 23223
	[Nullable(2)]
	private static DamageUiConfig _Instance;
}
