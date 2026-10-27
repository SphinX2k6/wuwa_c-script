using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Pawn.Controllers
{
	// Token: 0x02007065 RID: 28773
	[NullableContext(1)]
	[Nullable(0)]
	public class InteractEntity
	{
		// Token: 0x06046074 RID: 286836 RVA: 0x01174C7C File Offset: 0x01172E7C
		public InteractEntity(Entity entity)
		{
			this.Entity = entity;
			this.EntityId = ((entity != null) ? new int?(entity.Id) : null);
			this.IsAdvice = (entity.GetComponent<CreatureDataComponent>().GetAdviceInfo() != null);
			this.ActorComp = entity.GetComponent<BaseActorComponent>();
			this.DirectOptionInstanceIds = new List<int>();
			this.DirectOptionNames = new List<string>();
		}

		// Token: 0x17009BFB RID: 39931
		// (get) Token: 0x06046075 RID: 286837 RVA: 0x01174D18 File Offset: 0x01172F18
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

		// Token: 0x06046076 RID: 286838 RVA: 0x01174D94 File Offset: 0x01172F94
		public Entity GetEntity()
		{
			return this.Entity;
		}

		// Token: 0x04024A92 RID: 150162
		private const int AdvicePriority = -100;

		// Token: 0x04024A93 RID: 150163
		private const int MinPriority = -9999;

		// Token: 0x04024A94 RID: 150164
		public readonly bool IsAdvice;

		// Token: 0x04024A95 RID: 150165
		[Nullable(2)]
		private readonly Entity Entity;

		// Token: 0x04024A96 RID: 150166
		[Nullable(2)]
		private readonly BaseActorComponent ActorComp;

		// Token: 0x04024A97 RID: 150167
		public int? EntityId;

		// Token: 0x04024A98 RID: 150168
		public float InteractRange;

		// Token: 0x04024A99 RID: 150169
		private int PriorityInternal;

		// Token: 0x04024A9A RID: 150170
		public List<int> DirectOptionInstanceIds = new List<int>();

		// Token: 0x04024A9B RID: 150171
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<string> DirectOptionNames = new List<string>();

		// Token: 0x04024A9C RID: 150172
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public List<string> DirectOptionConditionIcon = new List<string>();

		// Token: 0x04024A9D RID: 150173
		public List<bool> DirectOptionGray = new List<bool>();
	}
}
