using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020078A3 RID: 30883
	public class IShowCenterTextT
	{
		// Token: 0x1700E275 RID: 57973
		// (get) Token: 0x0603654B RID: 222539 RVA: 0x00746635 File Offset: 0x00744835
		// (set) Token: 0x0603654C RID: 222540 RVA: 0x0074663D File Offset: 0x0074483D
		public int TextId { get; set; }

		// Token: 0x1700E276 RID: 57974
		// (get) Token: 0x0603654D RID: 222541 RVA: 0x00746646 File Offset: 0x00744846
		// (set) Token: 0x0603654E RID: 222542 RVA: 0x0074664E File Offset: 0x0074484E
		public string TidCenterText { get; set; }

		// Token: 0x1700E277 RID: 57975
		// (get) Token: 0x0603654F RID: 222543 RVA: 0x00746657 File Offset: 0x00744857
		// (set) Token: 0x06036550 RID: 222544 RVA: 0x0074665F File Offset: 0x0074485F
		public string PlotLineKey { get; set; }

		// Token: 0x1700E278 RID: 57976
		// (get) Token: 0x06036551 RID: 222545 RVA: 0x00746668 File Offset: 0x00744868
		// (set) Token: 0x06036552 RID: 222546 RVA: 0x00746670 File Offset: 0x00744870
		public float TotalTime { get; set; }

		// Token: 0x1700E279 RID: 57977
		// (get) Token: 0x06036553 RID: 222547 RVA: 0x00746679 File Offset: 0x00744879
		// (set) Token: 0x06036554 RID: 222548 RVA: 0x00746681 File Offset: 0x00744881
		public ITextStyleT TextStyle { get; set; }

		// Token: 0x1700E27A RID: 57978
		// (get) Token: 0x06036555 RID: 222549 RVA: 0x0074668A File Offset: 0x0074488A
		// (set) Token: 0x06036556 RID: 222550 RVA: 0x00746692 File Offset: 0x00744892
		public string BgImageId { get; set; }

		// Token: 0x1700E27B RID: 57979
		// (get) Token: 0x06036557 RID: 222551 RVA: 0x0074669B File Offset: 0x0074489B
		// (set) Token: 0x06036558 RID: 222552 RVA: 0x007466A3 File Offset: 0x007448A3
		public bool IsMulLine { get; set; }

		// Token: 0x1700E27C RID: 57980
		// (get) Token: 0x06036559 RID: 222553 RVA: 0x007466AC File Offset: 0x007448AC
		// (set) Token: 0x0603655A RID: 222554 RVA: 0x007466B4 File Offset: 0x007448B4
		public bool IsManualNext { get; set; }

		// Token: 0x1700E27D RID: 57981
		// (get) Token: 0x0603655B RID: 222555 RVA: 0x007466BD File Offset: 0x007448BD
		// (set) Token: 0x0603655C RID: 222556 RVA: 0x007466C5 File Offset: 0x007448C5
		public bool IsCancelAutoLine { get; set; }

		// Token: 0x1700E27E RID: 57982
		// (get) Token: 0x0603655D RID: 222557 RVA: 0x007466CE File Offset: 0x007448CE
		// (set) Token: 0x0603655E RID: 222558 RVA: 0x007466D6 File Offset: 0x007448D6
		public byte NullMask { get; set; }

		// Token: 0x0603655F RID: 222559 RVA: 0x007466E0 File Offset: 0x007448E0
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
