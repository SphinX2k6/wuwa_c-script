using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067B4 RID: 26548
	public class IFireBulletEffectT
	{
		// Token: 0x1700C50A RID: 50442
		// (get) Token: 0x0602E335 RID: 189237 RVA: 0x0064F2EC File Offset: 0x0064D4EC
		// (set) Token: 0x0602E336 RID: 189238 RVA: 0x0064F2F4 File Offset: 0x0064D4F4
		public int Id { get; set; }

		// Token: 0x1700C50B RID: 50443
		// (get) Token: 0x0602E337 RID: 189239 RVA: 0x0064F2FD File Offset: 0x0064D4FD
		// (set) Token: 0x0602E338 RID: 189240 RVA: 0x0064F305 File Offset: 0x0064D505
		public int X { get; set; }

		// Token: 0x1700C50C RID: 50444
		// (get) Token: 0x0602E339 RID: 189241 RVA: 0x0064F30E File Offset: 0x0064D50E
		// (set) Token: 0x0602E33A RID: 189242 RVA: 0x0064F316 File Offset: 0x0064D516
		public int Y { get; set; }

		// Token: 0x1700C50D RID: 50445
		// (get) Token: 0x0602E33B RID: 189243 RVA: 0x0064F31F File Offset: 0x0064D51F
		// (set) Token: 0x0602E33C RID: 189244 RVA: 0x0064F327 File Offset: 0x0064D527
		public int Z { get; set; }

		// Token: 0x1700C50E RID: 50446
		// (get) Token: 0x0602E33D RID: 189245 RVA: 0x0064F330 File Offset: 0x0064D530
		// (set) Token: 0x0602E33E RID: 189246 RVA: 0x0064F338 File Offset: 0x0064D538
		public EBulletLauncher Launcher { get; set; }

		// Token: 0x1700C50F RID: 50447
		// (get) Token: 0x0602E33F RID: 189247 RVA: 0x0064F341 File Offset: 0x0064D541
		// (set) Token: 0x0602E340 RID: 189248 RVA: 0x0064F349 File Offset: 0x0064D549
		public byte NullMask { get; set; }

		// Token: 0x0602E341 RID: 189249 RVA: 0x0064F352 File Offset: 0x0064D552
		public IFireBulletEffectT()
		{
			this.Id = 0;
			this.X = 0;
			this.Y = 0;
			this.Z = 0;
			this.Launcher = EBulletLauncher.Player;
			this.NullMask = 0;
		}
	}
}
