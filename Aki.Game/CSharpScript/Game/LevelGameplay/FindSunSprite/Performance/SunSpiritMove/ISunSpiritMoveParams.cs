using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.FindSunSprite.Performance.SunSpiritMove
{
	// Token: 0x02006E56 RID: 28246
	[NullableContext(1)]
	public interface ISunSpiritMoveParams
	{
		// Token: 0x17009A3E RID: 39486
		// (get) Token: 0x06044D7C RID: 281980
		// (set) Token: 0x06044D7D RID: 281981
		EntityHandle MoveTarget { get; set; }

		// Token: 0x17009A3F RID: 39487
		// (get) Token: 0x06044D7E RID: 281982
		// (set) Token: 0x06044D7F RID: 281983
		ESunSpiritMovePerformType PerformType { get; set; }

		// Token: 0x17009A40 RID: 39488
		// (get) Token: 0x06044D80 RID: 281984
		// (set) Token: 0x06044D81 RID: 281985
		Vector TargetLocation { get; set; }

		// Token: 0x17009A41 RID: 39489
		// (get) Token: 0x06044D82 RID: 281986
		// (set) Token: 0x06044D83 RID: 281987
		Rotator TargetRotator { get; set; }

		// Token: 0x17009A42 RID: 39490
		// (get) Token: 0x06044D84 RID: 281988
		// (set) Token: 0x06044D85 RID: 281989
		bool? SuccessPerform { get; set; }
	}
}
