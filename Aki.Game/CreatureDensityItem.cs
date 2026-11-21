using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

// Token: 0x02002A6D RID: 10861
[NullableContext(1)]
[Nullable(0)]
public class CreatureDensityItem
{
	// Token: 0x0601B8D0 RID: 112848 RVA: 0x0087D1F4 File Offset: 0x0087B3F4
	public CreatureDensityItem(long creatureDataId, int densityLevel, EntityPb entityData)
	{
		this.CreatureDataId = creatureDataId;
		this.DensityLevel = densityLevel;
		this.EntityData = entityData;
	}

	// Token: 0x0400EE0A RID: 60938
	[Nullable(2)]
	public EntityHandle EntityHandle;

	// Token: 0x0400EE0B RID: 60939
	public readonly long CreatureDataId;

	// Token: 0x0400EE0C RID: 60940
	public int DensityLevel;

	// Token: 0x0400EE0D RID: 60941
	public readonly EntityPb EntityData;
}
