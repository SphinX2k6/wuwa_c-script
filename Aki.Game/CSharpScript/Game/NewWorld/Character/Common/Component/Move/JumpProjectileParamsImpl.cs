using System;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A2 RID: 25506
	public class JumpProjectileParamsImpl : IJumpProjectileParams
	{
		// Token: 0x17007559 RID: 30041
		// (get) Token: 0x0603DD52 RID: 253266 RVA: 0x011F1B17 File Offset: 0x011EFD17
		// (set) Token: 0x0603DD53 RID: 253267 RVA: 0x011F1B1F File Offset: 0x011EFD1F
		public float Length { get; set; }

		// Token: 0x1700755A RID: 30042
		// (get) Token: 0x0603DD54 RID: 253268 RVA: 0x011F1B28 File Offset: 0x011EFD28
		// (set) Token: 0x0603DD55 RID: 253269 RVA: 0x011F1B30 File Offset: 0x011EFD30
		public float AllTime { get; set; }

		// Token: 0x1700755B RID: 30043
		// (get) Token: 0x0603DD56 RID: 253270 RVA: 0x011F1B39 File Offset: 0x011EFD39
		// (set) Token: 0x0603DD57 RID: 253271 RVA: 0x011F1B41 File Offset: 0x011EFD41
		public float Height0 { get; set; }

		// Token: 0x1700755C RID: 30044
		// (get) Token: 0x0603DD58 RID: 253272 RVA: 0x011F1B4A File Offset: 0x011EFD4A
		// (set) Token: 0x0603DD59 RID: 253273 RVA: 0x011F1B52 File Offset: 0x011EFD52
		public float ProjectileA { get; set; }

		// Token: 0x1700755D RID: 30045
		// (get) Token: 0x0603DD5A RID: 253274 RVA: 0x011F1B5B File Offset: 0x011EFD5B
		// (set) Token: 0x0603DD5B RID: 253275 RVA: 0x011F1B63 File Offset: 0x011EFD63
		public float ProjectileB { get; set; }
	}
}
