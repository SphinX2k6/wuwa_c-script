using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A1B RID: 27163
	public class IClientEventPianoUpdateSubtitleT
	{
		// Token: 0x1700C7B3 RID: 51123
		// (get) Token: 0x0602E999 RID: 190873 RVA: 0x0065ACB9 File Offset: 0x00658EB9
		// (set) Token: 0x0602E99A RID: 190874 RVA: 0x0065ACC1 File Offset: 0x00658EC1
		public EClientEventPianoEventType Type { get; set; }

		// Token: 0x1700C7B4 RID: 51124
		// (get) Token: 0x0602E99B RID: 190875 RVA: 0x0065ACCA File Offset: 0x00658ECA
		// (set) Token: 0x0602E99C RID: 190876 RVA: 0x0065ACD2 File Offset: 0x00658ED2
		public IPlayFlowT Flow { get; set; }

		// Token: 0x1700C7B5 RID: 51125
		// (get) Token: 0x0602E99D RID: 190877 RVA: 0x0065ACDB File Offset: 0x00658EDB
		// (set) Token: 0x0602E99E RID: 190878 RVA: 0x0065ACE3 File Offset: 0x00658EE3
		public bool DisableMove { get; set; }

		// Token: 0x0602E99F RID: 190879 RVA: 0x0065ACEC File Offset: 0x00658EEC
		public IClientEventPianoUpdateSubtitleT()
		{
			this.Type = EClientEventPianoEventType.UpdateSubtitle;
			this.Flow = null;
			this.DisableMove = false;
		}
	}
}
