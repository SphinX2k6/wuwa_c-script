using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x020034F8 RID: 13560
[NullableContext(1)]
[Nullable(0)]
public class CreatureDensityItem
{
	// Token: 0x0601DBB9 RID: 121785 RVA: 0x00854DA0 File Offset: 0x00852FA0
	public CreatureDensityItem(long creatureDataId, int densityLevel, EntityPb entityData)
	{
		this.CreatureDataId = creatureDataId;
		this.DensityLevel = densityLevel;
		this.EntityData = entityData;
	}

	// Token: 0x0400E94F RID: 59727
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400E950 RID: 59728
	public readonly long CreatureDataId;

	// Token: 0x0400E951 RID: 59729
	public int DensityLevel;

	// Token: 0x0400E952 RID: 59730
	public readonly EntityPb EntityData;
}
