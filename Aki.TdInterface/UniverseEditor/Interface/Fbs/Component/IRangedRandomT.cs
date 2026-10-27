using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005806 RID: 22534
	public class IRangedRandomT
	{
		// Token: 0x1700A856 RID: 43094
		// (get) Token: 0x06025E21 RID: 155169 RVA: 0x0053979C File Offset: 0x0053799C
		// (set) Token: 0x06025E22 RID: 155170 RVA: 0x005397A4 File Offset: 0x005379A4
		public float Left { get; set; }

		// Token: 0x1700A857 RID: 43095
		// (get) Token: 0x06025E23 RID: 155171 RVA: 0x005397AD File Offset: 0x005379AD
		// (set) Token: 0x06025E24 RID: 155172 RVA: 0x005397B5 File Offset: 0x005379B5
		public float Right { get; set; }

		// Token: 0x06025E25 RID: 155173 RVA: 0x005397BE File Offset: 0x005379BE
		public IRangedRandomT()
		{
			this.Left = 0f;
			this.Right = 0f;
		}
	}
}
