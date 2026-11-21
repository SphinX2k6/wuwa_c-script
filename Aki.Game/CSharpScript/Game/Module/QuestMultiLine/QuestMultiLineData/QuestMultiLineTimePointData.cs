using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.Protocol;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02003F99 RID: 16281
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineTimePointData
	{
		// Token: 0x060292DC RID: 168668 RVA: 0x00B902A4 File Offset: 0x00B8E4A4
		public QuestMultiLineTimePointData(QuestTimePointConfig config)
		{
			this.Config = new QuestTimePointConfig?(config);
			this.ConfigId = config.Id;
		}

		// Token: 0x060292DD RID: 168669 RVA: 0x00B902DC File Offset: 0x00B8E4DC
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

		// Token: 0x17005353 RID: 21331
		// (get) Token: 0x060292DE RID: 168670 RVA: 0x00B9032C File Offset: 0x00B8E52C
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

		// Token: 0x17005354 RID: 21332
		// (get) Token: 0x060292DF RID: 168671 RVA: 0x00B9038C File Offset: 0x00B8E58C
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

		// Token: 0x17005355 RID: 21333
		// (get) Token: 0x060292E0 RID: 168672 RVA: 0x00B903EC File Offset: 0x00B8E5EC
		public Dictionary<int, QuestMultiLineComponentData> UnlockComponent
		{
			get
			{
				return this.UnlockComponentMap;
			}
		}

		// Token: 0x17005356 RID: 21334
		// (get) Token: 0x060292E1 RID: 168673 RVA: 0x00B903F4 File Offset: 0x00B8E5F4
		public List<QuestMultiLineComponentData> UnlockComponents
		{
			get
			{
				return this.UnlockComponentArray;
			}
		}

		// Token: 0x17005357 RID: 21335
		// (get) Token: 0x060292E2 RID: 168674 RVA: 0x00B903FC File Offset: 0x00B8E5FC
		public Dictionary<int, bool> FightingAreaMap
		{
			get
			{
				return this.FightAreaMap;
			}
		}

		// Token: 0x17005358 RID: 21336
		// (get) Token: 0x060292E3 RID: 168675 RVA: 0x00B90404 File Offset: 0x00B8E604
		// (set) Token: 0x060292E4 RID: 168676 RVA: 0x00B9040C File Offset: 0x00B8E60C
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

		// Token: 0x17005359 RID: 21337
		// (get) Token: 0x060292E5 RID: 168677 RVA: 0x00B90415 File Offset: 0x00B8E615
		public int Id
		{
			get
			{
				return this.ConfigId;
			}
		}

		// Token: 0x1700535A RID: 21338
		// (get) Token: 0x060292E6 RID: 168678 RVA: 0x00B90420 File Offset: 0x00B8E620
		public string Name
		{
			get
			{
				return this.Config.Value.Name;
			}
		}

		// Token: 0x1700535B RID: 21339
		// (get) Token: 0x060292E7 RID: 168679 RVA: 0x00B90440 File Offset: 0x00B8E640
		public int QuestId
		{
			get
			{
				return this.Config.Value.QuestId;
			}
		}

		// Token: 0x1700535C RID: 21340
		// (get) Token: 0x060292E8 RID: 168680 RVA: 0x00B90460 File Offset: 0x00B8E660
		public string ScreenEffect
		{
			get
			{
				return this.Config.Value.ScreenEffect;
			}
		}

		// Token: 0x1700535D RID: 21341
		// (get) Token: 0x060292E9 RID: 168681 RVA: 0x00B90480 File Offset: 0x00B8E680
		public int BranchPage
		{
			get
			{
				return this.Config.Value.BranchPage;
			}
		}

		// Token: 0x1700535E RID: 21342
		// (get) Token: 0x060292EA RID: 168682 RVA: 0x00B904A0 File Offset: 0x00B8E6A0
		public int Sort
		{
			get
			{
				return this.Config.Value.Sort;
			}
		}

		// Token: 0x1700535F RID: 21343
		// (get) Token: 0x060292EB RID: 168683 RVA: 0x00B904C0 File Offset: 0x00B8E6C0
		public int[] ComponentGroup
		{
			get
			{
				return this.Config.Value.ComponentGroup();
			}
		}

		// Token: 0x17005360 RID: 21344
		// (get) Token: 0x060292EC RID: 168684 RVA: 0x00B904E0 File Offset: 0x00B8E6E0
		public bool IsBranchNode
		{
			get
			{
				return this.Config.Value.IsBranchNode;
			}
		}

		// Token: 0x17005361 RID: 21345
		// (get) Token: 0x060292ED RID: 168685 RVA: 0x00B90500 File Offset: 0x00B8E700
		public string Title
		{
			get
			{
				return this.Config.Value.Title;
			}
		}

		// Token: 0x17005362 RID: 21346
		// (get) Token: 0x060292EE RID: 168686 RVA: 0x00B90520 File Offset: 0x00B8E720
		public string Desc
		{
			get
			{
				return this.Config.Value.Desc;
			}
		}

		// Token: 0x17005363 RID: 21347
		// (get) Token: 0x060292EF RID: 168687 RVA: 0x00B90540 File Offset: 0x00B8E740
		public string NameBottom
		{
			get
			{
				return this.Config.Value.NameBottom;
			}
		}

		// Token: 0x060292F0 RID: 168688 RVA: 0x00B90560 File Offset: 0x00B8E760
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

		// Token: 0x060292F1 RID: 168689 RVA: 0x00B9066C File Offset: 0x00B8E86C
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

		// Token: 0x17005364 RID: 21348
		// (get) Token: 0x060292F2 RID: 168690 RVA: 0x00B906D1 File Offset: 0x00B8E8D1
		[Nullable(2)]
		public QuestMultiLineBranchPageData BranchPageData
		{
			[NullableContext(2)]
			get
			{
				return this.QuestMultiLineBranchPageData;
			}
		}

		// Token: 0x17005365 RID: 21349
		// (get) Token: 0x060292F3 RID: 168691 RVA: 0x00B906D9 File Offset: 0x00B8E8D9
		public bool IsBranchTimePoint
		{
			get
			{
				return this.BranchPage != 0;
			}
		}

		// Token: 0x17005366 RID: 21350
		// (get) Token: 0x060292F4 RID: 168692 RVA: 0x00B906E4 File Offset: 0x00B8E8E4
		[Nullable(2)]
		public OneQuestBranchPageInfo BranchPageInfoData
		{
			[NullableContext(2)]
			get
			{
				return this.BranchPageInfo;
			}
		}

		// Token: 0x040166BE RID: 91838
		private readonly int ConfigId;

		// Token: 0x040166BF RID: 91839
		private bool UnLock;

		// Token: 0x040166C0 RID: 91840
		[Nullable(2)]
		private List<int> UnlockComponentGroups;

		// Token: 0x040166C1 RID: 91841
		[Nullable(2)]
		private QuestMultiLineBranchPageData QuestMultiLineBranchPageData;

		// Token: 0x040166C2 RID: 91842
		[Nullable(2)]
		private OneQuestBranchPageInfo BranchPageInfo;

		// Token: 0x040166C3 RID: 91843
		private readonly Dictionary<int, QuestMultiLineComponentData> UnlockComponentMap = new Dictionary<int, QuestMultiLineComponentData>();

		// Token: 0x040166C4 RID: 91844
		private readonly Dictionary<int, bool> FightAreaMap = new Dictionary<int, bool>();

		// Token: 0x040166C5 RID: 91845
		private readonly QuestTimePointConfig? Config;
	}
}
