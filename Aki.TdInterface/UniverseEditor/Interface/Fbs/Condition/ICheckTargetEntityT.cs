using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02005035 RID: 20533
	public class ICheckTargetEntityT
	{
		// Token: 0x170092EA RID: 37610
		// (get) Token: 0x0602014B RID: 131403 RVA: 0x00473717 File Offset: 0x00471917
		// (set) Token: 0x0602014C RID: 131404 RVA: 0x0047371F File Offset: 0x0047191F
		public ECheckEntity Type { get; set; }

		// Token: 0x170092EB RID: 37611
		// (get) Token: 0x0602014D RID: 131405 RVA: 0x00473728 File Offset: 0x00471928
		// (set) Token: 0x0602014E RID: 131406 RVA: 0x00473730 File Offset: 0x00471930
		public TTargetEntityUnion TargetEntity { get; set; }

		// Token: 0x0602014F RID: 131407 RVA: 0x00473739 File Offset: 0x00471939
		public ICheckTargetEntityT()
		{
			this.Type = ECheckEntity.OnlinePlayer;
			this.TargetEntity = null;
		}
	}
}
