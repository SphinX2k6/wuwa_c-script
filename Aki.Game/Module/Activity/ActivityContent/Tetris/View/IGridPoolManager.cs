using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris.View
{
	// Token: 0x02002FE2 RID: 12258
	[NullableContext(1)]
	public interface IGridPoolManager
	{
		// Token: 0x0601D186 RID: 119174
		[return: TupleElementNames(new string[]
		{
			"Grid",
			"IsNew"
		})]
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		ValueTuple<TetrisGridPanel, bool> GetGrid(UUIItem poolContainer);

		// Token: 0x0601D187 RID: 119175
		void ReturnGrid(TetrisGridPanel grid);
	}
}
