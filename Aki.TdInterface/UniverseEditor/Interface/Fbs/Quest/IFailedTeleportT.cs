using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004254 RID: 16980
	public class IFailedTeleportT
	{
		// Token: 0x170073C8 RID: 29640
		// (get) Token: 0x06017A46 RID: 96838 RVA: 0x0035F47D File Offset: 0x0035D67D
		// (set) Token: 0x06017A47 RID: 96839 RVA: 0x0035F485 File Offset: 0x0035D685
		public IPosAT Position { get; set; }

		// Token: 0x170073C9 RID: 29641
		// (get) Token: 0x06017A48 RID: 96840 RVA: 0x0035F48E File Offset: 0x0035D68E
		// (set) Token: 0x06017A49 RID: 96841 RVA: 0x0035F496 File Offset: 0x0035D696
		public int PositionEntityId { get; set; }

		// Token: 0x170073CA RID: 29642
		// (get) Token: 0x06017A4A RID: 96842 RVA: 0x0035F49F File Offset: 0x0035D69F
		// (set) Token: 0x06017A4B RID: 96843 RVA: 0x0035F4A7 File Offset: 0x0035D6A7
		public bool IsConfirm { get; set; }

		// Token: 0x170073CB RID: 29643
		// (get) Token: 0x06017A4C RID: 96844 RVA: 0x0035F4B0 File Offset: 0x0035D6B0
		// (set) Token: 0x06017A4D RID: 96845 RVA: 0x0035F4B8 File Offset: 0x0035D6B8
		public int ConfirmId { get; set; }

		// Token: 0x170073CC RID: 29644
		// (get) Token: 0x06017A4E RID: 96846 RVA: 0x0035F4C1 File Offset: 0x0035D6C1
		// (set) Token: 0x06017A4F RID: 96847 RVA: 0x0035F4C9 File Offset: 0x0035D6C9
		public TTeleportTransitionOptionUnion TransitionOption { get; set; }

		// Token: 0x170073CD RID: 29645
		// (get) Token: 0x06017A50 RID: 96848 RVA: 0x0035F4D2 File Offset: 0x0035D6D2
		// (set) Token: 0x06017A51 RID: 96849 RVA: 0x0035F4DA File Offset: 0x0035D6DA
		public bool GravityFlip { get; set; }

		// Token: 0x170073CE RID: 29646
		// (get) Token: 0x06017A52 RID: 96850 RVA: 0x0035F4E3 File Offset: 0x0035D6E3
		// (set) Token: 0x06017A53 RID: 96851 RVA: 0x0035F4EB File Offset: 0x0035D6EB
		public byte NullMask { get; set; }

		// Token: 0x06017A54 RID: 96852 RVA: 0x0035F4F4 File Offset: 0x0035D6F4
		public IFailedTeleportT()
		{
			this.Position = null;
			this.PositionEntityId = 0;
			this.IsConfirm = false;
			this.ConfirmId = 0;
			this.TransitionOption = null;
			this.GravityFlip = false;
			this.NullMask = 0;
		}
	}
}
