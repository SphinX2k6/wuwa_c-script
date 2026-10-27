using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02007158 RID: 29016
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalDark : BuffEffect
	{
		// Token: 0x06046D4C RID: 290124 RVA: 0x011D9BD7 File Offset: 0x011D7DD7
		public AbnormalDark(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
		{
		}

		// Token: 0x06046D4D RID: 290125 RVA: 0x011D9BE6 File Offset: 0x011D7DE6
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}

		// Token: 0x06046D4E RID: 290126 RVA: 0x011D9BE9 File Offset: 0x011D7DE9
		public override void OnPeriodCallback()
		{
		}
	}
}
