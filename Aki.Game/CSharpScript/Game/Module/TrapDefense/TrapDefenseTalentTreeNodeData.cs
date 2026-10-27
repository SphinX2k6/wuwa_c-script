using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.TrapDefense
{
	// Token: 0x02004A1C RID: 18972
	[NullableContext(1)]
	[Nullable(0)]
	public class TrapDefenseTalentTreeNodeData
	{
		// Token: 0x17007A1F RID: 31263
		// (get) Token: 0x06031407 RID: 201735 RVA: 0x00B6C680 File Offset: 0x00B6A880
		public int Row
		{
			get
			{
				return this.Config.Row;
			}
		}

		// Token: 0x17007A20 RID: 31264
		// (get) Token: 0x06031408 RID: 201736 RVA: 0x00B6C68D File Offset: 0x00B6A88D
		public int Col
		{
			get
			{
				return this.Config.Col;
			}
		}

		// Token: 0x17007A21 RID: 31265
		// (get) Token: 0x06031409 RID: 201737 RVA: 0x00B6C69A File Offset: 0x00B6A89A
		public ETrapDefenseTalentTreeType Type
		{
			get
			{
				return (ETrapDefenseTalentTreeType)this.Config.Type;
			}
		}

		// Token: 0x17007A22 RID: 31266
		// (get) Token: 0x0603140A RID: 201738 RVA: 0x00B6C6A7 File Offset: 0x00B6A8A7
		public int Index
		{
			get
			{
				return (this.Type - ETrapDefenseTalentTreeType.Economy) * 2 + this.Col - 1;
			}
		}

		// Token: 0x17007A23 RID: 31267
		// (get) Token: 0x0603140B RID: 201739 RVA: 0x00B6C6BC File Offset: 0x00B6A8BC
		public string Icon
		{
			get
			{
				return this.Config.IconPath;
			}
		}

		// Token: 0x17007A24 RID: 31268
		// (get) Token: 0x0603140C RID: 201740 RVA: 0x00B6C6C9 File Offset: 0x00B6A8C9
		public string IconBig
		{
			get
			{
				return this.Config.IconPathBig;
			}
		}

		// Token: 0x17007A25 RID: 31269
		// (get) Token: 0x0603140D RID: 201741 RVA: 0x00B6C6D6 File Offset: 0x00B6A8D6
		public string Desc
		{
			get
			{
				return this.Config.Desc;
			}
		}

		// Token: 0x17007A26 RID: 31270
		// (get) Token: 0x0603140E RID: 201742 RVA: 0x00B6C6E3 File Offset: 0x00B6A8E3
		public string Name
		{
			get
			{
				return this.Config.Name;
			}
		}

		// Token: 0x0603140F RID: 201743 RVA: 0x00B6C6F0 File Offset: 0x00B6A8F0
		public static TrapDefenseTalentTreeNodeData Create(TrapDefenseTech config)
		{
			return new TrapDefenseTalentTreeNodeData
			{
				Config = config,
				Id = config.Id
			};
		}

		// Token: 0x06031410 RID: 201744 RVA: 0x00B6C70B File Offset: 0x00B6A90B
		public void SetUnlock()
		{
			this.IsUnlock = true;
		}

		// Token: 0x06031411 RID: 201745 RVA: 0x00B6C714 File Offset: 0x00B6A914
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

		// Token: 0x0401A557 RID: 107863
		public int Id;

		// Token: 0x0401A558 RID: 107864
		public TrapDefenseTech Config;

		// Token: 0x0401A559 RID: 107865
		public bool IsUnlock;
	}
}
