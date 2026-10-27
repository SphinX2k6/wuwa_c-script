using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess;

// Token: 0x020011CF RID: 4559
public static class ChessManagerCreator
{
	// Token: 0x06007974 RID: 31092 RVA: 0x00199D12 File Offset: 0x00197F12
	[NullableContext(2)]
	public static IChessManager CreateChessManager(EChessMode mode)
	{
		if (mode == EChessMode.Stackable)
		{
			return new StackableChessManager();
		}
		return null;
	}
}
