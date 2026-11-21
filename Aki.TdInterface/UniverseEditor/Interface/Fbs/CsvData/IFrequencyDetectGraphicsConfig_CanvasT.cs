using System;

namespace Aki.UniverseEditor.Interface.Fbs.CsvData
{
	// Token: 0x02004D86 RID: 19846
	public class IFrequencyDetectGraphicsConfig_CanvasT
	{
		// Token: 0x17008DFF RID: 36351
		// (get) Token: 0x0601EC51 RID: 126033 RVA: 0x0044D748 File Offset: 0x0044B948
		// (set) Token: 0x0601EC52 RID: 126034 RVA: 0x0044D750 File Offset: 0x0044B950
		public float Width { get; set; }

		// Token: 0x17008E00 RID: 36352
		// (get) Token: 0x0601EC53 RID: 126035 RVA: 0x0044D759 File Offset: 0x0044B959
		// (set) Token: 0x0601EC54 RID: 126036 RVA: 0x0044D761 File Offset: 0x0044B961
		public float Height { get; set; }

		// Token: 0x0601EC55 RID: 126037 RVA: 0x0044D76A File Offset: 0x0044B96A
		public IFrequencyDetectGraphicsConfig_CanvasT()
		{
			this.Width = 0f;
			this.Height = 0f;
		}
	}
}
