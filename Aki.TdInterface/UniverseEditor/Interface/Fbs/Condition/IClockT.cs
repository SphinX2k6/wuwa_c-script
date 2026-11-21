using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005068 RID: 20584
	public class IClockT
	{
		// Token: 0x17009353 RID: 37715
		// (get) Token: 0x060202F1 RID: 131825 RVA: 0x0047655C File Offset: 0x0047475C
		// (set) Token: 0x060202F2 RID: 131826 RVA: 0x00476564 File Offset: 0x00474764
		public EVisibleCondition Type { get; set; }

		// Token: 0x17009354 RID: 37716
		// (get) Token: 0x060202F3 RID: 131827 RVA: 0x0047656D File Offset: 0x0047476D
		// (set) Token: 0x060202F4 RID: 131828 RVA: 0x00476575 File Offset: 0x00474775
		public ECompare Compare { get; set; }

		// Token: 0x17009355 RID: 37717
		// (get) Token: 0x060202F5 RID: 131829 RVA: 0x0047657E File Offset: 0x0047477E
		// (set) Token: 0x060202F6 RID: 131830 RVA: 0x00476586 File Offset: 0x00474786
		public int Start { get; set; }

		// Token: 0x17009356 RID: 37718
		// (get) Token: 0x060202F7 RID: 131831 RVA: 0x0047658F File Offset: 0x0047478F
		// (set) Token: 0x060202F8 RID: 131832 RVA: 0x00476597 File Offset: 0x00474797
		public int End { get; set; }

		// Token: 0x060202F9 RID: 131833 RVA: 0x004765A0 File Offset: 0x004747A0
		public IClockT()
		{
			this.Type = EVisibleCondition.Weather;
			this.Compare = ECompare.Eq;
			this.Start = 0;
			this.End = 0;
		}
	}
}
