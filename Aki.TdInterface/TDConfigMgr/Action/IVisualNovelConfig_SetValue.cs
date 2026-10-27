using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002068 RID: 8296
	[NullableContext(2)]
	[Nullable(0)]
	public class IVisualNovelConfig_SetValue
	{
		// Token: 0x04006D80 RID: 28032
		public EVisualNovelSubType? VisualNovelSubType;

		// Token: 0x04006D81 RID: 28033
		public bool? EnableReadRecord;

		// Token: 0x04006D82 RID: 28034
		public bool? HideControlUi;

		// Token: 0x04006D83 RID: 28035
		public int? InitialBackgroundId;

		// Token: 0x04006D84 RID: 28036
		public string InitialAudioEvent;

		// Token: 0x04006D85 RID: 28037
		public ISolarSchoolTime InitialTime;
	}
}
