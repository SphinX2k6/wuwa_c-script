using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Interaction
{
	// Token: 0x0200481F RID: 18463
	public class InstantInteractionProcessor : InteractionProcessor
	{
		// Token: 0x0602E62E RID: 189998 RVA: 0x00CF0DD2 File Offset: 0x00CEEFD2
		[NullableContext(2)]
		public InstantInteractionProcessor(Entity entity, int index) : base(entity, index, EInteractionType.Instant)
		{
		}

		// Token: 0x0602E62F RID: 189999 RVA: 0x00CF0DDD File Offset: 0x00CEEFDD
		public override void OnPress()
		{
		}

		// Token: 0x0602E630 RID: 190000 RVA: 0x00CF0DDF File Offset: 0x00CEEFDF
		public override void OnRelease()
		{
			base.TriggerComplete();
		}

		// Token: 0x0602E631 RID: 190001 RVA: 0x00CF0DE7 File Offset: 0x00CEEFE7
		public override void OnReset()
		{
		}
	}
}
