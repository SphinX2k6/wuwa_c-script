using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Giant;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CA7 RID: 23719
	public class LevelEventGiantToggleModel : LevelEventBase
	{
		// Token: 0x0603A26F RID: 238191 RVA: 0x010664A4 File Offset: 0x010646A4
		public LevelEventGiantToggleModel(int id) : base(id)
		{
		}

		// Token: 0x0603A270 RID: 238192 RVA: 0x010664B0 File Offset: 0x010646B0
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
