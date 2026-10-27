using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005847 RID: 22599
	public class IRenderFogBarrierT
	{
		// Token: 0x1700A8DD RID: 43229
		// (get) Token: 0x06026074 RID: 155764 RVA: 0x0053E288 File Offset: 0x0053C488
		// (set) Token: 0x06026075 RID: 155765 RVA: 0x0053E290 File Offset: 0x0053C490
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700A8DE RID: 43230
		// (get) Token: 0x06026076 RID: 155766 RVA: 0x0053E299 File Offset: 0x0053C499
		// (set) Token: 0x06026077 RID: 155767 RVA: 0x0053E2A1 File Offset: 0x0053C4A1
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700A8DF RID: 43231
		// (get) Token: 0x06026078 RID: 155768 RVA: 0x0053E2AA File Offset: 0x0053C4AA
		// (set) Token: 0x06026079 RID: 155769 RVA: 0x0053E2B2 File Offset: 0x0053C4B2
		public IVectorInfoT Center { get; set; }

		// Token: 0x1700A8E0 RID: 43232
		// (get) Token: 0x0602607A RID: 155770 RVA: 0x0053E2BB File Offset: 0x0053C4BB
		// (set) Token: 0x0602607B RID: 155771 RVA: 0x0053E2C3 File Offset: 0x0053C4C3
		public IVectorInfoT Size { get; set; }

		// Token: 0x1700A8E1 RID: 43233
		// (get) Token: 0x0602607C RID: 155772 RVA: 0x0053E2CC File Offset: 0x0053C4CC
		// (set) Token: 0x0602607D RID: 155773 RVA: 0x0053E2D4 File Offset: 0x0053C4D4
		public IVectorInfoT Rotator { get; set; }

		// Token: 0x0602607E RID: 155774 RVA: 0x0053E2DD File Offset: 0x0053C4DD
		public IRenderFogBarrierT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.CenterTarget = null;
			this.Center = null;
			this.Size = null;
			this.Rotator = null;
		}
	}
}
