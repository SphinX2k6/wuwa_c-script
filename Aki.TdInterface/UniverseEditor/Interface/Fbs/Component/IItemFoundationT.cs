using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005492 RID: 21650
	public class IItemFoundationT
	{
		// Token: 0x17009F6A RID: 40810
		// (get) Token: 0x06023A14 RID: 145940 RVA: 0x004ED34D File Offset: 0x004EB54D
		// (set) Token: 0x06023A15 RID: 145941 RVA: 0x004ED355 File Offset: 0x004EB555
		public bool Disabled { get; set; }

		// Token: 0x17009F6B RID: 40811
		// (get) Token: 0x06023A16 RID: 145942 RVA: 0x004ED35E File Offset: 0x004EB55E
		// (set) Token: 0x06023A17 RID: 145943 RVA: 0x004ED366 File Offset: 0x004EB566
		public IAdsortTransformT AdsorptionPoint { get; set; }

		// Token: 0x17009F6C RID: 40812
		// (get) Token: 0x06023A18 RID: 145944 RVA: 0x004ED36F File Offset: 0x004EB56F
		// (set) Token: 0x06023A19 RID: 145945 RVA: 0x004ED377 File Offset: 0x004EB577
		public IEntityMatchT AdsorptionMatch { get; set; }

		// Token: 0x17009F6D RID: 40813
		// (get) Token: 0x06023A1A RID: 145946 RVA: 0x004ED380 File Offset: 0x004EB580
		// (set) Token: 0x06023A1B RID: 145947 RVA: 0x004ED388 File Offset: 0x004EB588
		public IEntityMatchT ActiveMatch { get; set; }

		// Token: 0x17009F6E RID: 40814
		// (get) Token: 0x06023A1C RID: 145948 RVA: 0x004ED391 File Offset: 0x004EB591
		// (set) Token: 0x06023A1D RID: 145949 RVA: 0x004ED399 File Offset: 0x004EB599
		public bool IsSilent { get; set; }

		// Token: 0x17009F6F RID: 40815
		// (get) Token: 0x06023A1E RID: 145950 RVA: 0x004ED3A2 File Offset: 0x004EB5A2
		// (set) Token: 0x06023A1F RID: 145951 RVA: 0x004ED3AA File Offset: 0x004EB5AA
		public bool IsDestroy { get; set; }

		// Token: 0x17009F70 RID: 40816
		// (get) Token: 0x06023A20 RID: 145952 RVA: 0x004ED3B3 File Offset: 0x004EB5B3
		// (set) Token: 0x06023A21 RID: 145953 RVA: 0x004ED3BB File Offset: 0x004EB5BB
		public IItemChangeAdsorbateStateT ChangeAdsorbateState { get; set; }

		// Token: 0x17009F71 RID: 40817
		// (get) Token: 0x06023A22 RID: 145954 RVA: 0x004ED3C4 File Offset: 0x004EB5C4
		// (set) Token: 0x06023A23 RID: 145955 RVA: 0x004ED3CC File Offset: 0x004EB5CC
		public byte NullMask { get; set; }

		// Token: 0x06023A24 RID: 145956 RVA: 0x004ED3D5 File Offset: 0x004EB5D5
		public IItemFoundationT()
		{
			this.Disabled = false;
			this.AdsorptionPoint = null;
			this.AdsorptionMatch = null;
			this.ActiveMatch = null;
			this.IsSilent = false;
			this.IsDestroy = false;
			this.ChangeAdsorbateState = null;
			this.NullMask = 0;
		}
	}
}
