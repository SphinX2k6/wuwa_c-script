using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006661 RID: 26209
	public class IEnableFuncConfigT
	{
		// Token: 0x1700C2B9 RID: 49849
		// (get) Token: 0x0602D87F RID: 186495 RVA: 0x0063C180 File Offset: 0x0063A380
		// (set) Token: 0x0602D880 RID: 186496 RVA: 0x0063C188 File Offset: 0x0063A388
		public float DelayDuration { get; set; }

		// Token: 0x1700C2BA RID: 49850
		// (get) Token: 0x0602D881 RID: 186497 RVA: 0x0063C191 File Offset: 0x0063A391
		// (set) Token: 0x0602D882 RID: 186498 RVA: 0x0063C199 File Offset: 0x0063A399
		public bool IsEnableEsc { get; set; }

		// Token: 0x1700C2BB RID: 49851
		// (get) Token: 0x0602D883 RID: 186499 RVA: 0x0063C1A2 File Offset: 0x0063A3A2
		// (set) Token: 0x0602D884 RID: 186500 RVA: 0x0063C1AA File Offset: 0x0063A3AA
		public bool IsEnablePhoto { get; set; }

		// Token: 0x1700C2BC RID: 49852
		// (get) Token: 0x0602D885 RID: 186501 RVA: 0x0063C1B3 File Offset: 0x0063A3B3
		// (set) Token: 0x0602D886 RID: 186502 RVA: 0x0063C1BB File Offset: 0x0063A3BB
		public byte NullMask { get; set; }

		// Token: 0x0602D887 RID: 186503 RVA: 0x0063C1C4 File Offset: 0x0063A3C4
		public IEnableFuncConfigT()
		{
			this.DelayDuration = 0f;
			this.IsEnableEsc = false;
			this.IsEnablePhoto = false;
			this.NullMask = 0;
		}
	}
}
