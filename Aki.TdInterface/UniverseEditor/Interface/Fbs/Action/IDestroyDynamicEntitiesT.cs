using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006583 RID: 25987
	public class IDestroyDynamicEntitiesT
	{
		// Token: 0x1700C109 RID: 49417
		// (get) Token: 0x0602D145 RID: 184645 RVA: 0x0062F379 File Offset: 0x0062D579
		// (set) Token: 0x0602D146 RID: 184646 RVA: 0x0062F381 File Offset: 0x0062D581
		public IDestroyVisionDisplayT DestroyEntitiesConfig { get; set; }

		// Token: 0x0602D147 RID: 184647 RVA: 0x0062F38A File Offset: 0x0062D58A
		public IDestroyDynamicEntitiesT()
		{
			this.DestroyEntitiesConfig = null;
		}
	}
}
