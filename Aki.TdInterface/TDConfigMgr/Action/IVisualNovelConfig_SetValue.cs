using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B1 RID: 8881
	public class IVisualNovelConfig_SetValue
	{
		// Token: 0x0400738A RID: 29578
		public EVisualNovelSubType? VisualNovelSubType;

		// Token: 0x0400738B RID: 29579
		public bool? EnableReadRecord;

		// Token: 0x0400738C RID: 29580
		public bool? EnableFastForward;

		// Token: 0x0400738D RID: 29581
		public bool? HideControlUi;

		// Token: 0x0400738E RID: 29582
		public int? InitialBackgroundId;

		// Token: 0x0400738F RID: 29583
		[Nullable(new byte[]
		{
			2,
			0
		})]
		public List<string> InitialAudioEvents;

		// Token: 0x04007390 RID: 29584
		[Nullable(2)]
		public ISolarSchoolTime InitialTime;

		// Token: 0x04007391 RID: 29585
		public float? EndFadeOutTime;
	}
}
