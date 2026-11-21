using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005386 RID: 21382
	public class IAiAlertSystemConfigT
	{
		// Token: 0x1700970E RID: 38670
		// (get) Token: 0x06021537 RID: 136503 RVA: 0x004990C6 File Offset: 0x004972C6
		// (set) Token: 0x06021538 RID: 136504 RVA: 0x004990CE File Offset: 0x004972CE
		public int AreaId { get; set; }

		// Token: 0x1700970F RID: 38671
		// (get) Token: 0x06021539 RID: 136505 RVA: 0x004990D7 File Offset: 0x004972D7
		// (set) Token: 0x0602153A RID: 136506 RVA: 0x004990DF File Offset: 0x004972DF
		public float PlayerHatredDeltaValue { get; set; }

		// Token: 0x17009710 RID: 38672
		// (get) Token: 0x0602153B RID: 136507 RVA: 0x004990E8 File Offset: 0x004972E8
		// (set) Token: 0x0602153C RID: 136508 RVA: 0x004990F0 File Offset: 0x004972F0
		public byte NullMask { get; set; }

		// Token: 0x0602153D RID: 136509 RVA: 0x004990F9 File Offset: 0x004972F9
		public IAiAlertSystemConfigT()
		{
			this.AreaId = 0;
			this.PlayerHatredDeltaValue = 0f;
			this.NullMask = 0;
		}
	}
}
