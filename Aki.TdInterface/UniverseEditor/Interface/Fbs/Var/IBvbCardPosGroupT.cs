using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003E21 RID: 15905
	public class IBvbCardPosGroupT
	{
		// Token: 0x17006B71 RID: 27505
		// (get) Token: 0x06015656 RID: 87638 RVA: 0x003171DE File Offset: 0x003153DE
		// (set) Token: 0x06015657 RID: 87639 RVA: 0x003171E6 File Offset: 0x003153E6
		public bool Pos0 { get; set; }

		// Token: 0x17006B72 RID: 27506
		// (get) Token: 0x06015658 RID: 87640 RVA: 0x003171EF File Offset: 0x003153EF
		// (set) Token: 0x06015659 RID: 87641 RVA: 0x003171F7 File Offset: 0x003153F7
		public bool Pos1 { get; set; }

		// Token: 0x17006B73 RID: 27507
		// (get) Token: 0x0601565A RID: 87642 RVA: 0x00317200 File Offset: 0x00315400
		// (set) Token: 0x0601565B RID: 87643 RVA: 0x00317208 File Offset: 0x00315408
		public bool Pos2 { get; set; }

		// Token: 0x17006B74 RID: 27508
		// (get) Token: 0x0601565C RID: 87644 RVA: 0x00317211 File Offset: 0x00315411
		// (set) Token: 0x0601565D RID: 87645 RVA: 0x00317219 File Offset: 0x00315419
		public bool Pos3 { get; set; }

		// Token: 0x17006B75 RID: 27509
		// (get) Token: 0x0601565E RID: 87646 RVA: 0x00317222 File Offset: 0x00315422
		// (set) Token: 0x0601565F RID: 87647 RVA: 0x0031722A File Offset: 0x0031542A
		public bool Pos4 { get; set; }

		// Token: 0x17006B76 RID: 27510
		// (get) Token: 0x06015660 RID: 87648 RVA: 0x00317233 File Offset: 0x00315433
		// (set) Token: 0x06015661 RID: 87649 RVA: 0x0031723B File Offset: 0x0031543B
		public bool Pos5 { get; set; }

		// Token: 0x17006B77 RID: 27511
		// (get) Token: 0x06015662 RID: 87650 RVA: 0x00317244 File Offset: 0x00315444
		// (set) Token: 0x06015663 RID: 87651 RVA: 0x0031724C File Offset: 0x0031544C
		public byte NullMask { get; set; }

		// Token: 0x06015664 RID: 87652 RVA: 0x00317255 File Offset: 0x00315455
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
