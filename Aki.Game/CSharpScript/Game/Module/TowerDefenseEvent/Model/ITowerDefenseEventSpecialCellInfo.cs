using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.TowerDefenseEvent.Model
{
	// Token: 0x02003AB8 RID: 15032
	public interface ITowerDefenseEventSpecialCellInfo : ITowerDefenseEventSpecialCellBaseInfo, ITowerDefenseEventCombatInfo, ITowerDefenseEventConfigInfo
	{
		// Token: 0x17004ED3 RID: 20179
		// (get) Token: 0x060269BE RID: 158142
		// (set) Token: 0x060269BF RID: 158143
		[Nullable(2)]
		string GridId { [NullableContext(2)] get; [NullableContext(2)] set; }

		// Token: 0x17004ED4 RID: 20180
		// (get) Token: 0x060269C0 RID: 158144
		// (set) Token: 0x060269C1 RID: 158145
		[Nullable(1)]
		Vector2D Coords { [NullableContext(1)] get; [NullableContext(1)] set; }

		// Token: 0x060269C2 RID: 158146
		void UpdateTransform(FVectorDouble position, FRotator rotation);
	}
}
