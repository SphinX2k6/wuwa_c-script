using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E5E RID: 20062
	public class ICheckCollectedSunSpiritCountT
	{
		// Token: 0x17008F08 RID: 36616
		// (get) Token: 0x0601F0F5 RID: 127221 RVA: 0x00455E03 File Offset: 0x00454003
		// (set) Token: 0x0601F0F6 RID: 127222 RVA: 0x00455E0B File Offset: 0x0045400B
		public ECondition Type { get; set; }

		// Token: 0x17008F09 RID: 36617
		// (get) Token: 0x0601F0F7 RID: 127223 RVA: 0x00455E14 File Offset: 0x00454014
		// (set) Token: 0x0601F0F8 RID: 127224 RVA: 0x00455E1C File Offset: 0x0045401C
		public int DungeonId { get; set; }

		// Token: 0x17008F0A RID: 36618
		// (get) Token: 0x0601F0F9 RID: 127225 RVA: 0x00455E25 File Offset: 0x00454025
		// (set) Token: 0x0601F0FA RID: 127226 RVA: 0x00455E2D File Offset: 0x0045402D
		public int AreaId { get; set; }

		// Token: 0x17008F0B RID: 36619
		// (get) Token: 0x0601F0FB RID: 127227 RVA: 0x00455E36 File Offset: 0x00454036
		// (set) Token: 0x0601F0FC RID: 127228 RVA: 0x00455E3E File Offset: 0x0045403E
		public ECompare Compare { get; set; }

		// Token: 0x17008F0C RID: 36620
		// (get) Token: 0x0601F0FD RID: 127229 RVA: 0x00455E47 File Offset: 0x00454047
		// (set) Token: 0x0601F0FE RID: 127230 RVA: 0x00455E4F File Offset: 0x0045404F
		public int Count { get; set; }

		// Token: 0x17008F0D RID: 36621
		// (get) Token: 0x0601F0FF RID: 127231 RVA: 0x00455E58 File Offset: 0x00454058
		// (set) Token: 0x0601F100 RID: 127232 RVA: 0x00455E60 File Offset: 0x00454060
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x0601F101 RID: 127233 RVA: 0x00455E69 File Offset: 0x00454069
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
