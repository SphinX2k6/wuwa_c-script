using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B4 RID: 14260
	[NullableContext(1)]
	[Nullable(0)]
	public readonly struct VisualNovelCharacterMoveParameters
	{
		// Token: 0x17004C58 RID: 19544
		// (get) Token: 0x060251A5 RID: 151973 RVA: 0x00A77D54 File Offset: 0x00A75F54
		public VisualNovelCharacterState TargetState { get; }

		// Token: 0x17004C59 RID: 19545
		// (get) Token: 0x060251A6 RID: 151974 RVA: 0x00A77D5C File Offset: 0x00A75F5C
		public float Duration { get; }

		// Token: 0x17004C5A RID: 19546
		// (get) Token: 0x060251A7 RID: 151975 RVA: 0x00A77D64 File Offset: 0x00A75F64
		public LTweenEase Ease { get; }

		// Token: 0x17004C5B RID: 19547
		// (get) Token: 0x060251A8 RID: 151976 RVA: 0x00A77D6C File Offset: 0x00A75F6C
		[Nullable(2)]
		public UCurveFloat Curve { [NullableContext(2)] get; }

		// Token: 0x060251A9 RID: 151977 RVA: 0x00A77D74 File Offset: 0x00A75F74
		public VisualNovelCharacterMoveParameters(VisualNovelCharacterState targetState, float duration, LTweenEase ease, [Nullable(2)] UCurveFloat curve)
		{
			this.TargetState = targetState;
			this.Duration = duration;
			this.Ease = ease;
			this.Curve = curve;
		}
	}
}
