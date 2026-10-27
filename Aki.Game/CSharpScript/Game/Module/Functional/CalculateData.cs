using System;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A20 RID: 23072
	public class CalculateData : ICalculateData
	{
		// Token: 0x17008BD2 RID: 35794
		// (get) Token: 0x0603A841 RID: 239681 RVA: 0x00DECAE0 File Offset: 0x00DEACE0
		// (set) Token: 0x0603A842 RID: 239682 RVA: 0x00DECAE8 File Offset: 0x00DEACE8
		public int TotalGridNumber { get; set; }

		// Token: 0x17008BD3 RID: 35795
		// (get) Token: 0x0603A843 RID: 239683 RVA: 0x00DECAF1 File Offset: 0x00DEACF1
		// (set) Token: 0x0603A844 RID: 239684 RVA: 0x00DECAF9 File Offset: 0x00DEACF9
		public float OffsetWidth { get; set; }

		// Token: 0x17008BD4 RID: 35796
		// (get) Token: 0x0603A845 RID: 239685 RVA: 0x00DECB02 File Offset: 0x00DEAD02
		// (set) Token: 0x0603A846 RID: 239686 RVA: 0x00DECB0A File Offset: 0x00DEAD0A
		public int HorizontalGridNum { get; set; }

		// Token: 0x17008BD5 RID: 35797
		// (get) Token: 0x0603A847 RID: 239687 RVA: 0x00DECB13 File Offset: 0x00DEAD13
		// (set) Token: 0x0603A848 RID: 239688 RVA: 0x00DECB1B File Offset: 0x00DEAD1B
		public int VerticalGridNum { get; set; }
	}
}
