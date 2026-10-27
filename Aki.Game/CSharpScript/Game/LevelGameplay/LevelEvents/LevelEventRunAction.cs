using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B67 RID: 27495
	public class LevelEventRunAction : LevelEventBase
	{
		// Token: 0x06044201 RID: 279041 RVA: 0x010C5259 File Offset: 0x010C3459
		public LevelEventRunAction(int id) : base(id)
		{
		}

		// Token: 0x06044202 RID: 279042 RVA: 0x010C5264 File Offset: 0x010C3464
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
