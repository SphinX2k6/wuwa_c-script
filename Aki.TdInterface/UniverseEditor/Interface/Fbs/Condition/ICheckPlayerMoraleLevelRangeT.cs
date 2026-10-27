using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AF4 RID: 19188
	public class ICheckPlayerMoraleLevelRangeT
	{
		// Token: 0x17008B23 RID: 35619
		// (get) Token: 0x0601E27C RID: 123516 RVA: 0x0043A9A2 File Offset: 0x00438BA2
		// (set) Token: 0x0601E27D RID: 123517 RVA: 0x0043A9AA File Offset: 0x00438BAA
		public ECondition Type { get; set; }

		// Token: 0x17008B24 RID: 35620
		// (get) Token: 0x0601E27E RID: 123518 RVA: 0x0043A9B3 File Offset: 0x00438BB3
		// (set) Token: 0x0601E27F RID: 123519 RVA: 0x0043A9BB File Offset: 0x00438BBB
		public int MinMoraleLevel { get; set; }

		// Token: 0x17008B25 RID: 35621
		// (get) Token: 0x0601E280 RID: 123520 RVA: 0x0043A9C4 File Offset: 0x00438BC4
		// (set) Token: 0x0601E281 RID: 123521 RVA: 0x0043A9CC File Offset: 0x00438BCC
		public int MaxMoraleLevel { get; set; }

		// Token: 0x0601E282 RID: 123522 RVA: 0x0043A9D5 File Offset: 0x00438BD5
		public ICheckPlayerMoraleLevelRangeT()
		{
			this.Type = ECondition.CompareVar;
			this.MinMoraleLevel = 0;
			this.MaxMoraleLevel = 0;
		}
	}
}
