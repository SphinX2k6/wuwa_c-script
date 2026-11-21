using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.AutoPilot;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D12 RID: 23826
	[NullableContext(1)]
	[Nullable(0)]
	public class LevelEventStopMotorCruise : LevelEventBase
	{
		// Token: 0x0603A42F RID: 238639 RVA: 0x010771E2 File Offset: 0x010753E2
		public LevelEventStopMotorCruise(int id) : base(id)
		{
		}

		// Token: 0x0603A430 RID: 238640 RVA: 0x010771EB File Offset: 0x010753EB
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			AutoPilotController.Instance.ExitAutoPilot("LevelEvent", false);
			base.FinishExecute(true, false, true);
		}

		// Token: 0x0603A431 RID: 238641 RVA: 0x01077207 File Offset: 0x01075407
		protected override void ExecuteInGm(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			base.FinishExecute(true, false, true);
		}
	}
}
