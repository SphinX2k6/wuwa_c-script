using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006E98 RID: 28312
	[NullableContext(1)]
	public interface ISceneItemElementalFieldSnapshot<[Nullable(2)] T>
	{
		// Token: 0x17009A5D RID: 39517
		// (get) Token: 0x06044FF3 RID: 282611
		// (set) Token: 0x06044FF4 RID: 282612
		T ShapeType { get; set; }

		// Token: 0x17009A5E RID: 39518
		// (get) Token: 0x06044FF5 RID: 282613
		// (set) Token: 0x06044FF6 RID: 282614
		bool Enabled { get; set; }

		// Token: 0x17009A5F RID: 39519
		// (get) Token: 0x06044FF7 RID: 282615
		// (set) Token: 0x06044FF8 RID: 282616
		FVectorDouble Center { get; set; }
	}
}
