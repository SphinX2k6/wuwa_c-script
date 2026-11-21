using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Common.Event;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D28 RID: 23848
	public class LevelEventUltraSkillInteract : LevelEventBase
	{
		// Token: 0x0603A471 RID: 238705 RVA: 0x01078B30 File Offset: 0x01076D30
		public LevelEventUltraSkillInteract(int id) : base(id)
		{
		}

		// Token: 0x0603A472 RID: 238706 RVA: 0x01078B3C File Offset: 0x01076D3C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (context.Type.GetValueOrDefault() == EGeneralContextType.Entity)
			{
				EntityContext entityContext = context as EntityContext;
				if (entityContext != null)
				{
					Entity entity = EntitySystem.Instance.Get(entityContext.EntityId.GetValueOrDefault());
					if (entity == null || !entity.Valid)
					{
						base.FinishExecute(false, false, true);
						return;
					}
					EventSystem.Instance.Emit<int>(EEventName.UltraSkillInteract, entity.Id);
					base.FinishExecute(true, false, true);
					return;
				}
			}
			base.FinishExecute(false, false, true);
		}
	}
}
