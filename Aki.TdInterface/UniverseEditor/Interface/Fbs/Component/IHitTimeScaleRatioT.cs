using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053A8 RID: 21416
	public class IHitTimeScaleRatioT
	{
		// Token: 0x17009D57 RID: 40279
		// (get) Token: 0x06023148 RID: 143688 RVA: 0x004DB3BC File Offset: 0x004D95BC
		// (set) Token: 0x06023149 RID: 143689 RVA: 0x004DB3C4 File Offset: 0x004D95C4
		public float TimeRatio { get; set; }

		// Token: 0x17009D58 RID: 40280
		// (get) Token: 0x0602314A RID: 143690 RVA: 0x004DB3CD File Offset: 0x004D95CD
		// (set) Token: 0x0602314B RID: 143691 RVA: 0x004DB3D5 File Offset: 0x004D95D5
		public float MaxExtraTime { get; set; }

		// Token: 0x17009D59 RID: 40281
		// (get) Token: 0x0602314C RID: 143692 RVA: 0x004DB3DE File Offset: 0x004D95DE
		// (set) Token: 0x0602314D RID: 143693 RVA: 0x004DB3E6 File Offset: 0x004D95E6
		public float ValueRatio { get; set; }

		// Token: 0x17009D5A RID: 40282
		// (get) Token: 0x0602314E RID: 143694 RVA: 0x004DB3EF File Offset: 0x004D95EF
		// (set) Token: 0x0602314F RID: 143695 RVA: 0x004DB3F7 File Offset: 0x004D95F7
		public byte NullMask { get; set; }

		// Token: 0x06023150 RID: 143696 RVA: 0x004DB400 File Offset: 0x004D9600
		public IHitTimeScaleRatioT()
		{
			this.TimeRatio = 0f;
			this.MaxExtraTime = 0f;
			this.ValueRatio = 0f;
			this.NullMask = 0;
		}
	}
}
