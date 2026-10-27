using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003F84 RID: 16260
	public class IPhotographSubTargetT
	{
		// Token: 0x17007180 RID: 29056
		// (get) Token: 0x0601737E RID: 95102 RVA: 0x00359976 File Offset: 0x00357B76
		// (set) Token: 0x0601737F RID: 95103 RVA: 0x0035997E File Offset: 0x00357B7E
		public EPhotographSubTargetType Type { get; set; }

		// Token: 0x06017380 RID: 95104 RVA: 0x00359987 File Offset: 0x00357B87
		public IPhotographSubTargetT()
		{
			this.Type = EPhotographSubTargetType.SpecificRole;
		}
	}
}
