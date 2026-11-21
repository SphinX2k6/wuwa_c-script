using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C3 RID: 14019
	[NullableContext(1)]
	public interface ILastBigSceneMiniMapInfo
	{
		// Token: 0x17004A9C RID: 19100
		// (get) Token: 0x060246AB RID: 149163
		// (set) Token: 0x060246AC RID: 149164
		int InstanceDungeonId { get; set; }

		// Token: 0x17004A9D RID: 19101
		// (get) Token: 0x060246AD RID: 149165
		// (set) Token: 0x060246AE RID: 149166
		Vector Position { get; set; }
	}
}
