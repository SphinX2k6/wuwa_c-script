using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.LevelGamePlay.SplineConstrainedDrag;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents.LevelplayCapability
{
	// Token: 0x02006C34 RID: 27700
	public class LevelEventToggleDragActorPlay : LevelEventBase
	{
		// Token: 0x060444BC RID: 279740 RVA: 0x010D3701 File Offset: 0x010D1901
		public LevelEventToggleDragActorPlay(int id) : base(id)
		{
		}

		// Token: 0x060444BD RID: 279741 RVA: 0x010D370C File Offset: 0x010D190C
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
