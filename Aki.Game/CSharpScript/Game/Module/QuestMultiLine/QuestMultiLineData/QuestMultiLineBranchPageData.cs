using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02003F97 RID: 16279
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineBranchPageData
	{
		// Token: 0x060292C1 RID: 168641 RVA: 0x00B8FEEC File Offset: 0x00B8E0EC
		public QuestMultiLineBranchPageData(OneQuestBranchPageInfo branchPageInfo)
		{
			this.Config = QuestMultiLineConfig.GetBranchPageConfigById(branchPageInfo.Id);
			this.BranchDataArray = new List<QuestMultiLineBranchData>();
			int[] branch = this.Branch;
			for (int i = 0; i < branch.Length; i++)
			{
				QuestMultiLineBranchData questMultiLineBranchData = new QuestMultiLineBranchData(branch[i]);
				this.BranchDataArray.Add(questMultiLineBranchData);
				if (questMultiLineBranchData.BranchId == branchPageInfo.CurBranch)
				{
					questMultiLineBranchData.State = EBranchState.CurSelected;
				}
				else if (branchPageInfo.CompleteBranches.Contains(questMultiLineBranchData.BranchId))
				{
					questMultiLineBranchData.State = EBranchState.Finish;
				}
			}
		}

		// Token: 0x1700533A RID: 21306
		// (get) Token: 0x060292C2 RID: 168642 RVA: 0x00B8FF78 File Offset: 0x00B8E178
		public int Id
		{
			get
			{
				return this.Config.Value.Id;
			}
		}

		// Token: 0x1700533B RID: 21307
		// (get) Token: 0x060292C3 RID: 168643 RVA: 0x00B8FF98 File Offset: 0x00B8E198
		public int[] Branch
		{
			get
			{
				return this.Config.Value.Branch();
			}
		}

		// Token: 0x1700533C RID: 21308
		// (get) Token: 0x060292C4 RID: 168644 RVA: 0x00B8FFB8 File Offset: 0x00B8E1B8
		public Aki.Config.IntVector2D[] QuestNodes
		{
			get
			{
				return this.Config.Value.QuestNodes();
			}
		}

		// Token: 0x1700533D RID: 21309
		// (get) Token: 0x060292C5 RID: 168645 RVA: 0x00B8FFD8 File Offset: 0x00B8E1D8
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<QuestMultiLineBranchData> BranchData
		{
			[return: Nullable(new byte[]
			{
				2,
				1
			})]
			get
			{
				return this.BranchDataArray;
			}
		}

		// Token: 0x040166BB RID: 91835
		private readonly QuestBranchPageConfig? Config;

		// Token: 0x040166BC RID: 91836
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<QuestMultiLineBranchData> BranchDataArray;
	}
}
