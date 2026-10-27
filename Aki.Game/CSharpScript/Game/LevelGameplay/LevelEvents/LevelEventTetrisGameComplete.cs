using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SlidingBlocks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA3 RID: 27555
	public class LevelEventTetrisGameComplete : LevelEventBase
	{
		// Token: 0x060442FB RID: 279291 RVA: 0x010CE315 File Offset: 0x010CC515
		public LevelEventTetrisGameComplete(int id) : base(id)
		{
		}

		// Token: 0x060442FC RID: 279292 RVA: 0x010CE320 File Offset: 0x010CC520
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TetrisGameComplete tetrisGameComplete = inParams as TetrisGameComplete;
			if (tetrisGameComplete == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "TetrisGameComplete配置类型不支持", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SlidingBlocksController.Instance.MainLineModeGameComplete(tetrisGameComplete);
		}
	}
}
