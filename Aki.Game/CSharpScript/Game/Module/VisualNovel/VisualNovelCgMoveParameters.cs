using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.VisualNovel
{
	// Token: 0x020037B6 RID: 14262
	[NullableContext(2)]
	[Nullable(0)]
	public readonly struct VisualNovelCgMoveParameters
	{
		// Token: 0x17004C5F RID: 19551
		// (get) Token: 0x060251AE RID: 151982 RVA: 0x00A77DC2 File Offset: 0x00A75FC2
		public VisualNovelTransform Target { get; }

		// Token: 0x17004C60 RID: 19552
		// (get) Token: 0x060251AF RID: 151983 RVA: 0x00A77DCA File Offset: 0x00A75FCA
		public float Duration { get; }

		// Token: 0x17004C61 RID: 19553
		// (get) Token: 0x060251B0 RID: 151984 RVA: 0x00A77DD2 File Offset: 0x00A75FD2
		public LTweenEase Ease { get; }

		// Token: 0x17004C62 RID: 19554
		// (get) Token: 0x060251B1 RID: 151985 RVA: 0x00A77DDA File Offset: 0x00A75FDA
		public UCurveFloat Curve { get; }

		// Token: 0x060251B2 RID: 151986 RVA: 0x00A77DE2 File Offset: 0x00A75FE2
		public VisualNovelCgMoveParameters(VisualNovelTransform target, float duration, LTweenEase ease, UCurveFloat curve)
		{
			this.Target = target;
			this.Duration = duration;
			this.Ease = ease;
			this.Curve = curve;
		}
	}
}
