using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200526B RID: 21099
	public class IFixedDateTimeT
	{
		// Token: 0x17009A8A RID: 39562
		// (get) Token: 0x06022541 RID: 140609 RVA: 0x004C23BA File Offset: 0x004C05BA
		// (set) Token: 0x06022542 RID: 140610 RVA: 0x004C23C2 File Offset: 0x004C05C2
		public int Hours { get; set; }

		// Token: 0x17009A8B RID: 39563
		// (get) Token: 0x06022543 RID: 140611 RVA: 0x004C23CB File Offset: 0x004C05CB
		// (set) Token: 0x06022544 RID: 140612 RVA: 0x004C23D3 File Offset: 0x004C05D3
		public int Minutes { get; set; }

		// Token: 0x17009A8C RID: 39564
		// (get) Token: 0x06022545 RID: 140613 RVA: 0x004C23DC File Offset: 0x004C05DC
		// (set) Token: 0x06022546 RID: 140614 RVA: 0x004C23E4 File Offset: 0x004C05E4
		public int Seconds { get; set; }

		// Token: 0x06022547 RID: 140615 RVA: 0x004C23ED File Offset: 0x004C05ED
		public IFixedDateTimeT()
		{
			this.Hours = 0;
			this.Minutes = 0;
			this.Seconds = 0;
		}
	}
}
