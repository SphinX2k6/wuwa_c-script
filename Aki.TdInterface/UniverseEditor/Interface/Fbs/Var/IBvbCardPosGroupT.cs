using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A46 RID: 14918
	public class IBvbCardPosGroupT
	{
		// Token: 0x17006641 RID: 26177
		// (get) Token: 0x0601433A RID: 82746 RVA: 0x002F3FF2 File Offset: 0x002F21F2
		// (set) Token: 0x0601433B RID: 82747 RVA: 0x002F3FFA File Offset: 0x002F21FA
		public bool Pos0 { get; set; }

		// Token: 0x17006642 RID: 26178
		// (get) Token: 0x0601433C RID: 82748 RVA: 0x002F4003 File Offset: 0x002F2203
		// (set) Token: 0x0601433D RID: 82749 RVA: 0x002F400B File Offset: 0x002F220B
		public bool Pos1 { get; set; }

		// Token: 0x17006643 RID: 26179
		// (get) Token: 0x0601433E RID: 82750 RVA: 0x002F4014 File Offset: 0x002F2214
		// (set) Token: 0x0601433F RID: 82751 RVA: 0x002F401C File Offset: 0x002F221C
		public bool Pos2 { get; set; }

		// Token: 0x17006644 RID: 26180
		// (get) Token: 0x06014340 RID: 82752 RVA: 0x002F4025 File Offset: 0x002F2225
		// (set) Token: 0x06014341 RID: 82753 RVA: 0x002F402D File Offset: 0x002F222D
		public bool Pos3 { get; set; }

		// Token: 0x17006645 RID: 26181
		// (get) Token: 0x06014342 RID: 82754 RVA: 0x002F4036 File Offset: 0x002F2236
		// (set) Token: 0x06014343 RID: 82755 RVA: 0x002F403E File Offset: 0x002F223E
		public bool Pos4 { get; set; }

		// Token: 0x17006646 RID: 26182
		// (get) Token: 0x06014344 RID: 82756 RVA: 0x002F4047 File Offset: 0x002F2247
		// (set) Token: 0x06014345 RID: 82757 RVA: 0x002F404F File Offset: 0x002F224F
		public bool Pos5 { get; set; }

		// Token: 0x17006647 RID: 26183
		// (get) Token: 0x06014346 RID: 82758 RVA: 0x002F4058 File Offset: 0x002F2258
		// (set) Token: 0x06014347 RID: 82759 RVA: 0x002F4060 File Offset: 0x002F2260
		public byte NullMask { get; set; }

		// Token: 0x06014348 RID: 82760 RVA: 0x002F4069 File Offset: 0x002F2269
		public IBvbCardPosGroupT()
		{
			this.Pos0 = false;
			this.Pos1 = false;
			this.Pos2 = false;
			this.Pos3 = false;
			this.Pos4 = false;
			this.Pos5 = false;
			this.NullMask = 0;
		}
	}
}
