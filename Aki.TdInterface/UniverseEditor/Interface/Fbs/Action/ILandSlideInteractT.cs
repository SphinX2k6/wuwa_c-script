using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069DF RID: 27103
	public class ILandSlideInteractT
	{
		// Token: 0x1700C91A RID: 51482
		// (get) Token: 0x0602F613 RID: 194067 RVA: 0x006738DA File Offset: 0x00671ADA
		// (set) Token: 0x0602F614 RID: 194068 RVA: 0x006738E2 File Offset: 0x00671AE2
		public ELeisureInteract Type { get; set; }

		// Token: 0x0602F615 RID: 194069 RVA: 0x006738EB File Offset: 0x00671AEB
		public ILandSlideInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
