using System;
using System.Runtime.CompilerServices;

// Token: 0x02002A6F RID: 10863
public class SystemFunctionConditionChecker : ISkipConditionChecker
{
	// Token: 0x06016A0C RID: 92684 RVA: 0x005BC10D File Offset: 0x005BA30D
	[NullableContext(1)]
	public ISkipCondition<ESkipConditionType> Parse(int[] @params)
	{
		return new SystemFunctionConditionImpl
		{
			ConditionType = ESkipConditionType.SystemFunction,
			FunctionType = (EFunctionType)@params[0]
		};
	}

	// Token: 0x06016A0D RID: 92685 RVA: 0x005BC124 File Offset: 0x005BA324
	[NullableContext(1)]
	public bool Check(int[] @params)
	{
		SystemFunctionConditionImpl systemFunctionConditionImpl = this.Parse(@params) as SystemFunctionConditionImpl;
		if (systemFunctionConditionImpl == null)
		{
			return false;
		}
		EFunctionType functionType = systemFunctionConditionImpl.FunctionType;
		return FunctionModel.Instance.IsOpen((int)functionType);
	}
}
