using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005844 RID: 22596
	public class IRenderFlowerBridgeT
	{
		// Token: 0x1700A8D3 RID: 43219
		// (get) Token: 0x0602604D RID: 155725 RVA: 0x0053DB3B File Offset: 0x0053BD3B
		// (set) Token: 0x0602604E RID: 155726 RVA: 0x0053DB43 File Offset: 0x0053BD43
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700A8D4 RID: 43220
		// (get) Token: 0x0602604F RID: 155727 RVA: 0x0053DB4C File Offset: 0x0053BD4C
		// (set) Token: 0x06026050 RID: 155728 RVA: 0x0053DB54 File Offset: 0x0053BD54
		public int Radius { get; set; }

		// Token: 0x1700A8D5 RID: 43221
		// (get) Token: 0x06026051 RID: 155729 RVA: 0x0053DB5D File Offset: 0x0053BD5D
		// (set) Token: 0x06026052 RID: 155730 RVA: 0x0053DB65 File Offset: 0x0053BD65
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700A8D6 RID: 43222
		// (get) Token: 0x06026053 RID: 155731 RVA: 0x0053DB6E File Offset: 0x0053BD6E
		// (set) Token: 0x06026054 RID: 155732 RVA: 0x0053DB76 File Offset: 0x0053BD76
		public string AkEvent { get; set; }

		// Token: 0x06026055 RID: 155733 RVA: 0x0053DB7F File Offset: 0x0053BD7F
		public IRenderFlowerBridgeT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.Radius = 0;
			this.CenterTarget = null;
			this.AkEvent = null;
		}
	}
}
