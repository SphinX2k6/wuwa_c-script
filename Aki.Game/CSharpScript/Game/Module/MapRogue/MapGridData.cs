using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055A2 RID: 21922
	[NullableContext(1)]
	[Nullable(0)]
	public class MapGridData : IPathNode
	{
		// Token: 0x17008681 RID: 34433
		// (get) Token: 0x06037DFB RID: 228859 RVA: 0x00D3D983 File Offset: 0x00D3BB83
		// (set) Token: 0x06037DFC RID: 228860 RVA: 0x00D3D98B File Offset: 0x00D3BB8B
		public int GridIndex { get; set; }

		// Token: 0x17008682 RID: 34434
		// (get) Token: 0x06037DFD RID: 228861 RVA: 0x00D3D994 File Offset: 0x00D3BB94
		// (set) Token: 0x06037DFE RID: 228862 RVA: 0x00D3D99C File Offset: 0x00D3BB9C
		public int Cost { get; set; }

		// Token: 0x17008683 RID: 34435
		// (get) Token: 0x06037DFF RID: 228863 RVA: 0x00D3D9A5 File Offset: 0x00D3BBA5
		// (set) Token: 0x06037E00 RID: 228864 RVA: 0x00D3D9AD File Offset: 0x00D3BBAD
		public bool Walkable { get; set; }

		// Token: 0x06037E01 RID: 228865 RVA: 0x00D3D9B8 File Offset: 0x00D3BBB8
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

		// Token: 0x06037E02 RID: 228866 RVA: 0x00D3DB28 File Offset: 0x00D3BD28
		public bool HasEvent(bool? hasVision = null)
		{
			return (hasVision ?? this.HasVision) && !this.IsExplore && this.GridEventId != 0;
		}

		// Token: 0x06037E03 RID: 228867 RVA: 0x00D3DB66 File Offset: 0x00D3BD66
		public bool IsValid()
		{
			return this.GridId != 0;
		}

		// Token: 0x06037E04 RID: 228868 RVA: 0x00D3DB71 File Offset: 0x00D3BD71
		public bool NeedTriggerEvent()
		{
			return !this.IsExplore && this.GridEventId != 0;
		}

		// Token: 0x06037E05 RID: 228869 RVA: 0x00D3DB86 File Offset: 0x00D3BD86
		public bool IsUnlock()
		{
			return this.ConditionInfo == null || this.ConditionInfo.Id == 0 || this.ConditionInfo.Current >= this.ConditionInfo.Target;
		}

		// Token: 0x0401D59F RID: 120223
		public int GridId;

		// Token: 0x0401D5A1 RID: 120225
		public int GridTypeId;

		// Token: 0x0401D5A2 RID: 120226
		public int GroundPathIndex;

		// Token: 0x0401D5A3 RID: 120227
		public int ExtraPathIndex = -1;

		// Token: 0x0401D5A4 RID: 120228
		public int GridEventId;

		// Token: 0x0401D5A5 RID: 120229
		public EGridEventType GridEventType;

		// Token: 0x0401D5A6 RID: 120230
		public int EventType = -1;

		// Token: 0x0401D5A8 RID: 120232
		public int WalkCost;

		// Token: 0x0401D5A9 RID: 120233
		public int EventCost;

		// Token: 0x0401D5AA RID: 120234
		public bool IsExplore;

		// Token: 0x0401D5AB RID: 120235
		public bool HasVision;

		// Token: 0x0401D5AC RID: 120236
		public bool IsBlock;

		// Token: 0x0401D5AE RID: 120238
		public int Lv;

		// Token: 0x0401D5AF RID: 120239
		public int ToleranceLv;

		// Token: 0x0401D5B0 RID: 120240
		public int SkipBattleLv;

		// Token: 0x0401D5B1 RID: 120241
		public bool CanSkipBattle;

		// Token: 0x0401D5B2 RID: 120242
		public List<int> OccupiedEffectIdList = new List<int>();

		// Token: 0x0401D5B3 RID: 120243
		public List<int> RewardItemIdList = new List<int>();

		// Token: 0x0401D5B4 RID: 120244
		[Nullable(2)]
		public CondInfo ConditionInfo;
	}
}
