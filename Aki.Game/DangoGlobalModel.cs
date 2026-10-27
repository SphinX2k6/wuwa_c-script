using System;
using System.Runtime.CompilerServices;

// Token: 0x02001A70 RID: 6768
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DangoGlobalModel : ModelBase
{
	// Token: 0x0600C74C RID: 51020 RVA: 0x002D63A5 File Offset: 0x002D45A5
	protected override bool OnClear()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600C74D RID: 51021 RVA: 0x002D63AE File Offset: 0x002D45AE
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600C74E RID: 51022 RVA: 0x002D63B7 File Offset: 0x002D45B7
	protected override bool OnChangeMode()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x0600C74F RID: 51023 RVA: 0x002D63C0 File Offset: 0x002D45C0
	private void ClearAll()
	{
		this.Config = null;
	}

	// Token: 0x17001058 RID: 4184
	// (get) Token: 0x0600C750 RID: 51024 RVA: 0x002D63C9 File Offset: 0x002D45C9
	public static DangoGlobalModel Instance
	{
		get
		{
			return DangoGlobalModel._Instance;
		}
	}

	// Token: 0x0600C751 RID: 51025 RVA: 0x002D63D0 File Offset: 0x002D45D0
	public static DangoGlobalModel GetOrCreateInstance()
	{
		if (DangoGlobalModel._Instance == null)
		{
			DangoGlobalModel.CreateInstance();
		}
		return DangoGlobalModel._Instance;
	}

	// Token: 0x0600C752 RID: 51026 RVA: 0x002D63E4 File Offset: 0x002D45E4
	public static bool CreateInstance()
	{
		if (DangoGlobalModel._Instance != null)
		{
			return true;
		}
		DangoGlobalModel._Instance = new DangoGlobalModel();
		return true;
	}

	// Token: 0x0600C753 RID: 51027 RVA: 0x002D63FA File Offset: 0x002D45FA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C754 RID: 51028 RVA: 0x002D63FC File Offset: 0x002D45FC
	public static void ResetStaticDefaultValue()
	{
		DangoGlobalModel._Instance = null;
	}

	// Token: 0x0600C755 RID: 51029 RVA: 0x002D6404 File Offset: 0x002D4604
	static DangoGlobalModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoGlobalModel.CreateStaticDefaultValue), new Action(DangoGlobalModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005BE7 RID: 23527
	[Nullable(2)]
	public DangoGlobalConfig Config;

	// Token: 0x04005BE8 RID: 23528
	[Nullable(2)]
	private static DangoGlobalModel _Instance;
}
