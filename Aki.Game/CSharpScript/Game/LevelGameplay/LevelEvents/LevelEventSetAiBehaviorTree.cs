using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005CE7 RID: 23783
	public class LevelEventSetAiBehaviorTree : LevelEventBase
	{
		// Token: 0x0603A37E RID: 238462 RVA: 0x01071C2C File Offset: 0x0106FE2C
		public LevelEventSetAiBehaviorTree(int id) : base(id)
		{
		}

		// Token: 0x0603A37F RID: 238463 RVA: 0x01071C38 File Offset: 0x0106FE38
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
