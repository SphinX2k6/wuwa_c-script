using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AC4 RID: 23236
	public class ITrafficBulletLogicT
	{
		// Token: 0x1700AF03 RID: 44803
		// (get) Token: 0x0602799A RID: 162202 RVA: 0x0057225C File Offset: 0x0057045C
		// (set) Token: 0x0602799B RID: 162203 RVA: 0x00572264 File Offset: 0x00570464
		public ECustomBulletLogic Type { get; set; }

		// Token: 0x1700AF04 RID: 44804
		// (get) Token: 0x0602799C RID: 162204 RVA: 0x0057226D File Offset: 0x0057046D
		// (set) Token: 0x0602799D RID: 162205 RVA: 0x00572275 File Offset: 0x00570475
		public float MinSpeed { get; set; }

		// Token: 0x0602799E RID: 162206 RVA: 0x0057227E File Offset: 0x0057047E
		public ITrafficBulletLogicT()
		{
			this.Type = ECustomBulletLogic.TrafficBullet;
			this.MinSpeed = 0f;
		}
	}
}
