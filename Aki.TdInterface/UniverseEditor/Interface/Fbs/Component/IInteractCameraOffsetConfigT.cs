using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200543E RID: 21566
	public class IInteractCameraOffsetConfigT
	{
		// Token: 0x17009E9B RID: 40603
		// (get) Token: 0x060236E9 RID: 145129 RVA: 0x004E6C1A File Offset: 0x004E4E1A
		// (set) Token: 0x060236EA RID: 145130 RVA: 0x004E6C22 File Offset: 0x004E4E22
		public int CenterOffsetPercent { get; set; }

		// Token: 0x17009E9C RID: 40604
		// (get) Token: 0x060236EB RID: 145131 RVA: 0x004E6C2B File Offset: 0x004E4E2B
		// (set) Token: 0x060236EC RID: 145132 RVA: 0x004E6C33 File Offset: 0x004E4E33
		public float OffsetZ { get; set; }

		// Token: 0x17009E9D RID: 40605
		// (get) Token: 0x060236ED RID: 145133 RVA: 0x004E6C3C File Offset: 0x004E4E3C
		// (set) Token: 0x060236EE RID: 145134 RVA: 0x004E6C44 File Offset: 0x004E4E44
		public byte NullMask { get; set; }

		// Token: 0x060236EF RID: 145135 RVA: 0x004E6C4D File Offset: 0x004E4E4D
		public IInteractCameraOffsetConfigT()
		{
			this.CenterOffsetPercent = 0;
			this.OffsetZ = 0f;
			this.NullMask = 0;
		}
	}
}
