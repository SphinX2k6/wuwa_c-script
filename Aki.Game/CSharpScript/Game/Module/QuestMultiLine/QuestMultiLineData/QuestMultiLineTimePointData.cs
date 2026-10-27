using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02004FD0 RID: 20432
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineTimePointData
	{
		// Token: 0x0603446E RID: 214126 RVA: 0x00C46AEC File Offset: 0x00C44CEC
		public QuestMultiLineTimePointData(QuestTimePointConfig config)
		{
			this.Config = new QuestTimePointConfig?(config);
			this.ConfigId = config.Id;
		}

		// Token: 0x0603446F RID: 214127 RVA: 0x00C46B24 File Offset: 0x00C44D24
		public void RefreshUnComponentGroups(Dictionary<int, bool> groupIdMap)
		{
			this.UnlockComponentGroups = new List<int>();
			foreach (int num in this.ComponentGroup)
			{
				if (groupIdMap.GetValueOrDefault(num, false))
				{
					this.UnlockComponentGroups.Add(num);
				}
			}
			this.RefreshUnlockComponentAndFightArea();
		}

		// Token: 0x17007FA3 RID: 32675
		// (get) Token: 0x06034470 RID: 214128 RVA: 0x00C46B74 File Offset: 0x00C44D74
		public List<int> FightAreas
		{
			get
			{
				List<int> list = new List<int>();
				foreach (int item in this.FightAreaMap.Keys)
				{
					list.Add(item);
				}
				return list;
			}
		}

		// Token: 0x17007FA4 RID: 32676
		// (get) Token: 0x06034471 RID: 214129 RVA: 0x00C46BD4 File Offset: 0x00C44DD4
		public List<QuestMultiLineComponentData> UnlockComponentArray
		{
			get
			{
				List<QuestMultiLineComponentData> list = new List<QuestMultiLineComponentData>();
				foreach (QuestMultiLineComponentData item in this.UnlockComponentMap.Values)
				{
					list.Add(item);
				}
				return list;
			}
		}

		// Token: 0x17007FA5 RID: 32677
		// (get) Token: 0x06034472 RID: 214130 RVA: 0x00C46C34 File Offset: 0x00C44E34
		public Dictionary<int, QuestMultiLineComponentData> UnlockComponent
		{
			get
			{
				return this.UnlockComponentMap;
			}
		}

		// Token: 0x17007FA6 RID: 32678
		// (get) Token: 0x06034473 RID: 214131 RVA: 0x00C46C3C File Offset: 0x00C44E3C
		public List<QuestMultiLineComponentData> UnlockComponents
		{
			get
			{
				return this.UnlockComponentArray;
			}
		}

		// Token: 0x17007FA7 RID: 32679
		// (get) Token: 0x06034474 RID: 214132 RVA: 0x00C46C44 File Offset: 0x00C44E44
		public Dictionary<int, bool> FightingAreaMap
		{
			get
			{
				return this.FightAreaMap;
			}
		}

		// Token: 0x17007FA8 RID: 32680
		// (get) Token: 0x06034475 RID: 214133 RVA: 0x00C46C4C File Offset: 0x00C44E4C
		// (set) Token: 0x06034476 RID: 214134 RVA: 0x00C46C54 File Offset: 0x00C44E54
		public bool IsUnLock
		{
			get
			{
				return this.UnLock;
			}
			set
			{
				this.UnLock = value;
			}
		}

		// Token: 0x17007FA9 RID: 32681
		// (get) Token: 0x06034477 RID: 214135 RVA: 0x00C46C5D File Offset: 0x00C44E5D
		public int Id
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x17007FAA RID: 32682
		// (get) Token: 0x06034478 RID: 214136 RVA: 0x00C46C68 File Offset: 0x00C44E68
		public string Name
		{
			get
			{
				return this.Config.Value.Name;
			}
		}

		// Token: 0x17007FAB RID: 32683
		// (get) Token: 0x06034479 RID: 214137 RVA: 0x00C46C88 File Offset: 0x00C44E88
		public int QuestId
		{
			get
			{
				return this.Config.Value.QuestId;
			}
		}

		// Token: 0x17007FAC RID: 32684
		// (get) Token: 0x0603447A RID: 214138 RVA: 0x00C46CA8 File Offset: 0x00C44EA8
		public string ScreenEffect
		{
			get
			{
				return this.Config.Value.ScreenEffect;
			}
		}

		// Token: 0x17007FAD RID: 32685
		// (get) Token: 0x0603447B RID: 214139 RVA: 0x00C46CC8 File Offset: 0x00C44EC8
		public int BranchPage
		{
			get
			{
				return this.Config.Value.BranchPage;
			}
		}

		// Token: 0x17007FAE RID: 32686
		// (get) Token: 0x0603447C RID: 214140 RVA: 0x00C46CE8 File Offset: 0x00C44EE8
		public int Sort
		{
			get
			{
				return this.Config.Value.Sort;
			}
		}

		// Token: 0x17007FAF RID: 32687
		// (get) Token: 0x0603447D RID: 214141 RVA: 0x00C46D08 File Offset: 0x00C44F08
		public int[] ComponentGroup
		{
			get
			{
				return this.Config.Value.ComponentGroup();
			}
		}

		// Token: 0x17007FB0 RID: 32688
		// (get) Token: 0x0603447E RID: 214142 RVA: 0x00C46D28 File Offset: 0x00C44F28
		public bool IsBranchNode
		{
			get
			{
				return this.Config.Value.IsBranchNode;
			}
		}

		// Token: 0x17007FB1 RID: 32689
		// (get) Token: 0x0603447F RID: 214143 RVA: 0x00C46D48 File Offset: 0x00C44F48
		public string Title
		{
			get
			{
				return this.Config.Value.Title;
			}
		}

		// Token: 0x17007FB2 RID: 32690
		// (get) Token: 0x06034480 RID: 214144 RVA: 0x00C46D68 File Offset: 0x00C44F68
		public string Desc
		{
			get
			{
				return this.Config.Value.Desc;
			}
		}

		// Token: 0x17007FB3 RID: 32691
		// (get) Token: 0x06034481 RID: 214145 RVA: 0x00C46D88 File Offset: 0x00C44F88
		public string NameBottom
		{
			get
			{
				return this.Config.Value.NameBottom;
			}
		}

		// Token: 0x06034482 RID: 214146 RVA: 0x00C46DA8 File Offset: 0x00C44FA8
		private void RefreshUnlockComponentAndFightArea()
		{
			this.UnlockComponentMap.Clear();
			this.FightAreaMap.Clear();
			if (this.UnlockComponentGroups == null)
			{
				return;
			}
			foreach (int id in this.UnlockComponentGroups)
			{
				QuestBranchComponentGroup? branchComponentGroupConfig = QuestMultiLineConfig.GetBranchComponentGroupConfig(id);
				if (branchComponentGroupConfig != null)
				{
					foreach (int key in branchComponentGroupConfig.Value.ShownArea())
					{
						if (!this.FightAreaMap.GetValueOrDefault(key, false))
						{
							this.FightAreaMap[key] = true;
						}
					}
					foreach (int num in branchComponentGroupConfig.Value.BranchComponents())
					{
						if (!this.UnlockComponentMap.ContainsKey(num))
						{
							this.UnlockComponentMap[num] = new QuestMultiLineComponentData(num);
						}
					}
				}
			}
		}

		// Token: 0x06034483 RID: 214147 RVA: 0x00C46EB4 File Offset: 0x00C450B4
		public void RefreshBranchInfo(Dictionary<int, OneQuestBranchPageInfo> branchPageInfoMap)
		{
			if (this.BranchPage == 0)
			{
				this.BranchPageInfo = null;
				this.QuestMultiLineBranchPageData = null;
				return;
			}
			OneQuestBranchPageInfo oneQuestBranchPageInfo;
			if (!branchPageInfoMap.TryGetValue(this.BranchPage, out oneQuestBranchPageInfo))
			{
				oneQuestBranchPageInfo = OneQuestBranchPageInfo.Create();
				oneQuestBranchPageInfo.Id = this.BranchPage;
				oneQuestBranchPageInfo.CurBranch = 0;
			}
			this.BranchPageInfo = oneQuestBranchPageInfo;
			this.QuestMultiLineBranchPageData = new QuestMultiLineBranchPageData(this.BranchPageInfo);
		}

		// Token: 0x17007FB4 RID: 32692
		// (get) Token: 0x06034484 RID: 214148 RVA: 0x00C46F19 File Offset: 0x00C45119
		[Nullable(2)]
		public QuestMultiLineBranchPageData BranchPageData
		{
			[NullableContext(2)]
			get
			{
				return this.QuestMultiLineBranchPageData;
			}
		}

		// Token: 0x17007FB5 RID: 32693
		// (get) Token: 0x06034485 RID: 214149 RVA: 0x00C46F21 File Offset: 0x00C45121
		public bool IsBranchTimePoint
		{
			get
			{
				return this.BranchPage != 0;
			}
		}

		// Token: 0x17007FB6 RID: 32694
		// (get) Token: 0x06034486 RID: 214150 RVA: 0x00C46F2C File Offset: 0x00C4512C
		[Nullable(2)]
		public OneQuestBranchPageInfo BranchPageInfoData
		{
			[NullableContext(2)]
			get
			{
				return this.BranchPageInfo;
			}
		}

		// Token: 0x0401BCE9 RID: 113897
		private readonly int ConfigId;

		// Token: 0x0401BCEA RID: 113898
		private bool UnLock;

		// Token: 0x0401BCEB RID: 113899
		[Nullable(2)]
		private List<int> UnlockComponentGroups;

		// Token: 0x0401BCEC RID: 113900
		[Nullable(2)]
		private QuestMultiLineBranchPageData QuestMultiLineBranchPageData;

		// Token: 0x0401BCED RID: 113901
		[Nullable(2)]
		private OneQuestBranchPageInfo BranchPageInfo;

		// Token: 0x0401BCEE RID: 113902
		private readonly Dictionary<int, QuestMultiLineComponentData> UnlockComponentMap = new Dictionary<int, QuestMultiLineComponentData>();

		// Token: 0x0401BCEF RID: 113903
		private readonly Dictionary<int, bool> FightAreaMap = new Dictionary<int, bool>();

		// Token: 0x0401BCF0 RID: 113904
		private readonly QuestTimePointConfig? Config;
	}
}
