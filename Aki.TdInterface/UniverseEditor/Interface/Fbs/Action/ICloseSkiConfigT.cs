using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006431 RID: 25649
	public class ICloseSkiConfigT
	{
		// Token: 0x1700BEFC RID: 48892
		// (get) Token: 0x0602C63B RID: 181819 RVA: 0x00617317 File Offset: 0x00615517
		// (set) Token: 0x0602C63C RID: 181820 RVA: 0x0061731F File Offset: 0x0061551F
		public ESkiConfig Type { get; set; }

		// Token: 0x1700BEFD RID: 48893
		// (get) Token: 0x0602C63D RID: 181821 RVA: 0x00617328 File Offset: 0x00615528
		// (set) Token: 0x0602C63E RID: 181822 RVA: 0x00617330 File Offset: 0x00615530
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x0602C63F RID: 181823 RVA: 0x00617339 File Offset: 0x00615539
		public ICloseSkiConfigT()
		{
			this.Type = ESkiConfig.Open;
			this.Target = null;
		}
	}
}
