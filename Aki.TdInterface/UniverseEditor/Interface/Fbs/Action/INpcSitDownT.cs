using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006BE3 RID: 27619
	public class INpcSitDownT
	{
		// Token: 0x1700CD3D RID: 52541
		// (get) Token: 0x06030860 RID: 198752 RVA: 0x0069671F File Offset: 0x0069491F
		// (set) Token: 0x06030861 RID: 198753 RVA: 0x00696727 File Offset: 0x00694927
		public ENpcLeisureInteract Type { get; set; }

		// Token: 0x1700CD3E RID: 52542
		// (get) Token: 0x06030862 RID: 198754 RVA: 0x00696730 File Offset: 0x00694930
		// (set) Token: 0x06030863 RID: 198755 RVA: 0x00696738 File Offset: 0x00694938
		public bool KeepState { get; set; }

		// Token: 0x1700CD3F RID: 52543
		// (get) Token: 0x06030864 RID: 198756 RVA: 0x00696741 File Offset: 0x00694941
		// (set) Token: 0x06030865 RID: 198757 RVA: 0x00696749 File Offset: 0x00694949
		public IMontageIdT MontageId { get; set; }

		// Token: 0x1700CD40 RID: 52544
		// (get) Token: 0x06030866 RID: 198758 RVA: 0x00696752 File Offset: 0x00694952
		// (set) Token: 0x06030867 RID: 198759 RVA: 0x0069675A File Offset: 0x0069495A
		public int PosEntityId { get; set; }

		// Token: 0x1700CD41 RID: 52545
		// (get) Token: 0x06030868 RID: 198760 RVA: 0x00696763 File Offset: 0x00694963
		// (set) Token: 0x06030869 RID: 198761 RVA: 0x0069676B File Offset: 0x0069496B
		public float Duration { get; set; }

		// Token: 0x1700CD42 RID: 52546
		// (get) Token: 0x0603086A RID: 198762 RVA: 0x00696774 File Offset: 0x00694974
		// (set) Token: 0x0603086B RID: 198763 RVA: 0x0069677C File Offset: 0x0069497C
		public byte NullMask { get; set; }

		// Token: 0x0603086C RID: 198764 RVA: 0x00696785 File Offset: 0x00694985
		public INpcSitDownT()
		{
			this.Type = ENpcLeisureInteract.SitDown;
			this.KeepState = false;
			this.MontageId = null;
			this.PosEntityId = 0;
			this.Duration = 0f;
			this.NullMask = 0;
		}
	}
}
