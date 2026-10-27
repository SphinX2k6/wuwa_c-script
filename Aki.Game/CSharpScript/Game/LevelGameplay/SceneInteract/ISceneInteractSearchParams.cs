using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract
{
	// Token: 0x02006A7D RID: 27261
	[NullableContext(1)]
	public interface ISceneInteractSearchParams
	{
		// Token: 0x17009934 RID: 39220
		// (get) Token: 0x06043C20 RID: 277536
		// (set) Token: 0x06043C21 RID: 277537
		Vector CameraLocation { get; set; }

		// Token: 0x17009935 RID: 39221
		// (get) Token: 0x06043C22 RID: 277538
		// (set) Token: 0x06043C23 RID: 277539
		Vector CameraForward { get; set; }

		// Token: 0x17009936 RID: 39222
		// (get) Token: 0x06043C24 RID: 277540
		// (set) Token: 0x06043C25 RID: 277541
		Vector CurrentRoleLocation { get; set; }

		// Token: 0x17009937 RID: 39223
		// (get) Token: 0x06043C26 RID: 277542
		// (set) Token: 0x06043C27 RID: 277543
		[Nullable(2)]
		EntityHandle CurrentRoleEntityHandle { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17009938 RID: 39224
		// (get) Token: 0x06043C28 RID: 277544
		// (set) Token: 0x06043C29 RID: 277545
		Func<ISceneInteractPoint, bool> IsInteractingPoint { get; set; }
	}
}
