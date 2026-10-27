using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.CreatureTools;
using AkiClient.Game.Aki.Data.Fight.UI;
using UnrealEngine;

// Token: 0x020022FB RID: 8955
[NullableContext(2)]
[Nullable(0)]
public class PanelQteContext
{
	// Token: 0x06011AB6 RID: 72374 RVA: 0x004574E8 File Offset: 0x004556E8
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

	// Token: 0x040085F8 RID: 34296
	public EPanelQteSource? Source;

	// Token: 0x040085F9 RID: 34297
	public int QteId;

	// Token: 0x040085FA RID: 34298
	public int QteHandleId;

	// Token: 0x040085FB RID: 34299
	public USkeletalMeshComponent SourceMeshComp;

	// Token: 0x040085FC RID: 34300
	public long? SourceBuffId;

	// Token: 0x040085FD RID: 34301
	public int SourceBuffHandleId;

	// Token: 0x040085FE RID: 34302
	public AActor SourceActor;

	// Token: 0x040085FF RID: 34303
	public bool IsInitSourceEntity;

	// Token: 0x04008600 RID: 34304
	public EntityHandle SourceEntityHandle;

	// Token: 0x04008601 RID: 34305
	public SPanelQte Config;

	// Token: 0x04008602 RID: 34306
	public long? PreMessageId;

	// Token: 0x04008603 RID: 34307
	public bool Success;

	// Token: 0x04008604 RID: 34308
	public int BuffIndex = -1;
}
