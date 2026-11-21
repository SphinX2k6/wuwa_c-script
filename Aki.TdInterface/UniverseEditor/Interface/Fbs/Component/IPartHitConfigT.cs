using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5E RID: 23646
	public class IPartHitConfigT
	{
		// Token: 0x1700ADD1 RID: 44497
		// (get) Token: 0x060273B7 RID: 160695 RVA: 0x0055FF65 File Offset: 0x0055E165
		// (set) Token: 0x060273B8 RID: 160696 RVA: 0x0055FF6D File Offset: 0x0055E16D
		public string PartName { get; set; }

		// Token: 0x1700ADD2 RID: 44498
		// (get) Token: 0x060273B9 RID: 160697 RVA: 0x0055FF76 File Offset: 0x0055E176
		// (set) Token: 0x060273BA RID: 160698 RVA: 0x0055FF7E File Offset: 0x0055E17E
		public THitBulletTypeUnion HitBullets { get; set; }

		// Token: 0x1700ADD3 RID: 44499
		// (get) Token: 0x060273BB RID: 160699 RVA: 0x0055FF87 File Offset: 0x0055E187
		// (set) Token: 0x060273BC RID: 160700 RVA: 0x0055FF8F File Offset: 0x0055E18F
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700ADD4 RID: 44500
		// (get) Token: 0x060273BD RID: 160701 RVA: 0x0055FF98 File Offset: 0x0055E198
		// (set) Token: 0x060273BE RID: 160702 RVA: 0x0055FFA0 File Offset: 0x0055E1A0
		public byte NullMask { get; set; }

		// Token: 0x060273BF RID: 160703 RVA: 0x0055FFA9 File Offset: 0x0055E1A9
		public IPartHitConfigT()
		{
			this.PartName = null;
			this.HitBullets = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
