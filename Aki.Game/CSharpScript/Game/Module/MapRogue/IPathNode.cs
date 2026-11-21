using System;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02004599 RID: 17817
	public interface IPathNode
	{
		// Token: 0x17005AA2 RID: 23202
		// (get) Token: 0x0602CE6D RID: 183917
		int GridIndex { get; }

		// Token: 0x17005AA3 RID: 23203
		// (get) Token: 0x0602CE6E RID: 183918
		int Cost { get; }

		// Token: 0x17005AA4 RID: 23204
		// (get) Token: 0x0602CE6F RID: 183919
		bool Walkable { get; }
	}
}
