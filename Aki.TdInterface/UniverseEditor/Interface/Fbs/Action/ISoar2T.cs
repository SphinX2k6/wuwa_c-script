using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007161 RID: 29025
	public class ISoar2T
	{
		// Token: 0x1700D7AD RID: 55213
		// (get) Token: 0x0603376C RID: 210796 RVA: 0x006EEFBA File Offset: 0x006ED1BA
		// (set) Token: 0x0603376D RID: 210797 RVA: 0x006EEFC2 File Offset: 0x006ED1C2
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603376E RID: 210798 RVA: 0x006EEFCB File Offset: 0x006ED1CB
		public ISoar2T()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
