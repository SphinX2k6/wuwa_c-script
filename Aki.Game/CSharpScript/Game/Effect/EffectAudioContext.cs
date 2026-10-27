using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Effect
{
	// Token: 0x02007263 RID: 29283
	public class EffectAudioContext : EffectContext
	{
		// Token: 0x06047BE6 RID: 293862 RVA: 0x0125C16C File Offset: 0x0125A36C
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

		// Token: 0x04025B91 RID: 154513
		public bool FromPrimaryRole;
	}
}
