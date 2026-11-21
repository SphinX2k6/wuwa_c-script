using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D4D RID: 15693
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeEntriesGroupData
	{
		// Token: 0x17005230 RID: 21040
		// (get) Token: 0x0602833C RID: 164668 RVA: 0x00B42C48 File Offset: 0x00B40E48
		// (set) Token: 0x0602833B RID: 164667 RVA: 0x00B42C24 File Offset: 0x00B40E24
		public bool IsActive
		{
			get
			{
				return this.IsActiveInternal;
			}
			set
			{
				if (this.IsActiveInternal == value)
				{
					return;
				}
				this.IsActiveInternal = value;
				Action<bool> activeStateChange = this.ActiveStateChange;
				if (activeStateChange == null)
				{
					return;
				}
				activeStateChange(value);
			}
		}

		// Token: 0x17005231 RID: 21041
		// (get) Token: 0x0602833E RID: 164670 RVA: 0x00B42C74 File Offset: 0x00B40E74
		// (set) Token: 0x0602833D RID: 164669 RVA: 0x00B42C50 File Offset: 0x00B40E50
		public bool IsFocus
		{
			get
			{
				return this.IsFocusInternal;
			}
			set
			{
				if (this.IsFocus == value)
				{
					return;
				}
				this.IsFocusInternal = value;
				Action<bool> focusStateChange = this.FocusStateChange;
				if (focusStateChange == null)
				{
					return;
				}
				focusStateChange(value);
			}
		}

		// Token: 0x0602833F RID: 164671 RVA: 0x00B42C7C File Offset: 0x00B40E7C
		public List<RoguelikeEntryData> GetAllEntryDataList()
		{
			List<RoguelikeEntryData> list = new List<RoguelikeEntryData>();
			list.AddRange(this.GroupDataListRow1);
			list.AddRange(this.GroupDataListRow2);
			list.AddRange(this.GroupDataListRow3);
			return list;
		}

		// Token: 0x06028340 RID: 164672 RVA: 0x00B42CA8 File Offset: 0x00B40EA8
		public RogueHotEntryGroup GetConfig()
		{
			return RoguelikeConfig.Instance.GetRogueHotEntryGroupConfig(this.Id).Value;
		}

		// Token: 0x04015D6C RID: 89452
		public int Id;

		// Token: 0x04015D6D RID: 89453
		public int Index;

		// Token: 0x04015D6E RID: 89454
		public bool IsUnlock;

		// Token: 0x04015D6F RID: 89455
		private bool IsActiveInternal;

		// Token: 0x04015D70 RID: 89456
		private bool IsFocusInternal;

		// Token: 0x04015D71 RID: 89457
		public List<RoguelikeEntryData> GroupDataListRow1 = new List<RoguelikeEntryData>();

		// Token: 0x04015D72 RID: 89458
		public List<RoguelikeEntryData> GroupDataListRow2 = new List<RoguelikeEntryData>();

		// Token: 0x04015D73 RID: 89459
		public List<RoguelikeEntryData> GroupDataListRow3 = new List<RoguelikeEntryData>();

		// Token: 0x04015D74 RID: 89460
		[Nullable(2)]
		public Action<bool> ActiveStateChange;

		// Token: 0x04015D75 RID: 89461
		[Nullable(2)]
		public Action<bool> FocusStateChange;
	}
}
