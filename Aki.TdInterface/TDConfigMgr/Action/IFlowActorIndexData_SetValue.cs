using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001A7E RID: 6782
	public class IFlowActorIndexData_SetValue
	{
		// Token: 0x04005998 RID: 22936
		public int Index;

		// Token: 0x04005999 RID: 22937
		[Nullable(2)]
		public PosAndRot Offset;

		// Token: 0x0400599A RID: 22938
		public bool? IsUseFixedPosition;
	}
}
