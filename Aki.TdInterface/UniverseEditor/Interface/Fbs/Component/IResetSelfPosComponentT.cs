using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E6F RID: 24175
	public class IResetSelfPosComponentT
	{
		// Token: 0x1700B258 RID: 45656
		// (get) Token: 0x0602870E RID: 165646 RVA: 0x00587A24 File Offset: 0x00585C24
		// (set) Token: 0x0602870F RID: 165647 RVA: 0x00587A2C File Offset: 0x00585C2C
		public bool Disabled { get; set; }

		// Token: 0x1700B259 RID: 45657
		// (get) Token: 0x06028710 RID: 165648 RVA: 0x00587A35 File Offset: 0x00585C35
		// (set) Token: 0x06028711 RID: 165649 RVA: 0x00587A3D File Offset: 0x00585C3D
		public float ResetRadius { get; set; }

		// Token: 0x1700B25A RID: 45658
		// (get) Token: 0x06028712 RID: 165650 RVA: 0x00587A46 File Offset: 0x00585C46
		// (set) Token: 0x06028713 RID: 165651 RVA: 0x00587A4E File Offset: 0x00585C4E
		public bool IsDisableResetPosAfterThrow { get; set; }

		// Token: 0x1700B25B RID: 45659
		// (get) Token: 0x06028714 RID: 165652 RVA: 0x00587A57 File Offset: 0x00585C57
		// (set) Token: 0x06028715 RID: 165653 RVA: 0x00587A5F File Offset: 0x00585C5F
		public bool IsResetPosAfterThrow { get; set; }

		// Token: 0x1700B25C RID: 45660
		// (get) Token: 0x06028716 RID: 165654 RVA: 0x00587A68 File Offset: 0x00585C68
		// (set) Token: 0x06028717 RID: 165655 RVA: 0x00587A70 File Offset: 0x00585C70
		public float ResetPosDelayTime { get; set; }

		// Token: 0x1700B25D RID: 45661
		// (get) Token: 0x06028718 RID: 165656 RVA: 0x00587A79 File Offset: 0x00585C79
		// (set) Token: 0x06028719 RID: 165657 RVA: 0x00587A81 File Offset: 0x00585C81
		public byte NullMask { get; set; }

		// Token: 0x0602871A RID: 165658 RVA: 0x00587A8A File Offset: 0x00585C8A
		public IResetSelfPosComponentT()
		{
			this.Disabled = false;
			this.ResetRadius = 0f;
			this.IsDisableResetPosAfterThrow = false;
			this.IsResetPosAfterThrow = false;
			this.ResetPosDelayTime = 0f;
			this.NullMask = 0;
		}
	}
}
