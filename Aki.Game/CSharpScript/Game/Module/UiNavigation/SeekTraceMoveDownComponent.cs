using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x02003944 RID: 14660
	public class SeekTraceMoveDownComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x06025D1E RID: 154910 RVA: 0x00AA0039 File Offset: 0x00A9E239
		public SeekTraceMoveDownComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x06025D1F RID: 154911 RVA: 0x00AA0042 File Offset: 0x00A9E242
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Down;
		}
	}
}
