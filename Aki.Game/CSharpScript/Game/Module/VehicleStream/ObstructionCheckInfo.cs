using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x0200381F RID: 14367
	[NullableContext(1)]
	[Nullable(0)]
	public class ObstructionCheckInfo
	{
		// Token: 0x06025528 RID: 152872 RVA: 0x00A8529C File Offset: 0x00A8349C
		public void Reset()
		{
			this.HitChanged = false;
			this.CheckResultType = EObstructionCheckResult.None;
			this.HitDistance = float.MaxValue;
			this.HitEntityCreatureDataId = 0L;
			this.DistanceToKeep = 0f;
			this.HitEntityType = null;
			this.IsPlayer = false;
			this.PlayerHitDistance = 0f;
		}

		// Token: 0x06025529 RID: 152873 RVA: 0x00A852F4 File Offset: 0x00A834F4
		public void DeepCopy(ObstructionCheckInfo info)
		{
			this.CheckResultType = info.CheckResultType;
			this.HitDistance = info.HitDistance;
			this.HitChanged = info.HitChanged;
			this.HitEntityCreatureDataId = info.HitEntityCreatureDataId;
			this.HitEntityType = info.HitEntityType;
			this.DistanceToKeep = info.DistanceToKeep;
			this.IsPlayer = info.IsPlayer;
			this.PlayerHitDistance = info.PlayerHitDistance;
		}

		// Token: 0x0602552A RID: 152874 RVA: 0x00A85361 File Offset: 0x00A83561
		public bool IsHitTargetChanged(ObstructionCheckInfo info)
		{
			return this.CheckResultType != info.CheckResultType || this.HitEntityCreatureDataId != info.HitEntityCreatureDataId;
		}

		// Token: 0x0602552B RID: 152875 RVA: 0x00A85384 File Offset: 0x00A83584
		public void TryUpdateHitDistance(EObstructionCheckResult checkResult, long hitEntityCreatureDataId, EEntityType hitEntityType, float hitDistance, bool bPlayer = false)
		{
			if (hitDistance >= this.HitDistance)
			{
				return;
			}
			this.CheckResultType = checkResult;
			this.HitEntityCreatureDataId = hitEntityCreatureDataId;
			this.HitEntityType = new EEntityType?(hitEntityType);
			this.HitDistance = hitDistance;
			this.IsPlayer = bPlayer;
			switch (checkResult)
			{
			case EObstructionCheckResult.TraceBlock:
				this.DistanceToKeep = (bPlayer ? 5f : 3f);
				return;
			case EObstructionCheckResult.CheckPlayerBlock:
				this.DistanceToKeep = 5f;
				return;
			case EObstructionCheckResult.SameRoadwayVehicleBlock:
				this.DistanceToKeep = 3f;
				return;
			case EObstructionCheckResult.NextRoadwayVehicleBlock:
				this.DistanceToKeep = 6f;
				return;
			default:
				return;
			}
		}

		// Token: 0x04014A7E RID: 84606
		public bool HitChanged;

		// Token: 0x04014A7F RID: 84607
		public EObstructionCheckResult CheckResultType;

		// Token: 0x04014A80 RID: 84608
		public float HitDistance;

		// Token: 0x04014A81 RID: 84609
		public long HitEntityCreatureDataId;

		// Token: 0x04014A82 RID: 84610
		public EEntityType? HitEntityType;

		// Token: 0x04014A83 RID: 84611
		public float DistanceToKeep = 3f;

		// Token: 0x04014A84 RID: 84612
		public bool IsPlayer;

		// Token: 0x04014A85 RID: 84613
		public float PlayerHitDistance;
	}
}
