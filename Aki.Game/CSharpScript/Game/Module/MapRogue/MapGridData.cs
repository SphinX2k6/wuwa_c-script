using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004578 RID: 17784
	[NullableContext(1)]
	[Nullable(0)]
	public class MapGridData : IPathNode
	{
		// Token: 0x17005A48 RID: 23112
		// (get) Token: 0x0602CCF9 RID: 183545 RVA: 0x00C8B6CB File Offset: 0x00C898CB
		// (set) Token: 0x0602CCFA RID: 183546 RVA: 0x00C8B6D3 File Offset: 0x00C898D3
		public int GridIndex { get; set; }

		// Token: 0x17005A49 RID: 23113
		// (get) Token: 0x0602CCFB RID: 183547 RVA: 0x00C8B6DC File Offset: 0x00C898DC
		// (set) Token: 0x0602CCFC RID: 183548 RVA: 0x00C8B6E4 File Offset: 0x00C898E4
		public int Cost { get; set; }

		// Token: 0x17005A4A RID: 23114
		// (get) Token: 0x0602CCFD RID: 183549 RVA: 0x00C8B6ED File Offset: 0x00C898ED
		// (set) Token: 0x0602CCFE RID: 183550 RVA: 0x00C8B6F5 File Offset: 0x00C898F5
		public bool Walkable { get; set; }

		// Token: 0x0602CCFF RID: 183551 RVA: 0x00C8B700 File Offset: 0x00C89900
		public void RefreshByServer(RogueResGridData data)
		{
			this.GridId = data.ConfigId;
			this.WalkCost = data.Cost;
			this.EventCost = data.EventCost;
			this.IsExplore = data.IsExplore;
			this.HasVision = data.HasVision;
			this.IsBlock = data.IsBlock;
			this.Walkable = (data.HasVision && !data.IsBlock);
			this.GridTypeId = data.MapType;
			this.GridEventId = data.EventId;
			this.Lv = data.RecommondLevel;
			this.OccupiedEffectIdList.Clear();
			this.OccupiedEffectIdList.AddRange(data.CaptureEffects);
			this.RewardItemIdList.Clear();
			this.RewardItemIdList.AddRange(data.PreAward);
			this.ConditionInfo = data.CondInfo;
			this.ToleranceLv = data.RecommondLevelRange;
			this.SkipBattleLv = data.SkipBattleLv;
			this.CanSkipBattle = data.CanSkipBattle;
			RogueResGridEvent? gridEventConfigById = MapRogueConfig.Instance.GetGridEventConfigById(this.GridEventId);
			this.EventType = ((gridEventConfigById != null) ? gridEventConfigById.GetValueOrDefault().EventType : -1);
			this.GridEventType = (EGridEventType)((gridEventConfigById != null) ? gridEventConfigById.Value.ShowType : 0);
			this.Cost = (this.HasEvent(null) ? 1000000 : 1);
		}

		// Token: 0x0602CD00 RID: 183552 RVA: 0x00C8B870 File Offset: 0x00C89A70
		public bool HasEvent(bool? hasVision = null)
		{
			return (hasVision ?? this.HasVision) && !this.IsExplore && this.GridEventId != 0;
		}

		// Token: 0x0602CD01 RID: 183553 RVA: 0x00C8B8AE File Offset: 0x00C89AAE
		public bool IsValid()
		{
			return this.GridId != 0;
		}

		// Token: 0x0602CD02 RID: 183554 RVA: 0x00C8B8B9 File Offset: 0x00C89AB9
		public bool NeedTriggerEvent()
		{
			return !this.IsExplore && this.GridEventId != 0;
		}

		// Token: 0x0602CD03 RID: 183555 RVA: 0x00C8B8CE File Offset: 0x00C89ACE
		public bool IsUnlock()
		{
			return this.ConditionInfo == null || this.ConditionInfo.Id == 0 || this.ConditionInfo.Current >= this.ConditionInfo.Target;
		}

		// Token: 0x0401802A RID: 98346
		public int GridId;

		// Token: 0x0401802C RID: 98348
		public int GridTypeId;

		// Token: 0x0401802D RID: 98349
		public int GroundPathIndex;

		// Token: 0x0401802E RID: 98350
		public int ExtraPathIndex = -1;

		// Token: 0x0401802F RID: 98351
		public int GridEventId;

		// Token: 0x04018030 RID: 98352
		public EGridEventType GridEventType;

		// Token: 0x04018031 RID: 98353
		public int EventType = -1;

		// Token: 0x04018033 RID: 98355
		public int WalkCost;

		// Token: 0x04018034 RID: 98356
		public int EventCost;

		// Token: 0x04018035 RID: 98357
		public bool IsExplore;

		// Token: 0x04018036 RID: 98358
		public bool HasVision;

		// Token: 0x04018037 RID: 98359
		public bool IsBlock;

		// Token: 0x04018039 RID: 98361
		public int Lv;

		// Token: 0x0401803A RID: 98362
		public int ToleranceLv;

		// Token: 0x0401803B RID: 98363
		public int SkipBattleLv;

		// Token: 0x0401803C RID: 98364
		public bool CanSkipBattle;

		// Token: 0x0401803D RID: 98365
		public List<int> OccupiedEffectIdList = new List<int>();

		// Token: 0x0401803E RID: 98366
		public List<int> RewardItemIdList = new List<int>();

		// Token: 0x0401803F RID: 98367
		[Nullable(2)]
		public CondInfo ConditionInfo;
	}
}
