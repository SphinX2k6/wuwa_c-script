using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579D RID: 22429
	public class IProgressBarControlT
	{
		// Token: 0x1700A756 RID: 42838
		// (get) Token: 0x060259E1 RID: 154081 RVA: 0x005303E6 File Offset: 0x0052E5E6
		// (set) Token: 0x060259E2 RID: 154082 RVA: 0x005303EE File Offset: 0x0052E5EE
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700A757 RID: 42839
		// (get) Token: 0x060259E3 RID: 154083 RVA: 0x005303F7 File Offset: 0x0052E5F7
		// (set) Token: 0x060259E4 RID: 154084 RVA: 0x005303FF File Offset: 0x0052E5FF
		public int MaxValue { get; set; }

		// Token: 0x1700A758 RID: 42840
		// (get) Token: 0x060259E5 RID: 154085 RVA: 0x00530408 File Offset: 0x0052E608
		// (set) Token: 0x060259E6 RID: 154086 RVA: 0x00530410 File Offset: 0x0052E610
		public int InitValue { get; set; }

		// Token: 0x1700A759 RID: 42841
		// (get) Token: 0x060259E7 RID: 154087 RVA: 0x00530419 File Offset: 0x0052E619
		// (set) Token: 0x060259E8 RID: 154088 RVA: 0x00530421 File Offset: 0x0052E621
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x1700A75A RID: 42842
		// (get) Token: 0x060259E9 RID: 154089 RVA: 0x0053042A File Offset: 0x0052E62A
		// (set) Token: 0x060259EA RID: 154090 RVA: 0x00530432 File Offset: 0x0052E632
		public byte NullMask { get; set; }

		// Token: 0x060259EB RID: 154091 RVA: 0x0053043B File Offset: 0x0052E63B
		public IProgressBarControlT()
		{
			this.Type = EProgressBarControlType.CaptureStrategicPoint;
			this.MaxValue = 0;
			this.InitValue = 0;
			this.ProgressPerformanceAttribute = 0;
			this.NullMask = 0;
		}
	}
}
