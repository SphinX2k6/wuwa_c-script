using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E9C RID: 28316
	public interface ISceneItemElementalFieldConeSnapshot : ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17009A65 RID: 39525
		// (get) Token: 0x06045005 RID: 282629
		// (set) Token: 0x06045006 RID: 282630
		FVector ConeAxis { get; set; }

		// Token: 0x17009A66 RID: 39526
		// (get) Token: 0x06045007 RID: 282631
		// (set) Token: 0x06045008 RID: 282632
		double ConeHalfAngle { get; set; }

		// Token: 0x17009A67 RID: 39527
		// (get) Token: 0x06045009 RID: 282633
		// (set) Token: 0x0604500A RID: 282634
		double ConeHeight { get; set; }
	}
}
