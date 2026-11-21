using System;

namespace CSharpScript.Game.Module.Functional
{
	// Token: 0x020049FB RID: 18939
	public interface ICalculateData
	{
		// Token: 0x17005F9C RID: 24476
		// (get) Token: 0x0602F782 RID: 194434
		// (set) Token: 0x0602F783 RID: 194435
		int TotalGridNumber { get; set; }

		// Token: 0x17005F9D RID: 24477
		// (get) Token: 0x0602F784 RID: 194436
		// (set) Token: 0x0602F785 RID: 194437
		float OffsetWidth { get; set; }

		// Token: 0x17005F9E RID: 24478
		// (get) Token: 0x0602F786 RID: 194438
		// (set) Token: 0x0602F787 RID: 194439
		int HorizontalGridNum { get; set; }

		// Token: 0x17005F9F RID: 24479
		// (get) Token: 0x0602F788 RID: 194440
		// (set) Token: 0x0602F789 RID: 194441
		int VerticalGridNum { get; set; }
	}
}
