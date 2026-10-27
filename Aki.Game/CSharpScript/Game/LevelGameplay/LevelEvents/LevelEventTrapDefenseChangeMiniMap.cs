using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA9 RID: 27561
	public class LevelEventTrapDefenseChangeMiniMap : LevelEventBase
	{
		// Token: 0x0604430B RID: 279307 RVA: 0x010CE834 File Offset: 0x010CCA34
		public LevelEventTrapDefenseChangeMiniMap(int id) : base(id)
		{
		}

		// Token: 0x0604430C RID: 279308 RVA: 0x010CE840 File Offset: 0x010CCA40
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TrapDefenseChangeMiniMap trapDefenseChangeMiniMap = inParams as TrapDefenseChangeMiniMap;
			TrapDefenseController.Instance.ChangeMap(trapDefenseChangeMiniMap.MiniMapId);
			base.FinishExecute(true, false, true);
		}
	}
}
