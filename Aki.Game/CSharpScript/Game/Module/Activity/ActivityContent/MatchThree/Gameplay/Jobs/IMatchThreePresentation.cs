using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x0200549E RID: 21662
	[NullableContext(1)]
	public interface IMatchThreePresentation
	{
		// Token: 0x06035B85 RID: 220037
		UniTask PlaySwapAsync(GridPosition a, GridPosition b);

		// Token: 0x06035B86 RID: 220038
		UniTask PlaySwapFailAsync(GridPosition a, GridPosition b);

		// Token: 0x06035B87 RID: 220039
		UniTask PlayBoardAsync(BoardSegment board);

		// Token: 0x06035B88 RID: 220040
		UniTask PlayMechanicTipAsync(IReadOnlyList<MechanicTipEvent> tips);

		// Token: 0x06035B89 RID: 220041
		UniTask PlaySkillTipAsync(IReadOnlyList<SkillTipEvent> tips);

		// Token: 0x06035B8A RID: 220042
		UniTask PlayPieceTransformAsync(IReadOnlyList<PieceTransformEvent> transforms);

		// Token: 0x06035B8B RID: 220043
		UniTask PlayPieceAttachAsync(IReadOnlyList<PieceAttachEvent> attaches);

		// Token: 0x06035B8C RID: 220044
		UniTask PlayPieceRecolorAsync(IReadOnlyList<PieceRecolorEvent> recolors);

		// Token: 0x06035B8D RID: 220045
		UniTask PlaySkillTrailAsync(IReadOnlyList<SkillTrailEvent> trails);

		// Token: 0x06035B8E RID: 220046
		UniTask PlayMechanicTrailAsync(IReadOnlyList<MechanicTrailEvent> trails);

		// Token: 0x06035B8F RID: 220047
		UniTask PlayRecycleTrailSettleAsync(IReadOnlyList<RecycleTrailSettleEvent> settles);

		// Token: 0x06035B90 RID: 220048
		UniTask PlayScorePopAsync(IReadOnlyList<ScorePopEvent> pops);

		// Token: 0x06035B91 RID: 220049
		UniTask PlayReshuffleAsync();
	}
}
