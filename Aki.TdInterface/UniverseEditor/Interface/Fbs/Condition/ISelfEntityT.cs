using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051BE RID: 20926
	public class ISelfEntityT
	{
		// Token: 0x170095E1 RID: 38369
		// (get) Token: 0x06020F27 RID: 134951 RVA: 0x0048E6E2 File Offset: 0x0048C8E2
		// (set) Token: 0x06020F28 RID: 134952 RVA: 0x0048E6EA File Offset: 0x0048C8EA
		public ETargetEntityType Type { get; set; }

		// Token: 0x06020F29 RID: 134953 RVA: 0x0048E6F3 File Offset: 0x0048C8F3
		public ISelfEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
