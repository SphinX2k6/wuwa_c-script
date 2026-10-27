using System;
using System.Runtime.CompilerServices;

// Token: 0x020030BC RID: 12476
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class OnlineDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x0601AB7A RID: 109434 RVA: 0x007328A8 File Offset: 0x00730AA8
	protected override bool ShouldStop(InputFunctionContext context)
	{
		return context.SkillId == 800002 && GameModeModel.Instance.IsMulti;
	}
}
