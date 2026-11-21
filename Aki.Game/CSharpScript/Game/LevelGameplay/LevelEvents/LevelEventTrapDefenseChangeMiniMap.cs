using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D21 RID: 23841
	public class LevelEventTrapDefenseChangeMiniMap : LevelEventBase
	{
		// Token: 0x0603A461 RID: 238689 RVA: 0x010786C0 File Offset: 0x010768C0
		public LevelEventTrapDefenseChangeMiniMap(int id) : base(id)
		{
		}

		// Token: 0x0603A462 RID: 238690 RVA: 0x010786CC File Offset: 0x010768CC
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TrapDefenseChangeMiniMap trapDefenseChangeMiniMap = inParams as TrapDefenseChangeMiniMap;
			TrapDefenseController.Instance.ChangeMap(trapDefenseChangeMiniMap.MiniMapId);
			base.FinishExecute(true, false, true);
		}
	}
}
