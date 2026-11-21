using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.CreatureTools;
using AkiClient.Game.Aki.Data.Fight.UI;
using UnrealEngine;

// Token: 0x020017DF RID: 6111
[NullableContext(2)]
[Nullable(0)]
public class PanelQteContext
{
	// Token: 0x0600EF4E RID: 61262 RVA: 0x004641C8 File Offset: 0x004623C8
	public Entity GetSourceEntity()
	{
		if (this.IsInitSourceEntity)
		{
			EntityHandle sourceEntityHandle = this.SourceEntityHandle;
			if (sourceEntityHandle == null || !sourceEntityHandle.Valid)
			{
				this.SourceEntityHandle = null;
				return null;
			}
			return this.SourceEntityHandle.Entity;
		}
		else
		{
			this.IsInitSourceEntity = true;
			if (this.SourceActor == null)
			{
				return null;
			}
			if (!(this.SourceActor is IBPI_CreatureInterface_C))
			{
				return null;
			}
			IBPI_CreatureInterface_C ibpi_CreatureInterface_C = this.SourceActor as IBPI_CreatureInterface_C;
			int? num = (ibpi_CreatureInterface_C != null) ? new int?(ibpi_CreatureInterface_C.GetEntityId()) : null;
			if (num == null)
			{
				return null;
			}
			this.SourceEntityHandle = CharacterModel.Instance.GetHandle(num.Value);
			EntityHandle sourceEntityHandle2 = this.SourceEntityHandle;
			if (sourceEntityHandle2 == null)
			{
				return null;
			}
			return sourceEntityHandle2.Entity;
		}
	}

	// Token: 0x04008736 RID: 34614
	public EPanelQteSource? Source;

	// Token: 0x04008737 RID: 34615
	public int QteId;

	// Token: 0x04008738 RID: 34616
	public int QteHandleId;

	// Token: 0x04008739 RID: 34617
	public USkeletalMeshComponent SourceMeshComp;

	// Token: 0x0400873A RID: 34618
	public long? SourceBuffId;

	// Token: 0x0400873B RID: 34619
	public int SourceBuffHandleId;

	// Token: 0x0400873C RID: 34620
	public AActor SourceActor;

	// Token: 0x0400873D RID: 34621
	public bool IsInitSourceEntity;

	// Token: 0x0400873E RID: 34622
	public EntityHandle SourceEntityHandle;

	// Token: 0x0400873F RID: 34623
	public SPanelQte Config;

	// Token: 0x04008740 RID: 34624
	public long? PreMessageId;

	// Token: 0x04008741 RID: 34625
	public bool Success;

	// Token: 0x04008742 RID: 34626
	public int BuffIndex = -1;
}
