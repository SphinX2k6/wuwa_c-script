using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A49 RID: 19017
	public class ICheckHcMusicBeatsT
	{
		// Token: 0x170089AE RID: 35246
		// (get) Token: 0x0601DC82 RID: 121986 RVA: 0x0042FE2B File Offset: 0x0042E02B
		// (set) Token: 0x0601DC83 RID: 121987 RVA: 0x0042FE33 File Offset: 0x0042E033
		public EMusicEventType Type { get; set; }

		// Token: 0x170089AF RID: 35247
		// (get) Token: 0x0601DC84 RID: 121988 RVA: 0x0042FE3C File Offset: 0x0042E03C
		// (set) Token: 0x0601DC85 RID: 121989 RVA: 0x0042FE44 File Offset: 0x0042E044
		public string BeatType { get; set; }

		// Token: 0x0601DC86 RID: 121990 RVA: 0x0042FE4D File Offset: 0x0042E04D
		public ICheckHcMusicBeatsT()
		{
			this.Type = EMusicEventType.HcMusicBattle;
			this.BeatType = null;
		}
	}
}
