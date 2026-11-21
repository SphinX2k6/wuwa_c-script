using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007211 RID: 29201
	public class IMoneHackingDoorInteractT
	{
		// Token: 0x1700D5BD RID: 54717
		// (get) Token: 0x06032CF8 RID: 208120 RVA: 0x006DCA0E File Offset: 0x006DAC0E
		// (set) Token: 0x06032CF9 RID: 208121 RVA: 0x006DCA16 File Offset: 0x006DAC16
		public ELeisureInteract Type { get; set; }

		// Token: 0x06032CFA RID: 208122 RVA: 0x006DCA1F File Offset: 0x006DAC1F
		public IMoneHackingDoorInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
