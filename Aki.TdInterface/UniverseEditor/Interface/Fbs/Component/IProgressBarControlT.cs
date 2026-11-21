using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005DA4 RID: 23972
	public class IProgressBarControlT
	{
		// Token: 0x1700B07A RID: 45178
		// (get) Token: 0x06027F01 RID: 163585 RVA: 0x00576572 File Offset: 0x00574772
		// (set) Token: 0x06027F02 RID: 163586 RVA: 0x0057657A File Offset: 0x0057477A
		public EProgressBarControlType Type { get; set; }

		// Token: 0x1700B07B RID: 45179
		// (get) Token: 0x06027F03 RID: 163587 RVA: 0x00576583 File Offset: 0x00574783
		// (set) Token: 0x06027F04 RID: 163588 RVA: 0x0057658B File Offset: 0x0057478B
		public int MaxValue { get; set; }

		// Token: 0x1700B07C RID: 45180
		// (get) Token: 0x06027F05 RID: 163589 RVA: 0x00576594 File Offset: 0x00574794
		// (set) Token: 0x06027F06 RID: 163590 RVA: 0x0057659C File Offset: 0x0057479C
		public int InitValue { get; set; }

		// Token: 0x1700B07D RID: 45181
		// (get) Token: 0x06027F07 RID: 163591 RVA: 0x005765A5 File Offset: 0x005747A5
		// (set) Token: 0x06027F08 RID: 163592 RVA: 0x005765AD File Offset: 0x005747AD
		public int ProgressPerformanceAttribute { get; set; }

		// Token: 0x1700B07E RID: 45182
		// (get) Token: 0x06027F09 RID: 163593 RVA: 0x005765B6 File Offset: 0x005747B6
		// (set) Token: 0x06027F0A RID: 163594 RVA: 0x005765BE File Offset: 0x005747BE
		public byte NullMask { get; set; }

		// Token: 0x06027F0B RID: 163595 RVA: 0x005765C7 File Offset: 0x005747C7
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
