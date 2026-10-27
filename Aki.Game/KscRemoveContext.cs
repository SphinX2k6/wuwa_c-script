using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000E81 RID: 3713
[NullableContext(1)]
[Nullable(0)]
public class KscRemoveContext
{
	// Token: 0x06005AB6 RID: 23222 RVA: 0x001087C4 File Offset: 0x001069C4
	public void InitFromRemoveContext(FKSC_RemoveContext context, Dictionary<int, KscEntityHandle> entities)
	{
		KscEntityHandle kscEntityHandle;
		this.CreatureDataId = (entities.TryGetValue(context.EntityId, out kscEntityHandle) ? kscEntityHandle.CreatureDataId : 0L);
		KscEntityHandle kscEntityHandle2;
		this.KillerId = (entities.TryGetValue(context.EntityIdKillBy, out kscEntityHandle2) ? kscEntityHandle2.CreatureDataId : 0L);
		this.KillerType = FNameUtil.GetDynamicFName(context.EntityTypeKillBy.ToString());
		this.IsPreview = context.IsPreview;
		Vector location = this.Location;
		FVectorDouble location2 = context.Location;
		location.DeepCopy(location2);
		this.ReasonName = FNameUtil.GetDynamicFName(context.ReasonName.ToString()).Value;
		this.ClearCell = false;
		this.EffectRange = 0;
		this.FireNum = 0;
		this.Params = null;
	}

	// Token: 0x06005AB7 RID: 23223 RVA: 0x00108894 File Offset: 0x00106A94
	public void InitFromLandFireContext(FKSC_LandFireContext context, Dictionary<int, KscEntityHandle> entities)
	{
		KscEntityHandle kscEntityHandle;
		this.CreatureDataId = (entities.TryGetValue(context.SpawnerEntityId, out kscEntityHandle) ? kscEntityHandle.CreatureDataId : 0L);
		this.KillerId = this.CreatureDataId;
		this.KillerType = null;
		this.IsPreview = false;
		this.Location.Set(0.0, 0.0, 0.0);
		this.ReasonName = KscData.landFireRemoveReason;
		this.ClearCell = context.ClearCell;
		this.EffectRange = context.EffectRange;
		this.FireNum = context.FireNum;
		this.Params = context.Params;
	}

	// Token: 0x0400296A RID: 10602
	public long CreatureDataId;

	// Token: 0x0400296B RID: 10603
	public long KillerId;

	// Token: 0x0400296C RID: 10604
	public FName? KillerType;

	// Token: 0x0400296D RID: 10605
	public bool IsPreview;

	// Token: 0x0400296E RID: 10606
	public Vector Location = Vector.Create();

	// Token: 0x0400296F RID: 10607
	public FName ReasonName;

	// Token: 0x04002970 RID: 10608
	public bool ClearCell;

	// Token: 0x04002971 RID: 10609
	public int EffectRange;

	// Token: 0x04002972 RID: 10610
	public int FireNum;

	// Token: 0x04002973 RID: 10611
	[Nullable(2)]
	public TMap<EKSC_AttrType, int> Params;
}
