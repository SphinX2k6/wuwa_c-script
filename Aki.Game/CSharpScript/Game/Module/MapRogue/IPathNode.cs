using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x020055C3 RID: 21955
	public interface IPathNode
	{
		// Token: 0x170086DB RID: 34523
		// (get) Token: 0x06037F6F RID: 229231
		int GridIndex { get; }

		// Token: 0x170086DC RID: 34524
		// (get) Token: 0x06037F70 RID: 229232
		int Cost { get; }

		// Token: 0x170086DD RID: 34525
		// (get) Token: 0x06037F71 RID: 229233
		bool Walkable { get; }
	}
}
