using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A14 RID: 31252
	public class ISunPalaceInteractT
	{
		// Token: 0x1700E4FF RID: 58623
		// (get) Token: 0x06037102 RID: 225538 RVA: 0x0075BD06 File Offset: 0x00759F06
		// (set) Token: 0x06037103 RID: 225539 RVA: 0x0075BD0E File Offset: 0x00759F0E
		public ELeisureInteract Type { get; set; }

		// Token: 0x06037104 RID: 225540 RVA: 0x0075BD17 File Offset: 0x00759F17
		public ISunPalaceInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
