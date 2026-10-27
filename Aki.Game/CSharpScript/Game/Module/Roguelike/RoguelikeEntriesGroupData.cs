using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D84 RID: 19844
	[NullableContext(1)]
	[Nullable(0)]
	public class RoguelikeEntriesGroupData
	{
		// Token: 0x17007E80 RID: 32384
		// (get) Token: 0x060334CF RID: 210127 RVA: 0x00BF964C File Offset: 0x00BF784C
		// (set) Token: 0x060334CE RID: 210126 RVA: 0x00BF9628 File Offset: 0x00BF7828
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

		// Token: 0x17007E81 RID: 32385
		// (get) Token: 0x060334D1 RID: 210129 RVA: 0x00BF9678 File Offset: 0x00BF7878
		// (set) Token: 0x060334D0 RID: 210128 RVA: 0x00BF9654 File Offset: 0x00BF7854
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

		// Token: 0x060334D2 RID: 210130 RVA: 0x00BF9680 File Offset: 0x00BF7880
		public List<RoguelikeEntryData> GetAllEntryDataList()
		{
			List<RoguelikeEntryData> list = new List<RoguelikeEntryData>();
			list.AddRange(this.GroupDataListRow1);
			list.AddRange(this.GroupDataListRow2);
			list.AddRange(this.GroupDataListRow3);
			return list;
		}

		// Token: 0x060334D3 RID: 210131 RVA: 0x00BF96AC File Offset: 0x00BF78AC
		public RogueHotEntryGroup GetConfig()
		{
			return RoguelikeConfig.Instance.GetRogueHotEntryGroupConfig(this.Id).Value;
		}

		// Token: 0x0401B399 RID: 111513
		public int Id;

		// Token: 0x0401B39A RID: 111514
		public int Index;

		// Token: 0x0401B39B RID: 111515
		public bool IsUnlock;

		// Token: 0x0401B39C RID: 111516
		private bool IsActiveInternal;

		// Token: 0x0401B39D RID: 111517
		private bool IsFocusInternal;

		// Token: 0x0401B39E RID: 111518
		public List<RoguelikeEntryData> GroupDataListRow1 = new List<RoguelikeEntryData>();

		// Token: 0x0401B39F RID: 111519
		public List<RoguelikeEntryData> GroupDataListRow2 = new List<RoguelikeEntryData>();

		// Token: 0x0401B3A0 RID: 111520
		public List<RoguelikeEntryData> GroupDataListRow3 = new List<RoguelikeEntryData>();

		// Token: 0x0401B3A1 RID: 111521
		[Nullable(2)]
		public Action<bool> ActiveStateChange;

		// Token: 0x0401B3A2 RID: 111522
		[Nullable(2)]
		public Action<bool> FocusStateChange;
	}
}
