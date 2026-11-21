using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708C RID: 28812
	public class ILandSlideEndInteractT
	{
		// Token: 0x1700D317 RID: 54039
		// (get) Token: 0x06031FC1 RID: 204737 RVA: 0x006C3ABA File Offset: 0x006C1CBA
		// (set) Token: 0x06031FC2 RID: 204738 RVA: 0x006C3AC2 File Offset: 0x006C1CC2
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031FC3 RID: 204739 RVA: 0x006C3ACB File Offset: 0x006C1CCB
		public ILandSlideEndInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
