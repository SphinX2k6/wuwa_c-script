using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200203C RID: 8252
	[NullableContext(1)]
	[Nullable(0)]
	public class IVehicleEnterPathMove_SetValue
	{
		// Token: 0x04006D24 RID: 27940
		public EVehicleControlType Type;

		// Token: 0x04006D25 RID: 27941
		public IVehicleCruisingParams ControlParams;

		// Token: 0x04006D26 RID: 27942
		public ISplineMovePattern Pattern;
	}
}
