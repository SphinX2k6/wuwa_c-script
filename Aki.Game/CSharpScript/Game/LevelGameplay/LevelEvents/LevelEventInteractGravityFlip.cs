using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.SceneItem;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B3A RID: 27450
	public class LevelEventInteractGravityFlip : LevelEventBase
	{
		// Token: 0x06044144 RID: 278852 RVA: 0x010BD3D6 File Offset: 0x010BB5D6
		public LevelEventInteractGravityFlip(int id) : base(id)
		{
		}

		// Token: 0x06044145 RID: 278853 RVA: 0x010BD3E0 File Offset: 0x010BB5E0
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
