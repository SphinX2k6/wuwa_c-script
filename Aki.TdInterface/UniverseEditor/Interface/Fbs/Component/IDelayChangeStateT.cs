using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055E4 RID: 21988
	public class IDelayChangeStateT
	{
		// Token: 0x17009D6E RID: 40302
		// (get) Token: 0x06022FEF RID: 143343 RVA: 0x004D0C3D File Offset: 0x004CEE3D
		// (set) Token: 0x06022FF0 RID: 143344 RVA: 0x004D0C45 File Offset: 0x004CEE45
		public float Time { get; set; }

		// Token: 0x17009D6F RID: 40303
		// (get) Token: 0x06022FF1 RID: 143345 RVA: 0x004D0C4E File Offset: 0x004CEE4E
		// (set) Token: 0x06022FF2 RID: 143346 RVA: 0x004D0C56 File Offset: 0x004CEE56
		public string NewState { get; set; }

		// Token: 0x17009D70 RID: 40304
		// (get) Token: 0x06022FF3 RID: 143347 RVA: 0x004D0C5F File Offset: 0x004CEE5F
		// (set) Token: 0x06022FF4 RID: 143348 RVA: 0x004D0C67 File Offset: 0x004CEE67
		public IVarIntervalT DelayInterval { get; set; }

		// Token: 0x17009D71 RID: 40305
		// (get) Token: 0x06022FF5 RID: 143349 RVA: 0x004D0C70 File Offset: 0x004CEE70
		// (set) Token: 0x06022FF6 RID: 143350 RVA: 0x004D0C78 File Offset: 0x004CEE78
		public bool WaitActionGroupEnd { get; set; }

		// Token: 0x17009D72 RID: 40306
		// (get) Token: 0x06022FF7 RID: 143351 RVA: 0x004D0C81 File Offset: 0x004CEE81
		// (set) Token: 0x06022FF8 RID: 143352 RVA: 0x004D0C89 File Offset: 0x004CEE89
		public byte NullMask { get; set; }

		// Token: 0x06022FF9 RID: 143353 RVA: 0x004D0C92 File Offset: 0x004CEE92
		public IDelayChangeStateT()
		{
			this.Time = 0f;
			this.NewState = null;
			this.DelayInterval = null;
			this.WaitActionGroupEnd = false;
			this.NullMask = 0;
		}
	}
}
