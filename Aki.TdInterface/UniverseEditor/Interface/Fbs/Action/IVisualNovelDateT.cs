using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007578 RID: 30072
	public class IVisualNovelDateT
	{
		// Token: 0x1700E417 RID: 58391
		// (get) Token: 0x06036B5E RID: 224094 RVA: 0x0076DBF0 File Offset: 0x0076BDF0
		// (set) Token: 0x06036B5F RID: 224095 RVA: 0x0076DBF8 File Offset: 0x0076BDF8
		public int Month { get; set; }

		// Token: 0x1700E418 RID: 58392
		// (get) Token: 0x06036B60 RID: 224096 RVA: 0x0076DC01 File Offset: 0x0076BE01
		// (set) Token: 0x06036B61 RID: 224097 RVA: 0x0076DC09 File Offset: 0x0076BE09
		public int Day { get; set; }

		// Token: 0x06036B62 RID: 224098 RVA: 0x0076DC12 File Offset: 0x0076BE12
		public IVisualNovelDateT()
		{
			this.Month = 0;
			this.Day = 0;
		}
	}
}
