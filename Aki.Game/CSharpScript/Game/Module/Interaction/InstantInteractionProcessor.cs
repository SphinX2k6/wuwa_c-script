using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x02005847 RID: 22599
	public class InstantInteractionProcessor : InteractionProcessor
	{
		// Token: 0x06039717 RID: 235287 RVA: 0x00DA20FA File Offset: 0x00DA02FA
		[NullableContext(2)]
		public InstantInteractionProcessor(Entity entity, int index) : base(entity, index, EInteractionType.Instant)
		{
		}

		// Token: 0x06039718 RID: 235288 RVA: 0x00DA2105 File Offset: 0x00DA0305
		public override void OnPress()
		{
		}

		// Token: 0x06039719 RID: 235289 RVA: 0x00DA2107 File Offset: 0x00DA0307
		public override void OnRelease()
		{
			base.TriggerComplete();
		}

		// Token: 0x0603971A RID: 235290 RVA: 0x00DA210F File Offset: 0x00DA030F
		public override void OnReset()
		{
		}
	}
}
