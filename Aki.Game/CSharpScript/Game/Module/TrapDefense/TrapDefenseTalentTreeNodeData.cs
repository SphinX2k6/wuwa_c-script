using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x020039C4 RID: 14788
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeNodeData
	{
		// Token: 0x17004DCC RID: 19916
		// (get) Token: 0x06026197 RID: 156055 RVA: 0x00AB067C File Offset: 0x00AAE87C
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x17004DCD RID: 19917
		// (get) Token: 0x06026198 RID: 156056 RVA: 0x00AB0689 File Offset: 0x00AAE889
		public int Col
		{
			get
			{
				return this.Config.Col;
			}
		}

		// Token: 0x17004DCE RID: 19918
		// (get) Token: 0x06026199 RID: 156057 RVA: 0x00AB0696 File Offset: 0x00AAE896
		public ETrapDefenseTalentTreeType Type
		{
			get
			{
				return (ETrapDefenseTalentTreeType)this.Config.Type;
			}
		}

		// Token: 0x17004DCF RID: 19919
		// (get) Token: 0x0602619A RID: 156058 RVA: 0x00AB06A3 File Offset: 0x00AAE8A3
		public int Index
		{
			get
			{
				return (this.Type - ETrapDefenseTalentTreeType.Economy) * 2 + this.Col - 1;
			}
		}

		// Token: 0x17004DD0 RID: 19920
		// (get) Token: 0x0602619B RID: 156059 RVA: 0x00AB06B8 File Offset: 0x00AAE8B8
		public string Icon
		{
			get
			{
				return this.Config.IconPath;
			}
		}

		// Token: 0x17004DD1 RID: 19921
		// (get) Token: 0x0602619C RID: 156060 RVA: 0x00AB06C5 File Offset: 0x00AAE8C5
		public string IconBig
		{
			get
			{
				return this.Config.IconPathBig;
			}
		}

		// Token: 0x17004DD2 RID: 19922
		// (get) Token: 0x0602619D RID: 156061 RVA: 0x00AB06D2 File Offset: 0x00AAE8D2
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17004DD3 RID: 19923
		// (get) Token: 0x0602619E RID: 156062 RVA: 0x00AB06DF File Offset: 0x00AAE8DF
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x0602619F RID: 156063 RVA: 0x00AB06EC File Offset: 0x00AAE8EC
		public static TrapDefenseTalentTreeNodeData Create(TrapDefenseTech config)
		{
			return new TrapDefenseTalentTreeNodeData
			{
				Config = config,
				Id = config.Id
			};
		}

		// Token: 0x060261A0 RID: 156064 RVA: 0x00AB0707 File Offset: 0x00AAE907
		public void SetUnlock()
		{
			this.IsUnlock = true;
		}

		// Token: 0x060261A1 RID: 156065 RVA: 0x00AB0710 File Offset: 0x00AAE910
		public List<ICostData> GetCostData()
		{
			if (this.IsUnlock)
			{
				return new List<ICostData>();
			}
			CostData item = new CostData
			{
				ItemId = TrapDefenseConfig.Instance.GetTalentTreeCurrencyItemId(),
				Count = TrapDefenseModel.Instance.TalentTreeData.RemainPoints,
				Cost = this.Config.UnlockCost
			};
			return new List<ICostData>
			{
				item
			};
		}

		// Token: 0x04014EAE RID: 85678
		public int Id;

		// Token: 0x04014EAF RID: 85679
		public TrapDefenseTech Config;

		// Token: 0x04014EB0 RID: 85680
		public bool IsUnlock;
	}
}
