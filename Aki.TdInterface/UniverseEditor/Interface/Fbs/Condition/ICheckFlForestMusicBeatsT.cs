using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004EEE RID: 20206
	public class ICheckFlForestMusicBeatsT
	{
		// Token: 0x17009047 RID: 36935
		// (get) Token: 0x0601F5F6 RID: 128502 RVA: 0x0045ED57 File Offset: 0x0045CF57
		// (set) Token: 0x0601F5F7 RID: 128503 RVA: 0x0045ED5F File Offset: 0x0045CF5F
		public EMusicEventType Type { get; set; }

		// Token: 0x17009048 RID: 36936
		// (get) Token: 0x0601F5F8 RID: 128504 RVA: 0x0045ED68 File Offset: 0x0045CF68
		// (set) Token: 0x0601F5F9 RID: 128505 RVA: 0x0045ED70 File Offset: 0x0045CF70
		public string BeatType { get; set; }

		// Token: 0x0601F5FA RID: 128506 RVA: 0x0045ED79 File Offset: 0x0045CF79
		public ICheckFlForestMusicBeatsT()
		{
			this.Type = EMusicEventType.HcMusicBattle;
			this.BeatType = null;
		}
	}
}
