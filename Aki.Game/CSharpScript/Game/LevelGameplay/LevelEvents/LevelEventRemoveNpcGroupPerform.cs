using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B60 RID: 27488
	public class LevelEventRemoveNpcGroupPerform : LevelEventBase
	{
		// Token: 0x060441ED RID: 279021 RVA: 0x010C4C7C File Offset: 0x010C2E7C
		public LevelEventRemoveNpcGroupPerform(int id) : base(id)
		{
		}

		// Token: 0x060441EE RID: 279022 RVA: 0x010C4C88 File Offset: 0x010C2E88
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			string key = (inParams as RemoveNpcGroupPerform).Key;
			HoldingHandsModel instance = HoldingHandsModel.Instance;
			if (((instance != null) ? instance.GetRelation(key) : null) != null)
			{
				HoldingHandsController.Instance.RequestReleaseHands(key, "关卡行为", false, true);
			}
			if (AssistedWalkUtils.Instance.GetRelation(key) != null)
			{
				AssistedWalkUtils.Instance.RequestStopAssistedWalk(key, "关卡行为", global::EHandType.Right);
			}
			base.FinishExecute(true, false, true);
		}
	}
}
