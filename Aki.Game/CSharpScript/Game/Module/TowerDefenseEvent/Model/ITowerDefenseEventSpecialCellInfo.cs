using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B10 RID: 19216
	public interface ITowerDefenseEventSpecialCellInfo : ITowerDefenseEventSpecialCellBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B26 RID: 31526
		// (get) Token: 0x06031C2E RID: 203822
		// (set) Token: 0x06031C2F RID: 203823
		[Nullable(2)]
		string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B27 RID: 31527
		// (get) Token: 0x06031C30 RID: 203824
		// (set) Token: 0x06031C31 RID: 203825
		[Nullable(1)]
		Vector2D Coords { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x06031C32 RID: 203826
		void UpdateTransform(FVectorDouble position, FRotator rotation);
	}
}
