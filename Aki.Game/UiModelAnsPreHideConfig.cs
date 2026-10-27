using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02002C75 RID: 11381
public class UiModelAnsPreHideConfig : IStaticVariableResetter
{
	// Token: 0x06017C4B RID: 97355 RVA: 0x0060BA31 File Offset: 0x00609C31
	static UiModelAnsPreHideConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(UiModelAnsPreHideConfig.CreateStaticDefaultValue), new Action(UiModelAnsPreHideConfig.ResetStaticDefaultValue));
	}

	// Token: 0x17001FEC RID: 8172
	// (get) Token: 0x06017C4C RID: 97356 RVA: 0x0060BA50 File Offset: 0x00609C50
	[Nullable(1)]
	public static IReadOnlyList<string> PreHideOnAnsEndEffects
	{
		[NullableContext(1)]
		get
		{
			return UiModelAnsPreHideConfig._preHideOnAnsEndEffects;
		}
	}

	// Token: 0x06017C4D RID: 97357 RVA: 0x0060BA57 File Offset: 0x00609C57
	public static void CreateStaticDefaultValue()
	{
		UiModelAnsPreHideConfig._preHideOnAnsEndEffects = new List<string>
		{
			"DA_Fx_Group_Stand_Ring01",
			"DA_Fx_Group_Stand_Ring02"
		};
	}

	// Token: 0x06017C4E RID: 97358 RVA: 0x0060BA79 File Offset: 0x00609C79
	public static void ResetStaticDefaultValue()
	{
		UiModelAnsPreHideConfig._preHideOnAnsEndEffects = null;
	}

	// Token: 0x0400B123 RID: 45347
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static List<string> _preHideOnAnsEndEffects;
}
