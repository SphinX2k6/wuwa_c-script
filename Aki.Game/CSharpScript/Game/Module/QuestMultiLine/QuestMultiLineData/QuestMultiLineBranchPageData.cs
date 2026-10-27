using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02004FCE RID: 20430
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineBranchPageData
	{
		// Token: 0x06034453 RID: 214099 RVA: 0x00C46734 File Offset: 0x00C44934
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

		// Token: 0x17007F8A RID: 32650
		// (get) Token: 0x06034454 RID: 214100 RVA: 0x00C467C0 File Offset: 0x00C449C0
		public int Id
		{
			get
			{
				return this.Config.Value.Id;
			}
		}

		// Token: 0x17007F8B RID: 32651
		// (get) Token: 0x06034455 RID: 214101 RVA: 0x00C467E0 File Offset: 0x00C449E0
		public int[] Branch
		{
			get
			{
				return this.Config.Value.Branch();
			}
		}

		// Token: 0x17007F8C RID: 32652
		// (get) Token: 0x06034456 RID: 214102 RVA: 0x00C46800 File Offset: 0x00C44A00
		public Aki.Config.IntVector2D[] QuestNodes
		{
			get
			{
				return this.Config.Value.QuestNodes();
			}
		}

		// Token: 0x17007F8D RID: 32653
		// (get) Token: 0x06034457 RID: 214103 RVA: 0x00C46820 File Offset: 0x00C44A20
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

		// Token: 0x0401BCE6 RID: 113894
		private readonly QuestBranchPageConfig? Config;

		// Token: 0x0401BCE7 RID: 113895
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private readonly List<QuestMultiLineBranchData> BranchDataArray;
	}
}
