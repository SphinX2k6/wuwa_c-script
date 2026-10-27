using System;

namespace CSharpScript.Game.LevelGamePlay.SplineMoveTask
{
	// Token: 0x02006A17 RID: 27159
	public enum ESplineMoveState
	{
		// Token: 0x0402347A RID: 144506
		None,
		// Token: 0x0402347B RID: 144507
		Start,
		// Token: 0x0402347C RID: 144508
		Prepare,
		// Token: 0x0402347D RID: 144509
		MoveToStartPoint,
		// Token: 0x0402347E RID: 144510
		SplineMove,
		// Token: 0x0402347F RID: 144511
		WaitEnd,
		// Token: 0x04023480 RID: 144512
		End
	}
}
