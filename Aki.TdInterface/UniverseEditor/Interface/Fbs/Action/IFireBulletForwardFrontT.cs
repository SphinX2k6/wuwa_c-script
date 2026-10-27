using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B7 RID: 26551
	public class IFireBulletForwardFrontT
	{
		// Token: 0x1700C514 RID: 50452
		// (get) Token: 0x0602E35C RID: 189276 RVA: 0x0064F859 File Offset: 0x0064DA59
		// (set) Token: 0x0602E35D RID: 189277 RVA: 0x0064F861 File Offset: 0x0064DA61
		public EFireBulletType Type { get; set; }

		// Token: 0x1700C515 RID: 50453
		// (get) Token: 0x0602E35E RID: 189278 RVA: 0x0064F86A File Offset: 0x0064DA6A
		// (set) Token: 0x0602E35F RID: 189279 RVA: 0x0064F872 File Offset: 0x0064DA72
		public long BulletId { get; set; }

		// Token: 0x1700C516 RID: 50454
		// (get) Token: 0x0602E360 RID: 189280 RVA: 0x0064F87B File Offset: 0x0064DA7B
		// (set) Token: 0x0602E361 RID: 189281 RVA: 0x0064F883 File Offset: 0x0064DA83
		public TTargetEntityUnion Launcher { get; set; }

		// Token: 0x0602E362 RID: 189282 RVA: 0x0064F88C File Offset: 0x0064DA8C
		public IFireBulletForwardFrontT()
		{
			this.Type = EFireBulletType.TrackTarget;
			this.BulletId = 0L;
			this.Launcher = null;
		}
	}
}
