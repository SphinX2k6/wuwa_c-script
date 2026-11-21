using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051AF RID: 20911
	public class IRoleLevelTypeT
	{
		// Token: 0x170095C7 RID: 38343
		// (get) Token: 0x06020EBB RID: 134843 RVA: 0x0048DCBE File Offset: 0x0048BEBE
		// (set) Token: 0x06020EBC RID: 134844 RVA: 0x0048DCC6 File Offset: 0x0048BEC6
		public ERoleLevelType Type { get; set; }

		// Token: 0x06020EBD RID: 134845 RVA: 0x0048DCCF File Offset: 0x0048BECF
		public IRoleLevelTypeT()
		{
			this.Type = ERoleLevelType.SpecifyRole;
		}
	}
}
