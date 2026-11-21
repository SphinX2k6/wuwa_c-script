using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SlidingBlocks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D1D RID: 23837
	public class LevelEventTetrisTriggerDelayFall : LevelEventBase
	{
		// Token: 0x0603A455 RID: 238677 RVA: 0x01078238 File Offset: 0x01076438
		public LevelEventTetrisTriggerDelayFall(int id) : base(id)
		{
		}

		// Token: 0x0603A456 RID: 238678 RVA: 0x01078244 File Offset: 0x01076444
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
