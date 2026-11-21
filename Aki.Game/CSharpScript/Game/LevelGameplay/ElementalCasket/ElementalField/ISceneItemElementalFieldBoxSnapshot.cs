using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x0200601E RID: 24606
	public interface ISceneItemElementalFieldBoxSnapshot : ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17006FA2 RID: 28578
		// (get) Token: 0x0603B1B3 RID: 242099
		// (set) Token: 0x0603B1B4 RID: 242100
		FVectorDouble BoxSize { get; set; }

		// Token: 0x17006FA3 RID: 28579
		// (get) Token: 0x0603B1B5 RID: 242101
		// (set) Token: 0x0603B1B6 RID: 242102
		FRotator? BoxRotation { get; set; }
	}
}
