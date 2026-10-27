using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02004FCD RID: 20429
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineBranchData
	{
		// Token: 0x06034449 RID: 214089 RVA: 0x00C465F4 File Offset: 0x00C447F4
		public QuestMultiLineBranchData(int configId)
		{
			this.Config = QuestMultiLineConfig.GetQuestBranchConfig(configId);
			int[] array = this.Config.Value.Component();
			for (int i = 0; i < array.Length; i++)
			{
				QuestMultiLineComponentData item = new QuestMultiLineComponentData(array[i]);
				this.QuestMultiLineComponentDataList.Add(item);
			}
		}

		// Token: 0x17007F82 RID: 32642
		// (get) Token: 0x0603444A RID: 214090 RVA: 0x00C46658 File Offset: 0x00C44858
		public int BranchId
		{
			get
			{
				return this.Config.Value.Id;
			}
		}

		// Token: 0x17007F83 RID: 32643
		// (get) Token: 0x0603444B RID: 214091 RVA: 0x00C46678 File Offset: 0x00C44878
		public string Name
		{
			get
			{
				return this.Config.Value.Name;
			}
		}

		// Token: 0x17007F84 RID: 32644
		// (get) Token: 0x0603444C RID: 214092 RVA: 0x00C46698 File Offset: 0x00C44898
		public string Icon
		{
			get
			{
				return this.Config.Value.Icon;
			}
		}

		// Token: 0x17007F85 RID: 32645
		// (get) Token: 0x0603444D RID: 214093 RVA: 0x00C466B8 File Offset: 0x00C448B8
		public string[] Icons
		{
			get
			{
				return this.Config.Value.Icons();
			}
		}

		// Token: 0x17007F86 RID: 32646
		// (get) Token: 0x0603444E RID: 214094 RVA: 0x00C466D8 File Offset: 0x00C448D8
		public string Desc
		{
			get
			{
				return this.Config.Value.Desc;
			}
		}

		// Token: 0x17007F87 RID: 32647
		// (get) Token: 0x0603444F RID: 214095 RVA: 0x00C466F8 File Offset: 0x00C448F8
		public int[] FightingAreas
		{
			get
			{
				return this.Config.Value.ShownAreaRoute();
			}
		}

		// Token: 0x17007F88 RID: 32648
		// (get) Token: 0x06034450 RID: 214096 RVA: 0x00C46718 File Offset: 0x00C44918
		public List<QuestMultiLineComponentData> Components
		{
			get
			{
				return this.QuestMultiLineComponentDataList;
			}
		}

		// Token: 0x17007F89 RID: 32649
		// (get) Token: 0x06034451 RID: 214097 RVA: 0x00C46720 File Offset: 0x00C44920
		// (set) Token: 0x06034452 RID: 214098 RVA: 0x00C46728 File Offset: 0x00C44928
		public EBranchState State
		{
			get
			{
				return this.BranchState;
			}
			set
			{
				this.BranchState = value;
			}
		}

		// Token: 0x0401BCE3 RID: 113891
		private EBranchState BranchState;

		// Token: 0x0401BCE4 RID: 113892
		private readonly QuestBranchConfig? Config;

		// Token: 0x0401BCE5 RID: 113893
		private readonly List<QuestMultiLineComponentData> QuestMultiLineComponentDataList = new List<QuestMultiLineComponentData>();
	}
}
