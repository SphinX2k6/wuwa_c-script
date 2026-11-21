using System;
using System.Runtime.CompilerServices;

// Token: 0x02002614 RID: 9748
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OnlineDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x06018589 RID: 99721 RVA: 0x00758214 File Offset: 0x00756414
	protected override bool ShouldStop(InputFunctionContext context)
	{
		return context.SkillId == 800002 && GameModeModel.Instance.IsMulti;
	}
}
