using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B1 RID: 14257
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct VisualNovelBackgroundMoveParameters
	{
		// Token: 0x17004C50 RID: 19536
		// (get) Token: 0x0602519A RID: 151962 RVA: 0x00A77CD5 File Offset: 0x00A75ED5
		public VisualNovelTransform Target { get; }

		// Token: 0x17004C51 RID: 19537
		// (get) Token: 0x0602519B RID: 151963 RVA: 0x00A77CDD File Offset: 0x00A75EDD
		public float Duration { get; }

		// Token: 0x17004C52 RID: 19538
		// (get) Token: 0x0602519C RID: 151964 RVA: 0x00A77CE5 File Offset: 0x00A75EE5
		public LTweenEase Ease { get; }

		// Token: 0x17004C53 RID: 19539
		// (get) Token: 0x0602519D RID: 151965 RVA: 0x00A77CED File Offset: 0x00A75EED
		public UCurveFloat Curve { get; }

		// Token: 0x0602519E RID: 151966 RVA: 0x00A77CF5 File Offset: 0x00A75EF5
		public VisualNovelBackgroundMoveParameters(VisualNovelTransform target, float duration, LTweenEase ease, UCurveFloat curve)
		{
			this.Target = target;
			this.Duration = duration;
			this.Ease = ease;
			this.Curve = curve;
		}
	}
}
