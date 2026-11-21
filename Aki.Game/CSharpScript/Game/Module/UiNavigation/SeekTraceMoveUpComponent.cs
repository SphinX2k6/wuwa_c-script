using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003943 RID: 14659
	public class SeekTraceMoveUpComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x06025D1C RID: 154908 RVA: 0x00AA002D File Offset: 0x00A9E22D
		public SeekTraceMoveUpComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D1D RID: 154909 RVA: 0x00AA0036 File Offset: 0x00A9E236
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Up;
		}
	}
}
