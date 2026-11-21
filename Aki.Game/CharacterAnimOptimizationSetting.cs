using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

// Token: 0x0200282A RID: 10282
[NullableContext(1)]
[Nullable(0)]
public class CharacterAnimOptimizationSetting : Singleton
{
	// Token: 0x170029C7 RID: 10695
	// (get) Token: 0x06019E55 RID: 106069 RVA: 0x007FBAD1 File Offset: 0x007F9CD1
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

	// Token: 0x06019E56 RID: 106070 RVA: 0x007FBAF4 File Offset: 0x007F9CF4
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06019E57 RID: 106071 RVA: 0x007FBAF6 File Offset: 0x007F9CF6
	public static void ResetStaticDefaultValue()
	{
		CharacterAnimOptimizationSetting instance = CharacterAnimOptimizationSetting._instance;
		if (instance != null)
		{
			instance.OnClear();
		}
		CharacterAnimOptimizationSetting._instance = null;
	}

	// Token: 0x06019E58 RID: 106072 RVA: 0x007FBB0F File Offset: 0x007F9D0F
	static CharacterAnimOptimizationSetting()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CharacterAnimOptimizationSetting.CreateStaticDefaultValue), new Action(CharacterAnimOptimizationSetting.ResetStaticDefaultValue));
	}

	// Token: 0x06019E59 RID: 106073 RVA: 0x007FBB2E File Offset: 0x007F9D2E
	public CharacterAnimOptimizationSetting()
	{
		EVisibilityBasedAnimTickOption[] array = new EVisibilityBasedAnimTickOption[9];
		RuntimeHelpers.InitializeArray(array, fieldof(<PrivateImplementationDetails>.D2DCD027297326BE5922C0FDABEA867C1FD485C387D3D910C582B914204C7DAB).FieldHandle);
		this.DisableAnimOptimizationTypeDefines = array;
		base..ctor();
	}

	// Token: 0x0400E345 RID: 58181
	public readonly EVisibilityBasedAnimTickOption[] DisableAnimOptimizationTypeDefines;

	// Token: 0x0400E346 RID: 58182
	[Nullable(2)]
	private static CharacterAnimOptimizationSetting _instance;
}
