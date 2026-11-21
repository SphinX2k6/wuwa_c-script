using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005038 RID: 20536
	public class ICheckTargetSunSpiritCollectedT
	{
		// Token: 0x170092F2 RID: 37618
		// (get) Token: 0x0602016B RID: 131435 RVA: 0x00473BC1 File Offset: 0x00471DC1
		// (set) Token: 0x0602016C RID: 131436 RVA: 0x00473BC9 File Offset: 0x00471DC9
		public ECondition Type { get; set; }

		// Token: 0x170092F3 RID: 37619
		// (get) Token: 0x0602016D RID: 131437 RVA: 0x00473BD2 File Offset: 0x00471DD2
		// (set) Token: 0x0602016E RID: 131438 RVA: 0x00473BDA File Offset: 0x00471DDA
		public int DungeonId { get; set; }

		// Token: 0x170092F4 RID: 37620
		// (get) Token: 0x0602016F RID: 131439 RVA: 0x00473BE3 File Offset: 0x00471DE3
		// (set) Token: 0x06020170 RID: 131440 RVA: 0x00473BEB File Offset: 0x00471DEB
		public int SunSpiritEntityId { get; set; }

		// Token: 0x170092F5 RID: 37621
		// (get) Token: 0x06020171 RID: 131441 RVA: 0x00473BF4 File Offset: 0x00471DF4
		// (set) Token: 0x06020172 RID: 131442 RVA: 0x00473BFC File Offset: 0x00471DFC
		public bool IsCollected { get; set; }

		// Token: 0x170092F6 RID: 37622
		// (get) Token: 0x06020173 RID: 131443 RVA: 0x00473C05 File Offset: 0x00471E05
		// (set) Token: 0x06020174 RID: 131444 RVA: 0x00473C0D File Offset: 0x00471E0D
		public TOnlinePlayerConditionTargetUnion OnlinePlayerConditionTargetOption { get; set; }

		// Token: 0x06020175 RID: 131445 RVA: 0x00473C16 File Offset: 0x00471E16
		public ICheckTargetSunSpiritCollectedT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.SunSpiritEntityId = 0;
			this.IsCollected = false;
			this.OnlinePlayerConditionTargetOption = null;
		}
	}
}
