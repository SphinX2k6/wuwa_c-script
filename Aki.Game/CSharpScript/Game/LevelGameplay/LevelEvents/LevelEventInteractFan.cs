using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB1 RID: 23729
	public class LevelEventInteractFan : LevelEventBase
	{
		// Token: 0x0603A294 RID: 238228 RVA: 0x01066C1B File Offset: 0x01064E1B
		public LevelEventInteractFan(int id) : base(id)
		{
		}

		// Token: 0x0603A295 RID: 238229 RVA: 0x01066C24 File Offset: 0x01064E24
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
