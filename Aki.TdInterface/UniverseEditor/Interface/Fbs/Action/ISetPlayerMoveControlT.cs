using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007819 RID: 30745
	public class ISetPlayerMoveControlT
	{
		// Token: 0x1700E16E RID: 57710
		// (get) Token: 0x060360A6 RID: 221350 RVA: 0x0073D278 File Offset: 0x0073B478
		// (set) Token: 0x060360A7 RID: 221351 RVA: 0x0073D280 File Offset: 0x0073B480
		public int Left { get; set; }

		// Token: 0x1700E16F RID: 57711
		// (get) Token: 0x060360A8 RID: 221352 RVA: 0x0073D289 File Offset: 0x0073B489
		// (set) Token: 0x060360A9 RID: 221353 RVA: 0x0073D291 File Offset: 0x0073B491
		public int Right { get; set; }

		// Token: 0x1700E170 RID: 57712
		// (get) Token: 0x060360AA RID: 221354 RVA: 0x0073D29A File Offset: 0x0073B49A
		// (set) Token: 0x060360AB RID: 221355 RVA: 0x0073D2A2 File Offset: 0x0073B4A2
		public int Forward { get; set; }

		// Token: 0x1700E171 RID: 57713
		// (get) Token: 0x060360AC RID: 221356 RVA: 0x0073D2AB File Offset: 0x0073B4AB
		// (set) Token: 0x060360AD RID: 221357 RVA: 0x0073D2B3 File Offset: 0x0073B4B3
		public int Back { get; set; }

		// Token: 0x060360AE RID: 221358 RVA: 0x0073D2BC File Offset: 0x0073B4BC
		public ISetPlayerMoveControlT()
		{
			this.Left = 0;
			this.Right = 0;
			this.Forward = 0;
			this.Back = 0;
		}
	}
}
