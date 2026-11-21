using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006018 RID: 24600
	[NullableContext(1)]
	public interface ISceneItemElementalFieldSnapshot<[Nullable(2)] T>
	{
		// Token: 0x17006F94 RID: 28564
		// (get) Token: 0x0603B194 RID: 242068
		// (set) Token: 0x0603B195 RID: 242069
		T ShapeType { get; set; }

		// Token: 0x17006F95 RID: 28565
		// (get) Token: 0x0603B196 RID: 242070
		// (set) Token: 0x0603B197 RID: 242071
		bool Enabled { get; set; }

		// Token: 0x17006F96 RID: 28566
		// (get) Token: 0x0603B198 RID: 242072
		// (set) Token: 0x0603B199 RID: 242073
		FVectorDouble Center { get; set; }
	}
}
