using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049C9 RID: 18889
	public class SeekTraceMoveUpComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x060311E6 RID: 201190 RVA: 0x00B650DD File Offset: 0x00B632DD
		public SeekTraceMoveUpComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311E7 RID: 201191 RVA: 0x00B650E6 File Offset: 0x00B632E6
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Up;
		}
	}
}
