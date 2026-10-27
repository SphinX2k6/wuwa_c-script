using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.ElementalCasket.ElementalField
{
	// Token: 0x02006EA2 RID: 28322
	[NullableContext(1)]
	public interface ISceneItemElementalFieldShapeStrategy
	{
		// Token: 0x17009A75 RID: 39541
		// (get) Token: 0x06045025 RID: 282661
		ESceneItemElementalFieldShapeType ShapeType { get; }

		// Token: 0x17009A76 RID: 39542
		// (get) Token: 0x06045026 RID: 282662
		Action<UKuroFastCollisionShapeComponent> ApplyStaticConfig { get; }

		// Token: 0x17009A77 RID: 39543
		// (get) Token: 0x06045027 RID: 282663
		[Nullable(2)]
		Action<UKuroFastCollisionShapeComponent> SyncRuntime { [NullableContext(2)] get; }

		// Token: 0x17009A78 RID: 39544
		// (get) Token: 0x06045028 RID: 282664
		Func<ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>, ISceneItemElementalFieldSnapshot<ESceneItemElementalFieldShapeType>> FillSnapshot { get; }
	}
}
