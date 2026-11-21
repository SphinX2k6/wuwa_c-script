using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CD9 RID: 23769
	public class LevelEventResetAiBehaviorTree : LevelEventBase
	{
		// Token: 0x0603A341 RID: 238401 RVA: 0x0106E8BE File Offset: 0x0106CABE
		public LevelEventResetAiBehaviorTree(int id) : base(id)
		{
		}

		// Token: 0x0603A342 RID: 238402 RVA: 0x0106E8C8 File Offset: 0x0106CAC8
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
