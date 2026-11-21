using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005803 RID: 22531
	public class IFollowShooterComponentT
	{
		// Token: 0x1700A313 RID: 41747
		// (get) Token: 0x0602472E RID: 149294 RVA: 0x005025A7 File Offset: 0x005007A7
		// (set) Token: 0x0602472F RID: 149295 RVA: 0x005025AF File Offset: 0x005007AF
		public bool Disabled { get; set; }

		// Token: 0x1700A314 RID: 41748
		// (get) Token: 0x06024730 RID: 149296 RVA: 0x005025B8 File Offset: 0x005007B8
		// (set) Token: 0x06024731 RID: 149297 RVA: 0x005025C0 File Offset: 0x005007C0
		public string Config { get; set; }

		// Token: 0x1700A315 RID: 41749
		// (get) Token: 0x06024732 RID: 149298 RVA: 0x005025C9 File Offset: 0x005007C9
		// (set) Token: 0x06024733 RID: 149299 RVA: 0x005025D1 File Offset: 0x005007D1
		public IFollowShooterJellyFishConfigT TypeConfig { get; set; }

		// Token: 0x1700A316 RID: 41750
		// (get) Token: 0x06024734 RID: 149300 RVA: 0x005025DA File Offset: 0x005007DA
		// (set) Token: 0x06024735 RID: 149301 RVA: 0x005025E2 File Offset: 0x005007E2
		public List<IEntityCategoryT> LockableCategories { get; set; }

		// Token: 0x1700A317 RID: 41751
		// (get) Token: 0x06024736 RID: 149302 RVA: 0x005025EB File Offset: 0x005007EB
		// (set) Token: 0x06024737 RID: 149303 RVA: 0x005025F3 File Offset: 0x005007F3
		public byte NullMask { get; set; }

		// Token: 0x06024738 RID: 149304 RVA: 0x005025FC File Offset: 0x005007FC
		public IFollowShooterComponentT()
		{
			this.Disabled = false;
			this.Config = null;
			this.TypeConfig = null;
			this.LockableCategories = null;
			this.NullMask = 0;
		}
	}
}
