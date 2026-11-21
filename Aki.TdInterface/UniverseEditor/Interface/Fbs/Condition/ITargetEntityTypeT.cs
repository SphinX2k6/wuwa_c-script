using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051EE RID: 20974
	public class ITargetEntityTypeT
	{
		// Token: 0x1700962B RID: 38443
		// (get) Token: 0x06021083 RID: 135299 RVA: 0x00490C26 File Offset: 0x0048EE26
		// (set) Token: 0x06021084 RID: 135300 RVA: 0x00490C2E File Offset: 0x0048EE2E
		public ETargetEntityType Type { get; set; }

		// Token: 0x06021085 RID: 135301 RVA: 0x00490C37 File Offset: 0x0048EE37
		public ITargetEntityTypeT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
