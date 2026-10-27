using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.Season;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B7B RID: 27515
	public class LevelEventSetSeasonState : LevelEventBase
	{
		// Token: 0x06044259 RID: 279129 RVA: 0x010CA267 File Offset: 0x010C8467
		public LevelEventSetSeasonState(int id) : base(id)
		{
		}

		// Token: 0x0604425A RID: 279130 RVA: 0x010CA270 File Offset: 0x010C8470
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
