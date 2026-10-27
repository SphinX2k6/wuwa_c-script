using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.NewWorld.Character.Npc.Controller
{
	// Token: 0x0200709A RID: 28826
	public class TimetableConfigData
	{
		// Token: 0x04024CE7 RID: 150759
		[Nullable(1)]
		public string BehaviorTreePath = "";

		// Token: 0x04024CE8 RID: 150760
		[Nullable(2)]
		public ICommonBtOverride CommonBtOverride;

		// Token: 0x04024CE9 RID: 150761
		public int StartTime;

		// Token: 0x04024CEA RID: 150762
		public int SplineId;
	}
}
