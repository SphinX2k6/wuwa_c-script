using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SlidingBlocks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA5 RID: 27557
	public class LevelEventTetrisTriggerDelayFall : LevelEventBase
	{
		// Token: 0x060442FF RID: 279295 RVA: 0x010CE3AC File Offset: 0x010CC5AC
		public LevelEventTetrisTriggerDelayFall(int id) : base(id)
		{
		}

		// Token: 0x06044300 RID: 279296 RVA: 0x010CE3B8 File Offset: 0x010CC5B8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TetrisTriggerDelayFall tetrisTriggerDelayFall = inParams as TetrisTriggerDelayFall;
			if (tetrisTriggerDelayFall == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "LevelEventTetrisTriggerDelayFall配置类型不支持", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SlidingBlocksController.Instance.MainLineModeTriggerDelayFall(tetrisTriggerDelayFall);
		}
	}
}
