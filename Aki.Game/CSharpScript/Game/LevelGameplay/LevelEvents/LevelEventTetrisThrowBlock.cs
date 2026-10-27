using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SlidingBlocks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02006BA4 RID: 27556
	public class LevelEventTetrisThrowBlock : LevelEventBase
	{
		// Token: 0x060442FD RID: 279293 RVA: 0x010CE360 File Offset: 0x010CC560
		public LevelEventTetrisThrowBlock(int id) : base(id)
		{
		}

		// Token: 0x060442FE RID: 279294 RVA: 0x010CE36C File Offset: 0x010CC56C
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
