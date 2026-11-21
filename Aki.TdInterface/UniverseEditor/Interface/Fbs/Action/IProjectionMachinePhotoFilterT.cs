using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007535 RID: 30005
	public class IProjectionMachinePhotoFilterT
	{
		// Token: 0x1700DCC3 RID: 56515
		// (get) Token: 0x060349ED RID: 215533 RVA: 0x00714A70 File Offset: 0x00712C70
		// (set) Token: 0x060349EE RID: 215534 RVA: 0x00714A78 File Offset: 0x00712C78
		public float DefaultParam1 { get; set; }

		// Token: 0x1700DCC4 RID: 56516
		// (get) Token: 0x060349EF RID: 215535 RVA: 0x00714A81 File Offset: 0x00712C81
		// (set) Token: 0x060349F0 RID: 215536 RVA: 0x00714A89 File Offset: 0x00712C89
		public float DefaultParam2 { get; set; }

		// Token: 0x1700DCC5 RID: 56517
		// (get) Token: 0x060349F1 RID: 215537 RVA: 0x00714A92 File Offset: 0x00712C92
		// (set) Token: 0x060349F2 RID: 215538 RVA: 0x00714A9A File Offset: 0x00712C9A
		public float TargetParam1 { get; set; }

		// Token: 0x1700DCC6 RID: 56518
		// (get) Token: 0x060349F3 RID: 215539 RVA: 0x00714AA3 File Offset: 0x00712CA3
		// (set) Token: 0x060349F4 RID: 215540 RVA: 0x00714AAB File Offset: 0x00712CAB
		public float TargetParam2 { get; set; }

		// Token: 0x060349F5 RID: 215541 RVA: 0x00714AB4 File Offset: 0x00712CB4
		public IProjectionMachinePhotoFilterT()
		{
			this.DefaultParam1 = 0f;
			this.DefaultParam2 = 0f;
			this.TargetParam1 = 0f;
			this.TargetParam2 = 0f;
		}
	}
}
