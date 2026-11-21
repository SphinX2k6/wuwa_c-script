using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CDF RID: 23775
	public class LevelEventRunAction : LevelEventBase
	{
		// Token: 0x0603A353 RID: 238419 RVA: 0x0106EE29 File Offset: 0x0106D029
		public LevelEventRunAction(int id) : base(id)
		{
		}

		// Token: 0x0603A354 RID: 238420 RVA: 0x0106EE34 File Offset: 0x0106D034
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			RunActions runActions = inParams as RunActions;
			if (runActions == null)
			{
				base.FinishExecute(false, false, true);
				return;
			}
			LevelGeneralController instance = LevelGeneralController.Instance;
			IList<ActionInfo> actionList = runActions.ActionList;
			GeneralContext context2 = GeneralContext.Copy(context);
			Action<ELevelEventState> finishCallback;
			if (!this.IsAsync)
			{
				finishCallback = delegate(ELevelEventState result)
				{
					base.FinishExecute(result == ELevelEventState.Success, false, true);
				};
			}
			else
			{
				finishCallback = delegate(ELevelEventState _)
				{
				};
			}
			instance.ExecuteActionsNew(actionList, context2, finishCallback);
			if (this.IsAsync)
			{
				base.FinishExecute(true, false, true);
			}
		}
	}
}
