using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006291 RID: 25233
	public class ICameraOffsetInMovementDirectionT
	{
		// Token: 0x1700BC4E RID: 48206
		// (get) Token: 0x0602B971 RID: 178545 RVA: 0x00600587 File Offset: 0x005FE787
		// (set) Token: 0x0602B972 RID: 178546 RVA: 0x0060058F File Offset: 0x005FE78F
		public float MinInterpolationSpeed { get; set; }

		// Token: 0x1700BC4F RID: 48207
		// (get) Token: 0x0602B973 RID: 178547 RVA: 0x00600598 File Offset: 0x005FE798
		// (set) Token: 0x0602B974 RID: 178548 RVA: 0x006005A0 File Offset: 0x005FE7A0
		public float MaxInterpolationSpeed { get; set; }

		// Token: 0x1700BC50 RID: 48208
		// (get) Token: 0x0602B975 RID: 178549 RVA: 0x006005A9 File Offset: 0x005FE7A9
		// (set) Token: 0x0602B976 RID: 178550 RVA: 0x006005B1 File Offset: 0x005FE7B1
		public float OffsetDistance1 { get; set; }

		// Token: 0x1700BC51 RID: 48209
		// (get) Token: 0x0602B977 RID: 178551 RVA: 0x006005BA File Offset: 0x005FE7BA
		// (set) Token: 0x0602B978 RID: 178552 RVA: 0x006005C2 File Offset: 0x005FE7C2
		public float OffsetDistance2 { get; set; }

		// Token: 0x1700BC52 RID: 48210
		// (get) Token: 0x0602B979 RID: 178553 RVA: 0x006005CB File Offset: 0x005FE7CB
		// (set) Token: 0x0602B97A RID: 178554 RVA: 0x006005D3 File Offset: 0x005FE7D3
		public IBaseCurveT OffsetCurve { get; set; }

		// Token: 0x1700BC53 RID: 48211
		// (get) Token: 0x0602B97B RID: 178555 RVA: 0x006005DC File Offset: 0x005FE7DC
		// (set) Token: 0x0602B97C RID: 178556 RVA: 0x006005E4 File Offset: 0x005FE7E4
		public int CenteringWaitTime { get; set; }

		// Token: 0x1700BC54 RID: 48212
		// (get) Token: 0x0602B97D RID: 178557 RVA: 0x006005ED File Offset: 0x005FE7ED
		// (set) Token: 0x0602B97E RID: 178558 RVA: 0x006005F5 File Offset: 0x005FE7F5
		public int StartupWaitTime { get; set; }

		// Token: 0x1700BC55 RID: 48213
		// (get) Token: 0x0602B97F RID: 178559 RVA: 0x006005FE File Offset: 0x005FE7FE
		// (set) Token: 0x0602B980 RID: 178560 RVA: 0x00600606 File Offset: 0x005FE806
		public byte NullMask { get; set; }

		// Token: 0x0602B981 RID: 178561 RVA: 0x00600610 File Offset: 0x005FE810
		public ICameraOffsetInMovementDirectionT()
		{
			this.MinInterpolationSpeed = 0f;
			this.MaxInterpolationSpeed = 0f;
			this.OffsetDistance1 = 0f;
			this.OffsetDistance2 = 0f;
			this.OffsetCurve = null;
			this.CenteringWaitTime = 0;
			this.StartupWaitTime = 0;
			this.NullMask = 0;
		}
	}
}
