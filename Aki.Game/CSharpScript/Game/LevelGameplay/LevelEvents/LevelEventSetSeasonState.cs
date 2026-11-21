using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Season;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CF3 RID: 23795
	public class LevelEventSetSeasonState : LevelEventBase
	{
		// Token: 0x0603A3AB RID: 238507 RVA: 0x01073EDB File Offset: 0x010720DB
		public LevelEventSetSeasonState(int id) : base(id)
		{
		}

		// Token: 0x0603A3AC RID: 238508 RVA: 0x01073EE4 File Offset: 0x010720E4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ClientSetSeasonState clientSetSeasonState = inParams as ClientSetSeasonState;
			if (clientSetSeasonState == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			SeasonController.Instance.ApplyConfig(clientSetSeasonState.VolumeId, clientSetSeasonState.Config, delegate(bool success)
			{
				base.FinishExecute(success, false, true);
			});
		}
	}
}
