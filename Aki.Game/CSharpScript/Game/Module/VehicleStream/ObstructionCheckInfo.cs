using System;
using System.Runtime.CompilerServices;
using Aki.Protocol;

namespace CSharpScript.Game.Module.VehicleStream
{
	// Token: 0x020048A8 RID: 18600
	[NullableContext(1)]
	[Nullable(0)]
	public class ObstructionCheckInfo
	{
		// Token: 0x060309FC RID: 199164 RVA: 0x00B4A494 File Offset: 0x00B48694
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

		// Token: 0x060309FD RID: 199165 RVA: 0x00B4A4EC File Offset: 0x00B486EC
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

		// Token: 0x060309FE RID: 199166 RVA: 0x00B4A559 File Offset: 0x00B48759
		public bool IsHitTargetChanged(ObstructionCheckInfo info)
		{
			return this.CheckResultType != info.CheckResultType || this.HitEntityCreatureDataId != info.HitEntityCreatureDataId;
		}

		// Token: 0x060309FF RID: 199167 RVA: 0x00B4A57C File Offset: 0x00B4877C
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

		// Token: 0x0401A20B RID: 107019
		public bool HitChanged;

		// Token: 0x0401A20C RID: 107020
		public EObstructionCheckResult CheckResultType;

		// Token: 0x0401A20D RID: 107021
		public float HitDistance;

		// Token: 0x0401A20E RID: 107022
		public long HitEntityCreatureDataId;

		// Token: 0x0401A20F RID: 107023
		public EEntityType? HitEntityType;

		// Token: 0x0401A210 RID: 107024
		public float DistanceToKeep = 3f;

		// Token: 0x0401A211 RID: 107025
		public bool IsPlayer;

		// Token: 0x0401A212 RID: 107026
		public float PlayerHitDistance;
	}
}
