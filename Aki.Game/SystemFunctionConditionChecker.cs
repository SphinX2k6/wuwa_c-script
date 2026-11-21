using System;
using System.Runtime.CompilerServices;

// Token: 0x02001FEA RID: 8170
public class SystemFunctionConditionChecker : ISkipConditionChecker
{
	// Token: 0x0601442D RID: 82989 RVA: 0x005E8295 File Offset: 0x005E6495
	[NullableContext(1)]
	public ISkipCondition<ESkipConditionType> Parse(int[] @params)
	{
		return new SystemFunctionConditionImpl
		{
			ConditionType = ESkipConditionType.SystemFunction,
			FunctionType = (EFunctionType)@params[0]
		};
	}

	// Token: 0x0601442E RID: 82990 RVA: 0x005E82AC File Offset: 0x005E64AC
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
