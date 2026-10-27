using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200715E RID: 29022
	public class ISoarT
	{
		// Token: 0x1700D7AA RID: 55210
		// (get) Token: 0x0603375A RID: 210778 RVA: 0x006EEE42 File Offset: 0x006ED042
		// (set) Token: 0x0603375B RID: 210779 RVA: 0x006EEE4A File Offset: 0x006ED04A
		public ELeisureInteract Type { get; set; }

		// Token: 0x0603375C RID: 210780 RVA: 0x006EEE53 File Offset: 0x006ED053
		public ISoarT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
