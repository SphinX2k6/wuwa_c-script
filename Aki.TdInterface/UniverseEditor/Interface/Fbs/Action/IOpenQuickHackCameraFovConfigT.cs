using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C25 RID: 27685
	public class IOpenQuickHackCameraFovConfigT
	{
		// Token: 0x1700CDE9 RID: 52713
		// (get) Token: 0x06030B11 RID: 199441 RVA: 0x0069C23E File Offset: 0x0069A43E
		// (set) Token: 0x06030B12 RID: 199442 RVA: 0x0069C246 File Offset: 0x0069A446
		public int DefaultValue { get; set; }

		// Token: 0x1700CDEA RID: 52714
		// (get) Token: 0x06030B13 RID: 199443 RVA: 0x0069C24F File Offset: 0x0069A44F
		// (set) Token: 0x06030B14 RID: 199444 RVA: 0x0069C257 File Offset: 0x0069A457
		public int Min { get; set; }

		// Token: 0x1700CDEB RID: 52715
		// (get) Token: 0x06030B15 RID: 199445 RVA: 0x0069C260 File Offset: 0x0069A460
		// (set) Token: 0x06030B16 RID: 199446 RVA: 0x0069C268 File Offset: 0x0069A468
		public int Max { get; set; }

		// Token: 0x06030B17 RID: 199447 RVA: 0x0069C271 File Offset: 0x0069A471
		public IOpenQuickHackCameraFovConfigT()
		{
			this.DefaultValue = 0;
			this.Min = 0;
			this.Max = 0;
		}
	}
}
