using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020043AA RID: 17322
	public class IOutOfRangeTrackTargetT
	{
		// Token: 0x170076DD RID: 30429
		// (get) Token: 0x06018802 RID: 100354 RVA: 0x0037D940 File Offset: 0x0037BB40
		// (set) Token: 0x06018803 RID: 100355 RVA: 0x0037D948 File Offset: 0x0037BB48
		public IVectorInfoT TrackPos { get; set; }

		// Token: 0x170076DE RID: 30430
		// (get) Token: 0x06018804 RID: 100356 RVA: 0x0037D951 File Offset: 0x0037BB51
		// (set) Token: 0x06018805 RID: 100357 RVA: 0x0037D959 File Offset: 0x0037BB59
		public IVectorInfoT Center { get; set; }

		// Token: 0x170076DF RID: 30431
		// (get) Token: 0x06018806 RID: 100358 RVA: 0x0037D962 File Offset: 0x0037BB62
		// (set) Token: 0x06018807 RID: 100359 RVA: 0x0037D96A File Offset: 0x0037BB6A
		public int Radius { get; set; }

		// Token: 0x170076E0 RID: 30432
		// (get) Token: 0x06018808 RID: 100360 RVA: 0x0037D973 File Offset: 0x0037BB73
		// (set) Token: 0x06018809 RID: 100361 RVA: 0x0037D97B File Offset: 0x0037BB7B
		public bool OverrideChildNodeTrackTarget { get; set; }

		// Token: 0x170076E1 RID: 30433
		// (get) Token: 0x0601880A RID: 100362 RVA: 0x0037D984 File Offset: 0x0037BB84
		// (set) Token: 0x0601880B RID: 100363 RVA: 0x0037D98C File Offset: 0x0037BB8C
		public byte NullMask { get; set; }

		// Token: 0x0601880C RID: 100364 RVA: 0x0037D995 File Offset: 0x0037BB95
		public IOutOfRangeTrackTargetT()
		{
			this.TrackPos = null;
			this.Center = null;
			this.Radius = 0;
			this.OverrideChildNodeTrackTarget = false;
			this.NullMask = 0;
		}
	}
}
