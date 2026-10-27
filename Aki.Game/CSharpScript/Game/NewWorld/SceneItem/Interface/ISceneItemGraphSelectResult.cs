using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020071F8 RID: 29176
	[NullableContext(1)]
	public interface ISceneItemGraphSelectResult
	{
		// Token: 0x17009E0D RID: 40461
		// (get) Token: 0x060476AE RID: 292526
		// (set) Token: 0x060476AF RID: 292527
		int NodeId { get; set; }

		// Token: 0x17009E0E RID: 40462
		// (get) Token: 0x060476B0 RID: 292528
		// (set) Token: 0x060476B1 RID: 292529
		Vector Location { get; set; }
	}
}
