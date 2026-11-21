using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005E4E RID: 24142
	public class IRenderFlowerBridgeT
	{
		// Token: 0x1700B1FE RID: 45566
		// (get) Token: 0x06028594 RID: 165268 RVA: 0x0058439F File Offset: 0x0058259F
		// (set) Token: 0x06028595 RID: 165269 RVA: 0x005843A7 File Offset: 0x005825A7
		public ERenderSpecifiedRangeType Type { get; set; }

		// Token: 0x1700B1FF RID: 45567
		// (get) Token: 0x06028596 RID: 165270 RVA: 0x005843B0 File Offset: 0x005825B0
		// (set) Token: 0x06028597 RID: 165271 RVA: 0x005843B8 File Offset: 0x005825B8
		public int Radius { get; set; }

		// Token: 0x1700B200 RID: 45568
		// (get) Token: 0x06028598 RID: 165272 RVA: 0x005843C1 File Offset: 0x005825C1
		// (set) Token: 0x06028599 RID: 165273 RVA: 0x005843C9 File Offset: 0x005825C9
		public TTargetEntityUnion CenterTarget { get; set; }

		// Token: 0x1700B201 RID: 45569
		// (get) Token: 0x0602859A RID: 165274 RVA: 0x005843D2 File Offset: 0x005825D2
		// (set) Token: 0x0602859B RID: 165275 RVA: 0x005843DA File Offset: 0x005825DA
		public string AkEvent { get; set; }

		// Token: 0x0602859C RID: 165276 RVA: 0x005843E3 File Offset: 0x005825E3
		public IRenderFlowerBridgeT()
		{
			this.Type = ERenderSpecifiedRangeType.FlowerBridge;
			this.Radius = 0;
			this.CenterTarget = null;
			this.AkEvent = null;
		}
	}
}
