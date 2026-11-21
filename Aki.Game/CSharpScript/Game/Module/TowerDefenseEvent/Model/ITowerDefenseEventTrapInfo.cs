using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AB6 RID: 15030
	public interface ITowerDefenseEventTrapInfo : ITowerDefenseEventTrapBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004ECF RID: 20175
		// (get) Token: 0x060269B5 RID: 158133
		// (set) Token: 0x060269B6 RID: 158134
		[Nullable(2)]
		string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004ED0 RID: 20176
		// (get) Token: 0x060269B7 RID: 158135
		// (set) Token: 0x060269B8 RID: 158136
		[Nullable(1)]
		Vector2D Coords { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x060269B9 RID: 158137
		void UpdateTransform(FVectorDouble position, FRotator rotation);
	}
}
