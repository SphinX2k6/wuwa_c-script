using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Activity.ActivityContent.ChessGameplay.StackableChess;

// Token: 0x02000683 RID: 1667
public static class ChessManagerCreator
{
	// Token: 0x06004D0B RID: 19723 RVA: 0x001A29C2 File Offset: 0x001A0BC2
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
