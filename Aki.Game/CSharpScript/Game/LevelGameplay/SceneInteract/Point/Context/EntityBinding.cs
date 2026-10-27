using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A8B RID: 27275
	[NullableContext(1)]
	[Nullable(0)]
	public class EntityBinding
	{
		// Token: 0x06043C73 RID: 277619 RVA: 0x01097048 File Offset: 0x01095248
		public EntityBinding(EntityHandle Handle)
		{
			this.Handle = Handle;
		}

		// Token: 0x06043C74 RID: 277620 RVA: 0x01097058 File Offset: 0x01095258
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

		// Token: 0x04023699 RID: 145049
		public readonly EntityHandle Handle;
	}
}
