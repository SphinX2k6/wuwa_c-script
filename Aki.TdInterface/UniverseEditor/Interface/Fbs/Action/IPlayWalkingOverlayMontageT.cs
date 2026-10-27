using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D48 RID: 27976
	public class IPlayWalkingOverlayMontageT
	{
		// Token: 0x1700D0A6 RID: 53414
		// (get) Token: 0x0603165B RID: 202331 RVA: 0x006B2F06 File Offset: 0x006B1106
		// (set) Token: 0x0603165C RID: 202332 RVA: 0x006B2F0E File Offset: 0x006B110E
		public int EntityId { get; set; }

		// Token: 0x1700D0A7 RID: 53415
		// (get) Token: 0x0603165D RID: 202333 RVA: 0x006B2F17 File Offset: 0x006B1117
		// (set) Token: 0x0603165E RID: 202334 RVA: 0x006B2F1F File Offset: 0x006B111F
		public int OverlapMontageId { get; set; }

		// Token: 0x1700D0A8 RID: 53416
		// (get) Token: 0x0603165F RID: 202335 RVA: 0x006B2F28 File Offset: 0x006B1128
		// (set) Token: 0x06031660 RID: 202336 RVA: 0x006B2F30 File Offset: 0x006B1130
		public float LoopDuration { get; set; }

		// Token: 0x1700D0A9 RID: 53417
		// (get) Token: 0x06031661 RID: 202337 RVA: 0x006B2F39 File Offset: 0x006B1139
		// (set) Token: 0x06031662 RID: 202338 RVA: 0x006B2F41 File Offset: 0x006B1141
		public int RepeatTimes { get; set; }

		// Token: 0x1700D0AA RID: 53418
		// (get) Token: 0x06031663 RID: 202339 RVA: 0x006B2F4A File Offset: 0x006B114A
		// (set) Token: 0x06031664 RID: 202340 RVA: 0x006B2F52 File Offset: 0x006B1152
		public byte NullMask { get; set; }

		// Token: 0x06031665 RID: 202341 RVA: 0x006B2F5B File Offset: 0x006B115B
		public IPlayWalkingOverlayMontageT()
		{
			this.EntityId = 0;
			this.OverlapMontageId = 0;
			this.LoopDuration = 0f;
			this.RepeatTimes = 0;
			this.NullMask = 0;
		}
	}
}
