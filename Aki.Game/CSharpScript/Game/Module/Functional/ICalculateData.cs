using System;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x02005A1F RID: 23071
	public interface ICalculateData
	{
		// Token: 0x17008BCE RID: 35790
		// (get) Token: 0x0603A839 RID: 239673
		// (set) Token: 0x0603A83A RID: 239674
		int TotalGridNumber { get; set; }

		// Token: 0x17008BCF RID: 35791
		// (get) Token: 0x0603A83B RID: 239675
		// (set) Token: 0x0603A83C RID: 239676
		float OffsetWidth { get; set; }

		// Token: 0x17008BD0 RID: 35792
		// (get) Token: 0x0603A83D RID: 239677
		// (set) Token: 0x0603A83E RID: 239678
		int HorizontalGridNum { get; set; }

		// Token: 0x17008BD1 RID: 35793
		// (get) Token: 0x0603A83F RID: 239679
		// (set) Token: 0x0603A840 RID: 239680
		int VerticalGridNum { get; set; }
	}
}
