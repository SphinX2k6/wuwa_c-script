using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005812 RID: 22546
	public class IFollowShooterMontageT
	{
		// Token: 0x1700A332 RID: 41778
		// (get) Token: 0x060247AC RID: 149420 RVA: 0x00503383 File Offset: 0x00501583
		// (set) Token: 0x060247AD RID: 149421 RVA: 0x0050338B File Offset: 0x0050158B
		public EFollowShooterMontageType Name { get; set; }

		// Token: 0x1700A333 RID: 41779
		// (get) Token: 0x060247AE RID: 149422 RVA: 0x00503394 File Offset: 0x00501594
		// (set) Token: 0x060247AF RID: 149423 RVA: 0x0050339C File Offset: 0x0050159C
		public string Path { get; set; }

		// Token: 0x060247B0 RID: 149424 RVA: 0x005033A5 File Offset: 0x005015A5
		public IFollowShooterMontageT()
		{
			this.Name = EFollowShooterMontageType.Born;
			this.Path = null;
		}
	}
}
