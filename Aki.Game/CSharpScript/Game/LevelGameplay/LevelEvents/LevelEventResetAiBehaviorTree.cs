using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B61 RID: 27489
	public class LevelEventResetAiBehaviorTree : LevelEventBase
	{
		// Token: 0x060441EF RID: 279023 RVA: 0x010C4CEE File Offset: 0x010C2EEE
		public LevelEventResetAiBehaviorTree(int id) : base(id)
		{
		}

		// Token: 0x060441F0 RID: 279024 RVA: 0x010C4CF8 File Offset: 0x010C2EF8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventResetAiBehaviorTree 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			RestoreAiBehaviorTree restoreAiBehaviorTree = inParams as RestoreAiBehaviorTree;
			AiModel instance = AiModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.ResetAiBehaviorTree(restoreAiBehaviorTree.Key);
		}
	}
}
