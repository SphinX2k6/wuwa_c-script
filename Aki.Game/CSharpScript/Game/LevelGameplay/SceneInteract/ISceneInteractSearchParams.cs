using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02005BDA RID: 23514
	[NullableContext(1)]
	public interface ISceneInteractSearchParams
	{
		// Token: 0x17006E19 RID: 28185
		// (get) Token: 0x06039C6E RID: 236654
		// (set) Token: 0x06039C6F RID: 236655
		Vector CameraLocation { get; set; }

		// Token: 0x17006E1A RID: 28186
		// (get) Token: 0x06039C70 RID: 236656
		// (set) Token: 0x06039C71 RID: 236657
		Vector CameraForward { get; set; }

		// Token: 0x17006E1B RID: 28187
		// (get) Token: 0x06039C72 RID: 236658
		// (set) Token: 0x06039C73 RID: 236659
		Vector CurrentRoleLocation { get; set; }

		// Token: 0x17006E1C RID: 28188
		// (get) Token: 0x06039C74 RID: 236660
		// (set) Token: 0x06039C75 RID: 236661
		[Nullable(2)]
		EntityHandle CurrentRoleEntityHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17006E1D RID: 28189
		// (get) Token: 0x06039C76 RID: 236662
		// (set) Token: 0x06039C77 RID: 236663
		Func<ISceneInteractPoint, bool> IsInteractingPoint { get; set; }
	}
}
