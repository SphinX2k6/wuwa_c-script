using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049A7 RID: 18855
	public class ICheckCollectedSunSpiritCountT
	{
		// Token: 0x1700884D RID: 34893
		// (get) Token: 0x0601D6D0 RID: 120528 RVA: 0x0042594F File Offset: 0x00423B4F
		// (set) Token: 0x0601D6D1 RID: 120529 RVA: 0x00425957 File Offset: 0x00423B57
		public ECondition Type { get; set; }

		// Token: 0x1700884E RID: 34894
		// (get) Token: 0x0601D6D2 RID: 120530 RVA: 0x00425960 File Offset: 0x00423B60
		// (set) Token: 0x0601D6D3 RID: 120531 RVA: 0x00425968 File Offset: 0x00423B68
		public int DungeonId { get; set; }

		// Token: 0x1700884F RID: 34895
		// (get) Token: 0x0601D6D4 RID: 120532 RVA: 0x00425971 File Offset: 0x00423B71
		// (set) Token: 0x0601D6D5 RID: 120533 RVA: 0x00425979 File Offset: 0x00423B79
		public int AreaId { get; set; }

		// Token: 0x17008850 RID: 34896
		// (get) Token: 0x0601D6D6 RID: 120534 RVA: 0x00425982 File Offset: 0x00423B82
		// (set) Token: 0x0601D6D7 RID: 120535 RVA: 0x0042598A File Offset: 0x00423B8A
		public ECompare Compare { get; set; }

		// Token: 0x17008851 RID: 34897
		// (get) Token: 0x0601D6D8 RID: 120536 RVA: 0x00425993 File Offset: 0x00423B93
		// (set) Token: 0x0601D6D9 RID: 120537 RVA: 0x0042599B File Offset: 0x00423B9B
		public int Count { get; set; }

		// Token: 0x17008852 RID: 34898
		// (get) Token: 0x0601D6DA RID: 120538 RVA: 0x004259A4 File Offset: 0x00423BA4
		// (set) Token: 0x0601D6DB RID: 120539 RVA: 0x004259AC File Offset: 0x00423BAC
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601D6DC RID: 120540 RVA: 0x004259B5 File Offset: 0x00423BB5
		public ICheckCollectedSunSpiritCountT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.AreaId = 0;
			this.Compare = ECompare.Eq;
			this.Count = 0;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
