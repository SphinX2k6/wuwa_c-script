using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3E RID: 27966
	public class IEnterOrbitalCameraControlByMoveT
	{
		// Token: 0x1700CD2B RID: 52523
		// (get) Token: 0x060303DF RID: 197599 RVA: 0x0068EEA7 File Offset: 0x0068D0A7
		// (set) Token: 0x060303E0 RID: 197600 RVA: 0x0068EEAF File Offset: 0x0068D0AF
		public EEnterOrbitalCameraType Type { get; set; }

		// Token: 0x1700CD2C RID: 52524
		// (get) Token: 0x060303E1 RID: 197601 RVA: 0x0068EEB8 File Offset: 0x0068D0B8
		// (set) Token: 0x060303E2 RID: 197602 RVA: 0x0068EEC0 File Offset: 0x0068D0C0
		public string LevelSequence { get; set; }

		// Token: 0x1700CD2D RID: 52525
		// (get) Token: 0x060303E3 RID: 197603 RVA: 0x0068EEC9 File Offset: 0x0068D0C9
		// (set) Token: 0x060303E4 RID: 197604 RVA: 0x0068EED1 File Offset: 0x0068D0D1
		public float BlendInTime { get; set; }

		// Token: 0x1700CD2E RID: 52526
		// (get) Token: 0x060303E5 RID: 197605 RVA: 0x0068EEDA File Offset: 0x0068D0DA
		// (set) Token: 0x060303E6 RID: 197606 RVA: 0x0068EEE2 File Offset: 0x0068D0E2
		public float BlendOutTime { get; set; }

		// Token: 0x1700CD2F RID: 52527
		// (get) Token: 0x060303E7 RID: 197607 RVA: 0x0068EEEB File Offset: 0x0068D0EB
		// (set) Token: 0x060303E8 RID: 197608 RVA: 0x0068EEF3 File Offset: 0x0068D0F3
		public int BegEntity { get; set; }

		// Token: 0x1700CD30 RID: 52528
		// (get) Token: 0x060303E9 RID: 197609 RVA: 0x0068EEFC File Offset: 0x0068D0FC
		// (set) Token: 0x060303EA RID: 197610 RVA: 0x0068EF04 File Offset: 0x0068D104
		public int EndEntity { get; set; }

		// Token: 0x060303EB RID: 197611 RVA: 0x0068EF0D File Offset: 0x0068D10D
		public IEnterOrbitalCameraControlByMoveT()
		{
			this.Type = EEnterOrbitalCameraType.ControlByMove;
			this.LevelSequence = null;
			this.BlendInTime = 0f;
			this.BlendOutTime = 0f;
			this.BegEntity = 0;
			this.EndEntity = 0;
		}
	}
}
