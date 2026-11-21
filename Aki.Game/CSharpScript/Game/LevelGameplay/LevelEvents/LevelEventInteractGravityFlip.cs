using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CB2 RID: 23730
	public class LevelEventInteractGravityFlip : LevelEventBase
	{
		// Token: 0x0603A296 RID: 238230 RVA: 0x01066C62 File Offset: 0x01064E62
		public LevelEventInteractGravityFlip(int id) : base(id)
		{
		}

		// Token: 0x0603A297 RID: 238231 RVA: 0x01066C6C File Offset: 0x01064E6C
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ActionInteractGravityFlip actionInteractGravityFlip = inParams as ActionInteractGravityFlip;
			if (actionInteractGravityFlip == null)
			{
				return;
			}
			int entityId = actionInteractGravityFlip.EntityId;
			SceneItemGravityFlipComponent component = EntitySystem.Instance.GetComponent<SceneItemGravityFlipComponent>(entityId);
			if (component == null)
			{
				return;
			}
			component.ExecuteInteract();
			base.FinishExecute(true, false, true);
		}
	}
}
