using System;
using System.Runtime.CompilerServices;

// Token: 0x02000583 RID: 1411
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AdvanceNoticeModel : ModelBase
{
	// Token: 0x170009A2 RID: 2466
	// (get) Token: 0x060043AB RID: 17323 RVA: 0x00175A3D File Offset: 0x00173C3D
	public static AdvanceNoticeModel Instance
	{
		get
		{
			return AdvanceNoticeModel._Instance;
		}
	}

	// Token: 0x060043AC RID: 17324 RVA: 0x00175A44 File Offset: 0x00173C44
	public static AdvanceNoticeModel GetOrCreateInstance()
	{
		if (AdvanceNoticeModel._Instance == null)
		{
			AdvanceNoticeModel.CreateInstance();
		}
		return AdvanceNoticeModel._Instance;
	}

	// Token: 0x060043AD RID: 17325 RVA: 0x00175A58 File Offset: 0x00173C58
	public static bool CreateInstance()
	{
		if (AdvanceNoticeModel._Instance != null)
		{
			return true;
		}
		AdvanceNoticeModel._Instance = new AdvanceNoticeModel();
		return true;
	}

	// Token: 0x060043AE RID: 17326 RVA: 0x00175A6E File Offset: 0x00173C6E
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060043AF RID: 17327 RVA: 0x00175A70 File Offset: 0x00173C70
	public static void ResetStaticDefaultValue()
	{
		AdvanceNoticeModel._Instance = null;
	}

	// Token: 0x060043B0 RID: 17328 RVA: 0x00175A78 File Offset: 0x00173C78
	static AdvanceNoticeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdvanceNoticeModel.CreateStaticDefaultValue), new Action(AdvanceNoticeModel.ResetStaticDefaultValue));
	}

	// Token: 0x040034A5 RID: 13477
	[Nullable(2)]
	private static AdvanceNoticeModel _Instance;
}
