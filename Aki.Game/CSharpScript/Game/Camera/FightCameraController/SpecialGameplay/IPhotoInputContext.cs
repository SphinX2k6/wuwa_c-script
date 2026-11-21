using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006475 RID: 25717
	[NullableContext(1)]
	public interface IPhotoInputContext
	{
		// Token: 0x170076F8 RID: 30456
		// (get) Token: 0x0603E7B6 RID: 255926
		[Nullable(2)]
		TsBaseCharacter Character { [NullableContext(2)] get; }

		// Token: 0x170076F9 RID: 30457
		// (get) Token: 0x0603E7B7 RID: 255927
		PhotoCameraLogicComponent Logic { get; }
	}
}
