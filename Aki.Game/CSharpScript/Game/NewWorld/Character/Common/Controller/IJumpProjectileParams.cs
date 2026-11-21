using System;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x02006312 RID: 25362
	public interface IJumpProjectileParams
	{
		// Token: 0x1700744E RID: 29774
		// (get) Token: 0x0603D615 RID: 251413
		// (set) Token: 0x0603D616 RID: 251414
		float Length { get; set; }

		// Token: 0x1700744F RID: 29775
		// (get) Token: 0x0603D617 RID: 251415
		// (set) Token: 0x0603D618 RID: 251416
		float AllTime { get; set; }

		// Token: 0x17007450 RID: 29776
		// (get) Token: 0x0603D619 RID: 251417
		// (set) Token: 0x0603D61A RID: 251418
		float Height0 { get; set; }

		// Token: 0x17007451 RID: 29777
		// (get) Token: 0x0603D61B RID: 251419
		// (set) Token: 0x0603D61C RID: 251420
		float ProjectileA { get; set; }

		// Token: 0x17007452 RID: 29778
		// (get) Token: 0x0603D61D RID: 251421
		// (set) Token: 0x0603D61E RID: 251422
		float ProjectileB { get; set; }
	}
}
