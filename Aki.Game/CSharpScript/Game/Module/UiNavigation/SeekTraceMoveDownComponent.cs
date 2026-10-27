using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049CA RID: 18890
	public class SeekTraceMoveDownComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x060311E8 RID: 201192 RVA: 0x00B650E9 File Offset: 0x00B632E9
		public SeekTraceMoveDownComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311E9 RID: 201193 RVA: 0x00B650F2 File Offset: 0x00B632F2
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Down;
		}
	}
}
