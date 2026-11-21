using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004F0F RID: 20239
	public class ICheckHcMusicBeatsT
	{
		// Token: 0x1700908A RID: 37002
		// (get) Token: 0x0601F725 RID: 128805 RVA: 0x00460FB7 File Offset: 0x0045F1B7
		// (set) Token: 0x0601F726 RID: 128806 RVA: 0x00460FBF File Offset: 0x0045F1BF
		public EMusicEventType Type { get; set; }

		// Token: 0x1700908B RID: 37003
		// (get) Token: 0x0601F727 RID: 128807 RVA: 0x00460FC8 File Offset: 0x0045F1C8
		// (set) Token: 0x0601F728 RID: 128808 RVA: 0x00460FD0 File Offset: 0x0045F1D0
		public string BeatType { get; set; }

		// Token: 0x0601F729 RID: 128809 RVA: 0x00460FD9 File Offset: 0x0045F1D9
		public ICheckHcMusicBeatsT()
		{
			this.Type = EMusicEventType.HcMusicBattle;
			this.BeatType = null;
		}
	}
}
