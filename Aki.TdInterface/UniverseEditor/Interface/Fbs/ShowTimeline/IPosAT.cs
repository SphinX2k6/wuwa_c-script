using System;

namespace Aki.UniverseEditor.Interface.Fbs.ShowTimeline
{
	// Token: 0x02003B99 RID: 15257
	public class IPosAT
	{
		// Token: 0x1700688F RID: 26767
		// (get) Token: 0x06014E6C RID: 85612 RVA: 0x003085CE File Offset: 0x003067CE
		// (set) Token: 0x06014E6D RID: 85613 RVA: 0x003085D6 File Offset: 0x003067D6
		public float X { get; set; }

		// Token: 0x17006890 RID: 26768
		// (get) Token: 0x06014E6E RID: 85614 RVA: 0x003085DF File Offset: 0x003067DF
		// (set) Token: 0x06014E6F RID: 85615 RVA: 0x003085E7 File Offset: 0x003067E7
		public float Y { get; set; }

		// Token: 0x17006891 RID: 26769
		// (get) Token: 0x06014E70 RID: 85616 RVA: 0x003085F0 File Offset: 0x003067F0
		// (set) Token: 0x06014E71 RID: 85617 RVA: 0x003085F8 File Offset: 0x003067F8
		public float Z { get; set; }

		// Token: 0x17006892 RID: 26770
		// (get) Token: 0x06014E72 RID: 85618 RVA: 0x00308601 File Offset: 0x00306801
		// (set) Token: 0x06014E73 RID: 85619 RVA: 0x00308609 File Offset: 0x00306809
		public float A { get; set; }

		// Token: 0x17006893 RID: 26771
		// (get) Token: 0x06014E74 RID: 85620 RVA: 0x00308612 File Offset: 0x00306812
		// (set) Token: 0x06014E75 RID: 85621 RVA: 0x0030861A File Offset: 0x0030681A
		public byte NullMask { get; set; }

		// Token: 0x06014E76 RID: 85622 RVA: 0x00308623 File Offset: 0x00306823
		public IPosAT()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
			this.A = 0f;
			this.NullMask = 0;
		}
	}
}
