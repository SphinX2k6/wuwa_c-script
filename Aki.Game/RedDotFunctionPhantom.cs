using System;

// Token: 0x0200339E RID: 13214
public class RedDotFunctionPhantom : RedDotBase
{
	// Token: 0x0601CB13 RID: 117523 RVA: 0x0080760D File Offset: 0x0080580D
	protected override bool OnCheck(int uId = 0)
	{
		return FunctionModel.Instance.RedDotFunctionPhantomCondition();
	}
}
