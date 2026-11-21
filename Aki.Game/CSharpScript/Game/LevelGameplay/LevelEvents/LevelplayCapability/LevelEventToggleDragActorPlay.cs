using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.LevelplayCapability
{
	// Token: 0x02005DAD RID: 23981
	public class LevelEventToggleDragActorPlay : LevelEventBase
	{
		// Token: 0x0603A614 RID: 239124 RVA: 0x0107D655 File Offset: 0x0107B855
		public LevelEventToggleDragActorPlay(int id) : base(id)
		{
		}

		// Token: 0x0603A615 RID: 239125 RVA: 0x0107D660 File Offset: 0x0107B860
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			ToggleDragActorPlay toggleDragActorPlay = inParams as ToggleDragActorPlay;
			EToggleDragActorPlayType type = toggleDragActorPlay.Config.Type;
			if (type == EToggleDragActorPlayType.Enable)
			{
				SplineConstrainedDragController.Instance.EnableDragActorPlay(toggleDragActorPlay.Config as IToggleDragActorPlayEnable);
				return;
			}
			if (type != EToggleDragActorPlayType.Disable)
			{
				return;
			}
			SplineConstrainedDragController.Instance.DisableDragActorPlay();
		}
	}
}
