using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006B6F RID: 27503
	public class LevelEventSetAiBehaviorTree : LevelEventBase
	{
		// Token: 0x0604422C RID: 279084 RVA: 0x010C7FB8 File Offset: 0x010C61B8
		public LevelEventSetAiBehaviorTree(int id) : base(id)
		{
		}

		// Token: 0x0604422D RID: 279085 RVA: 0x010C7FC4 File Offset: 0x010C61C4
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			if (inParams == null)
			{
				global::Log.Instance.Error(ELogModule.Event, ELogAuthor.CWZ, "LevelEventSetAiBehaviorTree 参数配置错误", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			OverrideAiBehaviorTree aiBehaviorTree = inParams as OverrideAiBehaviorTree;
			AiModel instance = AiModel.Instance;
			if (instance == null)
			{
				return;
			}
			instance.SetAiBehaviorTree(aiBehaviorTree);
		}
	}
}
