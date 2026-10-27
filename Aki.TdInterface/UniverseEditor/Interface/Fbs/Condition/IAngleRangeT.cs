using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200496B RID: 18795
	public class IAngleRangeT
	{
		// Token: 0x170087C9 RID: 34761
		// (get) Token: 0x0601D4B2 RID: 119986 RVA: 0x00421E60 File Offset: 0x00420060
		// (set) Token: 0x0601D4B3 RID: 119987 RVA: 0x00421E68 File Offset: 0x00420068
		public float Min { get; set; }

		// Token: 0x170087CA RID: 34762
		// (get) Token: 0x0601D4B4 RID: 119988 RVA: 0x00421E71 File Offset: 0x00420071
		// (set) Token: 0x0601D4B5 RID: 119989 RVA: 0x00421E79 File Offset: 0x00420079
		public float Max { get; set; }

		// Token: 0x0601D4B6 RID: 119990 RVA: 0x00421E82 File Offset: 0x00420082
		public IAngleRangeT()
		{
			this.Min = 0f;
			this.Max = 0f;
		}
	}
}
