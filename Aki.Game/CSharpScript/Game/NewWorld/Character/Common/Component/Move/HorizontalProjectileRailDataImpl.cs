using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Move
{
	// Token: 0x0200639F RID: 25503
	public class HorizontalProjectileRailDataImpl : IHorizontalProjectileRailData, IRailParam, IConnectionRailData
	{
		// Token: 0x17007552 RID: 30034
		// (get) Token: 0x0603DD42 RID: 253250 RVA: 0x011F1A85 File Offset: 0x011EFC85
		// (set) Token: 0x0603DD43 RID: 253251 RVA: 0x011F1A8D File Offset: 0x011EFC8D
		public ERailMoveType RailType { get; set; }

		// Token: 0x17007553 RID: 30035
		// (get) Token: 0x0603DD44 RID: 253252 RVA: 0x011F1A96 File Offset: 0x011EFC96
		// (set) Token: 0x0603DD45 RID: 253253 RVA: 0x011F1A9E File Offset: 0x011EFC9E
		public ERailJumpType JumpType { get; set; }

		// Token: 0x17007554 RID: 30036
		// (get) Token: 0x0603DD46 RID: 253254 RVA: 0x011F1AA7 File Offset: 0x011EFCA7
		// (set) Token: 0x0603DD47 RID: 253255 RVA: 0x011F1AAF File Offset: 0x011EFCAF
		[Nullable(1)]
		public Vector RotatorFixedDirection { [NullableContext(1)] get; [NullableContext(1)] set; } = Vector.Create();

		// Token: 0x17007555 RID: 30037
		// (get) Token: 0x0603DD48 RID: 253256 RVA: 0x011F1AB8 File Offset: 0x011EFCB8
		// (set) Token: 0x0603DD49 RID: 253257 RVA: 0x011F1AC0 File Offset: 0x011EFCC0
		public int ConnectionNextRail { get; set; }

		// Token: 0x17007556 RID: 30038
		// (get) Token: 0x0603DD4A RID: 253258 RVA: 0x011F1AC9 File Offset: 0x011EFCC9
		// (set) Token: 0x0603DD4B RID: 253259 RVA: 0x011F1AD1 File Offset: 0x011EFCD1
		public float ConnectionStartDistance { get; set; }
	}
}
