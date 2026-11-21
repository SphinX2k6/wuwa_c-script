using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020021CE RID: 8654
public class UiModelAnsPreHideConfig : IStaticVariableResetter
{
	// Token: 0x060154BD RID: 87229 RVA: 0x006314D9 File Offset: 0x0062F6D9
	static UiModelAnsPreHideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelAnsPreHideConfig.CreateStaticDefaultValue), new Action(UiModelAnsPreHideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x1700203D RID: 8253
	// (get) Token: 0x060154BE RID: 87230 RVA: 0x006314F8 File Offset: 0x0062F6F8
	[Nullable(1)]
	public static IReadOnlyList<string> PreHideOnAnsEndEffects
	{
		[NullableContext(1)]
		get
		{
			return UiModelAnsPreHideConfig._preHideOnAnsEndEffects;
		}
	}

	// Token: 0x060154BF RID: 87231 RVA: 0x006314FF File Offset: 0x0062F6FF
	public static void CreateStaticDefaultValue()
	{
		UiModelAnsPreHideConfig._preHideOnAnsEndEffects = new List<string>
		{
			"DA_Fx_Group_Stand_Ring01",
			"DA_Fx_Group_Stand_Ring02"
		};
	}

	// Token: 0x060154C0 RID: 87232 RVA: 0x00631521 File Offset: 0x0062F721
	public static void ResetStaticDefaultValue()
	{
		UiModelAnsPreHideConfig._preHideOnAnsEndEffects = null;
	}

	// Token: 0x0400B48E RID: 46222
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _preHideOnAnsEndEffects;
}
