using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007050 RID: 28752
	public class IInteractPointConfigT
	{
		// Token: 0x1700D2A2 RID: 53922
		// (get) Token: 0x06031DC7 RID: 204231 RVA: 0x006C00DA File Offset: 0x006BE2DA
		// (set) Token: 0x06031DC8 RID: 204232 RVA: 0x006C00E2 File Offset: 0x006BE2E2
		public EInteractUnlockType Type { get; set; }

		// Token: 0x06031DC9 RID: 204233 RVA: 0x006C00EB File Offset: 0x006BE2EB
		public IInteractPointConfigT()
		{
			this.Type = EInteractUnlockType.Sequence;
		}
	}
}
