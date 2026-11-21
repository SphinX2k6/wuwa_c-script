using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.SceneItem.Interface
{
	// Token: 0x020062AD RID: 25261
	[NullableContext(1)]
	public interface ISceneItemGraphSelectResult
	{
		// Token: 0x1700736A RID: 29546
		// (get) Token: 0x0603CFB6 RID: 249782
		// (set) Token: 0x0603CFB7 RID: 249783
		int NodeId { get; set; }

		// Token: 0x1700736B RID: 29547
		// (get) Token: 0x0603CFB8 RID: 249784
		// (set) Token: 0x0603CFB9 RID: 249785
		Vector Location { get; set; }
	}
}
