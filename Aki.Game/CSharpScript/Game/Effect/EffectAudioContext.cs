using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x020063E2 RID: 25570
	public class EffectAudioContext : EffectContext
	{
		// Token: 0x0603DF9E RID: 253854 RVA: 0x011FCA70 File Offset: 0x011FAC70
		[NullableContext(1)]
		public override void ToKuroEffectContext(FKuroEffectContext context)
		{
			base.ToKuroEffectContext(context);
			FKuroEffectAudioContext fkuroEffectAudioContext = context as FKuroEffectAudioContext;
			if (fkuroEffectAudioContext != null)
			{
				fkuroEffectAudioContext.FromPrimaryRole = this.FromPrimaryRole;
			}
		}

		// Token: 0x04020E4F RID: 134735
		public bool FromPrimaryRole;
	}
}
