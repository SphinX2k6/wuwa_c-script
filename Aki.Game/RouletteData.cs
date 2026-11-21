using System;
using System.Runtime.CompilerServices;

// Token: 0x02001EA5 RID: 7845
public class RouletteData
{
	// Token: 0x0601360C RID: 79372 RVA: 0x005A7940 File Offset: 0x005A5B40
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

	// Token: 0x0400A5E9 RID: 42473
	public int Id;

	// Token: 0x0400A5EA RID: 42474
	public bool ShowIndex;

	// Token: 0x0400A5EB RID: 42475
	public int GridIndex;

	// Token: 0x0400A5EC RID: 42476
	public ERouletteGridType GridType;

	// Token: 0x0400A5ED RID: 42477
	public bool ShowNum;

	// Token: 0x0400A5EE RID: 42478
	public int DataNum;

	// Token: 0x0400A5EF RID: 42479
	public int DataIndex;

	// Token: 0x0400A5F0 RID: 42480
	[Nullable(2)]
	public string Name;

	// Token: 0x0400A5F1 RID: 42481
	public EGridBehavior State = EGridBehavior.Normal;

	// Token: 0x0400A5F2 RID: 42482
	public bool ShowRedDot = true;

	// Token: 0x0400A5F3 RID: 42483
	public EGridUseType UseType;
}
