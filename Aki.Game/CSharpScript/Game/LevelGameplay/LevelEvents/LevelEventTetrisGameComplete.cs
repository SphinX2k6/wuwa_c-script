using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Module.SlidingBlocks;

namespace CSharpScript.Game.LevelGamePlay.LevelEvents
{
	// Token: 0x02005D1B RID: 23835
	public class LevelEventTetrisGameComplete : LevelEventBase
	{
		// Token: 0x0603A451 RID: 238673 RVA: 0x010781A1 File Offset: 0x010763A1
		public LevelEventTetrisGameComplete(int id) : base(id)
		{
		}

		// Token: 0x0603A452 RID: 238674 RVA: 0x010781AC File Offset: 0x010763AC
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
