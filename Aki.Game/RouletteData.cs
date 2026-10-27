using System;
using System.Runtime.CompilerServices;

// Token: 0x0200292A RID: 10538
public class RouletteData
{
	// Token: 0x06015C07 RID: 89095 RVA: 0x0057C900 File Offset: 0x0057AB00
	[NullableContext(1)]
	public RouletteData DeepCopy()
	{
		return new RouletteData
		{
			DataIndex = this.DataIndex,
			GridIndex = this.GridIndex,
			GridType = this.GridType,
			Id = this.Id,
			Name = this.Name,
			State = this.State,
			ShowIndex = this.ShowIndex,
			ShowRedDot = this.ShowRedDot,
			UseType = this.UseType
		};
	}

	// Token: 0x0400A1FE RID: 41470
	public int Id;

	// Token: 0x0400A1FF RID: 41471
	public bool ShowIndex;

	// Token: 0x0400A200 RID: 41472
	public int GridIndex;

	// Token: 0x0400A201 RID: 41473
	public ERouletteGridType GridType;

	// Token: 0x0400A202 RID: 41474
	public bool ShowNum;

	// Token: 0x0400A203 RID: 41475
	public int DataNum;

	// Token: 0x0400A204 RID: 41476
	public int DataIndex;

	// Token: 0x0400A205 RID: 41477
	[Nullable(2)]
	public string Name;

	// Token: 0x0400A206 RID: 41478
	public EGridBehavior State = EGridBehavior.Normal;

	// Token: 0x0400A207 RID: 41479
	public bool ShowRedDot = true;

	// Token: 0x0400A208 RID: 41480
	public EGridUseType UseType;
}
