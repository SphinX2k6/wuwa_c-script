using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005AC1 RID: 23233
	public class ActionMoveToLocation : ActionParams
	{
		// Token: 0x0401E1D5 RID: 123349
		[Nullable(2)]
		public Vector ToLocation;

		// Token: 0x0401E1D6 RID: 123350
		public int MoveState;

		// Token: 0x0401E1D7 RID: 123351
		public bool IsNavigation;

		// Token: 0x0401E1D8 RID: 123352
		public bool IsFly;

		// Token: 0x0401E1D9 RID: 123353
		public bool DebugMode;

		// Token: 0x0401E1DA RID: 123354
		public float MoveSpeed;
	}
}
