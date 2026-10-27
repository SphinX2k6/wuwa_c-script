using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component.Abilities.ExtraEffect
{
	// Token: 0x02007155 RID: 29013
	[NullableContext(1)]
	[Nullable(0)]
	public class AbnormalFire : BuffEffect
	{
		// Token: 0x06046D45 RID: 290117 RVA: 0x011D9BAB File Offset: 0x011D7DAB
		public AbnormalFire(int activeHandleId, int index, RequireAndLimits requireAndLimits, BaseBuffComponent ownerBuffComponent, [Nullable(2)] CharacterBuffComponent instigatorBuffComponent) : base(activeHandleId, index, requireAndLimits, ownerBuffComponent, instigatorBuffComponent)
		{
		}

		// Token: 0x06046D46 RID: 290118 RVA: 0x011D9BBA File Offset: 0x011D7DBA
		[return: Nullable(2)]
		public override object OnExecute(params object[] args)
		{
			return null;
		}

		// Token: 0x06046D47 RID: 290119 RVA: 0x011D9BBD File Offset: 0x011D7DBD
		public override void OnPeriodCallback()
		{
		}
	}
}
