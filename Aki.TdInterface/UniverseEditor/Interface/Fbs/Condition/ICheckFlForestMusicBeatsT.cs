using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A2B RID: 18987
	public class ICheckFlForestMusicBeatsT
	{
		// Token: 0x17008972 RID: 35186
		// (get) Token: 0x0601DB6D RID: 121709 RVA: 0x0042DE5F File Offset: 0x0042C05F
		// (set) Token: 0x0601DB6E RID: 121710 RVA: 0x0042DE67 File Offset: 0x0042C067
		public EMusicEventType Type { get; set; }

		// Token: 0x17008973 RID: 35187
		// (get) Token: 0x0601DB6F RID: 121711 RVA: 0x0042DE70 File Offset: 0x0042C070
		// (set) Token: 0x0601DB70 RID: 121712 RVA: 0x0042DE78 File Offset: 0x0042C078
		public string BeatType { get; set; }

		// Token: 0x0601DB71 RID: 121713 RVA: 0x0042DE81 File Offset: 0x0042C081
		public ICheckFlForestMusicBeatsT()
		{
			this.Type = EMusicEventType.HcMusicBattle;
			this.BeatType = null;
		}
	}
}
