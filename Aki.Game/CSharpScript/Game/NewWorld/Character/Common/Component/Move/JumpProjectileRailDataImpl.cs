using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.NewWorld.Character.Common.Controller;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x020063A4 RID: 25508
	public class JumpProjectileRailDataImpl : IJumpProjectileRailData, IRailParam, IConnectionRailData, IJumpProjectileParams
	{
		// Token: 0x17007560 RID: 30048
		// (get) Token: 0x0603DD61 RID: 253281 RVA: 0x011F1B74 File Offset: 0x011EFD74
		// (set) Token: 0x0603DD62 RID: 253282 RVA: 0x011F1B7C File Offset: 0x011EFD7C
		public ERailMoveType RailType { get; set; }

		// Token: 0x17007561 RID: 30049
		// (get) Token: 0x0603DD63 RID: 253283 RVA: 0x011F1B85 File Offset: 0x011EFD85
		// (set) Token: 0x0603DD64 RID: 253284 RVA: 0x011F1B8D File Offset: 0x011EFD8D
		public ERailJumpType JumpType { get; set; }

		// Token: 0x17007562 RID: 30050
		// (get) Token: 0x0603DD65 RID: 253285 RVA: 0x011F1B96 File Offset: 0x011EFD96
		// (set) Token: 0x0603DD66 RID: 253286 RVA: 0x011F1B9E File Offset: 0x011EFD9E
		[Nullable(1)]
		public Vector RotatorFixedDirection { [NullableContext(1)] get; [NullableContext(1)] set; } = Vector.Create();

		// Token: 0x17007563 RID: 30051
		// (get) Token: 0x0603DD67 RID: 253287 RVA: 0x011F1BA7 File Offset: 0x011EFDA7
		// (set) Token: 0x0603DD68 RID: 253288 RVA: 0x011F1BAF File Offset: 0x011EFDAF
		public int ConnectionNextRail { get; set; }

		// Token: 0x17007564 RID: 30052
		// (get) Token: 0x0603DD69 RID: 253289 RVA: 0x011F1BB8 File Offset: 0x011EFDB8
		// (set) Token: 0x0603DD6A RID: 253290 RVA: 0x011F1BC0 File Offset: 0x011EFDC0
		public float ConnectionStartDistance { get; set; }

		// Token: 0x17007565 RID: 30053
		// (get) Token: 0x0603DD6B RID: 253291 RVA: 0x011F1BC9 File Offset: 0x011EFDC9
		// (set) Token: 0x0603DD6C RID: 253292 RVA: 0x011F1BD1 File Offset: 0x011EFDD1
		public float Length { get; set; }

		// Token: 0x17007566 RID: 30054
		// (get) Token: 0x0603DD6D RID: 253293 RVA: 0x011F1BDA File Offset: 0x011EFDDA
		// (set) Token: 0x0603DD6E RID: 253294 RVA: 0x011F1BE2 File Offset: 0x011EFDE2
		public float AllTime { get; set; }

		// Token: 0x17007567 RID: 30055
		// (get) Token: 0x0603DD6F RID: 253295 RVA: 0x011F1BEB File Offset: 0x011EFDEB
		// (set) Token: 0x0603DD70 RID: 253296 RVA: 0x011F1BF3 File Offset: 0x011EFDF3
		public float Height0 { get; set; }

		// Token: 0x17007568 RID: 30056
		// (get) Token: 0x0603DD71 RID: 253297 RVA: 0x011F1BFC File Offset: 0x011EFDFC
		// (set) Token: 0x0603DD72 RID: 253298 RVA: 0x011F1C04 File Offset: 0x011EFE04
		public float ProjectileA { get; set; }

		// Token: 0x17007569 RID: 30057
		// (get) Token: 0x0603DD73 RID: 253299 RVA: 0x011F1C0D File Offset: 0x011EFE0D
		// (set) Token: 0x0603DD74 RID: 253300 RVA: 0x011F1C15 File Offset: 0x011EFE15
		public float ProjectileB { get; set; }

		// Token: 0x1700756A RID: 30058
		// (get) Token: 0x0603DD75 RID: 253301 RVA: 0x011F1C1E File Offset: 0x011EFE1E
		// (set) Token: 0x0603DD76 RID: 253302 RVA: 0x011F1C26 File Offset: 0x011EFE26
		public float LastRate { get; set; }

		// Token: 0x1700756B RID: 30059
		// (get) Token: 0x0603DD77 RID: 253303 RVA: 0x011F1C2F File Offset: 0x011EFE2F
		// (set) Token: 0x0603DD78 RID: 253304 RVA: 0x011F1C37 File Offset: 0x011EFE37
		public float JumpTime { get; set; }
	}
}
