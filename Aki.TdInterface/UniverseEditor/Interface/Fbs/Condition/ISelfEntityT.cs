using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CC2 RID: 19650
	public class ISelfEntityT
	{
		// Token: 0x17008EA8 RID: 36520
		// (get) Token: 0x0601F2E3 RID: 127715 RVA: 0x0045A7EA File Offset: 0x004589EA
		// (set) Token: 0x0601F2E4 RID: 127716 RVA: 0x0045A7F2 File Offset: 0x004589F2
		public ETargetEntityType Type { get; set; }

		// Token: 0x0601F2E5 RID: 127717 RVA: 0x0045A7FB File Offset: 0x004589FB
		public ISelfEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
