using System;

// Token: 0x02002A70 RID: 10864
public class SystemFunctionConditionImpl : ISkipSystemFunctionCondition, ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E0D RID: 7693
	// (get) Token: 0x06016A0F RID: 92687 RVA: 0x005BC15D File Offset: 0x005BA35D
	// (set) Token: 0x06016A10 RID: 92688 RVA: 0x005BC165 File Offset: 0x005BA365
	public ESkipConditionType ConditionType { get; set; }

	// Token: 0x17001E0E RID: 7694
	// (get) Token: 0x06016A11 RID: 92689 RVA: 0x005BC16E File Offset: 0x005BA36E
	// (set) Token: 0x06016A12 RID: 92690 RVA: 0x005BC176 File Offset: 0x005BA376
	public EFunctionType FunctionType { get; set; }
}
