using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020066CB RID: 26315
	public class IAccelerateSkiConfigT
	{
		// Token: 0x1700BF4A RID: 48970
		// (get) Token: 0x0602C363 RID: 181091 RVA: 0x006056B9 File Offset: 0x006038B9
		// (set) Token: 0x0602C364 RID: 181092 RVA: 0x006056C1 File Offset: 0x006038C1
		public ESkiConfig Type { get; set; }

		// Token: 0x1700BF4B RID: 48971
		// (get) Token: 0x0602C365 RID: 181093 RVA: 0x006056CA File Offset: 0x006038CA
		// (set) Token: 0x0602C366 RID: 181094 RVA: 0x006056D2 File Offset: 0x006038D2
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x1700BF4C RID: 48972
		// (get) Token: 0x0602C367 RID: 181095 RVA: 0x006056DB File Offset: 0x006038DB
		// (set) Token: 0x0602C368 RID: 181096 RVA: 0x006056E3 File Offset: 0x006038E3
		public int Duration { get; set; }

		// Token: 0x1700BF4D RID: 48973
		// (get) Token: 0x0602C369 RID: 181097 RVA: 0x006056EC File Offset: 0x006038EC
		// (set) Token: 0x0602C36A RID: 181098 RVA: 0x006056F4 File Offset: 0x006038F4
		public int LimitSpeed { get; set; }

		// Token: 0x1700BF4E RID: 48974
		// (get) Token: 0x0602C36B RID: 181099 RVA: 0x006056FD File Offset: 0x006038FD
		// (set) Token: 0x0602C36C RID: 181100 RVA: 0x00605705 File Offset: 0x00603905
		public int Acceleration { get; set; }

		// Token: 0x1700BF4F RID: 48975
		// (get) Token: 0x0602C36D RID: 181101 RVA: 0x0060570E File Offset: 0x0060390E
		// (set) Token: 0x0602C36E RID: 181102 RVA: 0x00605716 File Offset: 0x00603916
		public int InstantSpeed { get; set; }

		// Token: 0x1700BF50 RID: 48976
		// (get) Token: 0x0602C36F RID: 181103 RVA: 0x0060571F File Offset: 0x0060391F
		// (set) Token: 0x0602C370 RID: 181104 RVA: 0x00605727 File Offset: 0x00603927
		public byte NullMask { get; set; }

		// Token: 0x0602C371 RID: 181105 RVA: 0x00605730 File Offset: 0x00603930
		public IAccelerateSkiConfigT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
			this.Duration = 0;
			this.LimitSpeed = 0;
			this.Acceleration = 0;
			this.InstantSpeed = 0;
			this.NullMask = 0;
		}
	}
}
