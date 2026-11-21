using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005F9D RID: 24477
	public class ISpringComponentT
	{
		// Token: 0x1700B547 RID: 46407
		// (get) Token: 0x060292BC RID: 168636 RVA: 0x0059F19B File Offset: 0x0059D39B
		// (set) Token: 0x060292BD RID: 168637 RVA: 0x0059F1A3 File Offset: 0x0059D3A3
		public bool Disabled { get; set; }

		// Token: 0x1700B548 RID: 46408
		// (get) Token: 0x060292BE RID: 168638 RVA: 0x0059F1AC File Offset: 0x0059D3AC
		// (set) Token: 0x060292BF RID: 168639 RVA: 0x0059F1B4 File Offset: 0x0059D3B4
		public bool IsNormalSpring { get; set; }

		// Token: 0x1700B549 RID: 46409
		// (get) Token: 0x060292C0 RID: 168640 RVA: 0x0059F1BD File Offset: 0x0059D3BD
		// (set) Token: 0x060292C1 RID: 168641 RVA: 0x0059F1C5 File Offset: 0x0059D3C5
		public bool IsHitNormalSpring { get; set; }

		// Token: 0x1700B54A RID: 46410
		// (get) Token: 0x060292C2 RID: 168642 RVA: 0x0059F1CE File Offset: 0x0059D3CE
		// (set) Token: 0x060292C3 RID: 168643 RVA: 0x0059F1D6 File Offset: 0x0059D3D6
		public ISettingSpringDirT SettingDir { get; set; }

		// Token: 0x1700B54B RID: 46411
		// (get) Token: 0x060292C4 RID: 168644 RVA: 0x0059F1DF File Offset: 0x0059D3DF
		// (set) Token: 0x060292C5 RID: 168645 RVA: 0x0059F1E7 File Offset: 0x0059D3E7
		public int SpringPow { get; set; }

		// Token: 0x1700B54C RID: 46412
		// (get) Token: 0x060292C6 RID: 168646 RVA: 0x0059F1F0 File Offset: 0x0059D3F0
		// (set) Token: 0x060292C7 RID: 168647 RVA: 0x0059F1F8 File Offset: 0x0059D3F8
		public byte NullMask { get; set; }

		// Token: 0x060292C8 RID: 168648 RVA: 0x0059F201 File Offset: 0x0059D401
		public ISpringComponentT()
		{
			this.Disabled = false;
			this.IsNormalSpring = false;
			this.IsHitNormalSpring = false;
			this.SettingDir = null;
			this.SpringPow = 0;
			this.NullMask = 0;
		}
	}
}
