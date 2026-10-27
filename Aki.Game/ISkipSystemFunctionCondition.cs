using System;

// Token: 0x02002A6B RID: 10859
public interface ISkipSystemFunctionCondition : ISkipCondition<ESkipConditionType>
{
	// Token: 0x17001E08 RID: 7688
	// (get) Token: 0x06016A00 RID: 92672
	// (set) Token: 0x06016A01 RID: 92673
	EFunctionType FunctionType { get; set; }
}
