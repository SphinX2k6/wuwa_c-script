using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay.Jobs
{
	// Token: 0x02006520 RID: 25888
	[NullableContext(1)]
	public interface IMatchThreePresentation
	{
		// Token: 0x06040EC1 RID: 265921
		UniTask PlaySwapAsync(GridPosition a, GridPosition b);

		// Token: 0x06040EC2 RID: 265922
		UniTask PlaySwapFailAsync(GridPosition a, GridPosition b);

		// Token: 0x06040EC3 RID: 265923
		UniTask PlayBoardAsync(BoardSegment board);

		// Token: 0x06040EC4 RID: 265924
		UniTask PlayMechanicTipAsync(IReadOnlyList<MechanicTipEvent> tips);

		// Token: 0x06040EC5 RID: 265925
		UniTask PlaySkillTipAsync(IReadOnlyList<SkillTipEvent> tips);

		// Token: 0x06040EC6 RID: 265926
		UniTask PlayPieceTransformAsync(IReadOnlyList<PieceTransformEvent> transforms);

		// Token: 0x06040EC7 RID: 265927
		UniTask PlayPieceAttachAsync(IReadOnlyList<PieceAttachEvent> attaches);

		// Token: 0x06040EC8 RID: 265928
		UniTask PlayPieceRecolorAsync(IReadOnlyList<PieceRecolorEvent> recolors);

		// Token: 0x06040EC9 RID: 265929
		UniTask PlaySkillTrailAsync(IReadOnlyList<SkillTrailEvent> trails);

		// Token: 0x06040ECA RID: 265930
		UniTask PlayMechanicTrailAsync(IReadOnlyList<MechanicTrailEvent> trails);

		// Token: 0x06040ECB RID: 265931
		UniTask PlayRecycleTrailSettleAsync(IReadOnlyList<RecycleTrailSettleEvent> settles);

		// Token: 0x06040ECC RID: 265932
		UniTask PlayScorePopAsync(IReadOnlyList<ScorePopEvent> pops);

		// Token: 0x06040ECD RID: 265933
		UniTask PlayReshuffleAsync();
	}
}
