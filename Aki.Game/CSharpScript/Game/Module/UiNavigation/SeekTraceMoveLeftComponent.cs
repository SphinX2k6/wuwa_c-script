using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003945 RID: 14661
	public class SeekTraceMoveLeftComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x06025D20 RID: 154912 RVA: 0x00AA0045 File Offset: 0x00A9E245
		public SeekTraceMoveLeftComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D21 RID: 154913 RVA: 0x00AA004E File Offset: 0x00A9E24E
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Left;
		}
	}
}
