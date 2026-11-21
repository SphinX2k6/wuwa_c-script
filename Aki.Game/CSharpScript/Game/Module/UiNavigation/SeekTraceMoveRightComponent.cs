using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003946 RID: 14662
	public class SeekTraceMoveRightComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x06025D22 RID: 154914 RVA: 0x00AA0051 File Offset: 0x00A9E251
		public SeekTraceMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D23 RID: 154915 RVA: 0x00AA005A File Offset: 0x00A9E25A
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Right;
		}
	}
}
