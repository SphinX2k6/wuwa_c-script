using System;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x0200601C RID: 24604
	public interface ISceneItemElementalFieldConeSnapshot : ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>
	{
		// Token: 0x17006F9C RID: 28572
		// (get) Token: 0x0603B1A6 RID: 242086
		// (set) Token: 0x0603B1A7 RID: 242087
		FVector ConeAxis { get; set; }

		// Token: 0x17006F9D RID: 28573
		// (get) Token: 0x0603B1A8 RID: 242088
		// (set) Token: 0x0603B1A9 RID: 242089
		double ConeHalfAngle { get; set; }

		// Token: 0x17006F9E RID: 28574
		// (get) Token: 0x0603B1AA RID: 242090
		// (set) Token: 0x0603B1AB RID: 242091
		double ConeHeight { get; set; }
	}
}
