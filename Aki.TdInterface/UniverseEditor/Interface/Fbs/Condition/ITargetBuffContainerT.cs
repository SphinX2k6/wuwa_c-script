using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE6 RID: 19686
	public class ITargetBuffContainerT
	{
		// Token: 0x17008EE1 RID: 36577
		// (get) Token: 0x0601F3F0 RID: 127984 RVA: 0x0045C5D2 File Offset: 0x0045A7D2
		// (set) Token: 0x0601F3F1 RID: 127985 RVA: 0x0045C5DA File Offset: 0x0045A7DA
		public ETargetBuffContainer Type { get; set; }

		// Token: 0x0601F3F2 RID: 127986 RVA: 0x0045C5E3 File Offset: 0x0045A7E3
		public ITargetBuffContainerT()
		{
			this.Type = ETargetBuffContainer.Monster;
		}
	}
}
