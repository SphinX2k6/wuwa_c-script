using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D4F RID: 15695
	public class RoguelikeTalentTreeNodeData
	{
		// Token: 0x06028344 RID: 164676 RVA: 0x00B42D37 File Offset: 0x00B40F37
		public RoguelikeTalentTreeNodeData(int id)
		{
			this.Id = id;
		}

		// Token: 0x17005232 RID: 21042
		// (get) Token: 0x06028345 RID: 164677 RVA: 0x00B42D46 File Offset: 0x00B40F46
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

		// Token: 0x17005233 RID: 21043
		// (get) Token: 0x06028346 RID: 164678 RVA: 0x00B42D78 File Offset: 0x00B40F78
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

		// Token: 0x17005234 RID: 21044
		// (get) Token: 0x06028347 RID: 164679 RVA: 0x00B42DBB File Offset: 0x00B40FBB
		public int Index
		{
			get
			{
				return this.Col - 1;
			}
		}

		// Token: 0x17005235 RID: 21045
		// (get) Token: 0x06028348 RID: 164680 RVA: 0x00B42DC8 File Offset: 0x00B40FC8
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x17005236 RID: 21046
		// (get) Token: 0x06028349 RID: 164681 RVA: 0x00B42DE4 File Offset: 0x00B40FE4
		public int Col
		{
			get
			{
				return this.Config.Column;
			}
		}

		// Token: 0x17005237 RID: 21047
		// (get) Token: 0x0602834A RID: 164682 RVA: 0x00B42DFF File Offset: 0x00B40FFF
		public int CurLevel
		{
			get
			{
				return RoguelikeModel.Instance.RoguelikeSkillDataMap[this.Id];
			}
		}

		// Token: 0x17005238 RID: 21048
		// (get) Token: 0x0602834B RID: 164683 RVA: 0x00B42E18 File Offset: 0x00B41018
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

		// Token: 0x0602834C RID: 164684 RVA: 0x00B42E38 File Offset: 0x00B41038
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

		// Token: 0x0602834D RID: 164685 RVA: 0x00B42EEC File Offset: 0x00B410EC
		public bool CanAfford()
		{
			List<ICostData> costData = this.GetCostData();
			return costData.Count == 0 || costData[0].Count >= costData[0].Cost;
		}

		// Token: 0x04015D7C RID: 89468
		public int Id;

		// Token: 0x04015D7D RID: 89469
		private RogueTalentTree? ConfigInternal;

		// Token: 0x04015D7E RID: 89470
		private RogueTalentTreeDesc? DescConfigInternal;

		// Token: 0x04015D7F RID: 89471
		[Nullable(2)]
		public Action<bool, bool> SetNodeToggleState;
	}
}
