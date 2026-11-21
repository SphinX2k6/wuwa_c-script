using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BE7 RID: 23527
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EntitySceneInteractPointContext : BindingSceneInteractPointContext
	{
		// Token: 0x06039CBF RID: 236735 RVA: 0x0103B87B File Offset: 0x01039A7B
		public EntitySceneInteractPointContext(EntityHandle entityHandle)
		{
			this.EntityBindingSlot = new EntityBinding(entityHandle);
		}

		// Token: 0x06039CC0 RID: 236736 RVA: 0x0103B88F File Offset: 0x01039A8F
		public override EntityHandle GetEntityHandle()
		{
			return this.EntityBindingSlot.Handle;
		}
	}
}
