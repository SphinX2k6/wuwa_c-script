using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B60 RID: 19296
	public class ICheckTrackMoonPopularityT
	{
		// Token: 0x17008C04 RID: 35844
		// (get) Token: 0x0601E659 RID: 124505 RVA: 0x00441FB6 File Offset: 0x004401B6
		// (set) Token: 0x0601E65A RID: 124506 RVA: 0x00441FBE File Offset: 0x004401BE
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17008C05 RID: 35845
		// (get) Token: 0x0601E65B RID: 124507 RVA: 0x00441FC7 File Offset: 0x004401C7
		// (set) Token: 0x0601E65C RID: 124508 RVA: 0x00441FCF File Offset: 0x004401CF
		public ECompare Compare { get; set; }

		// Token: 0x17008C06 RID: 35846
		// (get) Token: 0x0601E65D RID: 124509 RVA: 0x00441FD8 File Offset: 0x004401D8
		// (set) Token: 0x0601E65E RID: 124510 RVA: 0x00441FE0 File Offset: 0x004401E0
		public int Popularity { get; set; }

		// Token: 0x0601E65F RID: 124511 RVA: 0x00441FE9 File Offset: 0x004401E9
		public ICheckTrackMoonPopularityT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Compare = ECompare.Eq;
			this.Popularity = 0;
		}
	}
}
