using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.QuestMultiLine.QuestMultiLineData
{
	// Token: 0x02003F96 RID: 16278
	[NullableContext(1)]
	[Nullable(0)]
	public class QuestMultiLineBranchData
	{
		// Token: 0x060292B7 RID: 168631 RVA: 0x00B8FDAC File Offset: 0x00B8DFAC
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

		// Token: 0x17005332 RID: 21298
		// (get) Token: 0x060292B8 RID: 168632 RVA: 0x00B8FE10 File Offset: 0x00B8E010
		public int BranchId
		{
			get
			{
				return this.Config.Value.Id;
			}
		}

		// Token: 0x17005333 RID: 21299
		// (get) Token: 0x060292B9 RID: 168633 RVA: 0x00B8FE30 File Offset: 0x00B8E030
		public string Name
		{
			get
			{
				return this.Config.Value.Name;
			}
		}

		// Token: 0x17005334 RID: 21300
		// (get) Token: 0x060292BA RID: 168634 RVA: 0x00B8FE50 File Offset: 0x00B8E050
		public string Icon
		{
			get
			{
				return this.Config.Value.Icon;
			}
		}

		// Token: 0x17005335 RID: 21301
		// (get) Token: 0x060292BB RID: 168635 RVA: 0x00B8FE70 File Offset: 0x00B8E070
		public string[] Icons
		{
			get
			{
				return this.Config.Value.Icons();
			}
		}

		// Token: 0x17005336 RID: 21302
		// (get) Token: 0x060292BC RID: 168636 RVA: 0x00B8FE90 File Offset: 0x00B8E090
		public string Desc
		{
			get
			{
				return this.Config.Value.Desc;
			}
		}

		// Token: 0x17005337 RID: 21303
		// (get) Token: 0x060292BD RID: 168637 RVA: 0x00B8FEB0 File Offset: 0x00B8E0B0
		public int[] FightingAreas
		{
			get
			{
				return this.Config.Value.ShownAreaRoute();
			}
		}

		// Token: 0x17005338 RID: 21304
		// (get) Token: 0x060292BE RID: 168638 RVA: 0x00B8FED0 File Offset: 0x00B8E0D0
		public List<QuestMultiLineComponentData> Components
		{
			get
			{
				return this.QuestMultiLineComponentDataList;
			}
		}

		// Token: 0x17005339 RID: 21305
		// (get) Token: 0x060292BF RID: 168639 RVA: 0x00B8FED8 File Offset: 0x00B8E0D8
		// (set) Token: 0x060292C0 RID: 168640 RVA: 0x00B8FEE0 File Offset: 0x00B8E0E0
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

		// Token: 0x040166B8 RID: 91832
		private EBranchState BranchState;

		// Token: 0x040166B9 RID: 91833
		private readonly QuestBranchConfig? Config;

		// Token: 0x040166BA RID: 91834
		private readonly List<QuestMultiLineComponentData> QuestMultiLineComponentDataList = new List<QuestMultiLineComponentData>();
	}
}
