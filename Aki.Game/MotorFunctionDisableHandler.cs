using System;
using System.Runtime.CompilerServices;

// Token: 0x0200260F RID: 9743
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MotorFunctionDisableHandler : DisableHandler<InputFunctionContext>
{
	// Token: 0x0601857E RID: 99710 RVA: 0x00757F3D File Offset: 0x0075613D
	protected override bool ShouldStop(InputFunctionContext context)
	{
		return !VehicleController.Instance.CheckMotorAllowed(true);
	}
}
