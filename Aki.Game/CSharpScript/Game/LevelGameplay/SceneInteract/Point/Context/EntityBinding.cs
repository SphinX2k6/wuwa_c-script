using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BE8 RID: 23528
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityBinding
	{
		// Token: 0x06039CC1 RID: 236737 RVA: 0x0103B89C File Offset: 0x01039A9C
		public EntityBinding(EntityHandle Handle)
		{
			this.Handle = Handle;
		}

		// Token: 0x06039CC2 RID: 236738 RVA: 0x0103B8AC File Offset: 0x01039AAC
		public bool IsValid()
		{
			if (!this.Handle.Valid)
			{
				return false;
			}
			WorldEntity entity = this.Handle.Entity;
			CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
			if (component != null && component.GetRemoveState())
			{
				return false;
			}
			BaseActorComponent component2 = entity.GetComponent<BaseActorComponent>();
			if (component2 == null)
			{
				return false;
			}
			AActor owner = component2.Owner;
			return ((owner != null) ? new bool?(owner.IsValid()) : null).GetValueOrDefault();
		}

		// Token: 0x0401E88B RID: 125067
		public readonly EntityHandle Handle;
	}
}
