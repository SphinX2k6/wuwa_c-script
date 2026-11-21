using System;
using System.Runtime.CompilerServices;

// Token: 0x02000F2F RID: 3887
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class DangoGlobalModel : ModelBase
{
	// Token: 0x06009B5C RID: 39772 RVA: 0x002E1495 File Offset: 0x002DF695
	protected override bool OnClear()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06009B5D RID: 39773 RVA: 0x002E149E File Offset: 0x002DF69E
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06009B5E RID: 39774 RVA: 0x002E14A7 File Offset: 0x002DF6A7
	protected override bool OnChangeMode()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06009B5F RID: 39775 RVA: 0x002E14B0 File Offset: 0x002DF6B0
	private void ClearAll()
	{
		this.Config = null;
	}

	// Token: 0x1700107D RID: 4221
	// (get) Token: 0x06009B60 RID: 39776 RVA: 0x002E14B9 File Offset: 0x002DF6B9
	public static DangoGlobalModel Instance
	{
		get
		{
			return DangoGlobalModel._Instance;
		}
	}

	// Token: 0x06009B61 RID: 39777 RVA: 0x002E14C0 File Offset: 0x002DF6C0
	public static DangoGlobalModel GetOrCreateInstance()
	{
		if (DangoGlobalModel._Instance == null)
		{
			DangoGlobalModel.CreateInstance();
		}
		return DangoGlobalModel._Instance;
	}

	// Token: 0x06009B62 RID: 39778 RVA: 0x002E14D4 File Offset: 0x002DF6D4
	public static bool CreateInstance()
	{
		if (DangoGlobalModel._Instance != null)
		{
			return true;
		}
		DangoGlobalModel._Instance = new DangoGlobalModel();
		return true;
	}

	// Token: 0x06009B63 RID: 39779 RVA: 0x002E14EA File Offset: 0x002DF6EA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06009B64 RID: 39780 RVA: 0x002E14EC File Offset: 0x002DF6EC
	public static void ResetStaticDefaultValue()
	{
		DangoGlobalModel._Instance = null;
	}

	// Token: 0x06009B65 RID: 39781 RVA: 0x002E14F4 File Offset: 0x002DF6F4
	static DangoGlobalModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DangoGlobalModel.CreateStaticDefaultValue), new Action(DangoGlobalModel.ResetStaticDefaultValue));
	}

	// Token: 0x04005CB6 RID: 23734
	[Nullable(2)]
	public DangoGlobalConfig Config;

	// Token: 0x04005CB7 RID: 23735
	[Nullable(2)]
	private static DangoGlobalModel _Instance;
}
