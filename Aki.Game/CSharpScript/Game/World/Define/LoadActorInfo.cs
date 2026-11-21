using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.World.Define
{
	// Token: 0x0200345B RID: 13403
	[NullableContext(2)]
	[Nullable(0)]
	public class LoadActorInfo
	{
		// Token: 0x06022340 RID: 140096 RVA: 0x009AF9E8 File Offset: 0x009ADBE8
		private LoadActorInfo(long entityId, Entity entity, AActor actor)
		{
			this.EntityId = entityId;
			this.Entity = entity;
			this.Actor = actor;
		}

		// Token: 0x06022341 RID: 140097 RVA: 0x009AFA05 File Offset: 0x009ADC05
		public bool IsValid()
		{
			return this.EntityId != 0L && this.Entity != null && this.Actor != null;
		}

		// Token: 0x06022342 RID: 140098 RVA: 0x009AFA26 File Offset: 0x009ADC26
		[return: Nullable(1)]
		public static LoadActorInfo Create(long entityId, Entity entity = null, AActor actor = null)
		{
			return new LoadActorInfo(entityId, entity, actor);
		}

		// Token: 0x04012D49 RID: 77129
		private const long zero = 0L;

		// Token: 0x04012D4A RID: 77130
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly LoadActorInfo Undefined = new LoadActorInfo(0L, null, null);

		// Token: 0x04012D4B RID: 77131
		public readonly long EntityId;

		// Token: 0x04012D4C RID: 77132
		public readonly Entity Entity;

		// Token: 0x04012D4D RID: 77133
		public readonly AActor Actor;
	}
}
