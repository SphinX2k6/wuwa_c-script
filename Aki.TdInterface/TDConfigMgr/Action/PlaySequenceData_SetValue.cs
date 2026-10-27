using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002120 RID: 8480
	public class PlaySequenceData_SetValue
	{
		// Token: 0x04006FC5 RID: 28613
		[Nullable(1)]
		public string Path;

		// Token: 0x04006FC6 RID: 28614
		public bool? ResetCamera;

		// Token: 0x04006FC7 RID: 28615
		public bool? KeepCamera;

		// Token: 0x04006FC8 RID: 28616
		public bool? PreLoadRenderAssets;

		// Token: 0x04006FC9 RID: 28617
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<ISequenceFrameEvent> FrameEvents;

		// Token: 0x04006FCA RID: 28618
		public bool? SaveFinalPos;

		// Token: 0x04006FCB RID: 28619
		[Nullable(2)]
		public SetBlendAnim SeqBlendAnim;
	}
}
