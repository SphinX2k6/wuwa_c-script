using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B39 RID: 27449
	public class LevelEventInteractFan : LevelEventBase
	{
		// Token: 0x06044142 RID: 278850 RVA: 0x010BD38F File Offset: 0x010BB58F
		public LevelEventInteractFan(int id) : base(id)
		{
		}

		// Token: 0x06044143 RID: 278851 RVA: 0x010BD398 File Offset: 0x010BB598
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionInteractFan actionInteractFan = inParams as ActionInteractFan;
			if (actionInteractFan == null)
			{
				return;
			}
			int entityId = actionInteractFan.EntityId;
			SceneItemFanComponent component = EntitySystem.Instance.GetComponent<SceneItemFanComponent>(entityId);
			if (component == null)
			{
				return;
			}
			component.ExecuteInteract();
			base.FinishExecute(true, false, true);
		}
	}
}
