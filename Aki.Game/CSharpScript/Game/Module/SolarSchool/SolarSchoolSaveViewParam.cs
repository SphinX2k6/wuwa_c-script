using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A53 RID: 23123
	[NullableContext(2)]
	[Nullable(0)]
	public sealed class SolarSchoolSaveViewParam
	{
		// Token: 0x17006C9C RID: 27804
		// (get) Token: 0x06038F9A RID: 233370 RVA: 0x00FF61DC File Offset: 0x00FF43DC
		public int ActivityId { get; }

		// Token: 0x17006C9D RID: 27805
		// (get) Token: 0x06038F9B RID: 233371 RVA: 0x00FF61E4 File Offset: 0x00FF43E4
		public ESolarSchoolSaveViewMode Mode { get; }

		// Token: 0x17006C9E RID: 27806
		// (get) Token: 0x06038F9C RID: 233372 RVA: 0x00FF61EC File Offset: 0x00FF43EC
		public bool ReturnToSettingOnClose { get; }

		// Token: 0x17006C9F RID: 27807
		// (get) Token: 0x06038F9D RID: 233373 RVA: 0x00FF61F4 File Offset: 0x00FF43F4
		public bool CloseAfterSaved { get; }

		// Token: 0x17006CA0 RID: 27808
		// (get) Token: 0x06038F9E RID: 233374 RVA: 0x00FF61FC File Offset: 0x00FF43FC
		public Action CloseCallback { get; }

		// Token: 0x06038F9F RID: 233375 RVA: 0x00FF6204 File Offset: 0x00FF4404
		public SolarSchoolSaveViewParam(int activityId, ESolarSchoolSaveViewMode mode, bool returnToSettingOnClose = false, bool closeAfterSaved = false, Action closeCallback = null)
		{
			this.ActivityId = activityId;
			this.Mode = mode;
			this.ReturnToSettingOnClose = returnToSettingOnClose;
			this.CloseAfterSaved = closeAfterSaved;
			this.CloseCallback = closeCallback;
		}
	}
}
