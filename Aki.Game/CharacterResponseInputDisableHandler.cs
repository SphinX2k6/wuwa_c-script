using System;
using System.Runtime.CompilerServices;

// Token: 0x020030B8 RID: 12472
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class CharacterResponseInputDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x0601AB71 RID: 109425 RVA: 0x007325E9 File Offset: 0x007307E9
	protected override bool ShouldStop(InputFunctionContext context)
	{
		return !InputFunctionCommon.CanCharacterResponseInput();
	}
}
