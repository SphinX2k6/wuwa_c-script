using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BC1 RID: 31681
	public class IThreeStageSplineMoveMontageT
	{
		// Token: 0x1700ED62 RID: 60770
		// (get) Token: 0x060391BA RID: 233914 RVA: 0x007B7D23 File Offset: 0x007B5F23
		// (set) Token: 0x060391BB RID: 233915 RVA: 0x007B7D2B File Offset: 0x007B5F2B
		public ESplineMoveMontageType Type { get; set; }

		// Token: 0x1700ED63 RID: 60771
		// (get) Token: 0x060391BC RID: 233916 RVA: 0x007B7D34 File Offset: 0x007B5F34
		// (set) Token: 0x060391BD RID: 233917 RVA: 0x007B7D3C File Offset: 0x007B5F3C
		public string MontagePath { get; set; }

		// Token: 0x060391BE RID: 233918 RVA: 0x007B7D45 File Offset: 0x007B5F45
		public IThreeStageSplineMoveMontageT()
		{
			this.Type = ESplineMoveMontageType.ThreeStageMontage;
			this.MontagePath = null;
		}
	}
}
