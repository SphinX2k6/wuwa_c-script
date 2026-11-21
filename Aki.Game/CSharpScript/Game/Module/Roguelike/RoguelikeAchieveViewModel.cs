using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D87 RID: 15751
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveViewModel
	{
		// Token: 0x06028476 RID: 164982 RVA: 0x00B4869C File Offset: 0x00B4689C
		[NullableContext(1)]
		public void Init(IRoguelikeAchieveViewInfo viewState)
		{
			this.ViewStateInternal = viewState;
		}

		// Token: 0x06028477 RID: 164983 RVA: 0x00B486A5 File Offset: 0x00B468A5
		[NullableContext(1)]
		public void SetViewState(IRoguelikeAchieveViewInfo viewState)
		{
			this.ViewStateInternal = viewState;
		}

		// Token: 0x17005259 RID: 21081
		// (get) Token: 0x06028479 RID: 164985 RVA: 0x00B486BC File Offset: 0x00B468BC
		// (set) Token: 0x06028478 RID: 164984 RVA: 0x00B486AE File Offset: 0x00B468AE
		public ERoguelikeAchieveViewMode Mode
		{
			get
			{
				return this.ViewStateInternal.Mode;
			}
			set
			{
				this.ViewStateInternal.Mode = value;
			}
		}

		// Token: 0x1700525A RID: 21082
		// (get) Token: 0x0602847A RID: 164986 RVA: 0x00B486C9 File Offset: 0x00B468C9
		public bool IsArchiveMode
		{
			get
			{
				return this.Mode == ERoguelikeAchieveViewMode.Archive;
			}
		}

		// Token: 0x1700525B RID: 21083
		// (get) Token: 0x0602847B RID: 164987 RVA: 0x00B486D4 File Offset: 0x00B468D4
		public bool IsUseArchiveMode
		{
			get
			{
				return this.Mode == ERoguelikeAchieveViewMode.UseArchive;
			}
		}

		// Token: 0x0602847C RID: 164988 RVA: 0x00B486E0 File Offset: 0x00B468E0
		public void TempArchiveSaved(int slotId)
		{
			this.IsTempRecordSaved = true;
			RoguelikeAchieveSlotData archiveBySlotId = this.GetArchiveBySlotId(slotId);
			if (archiveBySlotId != null)
			{
				int slotId2 = archiveBySlotId.ArchiveInfoData.SlotId;
				int index = archiveBySlotId.ArchiveInfoData.Index;
				archiveBySlotId.ArchiveInfoData = this.TempRecordInfo;
				archiveBySlotId.ArchiveInfoData.SlotId = slotId2;
				archiveBySlotId.ArchiveInfoData.Index = index;
			}
		}

		// Token: 0x0602847D RID: 164989 RVA: 0x00B4873C File Offset: 0x00B4693C
		public RoguelikeAchieveSlotData GetArchiveBySlotId(int slotId)
		{
			return this.ArchiveSlotList.Find(delegate(RoguelikeAchieveSlotData data)
			{
				RogueArchiveInfoData archiveInfoData = data.ArchiveInfoData;
				return archiveInfoData != null && archiveInfoData.SlotId == slotId;
			});
		}

		// Token: 0x1700525C RID: 21084
		// (get) Token: 0x0602847F RID: 164991 RVA: 0x00B4877B File Offset: 0x00B4697B
		// (set) Token: 0x0602847E RID: 164990 RVA: 0x00B4876D File Offset: 0x00B4696D
		public RogueArchiveInfoData TempRecordInfo
		{
			get
			{
				return this.ViewStateInternal.TempRecordInfo;
			}
			set
			{
				this.ViewStateInternal.TempRecordInfo = value;
			}
		}

		// Token: 0x1700525D RID: 21085
		// (get) Token: 0x06028480 RID: 164992 RVA: 0x00B48788 File Offset: 0x00B46988
		// (set) Token: 0x06028481 RID: 164993 RVA: 0x00B48790 File Offset: 0x00B46990
		public bool IsTempRecordSaved
		{
			get
			{
				return this.IsTempRecordSavedInternal;
			}
			set
			{
				this.IsTempRecordSavedInternal = value;
			}
		}

		// Token: 0x1700525E RID: 21086
		// (get) Token: 0x06028482 RID: 164994 RVA: 0x00B48799 File Offset: 0x00B46999
		public bool ShouldShowTempRecord
		{
			get
			{
				return this.IsArchiveMode && this.TempRecordInfo != null;
			}
		}

		// Token: 0x06028483 RID: 164995 RVA: 0x00B487B0 File Offset: 0x00B469B0
		public RoguelikeAchieveSlotData GetArchiveSlot(int slotIndex)
		{
			return this.ArchiveSlotList.Find((RoguelikeAchieveSlotData slotData) => slotData.SlotIndex == slotIndex);
		}

		// Token: 0x06028484 RID: 164996 RVA: 0x00B487E1 File Offset: 0x00B469E1
		public RogueArchiveInfoData GetArchiveInfo(int slotIndex)
		{
			RoguelikeAchieveSlotData archiveSlot = this.GetArchiveSlot(slotIndex);
			if (archiveSlot == null)
			{
				return null;
			}
			return archiveSlot.ArchiveInfoData;
		}

		// Token: 0x1700525F RID: 21087
		// (get) Token: 0x06028485 RID: 164997 RVA: 0x00B487F5 File Offset: 0x00B469F5
		// (set) Token: 0x06028486 RID: 164998 RVA: 0x00B487FD File Offset: 0x00B469FD
		public int SelectedRecordGridIndex
		{
			get
			{
				return this.SelectedRecordGridIndexInternal;
			}
			set
			{
				this.SelectedRecordGridIndexInternal = value;
			}
		}

		// Token: 0x17005260 RID: 21088
		// (get) Token: 0x06028487 RID: 164999 RVA: 0x00B48806 File Offset: 0x00B46A06
		// (set) Token: 0x06028488 RID: 165000 RVA: 0x00B4880E File Offset: 0x00B46A0E
		public bool IsTempRecordSelected
		{
			get
			{
				return this.IsTempRecordSelectedInternal;
			}
			set
			{
				this.IsTempRecordSelectedInternal = value;
			}
		}

		// Token: 0x17005261 RID: 21089
		// (get) Token: 0x06028489 RID: 165001 RVA: 0x00B48817 File Offset: 0x00B46A17
		public RogueArchiveInfoData SelectedArchiveInfoData
		{
			get
			{
				if (this.IsTempRecordSelectedInternal)
				{
					return this.TempRecordInfo;
				}
				RoguelikeAchieveSlotData selectedSlotData = this.SelectedSlotData;
				if (selectedSlotData == null)
				{
					return null;
				}
				return selectedSlotData.ArchiveInfoData;
			}
		}

		// Token: 0x17005262 RID: 21090
		// (get) Token: 0x0602848A RID: 165002 RVA: 0x00B48839 File Offset: 0x00B46A39
		public RoguelikeAchieveSlotData SelectedSlotData
		{
			get
			{
				if (this.SelectedRecordGridIndexInternal < 0)
				{
					return null;
				}
				if (this.SelectedRecordGridIndexInternal >= this.ArchiveSlotList.Count)
				{
					return null;
				}
				return this.ArchiveSlotList[this.SelectedRecordGridIndexInternal];
			}
		}

		// Token: 0x04015E61 RID: 89697
		public int InstId;

		// Token: 0x04015E62 RID: 89698
		[Nullable(1)]
		public List<RoguelikeAchieveSlotData> ArchiveSlotList = new List<RoguelikeAchieveSlotData>();

		// Token: 0x04015E63 RID: 89699
		private bool IsTempRecordSavedInternal;

		// Token: 0x04015E64 RID: 89700
		[Nullable(1)]
		private IRoguelikeAchieveViewInfo ViewStateInternal;

		// Token: 0x04015E65 RID: 89701
		private int SelectedRecordGridIndexInternal = -1;

		// Token: 0x04015E66 RID: 89702
		private bool IsTempRecordSelectedInternal;
	}
}
