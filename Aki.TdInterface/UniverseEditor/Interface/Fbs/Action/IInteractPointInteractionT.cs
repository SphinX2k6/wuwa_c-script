using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007056 RID: 28758
	public class IInteractPointInteractionT
	{
		// Token: 0x1700D2A7 RID: 53927
		// (get) Token: 0x06031DE5 RID: 204261 RVA: 0x006C034E File Offset: 0x006BE54E
		// (set) Token: 0x06031DE6 RID: 204262 RVA: 0x006C0356 File Offset: 0x006BE556
		public EInteractPointInteractionType Type { get; set; }

		// Token: 0x06031DE7 RID: 204263 RVA: 0x006C035F File Offset: 0x006BE55F
		public IInteractPointInteractionT()
		{
			this.Type = EInteractPointInteractionType.Drag;
		}
	}
}
