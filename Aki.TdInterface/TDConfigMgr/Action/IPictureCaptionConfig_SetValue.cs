using System;
using System.Runtime.CompilerServices;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001CF3 RID: 7411
	[NullableContext(2)]
	[Nullable(0)]
	public class IPictureCaptionConfig_SetValue
	{
		// Token: 0x0400600D RID: 24589
		[Nullable(1)]
		public string PictureCaption;

		// Token: 0x0400600E RID: 24590
		public string UiPrefabId;

		// Token: 0x0400600F RID: 24591
		public float Duration;

		// Token: 0x04006010 RID: 24592
		public IUiAnimConfig UiAnimConfig;
	}
}
