using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x02004533 RID: 17715
	[NullableContext(2)]
	[Nullable(0)]
	public class LoadActorInfo
	{
		// Token: 0x0602DC63 RID: 187491 RVA: 0x00A844F8 File Offset: 0x00A826F8
		private LoadActorInfo(long entityId, Entity entity, AActor actor)
		{
			this.EntityId = entityId;
			this.Entity = entity;
			this.Actor = actor;
		}

		// Token: 0x0602DC64 RID: 187492 RVA: 0x00A84515 File Offset: 0x00A82715
		public bool IsValid()
		{
			return this.EntityId != 0L && this.Entity != null && this.Actor != null;
		}

		// Token: 0x0602DC65 RID: 187493 RVA: 0x00A84536 File Offset: 0x00A82736
		[return: Nullable(1)]
		public static LoadActorInfo Create(long entityId, Entity entity = null, AActor actor = null)
		{
			return new LoadActorInfo(entityId, entity, actor);
		}

		// Token: 0x04018716 RID: 100118
		private const long zero = 0L;

		// Token: 0x04018717 RID: 100119
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly LoadActorInfo Undefined = new LoadActorInfo(0L, null, null);

		// Token: 0x04018718 RID: 100120
		public readonly long EntityId;

		// Token: 0x04018719 RID: 100121
		public readonly Entity Entity;

		// Token: 0x0401871A RID: 100122
		public readonly AActor Actor;
	}
}
