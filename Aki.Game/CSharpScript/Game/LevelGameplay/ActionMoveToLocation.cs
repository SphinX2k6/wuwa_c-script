using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02006965 RID: 26981
	public class ActionMoveToLocation : ActionParams
	{
		// Token: 0x04022FEB RID: 143339
		[Nullable(2)]
		public Vector ToLocation;

		// Token: 0x04022FEC RID: 143340
		public int MoveState;

		// Token: 0x04022FED RID: 143341
		public bool IsNavigation;

		// Token: 0x04022FEE RID: 143342
		public bool IsFly;

		// Token: 0x04022FEF RID: 143343
		public bool DebugMode;

		// Token: 0x04022FF0 RID: 143344
		public float MoveSpeed;
	}
}
