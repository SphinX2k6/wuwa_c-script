using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005020 RID: 20512
	public class ICheckSyncLevelPlayCompleteNumberT
	{
		// Token: 0x170092C6 RID: 37574
		// (get) Token: 0x06020073 RID: 131187 RVA: 0x004719A4 File Offset: 0x0046FBA4
		// (set) Token: 0x06020074 RID: 131188 RVA: 0x004719AC File Offset: 0x0046FBAC
		public ECondition Type { get; set; }

		// Token: 0x170092C7 RID: 37575
		// (get) Token: 0x06020075 RID: 131189 RVA: 0x004719B5 File Offset: 0x0046FBB5
		// (set) Token: 0x06020076 RID: 131190 RVA: 0x004719BD File Offset: 0x0046FBBD
		public int SyncId { get; set; }

		// Token: 0x170092C8 RID: 37576
		// (get) Token: 0x06020077 RID: 131191 RVA: 0x004719C6 File Offset: 0x0046FBC6
		// (set) Token: 0x06020078 RID: 131192 RVA: 0x004719CE File Offset: 0x0046FBCE
		public ECompare Compare { get; set; }

		// Token: 0x170092C9 RID: 37577
		// (get) Token: 0x06020079 RID: 131193 RVA: 0x004719D7 File Offset: 0x0046FBD7
		// (set) Token: 0x0602007A RID: 131194 RVA: 0x004719DF File Offset: 0x0046FBDF
		public int Number { get; set; }

		// Token: 0x0602007B RID: 131195 RVA: 0x004719E8 File Offset: 0x0046FBE8
		public ICheckSyncLevelPlayCompleteNumberT()
		{
			this.Type = ECondition.CompareVar;
			this.SyncId = 0;
			this.Compare = ECompare.Eq;
			this.Number = 0;
		}
	}
}
