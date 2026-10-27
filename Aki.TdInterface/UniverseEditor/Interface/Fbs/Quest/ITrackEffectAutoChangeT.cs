using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041F4 RID: 16884
	public class ITrackEffectAutoChangeT
	{
		// Token: 0x170077D8 RID: 30680
		// (get) Token: 0x06018E94 RID: 102036 RVA: 0x00395AE2 File Offset: 0x00393CE2
		// (set) Token: 0x06018E95 RID: 102037 RVA: 0x00395AEA File Offset: 0x00393CEA
		public ETrackEffectType Type { get; set; }

		// Token: 0x170077D9 RID: 30681
		// (get) Token: 0x06018E96 RID: 102038 RVA: 0x00395AF3 File Offset: 0x00393CF3
		// (set) Token: 0x06018E97 RID: 102039 RVA: 0x00395AFB File Offset: 0x00393CFB
		public int EnterRange { get; set; }

		// Token: 0x170077DA RID: 30682
		// (get) Token: 0x06018E98 RID: 102040 RVA: 0x00395B04 File Offset: 0x00393D04
		// (set) Token: 0x06018E99 RID: 102041 RVA: 0x00395B0C File Offset: 0x00393D0C
		public int LeaveRange { get; set; }

		// Token: 0x06018E9A RID: 102042 RVA: 0x00395B15 File Offset: 0x00393D15
		public ITrackEffectAutoChangeT()
		{
			this.Type = ETrackEffectType.AutoChange;
			this.EnterRange = 0;
			this.LeaveRange = 0;
		}
	}
}
