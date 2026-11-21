using System;
using System.Runtime.CompilerServices;

// Token: 0x02002887 RID: 10375
public class PreloadSetting : IStaticVariableResetter
{
	// Token: 0x0601A4C8 RID: 107720 RVA: 0x00824684 File Offset: 0x00822884
	static PreloadSetting()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PreloadSetting.CreateStaticDefaultValue), new Action(PreloadSetting.ResetStaticDefaultValue));
	}

	// Token: 0x17002B18 RID: 11032
	// (get) Token: 0x0601A4C9 RID: 107721 RVA: 0x008246A3 File Offset: 0x008228A3
	[Nullable(1)]
	public static PreloadSetting Default
	{
		[NullableContext(1)]
		get
		{
			return PreloadSetting._default;
		}
	}

	// Token: 0x17002B19 RID: 11033
	// (get) Token: 0x0601A4CA RID: 107722 RVA: 0x008246AA File Offset: 0x008228AA
	public static bool UseNewPreload
	{
		get
		{
			return PreloadSetting.UseNewPreloadInternal;
		}
	}

	// Token: 0x0601A4CB RID: 107723 RVA: 0x008246B1 File Offset: 0x008228B1
	public static void SetUseNewPreload(bool value)
	{
		PreloadSetting.UseNewPreloadInternal = value;
	}

	// Token: 0x0601A4CC RID: 107724 RVA: 0x008246B9 File Offset: 0x008228B9
	public static void CreateStaticDefaultValue()
	{
		PreloadSetting._default = new PreloadSetting();
		PreloadSetting.UseNewPreloadInternal = true;
		PreloadSetting.LoadAllPreloadData = false;
	}

	// Token: 0x0601A4CD RID: 107725 RVA: 0x008246D1 File Offset: 0x008228D1
	public static void ResetStaticDefaultValue()
	{
		PreloadSetting._default = null;
		PreloadSetting.UseNewPreloadInternal = true;
		PreloadSetting.LoadAllPreloadData = false;
	}

	// Token: 0x0400E6FF RID: 59135
	[Nullable(2)]
	private static PreloadSetting _default;

	// Token: 0x0400E700 RID: 59136
	private static bool UseNewPreloadInternal;

	// Token: 0x0400E701 RID: 59137
	public static bool LoadAllPreloadData;
}
