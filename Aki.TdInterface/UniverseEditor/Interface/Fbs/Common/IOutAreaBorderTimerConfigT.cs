using System;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x0200645C RID: 25692
	public class IOutAreaBorderTimerConfigT
	{
		// Token: 0x1700BDAB RID: 48555
		// (get) Token: 0x0602BA9C RID: 178844 RVA: 0x005F1749 File Offset: 0x005EF949
		// (set) Token: 0x0602BA9D RID: 178845 RVA: 0x005F1751 File Offset: 0x005EF951
		public EOutAreaBorderType Type { get; set; }

		// Token: 0x1700BDAC RID: 48556
		// (get) Token: 0x0602BA9E RID: 178846 RVA: 0x005F175A File Offset: 0x005EF95A
		// (set) Token: 0x0602BA9F RID: 178847 RVA: 0x005F1762 File Offset: 0x005EF962
		public float OutAreaBorderTime { get; set; }

		// Token: 0x1700BDAD RID: 48557
		// (get) Token: 0x0602BAA0 RID: 178848 RVA: 0x005F176B File Offset: 0x005EF96B
		// (set) Token: 0x0602BAA1 RID: 178849 RVA: 0x005F1773 File Offset: 0x005EF973
		public int TeleportTransitionConfigId { get; set; }

		// Token: 0x1700BDAE RID: 48558
		// (get) Token: 0x0602BAA2 RID: 178850 RVA: 0x005F177C File Offset: 0x005EF97C
		// (set) Token: 0x0602BAA3 RID: 178851 RVA: 0x005F1784 File Offset: 0x005EF984
		public IOutAreaBorderDownTimeTextTipT OutAreaBorderTipOption { get; set; }

		// Token: 0x1700BDAF RID: 48559
		// (get) Token: 0x0602BAA4 RID: 178852 RVA: 0x005F178D File Offset: 0x005EF98D
		// (set) Token: 0x0602BAA5 RID: 178853 RVA: 0x005F1795 File Offset: 0x005EF995
		public IOutAreaBorderBuffEffectT OutAreaBorderEffectOption { get; set; }

		// Token: 0x0602BAA6 RID: 178854 RVA: 0x005F179E File Offset: 0x005EF99E
		public IOutAreaBorderTimerConfigT()
		{
			this.Type = EOutAreaBorderType.TeleportTimer;
			this.OutAreaBorderTime = 0f;
			this.TeleportTransitionConfigId = 0;
			this.OutAreaBorderTipOption = null;
			this.OutAreaBorderEffectOption = null;
		}
	}
}
