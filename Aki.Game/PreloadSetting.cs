using System;
using System.Runtime.CompilerServices;

// Token: 0x02003315 RID: 13077
public class PreloadSetting : IStaticVariableResetter
{
	// Token: 0x0601C7CF RID: 116687 RVA: 0x007FE118 File Offset: 0x007FC318
	static PreloadSetting()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreloadSetting.CreateStaticDefaultValue), new Action(PreloadSetting.ResetStaticDefaultValue));
	}

	// Token: 0x1700277B RID: 10107
	// (get) Token: 0x0601C7D0 RID: 116688 RVA: 0x007FE137 File Offset: 0x007FC337
	[Nullable(1)]
	public static PreloadSetting Default
	{
		[NullableContext(1)]
		get
		{
			return PreloadSetting._default;
		}
	}

	// Token: 0x1700277C RID: 10108
	// (get) Token: 0x0601C7D1 RID: 116689 RVA: 0x007FE13E File Offset: 0x007FC33E
	public static bool UseNewPreload
	{
		get
		{
			return PreloadSetting.UseNewPreloadInternal;
		}
	}

	// Token: 0x0601C7D2 RID: 116690 RVA: 0x007FE145 File Offset: 0x007FC345
	public static void SetUseNewPreload(bool value)
	{
		PreloadSetting.UseNewPreloadInternal = value;
	}

	// Token: 0x0601C7D3 RID: 116691 RVA: 0x007FE14D File Offset: 0x007FC34D
	public static void CreateStaticDefaultValue()
	{
		PreloadSetting._default = new PreloadSetting();
		PreloadSetting.UseNewPreloadInternal = true;
		PreloadSetting.LoadAllPreloadData = false;
	}

	// Token: 0x0601C7D4 RID: 116692 RVA: 0x007FE165 File Offset: 0x007FC365
	public static void ResetStaticDefaultValue()
	{
		PreloadSetting._default = null;
		PreloadSetting.UseNewPreloadInternal = true;
		PreloadSetting.LoadAllPreloadData = false;
	}

	// Token: 0x0400E24E RID: 57934
	[Nullable(2)]
	private static PreloadSetting _default;

	// Token: 0x0400E24F RID: 57935
	private static bool UseNewPreloadInternal;

	// Token: 0x0400E250 RID: 57936
	public static bool LoadAllPreloadData;
}
