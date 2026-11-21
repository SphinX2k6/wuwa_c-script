using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02005B74 RID: 23412
	public enum ESplineMoveState
	{
		// Token: 0x0401E66C RID: 124524
		None,
		// Token: 0x0401E66D RID: 124525
		Start,
		// Token: 0x0401E66E RID: 124526
		Prepare,
		// Token: 0x0401E66F RID: 124527
		MoveToStartPoint,
		// Token: 0x0401E670 RID: 124528
		SplineMove,
		// Token: 0x0401E671 RID: 124529
		WaitEnd,
		// Token: 0x0401E672 RID: 124530
		End
	}
}
