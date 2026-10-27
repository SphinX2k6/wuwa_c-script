using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Giant;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B2F RID: 27439
	public class LevelEventGiantToggleModel : LevelEventBase
	{
		// Token: 0x0604411D RID: 278813 RVA: 0x010BCC18 File Offset: 0x010BAE18
		public LevelEventGiantToggleModel(int id) : base(id)
		{
		}

		// Token: 0x0604411E RID: 278814 RVA: 0x010BCC24 File Offset: 0x010BAE24
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			GiantToggleModel giantToggleModel = inParams as GiantToggleModel;
			if (giantToggleModel == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			GiantController.Instance.SetBodyVisible(giantToggleModel.IsEnabled);
			base.FinishExecute(true, false, true);
		}
	}
}
