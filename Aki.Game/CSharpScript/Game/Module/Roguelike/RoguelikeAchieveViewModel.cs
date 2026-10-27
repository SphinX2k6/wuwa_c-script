using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004DBE RID: 19902
	[NullableContext(2)]
	[Nullable(0)]
	public class RoguelikeAchieveViewModel
	{
		// Token: 0x06033609 RID: 210441 RVA: 0x00BFF15C File Offset: 0x00BFD35C
		[NullableContext(1)]
		public void Init(IRoguelikeAchieveViewInfo viewState)
		{
			this.ViewStateInternal = viewState;
		}

		// Token: 0x0603360A RID: 210442 RVA: 0x00BFF165 File Offset: 0x00BFD365
		[NullableContext(1)]
		public void SetViewState(IRoguelikeAchieveViewInfo viewState)
		{
			this.ViewStateInternal = viewState;
		}

		// Token: 0x17007EA9 RID: 32425
		// (get) Token: 0x0603360C RID: 210444 RVA: 0x00BFF17C File Offset: 0x00BFD37C
		// (set) Token: 0x0603360B RID: 210443 RVA: 0x00BFF16E File Offset: 0x00BFD36E
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

		// Token: 0x17007EAA RID: 32426
		// (get) Token: 0x0603360D RID: 210445 RVA: 0x00BFF189 File Offset: 0x00BFD389
		public bool IsArchiveMode
		{
			get
			{
				return this.Mode == ERoguelikeAchieveViewMode.Archive;
			}
		}

		// Token: 0x17007EAB RID: 32427
		// (get) Token: 0x0603360E RID: 210446 RVA: 0x00BFF194 File Offset: 0x00BFD394
		public bool IsUseArchiveMode
		{
			get
			{
				return this.Mode == ERoguelikeAchieveViewMode.UseArchive;
			}
		}

		// Token: 0x0603360F RID: 210447 RVA: 0x00BFF1A0 File Offset: 0x00BFD3A0
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

		// Token: 0x06033610 RID: 210448 RVA: 0x00BFF1FC File Offset: 0x00BFD3FC
		public RoguelikeAchieveSlotData GetArchiveBySlotId(int slotId)
		{
			return this.ArchiveSlotList.Find(delegate(RoguelikeAchieveSlotData data)
			{
				RogueArchiveInfoData archiveInfoData = data.ArchiveInfoData;
				return archiveInfoData != null && archiveInfoData.SlotId == slotId;
			});
		}

		// Token: 0x17007EAC RID: 32428
		// (get) Token: 0x06033612 RID: 210450 RVA: 0x00BFF23B File Offset: 0x00BFD43B
		// (set) Token: 0x06033611 RID: 210449 RVA: 0x00BFF22D File Offset: 0x00BFD42D
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

		// Token: 0x17007EAD RID: 32429
		// (get) Token: 0x06033613 RID: 210451 RVA: 0x00BFF248 File Offset: 0x00BFD448
		// (set) Token: 0x06033614 RID: 210452 RVA: 0x00BFF250 File Offset: 0x00BFD450
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

		// Token: 0x17007EAE RID: 32430
		// (get) Token: 0x06033615 RID: 210453 RVA: 0x00BFF259 File Offset: 0x00BFD459
		public bool ShouldShowTempRecord
		{
			get
			{
				return this.IsArchiveMode && this.TempRecordInfo != null;
			}
		}

		// Token: 0x06033616 RID: 210454 RVA: 0x00BFF270 File Offset: 0x00BFD470
		public RoguelikeAchieveSlotData GetArchiveSlot(int slotIndex)
		{
			return this.ArchiveSlotList.Find((RoguelikeAchieveSlotData slotData) => slotData.SlotIndex == slotIndex);
		}

		// Token: 0x06033617 RID: 210455 RVA: 0x00BFF2A1 File Offset: 0x00BFD4A1
		public RogueArchiveInfoData GetArchiveInfo(int slotIndex)
		{
			RoguelikeAchieveSlotData archiveSlot = this.GetArchiveSlot(slotIndex);
			if (archiveSlot == null)
			{
				return null;
			}
			return archiveSlot.ArchiveInfoData;
		}

		// Token: 0x17007EAF RID: 32431
		// (get) Token: 0x06033618 RID: 210456 RVA: 0x00BFF2B5 File Offset: 0x00BFD4B5
		// (set) Token: 0x06033619 RID: 210457 RVA: 0x00BFF2BD File Offset: 0x00BFD4BD
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

		// Token: 0x17007EB0 RID: 32432
		// (get) Token: 0x0603361A RID: 210458 RVA: 0x00BFF2C6 File Offset: 0x00BFD4C6
		// (set) Token: 0x0603361B RID: 210459 RVA: 0x00BFF2CE File Offset: 0x00BFD4CE
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

		// Token: 0x17007EB1 RID: 32433
		// (get) Token: 0x0603361C RID: 210460 RVA: 0x00BFF2D7 File Offset: 0x00BFD4D7
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

		// Token: 0x17007EB2 RID: 32434
		// (get) Token: 0x0603361D RID: 210461 RVA: 0x00BFF2F9 File Offset: 0x00BFD4F9
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

		// Token: 0x0401B48E RID: 111758
		public int InstId;

		// Token: 0x0401B48F RID: 111759
		[Nullable(1)]
		public List<RoguelikeAchieveSlotData> ArchiveSlotList = new List<RoguelikeAchieveSlotData>();

		// Token: 0x0401B490 RID: 111760
		private bool IsTempRecordSavedInternal;

		// Token: 0x0401B491 RID: 111761
		[Nullable(1)]
		private IRoguelikeAchieveViewInfo ViewStateInternal;

		// Token: 0x0401B492 RID: 111762
		private int SelectedRecordGridIndexInternal = -1;

		// Token: 0x0401B493 RID: 111763
		private bool IsTempRecordSelectedInternal;
	}
}
