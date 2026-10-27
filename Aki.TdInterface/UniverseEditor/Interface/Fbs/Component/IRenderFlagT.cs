using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005842 RID: 22594
	public class IRenderFlagT
	{
		// Token: 0x1700A8CC RID: 43212
		// (get) Token: 0x0602602B RID: 155691 RVA: 0x0053D600 File Offset: 0x0053B800
		// (set) Token: 0x0602602C RID: 155692 RVA: 0x0053D608 File Offset: 0x0053B808
		public ERenderFlagType Type { get; set; }

		// Token: 0x1700A8CD RID: 43213
		// (get) Token: 0x0602602D RID: 155693 RVA: 0x0053D611 File Offset: 0x0053B811
		// (set) Token: 0x0602602E RID: 155694 RVA: 0x0053D619 File Offset: 0x0053B819
		public bool Enable { get; set; }

		// Token: 0x0602602F RID: 155695 RVA: 0x0053D622 File Offset: 0x0053B822
		public IRenderFlagT()
		{
			this.Type = ERenderFlagType.Fog;
			this.Enable = false;
		}
	}
}
