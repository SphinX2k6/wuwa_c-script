using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005967 RID: 22887
	public class IIconNearByTrackingConfigT
	{
		// Token: 0x1700A648 RID: 42568
		// (get) Token: 0x060254D7 RID: 152791 RVA: 0x0051EF67 File Offset: 0x0051D167
		// (set) Token: 0x060254D8 RID: 152792 RVA: 0x0051EF6F File Offset: 0x0051D16F
		public int ShowRange { get; set; }

		// Token: 0x1700A649 RID: 42569
		// (get) Token: 0x060254D9 RID: 152793 RVA: 0x0051EF78 File Offset: 0x0051D178
		// (set) Token: 0x060254DA RID: 152794 RVA: 0x0051EF80 File Offset: 0x0051D180
		public int HideRange { get; set; }

		// Token: 0x1700A64A RID: 42570
		// (get) Token: 0x060254DB RID: 152795 RVA: 0x0051EF89 File Offset: 0x0051D189
		// (set) Token: 0x060254DC RID: 152796 RVA: 0x0051EF91 File Offset: 0x0051D191
		public ENearbyTrackingTexture TexturePath { get; set; }

		// Token: 0x1700A64B RID: 42571
		// (get) Token: 0x060254DD RID: 152797 RVA: 0x0051EF9A File Offset: 0x0051D19A
		// (set) Token: 0x060254DE RID: 152798 RVA: 0x0051EFA2 File Offset: 0x0051D1A2
		public IVectorInfoT UiOffset { get; set; }

		// Token: 0x1700A64C RID: 42572
		// (get) Token: 0x060254DF RID: 152799 RVA: 0x0051EFAB File Offset: 0x0051D1AB
		// (set) Token: 0x060254E0 RID: 152800 RVA: 0x0051EFB3 File Offset: 0x0051D1B3
		public float Duration { get; set; }

		// Token: 0x1700A64D RID: 42573
		// (get) Token: 0x060254E1 RID: 152801 RVA: 0x0051EFBC File Offset: 0x0051D1BC
		// (set) Token: 0x060254E2 RID: 152802 RVA: 0x0051EFC4 File Offset: 0x0051D1C4
		public byte NullMask { get; set; }

		// Token: 0x060254E3 RID: 152803 RVA: 0x0051EFCD File Offset: 0x0051D1CD
		public IIconNearByTrackingConfigT()
		{
			this.ShowRange = 0;
			this.HideRange = 0;
			this.TexturePath = ENearbyTrackingTexture.BigTeleporter;
			this.UiOffset = null;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
