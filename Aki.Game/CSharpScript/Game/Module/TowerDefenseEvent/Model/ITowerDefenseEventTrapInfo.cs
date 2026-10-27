using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02004B0E RID: 19214
	public interface ITowerDefenseEventTrapInfo : ITowerDefenseEventTrapBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17007B22 RID: 31522
		// (get) Token: 0x06031C25 RID: 203813
		// (set) Token: 0x06031C26 RID: 203814
		[Nullable(2)]
		string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17007B23 RID: 31523
		// (get) Token: 0x06031C27 RID: 203815
		// (set) Token: 0x06031C28 RID: 203816
		[Nullable(1)]
		Vector2D Coords { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x06031C29 RID: 203817
		void UpdateTransform(FVectorDouble position, FRotator rotation);
	}
}
