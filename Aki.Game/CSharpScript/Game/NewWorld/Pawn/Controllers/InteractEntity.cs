using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x020061E6 RID: 25062
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractEntity
	{
		// Token: 0x0603C26F RID: 246383 RVA: 0x0111E840 File Offset: 0x0111CA40
		public InteractEntity(Entity entity)
		{
			this.Entity = entity;
			this.EntityId = ((entity != null) ? new int?(entity.Id) : null);
			this.IsAdvice = (entity.GetComponent<CreatureDataComponent>().GetAdviceInfo() != null);
			this.ActorComp = entity.GetComponent<BaseActorComponent>();
			this.DirectOptionInstanceIds = new List<int>();
			this.DirectOptionNames = new List<string>();
		}

		// Token: 0x17007181 RID: 29057
		// (get) Token: 0x0603C270 RID: 246384 RVA: 0x0111E8DC File Offset: 0x0111CADC
		public int Priority
		{
			get
			{
				if (this.Entity == null)
				{
					return -9999;
				}
				if (this.IsAdvice)
				{
					Vector actorLocationProxy = this.ActorComp.ActorLocationProxy;
					Vector actorLocationProxy2 = Global.BaseCharacter.CharacterActorComponent.ActorLocationProxy;
					double num = Vector.Distance(actorLocationProxy, actorLocationProxy2);
					this.PriorityInternal = (int)(MathCommon.Clamp(num / (double)this.InteractRange, 0.0, 1.0) * -100.0);
				}
				return this.PriorityInternal;
			}
		}

		// Token: 0x0603C271 RID: 246385 RVA: 0x0111E958 File Offset: 0x0111CB58
		public Entity GetEntity()
		{
			return this.Entity;
		}

		// Token: 0x0401FD48 RID: 130376
		private const int AdvicePriority = -100;

		// Token: 0x0401FD49 RID: 130377
		private const int MinPriority = -9999;

		// Token: 0x0401FD4A RID: 130378
		public readonly bool IsAdvice;

		// Token: 0x0401FD4B RID: 130379
		[Nullable(2)]
		private readonly Entity Entity;

		// Token: 0x0401FD4C RID: 130380
		[Nullable(2)]
		private readonly BaseActorComponent ActorComp;

		// Token: 0x0401FD4D RID: 130381
		public int? EntityId;

		// Token: 0x0401FD4E RID: 130382
		public float InteractRange;

		// Token: 0x0401FD4F RID: 130383
		private int PriorityInternal;

		// Token: 0x0401FD50 RID: 130384
		public List<int> DirectOptionInstanceIds = new List<int>();

		// Token: 0x0401FD51 RID: 130385
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<string> DirectOptionNames = new List<string>();

		// Token: 0x0401FD52 RID: 130386
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<string> DirectOptionConditionIcon = new List<string>();

		// Token: 0x0401FD53 RID: 130387
		public List<bool> DirectOptionGray = new List<bool>();
	}
}
