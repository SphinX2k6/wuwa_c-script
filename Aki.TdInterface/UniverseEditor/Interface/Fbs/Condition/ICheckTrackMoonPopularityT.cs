using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005047 RID: 20551
	public class ICheckTrackMoonPopularityT
	{
		// Token: 0x17009314 RID: 37652
		// (get) Token: 0x060201E7 RID: 131559 RVA: 0x00474802 File Offset: 0x00472A02
		// (set) Token: 0x060201E8 RID: 131560 RVA: 0x0047480A File Offset: 0x00472A0A
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17009315 RID: 37653
		// (get) Token: 0x060201E9 RID: 131561 RVA: 0x00474813 File Offset: 0x00472A13
		// (set) Token: 0x060201EA RID: 131562 RVA: 0x0047481B File Offset: 0x00472A1B
		public ECompare Compare { get; set; }

		// Token: 0x17009316 RID: 37654
		// (get) Token: 0x060201EB RID: 131563 RVA: 0x00474824 File Offset: 0x00472A24
		// (set) Token: 0x060201EC RID: 131564 RVA: 0x0047482C File Offset: 0x00472A2C
		public int Popularity { get; set; }

		// Token: 0x060201ED RID: 131565 RVA: 0x00474835 File Offset: 0x00472A35
		public ICheckTrackMoonPopularityT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Compare = ECompare.Eq;
			this.Popularity = 0;
		}
	}
}
