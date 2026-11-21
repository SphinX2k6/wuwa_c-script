using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CD2 RID: 27858
	public class IEnableFuncConfigT
	{
		// Token: 0x1700CC57 RID: 52311
		// (get) Token: 0x06030050 RID: 196688 RVA: 0x00688CE8 File Offset: 0x00686EE8
		// (set) Token: 0x06030051 RID: 196689 RVA: 0x00688CF0 File Offset: 0x00686EF0
		public float DelayDuration { get; set; }

		// Token: 0x1700CC58 RID: 52312
		// (get) Token: 0x06030052 RID: 196690 RVA: 0x00688CF9 File Offset: 0x00686EF9
		// (set) Token: 0x06030053 RID: 196691 RVA: 0x00688D01 File Offset: 0x00686F01
		public bool IsEnableEsc { get; set; }

		// Token: 0x1700CC59 RID: 52313
		// (get) Token: 0x06030054 RID: 196692 RVA: 0x00688D0A File Offset: 0x00686F0A
		// (set) Token: 0x06030055 RID: 196693 RVA: 0x00688D12 File Offset: 0x00686F12
		public bool IsEnablePhoto { get; set; }

		// Token: 0x1700CC5A RID: 52314
		// (get) Token: 0x06030056 RID: 196694 RVA: 0x00688D1B File Offset: 0x00686F1B
		// (set) Token: 0x06030057 RID: 196695 RVA: 0x00688D23 File Offset: 0x00686F23
		public byte NullMask { get; set; }

		// Token: 0x06030058 RID: 196696 RVA: 0x00688D2C File Offset: 0x00686F2C
		public IEnableFuncConfigT()
		{
			this.DelayDuration = 0f;
			this.IsEnableEsc = false;
			this.IsEnablePhoto = false;
			this.NullMask = 0;
		}
	}
}
