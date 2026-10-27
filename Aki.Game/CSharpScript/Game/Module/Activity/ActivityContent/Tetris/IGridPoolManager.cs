using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200601A RID: 24602
	[NullableContext(1)]
	public interface IGridPoolManager
	{
		// Token: 0x0603E4BE RID: 255166
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

		// Token: 0x0603E4BF RID: 255167
		void ReturnGrid(TetrisGridPanel grid);
	}
}
