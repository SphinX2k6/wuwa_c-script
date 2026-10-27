using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004C8C RID: 19596
	public class IPlayerEntityT
	{
		// Token: 0x17008E4A RID: 36426
		// (get) Token: 0x0601F14B RID: 127307 RVA: 0x00457E36 File Offset: 0x00456036
		// (set) Token: 0x0601F14C RID: 127308 RVA: 0x00457E3E File Offset: 0x0045603E
		public ETargetEntityType Type { get; set; }

		// Token: 0x0601F14D RID: 127309 RVA: 0x00457E47 File Offset: 0x00456047
		public IPlayerEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
