using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.NewWorld.Character.Common.Component.Move.AssistedWalk;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD8 RID: 23768
	public class LevelEventRemoveNpcGroupPerform : LevelEventBase
	{
		// Token: 0x0603A33F RID: 238399 RVA: 0x0106E84C File Offset: 0x0106CA4C
		public LevelEventRemoveNpcGroupPerform(int id) : base(id)
		{
		}

		// Token: 0x0603A340 RID: 238400 RVA: 0x0106E858 File Offset: 0x0106CA58
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
