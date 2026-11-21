using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005473 RID: 21619
	public class IBulletHitConfigT
	{
		// Token: 0x170099BC RID: 39356
		// (get) Token: 0x06021F6D RID: 139117 RVA: 0x004AE712 File Offset: 0x004AC912
		// (set) Token: 0x06021F6E RID: 139118 RVA: 0x004AE71A File Offset: 0x004AC91A
		public THitBulletTypeUnion HitBullet { get; set; }

		// Token: 0x170099BD RID: 39357
		// (get) Token: 0x06021F6F RID: 139119 RVA: 0x004AE723 File Offset: 0x004AC923
		// (set) Token: 0x06021F70 RID: 139120 RVA: 0x004AE72B File Offset: 0x004AC92B
		public IHitTimeScaleRatioT AttackerHitTimeScaleRatio { get; set; }

		// Token: 0x170099BE RID: 39358
		// (get) Token: 0x06021F71 RID: 139121 RVA: 0x004AE734 File Offset: 0x004AC934
		// (set) Token: 0x06021F72 RID: 139122 RVA: 0x004AE73C File Offset: 0x004AC93C
		public IHitTimeScaleRatioT VictimHitTimeScaleRatio { get; set; }

		// Token: 0x06021F73 RID: 139123 RVA: 0x004AE745 File Offset: 0x004AC945
		public IBulletHitConfigT()
		{
			this.HitBullet = null;
			this.AttackerHitTimeScaleRatio = null;
			this.VictimHitTimeScaleRatio = null;
		}
	}
}
