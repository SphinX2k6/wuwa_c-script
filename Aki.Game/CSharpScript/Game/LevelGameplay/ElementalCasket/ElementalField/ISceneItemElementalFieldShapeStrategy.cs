using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006022 RID: 24610
	[NullableContext(1)]
	public interface ISceneItemElementalFieldShapeStrategy
	{
		// Token: 0x17006FAC RID: 28588
		// (get) Token: 0x0603B1C6 RID: 242118
		ESceneItemElementalFieldShapeType ShapeType { get; }

		// Token: 0x17006FAD RID: 28589
		// (get) Token: 0x0603B1C7 RID: 242119
		Action<UKuroFastCollisionShapeComponent> ApplyStaticConfig { get; }

		// Token: 0x17006FAE RID: 28590
		// (get) Token: 0x0603B1C8 RID: 242120
		[Nullable(2)]
		Action<UKuroFastCollisionShapeComponent> SyncRuntime { [NullableContext(2)] get; }

		// Token: 0x17006FAF RID: 28591
		// (get) Token: 0x0603B1C9 RID: 242121
		Func<ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>> FillSnapshot { get; }
	}
}
