using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200583F RID: 22591
	public class IRenderBookPageT
	{
		// Token: 0x1700A8C5 RID: 43205
		// (get) Token: 0x06026018 RID: 155672 RVA: 0x0053D423 File Offset: 0x0053B623
		// (set) Token: 0x06026019 RID: 155673 RVA: 0x0053D42B File Offset: 0x0053B62B
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700A8C6 RID: 43206
		// (get) Token: 0x0602601A RID: 155674 RVA: 0x0053D434 File Offset: 0x0053B634
		// (set) Token: 0x0602601B RID: 155675 RVA: 0x0053D43C File Offset: 0x0053B63C
		public int Radius { get; set; }

		// Token: 0x1700A8C7 RID: 43207
		// (get) Token: 0x0602601C RID: 155676 RVA: 0x0053D445 File Offset: 0x0053B645
		// (set) Token: 0x0602601D RID: 155677 RVA: 0x0053D44D File Offset: 0x0053B64D
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700A8C8 RID: 43208
		// (get) Token: 0x0602601E RID: 155678 RVA: 0x0053D456 File Offset: 0x0053B656
		// (set) Token: 0x0602601F RID: 155679 RVA: 0x0053D45E File Offset: 0x0053B65E
		public string AkEvent { get; set; }

		// Token: 0x06026020 RID: 155680 RVA: 0x0053D467 File Offset: 0x0053B667
		public IRenderBookPageT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.Radius = 0;
			this.CenterTarget = null;
			this.AkEvent = null;
		}
	}
}
