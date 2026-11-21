using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D27 RID: 23847
	public class LevelEventTriggerSystemRandomPlot : LevelEventBase
	{
		// Token: 0x0603A46F RID: 238703 RVA: 0x01078B00 File Offset: 0x01076D00
		public LevelEventTriggerSystemRandomPlot(int id) : base(id)
		{
		}

		// Token: 0x0603A470 RID: 238704 RVA: 0x01078B0C File Offset: 0x01076D0C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TriggerSystemRandomPlot triggerSystemRandomPlot = inParams as TriggerSystemRandomPlot;
			RandomPlotController.Instance.PlayRandomPlot(triggerSystemRandomPlot.Id);
		}
	}
}
