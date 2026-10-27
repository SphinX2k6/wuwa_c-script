using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AC1 RID: 19137
	public class ICheckLevelPlayCompleteNumberT
	{
		// Token: 0x17008ABA RID: 35514
		// (get) Token: 0x0601E0B8 RID: 123064 RVA: 0x00437560 File Offset: 0x00435760
		// (set) Token: 0x0601E0B9 RID: 123065 RVA: 0x00437568 File Offset: 0x00435768
		public ECondition Type { get; set; }

		// Token: 0x17008ABB RID: 35515
		// (get) Token: 0x0601E0BA RID: 123066 RVA: 0x00437571 File Offset: 0x00435771
		// (set) Token: 0x0601E0BB RID: 123067 RVA: 0x00437579 File Offset: 0x00435779
		public int LevelId { get; set; }

		// Token: 0x17008ABC RID: 35516
		// (get) Token: 0x0601E0BC RID: 123068 RVA: 0x00437582 File Offset: 0x00435782
		// (set) Token: 0x0601E0BD RID: 123069 RVA: 0x0043758A File Offset: 0x0043578A
		public ECompare Compare { get; set; }

		// Token: 0x17008ABD RID: 35517
		// (get) Token: 0x0601E0BE RID: 123070 RVA: 0x00437593 File Offset: 0x00435793
		// (set) Token: 0x0601E0BF RID: 123071 RVA: 0x0043759B File Offset: 0x0043579B
		public int Number { get; set; }

		// Token: 0x0601E0C0 RID: 123072 RVA: 0x004375A4 File Offset: 0x004357A4
		public ICheckLevelPlayCompleteNumberT()
		{
			this.Type = ECondition.CompareVar;
			this.LevelId = 0;
			this.Compare = ECompare.Eq;
			this.Number = 0;
		}
	}
}
