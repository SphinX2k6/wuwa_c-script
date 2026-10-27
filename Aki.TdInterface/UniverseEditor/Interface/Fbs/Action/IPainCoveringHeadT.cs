using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C5E RID: 27742
	public class IPainCoveringHeadT
	{
		// Token: 0x1700CE9B RID: 52891
		// (get) Token: 0x06030E13 RID: 200211 RVA: 0x006A392E File Offset: 0x006A1B2E
		// (set) Token: 0x06030E14 RID: 200212 RVA: 0x006A3936 File Offset: 0x006A1B36
		public ELeisureInteract Type { get; set; }

		// Token: 0x06030E15 RID: 200213 RVA: 0x006A393F File Offset: 0x006A1B3F
		public IPainCoveringHeadT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
