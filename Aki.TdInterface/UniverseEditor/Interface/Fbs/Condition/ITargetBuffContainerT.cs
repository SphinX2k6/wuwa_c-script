using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051E2 RID: 20962
	public class ITargetBuffContainerT
	{
		// Token: 0x1700961A RID: 38426
		// (get) Token: 0x06021035 RID: 135221 RVA: 0x00490522 File Offset: 0x0048E722
		// (set) Token: 0x06021036 RID: 135222 RVA: 0x0049052A File Offset: 0x0048E72A
		public ETargetBuffContainer Type { get; set; }

		// Token: 0x06021037 RID: 135223 RVA: 0x00490533 File Offset: 0x0048E733
		public ITargetBuffContainerT()
		{
			this.Type = ETargetBuffContainer.Monster;
		}
	}
}
