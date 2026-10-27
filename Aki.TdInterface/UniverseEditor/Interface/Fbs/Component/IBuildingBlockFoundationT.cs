using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F35 RID: 20277
	public class IBuildingBlockFoundationT
	{
		// Token: 0x1700922A RID: 37418
		// (get) Token: 0x06020193 RID: 131475 RVA: 0x004773A2 File Offset: 0x004755A2
		// (set) Token: 0x06020194 RID: 131476 RVA: 0x004773AA File Offset: 0x004755AA
		public EItemFoundation Type { get; set; }

		// Token: 0x06020195 RID: 131477 RVA: 0x004773B3 File Offset: 0x004755B3
		public IBuildingBlockFoundationT()
		{
			this.Type = EItemFoundation.CategoryMatching;
		}
	}
}
