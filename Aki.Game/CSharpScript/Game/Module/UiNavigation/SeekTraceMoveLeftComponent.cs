using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049CB RID: 18891
	public class SeekTraceMoveLeftComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x060311EA RID: 201194 RVA: 0x00B650F5 File Offset: 0x00B632F5
		public SeekTraceMoveLeftComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311EB RID: 201195 RVA: 0x00B650FE File Offset: 0x00B632FE
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Left;
		}
	}
}
