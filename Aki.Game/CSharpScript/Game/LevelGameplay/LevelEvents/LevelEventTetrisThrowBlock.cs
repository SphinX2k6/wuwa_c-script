using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SlidingBlocks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D1C RID: 23836
	public class LevelEventTetrisThrowBlock : LevelEventBase
	{
		// Token: 0x0603A453 RID: 238675 RVA: 0x010781EC File Offset: 0x010763EC
		public LevelEventTetrisThrowBlock(int id) : base(id)
		{
		}

		// Token: 0x0603A454 RID: 238676 RVA: 0x010781F8 File Offset: 0x010763F8
		[NullableContext(1)]
		public override void ExecuteNew(ActionParams inParams, GeneralContext context, int? actionId = null)
		{
			TetrisThrowBlock tetrisThrowBlock = inParams as TetrisThrowBlock;
			if (tetrisThrowBlock == null)
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "TetrisThrowBlock配置类型不支持", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			SlidingBlocksController.Instance.SpawnTetrominoOnMainLineMode(tetrisThrowBlock);
		}
	}
}
