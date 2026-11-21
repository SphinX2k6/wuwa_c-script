using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001C13 RID: 7187
	public class IFlowActorIndexData_SetValue
	{
		// Token: 0x04005DFD RID: 24061
		public int Index;

		// Token: 0x04005DFE RID: 24062
		[Nullable(2)]
		public PosAndRot Offset;

		// Token: 0x04005DFF RID: 24063
		public bool? IsUseFixedPosition;
	}
}
