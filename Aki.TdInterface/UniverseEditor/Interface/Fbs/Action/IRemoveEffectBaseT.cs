using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020075C5 RID: 30149
	public class IRemoveEffectBaseT
	{
		// Token: 0x1700DDA7 RID: 56743
		// (get) Token: 0x06034E50 RID: 216656 RVA: 0x0071BDBB File Offset: 0x00719FBB
		// (set) Token: 0x06034E51 RID: 216657 RVA: 0x0071BDC3 File Offset: 0x00719FC3
		public EEffectType Type { get; set; }

		// Token: 0x1700DDA8 RID: 56744
		// (get) Token: 0x06034E52 RID: 216658 RVA: 0x0071BDCC File Offset: 0x00719FCC
		// (set) Token: 0x06034E53 RID: 216659 RVA: 0x0071BDD4 File Offset: 0x00719FD4
		public string Path { get; set; }

		// Token: 0x06034E54 RID: 216660 RVA: 0x0071BDDD File Offset: 0x00719FDD
		public IRemoveEffectBaseT()
		{
			this.Type = EEffectType.Effect;
			this.Path = null;
		}
	}
}
