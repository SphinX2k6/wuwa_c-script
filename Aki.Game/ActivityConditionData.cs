using System;
using System.Runtime.CompilerServices;

// Token: 0x020010B9 RID: 4281
[NullableContext(1)]
[Nullable(0)]
public class ActivityConditionData : IActivityConditionData
{
	// Token: 0x17000960 RID: 2400
	// (get) Token: 0x06006F64 RID: 28516 RVA: 0x0016B80C File Offset: 0x00169A0C
	// (set) Token: 0x06006F65 RID: 28517 RVA: 0x0016B814 File Offset: 0x00169A14
	public int ConditionId { get; set; }

	// Token: 0x17000961 RID: 2401
	// (get) Token: 0x06006F66 RID: 28518 RVA: 0x0016B81D File Offset: 0x00169A1D
	// (set) Token: 0x06006F67 RID: 28519 RVA: 0x0016B825 File Offset: 0x00169A25
	public string ConditionTextId { get; set; }

	// Token: 0x17000962 RID: 2402
	// (get) Token: 0x06006F68 RID: 28520 RVA: 0x0016B82E File Offset: 0x00169A2E
	// (set) Token: 0x06006F69 RID: 28521 RVA: 0x0016B836 File Offset: 0x00169A36
	public bool IsFinished { get; set; }

	// Token: 0x17000963 RID: 2403
	// (get) Token: 0x06006F6A RID: 28522 RVA: 0x0016B83F File Offset: 0x00169A3F
	// (set) Token: 0x06006F6B RID: 28523 RVA: 0x0016B847 File Offset: 0x00169A47
	public int AccessId { get; set; }

	// Token: 0x17000964 RID: 2404
	// (get) Token: 0x06006F6C RID: 28524 RVA: 0x0016B850 File Offset: 0x00169A50
	// (set) Token: 0x06006F6D RID: 28525 RVA: 0x0016B858 File Offset: 0x00169A58
	public int AccessType { get; set; }

	// Token: 0x17000965 RID: 2405
	// (get) Token: 0x06006F6E RID: 28526 RVA: 0x0016B861 File Offset: 0x00169A61
	// (set) Token: 0x06006F6F RID: 28527 RVA: 0x0016B869 File Offset: 0x00169A69
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public object[] TextParam { [return: Nullable(new byte[]
	{
		2,
		1
	})] get; [param: Nullable(new byte[]
	{
		2,
		1
	})] set; }

	// Token: 0x17000966 RID: 2406
	// (get) Token: 0x06006F70 RID: 28528 RVA: 0x0016B872 File Offset: 0x00169A72
	// (set) Token: 0x06006F71 RID: 28529 RVA: 0x0016B87A File Offset: 0x00169A7A
	[Nullable(2)]
	public Action OnJump { [NullableContext(2)] get; [NullableContext(2)] set; }
}
