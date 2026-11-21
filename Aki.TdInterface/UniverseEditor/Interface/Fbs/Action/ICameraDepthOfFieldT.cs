using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068EA RID: 26858
	public class ICameraDepthOfFieldT
	{
		// Token: 0x1700C568 RID: 50536
		// (get) Token: 0x0602DF9A RID: 188314 RVA: 0x00648AC2 File Offset: 0x00646CC2
		// (set) Token: 0x0602DF9B RID: 188315 RVA: 0x00648ACA File Offset: 0x00646CCA
		public float Fstop { get; set; }

		// Token: 0x1700C569 RID: 50537
		// (get) Token: 0x0602DF9C RID: 188316 RVA: 0x00648AD3 File Offset: 0x00646CD3
		// (set) Token: 0x0602DF9D RID: 188317 RVA: 0x00648ADB File Offset: 0x00646CDB
		public float Distance { get; set; }

		// Token: 0x1700C56A RID: 50538
		// (get) Token: 0x0602DF9E RID: 188318 RVA: 0x00648AE4 File Offset: 0x00646CE4
		// (set) Token: 0x0602DF9F RID: 188319 RVA: 0x00648AEC File Offset: 0x00646CEC
		public float BlurAmount { get; set; }

		// Token: 0x1700C56B RID: 50539
		// (get) Token: 0x0602DFA0 RID: 188320 RVA: 0x00648AF5 File Offset: 0x00646CF5
		// (set) Token: 0x0602DFA1 RID: 188321 RVA: 0x00648AFD File Offset: 0x00646CFD
		public float BlurRadius { get; set; }

		// Token: 0x1700C56C RID: 50540
		// (get) Token: 0x0602DFA2 RID: 188322 RVA: 0x00648B06 File Offset: 0x00646D06
		// (set) Token: 0x0602DFA3 RID: 188323 RVA: 0x00648B0E File Offset: 0x00646D0E
		public byte NullMask { get; set; }

		// Token: 0x0602DFA4 RID: 188324 RVA: 0x00648B17 File Offset: 0x00646D17
		public ICameraDepthOfFieldT()
		{
			this.Fstop = 0f;
			this.Distance = 0f;
			this.BlurAmount = 0f;
			this.BlurRadius = 0f;
			this.NullMask = 0;
		}
	}
}
