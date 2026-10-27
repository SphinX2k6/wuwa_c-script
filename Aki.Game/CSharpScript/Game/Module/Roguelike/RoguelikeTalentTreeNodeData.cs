using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D86 RID: 19846
	public class RoguelikeTalentTreeNodeData
	{
		// Token: 0x060334D7 RID: 210135 RVA: 0x00BF973B File Offset: 0x00BF793B
		public RoguelikeTalentTreeNodeData(int id)
		{
			this.Id = id;
		}

		// Token: 0x17007E82 RID: 32386
		// (get) Token: 0x060334D8 RID: 210136 RVA: 0x00BF974A File Offset: 0x00BF794A
		public RogueTalentTree Config
		{
			get
			{
				if (this.ConfigInternal == null)
				{
					this.ConfigInternal = RoguelikeConfig.Instance.GetRogueTalentTreeById(this.Id);
				}
				return this.ConfigInternal.Value;
			}
		}

		// Token: 0x17007E83 RID: 32387
		// (get) Token: 0x060334D9 RID: 210137 RVA: 0x00BF977C File Offset: 0x00BF797C
		public RogueTalentTreeDesc DescConfig
		{
			get
			{
				if (this.DescConfigInternal == null)
				{
					this.DescConfigInternal = RoguelikeConfig.Instance.GetRogueTalentTreeDescConfig(this.Config.Describe);
				}
				return this.DescConfigInternal.Value;
			}
		}

		// Token: 0x17007E84 RID: 32388
		// (get) Token: 0x060334DA RID: 210138 RVA: 0x00BF97BF File Offset: 0x00BF79BF
		public int Index
		{
			get
			{
				return this.Col - 1;
			}
		}

		// Token: 0x17007E85 RID: 32389
		// (get) Token: 0x060334DB RID: 210139 RVA: 0x00BF97CC File Offset: 0x00BF79CC
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x17007E86 RID: 32390
		// (get) Token: 0x060334DC RID: 210140 RVA: 0x00BF97E8 File Offset: 0x00BF79E8
		public int Col
		{
			get
			{
				return this.Config.Column;
			}
		}

		// Token: 0x17007E87 RID: 32391
		// (get) Token: 0x060334DD RID: 210141 RVA: 0x00BF9803 File Offset: 0x00BF7A03
		public int CurLevel
		{
			get
			{
				return RoguelikeModel.Instance.RoguelikeSkillDataMap[this.Id];
			}
		}

		// Token: 0x17007E88 RID: 32392
		// (get) Token: 0x060334DE RID: 210142 RVA: 0x00BF981C File Offset: 0x00BF7A1C
		public ETalentTreeNodeState State
		{
			get
			{
				int curLevel = this.CurLevel;
				if (curLevel == -1)
				{
					return ETalentTreeNodeState.Lock;
				}
				if (curLevel == 0)
				{
					return ETalentTreeNodeState.Unlock;
				}
				return ETalentTreeNodeState.Active;
			}
		}

		// Token: 0x060334DF RID: 210143 RVA: 0x00BF983C File Offset: 0x00BF7A3C
		[NullableContext(1)]
		public List<ICostData> GetCostData()
		{
			if (this.State == ETalentTreeNodeState.Active)
			{
				return new List<ICostData>();
			}
			int skillPoint = RoguelikeModel.Instance.GetParamConfigBySeasonId(null).Value.SkillPoint;
			CostData costData = new CostData();
			costData.ItemId = skillPoint;
			InventoryModel instance = InventoryModel.Instance;
			costData.Count = ((instance != null) ? instance.GetItemCountByConfigId(skillPoint, 0) : 0);
			costData.Cost = ((this.CurLevel >= 0 && this.CurLevel < this.Config.ConsuleLength) ? this.Config.Consule(this.CurLevel) : 0);
			CostData item = costData;
			return new List<ICostData>
			{
				item
			};
		}

		// Token: 0x060334E0 RID: 210144 RVA: 0x00BF98F0 File Offset: 0x00BF7AF0
		public bool CanAfford()
		{
			List<ICostData> costData = this.GetCostData();
			return costData.Count == 0 || costData[0].Count >= costData[0].Cost;
		}

		// Token: 0x0401B3A9 RID: 111529
		public int Id;

		// Token: 0x0401B3AA RID: 111530
		private RogueTalentTree? ConfigInternal;

		// Token: 0x0401B3AB RID: 111531
		private RogueTalentTreeDesc? DescConfigInternal;

		// Token: 0x0401B3AC RID: 111532
		[Nullable(2)]
		public Action<bool, bool> SetNodeToggleState;
	}
}
