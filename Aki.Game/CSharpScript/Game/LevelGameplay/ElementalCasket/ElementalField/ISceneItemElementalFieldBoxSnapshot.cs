using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E9E RID: 28318
	public interface ISceneItemElementalFieldBoxSnapshot : ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17009A6B RID: 39531
		// (get) Token: 0x06045012 RID: 282642
		// (set) Token: 0x06045013 RID: 282643
		FVectorDouble BoxSize { get; set; }

		// Token: 0x17009A6C RID: 39532
		// (get) Token: 0x06045014 RID: 282644
		// (set) Token: 0x06045015 RID: 282645
		FRotator? BoxRotation { get; set; }
	}
}
