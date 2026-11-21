using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200579D RID: 22429
	public class IFanInteractByHitT
	{
		// Token: 0x1700A231 RID: 41521
		// (get) Token: 0x06024349 RID: 148297 RVA: 0x004FA4AA File Offset: 0x004F86AA
		// (set) Token: 0x0602434A RID: 148298 RVA: 0x004FA4B2 File Offset: 0x004F86B2
		public EFanInteractType Type { get; set; }

		// Token: 0x0602434B RID: 148299 RVA: 0x004FA4BB File Offset: 0x004F86BB
		public IFanInteractByHitT()
		{
			this.Type = EFanInteractType.Hit;
		}
	}
}
