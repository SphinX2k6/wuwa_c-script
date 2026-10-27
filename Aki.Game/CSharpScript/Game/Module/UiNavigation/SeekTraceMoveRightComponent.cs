using System;
using CSharpScript.Game.LevelGamePlay.SeekTrace;

namespace CSharpScript.Game.Module.UiNavigation
{
	// Token: 0x020049CC RID: 18892
	public class SeekTraceMoveRightComponent : SeekTraceBaseMoveComponent
	{
		// Token: 0x060311EC RID: 201196 RVA: 0x00B65101 File Offset: 0x00B63301
		public SeekTraceMoveRightComponent(int hotKeyMapIndex) : base(hotKeyMapIndex)
		{
		}

		// Token: 0x060311ED RID: 201197 RVA: 0x00B6510A File Offset: 0x00B6330A
		protected override ESeekTraceMoveDirection GetMoveDirection()
		{
			return ESeekTraceMoveDirection.Right;
		}
	}
}
