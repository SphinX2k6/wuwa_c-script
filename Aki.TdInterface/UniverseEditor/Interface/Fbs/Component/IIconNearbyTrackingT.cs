using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005964 RID: 22884
	public class IIconNearbyTrackingT
	{
		// Token: 0x1700A63A RID: 42554
		// (get) Token: 0x060254AF RID: 152751 RVA: 0x0051EA71 File Offset: 0x0051CC71
		// (set) Token: 0x060254B0 RID: 152752 RVA: 0x0051EA79 File Offset: 0x0051CC79
		public ENearbyTrackingType Type { get; set; }

		// Token: 0x1700A63B RID: 42555
		// (get) Token: 0x060254B1 RID: 152753 RVA: 0x0051EA82 File Offset: 0x0051CC82
		// (set) Token: 0x060254B2 RID: 152754 RVA: 0x0051EA8A File Offset: 0x0051CC8A
		public int ShowRange { get; set; }

		// Token: 0x1700A63C RID: 42556
		// (get) Token: 0x060254B3 RID: 152755 RVA: 0x0051EA93 File Offset: 0x0051CC93
		// (set) Token: 0x060254B4 RID: 152756 RVA: 0x0051EA9B File Offset: 0x0051CC9B
		public int HideRange { get; set; }

		// Token: 0x1700A63D RID: 42557
		// (get) Token: 0x060254B5 RID: 152757 RVA: 0x0051EAA4 File Offset: 0x0051CCA4
		// (set) Token: 0x060254B6 RID: 152758 RVA: 0x0051EAAC File Offset: 0x0051CCAC
		public ENearbyTrackingTexture TexturePath { get; set; }

		// Token: 0x1700A63E RID: 42558
		// (get) Token: 0x060254B7 RID: 152759 RVA: 0x0051EAB5 File Offset: 0x0051CCB5
		// (set) Token: 0x060254B8 RID: 152760 RVA: 0x0051EABD File Offset: 0x0051CCBD
		public IVectorInfoT UiOffset { get; set; }

		// Token: 0x1700A63F RID: 42559
		// (get) Token: 0x060254B9 RID: 152761 RVA: 0x0051EAC6 File Offset: 0x0051CCC6
		// (set) Token: 0x060254BA RID: 152762 RVA: 0x0051EACE File Offset: 0x0051CCCE
		public float Duration { get; set; }

		// Token: 0x1700A640 RID: 42560
		// (get) Token: 0x060254BB RID: 152763 RVA: 0x0051EAD7 File Offset: 0x0051CCD7
		// (set) Token: 0x060254BC RID: 152764 RVA: 0x0051EADF File Offset: 0x0051CCDF
		public byte NullMask { get; set; }

		// Token: 0x060254BD RID: 152765 RVA: 0x0051EAE8 File Offset: 0x0051CCE8
		public IIconNearbyTrackingT()
		{
			this.Type = ENearbyTrackingType.Icon;
			this.ShowRange = 0;
			this.HideRange = 0;
			this.TexturePath = ENearbyTrackingTexture.BigTeleporter;
			this.UiOffset = null;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
