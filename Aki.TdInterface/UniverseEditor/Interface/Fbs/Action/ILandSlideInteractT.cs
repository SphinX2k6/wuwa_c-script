using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708F RID: 28815
	public class ILandSlideInteractT
	{
		// Token: 0x1700D31A RID: 54042
		// (get) Token: 0x06031FD3 RID: 204755 RVA: 0x006C3C32 File Offset: 0x006C1E32
		// (set) Token: 0x06031FD4 RID: 204756 RVA: 0x006C3C3A File Offset: 0x006C1E3A
		public ELeisureInteract Type { get; set; }

		// Token: 0x06031FD5 RID: 204757 RVA: 0x006C3C43 File Offset: 0x006C1E43
		public ILandSlideInteractT()
		{
			this.Type = ELeisureInteract.CustomSkill;
		}
	}
}
