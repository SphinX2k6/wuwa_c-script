using System;

// Token: 0x02002910 RID: 10512
public class RedDotFunctionPhantom : RedDotBase
{
	// Token: 0x0601A80B RID: 108555 RVA: 0x0082DBD1 File Offset: 0x0082BDD1
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.RedDotFunctionPhantomCondition();
	}
}
