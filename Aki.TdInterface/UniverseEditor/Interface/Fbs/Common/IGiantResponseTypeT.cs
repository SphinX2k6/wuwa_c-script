using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x02006405 RID: 25605
	public class IGiantResponseTypeT
	{
		// Token: 0x1700BD24 RID: 48420
		// (get) Token: 0x0602B808 RID: 178184 RVA: 0x005ECD66 File Offset: 0x005EAF66
		// (set) Token: 0x0602B809 RID: 178185 RVA: 0x005ECD6E File Offset: 0x005EAF6E
		public EGiantResponseType Type { get; set; }

		// Token: 0x0602B80A RID: 178186 RVA: 0x005ECD77 File Offset: 0x005EAF77
		public IGiantResponseTypeT()
		{
			this.Type = EGiantResponseType.PlayAnimation;
		}
	}
}
