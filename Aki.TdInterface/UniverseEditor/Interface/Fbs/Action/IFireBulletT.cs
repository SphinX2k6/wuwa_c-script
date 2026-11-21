using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E31 RID: 28209
	public class IFireBulletT
	{
		// Token: 0x1700CEB6 RID: 52918
		// (get) Token: 0x06030B5B RID: 199515 RVA: 0x0069C63D File Offset: 0x0069A83D
		// (set) Token: 0x06030B5C RID: 199516 RVA: 0x0069C645 File Offset: 0x0069A845
		public TFireBulletUnion Type { get; set; }

		// Token: 0x1700CEB7 RID: 52919
		// (get) Token: 0x06030B5D RID: 199517 RVA: 0x0069C64E File Offset: 0x0069A84E
		// (set) Token: 0x06030B5E RID: 199518 RVA: 0x0069C656 File Offset: 0x0069A856
		public EBulletLauncher Launcher { get; set; }

		// Token: 0x1700CEB8 RID: 52920
		// (get) Token: 0x06030B5F RID: 199519 RVA: 0x0069C65F File Offset: 0x0069A85F
		// (set) Token: 0x06030B60 RID: 199520 RVA: 0x0069C667 File Offset: 0x0069A867
		public byte NullMask { get; set; }

		// Token: 0x06030B61 RID: 199521 RVA: 0x0069C670 File Offset: 0x0069A870
		public IFireBulletT()
		{
			this.Type = null;
			this.Launcher = EBulletLauncher.Player;
			this.NullMask = 0;
		}
	}
}
