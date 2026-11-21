using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060D1 RID: 24785
	public class ITrafficBulletLogicT
	{
		// Token: 0x1700B83F RID: 47167
		// (get) Token: 0x06029F20 RID: 171808 RVA: 0x005B9544 File Offset: 0x005B7744
		// (set) Token: 0x06029F21 RID: 171809 RVA: 0x005B954C File Offset: 0x005B774C
		public ECustomBulletLogic Type { get; set; }

		// Token: 0x1700B840 RID: 47168
		// (get) Token: 0x06029F22 RID: 171810 RVA: 0x005B9555 File Offset: 0x005B7755
		// (set) Token: 0x06029F23 RID: 171811 RVA: 0x005B955D File Offset: 0x005B775D
		public float MinSpeed { get; set; }

		// Token: 0x06029F24 RID: 171812 RVA: 0x005B9566 File Offset: 0x005B7766
		public ITrafficBulletLogicT()
		{
			this.Type = ECustomBulletLogic.TrafficBullet;
			this.MinSpeed = 0f;
		}
	}
}
