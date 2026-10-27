using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x020032B9 RID: 12985
[NullableContext(1)]
[Nullable(0)]
public class CharacterAnimOptimizationSetting : Singleton
{
	// Token: 0x170026DA RID: 9946
	// (get) Token: 0x0601C214 RID: 115220 RVA: 0x007D49D5 File Offset: 0x007D2BD5
	public static CharacterAnimOptimizationSetting Instance
	{
		get
		{
			if (CharacterAnimOptimizationSetting._instance == null)
			{
				CharacterAnimOptimizationSetting._instance = new CharacterAnimOptimizationSetting();
				CharacterAnimOptimizationSetting._instance.OnInit();
			}
			return CharacterAnimOptimizationSetting._instance;
		}
	}

	// Token: 0x0601C215 RID: 115221 RVA: 0x007D49F8 File Offset: 0x007D2BF8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601C216 RID: 115222 RVA: 0x007D49FA File Offset: 0x007D2BFA
	public static void ResetStaticDefaultValue()
	{
		CharacterAnimOptimizationSetting instance = CharacterAnimOptimizationSetting._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CharacterAnimOptimizationSetting._instance = null;
	}

	// Token: 0x0601C217 RID: 115223 RVA: 0x007D4A13 File Offset: 0x007D2C13
	static CharacterAnimOptimizationSetting()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterAnimOptimizationSetting.CreateStaticDefaultValue), new Action(CharacterAnimOptimizationSetting.ResetStaticDefaultValue));
	}

	// Token: 0x0601C218 RID: 115224 RVA: 0x007D4A32 File Offset: 0x007D2C32
	public CharacterAnimOptimizationSetting()
	{
		EVisibilityBasedAnimTickOption[] array = new EVisibilityBasedAnimTickOption[9];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.D2DCD027297326BE5922C0FDABEA867C1FD485C387D3D910C582B914204C7DAB).FieldHandle);
		this.DisableAnimOptimizationTypeDefines = array;
		base..ctor();
	}

	// Token: 0x0400DE9F RID: 56991
	public readonly EVisibilityBasedAnimTickOption[] DisableAnimOptimizationTypeDefines;

	// Token: 0x0400DEA0 RID: 56992
	[Nullable(2)]
	private static CharacterAnimOptimizationSetting _instance;
}
