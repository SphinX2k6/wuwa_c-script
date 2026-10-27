using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006AF6 RID: 27382
	public class LevelEventBreakWeakness : LevelEventBase
	{
		// Token: 0x06044014 RID: 278548 RVA: 0x010B1E49 File Offset: 0x010B0049
		public LevelEventBreakWeakness(int id) : base(id)
		{
		}

		// Token: 0x06044015 RID: 278549 RVA: 0x010B1E54 File Offset: 0x010B0054
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() != EGeneralContextType.Entity)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			Entity entity = EntitySystem.Instance.Get((context as EntityContext).EntityId.Value);
			if (entity == null || !entity.Valid)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			EventSystem.Instance.Emit<int>(EEventName.MonsterBeginBroken, entity.Id);
			base.FinishExecute(true, false, true);
		}
	}
}
