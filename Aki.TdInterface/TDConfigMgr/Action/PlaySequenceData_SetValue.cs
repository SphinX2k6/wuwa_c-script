using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002381 RID: 9089
	public class PlaySequenceData_SetValue
	{
		// Token: 0x040075FA RID: 30202
		public string Path;

		// Token: 0x040075FB RID: 30203
		public bool? ResetCamera;

		// Token: 0x040075FC RID: 30204
		public bool? KeepCamera;

		// Token: 0x040075FD RID: 30205
		public bool? PreLoadRenderAssets;

		// Token: 0x040075FE RID: 30206
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<ISequenceFrameEvent> FrameEvents;

		// Token: 0x040075FF RID: 30207
		public bool? SaveFinalPos;

		// Token: 0x04007600 RID: 30208
		[Nullable(2)]
		public SetBlendAnim SeqBlendAnim;
	}
}
