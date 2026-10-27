using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BAF RID: 27567
	public class LevelEventTriggerSystemRandomPlot : LevelEventBase
	{
		// Token: 0x06044319 RID: 279321 RVA: 0x010CEC74 File Offset: 0x010CCE74
		public LevelEventTriggerSystemRandomPlot(int id) : base(id)
		{
		}

		// Token: 0x0604431A RID: 279322 RVA: 0x010CEC80 File Offset: 0x010CCE80
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TriggerSystemRandomPlot triggerSystemRandomPlot = inParams as TriggerSystemRandomPlot;
			RandomPlotController.Instance.PlayRandomPlot(triggerSystemRandomPlot.Id);
		}
	}
}
