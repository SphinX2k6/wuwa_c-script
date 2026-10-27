using System;
using System.Runtime.CompilerServices;

// Token: 0x020010CF RID: 4303
[NullableContext(1)]
[Nullable(0)]
[Model(0)]
public class AdvanceNoticeModel : ModelBase
{
	// Token: 0x17000982 RID: 2434
	// (get) Token: 0x06007015 RID: 28693 RVA: 0x0016D081 File Offset: 0x0016B281
	public static AdvanceNoticeModel Instance
	{
		get
		{
			return AdvanceNoticeModel._Instance;
		}
	}

	// Token: 0x06007016 RID: 28694 RVA: 0x0016D088 File Offset: 0x0016B288
	public static AdvanceNoticeModel GetOrCreateInstance()
	{
		if (AdvanceNoticeModel._Instance == null)
		{
			AdvanceNoticeModel.CreateInstance();
		}
		return AdvanceNoticeModel._Instance;
	}

	// Token: 0x06007017 RID: 28695 RVA: 0x0016D09C File Offset: 0x0016B29C
	public static bool CreateInstance()
	{
		if (AdvanceNoticeModel._Instance != null)
		{
			return true;
		}
		AdvanceNoticeModel._Instance = new AdvanceNoticeModel();
		return true;
	}

	// Token: 0x06007018 RID: 28696 RVA: 0x0016D0B2 File Offset: 0x0016B2B2
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06007019 RID: 28697 RVA: 0x0016D0B4 File Offset: 0x0016B2B4
	public static void ResetStaticDefaultValue()
	{
		AdvanceNoticeModel._Instance = null;
	}

	// Token: 0x0600701A RID: 28698 RVA: 0x0016D0BC File Offset: 0x0016B2BC
	static AdvanceNoticeModel()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(AdvanceNoticeModel.CreateStaticDefaultValue), new Action(AdvanceNoticeModel.ResetStaticDefaultValue));
	}

	// Token: 0x0400340C RID: 13324
	[Nullable(2)]
	private static AdvanceNoticeModel _Instance;
}
