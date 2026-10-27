using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070D7 RID: 28887
	public class IShowCenterTextT
	{
		// Token: 0x1700D692 RID: 54930
		// (get) Token: 0x060332A9 RID: 209577 RVA: 0x006E6029 File Offset: 0x006E4229
		// (set) Token: 0x060332AA RID: 209578 RVA: 0x006E6031 File Offset: 0x006E4231
		public int TextId { get; set; }

		// Token: 0x1700D693 RID: 54931
		// (get) Token: 0x060332AB RID: 209579 RVA: 0x006E603A File Offset: 0x006E423A
		// (set) Token: 0x060332AC RID: 209580 RVA: 0x006E6042 File Offset: 0x006E4242
		public string TidCenterText { get; set; }

		// Token: 0x1700D694 RID: 54932
		// (get) Token: 0x060332AD RID: 209581 RVA: 0x006E604B File Offset: 0x006E424B
		// (set) Token: 0x060332AE RID: 209582 RVA: 0x006E6053 File Offset: 0x006E4253
		public string PlotLineKey { get; set; }

		// Token: 0x1700D695 RID: 54933
		// (get) Token: 0x060332AF RID: 209583 RVA: 0x006E605C File Offset: 0x006E425C
		// (set) Token: 0x060332B0 RID: 209584 RVA: 0x006E6064 File Offset: 0x006E4264
		public float TotalTime { get; set; }

		// Token: 0x1700D696 RID: 54934
		// (get) Token: 0x060332B1 RID: 209585 RVA: 0x006E606D File Offset: 0x006E426D
		// (set) Token: 0x060332B2 RID: 209586 RVA: 0x006E6075 File Offset: 0x006E4275
		public ITextStyleT TextStyle { get; set; }

		// Token: 0x1700D697 RID: 54935
		// (get) Token: 0x060332B3 RID: 209587 RVA: 0x006E607E File Offset: 0x006E427E
		// (set) Token: 0x060332B4 RID: 209588 RVA: 0x006E6086 File Offset: 0x006E4286
		public string BgImageId { get; set; }

		// Token: 0x1700D698 RID: 54936
		// (get) Token: 0x060332B5 RID: 209589 RVA: 0x006E608F File Offset: 0x006E428F
		// (set) Token: 0x060332B6 RID: 209590 RVA: 0x006E6097 File Offset: 0x006E4297
		public bool IsMulLine { get; set; }

		// Token: 0x1700D699 RID: 54937
		// (get) Token: 0x060332B7 RID: 209591 RVA: 0x006E60A0 File Offset: 0x006E42A0
		// (set) Token: 0x060332B8 RID: 209592 RVA: 0x006E60A8 File Offset: 0x006E42A8
		public bool IsManualNext { get; set; }

		// Token: 0x1700D69A RID: 54938
		// (get) Token: 0x060332B9 RID: 209593 RVA: 0x006E60B1 File Offset: 0x006E42B1
		// (set) Token: 0x060332BA RID: 209594 RVA: 0x006E60B9 File Offset: 0x006E42B9
		public bool IsCancelAutoLine { get; set; }

		// Token: 0x1700D69B RID: 54939
		// (get) Token: 0x060332BB RID: 209595 RVA: 0x006E60C2 File Offset: 0x006E42C2
		// (set) Token: 0x060332BC RID: 209596 RVA: 0x006E60CA File Offset: 0x006E42CA
		public byte NullMask { get; set; }

		// Token: 0x060332BD RID: 209597 RVA: 0x006E60D4 File Offset: 0x006E42D4
		public IShowCenterTextT()
		{
			this.TextId = 0;
			this.TidCenterText = null;
			this.PlotLineKey = null;
			this.TotalTime = 0f;
			this.TextStyle = null;
			this.BgImageId = null;
			this.IsMulLine = false;
			this.IsManualNext = false;
			this.IsCancelAutoLine = false;
			this.NullMask = 0;
		}
	}
}
