using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F2 RID: 29426
	[NullableContext(1)]
	public interface IPhotoInputContext
	{
		// Token: 0x17009F5A RID: 40794
		// (get) Token: 0x0604836A RID: 295786
		[Nullable(2)]
		TsBaseCharacter Character { [NullableContext(2)] get; }

		// Token: 0x17009F5B RID: 40795
		// (get) Token: 0x0604836B RID: 295787
		PhotoCameraLogicComponent Logic { get; }
	}
}
