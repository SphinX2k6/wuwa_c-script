using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063F0 RID: 25584
	public class IFollowShooterJellyFishAbilityT
	{
		// Token: 0x1700BD05 RID: 48389
		// (get) Token: 0x0602B776 RID: 178038 RVA: 0x005EBFC7 File Offset: 0x005EA1C7
		// (set) Token: 0x0602B777 RID: 178039 RVA: 0x005EBFCF File Offset: 0x005EA1CF
		public EFollowShooterType Type { get; set; }

		// Token: 0x1700BD06 RID: 48390
		// (get) Token: 0x0602B778 RID: 178040 RVA: 0x005EBFD8 File Offset: 0x005EA1D8
		// (set) Token: 0x0602B779 RID: 178041 RVA: 0x005EBFE0 File Offset: 0x005EA1E0
		public List<EJellyFishAbilityType> Abilities { get; set; }

		// Token: 0x0602B77A RID: 178042 RVA: 0x005EBFE9 File Offset: 0x005EA1E9
		public IFollowShooterJellyFishAbilityT()
		{
			this.Type = EFollowShooterType.JellyFish;
			this.Abilities = null;
		}
	}
}
