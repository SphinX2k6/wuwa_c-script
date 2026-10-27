using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A8A RID: 27274
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class EntitySceneInteractPointContext : BindingSceneInteractPointContext
	{
		// Token: 0x06043C71 RID: 277617 RVA: 0x01097027 File Offset: 0x01095227
		public EntitySceneInteractPointContext(EntityHandle entityHandle)
		{
			this.EntityBindingSlot = new EntityBinding(entityHandle);
		}

		// Token: 0x06043C72 RID: 277618 RVA: 0x0109703B File Offset: 0x0109523B
		public override EntityHandle GetEntityHandle()
		{
			return this.EntityBindingSlot.Handle;
		}
	}
}
