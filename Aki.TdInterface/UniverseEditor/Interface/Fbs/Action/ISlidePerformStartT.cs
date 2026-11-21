using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200790F RID: 30991
	public class ISlidePerformStartT
	{
		// Token: 0x1700E357 RID: 58199
		// (get) Token: 0x0603691E RID: 223518 RVA: 0x0074DD2D File Offset: 0x0074BF2D
		// (set) Token: 0x0603691F RID: 223519 RVA: 0x0074DD35 File Offset: 0x0074BF35
		public TCommonTargetUnion SlideTarget { get; set; }

		// Token: 0x1700E358 RID: 58200
		// (get) Token: 0x06036920 RID: 223520 RVA: 0x0074DD3E File Offset: 0x0074BF3E
		// (set) Token: 0x06036921 RID: 223521 RVA: 0x0074DD46 File Offset: 0x0074BF46
		public int SlideEntityId { get; set; }

		// Token: 0x1700E359 RID: 58201
		// (get) Token: 0x06036922 RID: 223522 RVA: 0x0074DD4F File Offset: 0x0074BF4F
		// (set) Token: 0x06036923 RID: 223523 RVA: 0x0074DD57 File Offset: 0x0074BF57
		public ISlopeSlidePerformStartT SlidePerformConfig { get; set; }

		// Token: 0x06036924 RID: 223524 RVA: 0x0074DD60 File Offset: 0x0074BF60
		public ISlidePerformStartT()
		{
			this.SlideTarget = null;
			this.SlideEntityId = 0;
			this.SlidePerformConfig = null;
		}
	}
}
