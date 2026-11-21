using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E2E RID: 24110
	public class IRefreshGroupT
	{
		// Token: 0x1700B1B2 RID: 45490
		// (get) Token: 0x0602844E RID: 164942 RVA: 0x005818AB File Offset: 0x0057FAAB
		// (set) Token: 0x0602844F RID: 164943 RVA: 0x005818B3 File Offset: 0x0057FAB3
		public bool Disabled { get; set; }

		// Token: 0x1700B1B3 RID: 45491
		// (get) Token: 0x06028450 RID: 164944 RVA: 0x005818BC File Offset: 0x0057FABC
		// (set) Token: 0x06028451 RID: 164945 RVA: 0x005818C4 File Offset: 0x0057FAC4
		public int RefreshInterval { get; set; }

		// Token: 0x1700B1B4 RID: 45492
		// (get) Token: 0x06028452 RID: 164946 RVA: 0x005818CD File Offset: 0x0057FACD
		// (set) Token: 0x06028453 RID: 164947 RVA: 0x005818D5 File Offset: 0x0057FAD5
		public bool DelayRefresh { get; set; }

		// Token: 0x1700B1B5 RID: 45493
		// (get) Token: 0x06028454 RID: 164948 RVA: 0x005818DE File Offset: 0x0057FADE
		// (set) Token: 0x06028455 RID: 164949 RVA: 0x005818E6 File Offset: 0x0057FAE6
		public List<int> EntityIdList { get; set; }

		// Token: 0x1700B1B6 RID: 45494
		// (get) Token: 0x06028456 RID: 164950 RVA: 0x005818EF File Offset: 0x0057FAEF
		// (set) Token: 0x06028457 RID: 164951 RVA: 0x005818F7 File Offset: 0x0057FAF7
		public ICylinderT IsUesCylinder { get; set; }

		// Token: 0x1700B1B7 RID: 45495
		// (get) Token: 0x06028458 RID: 164952 RVA: 0x00581900 File Offset: 0x0057FB00
		// (set) Token: 0x06028459 RID: 164953 RVA: 0x00581908 File Offset: 0x0057FB08
		public byte NullMask { get; set; }

		// Token: 0x0602845A RID: 164954 RVA: 0x00581911 File Offset: 0x0057FB11
		public IRefreshGroupT()
		{
			this.Disabled = false;
			this.RefreshInterval = 0;
			this.DelayRefresh = false;
			this.EntityIdList = null;
			this.IsUesCylinder = null;
			this.NullMask = 0;
		}
	}
}
