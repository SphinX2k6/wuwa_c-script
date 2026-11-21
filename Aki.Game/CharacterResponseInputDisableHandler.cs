using System;
using System.Runtime.CompilerServices;

// Token: 0x02002610 RID: 9744
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterResponseInputDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x06018580 RID: 99712 RVA: 0x00757F55 File Offset: 0x00756155
	protected override bool ShouldStop(InputFunctionContext context)
	{
		return !InputFunctionCommon.CanCharacterResponseInput();
	}
}
