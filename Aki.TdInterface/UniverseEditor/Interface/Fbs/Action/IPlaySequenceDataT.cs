using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D3F RID: 27967
	public class IPlaySequenceDataT
	{
		// Token: 0x1700D08A RID: 53386
		// (get) Token: 0x060315F5 RID: 202229 RVA: 0x006B242D File Offset: 0x006B062D
		// (set) Token: 0x060315F6 RID: 202230 RVA: 0x006B2435 File Offset: 0x006B0635
		public string Path { get; set; }

		// Token: 0x1700D08B RID: 53387
		// (get) Token: 0x060315F7 RID: 202231 RVA: 0x006B243E File Offset: 0x006B063E
		// (set) Token: 0x060315F8 RID: 202232 RVA: 0x006B2446 File Offset: 0x006B0646
		public bool ResetCamera { get; set; }

		// Token: 0x1700D08C RID: 53388
		// (get) Token: 0x060315F9 RID: 202233 RVA: 0x006B244F File Offset: 0x006B064F
		// (set) Token: 0x060315FA RID: 202234 RVA: 0x006B2457 File Offset: 0x006B0657
		public bool KeepCamera { get; set; }

		// Token: 0x1700D08D RID: 53389
		// (get) Token: 0x060315FB RID: 202235 RVA: 0x006B2460 File Offset: 0x006B0660
		// (set) Token: 0x060315FC RID: 202236 RVA: 0x006B2468 File Offset: 0x006B0668
		public bool PreLoadRenderAssets { get; set; }

		// Token: 0x1700D08E RID: 53390
		// (get) Token: 0x060315FD RID: 202237 RVA: 0x006B2471 File Offset: 0x006B0671
		// (set) Token: 0x060315FE RID: 202238 RVA: 0x006B2479 File Offset: 0x006B0679
		public List<ISequenceFrameEventT> FrameEvents { get; set; }

		// Token: 0x1700D08F RID: 53391
		// (get) Token: 0x060315FF RID: 202239 RVA: 0x006B2482 File Offset: 0x006B0682
		// (set) Token: 0x06031600 RID: 202240 RVA: 0x006B248A File Offset: 0x006B068A
		public bool SaveFinalPos { get; set; }

		// Token: 0x1700D090 RID: 53392
		// (get) Token: 0x06031601 RID: 202241 RVA: 0x006B2493 File Offset: 0x006B0693
		// (set) Token: 0x06031602 RID: 202242 RVA: 0x006B249B File Offset: 0x006B069B
		public ISetBlendAnimT SeqBlendAnim { get; set; }

		// Token: 0x1700D091 RID: 53393
		// (get) Token: 0x06031603 RID: 202243 RVA: 0x006B24A4 File Offset: 0x006B06A4
		// (set) Token: 0x06031604 RID: 202244 RVA: 0x006B24AC File Offset: 0x006B06AC
		public byte NullMask { get; set; }

		// Token: 0x06031605 RID: 202245 RVA: 0x006B24B5 File Offset: 0x006B06B5
		public IPlaySequenceDataT()
		{
			this.Path = null;
			this.ResetCamera = false;
			this.KeepCamera = false;
			this.PreLoadRenderAssets = false;
			this.FrameEvents = null;
			this.SaveFinalPos = false;
			this.SeqBlendAnim = null;
			this.NullMask = 0;
		}
	}
}
