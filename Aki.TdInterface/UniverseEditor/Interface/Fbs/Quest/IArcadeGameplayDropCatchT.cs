using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003D08 RID: 15624
	public class IArcadeGameplayDropCatchT
	{
		// Token: 0x17006B31 RID: 27441
		// (get) Token: 0x060158D3 RID: 88275 RVA: 0x0031D210 File Offset: 0x0031B410
		// (set) Token: 0x060158D4 RID: 88276 RVA: 0x0031D218 File Offset: 0x0031B418
		public EArcadeGameplayType Type { get; set; }

		// Token: 0x17006B32 RID: 27442
		// (get) Token: 0x060158D5 RID: 88277 RVA: 0x0031D221 File Offset: 0x0031B421
		// (set) Token: 0x060158D6 RID: 88278 RVA: 0x0031D229 File Offset: 0x0031B429
		public int LevelId { get; set; }

		// Token: 0x060158D7 RID: 88279 RVA: 0x0031D232 File Offset: 0x0031B432
		public IArcadeGameplayDropCatchT()
		{
			this.Type = EArcadeGameplayType.DropCatch;
			this.LevelId = 0;
		}
	}
}
