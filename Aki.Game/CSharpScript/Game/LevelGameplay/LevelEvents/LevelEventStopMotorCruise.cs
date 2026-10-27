using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.AutoPilot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B9A RID: 27546
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventStopMotorCruise : LevelEventBase
	{
		// Token: 0x060442DB RID: 279259 RVA: 0x010CD3AA File Offset: 0x010CB5AA
		public LevelEventStopMotorCruise(int id) : base(id)
		{
		}

		// Token: 0x060442DC RID: 279260 RVA: 0x010CD3B3 File Offset: 0x010CB5B3
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			AutoPilotController.Instance.ExitAutoPilot("LevelEvent", false);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x060442DD RID: 279261 RVA: 0x010CD3CF File Offset: 0x010CB5CF
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}
	}
}
