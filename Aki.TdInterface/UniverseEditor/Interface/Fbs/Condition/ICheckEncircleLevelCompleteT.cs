using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049E9 RID: 18921
	public class ICheckEncircleLevelCompleteT
	{
		// Token: 0x170088DB RID: 35035
		// (get) Token: 0x0601D904 RID: 121092 RVA: 0x0042953E File Offset: 0x0042773E
		// (set) Token: 0x0601D905 RID: 121093 RVA: 0x00429546 File Offset: 0x00427746
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x170088DC RID: 35036
		// (get) Token: 0x0601D906 RID: 121094 RVA: 0x0042954F File Offset: 0x0042774F
		// (set) Token: 0x0601D907 RID: 121095 RVA: 0x00429557 File Offset: 0x00427757
		public int EncircleLevelId { get; set; }

		// Token: 0x170088DD RID: 35037
		// (get) Token: 0x0601D908 RID: 121096 RVA: 0x00429560 File Offset: 0x00427760
		// (set) Token: 0x0601D909 RID: 121097 RVA: 0x00429568 File Offset: 0x00427768
		public bool IsCompleted { get; set; }

		// Token: 0x0601D90A RID: 121098 RVA: 0x00429571 File Offset: 0x00427771
		public ICheckEncircleLevelCompleteT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.EncircleLevelId = 0;
			this.IsCompleted = false;
		}
	}
}
