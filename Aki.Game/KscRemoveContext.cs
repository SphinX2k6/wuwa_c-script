using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.KuroSimpleCombat;
using UnrealEngine;

// Token: 0x02000336 RID: 822
[NullableContext(1)]
[Nullable(0)]
public class KscRemoveContext
{
	// Token: 0x06002E4D RID: 11853 RVA: 0x00110474 File Offset: 0x0010E674
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

	// Token: 0x06002E4E RID: 11854 RVA: 0x00110544 File Offset: 0x0010E744
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

	// Token: 0x04002A05 RID: 10757
	public long CreatureDataId;

	// Token: 0x04002A06 RID: 10758
	public long KillerId;

	// Token: 0x04002A07 RID: 10759
	public FName? KillerType;

	// Token: 0x04002A08 RID: 10760
	public bool IsPreview;

	// Token: 0x04002A09 RID: 10761
	public Vector Location = Vector.Create();

	// Token: 0x04002A0A RID: 10762
	public FName ReasonName;

	// Token: 0x04002A0B RID: 10763
	public bool ClearCell;

	// Token: 0x04002A0C RID: 10764
	public int EffectRange;

	// Token: 0x04002A0D RID: 10765
	public int FireNum;

	// Token: 0x04002A0E RID: 10766
	[Nullable(2)]
	public TMap<EKSC_AttrType, int> Params;
}
