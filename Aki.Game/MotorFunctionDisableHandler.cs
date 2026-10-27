using System;
using System.Runtime.CompilerServices;

// Token: 0x020030B7 RID: 12471
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorFunctionDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x0601AB6F RID: 109423 RVA: 0x007325D1 File Offset: 0x007307D1
	protected override bool ShouldStop(InputFunctionContext context)
	{
		return !VehicleController.Instance.CheckMotorAllowed(true);
	}
}
