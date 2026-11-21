using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C5 RID: 29637
	public class IPainCoveringHeadT
	{
		// Token: 0x1700D9B6 RID: 55734
		// (get) Token: 0x06033D6E RID: 212334 RVA: 0x006FDE2E File Offset: 0x006FC02E
		// (set) Token: 0x06033D6F RID: 212335 RVA: 0x006FDE36 File Offset: 0x006FC036
		public ELeisureInteract Type { get; set; }

		// Token: 0x06033D70 RID: 212336 RVA: 0x006FDE3F File Offset: 0x006FC03F
		public IPainCoveringHeadT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
