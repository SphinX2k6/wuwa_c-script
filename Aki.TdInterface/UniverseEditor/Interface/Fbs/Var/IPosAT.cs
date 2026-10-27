using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003AB2 RID: 15026
	public class IPosAT
	{
		// Token: 0x1700670A RID: 26378
		// (get) Token: 0x060146C2 RID: 83650 RVA: 0x002FA206 File Offset: 0x002F8406
		// (set) Token: 0x060146C3 RID: 83651 RVA: 0x002FA20E File Offset: 0x002F840E
		public float X { get; set; }

		// Token: 0x1700670B RID: 26379
		// (get) Token: 0x060146C4 RID: 83652 RVA: 0x002FA217 File Offset: 0x002F8417
		// (set) Token: 0x060146C5 RID: 83653 RVA: 0x002FA21F File Offset: 0x002F841F
		public float Y { get; set; }

		// Token: 0x1700670C RID: 26380
		// (get) Token: 0x060146C6 RID: 83654 RVA: 0x002FA228 File Offset: 0x002F8428
		// (set) Token: 0x060146C7 RID: 83655 RVA: 0x002FA230 File Offset: 0x002F8430
		public float Z { get; set; }

		// Token: 0x1700670D RID: 26381
		// (get) Token: 0x060146C8 RID: 83656 RVA: 0x002FA239 File Offset: 0x002F8439
		// (set) Token: 0x060146C9 RID: 83657 RVA: 0x002FA241 File Offset: 0x002F8441
		public float A { get; set; }

		// Token: 0x1700670E RID: 26382
		// (get) Token: 0x060146CA RID: 83658 RVA: 0x002FA24A File Offset: 0x002F844A
		// (set) Token: 0x060146CB RID: 83659 RVA: 0x002FA252 File Offset: 0x002F8452
		public byte NullMask { get; set; }

		// Token: 0x060146CC RID: 83660 RVA: 0x002FA25B File Offset: 0x002F845B
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
