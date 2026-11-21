using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x020062FF RID: 25343
	public class TimetableConfigData
	{
		// Token: 0x04020839 RID: 133177
		[Nullable(1)]
		public string BehaviorTreePath = "";

		// Token: 0x0402083A RID: 133178
		[Nullable(2)]
		public ICommonBtOverride CommonBtOverride;

		// Token: 0x0402083B RID: 133179
		public int StartTime;

		// Token: 0x0402083C RID: 133180
		public int SplineId;
	}
}
