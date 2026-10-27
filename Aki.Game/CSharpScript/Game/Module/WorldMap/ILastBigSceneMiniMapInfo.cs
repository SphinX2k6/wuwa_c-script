using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004792 RID: 18322
	[NullableContext(1)]
	public interface ILastBigSceneMiniMapInfo
	{
		// Token: 0x170077E0 RID: 30688
		// (get) Token: 0x0602FEE0 RID: 196320
		// (set) Token: 0x0602FEE1 RID: 196321
		int InstanceDungeonId { get; set; }

		// Token: 0x170077E1 RID: 30689
		// (get) Token: 0x0602FEE2 RID: 196322
		// (set) Token: 0x0602FEE3 RID: 196323
		Vector Position { get; set; }
	}
}
