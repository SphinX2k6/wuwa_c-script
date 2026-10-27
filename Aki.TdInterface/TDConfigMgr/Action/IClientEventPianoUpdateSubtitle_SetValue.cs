using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020018AF RID: 6319
	public class IClientEventPianoUpdateSubtitle_SetValue
	{
		// Token: 0x04005554 RID: 21844
		public EClientEventPianoEventType Type;

		// Token: 0x04005555 RID: 21845
		[Nullable(1)]
		public PlayFlow Flow;

		// Token: 0x04005556 RID: 21846
		public bool DisableMove;
	}
}
